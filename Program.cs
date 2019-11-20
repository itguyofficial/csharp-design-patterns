using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region "Singleton"
            System.Console.WriteLine(Singleton.GetObject);
            #endregion

            #region "Factory"
            System.Console.WriteLine(Factory.GetObjects(FactoryTypes.Student));
            #endregion

            #region "Abstract Factory"
            System.Console.WriteLine();
            #endregion
            Console.ReadLine();
        }
    }
}
