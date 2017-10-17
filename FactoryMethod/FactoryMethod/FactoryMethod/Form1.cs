using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactoryMethod
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        PictureBox m_lblrupee1 = new PictureBox();
        PictureBox m_lblrupee2 = new PictureBox();
        RedRupeeCreator red = new RedRupeeCreator();
        GreenRupeeCreator green = new GreenRupeeCreator();
        public int rupeeCount = 0;
        List<string> list = new List<string>();

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            m_lblrupee1.Size = new Size(15, 25);
            m_lblrupee2.Size = new Size(15, 25);
            AddRupeeToPanel(m_lblrupee1, rand.Next(10));
            AddRupeeToPanel(m_lblrupee2, rand.Next(10));
        }

        private void addProductToPanel(Product prod)
        {
            m_lbGathered.Items.Add(prod.returnName());
        }

        public void AddRupeeToPanel(PictureBox lbl, int cn)
        {
            if(cn == 0)
            {
                lbl.ForeColor = Color.Green;
                Creator create = new GreenRupeeCreator();
                lbl.Image = Image.FromFile(create.returnString());
            }
            if(cn == 1)
            {
                lbl.ForeColor = Color.Red;
                Creator create = new RedRupeeCreator();
                lbl.Image = Image.FromFile(create.returnString());
            }
            if(cn >= 2)
            {
                lbl.ForeColor = Color.Green;
                Creator create = new GreenRupeeCreator();
                lbl.Image = Image.FromFile(create.returnString());
            }
            m_pnlMotion.Controls.Add(lbl);
            int xLocation = rand.Next(0, 200);
            int yLocation = rand.Next(0, 180);
            lbl.Location = new Point(xLocation, yLocation);
            m_lblRupeeCount.Text = rupeeCount.ToString();
        }

        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
            {
                m_pbBox.Location = new Point(m_pbBox.Left, m_pbBox.Top - 5);
                if(m_pbBox.Top <= -6)
                {
                    m_pbBox.Location = new Point(m_pbBox.Left, 206);
                }
                if(CheckCollision(m_lblrupee1))
                {
                    AddRupeeToPanel(m_lblrupee1, rand.Next(10));
                }
                if(CheckCollision(m_lblrupee2))
                {
                    AddRupeeToPanel(m_lblrupee2, rand.Next(10));
                }
            }
            else if(e.KeyCode == Keys.Down)
            {
                m_pbBox.Location = new Point(m_pbBox.Left, m_pbBox.Top + 5);
                if(m_pbBox.Top >= 206)
                {
                    m_pbBox.Location = new Point(m_pbBox.Left, -6);
                }
                if (CheckCollision(m_lblrupee1))
                {
                    AddRupeeToPanel(m_lblrupee1, rand.Next(10));
                }
                if (CheckCollision(m_lblrupee2))
                {
                    AddRupeeToPanel(m_lblrupee2, rand.Next(10));
                }
            }
            else if(e.KeyCode == Keys.Left)
            {
                m_pbBox.Location = new Point(m_pbBox.Left - 5, m_pbBox.Top);
                if(m_pbBox.Left <= -6)
                {
                    m_pbBox.Location = new Point(220, m_pbBox.Top);
                }
                if (CheckCollision(m_lblrupee1))
                {
                    AddRupeeToPanel(m_lblrupee1, rand.Next(10));
                }
                if (CheckCollision(m_lblrupee2))
                {
                    AddRupeeToPanel(m_lblrupee2, rand.Next(10));
                }
            }
            else if(e.KeyCode == Keys.Right)
            {
                m_pbBox.Location = new Point(m_pbBox.Left + 5, m_pbBox.Top);
                if(m_pbBox.Left >= 220)
                {
                    m_pbBox.Location = new Point(-6, m_pbBox.Top);
                }
                if (CheckCollision(m_lblrupee1))
                {
                    AddRupeeToPanel(m_lblrupee1, rand.Next(10));
                }
                if (CheckCollision(m_lblrupee2))
                {
                    AddRupeeToPanel(m_lblrupee2, rand.Next(10));
                }
            }
            else
            {
                return;
            }
        }

        private bool CheckCollision(PictureBox lbl)
        {
            Rectangle rec = lbl.Bounds;
            Rectangle rec2 = m_pbBox.Bounds;
            if (rec.IntersectsWith(rec2))
            {
                if (lbl.ForeColor == Color.Green)
                {
                    Product greenRupee = green.FactoryMethod();
                    addProductToPanel(greenRupee);
                    rupeeCount += greenRupee.returnValue();
                }
                if(lbl.ForeColor == Color.Red)
                {
                    Product redRupee = red.FactoryMethod();
                    addProductToPanel(redRupee);
                    rupeeCount += redRupee.returnValue();
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
