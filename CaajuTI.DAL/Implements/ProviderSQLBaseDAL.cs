using CaajuTI.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaajuTI.DAL.Implements
{
    public class ProviderSQLBaseDAL : IProviderBaseDAL
    {
        public IBaseDAL GetBaseDAL(string connectionString)
        {
            return new SQLBaseDAL(connectionString);
        }
    }
}
