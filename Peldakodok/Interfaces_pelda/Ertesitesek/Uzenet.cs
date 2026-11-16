using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_pelda.Ertesitesek
{
    internal class Uzenet : IErtesites
    {
        public string telefonszam {  get; set; }

        public void Ertesites()
        {
            Console.WriteLine("uzenetben ertesites");
        }
    }
}
