using System;
using System.Collections.Generic;

namespace WTWProject
{
    public class Program
    {
        private static string GetCleanedEmailAddress(string email)
        {
            var localAndDomainParts = email.Split('@');
            var localPart = localAndDomainParts[0];
            var domainPart = localAndDomainParts[1];
            localPart = localPart.Replace(".", string.Empty);
            var plusSignLocation = localPart.IndexOf('+');
            if (plusSignLocation > -1)
            {
                var totalCharactersToRemove = localPart.Length - plusSignLocation;
                localPart = localPart.Remove(plusSignLocation, totalCharactersToRemove);
            }
            var cleanedEmail = $"{localPart}@{domainPart}";
            return cleanedEmail;
        }

        // It is assumed that all emils passed in are valid emails.
        public static int NumberOfUniqueEmailAddresses(string[] emails)
        {
            var uniqueEmailAddresses = new List<string>();
            foreach (string email in emails)
            {
                var cleanedEmail = GetCleanedEmailAddress(email);
                if (!uniqueEmailAddresses.Contains(cleanedEmail))
                {
                    uniqueEmailAddresses.Add(cleanedEmail);
                }
            }
            return uniqueEmailAddresses.Count;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
