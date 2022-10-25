using System;

namespace DotNet_Abstract_vs_Interface
{
    class Program
    {
        static void Main(string[] args)
        {

            //Interface -> Aggreement - CanAbleTo

            var sqlDb = new SqlServerDb();
            sqlDb.ExecuteSql("");

            var oracleDb = new OracleDb();
            oracleDb.ExecuteSql("");
            var dbVers = oracleDb.GetDbVersion();

            //var baseDb = new BaseDb();
        }
    }
}
