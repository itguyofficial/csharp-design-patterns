using System;

namespace DesignPatterns
{
    internal class Singleton
    {
        static string singletonObj = null;
        private Singleton() { }

        public static string GetObject
        {
            get
            {
                if (singletonObj == null)
                {
                    // if variable is of type object then we can use Lock
                    // lock (singletonObj)
                    //{
                    singletonObj = "I'm Singleton Object";
                    //}

                }
                return singletonObj = "I'm from aleady object";
            }
        }
    }
}