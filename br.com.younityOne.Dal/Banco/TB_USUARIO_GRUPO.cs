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
    
    public partial class TB_USUARIO_GRUPO
    {
        public TB_USUARIO_GRUPO()
        {
            this.TB_PERMISSOES_GRUPO = new HashSet<TB_PERMISSOES_GRUPO>();
            this.TB_USUARIO = new HashSet<TB_USUARIO>();
        }
    
        public int ID { get; set; }
        public string DES_GRUPO { get; set; }
        public Nullable<bool> FLG_ATIVO { get; set; }
    
        public virtual ICollection<TB_PERMISSOES_GRUPO> TB_PERMISSOES_GRUPO { get; set; }
        public virtual ICollection<TB_USUARIO> TB_USUARIO { get; set; }
    }
}
