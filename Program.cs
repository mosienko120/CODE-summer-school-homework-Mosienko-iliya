﻿using System;

namespace CalculatorX
{
    class Program
    {
        static void Main(string[] args)
        {
           double a;
           double b;
           double total;
           char oper;
           //Мы обьявили переменные
           Console.WriteLine("Введите первое число");
           a = Convert.ToDouble(Console.ReadLine());
           // Пользователь вводит первое число
            Console.WriteLine("Введите оператор");
            oper  = Convert.ToChar(Console.ReadLine());
            //Пользователь вводит оператор
             Console.WriteLine("Введите второе число");
            b = Convert.ToDouble(Console.ReadLine());
            //Пользователь вводит второе  число
            if (oper == '+')
            {
             
          total = a + b;
          Console.WriteLine("Cумма " + a + " и " + b + " равна " + total + ".");
            
            }
                    else if (oper == '-')
                {
                    total = a - b;
                    Console.WriteLine("Разность " + a + " и " + b + " равна " + total + ".");
                }
 
                else if (oper == '*')
                {
                    total = a * b;
                    Console.WriteLine("Умножение " + a + " на " + b + " равно " + total + ".");
                }
 
                else if (oper == '/')
                {
                    total = a / b;
                    Console.WriteLine("Деление " + a + " на " + b + " равно " + total + ".");
                }
                else
                {
                   
                 
                    Console.WriteLine("Неизвестный оператор.");
                }
        
        }

        private static void NewMethod()
        {
            ;
        }
    }
    }
