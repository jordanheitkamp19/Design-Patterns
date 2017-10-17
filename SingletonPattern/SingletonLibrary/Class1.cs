using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonLibrary
{
    public class Singleton
    {
        private static Singleton instance;
        String name;
        private Singleton(String s)
        {
            name = s;
        }
        public static Singleton getInstance(String s)
        {
            if (instance == null)
                instance = new Singleton(s);
            return instance;
        }
        public String returnColor()
        {
            return instance.name;
        }
        public void changeColor()
        {
            instance = null;
        }
    }
}
