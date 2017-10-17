﻿using System;
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
    public partial class Observer : Form
    {

        public Observer()
        {
            InitializeComponent();
        }
        
        public bool SetWord(string s)
        {
            m_lblWord.Text = s;
            return true;
        }
    }
}
