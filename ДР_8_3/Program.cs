namespace ДР_8_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            DateTime nextBirthday;

            Console.Write("Your DoB dd.mm.yyyy : ");
            DateTime doB = Convert.ToDateTime(Console.ReadLine());

            if (doB.Year == now.Year)
            {
                nextBirthday = new DateTime(now.Year + 1, doB.Month, doB.Day);
            }
            else
            {
                nextBirthday = new DateTime(now.Year, doB.Month, doB.Day);
            }

            TimeSpan leftToNextDoB = nextBirthday - now ;

            Console.WriteLine(leftToNextDoB.Days);


            Console.ReadKey();
        }
    }
}