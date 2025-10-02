namespace Tumakov
{
    class Programm
    {
        static void Main(string[] args)
        {/*
            Console.WriteLine("\tУпражнение 4.1");
            Console.Write("Введите число от 1 до 365:");
            string str_day_of_year_1 = Console.ReadLine();
            if (Int32.TryParse(str_day_of_year_1, out int int_day_of_year_1))
            {
                DateTime data = new();
                str_day_of_year_1 = data.AddDays(int_day_of_year_1 - 1).ToString("d MMMM");
                Console.WriteLine("Ваша дата:"+str_day_of_year_1);
            }
            else
            {
                Console.WriteLine("Недопустимое значение");
            }
            
            Console.WriteLine("\tУпражнение 4.2");
            Console.Write("Введите число от 1 до 365:");
            string str_day_of_year_2 = Console.ReadLine();
            if (Int32.TryParse(str_day_of_year_2, out int int_day_of_year_2))
            {   
                if (int_day_of_year_2 < 1 || int_day_of_year_2 > 365)
                {
                    Console.WriteLine("Недопустимое значение");
                }
                else
                {
                    DateTime data = new();
                    str_day_of_year_2 = data.AddDays(int_day_of_year_2 - 1).ToString("d MMMM");
                    Console.WriteLine("Ваша дата:"+str_day_of_year_2);
                }
            }
            else
            {
                Console.WriteLine("Недопустимое значение");
            }*/
            Console.WriteLine("\tДомашнее задание 4.1");
            Console.Write("Введите число от 1 до 365:");
            string str_day = Console.ReadLine();
            if (Int32.TryParse(str_day, out int int_day))
            {
                if (int_day < 1 || int_day > 365)
                {
                    Console.WriteLine("Недопустимое значение");
                }
                else
                {
                    Console.WriteLine("Введите год:");
                    string str_year = Console.ReadLine();
                    if (Int32.TryParse(str_year, out int int_year))
                    {
                        if (int_year < 1)
                        {
                            Console.WriteLine("Недопустимое значение");
                        }
                        else
                        {
                            DateTime data = new(int_year, 01, 01);
                            data = data.AddDays(int_day - 1);
                            Console.WriteLine("Ваша дата:" + data.ToString("d MMMM yyy"));
                        }

                    }
                }
            }
            else
            {
                Console.WriteLine("Недопустимое значение");
            }

        }
    }
}