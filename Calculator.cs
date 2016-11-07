using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorRUEN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine ("1 - English(BETA) 2 - Русский");
            var lauguage = Console.ReadLine();
            if (lauguage == "1" || lauguage == "English")
            {
                while (true)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Enter the first number");
                    String a = Console.ReadLine();
                    Console.WriteLine("Enter the second number");
                    String b = Console.ReadLine();

                    Double num1 = Double.Parse(a);
                    Double num2 = Double.Parse(b);

                    Double CLO;//Сумма
                    Double BI;//Разность
                    Double YMN;//Произведение
                    Double DEL;//Частное
                    Double CR;//Среднее значение
                    Double KV;//Квадрат
                    Double KV1;//Квадрат1
                    Double KUB;//Куб
                    Double KUB1;//Куб1
                    Double POC;//Процент от числа
                    Double POC1;//Процент от числа1
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    CLO = num1 + num2;//Сумма
                    Console.WriteLine((a) + " + " + (b) + " = " + (CLO));
                    BI = num1 - num2;//Разность
                    Console.WriteLine((a) + " - " + (b) + " = " + (BI));
                    YMN = num1 * num2;//Произведение
                    Console.WriteLine((a) + " * " + (b) + " = " + (YMN));
                    DEL = num1 / num2;//Частное
                    Console.WriteLine((a) + " / " + (b) + " = " + (DEL));
                    CR = (num1 + num2) / 2;//Среднее значение
                    Console.WriteLine("Average value " + (a) + " and " + (b) + " = " + (CR));
                    KV = num1 * num1;//Квадрат
                    KV1 = num2 * num2;
                    Console.WriteLine("Squared " + (a) + " = " + (KV));
                    Console.WriteLine("Squared " + (b) + " = " + (KV1));
                    KUB = num1 * num1 * num1;//Куб
                    KUB1 = num2 * num2 * num2;
                    Console.WriteLine("Cube " + (a) + " = " + (KUB));
                    Console.WriteLine("Cube " + (b) + " = " + (KUB1));
                    POC = (num1 / num2) * 100;//Процент от числа
                    POC1 = (num2 / num1) * 100;
                    Console.WriteLine("Number " + (a) + " is " + (POC) + "%" + " of the number " + (b));
                    Console.WriteLine("Number " + (b) + " is " + (POC1) + "%" + " of the number " + (a));
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
                if (lauguage == "2" || lauguage == "Русский")
                {
                while (true)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Введите 1 число");
                    String a = Console.ReadLine();
                    Console.WriteLine("Введите 2 число");
                    String b = Console.ReadLine();

                    Double num1 = Double.Parse(a);
                    Double num2 = Double.Parse(b);
                    Double CLO;//Сумма
                    Double BI;//Разность
                    Double YMN;//Произведение
                    Double DEL;//Частное
                    Double CR;//Среднее значение
                    Double KV;//Квадрат
                    Double KV1;//Квадрат1
                    Double KUB;//Куб
                    Double KUB1;//Куб1
                    Double POC;//Процент от числа
                    Double POC1;//Процент от числа1
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    CLO = num1 + num2;//Сумма
                    Console.WriteLine((a) + " + " + (b) + " = " + (CLO));
                    BI = num1 - num2;//Разность
                    Console.WriteLine((a) + " - " + (b) + " = " + (BI));
                    YMN = num1 * num2;//Произведение
                    Console.WriteLine((a) + " * " + (b) + " = " + (YMN));
                    DEL = num1 / num2;//Частное
                    Console.WriteLine((a) + " / " + (b) + " = " + (DEL));
                    CR = (num1 + num2) / 2;//Среднее значение
                    Console.WriteLine("Среднее значение " + (a) + " и " + (b) + " равно " + (CR));
                    KV = num1 * num1;//Квадрат
                    KV1 = num2 * num2;
                    Console.WriteLine("Квадрат " + (a) + " Равен " + (KV));
                    Console.WriteLine("Квадрат " + (b) + " Равен " + (KV1));
                    KUB = num1 * num1 * num1;//Куб
                    KUB1 = num2 * num2 * num2;
                    Console.WriteLine("Куб " + (a) + " Равен " + (KUB));
                    Console.WriteLine("Куб " + (b) + " Равен " + (KUB1));
                    POC = (num1 / num2) * 100;//Процент от числа
                    POC1 = (num2 / num1) * 100;
                    Console.WriteLine("Число " + (a) + " Составляет " + (POC) + "%" + " От числа " + (b));
                    Console.WriteLine("Число " + (b) + " Составляет " + (POC1) + "%" + " От числа " + (a));
                    Console.ForegroundColor = ConsoleColor.Gray;
                }

            }
            if (lauguage == "3" || lauguage ==  "How Made")
            {
                Console.WriteLine("Made by qazxswedx, 2016");
                Console.ReadLine();
            }

           
            else
            {
                Console.WriteLine("Error");
                Console.ReadLine();
            }
        }
    }
}
