using System;
using KnightOnlineGameProje;
using KnightOnlineGameProje.Concrete;
using KnightOnlineGameProje.Entities;

namespace KnightOnlineGameProje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer();
            gamer1.FirstName = "Ümit";
            gamer1.LastName = "Aykut";
            gamer1.Id = 1;
            gamer1.IdentityNumber = "123456";

            ProductGame product1 = new ProductGame();
            product1.Id = 1;
            product1.GameName = "Buzul Çağı";
            product1.Categories = "Macera";
            product1.Fiyat = 125.6;

            Offer offer1 = new Offer();
            offer1.Id = 1;
            offer1.OfferName = "Yaz Kampanyasi";
            offer1.IndirimYüzdesi = 35;

            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(gamer1);
            gamerManager.Delete(gamer1);
            gamerManager.Update(gamer1);

            SalesManager salesManager = new SalesManager();
            salesManager.Sales(product1, gamer1, offer1);

            OfferManager offerManager = new OfferManager();
            offerManager.AddOffer(offer1);
            offerManager.DeleteOffer(offer1);
            offerManager.UpDateOffer(offer1);


        }
    }
}
