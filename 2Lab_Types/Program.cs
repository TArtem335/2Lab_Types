﻿using System;
using System.Text;

namespace _2Lab_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 1a.
            Console.WriteLine("----------------Задание 1a----------------");
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
            Console.WriteLine("----------------Задание 1d----------------");
            var someVariable1 = 54;
            var someVariable2 = "Some text";
            Console.WriteLine($"Первая неявно типизированная переменная: {someVariable1}");
            Console.WriteLine($"Вторая неявно типизированная переменная: {someVariable2}");

            Console.ReadKey();
            Console.Clear();

            // Задание 1e.
            Console.WriteLine("----------------Задание 1e----------------");
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
            Console.WriteLine("----------------Задание 1f----------------");
            var someVarVaruable = "Hello There";
            Console.WriteLine($"Переменная типа var: {someVarVaruable}");
            //someVarVaruable = 5;

            Console.ReadKey();
            Console.Clear();

            // Задание 2a.
            Console.WriteLine("----------------Задание 2a----------------");
            string word1 = "First string";
            string word2 = "Second string";
            string word3 = "First string";

            Console.WriteLine($"Строка 1: {word1}");
            Console.WriteLine($"Строка 2: {word2}");
            Console.WriteLine($"Строка 3: {word3}");
            Console.WriteLine("");

            if (word1 == word2)
            {
                Console.WriteLine($"Строка 1 = строке 2");
            }
            else
            {
                Console.WriteLine($"Строка 1 != строке 2");
            }

            if (word2 == word3)
            {
                Console.WriteLine($"Строка 2 = строке 3");
            }
            else
            {
                Console.WriteLine($"Строка 2 != строке 3");
            }

            if (word1 == word3)
            {
                Console.WriteLine($"Строка 1 = строке 3");
            }
            else
            {
                Console.WriteLine($"Строка 1 != строке 3");
            }

            Console.ReadKey();
            Console.Clear();

            // Задание 2b.
            Console.WriteLine("----------------Задание 2b----------------");
            Console.WriteLine($"Строка 1: {word1}");
            Console.WriteLine($"Строка 2: {word2}");
            Console.WriteLine($"Строка 3: {word3}");
            Console.WriteLine("");

            Console.WriteLine($"Конкатанация: {word1 + word2}");
            string word4 = (string)word1.Clone();
            Console.WriteLine($"Копирование: {word4}");
            Console.WriteLine($"Выделение подстроки строки {word4} (5 элементов начиная с 3 позиции): {word4.Substring(2, 5)}");

            Console.WriteLine();
            string sentence = "Some example of very very long sentence";
            string[] words = sentence.Split(' ');
            Console.WriteLine($"Начальная строка: {sentence}");
            Console.Write("Разделение строки на слова: ");
            foreach (string wordI in words)
            {
                Console.Write($"{wordI}, ");
            }
            Console.WriteLine();

            Console.WriteLine($"Вставка подстроки (с 2 позиции): {word4.Insert(2, word2)}");
            Console.WriteLine($"Удаление подстроки (3 элементов начиная с 2 позиции): {word4.Remove(1, 3)}");

            Console.ReadKey();
            Console.Clear();

            // Задание 2c.
            Console.WriteLine("----------------Задание 2c----------------");
            string wordEmpty = "";
            string wordNull = null;

            if (string.IsNullOrEmpty(wordEmpty))
            {
                Console.WriteLine("Строка wordEmpty пуста или равна null");
            }
            else
            {
                Console.WriteLine("Строка wordEmpty не пуста и не равна null");
            }

            if (string.IsNullOrEmpty(wordNull))
            {
                Console.WriteLine("Строка wordNull пуста или равна null");
            }
            else
            {
                Console.WriteLine("Строка wordNull не пуста и не равна null");
            }

            if (string.IsNullOrEmpty(word4))
            {
                Console.WriteLine("Строка word4 пуста или равна null");
            }
            else
            {
                Console.WriteLine("Строка word4 не пуста и не равна null");
            }

            Console.ReadKey();
            Console.Clear();

            // Задание 2c.
            Console.WriteLine("----------------Задание 2c----------------");
            StringBuilder stringBuild = new StringBuilder("АЛЫЛВЫЛ", 30);
            Console.WriteLine($"Строка, содержащая {stringBuild.Length} символов: {stringBuild.ToString()}");
            stringBuild.Append(new char[] { 'А', 'В', 'Д' });
            Console.WriteLine($"Строка, содержащая {stringBuild.Length} символов: {stringBuild.ToString()}");
            stringBuild.Insert(0, "Случайные большие буквы: ");
            Console.WriteLine($"Строка, содержащая {stringBuild.Length} символов: {stringBuild.ToString()}");
            stringBuild.Insert(stringBuild.Length, " - случайные большие буквы (не только)");
            Console.WriteLine($"Строка, содержащая {stringBuild.Length} символов: {stringBuild.ToString()}");
            stringBuild.Replace('А', 'о');
            Console.WriteLine($"Строка, содержащая {stringBuild.Length} символов: {stringBuild.ToString()}");
            stringBuild.Remove(7, 3);
            Console.WriteLine($"Строка, содержащая {stringBuild.Length} символов: {stringBuild.ToString()}");

            Console.ReadKey();
            Console.Clear();
        }
    }
}
