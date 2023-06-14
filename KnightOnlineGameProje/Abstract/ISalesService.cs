using System;
using System.Collections.Generic;
using System.Text;
using KnightOnlineGameProje.Entities;

namespace KnightOnlineGameProje.Abstract
{
    internal interface ISalesService
    {
        void Sales(ProductGame productGame, Gamer gamer, Offer offer);
    }
}
