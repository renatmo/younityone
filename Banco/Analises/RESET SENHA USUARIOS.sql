USE YOUNITY_ONE
GO

UPDATE TB_USUARIO
SET DES_SENHA = SUBSTRING(sys.fn_sqlvarbasetostr(HASHBYTES('MD5', 'inicio')),3,32)


select * from TB_USUARIO