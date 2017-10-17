using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    class Xbox
    {
        public enum Power { On, Off };
        public List<string> XboxList = new List<string>();
        int counter = 0;
        Power power;

        public Xbox()
        {
            populateList();
        }

        public string switchPower()
        {
            counter++;
            if (counter % 2 == 1)
            {
                power = Power.On;
                return "on";
            }
            if (counter % 2 == 0)
            {
                power = Power.Off;
                return "off";
            }
            else return "off";
        }

        public void populateList()
        {
            XboxList.Add("Halo Reach");
            XboxList.Add("Skyrim");
            XboxList.Add("Fallout 3");
            XboxList.Add("Portal 2");
            XboxList.Add("Modern Warfare 3");
        }
    }
}
