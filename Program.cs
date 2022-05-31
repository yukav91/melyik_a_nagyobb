using System;

namespace test1
{
    class Class1
    {
        [STAThread]
        public static void Main(string[] args)
        {
            int a, b, kisebb, nagyobb;
            bool vanenagyobb = true;
            Console.WriteLine("Adj meg két számot, megmondom melyik a nagyobb!\n Az 'a' értéke: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A 'b' értéke: ");
            b = Convert.ToInt32(Console.ReadLine());

            if (a == b)
            {
                Console.WriteLine("Az 'a' és a 'b' értékei egyenlőek!");
                vanenagyobb = false;
                Console.WriteLine("Van-e nagyobb: {0}", vanenagyobb);
            }
            else if (a < b)
            {
                kisebb = a;
                nagyobb = b;
                vanenagyobb = true;    
                Console.WriteLine("A 'b' értéke nagyobb");
                Console.WriteLine("Nagyobb: {0}\nKisebb: {1}\nVan-e nagyobb: {2}", nagyobb, kisebb, vanenagyobb);
            }
            else
            {
                kisebb = b;
                nagyobb = a;
                vanenagyobb = true;
                Console.WriteLine("Az 'a' értéke nagyobb");
                Console.WriteLine("Nagyobb: {0}\nKisebb: {1}\nVan-e nagyobb: {2}", nagyobb, kisebb, vanenagyobb);
            }
            
        }
    }
}
