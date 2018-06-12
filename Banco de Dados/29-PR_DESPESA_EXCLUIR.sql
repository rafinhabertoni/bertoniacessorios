USE BertoniAcessorios
GO

IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'PR_DESPESA_EXCLUIR')
BEGIN
    DROP Procedure PR_DESPESA_EXCLUIR
END
GO

CREATE PROCEDURE dbo.PR_DESPESA_EXCLUIR 
(
	@id int
)
AS

	UPDATE
		despesa
	SET
		ativo = 0
	WHERE
		id = @id

GO