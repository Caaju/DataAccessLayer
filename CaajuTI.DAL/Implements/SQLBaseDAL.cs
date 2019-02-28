using CaajuTI.DAL.Abstracts;
using CaajuTI.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CaajuTI.DAL.Factory;

namespace CaajuTI.DAL.Implements
{
    public class SQLBaseDAL:BaseDAL,IBaseDAL
    {
        public SQLBaseDAL(string connectionString)
            :base(new SqlConnection(),connectionString)
        {
            
        }

        protected override IDbCommand GetCommand()
        {
            return CommandFactory.Build<SqlCommand>();
        }

        protected override IDbDataAdapter GetDataAdapter(IDbCommand command)
        {
            return DataAdapterFactory.Build<SqlDataAdapter>(command);
        }

        protected override object GetParameter(KeyValuePair<string, object> parameter)
        {
            return DataParameterFactory.Builder<SqlParameter>(parameter.Key,parameter.Value);
        }
    }
}
