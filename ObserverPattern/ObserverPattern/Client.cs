using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObserverPattern
{
    public partial class Client : Form
    {
        Observer o;
        public delegate void WordHoverHandler(object sender, bool b);
        public event WordHoverHandler WordHovered;

        public Client()
        {
            InitializeComponent();
            o = new Observer();
            o.Visible = true;
        }

        #region[Hover Events]
        private void m_lblSofa_MouseHover(object sender, EventArgs e)
        {
            o.SetWord(WordHoverEventArgs(0));
        }

        private void m_lblPerfect_MouseHover(object sender, EventArgs e)
        {
            o.SetWord(WordHoverEventArgs(1));
        }

        private void m_lblAbsolutely_MouseHover(object sender, EventArgs e)
        {
            o.SetWord(WordHoverEventArgs(2));
        }

        private void m_lblTelevision_MouseHover(object sender, EventArgs e)
        {
            o.SetWord(WordHoverEventArgs(3));
        }

        private void m_lblSupper_MouseHover(object sender, EventArgs e)
        {
            o.SetWord(WordHoverEventArgs(4));
        }
        #endregion

        public string WordHoverEventArgs(int i)
        {
            switch(i)
            {
                case 0:
                    return "Sofa";
                case 1:
                    return "Perfect";
                case 2:
                    return "Absolutely";
                case 3:
                    return "Television";
                case 4:
                    return "Supper";
                default:
                    return "";


                    
            }
        }
    }
}
