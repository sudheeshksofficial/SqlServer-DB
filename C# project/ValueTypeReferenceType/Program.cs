

//Primitive datatype and non primitive datatype
//    Primitive is the one which C# language providing --> int,bool,double
// non primitive means the datatype we provide 
// ---> Class a = new Class();



namespace ValueTypeReferenceType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //value type and reference type examples
            int firstValue = 20; //Primitive
            int secondValue = firstValue;
            Console.WriteLine("Hello, From Main method!");
            SecondaryClass secondaryClass = new SecondaryClass(); // non Primitive
            secondaryClass.fieldValue = 456;
            SecondaryClass secondaryClass1 = new SecondaryClass();
            secondaryClass1 = secondaryClass;
            secondaryClass1.fieldValue = 2343;
            

        }
    }

    internal class SecondaryClass
    {
        public int fieldValue;

    }
}
