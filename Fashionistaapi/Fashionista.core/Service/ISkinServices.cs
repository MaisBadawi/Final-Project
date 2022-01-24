using Fashionista.core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fashionista.core.Service
{
   public interface ISkinServices
    {
        public string insert_Skin(Skin skin);//from service 
        public bool delete_Skin(int id);
        public bool update_Skin(Skin skin);

        public List<Skin> getall_Skin();


        public Skin get_Skin_By_id(int id);
    }
}
