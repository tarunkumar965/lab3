using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class pripub
    {
        private string t = "tarunkumar";
        public string tar
        {
            get
            {
                return t;
            }
            set
            {
                t = value;
            }
        }
    }
    internal class Program
    {
      
        static void Main(string[] args)
        {
            pripub ta = new pripub();
            ta.tar = "kumar";
            Console.WriteLine(ta.tar);
        }
    }
}
