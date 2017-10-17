using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacadePattern
{
    public partial class Form1 : Form
    {
        String onImg = "C:\\Users\\Jordan\\Design Patterns\\FacadePattern\\Images\\on.png";
        String offImg = "C:\\Users\\Jordan\\Design Patterns\\FacadePattern\\Images\\off.png";
        String ps4BtnOn = "C:\\Users\\Jordan\\Design Patterns\\FacadePattern\\Images\\ps4on.png";
        String ps4BtnOff = "C:\\Users\\Jordan\\Design Patterns\\FacadePattern\\Images\\ps4off.png";
        String TVOn = "C:\\Users\\Jordan\\Design Patterns\\FacadePattern\\Images\\tvon.png";
        String TVOff = "C:\\Users\\Jordan\\Design Patterns\\FacadePattern\\Images\\tvoff.png";
        int xboxClick = 0;
        int ps4Click = 0;
        int TVClick = 0;
        int volume = 0;
        int channel = 26;
        Television tv = new Television();
        Xbox xbox = new Xbox();
        PS4 ps4 = new PS4();
        public Form1()
        {
            InitializeComponent();
            m_CBPS4.DataSource = ps4.PS4List;
            m_CBXbox.DataSource = xbox.XboxList;
            disableButtons();
        }

        public void enableButtons()
        {
            m_btnChannelUp.Enabled = true;
            m_lblChannelDown.Enabled = true;
            m_btnVolumeDown.Enabled = true;
            m_btnVolumeUp.Enabled = true;
            m_btnHDMI1.Enabled = true;
            m_btnHDMI2.Enabled = true;
            m_btnTV.Enabled = true;
        }

        public void disableButtons()
        {
            m_btnChannelUp.Enabled = false;
            m_lblChannelDown.Enabled = false;
            m_btnVolumeDown.Enabled = false;
            m_btnVolumeUp.Enabled = false;
            m_btnHDMI2.Enabled = false;
            m_btnHDMI1.Enabled = false;
            m_btnTV.Enabled = false;
        }

        private void m_pbXbox_Click(object sender, EventArgs e)
        {
            if (xboxClick % 2 == 0)
            {
                m_pbXbox.Image = Image.FromFile(onImg);
                m_CBXbox.Enabled = true;
                m_lblXboxPower.Text = xbox.switchPower();
            }
            if(xboxClick % 2 == 1)
            {
                m_pbXbox.Image = Image.FromFile(offImg);
                m_CBXbox.Enabled = false;
                m_lblXboxPower.Text = xbox.switchPower();
            }
            xboxClick++;
        }

        private void m_pbPS4_Click(object sender, EventArgs e)
        {
            if(ps4Click % 2 == 0)
            {
                m_pbPS4.Image = Image.FromFile(ps4BtnOn);
                m_CBPS4.Enabled = true;
                m_lblPS4Power.Text = ps4.switchPower(0);
            }
            if(ps4Click % 2 == 1)
            {
                m_pbPS4.Image = Image.FromFile(ps4BtnOff);
                m_CBPS4.Enabled = false;
                m_lblPS4Power.Text = ps4.switchPower(0);
            }
            ps4Click++;
        }

        private void m_btnTV_Click(object sender, EventArgs e)
        {
            m_lblOutput.Text = "Televison";
        }

        private void m_btnHDMI1_Click(object sender, EventArgs e)
        {
            m_lblOutput.Text = "HDMI 1";
        }

        private void m_btnHDMI2_Click(object sender, EventArgs e)
        {
            m_lblOutput.Text = "HDMI 2";
        }

        private void m_pbTV_Click(object sender, EventArgs e)
        {
            if (TVClick % 2 == 0)
            {
                m_pbTV.Image = Image.FromFile(TVOn);
                m_lblTVPower.Text = tv.switchPower();
                enableButtons();
            }
            if (TVClick % 2 == 1)
            {
                m_pbTV.Image = Image.FromFile(TVOff);
                m_lblTVPower.Text = tv.switchPower();
                disableButtons();
            }
            TVClick++;
        }

        private void m_btnVolumeUp_Click(object sender, EventArgs e)
        {
            volume = tv.upVolume();
            m_lblVolume.Text = volume.ToString();
        }

        private void m_btnVolumeDown_Click(object sender, EventArgs e)
        {
            volume = tv.downVolume();
            m_lblVolume.Text = volume.ToString();
        }

        private void m_btnChannelUp_Click(object sender, EventArgs e)
        {
            channel = tv.upChannel();
            m_lblChannel.Text = channel.ToString();
            m_lblOutput.Text = "Television";
        }

        private void m_btnChannelDown_Click(object sender, EventArgs e)
        {
            channel = tv.downChannel();
            m_lblChannel.Text = channel.ToString();
            m_lblOutput.Text = "Television";
        }

        private void m_pbPS4_DoubleClick(object sender, EventArgs e)
        {
            m_pbPS4.Image = Image.FromFile(ps4BtnOff);
            m_CBPS4.Enabled = false;
            m_lblPS4Power.Text = ps4.switchPower(1);
        }
    }
}
