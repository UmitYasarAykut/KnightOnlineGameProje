﻿using System;
using System.Collections.Generic;
using System.Text;
using KnightOnlineGameProje.Abstract;
using KnightOnlineGameProje.Entities;

namespace KnightOnlineGameProje.Concrete
{
    internal class GamerManager : IGamerService
    {
        IGamerValidationService _gamerValidationService;

        public GamerManager(IGamerValidationService gamerValidationService)
        {
            _gamerValidationService = gamerValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_gamerValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Başarılı Bir Şekilde Kayıt Olundu :D");
            }
            else
            {
                Console.WriteLine("Doğrulama Başarısız");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt Silindi :S");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt Güncelleneme Başarılı ");
        }
    }
}
