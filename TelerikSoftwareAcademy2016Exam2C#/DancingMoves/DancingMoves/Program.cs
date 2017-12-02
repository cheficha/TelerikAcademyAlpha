using System;
using System.Linq;

namespace DancingMoves
{
    class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var numbersCount = numbers.Length;

            var position = 0;
            var directionsCount = 0;
            decimal sum = 0;

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "stop")
                {
                    break;
                }
                else
                {
                    directionsCount++;
                }

                var splitted = input.Split(' ');

                var steps = int.Parse(splitted[0]);
                var direction = splitted[1];
                var size = int.Parse(splitted[2]);

                if (direction == "right")
                {
                    for (int i = 0; i < steps; i++)
                    {
                        position = (position + size) % numbersCount;
                        sum += numbers[position];
                    }
                }
                else
                {
                    for (int i = 0; i < steps; i++)
                    {
                        var newPosition = (position - size) % numbersCount;

                        if (newPosition < 0)
                        {
                            position = numbersCount + (position - size) % numbersCount;
                        }
                        else
                        {
                            position = newPosition;
                        }
                        
                        sum += numbers[position];
                    }
                }
            }

            Console.WriteLine("{0:0.0}", sum / directionsCount);
        }
    }
}
