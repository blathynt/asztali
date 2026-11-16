using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_pelda.Ertesitesek
{
    internal class Level : IErtesites
    {
        public string cim {  get; set; }

        public void Ertesites()
        {
            Console.WriteLine("leveles ertesites");
        }
    }
}
