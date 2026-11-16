using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_pelda
{
    internal class ParkMngmt
    {
        public List<Vendeg> Vendegek {  get; set; } = new List<Vendeg>();

        public void ErtesitesKuldese()
        {
            foreach (Vendeg v in Vendegek)
            {
                v.ErtesitesiMod.Ertesites();
            }
        }
    }
}
