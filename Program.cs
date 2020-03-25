using System;

namespace dz_if_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Задание 1
                    Выучите основные конструкции и понятия, рассмотренные на уроке.
            */      

            Console.WriteLine("(^_^) OK! :)");
            
            /*
                Задание 2
                    Даны две переменные целого типа: A и B. Если их значения не равны, то присвоить
                    каждой переменной большее из этих значений, а если равны, то присвоить переменным
                    нулевые значения. Вывести новые значения переменных A и B.
            */

            int A, B;
            int ter = 0;
                System.Console.Write("Vvedite A: ");
            A = int.Parse(Console.ReadLine());
                System.Console.Write("Vvedite B: ");
            B = int.Parse(Console.ReadLine());
            if(A != B)
            {
                ter = (A > B) ? B = A : A = B;
            } 
            else 
            {
                A = 0;
                B = 0;
            }
                Console.WriteLine("A = " + A + ", B = " + B + ".");

            //////////////////////////////////////////////////////////////////////////////////////////////////////
            // В написании кода были сложности, но используя материалы прошедших уроков, по моему справился ? 
            //
            //////////////////////////////////////////////////////////////////////////////////////////////////////

            /*
                Задание 3
                    Используя Visual Studio Code, создайте проект по шаблону Console Application.
                    Напишите программу - консольный калькулятор. Создайте две переменные с именами
                    operand1 и operand2. Задайте переменным некоторые произвольные значения.
                    Предложите пользователю ввести знак арифметической операции. Примите значение,
                    введенное пользователем, и поместите его в строковую переменную sign. Для
                    организации выбора алгоритма вычислительного процесса, используйте переключатель
                    switch. Выведите на экран результат выполнения арифметической операции. В случае
                    использования операции деления, организуйте проверку попытки деления на ноль. И
                    если таковая имеется, то отмените выполнение арифметической операции и уведомите
                    об ошибке пользователя.
            */

            double operand1 = 10;
            double operand2 = 0;
            string Message1 = "Delit na 0 NELZYA !!!";
            string Message2 = "Vi vveli NEVERNO !!!";
            string sign = null;
                Console.WriteLine("operand1 = " + operand1 + ";  operand2 = " + operand2 + ".");
        metka:  Console.Write("Vvedite odin iz operaciy: +, -, *, /: ");
                sign = Console.ReadLine();
            switch (sign)
            {
                case "+":
                {
                    Console.WriteLine(operand1 + operand2);
                    break;
                }
                case "-":
                {
                    Console.WriteLine(operand1 - operand2);
                    break;
                }
                case "*":
                {
                    Console.WriteLine(operand1 * operand2);
                    break;
                }
                case "/":
                {
                    if((operand1 == 0)||(operand2==0))
                    {
                        Console.WriteLine(Message1);
                        goto metka;
                    }
                    else
                    {
                    Console.WriteLine(operand1 / operand2);
                    } 
                    break; 
                }
                default:
                {
                    Console.WriteLine(Message2);
                    break;
                }
            }

            ////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Cложности были в восприятии задачи т.е. в понимании сути задачи. 
            // Еще в написании кода были сложности, но используя материалы прошедших уроков, по моему справился ? 
            // 
            ////////////////////////////////////////////////////////////////////////////////////////////////////////

            /*
                Задание 4
                    Используя Visual Studio Code, создайте проект по шаблону Console Application.
                    Напишите программу определения, попадает ли указанное пользователем число от 0 до
                    100 в числовой промежуток [0 - 14] [15 - 35] [36 - 50] [50 - 100]. Если да, то укажите, в
                    какой именно промежуток. Если пользователь указывает число, не входящее ни в один
                    из имеющихся числовых промежутков, то выводится соответствующее сообщение
            */

            byte chislo;
            string msg0_14 = "Vi vveli chislo v diapazone [0 - 14]";
            string msg15_35 = "Vi vveli chislo v diapazone [15 - 35]";
            string msg36_50 = "Vi vveli chislo v diapazone [36 - 50]";
            string msg51_100 = "Vi vveli chislo v diapazone [51 - 100]";
            string msgNO = "Vashe chislo NE NAHODITSYA v diapazone [0 - 100]";
                Console.Write("Vvedite chislo: ");
                chislo = byte.Parse(Console.ReadLine());
            switch(chislo)
            {
                case 0: case 1: case 2: case 3: case 4: case 5: case 6: case 7: 
                case 8: case 9: case 10: case 11: case 12: case 13: case 14:
                {   
                    Console.WriteLine(msg0_14);
                    break;
                }
                case 15: case 16: case 17: case 18: case 19: case 20: case 21: case 22: 
                case 23: case 24: case 25: case 26: case 27: case 28: case 29: case 30:
                case 31: case 32: case 33: case 34: case 35:
                {   
                    Console.WriteLine(msg15_35);
                    break;
                }
                case 36: case 37: case 38: case 39: case 40: case 41: case 42: case 43: 
                case 44: case 45: case 46: case 47: case 48: case 49: case 50:
                {   
                    Console.WriteLine(msg36_50);
                    break;
                }
                case 51: case 52: case 53: case 54: case 55: case 56: case 57: case 58: 
                case 59: case 60: case 61: case 62: case 63: case 64: case 65: case 66: 
                case 67: case 68: case 69: case 70: case 71: case 72: case 73: case 74:
                case 76: case 77: case 78: case 79: case 80: case 81: case 82: case 83:
                case 84: case 85: case 86: case 87: case 88: case 89: case 90: case 91:
                case 92: case 93: case 94: case 95: case 96: case 97: case 98: case 99:
                case 100:
                {   
                    Console.WriteLine(msg51_100);
                    break;
                }
                default:
                {
                    Console.WriteLine(msgNO);
                    break;
                }
            }
            
            Console.ReadKey();
            
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Cложности были в восприятии задачи т.е. в понимании сути задачи, 
            // не зря говорят - понять задачу - это - уже наполовину решить ее. 
            // В написании кода были сложности, 
            // но используя материалы прошедших уроков, по моему справился ?
            // :)
            // 
            // Что делать когда даже если (непонял)||(понял) задачу, 
            // но не можешь написать код (ну не получается вообще) ?
            //  
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}