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

            Boolean whatiffff = (new verify()).verifywhat("whatififff");

            Boolean whatifsssfff = (new verify()).verifywhat("whatififfsssf");

            Boolean whatifsssfffjenkin = (new verify()).verifywhat("whatifsssfffjenkin");

            Boolean whatifsssfffjenkinpr = (new verify()).verifywhat("whatifsssfffjenkinpr");


        }
    }

    public class verify
    {
        string name;

        public Boolean verifywhat(string name)
        {
            return this.name == name ? true : false;
        }
    }
}
