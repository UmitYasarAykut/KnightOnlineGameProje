using System;
using System.Collections.Generic;
using System.Text;
using KnightOnlineGameProje.Abstract;
using KnightOnlineGameProje.Entities;

namespace KnightOnlineGameProje.Concrete
{
    internal class UserValidationManager : IGamerValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.Id == 1 && gamer.IdentityNumber == "123456"
                && gamer.FirstName == "Ümit" && gamer.LastName == "Aykut")
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
