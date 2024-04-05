using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_OOP
{
    /// <summary>
    /// Класс рациональных дробей
    /// </summary>
    public class Rational
    {
        /// <summary>
        /// Числитель дроби
        /// </summary>
        public int Numerator { get; protected set; }
        /// <summary>
        /// Знаменатель дроби
        /// </summary>
        public int Denominator { get; protected set; }

        /// <summary>
        /// Стандартный конструктор дроби
        /// </summary>
        /// <param name="numerator">Числитель дроби</param>
        /// <param name="denominator">Знаменатель дроби</param>
        /// <exception cref="DivideByZeroException"></exception>
        public Rational(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new DivideByZeroException();
            if (denominator < 0)
            {
                numerator *= -1;
                denominator *= -1;
            }

            int nod;
            while ((nod = NOD(numerator, denominator)) != 1)
            {
                numerator /= nod;
                denominator /= nod;
            }

            Numerator = numerator;
            Denominator = denominator;
        }

        /// <summary>
        /// Преобразует дробь в строку
        /// </summary>
        /// <returns>Дробь в виде текста</returns>
        public override string ToString()
        {
            if (Denominator == 1)
                return Numerator.ToString();
            return $"{Numerator}/{Denominator}";
        }

        public static Rational operator -(Rational rational) => new Rational(-rational.Numerator, rational.Denominator);

        public static Rational operator +(Rational rational1, Rational rational2)
        {
            int nok = NOK(rational1.Denominator, rational2.Denominator);
            Rational rational = new(rational1.Numerator * (nok / rational1.Denominator) + rational2.Numerator * (nok / rational2.Denominator), nok);
            rational.Reduce();
            return rational;
        }

        public static Rational operator -(Rational rational1, Rational rational2)
        {
            int nok = NOK(rational1.Denominator, rational2.Denominator);
            Rational rational = new(rational1.Numerator * (nok / rational1.Denominator) - rational2.Numerator * (nok / rational2.Denominator), nok);
            rational.Reduce();
            return rational;
        }
        public static Rational operator *(Rational rational1, Rational rational2)
        {
            Rational rational = new(rational1.Numerator * rational2.Numerator, rational1.Denominator * rational2.Denominator);
            rational.Reduce();
            return rational;
        }

        public static Rational operator /(Rational rational1, Rational rational2)
        {
            Rational rational = new(rational1.Numerator * rational2.Denominator, rational1.Denominator * rational2.Numerator);
            if (rational.Denominator == 0)
                throw new DivideByZeroException();
            if (rational.Denominator < 0)
            {
                rational.Denominator *= -1;
                rational.Numerator *= -1;
            }
            rational.Reduce();
            return rational;
        }

        public static bool operator ==(Rational rational1, Rational rational2) =>
            (rational1.Numerator == rational2.Numerator) && (rational1.Denominator == rational2.Denominator);

        public static bool operator !=(Rational rational1, Rational rational2) =>
            !(rational1 == rational2);

        public static bool operator <(Rational rational1, Rational rational2)
        {
            int nok = NOK(rational1.Denominator, rational2.Denominator);
            return rational1.Numerator * (nok / rational1.Denominator) < rational2.Numerator * (nok / rational2.Denominator);
        }

        public static bool operator >(Rational rational1, Rational rational2)
        {
            int nok = NOK(rational1.Denominator, rational2.Denominator);
            return rational1.Numerator * (nok / rational1.Denominator) > rational2.Numerator * (nok / rational2.Denominator);
        }

        public static bool operator <=(Rational rational1, Rational rational2) =>
            (rational1 < rational2) || (rational1 == rational2);

        public static bool operator >=(Rational rational1, Rational rational2) =>
            (rational1 > rational2) || (rational1 == rational2);

        /// <summary>
        /// Сокращение дроби
        /// </summary>
        protected void Reduce()
        {
            int nod;
            while ((nod = NOD(Numerator, Denominator)) != 1)
            {
                Numerator /= nod;
                Denominator /= nod;
            }
        }

        /// <summary>
        /// Вычисляет НОК
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>НОК</returns>
        public static int NOK(int num1, int num2) => Math.Abs(num1 * num2) / NOD(num1, num2);

        /// <summary>
        /// Вычисляет НОД
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>НОД</returns>
        public static int NOD(int num1, int num2)
        {
            if (num2 < 0)
                num2 = -num2;
            if (num1 < 0)
                num1 = -num1;
            while (num2 > 0)
            {
                int temp = num2;
                num2 = num1 % num2;
                num1 = temp;
            }
            return num1;
        }

        /// <summary>
        /// Проверка на равенство двух объектов класса дроби
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>true в случае равенства, false в противном случае</returns>
        /// <exception cref="InvalidCastException"></exception>
        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (ReferenceEquals(obj, null))
            {
                return false;
            }

            if (obj.GetType() != GetType())
            {
                throw new InvalidCastException();
            }

            if (this == (Rational)obj)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
