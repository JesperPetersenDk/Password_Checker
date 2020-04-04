using System;

namespace Password_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            var plainTextPassword1 = "DF_SAskf2@_As!@?5546*%^__90";

            for (var saltRounds = 10; saltRounds < 21; saltRounds++)
            {
                var dt = DateTime.Now;
                Console.Write("START : Bcrype | cost: {0} - {1} - ",saltRounds, dt.Second);
                var passwordHash = BCrypt.Net.BCrypt.HashPassword(plainTextPassword1);
                Console.WriteLine("END: Bcrype | cost: {0} - {1} - PasswordHash: {2}", saltRounds, dt.Second, passwordHash);
            }
        }
    }
}
