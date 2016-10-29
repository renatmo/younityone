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
    public class GestaoAcessoDAL
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
                        NOM_CONTROLLER = l.NOM_CONTROLLER,
                        NOM_USUARIO = l.NOM_USUARIO
                    }).ToList();
                }

                return listaUsuario;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<MenuMODEL> obterMenus(string pCodigoUsuario)
        {
            List<MenuMODEL> menuFinal = null;
            MenuMODEL oMenuMODEL = null;

            try
            {
                using (_db = new YOUNITY_ONEEntities())
                {
                    List<MenuMODEL> listaMenu = _db.TB_MENU.OrderBy(m => m.NUM_ORDEM).Select(m => new MenuMODEL()
                    {
                        Id = m.ID,
                        Nome = m.NOM_MENU,
                        NomeImagem = m.NOM_IMAGEM

                    }).ToList();

                    List<SubMenuMODEL> listaSubMenu = (from u in _db.TB_USUARIO
                                                       join p in _db.TB_PERMISSOES_GRUPO on u.ID_GRUPO equals p.ID_GRUPO
                                                       join s in _db.TB_SUBMENU on p.ID_ACTION equals s.ID_ACTION
                                                       join a in _db.TB_ACTION on s.ID_ACTION equals a.ID
                                                       join c in _db.TB_CONTROLER on a.ID_CONTROLLER equals c.ID
                                                       where u.COD_USUARIO == pCodigoUsuario
                                                       select new SubMenuMODEL()
                                                       {
                                                           Nome = s.NOM_SUBMENU,
                                                           IdMenu = s.ID_MENU,
                                                           NomeAction = a.NOM_ACTION,
                                                           NomeController = c.NOM_CONTROLLER
                                                       }).ToList();

                    menuFinal = new List<MenuMODEL>();

                    foreach (MenuMODEL item in listaMenu)
                    {
                        oMenuMODEL = new MenuMODEL();

                        oMenuMODEL.Nome = item.Nome;
                        oMenuMODEL.NomeImagem = item.NomeImagem;

                        oMenuMODEL.SubMenu = listaSubMenu.Where(s => s.IdMenu == item.Id).ToList();

                        if (oMenuMODEL.SubMenu != null && oMenuMODEL.SubMenu.Count > 0)
                        {
                            menuFinal.Add(oMenuMODEL);
                        }

                    }

                    return menuFinal;

                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
