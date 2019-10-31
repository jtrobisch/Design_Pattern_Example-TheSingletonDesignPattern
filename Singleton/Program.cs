using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        //The singleton pattern is one of the best-known patterns in software engineering. 
        //Essentially, a singleton is a class which only allows a single instance of itself to be 
        //created, and usually gives simple access to that instance.

        static void Main(string[] args)
        {
            MainAppBody s  = MainAppBody.Instance; //constructor run 
            MainAppBody x = MainAppBody.Instance; //constructor does not run (object cannot be created)
            Console.ReadLine();
        }
    }



    public sealed class MainAppBody
    {
        static readonly MainAppBody _instance = new MainAppBody();
        public static MainAppBody Instance
        {
            get
            {
                return _instance;
            }
        }
        MainAppBody()
        {
            // Initialize.
            Console.WriteLine("Object Created!");
        }
    }
}
