﻿using Fashionista.core.Data;
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

        public List<GetPropertyDto> GetProperty_IDProduct(Property proparty)
        {
            return propertyService.GetProperty_IDProduct(proparty);
        }

        public string Insert_Property(Property proparty)
        {
            return propertyService.Insert_Property(proparty);        }

        public bool Update_Property(Property proparty)
        {
            return propertyService.Update_Property(proparty);
        }

        public bool Update_Quantity(int id, int quantity)
        {
            return propertyService.Update_Quantity(id,quantity);
        }
    }
}