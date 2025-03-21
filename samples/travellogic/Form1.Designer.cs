namespace AqLAVISA_Sample
{
	partial class Form1
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
			this.raAppTL = new System.Windows.Forms.RadioButton();
			this.raAppTB = new System.Windows.Forms.RadioButton();
			this.raAppBF_LA3K = new System.Windows.Forms.RadioButton();
			this.raAppMSO = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.bnSend = new System.Windows.Forms.Button();
			this.edCmd = new System.Windows.Forms.TextBox();
			this.ltCmdSample = new System.Windows.Forms.ListBox();
			this.bnConnect = new System.Windows.Forms.Button();
			this.bnDisconnect = new System.Windows.Forms.Button();
			this.ltResult = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// raAppTL
			// 
			this.raAppTL.AutoSize = true;
			this.raAppTL.Location = new System.Drawing.Point(23, 24);
			this.raAppTL.Name = "raAppTL";
			this.raAppTL.Size = new System.Drawing.Size(79, 19);
			this.raAppTL.TabIndex = 0;
			this.raAppTL.TabStop = true;
			this.raAppTL.Text = "APP_TL";
			this.raAppTL.UseVisualStyleBackColor = true;
			// 
			// raAppTB
			// 
			this.raAppTB.AutoSize = true;
			this.raAppTB.Location = new System.Drawing.Point(23, 49);
			this.raAppTB.Name = "raAppTB";
			this.raAppTB.Size = new System.Drawing.Size(79, 19);
			this.raAppTB.TabIndex = 1;
			this.raAppTB.TabStop = true;
			this.raAppTB.Text = "APP_TB";
			this.raAppTB.UseVisualStyleBackColor = true;
			// 
			// raAppBF_LA3K
			// 
			this.raAppBF_LA3K.AutoSize = true;
			this.raAppBF_LA3K.Location = new System.Drawing.Point(23, 74);
			this.raAppBF_LA3K.Name = "raAppBF_LA3K";
			this.raAppBF_LA3K.Size = new System.Drawing.Size(121, 19);
			this.raAppBF_LA3K.TabIndex = 2;
			this.raAppBF_LA3K.TabStop = true;
			this.raAppBF_LA3K.Text = "APP_BF_LA3K";
			this.raAppBF_LA3K.UseVisualStyleBackColor = true;
			// 
			// raAppMSO
			// 
			this.raAppMSO.AutoSize = true;
			this.raAppMSO.Location = new System.Drawing.Point(23, 99);
			this.raAppMSO.Name = "raAppMSO";
			this.raAppMSO.Size = new System.Drawing.Size(92, 19);
			this.raAppMSO.TabIndex = 3;
			this.raAppMSO.TabStop = true;
			this.raAppMSO.Text = "APP_MSO";
			this.raAppMSO.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.raAppMSO);
			this.groupBox1.Controls.Add(this.raAppBF_LA3K);
			this.groupBox1.Controls.Add(this.raAppTB);
			this.groupBox1.Controls.Add(this.raAppTL);
			this.groupBox1.Location = new System.Drawing.Point(27, 17);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(189, 128);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "App Selection";
			// 
			// bnSend
			// 
			this.bnSend.Location = new System.Drawing.Point(349, 323);
			this.bnSend.Name = "bnSend";
			this.bnSend.Size = new System.Drawing.Size(75, 23);
			this.bnSend.TabIndex = 5;
			this.bnSend.Text = "Send";
			this.bnSend.UseVisualStyleBackColor = true;
			this.bnSend.Click += new System.EventHandler(this.bnSend_Click);
			// 
			// edCmd
			// 
			this.edCmd.Location = new System.Drawing.Point(27, 290);
			this.edCmd.Name = "edCmd";
			this.edCmd.Size = new System.Drawing.Size(397, 25);
			this.edCmd.TabIndex = 7;
			// 
			// ltCmdSample
			// 
			this.ltCmdSample.FormattingEnabled = true;
			this.ltCmdSample.ItemHeight = 15;
			this.ltCmdSample.Items.AddRange(new object[] {
            "*STB?",
            "*FILE:SAVE -WAVEFILE D:\\Wavefile.bfw",
            "*FILE:SAVE -TRANSTEXT D:\\Transfile.txt",
            "*LA:CAPTURE:START",
            "*LA:CAPTURE:STOP"});
			this.ltCmdSample.Location = new System.Drawing.Point(27, 171);
			this.ltCmdSample.Name = "ltCmdSample";
			this.ltCmdSample.Size = new System.Drawing.Size(397, 94);
			this.ltCmdSample.TabIndex = 8;
			this.ltCmdSample.DoubleClick += new System.EventHandler(this.ltCmdSample_DoubleClick);
			// 
			// bnConnect
			// 
			this.bnConnect.Location = new System.Drawing.Point(242, 17);
			this.bnConnect.Name = "bnConnect";
			this.bnConnect.Size = new System.Drawing.Size(75, 23);
			this.bnConnect.TabIndex = 5;
			this.bnConnect.Text = "Connect";
			this.bnConnect.UseVisualStyleBackColor = true;
			this.bnConnect.Click += new System.EventHandler(this.bnConnect_Click);
			// 
			// bnDisconnect
			// 
			this.bnDisconnect.Location = new System.Drawing.Point(242, 64);
			this.bnDisconnect.Name = "bnDisconnect";
			this.bnDisconnect.Size = new System.Drawing.Size(75, 23);
			this.bnDisconnect.TabIndex = 5;
			this.bnDisconnect.Text = "Disconnect";
			this.bnDisconnect.UseVisualStyleBackColor = true;
			this.bnDisconnect.Click += new System.EventHandler(this.bnDisconnect_Click);
			// 
			// ltResult
			// 
			this.ltResult.FormattingEnabled = true;
			this.ltResult.ItemHeight = 15;
			this.ltResult.Location = new System.Drawing.Point(455, 41);
			this.ltResult.Name = "ltResult";
			this.ltResult.Size = new System.Drawing.Size(445, 304);
			this.ltResult.TabIndex = 9;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(452, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 15);
			this.label1.TabIndex = 10;
			this.label1.Text = "Result";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(923, 358);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ltResult);
			this.Controls.Add(this.ltCmdSample);
			this.Controls.Add(this.edCmd);
			this.Controls.Add(this.bnDisconnect);
			this.Controls.Add(this.bnConnect);
			this.Controls.Add(this.bnSend);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RadioButton raAppTL;
		private System.Windows.Forms.RadioButton raAppTB;
		private System.Windows.Forms.RadioButton raAppBF_LA3K;
		private System.Windows.Forms.RadioButton raAppMSO;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button bnSend;
		private System.Windows.Forms.TextBox edCmd;
		private System.Windows.Forms.ListBox ltCmdSample;
		private System.Windows.Forms.Button bnConnect;
		private System.Windows.Forms.Button bnDisconnect;
		private System.Windows.Forms.ListBox ltResult;
		private System.Windows.Forms.Label label1;
	}
}

