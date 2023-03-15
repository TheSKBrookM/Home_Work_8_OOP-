namespace ДР_8_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Впишiть строку: ");
            string stroka = Console.ReadLine();

            Console.WriteLine("Вкажiть колiр: \nRed = 0,\nGreen = 1,\nYellow = 2,\nGray = 3,\nWhite = 4," +
                "\nBlue = 5,\nBlack = 6");
            int color = Convert.ToInt32(Console.ReadLine());

            Printer.Print(stroka, color);

            Console.ReadKey();
        }
    }
}