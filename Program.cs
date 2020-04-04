using System;
using System.Diagnostics;

namespace Password_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            var plainTextPassword1 = "DF_SAskf2@_As!@?5546*%^__90";

            Stopwatch sw = Stopwatch.StartNew();

            for (var saltRounds = 1; saltRounds < 100; saltRounds++)
            {
                Console.Write("START : Bcrype | cost: {0} - ",saltRounds);
                var passwordHash = BCrypt.Net.BCrypt.HashPassword(plainTextPassword1);
                Console.WriteLine("END: Bcrype | cost: {0} - Total tid: {1} - PasswordHash: {2}", saltRounds, sw.Elapsed.TotalMilliseconds, passwordHash);
                sw.Stop();
            }
        }
    }
}
