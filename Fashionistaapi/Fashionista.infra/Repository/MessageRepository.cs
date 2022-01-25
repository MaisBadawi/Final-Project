using Dapper;
using Fashionista.core.Common;
using Fashionista.core.Data;
using Fashionista.core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Fashionista.infra.Repository
{
    public class MessageRepository : IMessageRepository
    {
        private readonly IdbContext context;
        public MessageRepository(IdbContext context)
        {
            this.context = context;
        }
       
        public bool Delete_Msg(int id)
        {
            var p = new DynamicParameters();
            p.Add("M_ID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var item = context.connection.ExecuteAsync("Massege_Package.Delete_Msg", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Message> Get_All_Msg()
        {
            IEnumerable<Message> result = context.connection.Query<Message>("Massege_Package.Get_All_Msg", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Message Get_Msg_By_Id(int id)
        {
            var p = new DynamicParameters();
            p.Add("M_ID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = context.connection.Query<Message>("Massege_Package.Get_Msg_By_Id", p, commandType: CommandType.StoredProcedure);

            return result.FirstOrDefault();
        }

        public string Insert_Msg(Message msg)
        {
            var p = new DynamicParameters();

            p.Add("M_Cust_Id", msg.CUSTOMER_ID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Msg", msg.MESSG, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Reciv", msg.RECIVER, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = context.connection.ExecuteAsync("Massege_Package.Insert_Msg", p, commandType: CommandType.StoredProcedure);
            return "valid";
        }

        public bool Update_Msg(Message msg)
        {
            var p = new DynamicParameters();

            p.Add("M_ID", msg.ID, dbType: DbType.Int32, direction: ParameterDirection.Input);

            p.Add("M_Cust_Id", msg.CUSTOMER_ID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Msg", msg.MESSG, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Reciv", msg.RECIVER, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = context.connection.ExecuteAsync("Massege_Package.Update_Msg", p, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
