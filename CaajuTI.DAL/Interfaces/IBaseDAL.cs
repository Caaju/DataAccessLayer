using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace CaajuTI.DAL.Interfaces
{
    public interface IBaseDAL:IDisposable
    {
        void ExecuteCommand(string command, IQueryParameter parameter);
        DataSet ExecuteQuery(string select);
        DataSet ExecuteQuery(string select, IQueryParameter parameter);
    }
}
