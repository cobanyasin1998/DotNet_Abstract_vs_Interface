using System.Data;

namespace DotNet_Abstract_vs_Interface
{

    public class BaseDb
    {
        public DataTable ExecuteSql(string sql)
        {
            return new DataTable();
        }
    }

    public class SqlServerDb:BaseDb
    {
        public string GetDbVersion() => "SqlServer 2012";

        public string GenerateSql(int id)
        {
            return $"SELECT * FROM USERS WITH(NOLOCK) WHERE ID = {id}";
        }
    }
    public class OracleDb : BaseDb
    {
        public string GetDbVersion() => "Oracle 18c";
        public string GenerateSql(int id)
        {
            return $"SELECT * FROM USERS WHERE USER_ID = {id}";
        }
    }
}
