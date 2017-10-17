namespace SingletonPattern
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.m_tbFavorite = new System.Windows.Forms.TextBox();
            this.m_tbCFavorite = new System.Windows.Forms.TextBox();
            this.m_btnSelect = new System.Windows.Forms.Button();
            this.m_btnChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Favorite Color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Current Favorite Color";
            // 
            // m_tbFavorite
            // 
            this.m_tbFavorite.Location = new System.Drawing.Point(260, 115);
            this.m_tbFavorite.Name = "m_tbFavorite";
            this.m_tbFavorite.Size = new System.Drawing.Size(152, 31);
            this.m_tbFavorite.TabIndex = 2;
            // 
            // m_tbCFavorite
            // 
            this.m_tbCFavorite.Location = new System.Drawing.Point(260, 154);
            this.m_tbCFavorite.Name = "m_tbCFavorite";
            this.m_tbCFavorite.Size = new System.Drawing.Size(152, 31);
            this.m_tbCFavorite.TabIndex = 3;
            // 
            // m_btnSelect
            // 
            this.m_btnSelect.Location = new System.Drawing.Point(446, 81);
            this.m_btnSelect.Name = "m_btnSelect";
            this.m_btnSelect.Size = new System.Drawing.Size(186, 65);
            this.m_btnSelect.TabIndex = 4;
            this.m_btnSelect.Text = "Select Color";
            this.m_btnSelect.UseVisualStyleBackColor = true;
            this.m_btnSelect.Click += new System.EventHandler(this.m_btnSelect_Click);
            // 
            // m_btnChange
            // 
            this.m_btnChange.Location = new System.Drawing.Point(446, 154);
            this.m_btnChange.Name = "m_btnChange";
            this.m_btnChange.Size = new System.Drawing.Size(186, 65);
            this.m_btnChange.TabIndex = 5;
            this.m_btnChange.Text = "Change Color";
            this.m_btnChange.UseVisualStyleBackColor = true;
            this.m_btnChange.Click += new System.EventHandler(this.m_btnChange_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 539);
            this.Controls.Add(this.m_btnChange);
            this.Controls.Add(this.m_btnSelect);
            this.Controls.Add(this.m_tbCFavorite);
            this.Controls.Add(this.m_tbFavorite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox m_tbFavorite;
        private System.Windows.Forms.TextBox m_tbCFavorite;
        private System.Windows.Forms.Button m_btnSelect;
        private System.Windows.Forms.Button m_btnChange;
    }
}

