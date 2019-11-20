using System;

namespace DesignPatterns
{
    internal class Factory
    {
        static string classObj = null;

        // Here for the examle purpose im using string.
        // The parameter baseType would be a  emum which has all class types
        public static string GetObjects(string baseType)
        {
            switch (baseType.ToLower())
            {
                case "employee":
                    classObj = "New Employee object created";
                    break;
                case "student":
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