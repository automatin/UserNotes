using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.FileExtensions;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.Options;
using UserNotes.Data.Repository.IRepository;

namespace UserNotes.Data.Base
{
    public class BaseRepository : IDisposable
    {
        protected IDbConnection con;

        public BaseRepository(IHelperConnectionString helper)
        {
            con = new SqlConnection(helper.GetConnectionString());
        }
        public void Dispose()
        {
            if(con.State != ConnectionState.Closed)
                con.Close();
        }
    }
}
