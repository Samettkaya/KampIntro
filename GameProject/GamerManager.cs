using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            Console.WriteLine("Kayıt oldu");
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt Güncellendi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi");
        }
    }
}
