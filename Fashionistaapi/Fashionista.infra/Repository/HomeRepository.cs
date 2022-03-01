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
    public class HomeRepository : IHomeRepository
    {

        private readonly IdbContext context;
        public HomeRepository(IdbContext context)
        {
            this.context = context;
        }

        public List<home> GET_All_Home()
        {
            IEnumerable<home> result = context.connection.Query<home>("Home_Package.GET_All_Home", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
    }
}
