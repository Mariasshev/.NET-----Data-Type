using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1

            //Console.WriteLine("Введите число в диапазоне от 1 до 100: ");
            //int userNum = int.Parse(Console.ReadLine());

            //if(userNum < 1 || userNum > 100)
            //{
            //    Console.WriteLine("Ошибка. Число не подходит под диапазон 1-100");
            //}
            //else
            //{
            //    if(userNum % 3 == 0 && userNum % 5 != 0)
            //    {
            //        Console.WriteLine("Fizz!");
            //    }
            //    else if(userNum % 5 == 0 && userNum % 3 != 0)
            //    {
            //        Console.WriteLine("Buzz!");
            //    }
            //    else if( userNum % 3 == 0 && userNum % 5 == 0) {

            //        Console.WriteLine("Fizz! Buzz!");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Number: {userNum}");
            //    }
            //}

            #endregion

            #region Task 2

            //Console.WriteLine("Введите число: ");
            //int userNum = int.Parse(Console.ReadLine());

            //Console.WriteLine("Введите процент: ");
            //int userPercent = int.Parse(Console.ReadLine());

            //double result = Convert.ToDouble(userNum * userPercent) / 100;

            //Console.WriteLine($"Result: {userPercent}% from {userNum}  = {result}");

            #endregion

            #region Task 3

            //string resNum = "";
            //for(int i = 0; i < 4; i++) {
            //    Console.WriteLine($"Введите {i+1} цифру: ");
            //    resNum += Convert.ToString(Console.ReadLine());
            //}

            //Console.WriteLine($"Result: {resNum}");

            #endregion

            #region Task 4

            Console.Write("Enter 6-digit number: ");
            int userNum = int.Parse(Console.ReadLine());

            if(userNum.ToString().Length != 6)
            {
                Console.WriteLine("Wrong number!");
            }
            else
            {
                int[] arr = new int[6];

                string str = userNum.ToString();
                
                for(int i  = 0; i < arr.Length; i++)
                {
                    arr[i] = str[1];
                    Console.Write(arr[i] + "");
                }
            }

            #endregion

            #region Task 5
            //Console.WriteLine("Введите дату");
            //Console.WriteLine("День");
            //int day = int.Parse(Console.ReadLine());
            //Console.WriteLine("Месяц");
            //int month = int.Parse(Console.ReadLine());
            //Console.WriteLine("Год");
            //int year = int.Parse(Console.ReadLine());

            //DateTime dt = new DateTime(year, month, day);

            //string season;

            //if (month < 1 || month > 12)
            //{
            //    Console.WriteLine("Некорректный номер месяца.");
            //    return; 
            //}

            //if (month == 12 || month <= 2) // Декабрь, Январь, Февраль
            //{
            //    season = "Winter";
            //}
            //else if (month >= 3 && month <= 5) // Март, Апрель, Май
            //{
            //    season = "Spring";
            //}
            //else if (month >= 6 && month <= 8) // Июнь, Июль, Август
            //{
            //    season = "Summer";
            //}
            //else // Сентябрь, Октябрь, Ноябрь
            //{
            //    season = "Autumn";
            //}

            //Console.WriteLine($"{season} {dt.DayOfWeek.ToString()}");

            #endregion

            #region Task 6
            //Console.WriteLine("Введите температуру");
            //int userTemp = int.Parse(Console.ReadLine());
            //Console.WriteLine("Перевести в Цельсии(1) или Фаренгейты(2)?");
            //int choice = int.Parse(Console.ReadLine());

            //if(choice == 1)
            //{
            //    double celsius = (userTemp - 32) * 5 / 9;
            //    Console.WriteLine($"{userTemp} °F = {celsius} °C");
            //}
            //else if(choice == 2)
            //{
            //    double fahrenheit = (userTemp * 9 / 5) + 32;
            //    Console.WriteLine($"{userTemp} °C = {fahrenheit} °F");
            //}
            //else
            //{
            //    Console.WriteLine("Неверное значение!");
            //}

            #endregion

            #region Task 7
 
            //Console.Write("1 число: ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("2 число: ");
            //int b = int.Parse(Console.ReadLine());
            //int temp;

            //if(a > b)
            //{
            //    temp = a;
            //    a = b;
            //    b = temp;
            //}

            //Console.WriteLine("Result: ");
            //for(int i = a; i <= b; i++)
            //{
            //    if(i % 2 == 0)
            //    {
            //        Console.Write(i + "");
            //    }
            //}
            //Console.WriteLine("");

            #endregion
        }
    }
}
