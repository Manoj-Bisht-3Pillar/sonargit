using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sonarapp
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "This is a test";

            Boolean what = (new verify()).verifywhat("whatif");

            Boolean whatif = (new verify()).verifywhat("whatif");

            Boolean whatiff = (new verify()).verifywhat("whatif");


            verify v = new verify();

            Boolean verifiyResult = v.verifywhat(string.Empty);

            Console.WriteLine("some message");

            Console.WriteLine("some message 123");



        }
    }

    public class verify
    {
        public string name;

        public Boolean verifywhat(string name)
        {
            return this.name == name ? true : false;
        }
    }
}
