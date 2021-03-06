USE YOUNITY_ONE
GO

INSERT INTO TB_TIPO_PESSOA (DES_PESSOA) VALUES ('FISICA')
INSERT INTO TB_TIPO_PESSOA (DES_PESSOA) VALUES ('JURIDICA')
GO

INSERT INTO TB_CLIENTE
	(ID_TIPO_PESSOA, NOM_FANTASIA, NOM_RAZAO, NUM_DOCUMENTO, FLG_ATIVO)
VALUES
	(1,'DASA', 'DASA', '01234567000102', 1)

INSERT INTO TB_DEPARTAMENTO_CLIENTE
	(ID_CLIENTE, NOM_DEPARTAMENTO, FLG_ATIVO)
VALUES
	(1, 'GERENCIA CONTAS RECEBER', 1)


INSERT INTO TB_USUARIO_GRUPO
	(DES_GRUPO, FLG_ATIVO)
VALUES
	('Administrador', 1)

INSERT INTO TB_USUARIO
	(ID_DEPARTAMENTO, ID_GRUPO, COD_USUARIO, DES_SENHA, NOM_USUARIO, NUM_CPF, END_MAIL, FLG_ATIVO)
VALUES
	(1, 1, '033004221', SUBSTRING(sys.fn_sqlvarbasetostr(HASHBYTES('MD5', 'inicio')),3,32), 'RENATO', '30579879828', 'renato@younitytec.com.br', 1)


INSERT INTO TB_CONTROLER (NOM_CONTROLLER) VALUES ('Dashboards')
INSERT INTO TB_CONTROLER (NOM_CONTROLLER) VALUES ('Automacao')
INSERT INTO TB_CONTROLER (NOM_CONTROLLER) VALUES ('Relatorio')
INSERT INTO TB_CONTROLER (NOM_CONTROLLER) VALUES ('GestaoAcesso')

INSERT INTO TB_ACTION (ID_CONTROLLER, NOM_ACTION) VALUES (1, 'Visualizar')
INSERT INTO TB_ACTION (ID_CONTROLLER, NOM_ACTION) VALUES (2, 'CriarTarefa')
INSERT INTO TB_ACTION (ID_CONTROLLER, NOM_ACTION) VALUES (2, 'GerenciarTarefa')
INSERT INTO TB_ACTION (ID_CONTROLLER, NOM_ACTION) VALUES (3, 'Visualizar')
INSERT INTO TB_ACTION (ID_CONTROLLER, NOM_ACTION) VALUES (4, 'CriarUsuario')
INSERT INTO TB_ACTION (ID_CONTROLLER, NOM_ACTION) VALUES (4, 'GerenciarUsuario')


INSERT INTO TB_PERMISSOES_GRUPO (ID_ACTION, ID_GRUPO) VALUES (1, 1)
INSERT INTO TB_PERMISSOES_GRUPO (ID_ACTION, ID_GRUPO) VALUES (2, 1)
INSERT INTO TB_PERMISSOES_GRUPO (ID_ACTION, ID_GRUPO) VALUES (3, 1)
INSERT INTO TB_PERMISSOES_GRUPO (ID_ACTION, ID_GRUPO) VALUES (4, 1)
INSERT INTO TB_PERMISSOES_GRUPO (ID_ACTION, ID_GRUPO) VALUES (5, 1)
INSERT INTO TB_PERMISSOES_GRUPO (ID_ACTION, ID_GRUPO) VALUES (6, 1)


INSERT INTO TB_MENU (NOM_MENU, NUM_ORDEM, FLG_ATIVO, NOM_IMAGEM) VALUES ('Dashboards', 0, 1, 'fa fa-bar-chart-o')
INSERT INTO TB_MENU (NOM_MENU, NUM_ORDEM, FLG_ATIVO, NOM_IMAGEM) VALUES ('Automa��o', 1, 1, 'fa fa-desktop')
INSERT INTO TB_MENU (NOM_MENU, NUM_ORDEM, FLG_ATIVO, NOM_IMAGEM) VALUES ('Relat�rios Execu��o', 2, 1, 'fa fa-pie-chart')
INSERT INTO TB_MENU (NOM_MENU, NUM_ORDEM, FLG_ATIVO, NOM_IMAGEM) VALUES ('Gest�o de Acessos', 3, 1, 'fa fa-diamond')

INSERT INTO TB_SUBMENU (ID_ACTION, ID_MENU, NOM_SUBMENU, NUM_ORDEM) VALUES (1, 1, 'Visualizar', 0)
INSERT INTO TB_SUBMENU (ID_ACTION, ID_MENU, NOM_SUBMENU, NUM_ORDEM) VALUES (2, 2, 'Criar Tarefa', 0)
INSERT INTO TB_SUBMENU (ID_ACTION, ID_MENU, NOM_SUBMENU, NUM_ORDEM) VALUES (3, 2, 'Gerenciar Tarefa', 1)
INSERT INTO TB_SUBMENU (ID_ACTION, ID_MENU, NOM_SUBMENU, NUM_ORDEM) VALUES (4, 3, 'Visualizar', 0)
INSERT INTO TB_SUBMENU (ID_ACTION, ID_MENU, NOM_SUBMENU, NUM_ORDEM) VALUES (5, 4, 'Criar Usu�rio', 0)
INSERT INTO TB_SUBMENU (ID_ACTION, ID_MENU, NOM_SUBMENU, NUM_ORDEM) VALUES (6, 4, 'Gerenciar Usu�rio', 1)
