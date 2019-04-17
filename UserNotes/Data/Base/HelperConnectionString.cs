using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserNotes.Data.Base
{
    public class HelperConnectionString : IHelperConnectionString
    {
        private string connectionString;

        public string GetConnectionString()
        {
            return connectionString;
        }
    }
}
