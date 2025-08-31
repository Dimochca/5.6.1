using System;
using System.Net.Http.Headers;

class Programm
{
    static void Main(string[] args)
    {
        int numberp = 0;
        Console.Write("Введите ваше имя: ");
        var name = Console.ReadLine();
        Console.Write("Введите ваше фамилие: ");
        var surname = Console.ReadLine();
        Console.Write("Введите ваш возраст: ");
        var age = int.Parse(Console.ReadLine());
        Console.Write("Есть ли у вас питомец (yes/no): ");
        var haspet = Console.ReadLine();
        if (haspet == "yes")
        {
            Console.Write("Сколько у вас питомцев: ");
            numberp = int.Parse(Console.ReadLine());
            
        }
        string[] petsname = new string[numberp];
        petsname = Pet(numberp);
        Console.Write("Сколько у вас любимых цветов: ");
        var numberc = int.Parse(Console.ReadLine());
        static string[] Pet(int number)
        {
            string[] petsname = new string[number];
            Console.WriteLine("Введите их клички");
            for (int i = 0; i < number; i++)
            {
                petsname[i] = Console.ReadLine();
            }
            return (petsname);
        }
        string[] faworitcolors = new string[numberc];
        faworitcolors = Color(numberc);

        static string[] Color(int number)
        {
            string[] faworitcolors = new string[number];
            Console.WriteLine("Введите ваши любимые цвета");
            for (int i = 0; i < number; i++)
            {
                faworitcolors[i] = Console.ReadLine();
            }
            return (faworitcolors);
        }

        Сheck(age, numberp, numberc);
        static void Сheck(int age, int numberp, int numberc)
        {
            if (age < 0) 
            {
                Console.Write("Возраст не может быть меньше 0, введите возраст снова: ");
                age = int.Parse(Console.ReadLine());
            }
            if (numberp < 0)
            {
                Console.Write("Количество питомцев не может быть меньше 0");
                numberp = int.Parse(Console.ReadLine());
                Pet(numberp);
            }
            if (numberc < 0)
            {
                Console.Write("Количество любимых цветов не может быть меньше 0");
                numberc = int.Parse(Console.ReadLine());
                Color(numberc);
            }
        }
        Answer(name, surname, age, haspet, numberp, petsname, numberc, faworitcolors);
        static void Answer(string name, string surname, int age, string haspet, int numberp, string[] petsname, int numberc, string[] faworitcolors)
        {
            Console.WriteLine("Ваше имя - {0}\nВаше фамилие - {1}\nВаш возраст - {2}\nЕсть ли у вас питомец - {3}\nКоличество питомцев - {4}\nИх клички - {5}\nКоличество ваших любимых цветов - {6}\nВаши любимые цвета - {7}", name, surname, age, haspet, numberp, petsname, numberc, faworitcolors);
        }
        Console.ReadKey();
    }
}