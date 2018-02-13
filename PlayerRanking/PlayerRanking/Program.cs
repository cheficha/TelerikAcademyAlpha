using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace PlayerRanking
{
    class Program
    {
        static string input;

        static void Main(string[] args)
        {
     
            var dict = new Dictionary<string, OrderedSet<Player>>();
            var positions = new BigList<Player>();
            var result = new StringBuilder();
            while ((input = Console.ReadLine()) != "end")
            {
                var commands = input.Split().ToArray();
                switch (commands[0])
                {
                    case "add":
                        Add(commands, dict, positions, result);
                        break;
                    case "find":
                        Find(commands, dict, positions, result);
                        break;
                    case "ranklist":
                        Ranklist(commands, dict, positions, result);
                        break;

                    default:
                        break;
                }
            }
            Console.WriteLine(result.ToString().Trim());
            
           



        }

        public static void Add(string[] playerInfo, Dictionary<string, OrderedSet<Player>> dict, BigList<Player> positions, StringBuilder sb)
        {
            var type = playerInfo[2];
            var name = playerInfo[1];
            var position = int.Parse(playerInfo[4]);

            var player = new Player(name, type, int.Parse(playerInfo[3]));

            if (dict.ContainsKey(type))
            {
                if (dict[type].Count == 5)
                {
                    Player lastPlayer = dict[type][4];

                    if (lastPlayer.CompareTo(player) > 0)
                    {
                        dict[type].Remove(lastPlayer);
                        dict[type].Add(player);
                    }

                }
                else
                {
                    dict[type].Add(player);
                }

            }
            else
            {
                dict[type] = new OrderedSet<Player>();
                dict[type].Add(player);
            }

            positions.Insert(position - 1, player);
            sb.AppendLine($"Added player {playerInfo[1]} to position {playerInfo[4]}");
        }
        
        public static void Find(string[] playerInfo, Dictionary<string, OrderedSet<Player>> dict, BigList<Player> positions, StringBuilder sb)
        {
            var type = playerInfo[1];
            if (!dict.Keys.Contains(type))
            {
                sb.AppendLine($"Type {type}: ".Trim());
            }
            else
            {

                sb.AppendLine($"Type {type}: {string.Join("; ", dict[type])}".Trim());

            }
           

        }
        public static void Ranklist(string[] playerInfo, Dictionary<string, OrderedSet<Player>> dict, BigList<Player> positions, StringBuilder sb)
        {
            var start = int.Parse(playerInfo[1]);
            var end = int.Parse(playerInfo[2]);
            var range = end - start + 1;
            var sbs = new StringBuilder();


            var asd = positions.Range(start - 1, range);

            for (int i = 0; i < asd.Count; i++)
            {
                sbs.Append($"{start+i}. {asd[i].ToString()}; ");
                
            }
            sbs.Remove(sbs.Length - 2, 2);
            sb.AppendLine(sbs.ToString().Trim());
        }


    }
    public struct Player : IComparable<Player>
    {
        public Player(string name, string type, int age)
        {
            Name = name;
            Type = type;
            Age = age;

        }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Age { get; set; }

        public int CompareTo(Player other)
        {
            var result = this.Name.CompareTo(other.Name);
            if (result == 0)
            {
                return this.Age.CompareTo(other.Age) * -1;
            }
            return result;


        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"{Name}({Age})");
            return sb.ToString().Trim();
        }
    }
}
