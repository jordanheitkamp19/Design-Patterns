using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SingletonLibrary;

namespace SingletonPattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void m_btnSelect_Click(object sender, EventArgs e)
        {
            Singleton s = Singleton.getInstance(m_tbFavorite.Text);
            m_tbCFavorite.Text = s.returnColor();
            m_tbFavorite.Text = "";
        }

        private void m_btnChange_Click(object sender, EventArgs e)
        {
            Singleton s = Singleton.getInstance("");
            s.changeColor();
            m_tbCFavorite.Text = "";
        }
    }
}
