using System.Collections;
using System.Collections.Generic;

namespace Collections_Arrays_Arraylist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("here first we are created a array with 5 numbers");
            int[] array1 = [ 1, 2, 3, 4, 5 ];
           
            foreach (var item in array1)
            {
                Console.WriteLine($"{item.ToString()}");
            }

            array1[0] = 87;
            array1.ToList().ForEach(i => Console.WriteLine(i));

            
            Console.WriteLine(array1.GetType()); //int32[]

            ArrayList li = new ArrayList(); //Arraylist 
            li.Add(34); // any datatypes allowed as it converts all as object
            li.Add("sru");

            List<String> userDetails = new List<String>();
            userDetails.Add("raja");
            userDetails.Add("poo");

            string name = "raja";

            switch (name)
            {
                case "ram" :  {
                        Console.WriteLine("name is ram");
                        break;
                    }
                default :
                    {
                        Console.WriteLine("default case here");
                        break;
                    }
            }


            string[] araysample = new string[] { };
            ArrayList arrayList = new ArrayList();
            List<string> listsamples = new List<string>();
        }
    }
}
