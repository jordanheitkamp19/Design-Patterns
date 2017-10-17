namespace FactoryMethod
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
            this.m_pnlMotion = new System.Windows.Forms.Panel();
            this.m_pbBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.m_lblRupeeCount = new System.Windows.Forms.Label();
            this.m_lbGathered = new System.Windows.Forms.ListBox();
            this.m_pnlMotion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_pbBox)).BeginInit();
            this.SuspendLayout();
            // 
            // m_pnlMotion
            // 
            this.m_pnlMotion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_pnlMotion.Controls.Add(this.m_pbBox);
            this.m_pnlMotion.Enabled = false;
            this.m_pnlMotion.Location = new System.Drawing.Point(44, 44);
            this.m_pnlMotion.Name = "m_pnlMotion";
            this.m_pnlMotion.Size = new System.Drawing.Size(488, 434);
            this.m_pnlMotion.TabIndex = 0;
            // 
            // m_pbBox
            // 
            this.m_pbBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.m_pbBox.Location = new System.Drawing.Point(219, 189);
            this.m_pbBox.Name = "m_pbBox";
            this.m_pbBox.Size = new System.Drawing.Size(50, 50);
            this.m_pbBox.TabIndex = 0;
            this.m_pbBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(539, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rupees:";
            // 
            // m_lblRupeeCount
            // 
            this.m_lblRupeeCount.AutoSize = true;
            this.m_lblRupeeCount.Location = new System.Drawing.Point(627, 44);
            this.m_lblRupeeCount.Name = "m_lblRupeeCount";
            this.m_lblRupeeCount.Size = new System.Drawing.Size(24, 25);
            this.m_lblRupeeCount.TabIndex = 2;
            this.m_lblRupeeCount.Text = "0";
            // 
            // m_lbGathered
            // 
            this.m_lbGathered.Enabled = false;
            this.m_lbGathered.FormattingEnabled = true;
            this.m_lbGathered.ItemHeight = 25;
            this.m_lbGathered.Location = new System.Drawing.Point(574, 88);
            this.m_lbGathered.Name = "m_lbGathered";
            this.m_lbGathered.Size = new System.Drawing.Size(337, 429);
            this.m_lbGathered.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 616);
            this.Controls.Add(this.m_lbGathered);
            this.Controls.Add(this.m_lblRupeeCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_pnlMotion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDownHandler);
            this.m_pnlMotion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_pbBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel m_pnlMotion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox m_pbBox;
        private System.Windows.Forms.Label m_lblRupeeCount;
        private System.Windows.Forms.ListBox m_lbGathered;
    }
}

