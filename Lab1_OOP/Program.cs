namespace Lab1_OOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Проверка на знаменатель 0
            try
            {
                Rational rational1 = new(5, 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            // Обыкновенная дробь
            Rational rational2 = new(5, 10);
            Console.WriteLine(rational2);
            // Сократившаяся дробь
            Rational rational3 = new(10, 5);
            Console.WriteLine(rational3);
            // Отрицательные дроби
            Rational rational4 = new(-3, 7);
            Rational rational5 = new(3, -8);
            // Работа с отрицательными дробями
            Console.WriteLine(rational4 + rational5);
            Console.WriteLine(rational4 - rational5);
            Console.WriteLine(rational4 * rational5);
            Console.WriteLine(rational4 / rational5);
        }
    }
}
