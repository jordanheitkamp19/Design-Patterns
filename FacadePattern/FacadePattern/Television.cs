using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class Television
    {
        enum Power { On, Off };
        Power power = Power.Off;
        int volume = 0;
        int channel = 26;
        int counter = 0;

        public string switchPower()
        {
            counter++;
            if(counter % 2 == 1)
            {
                power = Power.On;
                return "on";
            }
            if(counter % 2 == 0)
            {
                power = Power.Off;
                return "off";
            }
            else return "off";
        }

        public int downChannel()
        {
            if(channel == 1)
            {
                channel = 100;
                return channel;
            }
            return --channel;
        }

        public int upChannel()
        {
            if(channel == 100)
            {
                channel = 1;
                return channel;
            }
            return ++channel;
        }

        public int downVolume()
        {
            if (volume <= 0)
            {
                return 0;
            }
            else
                return --volume;
        }

        public int upVolume()
        {
            if (volume >= 100)
            {
                return 100;
            }
            else
                return ++volume;
        }
    }
}
