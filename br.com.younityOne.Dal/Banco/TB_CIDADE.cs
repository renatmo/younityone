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
    
    public partial class TB_CIDADE
    {
        public TB_CIDADE()
        {
            this.TB_ENDERECO = new HashSet<TB_ENDERECO>();
        }
    
        public int ID { get; set; }
        public string NOM_CIDADE { get; set; }
        public string SIG_UF { get; set; }
    
        public virtual ICollection<TB_ENDERECO> TB_ENDERECO { get; set; }
    }
}