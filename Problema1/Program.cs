namespace Problema1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstNum = Helper.GenerareCodUnic("373");
            Console.WriteLine(firstNum);
            string secondNum = Helper.GenerareCodUnic("112");
            Console.WriteLine(secondNum);
            string thirdNum = Helper.GenerareCodUnic("123");
            Console.WriteLine(thirdNum);

        }
    }
}
