using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public void Validate(Gamer gamer)
        {
            if (gamer.BirthYear==1985 && gamer.FirstName=="Engin" && gamer.LasstName=="Demiroğ"&& gamer.IdentityNumber==123645)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
