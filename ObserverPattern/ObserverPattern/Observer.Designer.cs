namespace ObserverPattern
{
    partial class Observer
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
            this.m_lblWord = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // m_lblWord
            // 
            this.m_lblWord.AutoSize = true;
            this.m_lblWord.Location = new System.Drawing.Point(112, 161);
            this.m_lblWord.Name = "m_lblWord";
            this.m_lblWord.Size = new System.Drawing.Size(0, 25);
            this.m_lblWord.TabIndex = 0;
            // 
            // Observer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 416);
            this.Controls.Add(this.m_lblWord);
            this.Name = "Observer";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label m_lblWord;
    }
}