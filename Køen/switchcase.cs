using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Køen
{
    public class switchcase
    {

        public string Choice(int choice)
        {
            string returnvalue = "0";
            switch (choice)
            {
                case 1:
                    returnvalue = "Du har valgt at tilføje en film!";
                    break;

                case 2:
                    returnvalue = "Du har set den næste film i rækken, og den vil blive fjernet fra køen";
                    break;

                case 3:
                    returnvalue = "Film i køen:";
                    break;

                case 4:
                    returnvalue = "Disse film er tilbage i køen";
                    break;

                case 5:
                    returnvalue = "Programmet afsluttes";
                    break;
            }
            return returnvalue;
        }
    }
}
