using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace LogManager.Core
{
    public interface ISystemUtility
    {
        bool IsValidDirectory(string directoryInput);
    }

    public class SystemUtility : ISystemUtility
    {

        public bool IsValidDirectory(string directoryInput)
        {
            if (!string.IsNullOrEmpty(directoryInput) && Directory.Exists(directoryInput))
            {
                string invalidRegexPattern = @"([,!#$%^&*()\[\]]+|\\\.\.|\\\\\.|\.\.\\\|\.\\\|\.\.\/|\.\/|\/\.\.|\/\.|;|(?<![A-Z]):)";
                Regex regex = new Regex(invalidRegexPattern);
                MatchCollection matches = regex.Matches(directoryInput);
                if (matches.Count == 0)
                {
                    Console.WriteLine("Valid directory input");
                    return true;
                }
                else
                {
                    Console.WriteLine("Invalid directory input");
                    foreach (Match match in matches)
                    {
                        Console.WriteLine("Directory contains invalid character" + match);
                    }
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Invalid directory input");
                Console.WriteLine("Directory is null or does not exist");
                return false;
            }
        }
    }
}
