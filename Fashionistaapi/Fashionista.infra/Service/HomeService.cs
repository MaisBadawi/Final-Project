using Fashionista.core.Data;
using Fashionista.core.Repository;
using Fashionista.core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fashionista.infra.Service
{
    public class HomeService : IHomeService
    {
        private readonly IHomeRepository homeRepository;
        public HomeService(IHomeRepository homeRepository)
        {
            this.homeRepository = homeRepository;
        }

        public List<home> GET_All_Home()
        {
            return homeRepository.GET_All_Home();
        }
    }
}
