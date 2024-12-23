using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema3
{
    public class Student
    {
        public string Nume { get; set; }
        public int Varsta { get; set; }
        public string Specializarea { get; set; }

        public Student(string nume, int varsta, string specializarea)
        {
            Nume = nume;
            Varsta = varsta;
            Specializarea = specializarea;
        }

        public Student(Student studentCopy)
        {
            Nume = studentCopy.Nume;
            Varsta = studentCopy.Varsta;
            Specializarea = studentCopy.Specializarea;
        }
        public void AfisareDetalii()
        {
            Console.WriteLine($"Numele: {Nume}, Varsta: {Varsta}, Specializarea: {Specializarea}");
        }

    }
}
