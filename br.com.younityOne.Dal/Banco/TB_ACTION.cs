//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace br.com.younityOne.DAL.Banco
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_ACTION
    {
        public TB_ACTION()
        {
            this.TB_LOG_ACESSO = new HashSet<TB_LOG_ACESSO>();
            this.TB_LOG_SISTEMA = new HashSet<TB_LOG_SISTEMA>();
            this.TB_PERMISSOES_GRUPO = new HashSet<TB_PERMISSOES_GRUPO>();
            this.TB_SUBMENU = new HashSet<TB_SUBMENU>();
            this.TB_USUARIO_ACTION = new HashSet<TB_USUARIO_ACTION>();
        }
    
        public int ID { get; set; }
        public int ID_CONTROLLER { get; set; }
        public string NOM_ACTION { get; set; }
    
        public virtual TB_CONTROLER TB_CONTROLER { get; set; }
        public virtual ICollection<TB_LOG_ACESSO> TB_LOG_ACESSO { get; set; }
        public virtual ICollection<TB_LOG_SISTEMA> TB_LOG_SISTEMA { get; set; }
        public virtual ICollection<TB_PERMISSOES_GRUPO> TB_PERMISSOES_GRUPO { get; set; }
        public virtual ICollection<TB_SUBMENU> TB_SUBMENU { get; set; }
        public virtual ICollection<TB_USUARIO_ACTION> TB_USUARIO_ACTION { get; set; }
    }
}
