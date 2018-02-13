using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogLovesPaper
{
    class Program
    {

        static void Main(string[] args)
        {

            var input = int.Parse(Console.ReadLine());
            var counter = 0;
            var childs = new Dictionary<int, List<int>>();
            var parentsCount = new int[10];
            var listOfOthers = new SortedSet<int>();
            var used = new bool[10];
            var sb = new StringBuilder();
            var min = int.MaxValue;
            var max = 0;
            while (counter != input)
            {
                List<string> line = Console.ReadLine().Split().ToList();
                if (line[2] == "after")
                {
                    counter++;
                    var parent = int.Parse(line[3]);
                    var child = int.Parse(line[0]);
                    if (child == parent)
                    {
                        parent = child;
                    }
                    parentsCount[child]++;
                    if (child < min)
                    {
                        min = child;
                    }
                    if (child > max)
                    {
                        max = child;
                    }
                    if (parent < min)
                    {
                        min = parent;
                    }
                    if (parent > max)
                    {
                        max = parent;
                    }
                    if (!childs.ContainsKey(parent))
                    {
                        var list = new List<int>();
                        list.Add(child);
                        childs.Add(parent, list);
                    }
                    else
                    {

                        childs[parent].Add(child);
                    }
                }
                else if (line[2] == "before")
                {
                    counter++;
                    var parent = int.Parse(line[0]);
                    var child = int.Parse(line[3]);
                    if (child==parent)
                    {
                        parent = child;
                    }
                    if (child < min)
                    {
                        min = child;
                    }
                    if (child > max)
                    {
                        max = child;
                    }
                    if (parent < min)
                    {
                        min = parent;
                    }
                    if (parent > max)
                    {
                        max = parent;
                    }
                    parentsCount[child]++;
                    if (!childs.ContainsKey(parent))
                    {
                        var list = new List<int>();
                        list.Add(child);
                        childs.Add(parent, list);
                    }
                    else
                    {

                        childs[parent].Add(child);
                    }
                }
            }
            bool areVisited = false;
            foreach (var item in childs.Keys)
            {
                foreach (var s in childs[item])
                {
                    listOfOthers.Add(s);
                }

            }
            while (!areVisited)
            {
                areVisited = true;
                for (int i = min; i <= max; i++)
                {
                    if (min==max)
                    {
                        sb.Append(i);

                    }
                   else if (i == 0 && sb.Length == 0 && childs.Keys.Count==1)
                    {
                        
                            parentsCount[childs[i][i]]--;
                        
                       
                            if (listOfOthers.Contains(childs[i][i]))
                            {
                                if (parentsCount[childs[i][i]] == 0)
                                {
                                    used[childs[i][i]] = true;
                                    sb.Append(childs[i][i]);
                                }
                            }
                       
                      
                        listOfOthers.Add(0);
                        i--;
                    }
                    else if (parentsCount[i] == 0 && used[i] == false)
                    {
                        if (i == 0 && sb.Length == 0)
                        {

                           
                            continue;
                        }

                        if (childs.ContainsKey(i))
                        {

                            sb.Append(i);

                            used[i] = true;
                            if (childs[i].Count != 0)
                            {

                                for (int j = 0; j < childs[i].Count; j++)
                                {
                                    parentsCount[childs[i][j]]--;
                                }
                            }
                            areVisited = false;
                            break;
                        }
                        else if (listOfOthers.Contains(i))
                        {
                            if (parentsCount[i] == 0)
                            {
                                used[i] = true;
                                sb.Append(i);
                            }
                        }

                    }

                }
            }
            Console.WriteLine(sb.ToString());




        }
    }
}
