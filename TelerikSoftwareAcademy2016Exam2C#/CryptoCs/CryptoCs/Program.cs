using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace CryptoCs
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string sign = Console.ReadLine();
            string secondName = Console.ReadLine();
            List<BigInteger> listFirstName = new List<BigInteger>();
            List<BigInteger> listSecName = new List<BigInteger>();
            NameToList(secondName,listSecName);
            NameToList(firstName, listFirstName);
            BigInteger firstNameInt = 0;
            BigInteger secNameInt = 0;
            firstNameInt=ListToInt(listFirstName);
            secNameInt=ListToInt(listSecName);
           
            //Console.WriteLine(firstNameInt);
            //Console.WriteLine(secNameInt);
            BigInteger result = 0;
            if (sign.Equals("+"))
            {
                result = firstNameInt + secNameInt;
            }
            else if (sign=="-")
            {
                result = firstNameInt - secNameInt;
            }
            //Console.WriteLine(result);
            string numbers = result.ToString();
            
            for (int i = 0; i < numbers.Length; i++)
            {
                switch (numbers[i])
                {
                    case '0':
                        Console.Write("cad");
                        break;
                    case '1':
                        Console.Write("xoz");
                        break;
                    case '2':
                        Console.Write("nop");
                        break;
                    case '3':
                        Console.Write("cyk");
                        break;
                    case '4':
                        Console.Write("min");
                        break;
                    case '5':
                        Console.Write("mar");
                        break;
                    case '6':
                        Console.Write("kon");
                        break;
                    case '7':
                        Console.Write("iva");
                        break;
                    case '8':
                        Console.Write("ogi");
                        break;
                    case '9':
                        Console.Write("yan");
                        break;
                    default:
                        break;
                }

            }
            Console.WriteLine();
        }

        

        private static void NameToList(string firstName, List<BigInteger> list)
        {
            for (int i = 0; i+3 <= firstName.Length; i = i + 3)
            {
                

                    string firstthree = firstName.Substring(i, 3);
                    switch (firstthree)
                    {
                        //CAD
                        case "cad":
                            list.Add(0);
                            break;
                        //case "cda":
                        //    list.Add(0);
                        //    break;
                        //case "dac":
                        //    list.Add(0);
                        //    break;
                        //case "dca":
                        //    list.Add(0);
                        //    break;
                        //case "acd":
                        //    list.Add(0);
                        //    break;
                        //case "adc":
                        //    list.Add(0);
                        //    break;
                        //XOZ
                        case "xoz":
                            list.Add(1);
                            break;
                        //case "xzo":
                        //    list.Add(1);
                        //    break;
                        //case "zox":
                        //    list.Add(1);
                        //    break;
                        //case "zxo":
                        //    list.Add(1);
                        //    break;
                        //case "ozx":
                        //    list.Add(1);
                        //    break;
                        //case "oxz":
                        //    list.Add(1);
                        //    break;

                        //NOP
                        case "nop":
                            list.Add(2);
                            break;
                        //case "npo":
                        //    list.Add(2);
                        //    break;
                        //case "pon":
                        //    list.Add(2);
                        //    break;
                        //case "pno":
                        //    list.Add(2);
                        //    break;
                        //case "onp":
                        //    list.Add(2);
                        //    break;
                        //case "opn":
                        //    list.Add(2);
                        //    break;
                        //CYK
                        case "cyk":
                            list.Add(3);
                            break;
                        //case "cky":
                        //    list.Add(3);
                        //    break;
                        //case "ykc":
                        //    list.Add(3);
                        //    break;
                        //case "yck":
                        //    list.Add(3);
                        //    break;
                        //case "kcy":
                        //    list.Add(3);
                        //    break;
                        //case "kyc":
                        //    list.Add(3);
                        //    break;
                        //MIN
                        case "min":
                            list.Add(4);
                            break;
                        //case "mni":
                        //    list.Add(4);
                        //    break;
                        //case "nim":
                        //    list.Add(4);
                        //    break;
                        //case "nmi":
                        //    list.Add(4);
                        //    break;
                        //case "imn":
                        //    list.Add(4);
                        //    break;
                        //case "inm":
                        //    list.Add(4);
                        //    break;
                        //MAR
                        case "mar":
                            list.Add(5);
                            break;
                        //case "mra":
                        //    list.Add(5);
                        //    break;
                        //case "arm":
                        //    list.Add(5);
                        //    break;
                        //case "amr":
                        //    list.Add(5);
                        //    break;
                        //case "rma":
                        //    list.Add(5);
                        //    break;
                        //case "ram":
                        //    list.Add(5);
                        //    break;
                        //KON
                        case "kon":
                            list.Add(6);
                            break;
                        //case "kno":
                        //    list.Add(6);
                        //    break;
                        //case "okn":
                        //    list.Add(6);
                        //    break;
                        //case "onk":
                        //    list.Add(6);
                        //    break;
                        //case "nok":
                        //    list.Add(6);
                        //    break;
                        //case "nko":
                        //    list.Add(6);
                        //    break;
                        //IVA
                        case "iva":
                            list.Add(7);
                            break;
                        //case "iav":
                        //    list.Add(7);
                        //    break;
                        //case "vai":
                        //    list.Add(7);
                        //    break;
                        //case "via":
                        //    list.Add(7);
                        //    break;
                        //case "avi":
                        //    list.Add(7);
                        //    break;
                        //case "aiv":
                        //    list.Add(7);
                        //    break;
                        //OGI
                        case "ogi":
                            list.Add(8);
                            break;
                        //case "oig":
                        //    list.Add(8);
                        //    break;
                        //case "gio":
                        //    list.Add(8);
                        //    break;
                        //case "goi":
                        //    list.Add(8);
                        //    break;
                        //case "iog":
                        //    list.Add(8);
                        //    break;
                        //case "igo":
                        //    list.Add(8);
                        //    break;
                        //YAN
                        case "yan":
                            list.Add(9);
                            break;
                            //case "yna":
                            //    list.Add(9);
                            //    break;
                            //case "nay":
                            //    list.Add(9);
                            //    break;
                            //case "nya":
                            //    list.Add(9);
                            //    break;
                            //case "ayn":
                            //    list.Add(9);
                            //    break;
                            //case "any":
                            //    list.Add(9);
                            //    break;
                            //default:
                            //    break;
                    }
                
            }
        }

        private static BigInteger ListToInt(List <BigInteger> list)
        {
           BigInteger  number = 0;
            foreach (BigInteger entry in list)
            {
                number = 10 * number + entry;
            }
            return number;
            

         
        }

        private static void printingList(List<BigInteger> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i]);
            }
            Console.WriteLine();
        }
    }
}
