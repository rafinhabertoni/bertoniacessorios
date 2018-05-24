USE BertoniAcessorios
GO

IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'PR_VENDA_EXCLUIR')
BEGIN
    DROP Procedure PR_VENDA_EXCLUIR
END
GO

CREATE PROCEDURE dbo.PR_VENDA_EXCLUIR 
(
	@id int
)
AS

	UPDATE
		venda
	SET
		ativo = 0
	WHERE
		id = @id

GO