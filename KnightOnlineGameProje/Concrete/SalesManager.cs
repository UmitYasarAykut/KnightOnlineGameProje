using System;
using System.Collections.Generic;
using System.Text;
using KnightOnlineGameProje.Abstract;
using KnightOnlineGameProje.Entities;

namespace KnightOnlineGameProje.Concrete
{
    internal class SalesManager : ISalesService
    {
        public void Sales(ProductGame productGame, Gamer gamer, Offer offer)
        {
            Console.WriteLine(gamer.FirstName + " 'ya : " + productGame.GameName + " : Ürünü Satıldı. Tebrikler." + "%" + offer.IndirimYüzdesi);
        }
    }
}
