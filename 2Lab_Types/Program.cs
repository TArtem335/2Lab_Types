using System;
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
            sbyte sbNumber = -34;
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

            // Задание 2d.
            Console.WriteLine("----------------Задание 2d----------------");
            StringBuilder stringBuild = new StringBuilder("АЛЫЛВЫЛ", 30);
            Console.WriteLine($"Строка, содержащая {stringBuild.Length} символов: \n\t{stringBuild.ToString()}");
            stringBuild.Append(new char[] { 'А', 'В', 'Д' });
            Console.WriteLine($"Строка, после добавление символов А, В, Д: \n\t{stringBuild.ToString()}");
            stringBuild.Insert(0, "Случайные большие буквы: ");
            Console.WriteLine($"Строка, после добавления подстроки в начало: \n\t{stringBuild.ToString()}");
            stringBuild.Insert(stringBuild.Length, " - случайные большие буквы (не только)");
            Console.WriteLine($"Строка, после добавления подстроки в конец: \n\t{stringBuild.ToString()}");
            stringBuild.Replace('А', 'о');
            Console.WriteLine($"Строка, после замены символов А на о: \n\t{stringBuild.ToString()}");
            stringBuild.Remove(7, 3);
            Console.WriteLine($"Строка, после удаления подстроки: \n\t{stringBuild.ToString()}");

            Console.ReadKey();
            Console.Clear();

            // Задание 3a.
            Console.WriteLine("----------------Задание 3a----------------");
            int[,] numbersArr = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } };
            for (int i = 0; i < numbersArr.GetUpperBound(0) + 1; ++i)
            {
                for (int j = 0; j < numbersArr.Length / (numbersArr.GetUpperBound(0) + 1); ++j)
                {
                    Console.Write("{0, 4}", numbersArr[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
            Console.Clear();

            // Задание 3b.
            Console.WriteLine("----------------Задание 3b----------------");
            string[] wordsArr = { "Первая строка", "Вторая строка", "Третья строка" };
            for (int i = 0; i < wordsArr.Length; ++i)
            {
                Console.WriteLine(wordsArr[i]);
            }
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"Длина массива (количество строк в массиве) - {wordsArr.Length}");
            Console.WriteLine("--------------------------------------------------");
            Console.Write("Введите номер строки, которую желаете изменить: ");
            int arrIndex = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.Write("Введите текст: ");
            wordsArr[arrIndex] = Console.ReadLine();
            Console.WriteLine("--------------------------------------------------");
            for (int i = 0; i < wordsArr.Length; ++i)
            {
                Console.WriteLine(wordsArr[i]);
            }

            Console.ReadKey();
            Console.Clear();

            // Задание 3c.
            Console.WriteLine("----------------Задание 3c----------------");
            float[][] juggedNumbersArr = new float[3][];
            juggedNumbersArr[0] = new float[] { 1.234f, 2.234f };
            juggedNumbersArr[1] = new float[] { 4.23f, 5.4f, 23.4f };
            juggedNumbersArr[2] = new float[] { 6.23434f, 7f, 8.2f, 9.0f };

            Console.WriteLine("Вы хотите ввести значение переменных(Y/N): ");
            input = Convert.ToChar(Console.ReadLine());
            if (input == 'Y' || input == 'y' || input == 'н' || input == 'Н')
            {
                for (int i = 0; i < 2; ++i)
                {
                    Console.Write($"Введите {i + 1} вещественное число для 1 массива: ");
                    juggedNumbersArr[0][i] = Convert.ToSingle(Console.ReadLine());
                }
                for (int i = 0; i < 3; ++i)
                {
                    Console.Write($"Введите {i + 1} вещественное число для 2 массива: ");
                    juggedNumbersArr[1][i] = Convert.ToSingle(Console.ReadLine());
                }
                for (int i = 0; i < 4; ++i)
                {
                    Console.Write($"Введите {i + 1} вещественное число для 3 массива: ");
                    juggedNumbersArr[2][i] = Convert.ToSingle(Console.ReadLine());
                }
            }

            for (int i = 0; i < juggedNumbersArr.Length; ++i)
            {
                for (int j = 0; j < juggedNumbersArr[i].Length; ++j)
                {
                    Console.Write("{0, 8}", juggedNumbersArr[i][j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
            Console.Clear();

            // Задание 3d.
            Console.WriteLine("----------------Задание 3d----------------");
            var someArr = new int[] { 1, 2, 3 };
            var someStr = "Ffffffffffff";

            Console.Write("Неявно типизированный массив - ");
            for (int i = 0; i < someArr.Length; ++i)
            {
                Console.Write("{0, 4}", someArr[i]);
            }
            Console.WriteLine();
            Console.WriteLine($"Неявно типизированна строка - {someStr}");

            Console.ReadKey();
            Console.Clear();

            // Задание 4.
            Console.WriteLine("----------------Задание 4----------------");
            (int, string, char, string, ulong) turpleVariable = (5, "Text", 'o', "txt", 234424);

            Console.WriteLine($"Кортеж - {turpleVariable}");
            Console.WriteLine($"1 элемент кортежа - {turpleVariable.Item1}");
            Console.WriteLine($"3 элемент кортежа - {turpleVariable.Item3}");
            Console.WriteLine($"4 элемент кортежа - {turpleVariable.Item4}");
            Console.WriteLine();

            (int numberFrmTurple, string str1FrmTurple, char charFrmTurple, string str2FrmTurple, ulong ulongFrmTurple) = turpleVariable;
            var (numberFrmTurple2, str1FrmTurple2, charFrmTurple2, str2FrmTurple2, ulongFrmTurple2) = turpleVariable;
            int numberFrmTurple3;
            string str1FrmTurple3;
            char charFrmTurple3;
            string str2FrmTurple3;
            ulong ulongFrmTurple3;
            (numberFrmTurple3, str1FrmTurple3, charFrmTurple3, str2FrmTurple3, ulongFrmTurple3) = turpleVariable;
            (numberFrmTurple3, _, _, str2FrmTurple3, _) = turpleVariable;

            (int, string, char, string, ulong) turpleVariable2 = turpleVariable;
            (int, string, char, string, ulong) turpleVariable3 = (6, "Dsdffs", 'g', "sfdsfs", 924242535);
            Console.WriteLine($"Кортеж 1 - {turpleVariable}");
            Console.WriteLine($"Кортеж 2 - {turpleVariable2}");
            Console.WriteLine($"Кортеж 3 - {turpleVariable3}");
            Console.WriteLine("");
            if (turpleVariable == turpleVariable2)
            {
                Console.WriteLine($"Кортеж 1 = кортежу 2");
            }
            else
            {
                Console.WriteLine($"Кортеж 1 != кортежу 2");
            }

            if (turpleVariable2 == turpleVariable3)
            {
                Console.WriteLine($"Кортеж 2 = кортежу 3");
            }
            else
            {
                Console.WriteLine($"Кортеж 2 != кортежу 3");
            }

            if (turpleVariable == turpleVariable3)
            {
                Console.WriteLine($"Кортеж 1 = кортежу 3");
            }
            else
            {
                Console.WriteLine($"Строка 1 != строке 3");
            }

            Console.ReadKey();
            Console.Clear();

            // Задание 5.
            Console.WriteLine("----------------Задание 5----------------");
            int[] someArrForFunc = { 3, 5, 6, 4, 2, 43, 5, 0, 1 };
            string someStringForFunc = "Hsd ksdjjsh sjkdhj skjdhsd";
            Console.Write($"Массив - ");
            for (int i = 0; i < someArrForFunc.Length; ++i)
            {
                Console.Write(someArrForFunc[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Строка - {someStringForFunc}");
            (int max, int min, int summ, char letter) = someFunc(someArrForFunc, someStringForFunc);
            Console.WriteLine($"Максимальный элемент массива - {max}\n" +
                $"Минимальный элемент массива - {min}\n" +
                $"Сумма элементов массива - {summ}\n" +
                $"Первый символ строки - {letter}");

            Console.ReadKey();
            Console.Clear();

            // Задание 6.
            Console.WriteLine("----------------Задание 6----------------");
            Console.WriteLine($"Используя unchecked - {maxIntNumber2()}");
            Console.WriteLine($"Используя checked - {maxIntNumber1()}");
            
            Console.ReadKey();
            Console.Clear();
        }

        static (int, int, int, char) someFunc(int[] arr, string str)
        {
            int max = arr[0];
            int min = arr[0];
            int summ = 0;
            char letter = str[0];

            for (int i = 0; i < arr.Length; ++i)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }

                summ += arr[i];
            }

            return (max, min, summ, letter);
        }

        static int maxIntNumber1()
        {
            int seven = 7;
            int number = checked(2_147_483_647 + seven);

            return number;
        }

        static int maxIntNumber2()
        {
            int seven = 7;
            int number = unchecked(2_147_483_647 + seven);

            return number;
        }
    }
}
