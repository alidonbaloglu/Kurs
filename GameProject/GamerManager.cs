using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    //MicroService
    internal class GamerManager : IGamerService
    {
        IUserValidationService userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            this.userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("kayıt oldu");
            }
            else
            {
                Console.WriteLine("doğrulama başarısız kayıt başarısız");

            }

        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("kayıt guncellendi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("kayıt silindi");
        }
    }
}
