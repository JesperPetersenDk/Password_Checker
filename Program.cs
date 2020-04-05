using System;
using System.Diagnostics;

namespace Password_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            var plainTextPassword1 = "DF_SAskf2@_As!@?5546*%^__90";
            var plainTextPassword2 = "h=-&[`ZH5e*5QZ+JC&{?G&34_E^";

            Stopwatch sw = new Stopwatch();

            var passwordx = BCrypt.Net.BCrypt.HashPassword(plainTextPassword2, 4);

            for (var saltRounds = 4; saltRounds < 20; saltRounds++)
            {
                sw.Start();
                Console.Write("START : Bcrypt | cost: {0} - ", saltRounds);
                var password = BCrypt.Net.BCrypt.HashPassword(plainTextPassword1, saltRounds);
                Console.WriteLine("END: Bcrypt | cost: {0} - Total tid: {1} - PasswordHash: {2}", saltRounds, sw.Elapsed.TotalMilliseconds, password);
                sw.Stop();
                sw.Restart();
            }
        }
    }
}
