using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IteratorDemo
{
    public partial class Form1 : Form
    {
        ConcreteAggregate agg;

        public Form1()
        {
            InitializeComponent();
            agg = new ConcreteAggregate();
            LoadAgg(agg);
            Iterator iter = agg.CreateIterator(IteratorType.TotalIterator);
            PopulateListBox(iter, m_lbTotal);
        }

        private void LoadAgg(ConcreteAggregate agg)
        {
            for(int i = 0; i <= 50; i++)
            {
                agg.Add(i.ToString());
            }
        }

        private void m_btnOdd_Click(object sender, EventArgs e)
        {
            Iterator iter = agg.CreateIterator(IteratorType.PrimeIterator);
            PopulateListBox(iter, m_lbSorted);
        }

        private void m_btnEven_Click(object sender, EventArgs e)
        {
            Iterator iter = agg.CreateIterator(IteratorType.SquaresIterator);
            PopulateListBox(iter, m_lbSorted);
        }

        public void PopulateListBox(Iterator iter, ListBox lb)
        {
            lb.Items.Clear();
            for(iter.First(); !iter.IsDone(); iter.Next())
            {
                lb.Items.Add(iter.CurrentItem());
            }
        }
    }
}
