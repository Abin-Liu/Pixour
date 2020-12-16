using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Win32API;
using MFGLib;

namespace Pixour
{
	public partial class MainForm : Form
	{
		Color m_color;
		bool keydown = false;

		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			toolTip1.SetToolTip(pixourCtrl1, "Click on a pixel to show details");
			toolTip1.SetToolTip(btnCopyDec, "Copy to clipboard");
			toolTip1.SetToolTip(btnCopyHex, "Copy to clipboard");
			toolTip1.SetToolTip(chkLowercase, "Display hexadecimal RGB in lower case");

			RegistryHelper reg = new RegistryHelper();
			reg.Open("Abin", ProductName);
			chkLowercase.Checked = reg.ReadBool("Lower Case", false);
			reg.Close();

			pixourCtrl1.OnPixelClick = OnPixelClick;
			OnStop();
			timer1.Enabled = true;
		}
		
		private void timer1_Tick(object sender, EventArgs e)
		{
			bool wasDown = keydown;
			keydown = Input.IsKeyDown(Keys.ControlKey);
			if (!wasDown && keydown)
			{
				OnStart();
			}
			else if (wasDown && !keydown)
			{
				OnStop();
			}			
		}

		void OnStart()
		{
			this.Text = "Pixour - Started";
			lblPropmt.Text = "Release Ctrl keys to stop";
			pixourCtrl1.Fetching = true;
		}

		void OnStop()
		{
			this.Text = "Pixour - Stopped";
			lblPropmt.Text = "Hold Ctrl keys to start";
			pixourCtrl1.Fetching = false;
		}

		void OnPixelClick(int x, int y, Color color)
		{			
			m_color = color;
			pictureBox1.BackColor = color;
			UpdateRGBValues();
		}

		void UpdateRGBValues()
		{
			txtDecValue.Text = string.Format("{0}, {1}, {2}", m_color.R, m_color.G, m_color.B);

			string hex = string.Format("{0:X2}{1:X2}{2:X2}", m_color.R, m_color.G, m_color.B);
			if (chkLowercase.Checked)
			{
				hex = hex.ToLower();
			}
			txtHexValue.Text = hex;
		}

		private void chkLowercase_CheckedChanged(object sender, EventArgs e)
		{
			RegistryHelper reg = new RegistryHelper();
			reg.Open("Abin", ProductName, true);
			reg.WriteBool("Lower Case", chkLowercase.Checked);
			reg.Close();

			UpdateRGBValues();
		}

		private void btnCopyDec_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(txtDecValue.Text);
		}

		private void btnCopyHex_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(txtHexValue.Text);
		}
	}
}
