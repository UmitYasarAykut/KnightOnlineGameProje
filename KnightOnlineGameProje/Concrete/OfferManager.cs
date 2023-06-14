using System;
using System.Collections.Generic;
using System.Text;
using KnightOnlineGameProje.Abstract;
using KnightOnlineGameProje.Entities;

namespace KnightOnlineGameProje.Concrete
{
    internal class OfferManager : IOfferService
    {
        public void AddOffer(Offer offer)
        {
            Console.WriteLine("Kampanya eklendi");
        }

        public void DeleteOffer(Offer offer)
        {
            Console.WriteLine("Kampanya silindi");
        }

        public void UpDateOffer(Offer offer)
        {
            Console.WriteLine("Kampanya güncellendi");
        }
    }
}
