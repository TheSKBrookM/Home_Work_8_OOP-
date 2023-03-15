namespace ДР_8_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Кiлькiсть вiдпрацьованих годин: ");
            int hours = Convert.ToInt32(Console.ReadLine());

            if (Accountant.AskForBonus(Post.Junior, hours))
            {
                Console.WriteLine("Дати премiю");
            }
            else
            {
                Console.WriteLine("Не давати премiю");
            }

            Console.ReadKey();
        }
    }
}