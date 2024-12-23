using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2
{
    public class Carte
    {
        public string Titlu { get; set; }
        public string Autor { get; set; }
        public int AnPublicare { get; set; }
        public int NrPagini { get; set; }

        public Carte(string titlu, string autor, int anPublicare, int nrPagini)
        {
            Titlu = titlu;
            Autor = autor;
            AnPublicare = anPublicare;
            NrPagini = nrPagini;    
        }
        public void AfisareDetalii()
        {
            Console.WriteLine($"Titlul cartii: {Titlu}, Autorul: {Autor}, Anul de publicare: {AnPublicare}, " +
                $"Numarul de pagini{NrPagini} ");
        }
    }
}
