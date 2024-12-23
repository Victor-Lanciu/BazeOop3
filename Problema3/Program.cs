namespace Problema3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student student1 = new Student("Gabriel", 22, "Matematica si Informatica");
            Student student1 = new Student("Igor", 23, " Informatica");
            Student student2 = new Student(student1);
            student1.AfisareDetalii();
            student2.AfisareDetalii();
            
        }
    }
}
