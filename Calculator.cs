using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Double Result;
                Console.WriteLine("Введите 1 число");
                String a = Console.ReadLine();
                Console.WriteLine("Введите 2 число");
                String b = Console.ReadLine();

                Double num1 = Double.Parse(a);
                Double num2 = Double.Parse(b);

                Console.WriteLine("Выберите действие-(1)Сложение (2)Вычитание (3) Умножение (4) Деление (5)Среднее значение (6)Квадрат (7)Куб (8)Процент от числа (9)Показать все");
                String DE = Console.ReadLine();
                Double DE1 = Int32.Parse(DE);
                if (DE1 == 1)//Сумма
                {
                    Result = num1 + num2;
                    Console.WriteLine((a) + "+" + (b) + "=" + (Result));
                }
                if (DE1 == 2)//Разность
                {
                    Result = num1 - num2;
                    Console.WriteLine((a) + "-" + (b) + "=" + (Result));
                }
                if (DE1 == 3)//Произведение
                {
                    Result = num1 * num2;
                    Console.WriteLine((a) + "*" + (b) + "=" + (Result));
                }
                if (DE1 == 4)//Част
                {
                    Result = num1 / num2;
                    Console.WriteLine((a) + "/" + (b) + "=" + (Result));
                }
                if (DE1 == 5)//Среднее значение
                {
                    Result = (num1 + num2) / 2;
                    Console.WriteLine("Среднее значение " + (a) + " и " + (b) + " равно " + (Result));
                }
                if (DE1 == 6)//Квадрат
                {
                    Double Result1;
                    Result = num1 * num1;
                    Result1 = num2 * num2;
                    Console.WriteLine("Квадрат" + (a) + "Равен" + (Result));
                    Console.WriteLine("Квадрат" + (b) + "Равен" + (Result1));
                }
                if (DE1 == 7)//Куб
                {
                    Double Result1;
                    Result = num1 * num1 * num1;
                    Result1 = num2 * num2 * num2;
                    Console.WriteLine("Куб " + (a) + " Равен " + (Result));
                    Console.WriteLine("Куб " + (b) + " Равен " + (Result1));
                }
                if (DE1 == 8)//Процент от числа
                {
                    Double Result1;
                    Result = (num1 / num2) * 100;
                    Result1 = (num2 / num1) * 100;
                    Console.WriteLine("Число " + (a) + " Составляет" + (Result) + "%" + " От числа " + (b));
                    Console.WriteLine("Число " + (b) + " Составляет " + (Result) + "%" + " От числа " + (a));

                }
                if (DE1 == 9)
                {
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
                    Console.WriteLine((a) + "+" + (b) + "=" + (CLO));
                    BI = num1 - num2;//Разность
                    Console.WriteLine((a) + "-" + (b) + "=" + (BI));
                    YMN = num1 * num2;//Произведение
                    Console.WriteLine((a) + "*" + (b) + "=" + (YMN));
                    DEL = num1 / num2;//Частное
                    Console.WriteLine((a) + "/" + (b) + "=" + (DEL));
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
                }

                else
                {
                    Console.WriteLine("Ну и зачем ты это написал");
                }
                Console.ReadLine();
            }
               


        }
    }
}
