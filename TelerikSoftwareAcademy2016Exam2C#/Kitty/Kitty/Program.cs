using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitty
{
    class Program
    {
        static void Main(string[] args)
        {
            string positions = Console.ReadLine();
            int[] path = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            List<char> Road = new List<char>();
            EachPosition(positions, Road);
            var souls = 0;
            var food = 0;
            var deadlocks = 0;
            switch (Road[0])
            {
                case '@':
                    souls++;
                    Road[0] = 'S';
                    break;
                case '*':
                    food++;
                    Road[0] = 'S';
                    break;
                case 'x':
                    Console.WriteLine("You are deadlocked, you greedy kitty!");
                    Console.WriteLine("Jumps before deadlock: 0");
                    return;

                default:
                    break;
            }
            var currentPosition = 0;
            for (int i = 0; i < path.Length; i++)
            {
                    currentPosition = currentPosition + path[i];
                    while (currentPosition>Road.Count-1)
                    {
                        currentPosition = currentPosition - Road.Count;
                    }
                    while (currentPosition<0)
                    {
                        currentPosition = currentPosition + Road.Count;
                    }

                    switch (Road[currentPosition])
                    {
                        case '@':
                            Road[currentPosition] = 'S';
                            souls++;

                            break;
                        case '*':
                            Road[currentPosition] = 'S';
                            food++;
                            break;
                        case 'S':

                            break;
                        case 'x':
                            if (currentPosition % 2 == 0)
                            {
                                Road[currentPosition] = '@';
                                souls--;
                                if (souls < 0)
                                {
                                    Console.WriteLine("You are deadlocked, you greedy kitty!");
                                    Console.WriteLine("Jumps before deadlock: {0}", i + 1);
                                    return;
                                }
                                else
                                {
                                    deadlocks++;
                                }

                            }
                            else
                            {
                                Road[currentPosition] = '*';
                                food--;
                                if (food < 0)
                                {
                                    Console.WriteLine("You are deadlocked, you greedy kitty!");
                                    Console.WriteLine("Jumps before deadlock: {0}", i + 1);
                                    return;
                                }
                                else
                                {
                                    deadlocks++;
                                }
                            }
                            break;
                        default:
                            break;
                    }
            }
            Console.WriteLine("Coder souls collected: {0}", souls);
            Console.WriteLine("Food collected: {0}", food);
            Console.WriteLine("Deadlocks: {0}", deadlocks);
        }
        private static void EachPosition(string path, List<char> AllPositions)
        {
            for (int i = 0; i < path.Length; i++)
            {
                AllPositions.Add(path[i]);
            }
        }
    }
}