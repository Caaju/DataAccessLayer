using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CaajuTI.DAL.Interfaces;
using CaajuTI.DAL.Factory;
using CaajuTI.DAL.Implements;
using System.Data;

namespace CaajuTI.DALTest
{
    [TestClass]
    public class UsuarioDAL
    {
        IProviderBaseDAL _provider;
        public UsuarioDAL()
        {
            _provider = ProviderBaseDALFactory.Build<ProviderSQLBaseDAL>();
        }
        [TestMethod]
        public void SelecionarUsuarioPorLogin()
        {
            var login = new { email = "teste@teste.com.br", senha = "1234" };
            using (var baseDAL=_provider.GetBaseDAL("base"))
            {
                string sql = "SELECT * FROM USU_USUARIO WHERE EMAIL=@EMAIL AND SENHA=@SENHA";

                QueryParameter parameter = new QueryParameter();
                parameter["EMAIL"] = login.email;
                parameter["SENHA"] = login.senha;

                DataSet ds=baseDAL.ExecuteQuery(sql, parameter);

            }

        }
    }
}
