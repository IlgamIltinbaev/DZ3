using System.Security.Cryptography;
using Latypova;
namespace Latypova
{
    class Programm
    {
        static void Main()
        {/*
            Console.WriteLine("\tУпражнение 1");
            int[] num_list = { 1, 2, 3, 4, 5, 9, 7, 8, 9, 10 };
            bool flag = true;
            int index = 0;
            for (int i = 0; i < num_list.Length-1; i++)
            {
                if (num_list[i] > num_list[i+1])
                {
                    flag = false;
                    index = i;
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine("Последовательность возрастающая");
            }
            else
            {
                Console.WriteLine("Последовательность не возрастающая");
                Console.WriteLine("Индекс числа: " + index);
            }

            Console.WriteLine("\tУпражнеине 2");
            Console.WriteLine("Введите число карты:");
            string str_mast = Console.ReadLine();
            if (Int32.TryParse(str_mast, out int int_mast))
            {
                try
                {
                    string[] cards = { "Шестёрка", "Семёрка", "Восьмёрка", "Девятка", "Десятка", "Валет", "Дама", "Король", "Туз" };
                    Console.WriteLine("Данная карта номинала:" + cards[int_mast-6]);
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Ошибка:"+ex.Message);
                }
                finally
                {
                    Console.WriteLine("Конец программы");
                }
            }
            else
            {
                Console.WriteLine("Введены некорректные данные");
            }

            Console.WriteLine("\tУпражнение 3");
            Console.Write("Введите данные:");
            string drinker = Console.ReadLine().ToLower();
            string drink = "Beer";
            switch (drinker)
            {
                case "jabroni":
                    drink = "Patron Tequila";
                    break;
                case "school counselor":
                    drink = "Anything with Alcohol";
                    break;
                case "programmer":
                    drink = "Hipster Craft Beer";
                    break;
                case "bike gang member":
                    drink = "Moonshine";
                    break;
                case "politician":
                    drink = "Your tax dollars";
                    break;
                case "rapper":
                    drink = "Cristal";
                    break;
                default:
                    break;
            }
            Console.WriteLine(drink);
            
            Console.WriteLine("\tУпражнение 4");
            Console.WriteLine("Введите число недели:");
            string str_of_week = Console.ReadLine();
            if (Int32.TryParse(str_of_week, out int int_of_week))
            {
                if (int_of_week > 0 & int_of_week < 8)
                {
                    Latypova.Weekly week_day = (Latypova.Weekly)int_of_week;
                    Console.WriteLine("Ваш день в неделе: " + week_day);

                }
                else
                {
                    Console.WriteLine("Некорректно введены данные");
                }
            }
            else
            {
                Console.WriteLine("Некорректно введены данные");
            }
            */
            string[] Toys = { "Barbie doll","Hello Kitty",  "Car", "Ball", "Hot Wheels", "Train", "Hello Kitty" };
            int count = 0;
            foreach (string toy in Toys)
            {
                if (toy == "Hello Kitty" || toy == "Barbie doll")
                {
                    count++;
                }
            }
            Console.WriteLine($"Кукол в сумке: {count}");
        }
    }
}