class Program
{
    static void Main()
    {
        int b = 0;
        int tries = 0;
        bool exit = false;        
        while (!exit)
        {
            Random rnd = new Random();

            int a = rnd.Next() % 100;

            do
            {
                Console.WriteLine("Угадай число от 1 до 100");
                b = Convert.ToInt32(Console.ReadLine());
                tries++;
                if ((b < a) && (a <= 50))
                {
                    Console.WriteLine("Ваше число меньше загаданного и загаданное число меньше либо равно 50");

                }
                else if ((b < a) && (a > 50))
                {
                    Console.WriteLine("Ваше число меньше загаданного и загаданное число больше 50 ");
                }
                else if ((b > a) && (a <= 50))
                {
                    Console.WriteLine("Ваше число больше загаданного и загаданное число меньше либо равно 50");
                }
                else if ((b > a) && (a > 50))
                {
                    Console.WriteLine("Ваше число больше загаданного и загаданное число больше 50");
                }
                else
                    Console.WriteLine($"Вы угадали c {tries} попытки!");
            } while (b != a);

            Console.WriteLine("\nПовторить ввод?  y/n");
            char input = char.Parse(Console.ReadLine());
            if (input == 'n')
            {
                exit = true;
            }
        }
    }
}