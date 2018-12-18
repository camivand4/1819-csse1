using System;

namespace deel_3
{
    public static class ObjectFactory
    {
        public static IBusinessThingy Create() 
        {
            var someSetting = Convert.ToBoolean(ConfigurationManager.AppSettings["foo"]);

            if(true)
            {
                return new Test("foo");
            }
            else
            {
                return new SecondTest();
            }
        }
    }
        
}