using System;
using System.Collections.Generic;
using System.Text;
using KnightOnlineGameProje.Entities;

namespace KnightOnlineGameProje.Abstract
{
    internal interface IGamerService
    {
        void Add(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);

    }
}
