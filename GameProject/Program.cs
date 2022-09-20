using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManeger = new GamerManager(new NewEStateUserValidationManager());
            gamerManeger.Add(new Gamer {
                Id = 1,
                BirthYear = 1985,
                FirstName = "Engin",
                LastName = "Demiroğ",
                IdentityNumber = 1235 
            });


        }
    }
}