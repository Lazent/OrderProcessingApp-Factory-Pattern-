using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Text.RegularExpressions;

namespace OrderProcessingApp.Services
{
    public class OrderIdGenerator
    {
        private static readonly Random Random = new Random();
        private const string Letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string Digits = "0123456789";

        public static string GenerateOrderId()
        {
            string pattern = @"[A-Z]{2}\d{5}";

            string orderId;

            do
            {
                string letters = new string(GenerateRandomCharacters(Letters, 2));

                string digits = new string(GenerateRandomCharacters(Digits, 5));

                orderId = new string((letters + digits).ToCharArray().OrderBy(_ => Random.Next()).ToArray());
            } while (!Regex.IsMatch(orderId, pattern));

            return orderId;
        }

        private static char[] GenerateRandomCharacters(string source, int count)
        {
            return Enumerable.Range(0, count)
                .Select(_ => source[Random.Next(source.Length)])
                .ToArray();
        }
    }
}
