
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
			this.label2 = new System.Windows.Forms.Label();
			this.txtDecValue = new System.Windows.Forms.TextBox();
			this.txtHexValue = new System.Windows.Forms.TextBox();
			this.chkLowercase = new System.Windows.Forms.CheckBox();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.btnCopyHex = new System.Windows.Forms.Button();
			this.btnCopyDec = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pixourCtrl1 = new PixourCtrl.PixourCtrl();
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
			this.label1.Size = new System.Drawing.Size(74, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Decimal RGB:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(292, 167);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(97, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Hexadecimal RGB:";
			// 
			// txtDecValue
			// 
			this.txtDecValue.BackColor = System.Drawing.SystemColors.Window;
			this.txtDecValue.Location = new System.Drawing.Point(295, 130);
			this.txtDecValue.Name = "txtDecValue";
			this.txtDecValue.ReadOnly = true;
			this.txtDecValue.Size = new System.Drawing.Size(182, 20);
			this.txtDecValue.TabIndex = 3;
			// 
			// txtHexValue
			// 
			this.txtHexValue.BackColor = System.Drawing.SystemColors.Window;
			this.txtHexValue.Location = new System.Drawing.Point(295, 183);
			this.txtHexValue.Name = "txtHexValue";
			this.txtHexValue.ReadOnly = true;
			this.txtHexValue.Size = new System.Drawing.Size(182, 20);
			this.txtHexValue.TabIndex = 6;
			// 
			// chkLowercase
			// 
			this.chkLowercase.AutoSize = true;
			this.chkLowercase.Location = new System.Drawing.Point(295, 209);
			this.chkLowercase.Name = "chkLowercase";
			this.chkLowercase.Size = new System.Drawing.Size(81, 17);
			this.chkLowercase.TabIndex = 8;
			this.chkLowercase.Text = "Lower case";
			this.chkLowercase.UseVisualStyleBackColor = true;
			this.chkLowercase.CheckedChanged += new System.EventHandler(this.chkLowercase_CheckedChanged);
			// 
			// btnCopyHex
			// 
			this.btnCopyHex.Image = global::Pixour.Properties.Resources.Copy;
			this.btnCopyHex.Location = new System.Drawing.Point(483, 181);
			this.btnCopyHex.Name = "btnCopyHex";
			this.btnCopyHex.Size = new System.Drawing.Size(26, 23);
			this.btnCopyHex.TabIndex = 7;
			this.btnCopyHex.UseVisualStyleBackColor = true;
			this.btnCopyHex.Click += new System.EventHandler(this.btnCopyHex_Click);
			// 
			// btnCopyDec
			// 
			this.btnCopyDec.Image = global::Pixour.Properties.Resources.Copy;
			this.btnCopyDec.Location = new System.Drawing.Point(483, 128);
			this.btnCopyDec.Name = "btnCopyDec";
			this.btnCopyDec.Size = new System.Drawing.Size(26, 23);
			this.btnCopyDec.TabIndex = 4;
			this.btnCopyDec.UseVisualStyleBackColor = true;
			this.btnCopyDec.Click += new System.EventHandler(this.btnCopyDec_Click);
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
			this.pixourCtrl1.OnPixelClick = null;
			this.pixourCtrl1.Size = new System.Drawing.Size(260, 260);
			this.pixourCtrl1.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(523, 298);
			this.Controls.Add(this.chkLowercase);
			this.Controls.Add(this.btnCopyHex);
			this.Controls.Add(this.txtHexValue);
			this.Controls.Add(this.btnCopyDec);
			this.Controls.Add(this.txtDecValue);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.lblPropmt);
			this.Controls.Add(this.pixourCtrl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "Pixour";
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
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtDecValue;
		private System.Windows.Forms.Button btnCopyDec;
		private System.Windows.Forms.TextBox txtHexValue;
		private System.Windows.Forms.Button btnCopyHex;
		private System.Windows.Forms.CheckBox chkLowercase;
		private System.Windows.Forms.ToolTip toolTip1;
	}
}

