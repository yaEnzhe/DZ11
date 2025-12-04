using System;

namespace Tumakov14.Classes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class InfoAttribute : Attribute
    {
        public string DeveloperName { get; }
        public string OrganizationName { get; }

        public InfoAttribute(string developerName, string organizationName)
        {
            DeveloperName = developerName;
            OrganizationName = organizationName;
        }
    }
}
