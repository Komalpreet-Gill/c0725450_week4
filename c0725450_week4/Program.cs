using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {


        }
    }
    class Village
    {
        public static int numberOfVillages = 0;
        public Village nextVillage;
        public Village previousVillage;
        public string villageName;
        public bool isAstrildeHere = false;

        public Village()
        {
            Village.numberOfVillages++;
        }

    }
    class Countryside
    {
        public Village Maple;
        public Village Toronto;
        public Village Ajax;

        public void MapInitializer()
        {
            Maple = new Village();
            Maple.villageName = "Maple";
            Maple.nextVillage = Toronto;
            Maple.previousVillage = null;

            Toronto = new Village();
            Toronto.villageName = "Toronto";
            Toronto.nextVillage = Ajax;
            Toronto.previousVillage = Maple;

            Ajax = new Village();
            Ajax.villageName = "Ajax";
            Ajax.nextVillage = null;
            Ajax.previousVillage = Toronto;
            Ajax.isAstrildeHere = true;
        }

        public void LookForAstrilde()
        {

        }

    }
}