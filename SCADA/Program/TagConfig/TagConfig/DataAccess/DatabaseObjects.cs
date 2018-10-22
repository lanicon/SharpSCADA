using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DatabaseLib;
using SqlSugar;

namespace TagConfig.DataAccess
{
    public class DatabaseObjects
    {
        public static SqlSugarClient GetInstance()
        {
            SqlSugarClient db = new SqlSugarClient(new ConnectionConfig() { ConnectionString = DataHelper.ConnectString, DbType = DbType.SqlServer, IsAutoCloseConnection = true });
            db.Aop.OnLogExecuting = (sql, pars) =>
            {
                Console.WriteLine(sql + "\r\n" + db.Utilities.SerializeObject(pars.ToDictionary(it => it.ParameterName, it => it.Value)));
                Console.WriteLine();
            };
            return db;
        }
    }
}
