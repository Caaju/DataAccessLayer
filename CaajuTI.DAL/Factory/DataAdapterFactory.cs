using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaajuTI.DAL.Factory
{
    public class DataAdapterFactory
    {
        public static TDataAdapter Build<TDataAdapter>(IDbCommand commad)
            where TDataAdapter:IDbDataAdapter
        {
            return (TDataAdapter)Activator.CreateInstance(typeof(TDataAdapter), commad);
        }
    }
}
