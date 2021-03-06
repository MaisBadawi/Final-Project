using Fashionista.core.Data;
using Fashionista.core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fashionista.core.Repository
{
   public interface IMessageRepository
    {
        public string Insert_Msg(Message msg);
        public bool Delete_Msg(int id);
        public bool Update_Msg(Message msg);
        public List<MessagesDto> Get_All_Msg();
        public Message Get_Msg_By_Id(int id);

        public bool Update_StatusById(int idOfMsg);

        public ReadMsgDto NumOfReadMsg();
        public UnReadMsgDto NumOfUnReadMsg();



    }
}
