using System;

namespace deel_3
{
    class Program
    {
       
        static void Main(string[] args)
            {
                var myObject = Test.Create();
                myObject.SomethingInteresting();

                var sb = new StringBuilder();

                var list = new List<string>();

                var someValueType = new SomeValueObject
                {
                    Age = 100,
                    nameof = "Kevin"
                };
            }
    }
        
}

