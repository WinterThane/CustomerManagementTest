using System;

namespace CustomerManagementTest.Common
{
    public static class StringHandler
    {
        /// <summary>
        /// Inserts spaces after a capital letter
        /// </summary>
        /// <param name="source"></param>
        public static string InsertSpaces(this string source)
        {
            var result = string.Empty;

            if(!String.IsNullOrWhiteSpace(source))
            {
                foreach (char letter in source)
                {
                    if(char.IsUpper(letter))
                    {
                        result = result.Trim();
                        result += " ";
                    }
                    result += letter;
                }
                result = result.Trim();
            }

            return result;
        }
    }
}
