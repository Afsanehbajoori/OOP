using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            Manager mgr = new Manager();
            mgr.Name = "John";
            Client cl1= mgr.AddCLinet("Alex");

            Console.WriteLine($"Name of Client is : {cl1.Name}");

            cl1.Buy("Book");
            Console.WriteLine($"His /Her points is : {cl1.GetPoint()} and get a discount: {cl1.GetDiscount()}");

            cl1.Buy("Bag");
            Console.WriteLine($"His /Her points is : {cl1.GetPoint()} and get a discount: {cl1.GetDiscount()}");

            Client cl2 = mgr.AddCLinet("Ebi");
            Console.WriteLine($"Name of Client is : {cl2.Name} ");

            cl2.Buy("Ipad");
            cl2.Buy("Cover");
            cl2.Buy("Book");
            Console.WriteLine($"His /Her points is : {cl2.GetPoint()}  and get a discount: {cl2.GetDiscount()}");

            Console.WriteLine("");

            Console.ReadKey(true);
        }


        public class Client
        {
            public string Name;
            private int point=0;
            private double discount = 0;

            public int GetPoint()
            {
                return point;
            }

            public double GetDiscount()
            {
                return discount;
            }
            public void Buy(string product )
            {
                //buy a product
                point++;
                discount += 5 ;
            }
        }

        public class Manager
        {
            public string Name;


            public Client AddCLinet(string clientName)
            {
                Client client1 = new Client();
                client1.Name = clientName;
                return client1;
            }
        }
    }
}
