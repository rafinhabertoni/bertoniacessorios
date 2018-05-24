USE BertoniAcessorios
GO

IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'PR_PRODUTO_EXCLUIR')
BEGIN
    DROP Procedure PR_PRODUTO_EXCLUIR
END
GO

CREATE PROCEDURE dbo.PR_PRODUTO_EXCLUIR 
(
	@id int
)
AS

	UPDATE
		produto
	SET
		ativo = 0
	WHERE
		id = @id

GO