namespace IteratorDemo
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
            this.m_btnPrime = new System.Windows.Forms.Button();
            this.m_btnSquares = new System.Windows.Forms.Button();
            this.m_lbTotal = new System.Windows.Forms.ListBox();
            this.m_lbSorted = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // m_btnPrime
            // 
            this.m_btnPrime.Location = new System.Drawing.Point(350, 104);
            this.m_btnPrime.Name = "m_btnPrime";
            this.m_btnPrime.Size = new System.Drawing.Size(140, 92);
            this.m_btnPrime.TabIndex = 0;
            this.m_btnPrime.Text = "Prime";
            this.m_btnPrime.UseVisualStyleBackColor = true;
            this.m_btnPrime.Click += new System.EventHandler(this.m_btnOdd_Click);
            // 
            // m_btnSquares
            // 
            this.m_btnSquares.Location = new System.Drawing.Point(515, 104);
            this.m_btnSquares.Name = "m_btnSquares";
            this.m_btnSquares.Size = new System.Drawing.Size(135, 92);
            this.m_btnSquares.TabIndex = 1;
            this.m_btnSquares.Text = "Perfect Squares";
            this.m_btnSquares.UseVisualStyleBackColor = true;
            this.m_btnSquares.Click += new System.EventHandler(this.m_btnEven_Click);
            // 
            // m_lbTotal
            // 
            this.m_lbTotal.FormattingEnabled = true;
            this.m_lbTotal.ItemHeight = 25;
            this.m_lbTotal.Location = new System.Drawing.Point(49, 106);
            this.m_lbTotal.Name = "m_lbTotal";
            this.m_lbTotal.Size = new System.Drawing.Size(285, 404);
            this.m_lbTotal.TabIndex = 2;
            // 
            // m_lbSorted
            // 
            this.m_lbSorted.FormattingEnabled = true;
            this.m_lbSorted.ItemHeight = 25;
            this.m_lbSorted.Location = new System.Drawing.Point(410, 246);
            this.m_lbSorted.Name = "m_lbSorted";
            this.m_lbSorted.Size = new System.Drawing.Size(283, 229);
            this.m_lbSorted.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 576);
            this.Controls.Add(this.m_lbSorted);
            this.Controls.Add(this.m_lbTotal);
            this.Controls.Add(this.m_btnSquares);
            this.Controls.Add(this.m_btnPrime);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button m_btnPrime;
        private System.Windows.Forms.Button m_btnSquares;
        private System.Windows.Forms.ListBox m_lbTotal;
        private System.Windows.Forms.ListBox m_lbSorted;
    }
}

