using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace UnitsOfWork
{
    public struct Unit:IComparable<Unit>
    {
        public Unit(string name, string type, int attack)
        {
            Name = name;
            Type = type;
            Attack = attack;
        }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Attack { get; set; }

        public int CompareTo(Unit other)
        {
            var result =  other.Attack.CompareTo(this.Attack);
            if (result == 0)
            {
                return this.Name.CompareTo(other.Name);
            }
           
                return result;
            
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.Append($"{Name}[{Type}]({Attack})");

            return sb.ToString();
        }
        

    }
    class Program
    {
        static void Main(string[] args)
        {

            var dict = new Dictionary<string, Unit>();
            var types = new Dictionary<string, OrderedSet<Unit>>();
            var attacks = new OrderedBag<Unit>();
            var result = new StringBuilder();
            while (true)
            {
                var input = Console.ReadLine().Split().ToArray();

                switch (input[0])
                {
                    case "end":
                        Console.WriteLine(result.ToString().Trim());
                        return;

                    case "add":
                        if (!dict.ContainsKey(input[1]))
                        {
                            var unit = new Unit(input[1], input[2], int.Parse(input[3]));

                            result.AppendLine($"SUCCESS: {unit.Name} added!");
                            dict.Add(unit.Name, unit);
                            attacks.Add(unit);
                            if (types.ContainsKey(input[2]))
                            {
                                types[unit.Type].Add(unit);
                            }
                            else
                            {
                                types.Add(unit.Type, new OrderedSet<Unit>());
                                types[unit.Type].Add(unit);
                            }
                        }
                        else
                        {
                            result.AppendLine($"FAIL: {input[1]} already exists!");
                        }
                        break;
                    case "remove":
                        if (dict.ContainsKey(input[1]))
                        {
                            types[dict[input[1]].Type].Remove(dict[input[1]]); // not sure if it works
                            attacks.Remove(dict[input[1]]);

                            dict.Remove(input[1]);
                            result.AppendLine($"SUCCESS: {input[1]} removed!");
                        }
                        else
                        {
                            result.AppendLine($"FAIL: {input[1]} could not be found!");
                        }

                        break;
                    case "find":
                        var niki = input[1];
                   
                       
                            if (types.Keys.Contains(niki))
                            {
                            var pesho = types[niki].Take(10);
                            result.AppendLine($"RESULT: {string.Join(", ", pesho)}");

                            }
                            else
                            {
                                result.AppendLine($"RESULT: ");
                            }
                        
                        
                    
                        break;
                    case "power":
                        result.Append("RESULT: ");

                        if (attacks.Count < int.Parse(input[1]))
                        {
                            for (int i = 0; i < attacks.Count; i++)
                            {

                                result.AppendLine($"{string.Join(", ",attacks)}");

                                
                            }
                        
                        }
                        else
                        {
                            var N = int.Parse(input[1]);

                            var newAttacks = attacks.Take(N);



                            result.AppendLine($"{string.Join(", ",newAttacks)}");
                            
                        }
                        break;
                      
                }

            }


            Console.WriteLine(result.ToString());

        }


    }

}
