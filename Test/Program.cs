using System;
using System.Collections;

// ReSharper disable All

namespace Test
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            int[] nums = { 1, 2, 3, 4, 5 };
            
        

            var pos = 0;
            foreach (var num in nums)
            {
                pos++;
                Console.WriteLine($"element[{pos}]: {num}");
                //Console.WriteLine(String.Format("element[{0}]: {1}", pos, num));
            }

            Console.WriteLine();
            
            foreach (var ll in List())
            {
                pos++;
                Console.WriteLine(String.Format("element[{0}]: {1}", pos, ll));
            }
            
            
            Console.WriteLine("Hello World".ToUpper());

            ArrayList List()
            {
             
                var objects = new ArrayList();
                objects.Add(1);
                objects.Add(2);
                objects.Add("Three");

                return objects;
            }


            /*StringBuilder sb = null;
            string result = sb?.ToString();
            Console.WriteLine(result);
            */
           
            
            Console.WriteLine(TimesTwo(2).ToString());
            
            Console.WriteLine(SomeProperty);
            
            Console.WriteLine(Created);
            
            Console.WriteLine(CreatedDateTime);

            
            // Indexers
            string s = "hello";
            Console.WriteLine(s[0]);
            Console.WriteLine(s[1]);

            string _s = null;
            Console.WriteLine(s?[0]); // check if null and write otherwise nothing but will not launch any exception.
            
            
            Sentence sentence = new Sentence();
            Console.WriteLine(sentence[3]);
            sentence[3] = "kangaroo";
            Console.WriteLine(sentence[3]);


            // Polymorphism
            Stock msft = new Stock {Name = "MSFT", SharesOwned = 1000};
            Console.WriteLine(msft.Name);
            Console.WriteLine(msft.SharesOwned);
            
            House mansion = new House{Name = "Mansion", Mortgage = 25000};
            Asset asset = mansion;
            Console.WriteLine(mansion.Liability);
            Console.WriteLine(asset.Liability);
            Console.WriteLine(asset.Name);
            Console.WriteLine(mansion.Name);
            Console.WriteLine(mansion.Mortgage);
            
            Display(msft); Display(mansion);
            
            // Upcasting
            Asset a = msft;
            Console.WriteLine(a == msft);
            Console.WriteLine(a.Name);
            
            // Donwcasting
            Stock stock = (Stock) a;
            Console.WriteLine(stock.SharesOwned);
            Console.WriteLine(stock == a);
            Console.WriteLine(stock == msft);
            
            var stack = new Stack<int>();
            stack.Push(5);
            stack.Push(10);

            int x = stack.Pop();
            int y = stack.Pop();
            
          
            Console.WriteLine(String.Format("x = {0} and y = {1}", x, y));
            
            Swap(ref x, ref y);
            
            Console.WriteLine(String.Format("x = {0} and y = {1} after swap", x, y));
        }


        public static void Display(Asset asset) { Console.WriteLine(asset.Name); }
        
        
      
        
        public static DateTime Created { get; set; } = DateTime.Now;

        public static DateTime CreatedDateTime { get; } = DateTime.Now;

        public static int TimesTwo(int x) => x * 2;

        public static string SomeProperty => "Some Property";
        
        public struct Point
        {
            public int x, y; 
        }

        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
        
        public interface IComparable<T>
        {
            int CompareTo(T other);
        }

        static T Max<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo (b) > 0 ? a : b;
        }
        
    }
}