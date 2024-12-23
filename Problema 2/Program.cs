namespace Problema_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carte cartea1 = new Carte("Learn c# in one day", "Jamie Chan", 2017, 200);
            Carte cartea2 = new Carte("Behave", "Robert Sapolsky", 2018, 600);
            Carte cartea3 = new Carte("Clean Code", "Robert Martin", 2008, 400);
            cartea1.AfisareDetalii();
            cartea2.AfisareDetalii();
            cartea3.AfisareDetalii();
        }
    }
}
