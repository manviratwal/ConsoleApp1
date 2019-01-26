using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   
class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Countrysider
    {

        Village Alst;
        Village Maeland;
        Village Schenig;

        public void InitializeMap()
        {


            Alst = new Village();
            Maeland = new Village();
            Maeland.isAstrildeHere = true;
            Schenig = new Village();

            Alst.NextVillage = Maeland;
            Maeland.NextVillage = Schenig;
            Schenig.NextVillage = Alst;
        }

        public void WalkAround()
        {
            Village InitializeVillage = this.Maeland;
        }
    }

    class Village
    {
        public Village PreviousVillage;
        public Village NextVillage;
        public String VillageName;
        public bool isAstrildeHere = false;
        public Village() { }


    }
}

