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
    
    public partial class TB_GRUPO_NOTIFICACAO
    {
        public TB_GRUPO_NOTIFICACAO()
        {
            this.TB_GRUPO_NOTIFICACAO_ACAO = new HashSet<TB_GRUPO_NOTIFICACAO_ACAO>();
            this.TB_GRUPO_NOTIFICACAO_REMETENTE = new HashSet<TB_GRUPO_NOTIFICACAO_REMETENTE>();
        }
    
        public int ID { get; set; }
        public int ID_TIPO_NOTIFICACAO { get; set; }
        public string DES_GRUPO { get; set; }
    
        public virtual ICollection<TB_GRUPO_NOTIFICACAO_ACAO> TB_GRUPO_NOTIFICACAO_ACAO { get; set; }
        public virtual ICollection<TB_GRUPO_NOTIFICACAO_REMETENTE> TB_GRUPO_NOTIFICACAO_REMETENTE { get; set; }
        public virtual TB_TIPO_NOTIFICACAO TB_TIPO_NOTIFICACAO { get; set; }
    }
}
