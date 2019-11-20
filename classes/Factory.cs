using System;

namespace DesignPatterns
{
    internal class Factory
    {
        static string classObj = null;

        public static string GetObjects(FactoryTypes baseType)
        {
            switch (baseType)
            {
                case FactoryTypes.Employee:
                    classObj = "New Employee object created";
                    break;
                case FactoryTypes.Student:
                    classObj = "New Student object creted";
                    break;
                default:
                    classObj = "not a valid input found";
                    break;
            }
            return classObj;
        }
    }
}