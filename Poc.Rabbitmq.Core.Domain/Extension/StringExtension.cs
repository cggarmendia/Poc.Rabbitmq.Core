using System;

namespace Poc.Rabbitmq.Core.Domain.Extension
{
    public static class StringExtension
    {
        public static string Replace(this string s, char[] separators, string newValue)
        {
            var temp = s.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            return string.Join(newValue, temp);
        }
    }
}
