using System;
using System.Collections.Generic;
using System.Text;
using KnightOnlineGameProje.Entities;

namespace KnightOnlineGameProje.Abstract
{
    internal interface IGamerValidationService
    {
        bool Validate(Gamer gamer);
    }
}
