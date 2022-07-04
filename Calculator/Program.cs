using System;

namespace Calculator
{
    class Program
    {
        //Напиши калькулятор.
        //это должно быть консольное приложение,
        //которое просит тебя ввести два числа и потом просит тебя сказать,
        //что с ними сделать

        //должно быть четыре метода:
        //    sum(int i, int j); - сумма
        //    sub(int i, int j); - вычитание
        //    mul(int i, int j); - умножение
        //    div(int i, int j); - деление

        //может понадобиться:
        //int a = int.Parse(Console.ReadLine());
        //switch
        //if - else

        //не забудь как-нибудь обработать условие, что на ноль делить нельзя, я проверю!
        static void Main(string[] args)
        {

            int i, j;
            string action;

            Console.WriteLine("Пиши любую цифэрку");
            i = int.Parse(Console.ReadLine());

            Console.WriteLine("Пиши еще цифэрку");
            j = int.Parse(Console.ReadLine());

            Console.WriteLine("Выбирай давай: + - * /");
            action = Console.ReadLine();

            Console.WriteLine("Ответ: ");

            switch (action)
            {

                case "+":
                    Console.WriteLine(i + j);
                    break;

                  case "-":
                     Console.WriteLine(i - j);
                     break;

                case "*":
                    Console.WriteLine(i * j);
                    break;

                case "/":

                    if (j == 0)
                    {

                        Console.WriteLine(0);

                    }
                    else 
                    {
                        Console.WriteLine(i / j);
                    }
               
                    break;



            }

            
            
        }
    }
}
