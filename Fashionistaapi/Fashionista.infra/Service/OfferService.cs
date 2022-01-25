using Fashionista.core;
using Fashionista.core.Data;
using Fashionista.core.Repository;
using Fashionista.core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fashionista.infra.Service
{
    public class OfferService : IOfferService
    {

        private readonly IOfferRepository offerRepository;
        public OfferService(IOfferRepository offerRepository)
        {
            this.offerRepository = offerRepository;
        }

        public bool Delete_Offer(int id)
        {
          return offerRepository.Delete_Offer(id);
        }

        public List<Offer> GET_All_Offer()
        {
            return offerRepository.GET_All_Offer();
        }

        public Offer Get_Offer_By_Id(int id)
        {
            return offerRepository.Get_Offer_By_Id(id);
        }
        public string Insert_Offer(Offer offer)
        {
            return offerRepository.Insert_Offer(offer);
        }

        public bool Update_Offer(Offer offer)
        {
            return offerRepository.Update_Offer(offer);
        }
    }
}
