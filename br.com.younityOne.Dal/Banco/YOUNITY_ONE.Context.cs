﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class YOUNITY_ONEEntities : DbContext
    {
        public YOUNITY_ONEEntities()
            : base("name=YOUNITY_ONEEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TB_ACAO> TB_ACAO { get; set; }
        public virtual DbSet<TB_ACTION> TB_ACTION { get; set; }
        public virtual DbSet<TB_AGENDA_EXECUCAO> TB_AGENDA_EXECUCAO { get; set; }
        public virtual DbSet<TB_CIDADE> TB_CIDADE { get; set; }
        public virtual DbSet<TB_CLIENTE> TB_CLIENTE { get; set; }
        public virtual DbSet<TB_CONTATO> TB_CONTATO { get; set; }
        public virtual DbSet<TB_CONTROLER> TB_CONTROLER { get; set; }
        public virtual DbSet<TB_DEPARTAMENTO_CLIENTE> TB_DEPARTAMENTO_CLIENTE { get; set; }
        public virtual DbSet<TB_DISPARADOR> TB_DISPARADOR { get; set; }
        public virtual DbSet<TB_ENDERECO> TB_ENDERECO { get; set; }
        public virtual DbSet<TB_FONTE_DEPARTAMENTO> TB_FONTE_DEPARTAMENTO { get; set; }
        public virtual DbSet<TB_FONTE_PAGADORA> TB_FONTE_PAGADORA { get; set; }
        public virtual DbSet<TB_FONTE_PAGADORA_PARAMETRO> TB_FONTE_PAGADORA_PARAMETRO { get; set; }
        public virtual DbSet<TB_FONTE_PAGADORA_PARAMETRO_DEFINICAO> TB_FONTE_PAGADORA_PARAMETRO_DEFINICAO { get; set; }
        public virtual DbSet<TB_GRUPO_NOTIFICACAO> TB_GRUPO_NOTIFICACAO { get; set; }
        public virtual DbSet<TB_GRUPO_NOTIFICACAO_ACAO> TB_GRUPO_NOTIFICACAO_ACAO { get; set; }
        public virtual DbSet<TB_GRUPO_NOTIFICACAO_REMETENTE> TB_GRUPO_NOTIFICACAO_REMETENTE { get; set; }
        public virtual DbSet<TB_HISTORICO_EXECUCAO> TB_HISTORICO_EXECUCAO { get; set; }
        public virtual DbSet<TB_LOG_ACESSO> TB_LOG_ACESSO { get; set; }
        public virtual DbSet<TB_LOG_SISTEMA> TB_LOG_SISTEMA { get; set; }
        public virtual DbSet<TB_MENU> TB_MENU { get; set; }
        public virtual DbSet<TB_MODULO> TB_MODULO { get; set; }
        public virtual DbSet<TB_MODULO_DEPARTAMENTO> TB_MODULO_DEPARTAMENTO { get; set; }
        public virtual DbSet<TB_PERMISSOES_GRUPO> TB_PERMISSOES_GRUPO { get; set; }
        public virtual DbSet<TB_SUBMENU> TB_SUBMENU { get; set; }
        public virtual DbSet<TB_TAREFA> TB_TAREFA { get; set; }
        public virtual DbSet<TB_TAREFA_FONTE> TB_TAREFA_FONTE { get; set; }
        public virtual DbSet<TB_TAREFA_FONTE_ACESSO> TB_TAREFA_FONTE_ACESSO { get; set; }
        public virtual DbSet<TB_TAREFA_PROXIMA> TB_TAREFA_PROXIMA { get; set; }
        public virtual DbSet<TB_TAREFA_TIPO_ENTREGA> TB_TAREFA_TIPO_ENTREGA { get; set; }
        public virtual DbSet<TB_TIPO_ACAO> TB_TIPO_ACAO { get; set; }
        public virtual DbSet<TB_TIPO_CONTATO> TB_TIPO_CONTATO { get; set; }
        public virtual DbSet<TB_TIPO_DISPARADOR> TB_TIPO_DISPARADOR { get; set; }
        public virtual DbSet<TB_TIPO_ENTREGA> TB_TIPO_ENTREGA { get; set; }
        public virtual DbSet<TB_TIPO_LOGRADOURO> TB_TIPO_LOGRADOURO { get; set; }
        public virtual DbSet<TB_TIPO_NOTIFICACAO> TB_TIPO_NOTIFICACAO { get; set; }
        public virtual DbSet<TB_TIPO_PESSOA> TB_TIPO_PESSOA { get; set; }
        public virtual DbSet<TB_UNIDADE> TB_UNIDADE { get; set; }
        public virtual DbSet<TB_USUARIO> TB_USUARIO { get; set; }
        public virtual DbSet<TB_USUARIO_ACTION> TB_USUARIO_ACTION { get; set; }
        public virtual DbSet<TB_USUARIO_GRUPO> TB_USUARIO_GRUPO { get; set; }
    
        public virtual ObjectResult<SP_LOGAR_Result> SP_LOGAR(string cOD_USUARIO, string dES_SENHA)
        {
            var cOD_USUARIOParameter = cOD_USUARIO != null ?
                new ObjectParameter("COD_USUARIO", cOD_USUARIO) :
                new ObjectParameter("COD_USUARIO", typeof(string));
    
            var dES_SENHAParameter = dES_SENHA != null ?
                new ObjectParameter("DES_SENHA", dES_SENHA) :
                new ObjectParameter("DES_SENHA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_LOGAR_Result>("SP_LOGAR", cOD_USUARIOParameter, dES_SENHAParameter);
        }
    }
}
