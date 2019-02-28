using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaajuTI.DAL.Interfaces
{
    public interface IProviderBaseDAL
    {
        IBaseDAL GetBaseDAL(string connectionString);
    }
}
