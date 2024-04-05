namespace Lab1_N2_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EuropeDateTime europeDateTime = new();
            Console.WriteLine(europeDateTime.GetDateTime());
            USDateTime usDateTime = new();
            Console.WriteLine(usDateTime.GetDateTime());
            Console.WriteLine(new DateTimeDeco2(new DateTimeDeco1(new DateTimeDeco1(europeDateTime))).GetDateTime());
            Console.WriteLine(new DateTimeDeco2(usDateTime).GetDateTime());
        }
    }
}
