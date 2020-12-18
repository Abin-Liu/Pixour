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
		bool m_hex;
		bool m_lower;

		public MainForm()
		{
			InitializeComponent();

			RegistryHelper reg = new RegistryHelper();

			reg.Open("Abin", ProductName);
			m_hex = reg.ReadBool("Hexadecimal", false);
			m_lower = reg.ReadBool("Lower Case", false);
			reg.Close();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			toolTip1.SetToolTip(pixourCtrl1, "Click on a pixel to show details");
			toolTip1.SetToolTip(btnCopy, "Copy to clipboard");			

			chkHex.Checked = m_hex;
			chkLowercase.Checked = m_lower;
			chkLowercase.Visible = m_hex;

			pixourCtrl1.OnColorPick = OnColorPick;
			OnStop();
			timer1.Enabled = true;
		}

		private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			RegistryHelper reg = new RegistryHelper();
			reg.Open("Abin", ProductName, true);
			reg.WriteBool("Hexadecimal", m_hex);
			reg.WriteBool("Lower Case", m_lower);
			reg.Close();
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

		void OnColorPick(Color color)
		{			
			m_color = color;
			pictureBox1.BackColor = color;
			UpdateRGBValues();
		}

		void UpdateRGBValues()
		{
			string text;
			if (m_hex)
			{
				if (m_lower)
				{
					text = string.Format("{0:x2}{1:x2}{2:x2}", m_color.R, m_color.G, m_color.B);
				}
				else
				{
					text = string.Format("{0:X2}{1:X2}{2:X2}", m_color.R, m_color.G, m_color.B);
				}				
			}
			else
			{
				text = string.Format("{0}, {1}, {2}", m_color.R, m_color.G, m_color.B);
			}
			
			txtGRBValue.Text = text;
		}

		private void chkHex_CheckedChanged(object sender, EventArgs e)
		{			
			m_hex = chkHex.Checked;			
			chkLowercase.Visible = m_hex;
			UpdateRGBValues();
		}

		private void chkLowercase_CheckedChanged(object sender, EventArgs e)
		{
			m_lower = chkLowercase.Checked;
			UpdateRGBValues();
		}

		private void btnCopyDec_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(txtGRBValue.Text);
		}		
	}
}
