using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaajuTI.DAL.Factory
{
    public class ProviderBaseDALFactory
    {
        public static TProviderBaseDAL Build<TProviderBaseDAL>()
        {
            return Activator.CreateInstance<TProviderBaseDAL>();
        }
    }
}
