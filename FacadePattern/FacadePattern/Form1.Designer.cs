namespace FacadePattern
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.m_pbXbox = new System.Windows.Forms.PictureBox();
            this.m_pbPS4 = new System.Windows.Forms.PictureBox();
            this.m_btnTV = new System.Windows.Forms.Button();
            this.m_btnHDMI1 = new System.Windows.Forms.Button();
            this.m_btnHDMI2 = new System.Windows.Forms.Button();
            this.m_lblCO = new System.Windows.Forms.Label();
            this.m_lblOutput = new System.Windows.Forms.Label();
            this.m_CBXbox = new System.Windows.Forms.ComboBox();
            this.m_CBPS4 = new System.Windows.Forms.ComboBox();
            this.m_lblGame = new System.Windows.Forms.Label();
            this.m_pbTV = new System.Windows.Forms.PictureBox();
            this.m_btnVolumeUp = new System.Windows.Forms.Button();
            this.m_btnVolumeDown = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.m_lblVolume = new System.Windows.Forms.Label();
            this.m_btnChannelUp = new System.Windows.Forms.Button();
            this.m_lblChannelDown = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.m_lblChannel = new System.Windows.Forms.Label();
            this.m_lblPower = new System.Windows.Forms.Label();
            this.m_lblTV = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.m_lblTVPower = new System.Windows.Forms.Label();
            this.m_lblXboxPower = new System.Windows.Forms.Label();
            this.m_lblPS4Power = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.m_pbXbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_pbPS4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_pbTV)).BeginInit();
            this.SuspendLayout();
            // 
            // m_pbXbox
            // 
            this.m_pbXbox.Image = ((System.Drawing.Image)(resources.GetObject("m_pbXbox.Image")));
            this.m_pbXbox.Location = new System.Drawing.Point(639, 59);
            this.m_pbXbox.Name = "m_pbXbox";
            this.m_pbXbox.Size = new System.Drawing.Size(128, 113);
            this.m_pbXbox.TabIndex = 0;
            this.m_pbXbox.TabStop = false;
            this.m_pbXbox.Click += new System.EventHandler(this.m_pbXbox_Click);
            // 
            // m_pbPS4
            // 
            this.m_pbPS4.Image = ((System.Drawing.Image)(resources.GetObject("m_pbPS4.Image")));
            this.m_pbPS4.Location = new System.Drawing.Point(801, 49);
            this.m_pbPS4.Name = "m_pbPS4";
            this.m_pbPS4.Size = new System.Drawing.Size(162, 141);
            this.m_pbPS4.TabIndex = 1;
            this.m_pbPS4.TabStop = false;
            this.m_pbPS4.Click += new System.EventHandler(this.m_pbPS4_Click);
            this.m_pbPS4.DoubleClick += new System.EventHandler(this.m_pbPS4_DoubleClick);
            // 
            // m_btnTV
            // 
            this.m_btnTV.Location = new System.Drawing.Point(45, 36);
            this.m_btnTV.Name = "m_btnTV";
            this.m_btnTV.Size = new System.Drawing.Size(167, 48);
            this.m_btnTV.TabIndex = 2;
            this.m_btnTV.Text = "Television";
            this.m_btnTV.UseVisualStyleBackColor = true;
            this.m_btnTV.Click += new System.EventHandler(this.m_btnTV_Click);
            // 
            // m_btnHDMI1
            // 
            this.m_btnHDMI1.Location = new System.Drawing.Point(45, 113);
            this.m_btnHDMI1.Name = "m_btnHDMI1";
            this.m_btnHDMI1.Size = new System.Drawing.Size(167, 50);
            this.m_btnHDMI1.TabIndex = 3;
            this.m_btnHDMI1.Text = "HDMI 1";
            this.m_btnHDMI1.UseVisualStyleBackColor = true;
            this.m_btnHDMI1.Click += new System.EventHandler(this.m_btnHDMI1_Click);
            // 
            // m_btnHDMI2
            // 
            this.m_btnHDMI2.Location = new System.Drawing.Point(45, 188);
            this.m_btnHDMI2.Name = "m_btnHDMI2";
            this.m_btnHDMI2.Size = new System.Drawing.Size(167, 53);
            this.m_btnHDMI2.TabIndex = 4;
            this.m_btnHDMI2.Text = "HDMI 2";
            this.m_btnHDMI2.UseVisualStyleBackColor = true;
            this.m_btnHDMI2.Click += new System.EventHandler(this.m_btnHDMI2_Click);
            // 
            // m_lblCO
            // 
            this.m_lblCO.AutoSize = true;
            this.m_lblCO.Location = new System.Drawing.Point(268, 188);
            this.m_lblCO.Name = "m_lblCO";
            this.m_lblCO.Size = new System.Drawing.Size(159, 25);
            this.m_lblCO.TabIndex = 5;
            this.m_lblCO.Text = "Current Output:";
            // 
            // m_lblOutput
            // 
            this.m_lblOutput.AutoSize = true;
            this.m_lblOutput.Location = new System.Drawing.Point(443, 188);
            this.m_lblOutput.Name = "m_lblOutput";
            this.m_lblOutput.Size = new System.Drawing.Size(110, 25);
            this.m_lblOutput.TabIndex = 6;
            this.m_lblOutput.Text = "Television";
            // 
            // m_CBXbox
            // 
            this.m_CBXbox.Enabled = false;
            this.m_CBXbox.FormattingEnabled = true;
            this.m_CBXbox.Location = new System.Drawing.Point(592, 240);
            this.m_CBXbox.Name = "m_CBXbox";
            this.m_CBXbox.Size = new System.Drawing.Size(193, 33);
            this.m_CBXbox.TabIndex = 7;
            // 
            // m_CBPS4
            // 
            this.m_CBPS4.Enabled = false;
            this.m_CBPS4.FormattingEnabled = true;
            this.m_CBPS4.Location = new System.Drawing.Point(801, 240);
            this.m_CBPS4.Name = "m_CBPS4";
            this.m_CBPS4.Size = new System.Drawing.Size(191, 33);
            this.m_CBPS4.TabIndex = 8;
            // 
            // m_lblGame
            // 
            this.m_lblGame.AutoSize = true;
            this.m_lblGame.Location = new System.Drawing.Point(381, 240);
            this.m_lblGame.Name = "m_lblGame";
            this.m_lblGame.Size = new System.Drawing.Size(133, 25);
            this.m_lblGame.TabIndex = 9;
            this.m_lblGame.Text = "Open Game:";
            // 
            // m_pbTV
            // 
            this.m_pbTV.Image = ((System.Drawing.Image)(resources.GetObject("m_pbTV.Image")));
            this.m_pbTV.Location = new System.Drawing.Point(430, 59);
            this.m_pbTV.Name = "m_pbTV";
            this.m_pbTV.Size = new System.Drawing.Size(139, 123);
            this.m_pbTV.TabIndex = 10;
            this.m_pbTV.TabStop = false;
            this.m_pbTV.Click += new System.EventHandler(this.m_pbTV_Click);
            // 
            // m_btnVolumeUp
            // 
            this.m_btnVolumeUp.Location = new System.Drawing.Point(77, 299);
            this.m_btnVolumeUp.Name = "m_btnVolumeUp";
            this.m_btnVolumeUp.Size = new System.Drawing.Size(127, 53);
            this.m_btnVolumeUp.TabIndex = 11;
            this.m_btnVolumeUp.Text = "+";
            this.m_btnVolumeUp.UseVisualStyleBackColor = true;
            this.m_btnVolumeUp.Click += new System.EventHandler(this.m_btnVolumeUp_Click);
            // 
            // m_btnVolumeDown
            // 
            this.m_btnVolumeDown.Location = new System.Drawing.Point(77, 349);
            this.m_btnVolumeDown.Name = "m_btnVolumeDown";
            this.m_btnVolumeDown.Size = new System.Drawing.Size(127, 52);
            this.m_btnVolumeDown.TabIndex = 12;
            this.m_btnVolumeDown.Text = "-";
            this.m_btnVolumeDown.UseVisualStyleBackColor = true;
            this.m_btnVolumeDown.Click += new System.EventHandler(this.m_btnVolumeDown_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Volume";
            // 
            // m_lblVolume
            // 
            this.m_lblVolume.AutoSize = true;
            this.m_lblVolume.Location = new System.Drawing.Point(150, 271);
            this.m_lblVolume.Name = "m_lblVolume";
            this.m_lblVolume.Size = new System.Drawing.Size(24, 25);
            this.m_lblVolume.TabIndex = 14;
            this.m_lblVolume.Text = "0";
            // 
            // m_btnChannelUp
            // 
            this.m_btnChannelUp.Location = new System.Drawing.Point(237, 299);
            this.m_btnChannelUp.Name = "m_btnChannelUp";
            this.m_btnChannelUp.Size = new System.Drawing.Size(126, 53);
            this.m_btnChannelUp.TabIndex = 15;
            this.m_btnChannelUp.Text = "+";
            this.m_btnChannelUp.UseVisualStyleBackColor = true;
            this.m_btnChannelUp.Click += new System.EventHandler(this.m_btnChannelUp_Click);
            // 
            // m_lblChannelDown
            // 
            this.m_lblChannelDown.Location = new System.Drawing.Point(237, 349);
            this.m_lblChannelDown.Name = "m_lblChannelDown";
            this.m_lblChannelDown.Size = new System.Drawing.Size(126, 52);
            this.m_lblChannelDown.TabIndex = 16;
            this.m_lblChannelDown.Text = "-";
            this.m_lblChannelDown.UseVisualStyleBackColor = true;
            this.m_lblChannelDown.Click += new System.EventHandler(this.m_btnChannelDown_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Channel:";
            // 
            // m_lblChannel
            // 
            this.m_lblChannel.AutoSize = true;
            this.m_lblChannel.Location = new System.Drawing.Point(316, 271);
            this.m_lblChannel.Name = "m_lblChannel";
            this.m_lblChannel.Size = new System.Drawing.Size(36, 25);
            this.m_lblChannel.TabIndex = 18;
            this.m_lblChannel.Text = "26";
            // 
            // m_lblPower
            // 
            this.m_lblPower.AutoSize = true;
            this.m_lblPower.Location = new System.Drawing.Point(425, 376);
            this.m_lblPower.Name = "m_lblPower";
            this.m_lblPower.Size = new System.Drawing.Size(72, 25);
            this.m_lblPower.TabIndex = 19;
            this.m_lblPower.Text = "Power";
            // 
            // m_lblTV
            // 
            this.m_lblTV.AutoSize = true;
            this.m_lblTV.Location = new System.Drawing.Point(530, 327);
            this.m_lblTV.Name = "m_lblTV";
            this.m_lblTV.Size = new System.Drawing.Size(39, 25);
            this.m_lblTV.TabIndex = 20;
            this.m_lblTV.Text = "TV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(639, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Xbox";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(773, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "PS4";
            // 
            // m_lblTVPower
            // 
            this.m_lblTVPower.AutoSize = true;
            this.m_lblTVPower.Location = new System.Drawing.Point(535, 376);
            this.m_lblTVPower.Name = "m_lblTVPower";
            this.m_lblTVPower.Size = new System.Drawing.Size(36, 25);
            this.m_lblTVPower.TabIndex = 23;
            this.m_lblTVPower.Text = "off";
            // 
            // m_lblXboxPower
            // 
            this.m_lblXboxPower.AutoSize = true;
            this.m_lblXboxPower.Location = new System.Drawing.Point(644, 376);
            this.m_lblXboxPower.Name = "m_lblXboxPower";
            this.m_lblXboxPower.Size = new System.Drawing.Size(36, 25);
            this.m_lblXboxPower.TabIndex = 24;
            this.m_lblXboxPower.Text = "off";
            // 
            // m_lblPS4Power
            // 
            this.m_lblPS4Power.AutoSize = true;
            this.m_lblPS4Power.Location = new System.Drawing.Point(778, 376);
            this.m_lblPS4Power.Name = "m_lblPS4Power";
            this.m_lblPS4Power.Size = new System.Drawing.Size(36, 25);
            this.m_lblPS4Power.TabIndex = 25;
            this.m_lblPS4Power.Text = "off";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1004, 596);
            this.Controls.Add(this.m_lblPS4Power);
            this.Controls.Add(this.m_lblXboxPower);
            this.Controls.Add(this.m_lblTVPower);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.m_lblTV);
            this.Controls.Add(this.m_lblPower);
            this.Controls.Add(this.m_lblChannel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.m_lblChannelDown);
            this.Controls.Add(this.m_btnChannelUp);
            this.Controls.Add(this.m_lblVolume);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_btnVolumeDown);
            this.Controls.Add(this.m_btnVolumeUp);
            this.Controls.Add(this.m_pbTV);
            this.Controls.Add(this.m_lblGame);
            this.Controls.Add(this.m_CBPS4);
            this.Controls.Add(this.m_CBXbox);
            this.Controls.Add(this.m_lblOutput);
            this.Controls.Add(this.m_lblCO);
            this.Controls.Add(this.m_btnHDMI2);
            this.Controls.Add(this.m_btnHDMI1);
            this.Controls.Add(this.m_btnTV);
            this.Controls.Add(this.m_pbPS4);
            this.Controls.Add(this.m_pbXbox);
            this.Name = "Form1";
            this.Text = "Universal Remote";
            ((System.ComponentModel.ISupportInitialize)(this.m_pbXbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_pbPS4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_pbTV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox m_pbXbox;
        private System.Windows.Forms.PictureBox m_pbPS4;
        private System.Windows.Forms.Button m_btnTV;
        private System.Windows.Forms.Button m_btnHDMI1;
        private System.Windows.Forms.Button m_btnHDMI2;
        private System.Windows.Forms.Label m_lblCO;
        private System.Windows.Forms.Label m_lblOutput;
        private System.Windows.Forms.ComboBox m_CBXbox;
        private System.Windows.Forms.ComboBox m_CBPS4;
        private System.Windows.Forms.Label m_lblGame;
        private System.Windows.Forms.PictureBox m_pbTV;
        private System.Windows.Forms.Button m_btnVolumeUp;
        private System.Windows.Forms.Button m_btnVolumeDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label m_lblVolume;
        private System.Windows.Forms.Button m_btnChannelUp;
        private System.Windows.Forms.Button m_lblChannelDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label m_lblChannel;
        private System.Windows.Forms.Label m_lblPower;
        private System.Windows.Forms.Label m_lblTV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label m_lblTVPower;
        private System.Windows.Forms.Label m_lblXboxPower;
        private System.Windows.Forms.Label m_lblPS4Power;
    }
}

