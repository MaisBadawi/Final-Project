using Fashionista.core.Data;
using Fashionista.core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fashionista.core.Repository
{
    public interface IPropertyRepository
    {
        public string Insert_Property(Property proparty);
        public bool Delete_Property(int id);
        public bool Update_Property(Property proparty);
        public bool Update_Quantity(int id, int quantity);
        public List<GetPropertyDto> GetAll_Property( );
        public GetPropertyDto GetProperty_ID(int id);
        public List<GetPropertyDto> GetProperty_IDProduct(PersonInfoDto proparty);
        public List<GetPropertyDto> GetAll_AvailabelProperty();
        public List<GetPropertyDto> GetByName(string name);

        public List<NewestProductDto> GetNewestProperty();

        public List<GetPropertyDto> GetSoldoutProperty();
        public List<DetailsProp> GetPropDetails();
        public List<DetailsProp> GetPropDetailsDaily();
        public List<DetailsProp> GetPropDetailsMonthly();
        public List<DetailsProp> GetPropDetailsYearly();
        public List<DetailsProp> GetPropDetailsBetweenDates(DateTime DateFrom, DateTime DateTo);


    }
}
