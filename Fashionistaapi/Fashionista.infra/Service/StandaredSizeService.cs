using Fashionista.core.Data;
using Fashionista.core.Repository;
using Fashionista.core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fashionista.infra.Service
{
   public class StandaredSizeService : IStandaredSizeService
    {
        private readonly IStandaredSizeRepository sizeRepository;
        public StandaredSizeService(IStandaredSizeRepository sizeRepository)
        {
            this.sizeRepository = sizeRepository;
        }

        public bool Delete_Size(int id)
        {
            return sizeRepository.Delete_Size(id);
        }

        public List<StandaredSize> GET_All_Size()
        {
            return sizeRepository.GET_All_Size();
        }

        public StandaredSize Get_Size_By_Id(int id)
        {
            return sizeRepository.Get_Size_By_Id(id);
        }

        public string Insert_Size(StandaredSize size)
        {
            return sizeRepository.Insert_Size(size);   
        }

        public bool Update_Size(StandaredSize size)
        {
            return sizeRepository.Update_Size(size);
        }
    }
}
