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

            Boolean what = (new verify( )).verifywhat("whatif");

            Boolean whatif = (new verify()).verifywhat("whatif");

        }
    }

    public class verify
    {
        string name;

        public Boolean verifywhat(string name)
        {
            return this.name == name ? true:false;
        }
    } 
}
