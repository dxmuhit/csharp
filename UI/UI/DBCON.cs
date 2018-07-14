using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace DBcon
{
    class DBCON
    {
        public OracleConnection thisCon = new OracleConnection("Data Source=127.0.0.1; User Id=muhit; Password=pass");
    }
}
