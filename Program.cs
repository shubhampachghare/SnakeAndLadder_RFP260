using System;

namespace SnakeAndLadder
{
    class Program
    {
        const int START_POSITION = 0;
        const int END_POSITION = 100;
        public static int currentPosition = 0;

        public static int throwDice()
        {
            Random random = new Random();
            int number = random.Next(1, 7);
            return number;
        }

        static void Main(string[] args)
        {
            currentPosition += throwDice();
            Console.WriteLine("Current position is=" + currentPosition);
            Console.WriteLine("start position is: " + START_POSITION);
            Console.WriteLine("end position is: " + END_POSITION);
        }
    }
}
