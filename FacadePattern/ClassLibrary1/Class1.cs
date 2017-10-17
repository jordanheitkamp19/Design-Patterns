using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class Television
    {
        public Television ()
        {
        enum Power { On, Off };
        int channel = 26;
        int volume = 0;
    }

    }

    public class HDMI1
    {
        public enum Power { On, Off};
        List<string> xboxList = new List<string>();


        public void populateList()
        {
            xboxList.Add("Halo Reach");
        }
    }

    public class HDMI2
    {
        public enum Power { On, Off};
    }
}
