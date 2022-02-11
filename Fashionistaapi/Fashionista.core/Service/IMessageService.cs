using Fashionista.core.Data;
using Fashionista.core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fashionista.core.Service
{
   public interface IMessageService
    {
        public string Insert_Msg(Message msg);
        public bool Delete_Msg(int id);
        public bool Update_Msg(Message msg);
        public List<MessagesDto> Get_All_Msg();
        public Message Get_Msg_By_Id(int id);
    }
}
