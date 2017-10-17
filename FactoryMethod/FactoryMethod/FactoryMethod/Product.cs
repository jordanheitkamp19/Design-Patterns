using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{

    public abstract class Product
    {
        protected int VALUE;
        public abstract string returnName();
        public abstract int returnValue();
    }

    public class ConcreteProduct : Product
    {
        private const int VALUE = 0;

        public override int returnValue()
        {
            return VALUE;
        }

        public override string returnName()
        {
            return "ConcreteProduct";
        }
    }

    public class RedRupee : Product
    {
        private const int VALUE = 20;

        public override int returnValue()
        {
            return VALUE;
        }

        public override string returnName()
        {
            return "Red Rupee (+20)";
        }
    }

    public class GreenRupee : Product
    {
        private const int VALUE = 1;

        public override int returnValue()
        {
            return VALUE;
        }

        public override string returnName()
        {
            return "Green Rupee (+1)";
        }
    }
}
