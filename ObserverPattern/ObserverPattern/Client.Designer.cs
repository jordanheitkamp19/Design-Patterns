namespace ObserverPattern
{
    partial class Client
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
            this.m_lblSofa = new System.Windows.Forms.Label();
            this.m_lblPerfect = new System.Windows.Forms.Label();
            this.m_lblAbsolutely = new System.Windows.Forms.Label();
            this.m_lblTelevision = new System.Windows.Forms.Label();
            this.m_lblSupper = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // m_lblSofa
            // 
            this.m_lblSofa.AutoSize = true;
            this.m_lblSofa.Location = new System.Drawing.Point(179, 120);
            this.m_lblSofa.Name = "m_lblSofa";
            this.m_lblSofa.Size = new System.Drawing.Size(56, 25);
            this.m_lblSofa.TabIndex = 0;
            this.m_lblSofa.Text = "Sofa";
            this.m_lblSofa.MouseHover += new System.EventHandler(this.m_lblSofa_MouseHover);
            // 
            // m_lblPerfect
            // 
            this.m_lblPerfect.AutoSize = true;
            this.m_lblPerfect.Location = new System.Drawing.Point(155, 171);
            this.m_lblPerfect.Name = "m_lblPerfect";
            this.m_lblPerfect.Size = new System.Drawing.Size(80, 25);
            this.m_lblPerfect.TabIndex = 1;
            this.m_lblPerfect.Text = "Perfect";
            this.m_lblPerfect.MouseHover += new System.EventHandler(this.m_lblPerfect_MouseHover);
            // 
            // m_lblAbsolutely
            // 
            this.m_lblAbsolutely.AutoSize = true;
            this.m_lblAbsolutely.Location = new System.Drawing.Point(123, 222);
            this.m_lblAbsolutely.Name = "m_lblAbsolutely";
            this.m_lblAbsolutely.Size = new System.Drawing.Size(112, 25);
            this.m_lblAbsolutely.TabIndex = 2;
            this.m_lblAbsolutely.Text = "Absolutely";
            this.m_lblAbsolutely.MouseHover += new System.EventHandler(this.m_lblAbsolutely_MouseHover);
            // 
            // m_lblTelevision
            // 
            this.m_lblTelevision.AutoSize = true;
            this.m_lblTelevision.Location = new System.Drawing.Point(125, 273);
            this.m_lblTelevision.Name = "m_lblTelevision";
            this.m_lblTelevision.Size = new System.Drawing.Size(110, 25);
            this.m_lblTelevision.TabIndex = 3;
            this.m_lblTelevision.Text = "Television";
            this.m_lblTelevision.MouseHover += new System.EventHandler(this.m_lblTelevision_MouseHover);
            // 
            // m_lblSupper
            // 
            this.m_lblSupper.AutoSize = true;
            this.m_lblSupper.Location = new System.Drawing.Point(154, 324);
            this.m_lblSupper.Name = "m_lblSupper";
            this.m_lblSupper.Size = new System.Drawing.Size(81, 25);
            this.m_lblSupper.TabIndex = 4;
            this.m_lblSupper.Text = "Supper";
            this.m_lblSupper.MouseHover += new System.EventHandler(this.m_lblSupper_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 556);
            this.Controls.Add(this.m_lblSupper);
            this.Controls.Add(this.m_lblTelevision);
            this.Controls.Add(this.m_lblAbsolutely);
            this.Controls.Add(this.m_lblPerfect);
            this.Controls.Add(this.m_lblSofa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label m_lblSofa;
        private System.Windows.Forms.Label m_lblPerfect;
        private System.Windows.Forms.Label m_lblAbsolutely;
        private System.Windows.Forms.Label m_lblTelevision;
        private System.Windows.Forms.Label m_lblSupper;
    }
}

