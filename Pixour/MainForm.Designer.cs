
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
			this.chkHex = new System.Windows.Forms.CheckBox();
			this.btnLock = new System.Windows.Forms.Button();
			this.btnCopy = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pixelBoard1 = new AbinLibs.Controls.PixelBoard();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// timer1
			// 
			this.timer1.Interval = 400;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// lblPropmt
			// 
			this.lblPropmt.ForeColor = System.Drawing.SystemColors.Highlight;
			this.lblPropmt.Location = new System.Drawing.Point(58, 346);
			this.lblPropmt.Name = "lblPropmt";
			this.lblPropmt.Size = new System.Drawing.Size(359, 23);
			this.lblPropmt.TabIndex = 2;
			this.lblPropmt.Text = "label1";
			this.lblPropmt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(350, 74);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "RGB values:";
			// 
			// txtGRBValue
			// 
			this.txtGRBValue.BackColor = System.Drawing.SystemColors.Window;
			this.txtGRBValue.Location = new System.Drawing.Point(350, 93);
			this.txtGRBValue.Name = "txtGRBValue";
			this.txtGRBValue.ReadOnly = true;
			this.txtGRBValue.Size = new System.Drawing.Size(182, 20);
			this.txtGRBValue.TabIndex = 4;
			// 
			// chkLowercase
			// 
			this.chkLowercase.AutoSize = true;
			this.chkLowercase.Location = new System.Drawing.Point(353, 151);
			this.chkLowercase.Name = "chkLowercase";
			this.chkLowercase.Size = new System.Drawing.Size(81, 17);
			this.chkLowercase.TabIndex = 7;
			this.chkLowercase.Text = "Lower case";
			this.chkLowercase.UseVisualStyleBackColor = true;
			this.chkLowercase.CheckedChanged += new System.EventHandler(this.chkLowercase_CheckedChanged);
			// 
			// chkHex
			// 
			this.chkHex.AutoSize = true;
			this.chkHex.Location = new System.Drawing.Point(353, 128);
			this.chkHex.Name = "chkHex";
			this.chkHex.Size = new System.Drawing.Size(87, 17);
			this.chkHex.TabIndex = 6;
			this.chkHex.Text = "Hexadecimal";
			this.chkHex.UseVisualStyleBackColor = true;
			this.chkHex.CheckedChanged += new System.EventHandler(this.chkHex_CheckedChanged);
			// 
			// btnLock
			// 
			this.btnLock.Image = global::Pixour.Properties.Resources.Unlocked;
			this.btnLock.Location = new System.Drawing.Point(23, 346);
			this.btnLock.Name = "btnLock";
			this.btnLock.Size = new System.Drawing.Size(26, 23);
			this.btnLock.TabIndex = 1;
			this.btnLock.UseVisualStyleBackColor = true;
			this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
			// 
			// btnCopy
			// 
			this.btnCopy.Image = global::Pixour.Properties.Resources.Copy;
			this.btnCopy.Location = new System.Drawing.Point(538, 92);
			this.btnCopy.Name = "btnCopy";
			this.btnCopy.Size = new System.Drawing.Size(26, 23);
			this.btnCopy.TabIndex = 5;
			this.btnCopy.UseVisualStyleBackColor = true;
			this.btnCopy.Click += new System.EventHandler(this.btnCopyDec_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Location = new System.Drawing.Point(350, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(32, 32);
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// pixelBoard1
			// 
			this.pixelBoard1.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.pixelBoard1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pixelBoard1.Image = null;
			this.pixelBoard1.Location = new System.Drawing.Point(12, 12);
			this.pixelBoard1.Name = "pixelBoard1";
			this.pixelBoard1.PixelSize = 10;
			this.pixelBoard1.SelectedPixel = null;
			this.pixelBoard1.SelectionColor = System.Drawing.Color.Yellow;
			this.pixelBoard1.Size = new System.Drawing.Size(320, 320);
			this.pixelBoard1.TabIndex = 0;
			this.pixelBoard1.SelectedPixelChanged += new System.EventHandler(this.pixelBoard1_SelectedPixelChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(580, 386);
			this.Controls.Add(this.pixelBoard1);
			this.Controls.Add(this.chkHex);
			this.Controls.Add(this.chkLowercase);
			this.Controls.Add(this.btnLock);
			this.Controls.Add(this.btnCopy);
			this.Controls.Add(this.txtGRBValue);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.lblPropmt);
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
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label lblPropmt;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtGRBValue;
		private System.Windows.Forms.Button btnCopy;
		private System.Windows.Forms.CheckBox chkLowercase;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.CheckBox chkHex;
		private System.Windows.Forms.Button btnLock;
		private AbinLibs.Controls.PixelBoard pixelBoard1;
	}
}

