using System.Data;

namespace DotNet_Abstract_vs_Interface
{

    public abstract class BaseDb
    {
        public abstract string GetDbVersion();
        public abstract string GenerateSql(int id);
        public DataTable ExecuteSql(string sql)
        {
            return new DataTable();
        }
    }

    public class SqlServerDb:BaseDb
    {
        public override string GetDbVersion() => "SqlServer 2012";

        public override string GenerateSql(int id)
        {
            return $"SELECT * FROM USERS WITH(NOLOCK) WHERE ID = {id}";
        }
    }
    public class OracleDb : BaseDb
    {
        public override string GetDbVersion() => "Oracle 18c";
        public override string GenerateSql(int id)
        {
            return $"SELECT * FROM USERS WHERE USER_ID = {id}";
        }
    }
    public class MySqlDb : BaseDb
    {
        public override string GenerateSql(int id)
        {
            return $"SELECT * FROM USERS WHERE US_ID = {id}";
        }

        public override string GetDbVersion() => "MySql Database";
     
    }
}
