using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_pelda.Ertesitesek
{
    internal class Email : IErtesites
    {
        public string emailcim {  get; set; }

        public void Ertesites()
        {
            Console.WriteLine("emilben ertesites");
        }
    }
}
