using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using br.com.younityOne.DAL;
using br.com.younityOne.MODEL;

namespace br.com.younityOne.BLL
{
    public class GestaoAcessoBLL
    {

        GestaoAcessoDAL oGestaoAcessoDAL = new GestaoAcessoDAL();

        public List<UsuarioMODEL> logar(string pUsuario, string pSenha)
        {
            try
            {
                return oGestaoAcessoDAL.logar(pUsuario, pSenha);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<MenuMODEL> obterMenus(string pCodigoUsuario)
        {
            try
            {
                return oGestaoAcessoDAL.obterMenus(pCodigoUsuario);

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
