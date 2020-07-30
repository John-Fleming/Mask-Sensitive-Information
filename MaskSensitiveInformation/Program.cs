using System;
using System.Text;

namespace MaskSensitiveInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a secret password:");
            var secret = Console.ReadLine();

            var maskedSecret = new StringBuilder();

            foreach (var c in secret)
            {
                var len = secret.Length;
                var position = secret.IndexOf(c);
                var distanceFromEnd = len - position;

                if (distanceFromEnd > 4)
                {
                    maskedSecret.Append("*");
                }
                else
                {
                    maskedSecret.Append(c);
                }
            }
            
            Console.WriteLine(maskedSecret);
        }
    }
}
