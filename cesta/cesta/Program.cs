
namespace cesta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("napis spoje mezi lidmi: ");
            string vsechny_spoje_neupravene = Console.ReadLine();
            Console.WriteLine("napis jak mezi jakymi cisly chces najit spojeni");
            string cislanacestu = Console.ReadLine();
            
           
            }


        }

        static void Pred0delani(string vsechny_spoje_neupravene)
        {
            string[] dvojice = vsechny_spoje_neupravene.Split(' ');
            int blabla = dvojice.Length;
            int[,] seznam_spoju = new int[blabla, 2];
            for (int i = 0; i < blabla; i++)
            {
                string[] numbers = dvojice[i].Split('-');
                seznam_spoju[i, 0] = int.Parse(numbers[0]);
                seznam_spoju[i, 1] = int.Parse(numbers[1]);
            }
        }
        static void D0delani(int[,] seznam_spoju,string[] cislanacestu)
        {
            string[] dvecisla = cislanacestu.Split('-');
        }
    }
}   

