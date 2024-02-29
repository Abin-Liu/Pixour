using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AbinLibs;

namespace Pixour
{
	public partial class MainForm : Form
	{
		Color m_color;
		bool m_locked = false;
		bool m_hex;
		bool m_lower;

		public MainForm()
		{
			InitializeComponent();

			RegistryHelper reg = new RegistryHelper();

			reg.Open("Abin", ProductName);
			m_locked = reg.ReadBool("Locked", false);
			m_hex = reg.ReadBool("Hexadecimal", false);
			m_lower = reg.ReadBool("Lower Case", false);
			reg.Close();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			toolTip1.SetToolTip(btnLock, "Click to lock/unlock");
			toolTip1.SetToolTip(btnCopy, "Copy to clipboard");			
			chkHex.Checked = m_hex;
			chkLowercase.Checked = m_lower;
			chkLowercase.Visible = m_hex;

			if (m_locked)
			{
				OnLock();
			}
			else
			{
				OnUnlock();
			}
		}

		private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			RegistryHelper reg = new RegistryHelper();
			reg.Open("Abin", ProductName, true);
			reg.WriteBool("Locked", m_locked);
			reg.WriteBool("Hexadecimal", m_hex);
			reg.WriteBool("Lower Case", m_lower);
			reg.Close();
		}

		private void btnLock_Click(object sender, EventArgs e)
		{
			m_locked = !m_locked;
			if (m_locked)
			{
				OnLock();
			}
			else
			{
				OnUnlock();
			}
		}

		void OnLock()
		{
			btnLock.Image = Properties.Resources.Locked;
			lblPropmt.Text = "Locked";
			timer1.Enabled = false;
		}

		void OnUnlock()
		{
			btnLock.Image = Properties.Resources.Unlocked;
			lblPropmt.Text = "Hold Ctrl keys to start";
			timer1.Enabled = true;
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			bool canFetch = (ModifierKeys & Keys.Control) == Keys.Control;
			if (canFetch)
			{
				lblPropmt.Text = "Release Ctrl keys to stop";
				FetchCursor();
			}
			else
			{
				lblPropmt.Text = "Hold Ctrl keys to start";
			}		
		}
		
		void FetchCursor()
		{
			var image = BitmapHelper.CaptureCursor(-16, -16, 32, 32);
			pixelBoard1.Image = image;
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

		private void pixelBoard1_SelectedPixelChanged(object sender, EventArgs e)
		{
			var data = pixelBoard1.SelectedPixel;
			if (data == null)
			{
				m_color = Color.Black;
			}
			else
			{
				m_color = data.Color;
			}

			pictureBox1.BackColor = data.Color;
			UpdateRGBValues();
		}
	}
}
