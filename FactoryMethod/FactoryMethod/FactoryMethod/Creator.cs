using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class Creator
    {

        public abstract Product FactoryMethod();
        public abstract string returnString();
    }

    public class RedRupeeCreator : Creator
    {
        public RedRupeeCreator()
        {
        }

        public override Product FactoryMethod()
        {
            return new RedRupee();
        }

        public override string returnString()
        {
            return "C:\\Users\\Jordan\\Design Patterns\\FactoryMethod\\FactoryMethod\\Images\\redRupee.png";
        }
    }

    public class GreenRupeeCreator : Creator
    {
        public GreenRupeeCreator()
        {
        }

        public override Product FactoryMethod()
        {
            return new GreenRupee();
        }

        public override string returnString()
        {
            return "C:\\Users\\Jordan\\Design Patterns\\FactoryMethod\\FactoryMethod\\Images\\greenRupee.png";
        }
    }
}
