using Interfaces_pelda.Ertesitesek;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_pelda
{
    internal class Vendeg
    {
        public string Nev {  get; set; }

        public IErtesites ErtesitesiMod {  get; set; }


        public Vendeg(IErtesites ertesitesimod) 
        {
            ErtesitesiMod = ertesitesimod; 
        }

        //public Email Email { get; set; }
        //public Uzenet uzenet { get; set; }
    }
}
