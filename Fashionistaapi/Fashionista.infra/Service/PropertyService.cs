using Fashionista.core.Data;
using Fashionista.core.DTO;
using Fashionista.core.Repository;
using Fashionista.core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fashionista.infra.Service
{
    public class PropertyService : IPropertyService
    {
        private readonly IPropertyRepository propertyService;

        public PropertyService(IPropertyRepository propertyService)
        {
            this.propertyService = propertyService;
        }
        public bool Delete_Property(int id)
        {
          return  propertyService.Delete_Property(id);
        }

        public List<GetPropertyDto> GetAll_Property()
        {
            return propertyService.GetAll_Property();
        }

        public GetPropertyDto GetProperty_ID(int id)
        {
            return propertyService.GetProperty_ID(id);
        }

        public List<GetPropertyDto> GetProperty_IDProduct(PersonInfoDto proparty)
        {
            return propertyService.GetProperty_IDProduct(proparty);
        }

        public string Insert_Property(Property proparty)
        {
            return propertyService.Insert_Property(proparty);
        }

        public bool Update_Property(Property proparty)
        {
            return propertyService.Update_Property(proparty);
        }

        public bool Update_Quantity(int id, int quantity)
        {
            return propertyService.Update_Quantity(id,quantity);
        }

        public List<GetPropertyDto> GetAll_AvailabelProperty()
        {
            return propertyService.GetAll_AvailabelProperty();
        }


        public List<GetPropertyDto> GetByName(string name)
        {
            return propertyService.GetByName(name);
        }


        public List<NewestProductDto> GetNewestProperty()
        {
            return propertyService.GetNewestProperty();
        }

        public List<GetPropertyDto> GetSoldoutProperty()
        {
            return propertyService.GetSoldoutProperty();
        }


        public List<DetailsProp> GetPropDetails()
        {
            return propertyService.GetPropDetails();
        }

        public List<DetailsProp> GetPropDetailsBetweenDates(DateTime DateFrom, DateTime DateTo)
        {
            return propertyService.GetPropDetailsBetweenDates(DateFrom, DateTo);
        }

        public List<DetailsProp> GetPropDetailsDaily()
        {
            return propertyService.GetPropDetailsDaily();
        }

        public List<DetailsProp> GetPropDetailsMonthly()
        {
            return propertyService.GetPropDetailsMonthly();
        }

        public List<DetailsProp> GetPropDetailsYearly()
        {
            return propertyService.GetPropDetailsYearly();
        }

    }
}
