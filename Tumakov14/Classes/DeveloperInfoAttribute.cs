using System;

namespace Tumakov14.Classes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class DeveloperInfoAttribute : Attribute
    {
        public string DeveloperName { get; }
        public string DevelopmentDate { get; }

        public DeveloperInfoAttribute(string developerName, string developmentDate)
        {
            DeveloperName = developerName;
            DevelopmentDate = developmentDate;
        }
    }
}
