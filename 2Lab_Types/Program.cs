using System;

namespace _2Lab_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 1a.
            bool flag = false;

            byte bNumber = 112;
            sbyte sbNumber =-34;
            short sNumber = -25000;
            ushort usNumber = 57000;
            int intNumber = -23423424;
            uint uintNumber = 32424424;
            long lNumber = -25234234242;
            ulong ulNumber = 93122423425;
            float flNumber = 234.342F;
            double dbNumber = 322.2342424D;
            decimal dNumber = 1231.13213141414M;

            char symbol = 'G';
            string word = "Hello world!";

            Console.WriteLine("Вы хотите ввести значение переменных(Y/N): ");
            char input = Convert.ToChar(Console.ReadLine());
            if (input == 'Y' || input == 'y' || input == 'н' || input == 'Н')
            {
                Console.Write("Введите логическую переменную: ");
                flag = Convert.ToBoolean(Console.ReadLine());
                Console.Write("Введите Byte переменную: ");
                bNumber = Convert.ToByte(Console.ReadLine());

                Console.Write("Введите SByte переменную: ");
                sbNumber = Convert.ToSByte(Console.ReadLine());
                Console.Write("Введите Short переменную: ");
                sNumber = Convert.ToInt16(Console.ReadLine());
                Console.Write("Введите UShort переменную: ");
                usNumber = Convert.ToUInt16(Console.ReadLine());
                Console.Write("Введите Int переменную: ");
                intNumber = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите UInt переменную: ");
                uintNumber = Convert.ToUInt32(Console.ReadLine());
                Console.Write("Введите Long переменную: ");
                lNumber = Convert.ToInt64(Console.ReadLine());
                Console.Write("Введите ULong переменную: ");
                ulNumber = Convert.ToUInt64(Console.ReadLine());

                Console.Write("Введите Float переменную: ");
                flNumber = Convert.ToSingle(Console.ReadLine());
                Console.Write("Введите Double переменную: ");
                dbNumber = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите Decimal переменную: ");
                dNumber = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Введите символьную переменную: ");
                symbol = Convert.ToChar(Console.ReadLine());
                Console.Write("Введите строковую переменную: ");
                word = Console.ReadLine();
            }

            Console.WriteLine($"Переменная типа bool - {flag}");

            Console.WriteLine($"Переменная типа byte - {bNumber}");
            Console.WriteLine($"Переменная типа signed byte - {sbNumber}");
            Console.WriteLine($"Переменная типа short - {sNumber}");
            Console.WriteLine($"Переменная типа unsigned short - {usNumber}");
            Console.WriteLine($"Переменная типа int - {intNumber}");
            Console.WriteLine($"Переменная типа unsigned int - {uintNumber}");
            Console.WriteLine($"Переменная типа long - {lNumber}");
            Console.WriteLine($"Переменная типа unsigned long - {ulNumber}");

            Console.WriteLine($"Переменная типа float - {flNumber}");
            Console.WriteLine($"Переменная типа double - {dbNumber}");
            Console.WriteLine($"Переменная типа decimal - {dNumber}");

            Console.WriteLine($"Переменная типа char - {symbol}");
            Console.WriteLine($"Переменная типа string - {word}");

            Console.ReadKey();
            Console.Clear();

            // Задание 1b.
            lNumber = intNumber;
            intNumber = sNumber;
            uintNumber = usNumber;
            ulNumber = uintNumber;
            ulNumber = usNumber;

            intNumber = (int)lNumber;
            sNumber = (short)intNumber;
            usNumber = (ushort)uintNumber;
            uintNumber = (uint)ulNumber;
            usNumber = (ushort)ulNumber;

            // Задание 1c.
            object intWrap = intNumber;
            int intNumber2 = (int)intWrap;

            // Задание 1d.
            var someVariable1 = 54;
            var someVariable2 = "Some text";
            Console.WriteLine($"Первая неявно типизированная переменная: {someVariable1}");
            Console.WriteLine($"Вторая неявно типизированная переменная: {someVariable2}");

            Console.ReadKey();
            Console.Clear();

            // Задание 1e.
            int? nullableNumber = null;

            Random rng = new Random();
            int rand = rng.Next(0, 1);
            if (rand == 1)
            {
                nullableNumber = rng.Next(1000);
            }

            if (nullableNumber.HasValue)
            {
                Console.WriteLine($"Значение переменной - {nullableNumber}");
            }
            else
            {
                Console.WriteLine("Значение переменной - null");
            }

            Console.ReadKey();
            Console.Clear();

            // Задание 1f.
            var someVarVaruable = "Hello There";
            Console.WriteLine($"Переменная типа var: {someVarVaruable}");
            //someVarVaruable = 5;

            Console.ReadKey();
            Console.Clear();
        }
    }
}
