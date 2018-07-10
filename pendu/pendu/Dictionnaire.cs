using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace pendu
{
    class Dictionnaire
    {

        public Mot str;
        public String[] list = new String[0];

        public Dictionnaire()
        {

        }
        public Dictionnaire(Mot str)
        {
            this.str = str;
        }

        public Dictionnaire(String [] list)
        {
            this.list = list;
        }
        public String[] charger()
        {
                list = File.ReadAllLines(@"C:\Users\Alexis Hidalgo\Documents\nombres.txt");
            
            return list;

        }
    }




}
