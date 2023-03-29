using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=7;i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");

                }
                Console.WriteLine("");
            }
        }
    }
}

namespace Excercise
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=7;i++)
            {
                for(int j=i;j<=7;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}

namespace Excercise
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=6;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine("");
               

                
            }
        }
    }
}

namespace Excercise
{
    internal class Class4
    {
        static void Main(string[] args)
        {
            for (int i = 7; i >0 ; i--)
            {
                for (int j = i; j >0; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine("");
            }
        }
    }
}


namespace Excercise
{
    internal class Class5
    {
        static void Main(string[] args)
        {
            char ch = 'A';
            for (int i = 1; i <= 8; i++)
            {

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(ch);
                }
                Console.WriteLine("");
            }
        }
    }
}


namespace Excercise
{
    internal class Class6
    {
        static void Main(string[] args)
        {
            string S= "ruturaj gungure";

            string[] arr= S.Split();

            foreach(string s in arr)

            Console.WriteLine(s);

           
        }
    }
}


namespace Excercise
{
    internal class Class7
    {
        static void Main(string[] args)
        {
            string str=Console.ReadLine();

            string s = str.Substring(0, 1);
            Console.WriteLine(s);
        }
    }
}

namespace Excercise
{
    internal class Class8
    {
        static void Main(string[] args)
        {
            int count = 0;
            string str = Console.ReadLine();
            char ch = 'u';

            for(int i=0;i<str.Length;i++)
            {
                if (str[i]==ch)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}

namespace Excercise
{
    internal class Class9
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            string s = str.Trim();
            Console.WriteLine(s);
        }
    }
}


namespace Excercise
{
    internal class Class10
    {
        static void Main(string[] args)
        {
            int count = 0;
            string str = Console.ReadLine();

            string[] arr = str.Split();

            for(int i=0;i<arr.Length;i++)
            {
                count++;
            }
            Console.WriteLine(count);
        }
    }
}

namespace Excercise
{
    internal class Class11
    {
        static void Main(string[] args)
        {
           
            string str=Console.ReadLine();
            char ch = Convert.ToChar(Console.ReadLine());
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i]!=ch)
                {
                    Console.Write(str[i]);
                }
            }

        }
    }
}


namespace Excercise
{
    internal class Class12
    {
        static void Main(string[] args)
        {
            int count1 = 0, count2 = 0;
            string str=Console.ReadLine() ;

            for(int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u' || str[i] == 'A' || str[i] == 'E' || str[i] == 'I' || str[i] == 'O' || str[i] == 'U' )
                {
                    count1++;
                }
                else
                {
                    count2++;
                }
            }

            Console.WriteLine($"no. of vowel {count1}");
            Console.WriteLine($"no. of Consonant {count2}");
        }
    }
}


namespace Excercise
{
    internal class Class13
    {
        static void Main(string[] args)
        {
            string[] a = {"Hello","xyz","world","yes","No" };
            Array.Sort(a);
            Array.Reverse(a);
            foreach (string s in a) 
                Console.WriteLine(s);
            

        } 
        
    }
}


namespace Excercise
{
    internal class Class14
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 4, 1, 3, 5 };
          
                Array.Sort(arr);
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }

           
        }
    }
}



namespace Excercise
{ 
    internal class Class15
    {


        static void Main(string[] args)
        {
            string str1=Console.ReadLine();
            string str2=Console.ReadLine();

            char[]a1=str1.ToLower().ToCharArray();
            char[]a2=str2.ToLower().ToCharArray();

            Array.Sort(a1);
            Array.Sort(a2);

            string rev1=new string(a1);
            string rev2 = new string(a1);

            if(rev1==rev2)
            {
                Console.WriteLine("it anagram");
            }
            else
            {
                Console.WriteLine("it not anagram");
            }
        }



            
    }
}