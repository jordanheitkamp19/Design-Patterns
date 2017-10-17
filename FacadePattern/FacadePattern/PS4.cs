using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    class PS4
    {
        public enum Power { On, Off, Rest };
        public List<string> PS4List = new List<string>();
        int counter = 0;
        Power power;

        public PS4()
        {
            populateList();
        }

        public string switchPower(int i)
        {
            if(i == 1)
            {
                power = Power.Rest;
                counter = 0;
                return "rest";
            }
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
            PS4List.Add("Just Cause 3");
            PS4List.Add("Black Ops 3");
            PS4List.Add("Infinite Warfare");
            PS4List.Add("Worms W.M.D.");
        }
    }
}
