using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Methods_module
{
    class Program
    {
        static (string Name, string LastName, int Age, string[] PetNames, string[] FavColors) Enteruser()
        {
            (string Name, string LastName, int Age, string[] PetNames, string[] FavColors) User;
            Console.WriteLine("Введите Ваше имя!");
            User.Name = Console.ReadLine();

            Console.WriteLine("Введите фамилию!");
            User.LastName = Console.ReadLine();

            string age;
            int integer1;
            do
            {
                Console.WriteLine("Введите ваш возраст");
                age = Console.ReadLine();
            }
            while (CheckNum1(age, out integer1));
            User.Age = integer1;

            int integer2;
            string NumberPets;
            Console.WriteLine("Есть ли у Вас питомцы?");
            var havePet = Console.ReadLine();
            if (havePet == "да")
            {
                do
                {
                    Console.WriteLine("Сколько у Вас питомцев");
                    NumberPets = Console.ReadLine();
                }
                while (CheckNum2(NumberPets, out integer2));
                User.PetNames = CreateArrayPets(integer2);
            }

            else
            {
                Console.WriteLine("Очень жаль");
                User.PetNames = null;
            }

            int integer3;
            string NumberColors;
            do
            {
                Console.WriteLine("Сколько у Вас любимых цветов");
                NumberColors = (Console.ReadLine());
            }
            while (CheckNum3 (NumberColors, out integer3));
                User.FavColors = CreateArrayColor(integer3);


            UserAnketa(User.Name, User.LastName, User.Age, User.PetNames, User.FavColors);
            return User;

        }

        static bool CheckNum1(string number, out int cornamber)
        {
            if (int.TryParse(number, out int intnum) && intnum > 0 && intnum <= 122)
            {
                cornamber = intnum;
                return false;
            }
            else
            {
                cornamber = 0;
                return true;
            }
        }

        static bool CheckNum2(string NumberPets, out int cornamber)
        {
            if (int.TryParse(NumberPets, out int intnum) && intnum > 0)
            {
                cornamber = intnum;
                return false;
            }
            else
            {
                cornamber = 0;
                return true;
            }
        }

        static bool CheckNum3(string NumberColors, out int cornamber)
        {
            if (int.TryParse(NumberColors, out int intnum) && intnum > 0)
            {
                cornamber = intnum;
                return false;
            }
            else
            {
                cornamber = 0;
                return true;
            }
        }

        static string[] CreateArrayPets(int NumberPets)
        {
            string[] NamesPets = new string[NumberPets];
            for (int i = 0; i < NamesPets.Length; i++)
            {
                Console.WriteLine("Введите имя питомца");
                NamesPets[i] = Console.ReadLine();

            }
            return NamesPets;
        }

        static string[] CreateArrayColor(int NumberColors)
        {
            string[] Colors = new string[NumberColors];
            Console.WriteLine("Назовите их!");
            for (int i = 0; i < Colors.Length; i++)
            {
                Colors[i] = Console.ReadLine();
            }
            return Colors;
        }

        static void UserAnketa(string Name, string LastName, int Age, string[] NamesPets, string[] FavColors)
        {
            Console.WriteLine("Данные о пользователе:");
            Console.WriteLine($"имя: {Name},\nфамилия: {LastName},\nвозраст: {Age},");
            if (NamesPets != null)
            {
                Console.Write("имена питомцев:");
                for (int i = 0; i < NamesPets.Length; i++)
                {
                    Console.Write(NamesPets[i]);
                }
                Console.WriteLine();
            }
            Console.Write("любимые цвета:");
            Console.WriteLine();
            for (int k = 0; k < FavColors.Length; k++)
            {
                Console.Write(FavColors[k]);
            }
            Console.Write(".");
        }

        static void Main()
        {
            Enteruser();

            Console.ReadKey();
        }
    }
}


