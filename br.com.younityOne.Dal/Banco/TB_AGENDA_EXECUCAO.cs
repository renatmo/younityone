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
    
    public partial class TB_AGENDA_EXECUCAO
    {
        public int ID { get; set; }
        public int ID_DISPARADOR { get; set; }
        public System.DateTime DTH_EXECUCAO { get; set; }
    
        public virtual TB_DISPARADOR TB_DISPARADOR { get; set; }
    }
}
