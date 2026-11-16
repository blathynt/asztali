using Interfaces_pelda.Ertesitesek;
using System.Security.Cryptography.X509Certificates;

namespace Interfaces_pelda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Email email = new Email() { emailcim = "anna@gmail.com" };
            Vendeg anna = new Vendeg(email);

            Uzenet uzenet = new Uzenet() { telefonszam = "02146435" };
            Vendeg bela = new Vendeg(uzenet);
        }
    }
}
