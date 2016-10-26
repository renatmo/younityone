using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using br.com.younityOne.DAL.Banco;
using br.com.younityOne.MODEL;

namespace br.com.younityOne.DAL
{
    public class UsuarioDAL
    {
        YOUNITY_ONEEntities _db = null;

        public List<UsuarioMODEL> logar(string pCodigoUsuario, string pSenha)
        {
            List<UsuarioMODEL> listaUsuario = null;

            try
            {
                using (_db = new YOUNITY_ONEEntities())
                {
                    listaUsuario = _db.SP_LOGAR(pCodigoUsuario, pSenha).Select(l => new UsuarioMODEL() 
                    {
                        COD_USUARIO = l.COD_USUARIO,
                        ID_GRUPO = l.ID_GRUPO,
                        DES_GRUPO = l.DES_GRUPO,
                        NOM_ACTION = l.NOM_ACTION,
                        NOM_CONTROLLER = l.NOM_CONTROLLER
                    }).ToList();
                }

                return listaUsuario;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
