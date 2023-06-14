using System;
using System.Collections.Generic;
using System.Text;
using KnightOnlineGameProje.Entities;

namespace KnightOnlineGameProje.Abstract
{
    internal interface IOfferService
    {
        void AddOffer(Offer offer);
        void UpDateOffer(Offer offer);
        void DeleteOffer(Offer offer);

    }
}
