using Fashionista.core.Data;
using Fashionista.core.DTO;
using Fashionista.core.Repository;
using Fashionista.core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fashionista.infra.Service
{
    public class MessageService : IMessageService
    {

        private readonly IMessageRepository msgRepository;
        public MessageService(IMessageRepository msgRepository)
        {
            this.msgRepository = msgRepository;
        }

        public bool Delete_Msg(int id)
        {
            return msgRepository.Delete_Msg(id);
        }

        public List<MessagesDto> Get_All_Msg()
        {
            return msgRepository.Get_All_Msg();
        }

        public Message Get_Msg_By_Id(int id)
        {
            return msgRepository.Get_Msg_By_Id(id);
        }

        public string Insert_Msg(Message msg)
        {
            return msgRepository.Insert_Msg(msg);
        }

        public ReadMsgDto NumOfReadMsg()
        {
            return msgRepository.NumOfReadMsg();
        }

        public UnReadMsgDto NumOfUnReadMsg()
        {
            return msgRepository.NumOfUnReadMsg();
        }

        public bool Update_Msg(Message msg)
        {
            return msgRepository.Update_Msg(msg);
        }


        public bool Update_StatusById(int idOfMsg)
        {
            return msgRepository.Update_StatusById(idOfMsg);
        }
    }
}
