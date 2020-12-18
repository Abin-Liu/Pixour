
namespace Pixour
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.lblPropmt = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtGRBValue = new System.Windows.Forms.TextBox();
			this.chkLowercase = new System.Windows.Forms.CheckBox();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.btnCopy = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pixourCtrl1 = new PixourCtrl.PixourCtrl();
			this.chkHex = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// lblPropmt
			// 
			this.lblPropmt.ForeColor = System.Drawing.SystemColors.Highlight;
			this.lblPropmt.Location = new System.Drawing.Point(17, 276);
			this.lblPropmt.Name = "lblPropmt";
			this.lblPropmt.Size = new System.Drawing.Size(260, 23);
			this.lblPropmt.TabIndex = 1;
			this.lblPropmt.Text = "label1";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(292, 114);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "RGB values:";
			// 
			// txtGRBValue
			// 
			this.txtGRBValue.BackColor = System.Drawing.SystemColors.Window;
			this.txtGRBValue.Location = new System.Drawing.Point(295, 130);
			this.txtGRBValue.Name = "txtGRBValue";
			this.txtGRBValue.ReadOnly = true;
			this.txtGRBValue.Size = new System.Drawing.Size(182, 20);
			this.txtGRBValue.TabIndex = 3;
			// 
			// chkLowercase
			// 
			this.chkLowercase.AutoSize = true;
			this.chkLowercase.Location = new System.Drawing.Point(294, 188);
			this.chkLowercase.Name = "chkLowercase";
			this.chkLowercase.Size = new System.Drawing.Size(81, 17);
			this.chkLowercase.TabIndex = 6;
			this.chkLowercase.Text = "Lower case";
			this.chkLowercase.UseVisualStyleBackColor = true;
			this.chkLowercase.CheckedChanged += new System.EventHandler(this.chkLowercase_CheckedChanged);
			// 
			// btnCopy
			// 
			this.btnCopy.Image = global::Pixour.Properties.Resources.Copy;
			this.btnCopy.Location = new System.Drawing.Point(483, 128);
			this.btnCopy.Name = "btnCopy";
			this.btnCopy.Size = new System.Drawing.Size(26, 23);
			this.btnCopy.TabIndex = 4;
			this.btnCopy.UseVisualStyleBackColor = true;
			this.btnCopy.Click += new System.EventHandler(this.btnCopyDec_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Gray;
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Location = new System.Drawing.Point(295, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(80, 80);
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// pixourCtrl1
			// 
			this.pixourCtrl1.BackColor = System.Drawing.Color.Gray;
			this.pixourCtrl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pixourCtrl1.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.pixourCtrl1.DefaultColor = System.Drawing.Color.Gray;
			this.pixourCtrl1.Fetching = true;
			this.pixourCtrl1.Location = new System.Drawing.Point(17, 12);
			this.pixourCtrl1.Name = "pixourCtrl1";
			this.pixourCtrl1.OnColorPick = null;
			this.pixourCtrl1.Size = new System.Drawing.Size(260, 260);
			this.pixourCtrl1.TabIndex = 0;
			// 
			// chkHex
			// 
			this.chkHex.AutoSize = true;
			this.chkHex.Location = new System.Drawing.Point(295, 165);
			this.chkHex.Name = "chkHex";
			this.chkHex.Size = new System.Drawing.Size(87, 17);
			this.chkHex.TabIndex = 5;
			this.chkHex.Text = "Hexadecimal";
			this.chkHex.UseVisualStyleBackColor = true;
			this.chkHex.CheckedChanged += new System.EventHandler(this.chkHex_CheckedChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(523, 298);
			this.Controls.Add(this.chkHex);
			this.Controls.Add(this.chkLowercase);
			this.Controls.Add(this.btnCopy);
			this.Controls.Add(this.txtGRBValue);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.lblPropmt);
			this.Controls.Add(this.pixourCtrl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "Pixour";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private PixourCtrl.PixourCtrl pixourCtrl1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label lblPropmt;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtGRBValue;
		private System.Windows.Forms.Button btnCopy;
		private System.Windows.Forms.CheckBox chkLowercase;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.CheckBox chkHex;
	}
}

