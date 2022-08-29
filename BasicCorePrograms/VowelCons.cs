using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class VowelCons
    {
        public static void VowelCon()
        {
            Console.Write("Input an Alphabet: ");
            char ch = Convert.ToChar(Console.ReadLine().ToUpper());
            
                switch (ch)
                {
                    case 'A':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'I':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'O':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'U':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'E':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    default:
                        Console.WriteLine("The Alphabet is not a vowel");
                        break;
                }
            
            
        }
    }
}
