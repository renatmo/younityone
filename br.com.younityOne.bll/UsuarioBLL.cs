using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using br.com.younityOne.DAL;
using br.com.younityOne.MODEL;

namespace br.com.younityOne.BLL
{
    public class UsuarioBLL
    {

        UsuarioDAL oUsuarioDAL = new UsuarioDAL();

        public List<UsuarioMODEL> logar(string pUsuario, string pSenha)
        {
            try
            {
                return oUsuarioDAL.logar(pUsuario, pSenha);

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
