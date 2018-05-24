USE BertoniAcessorios
GO

IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'PR_FORNECEDOR_EXCLUIR')
BEGIN
    DROP Procedure PR_FORNECEDOR_EXCLUIR
END
GO

CREATE PROCEDURE dbo.PR_FORNECEDOR_EXCLUIR 
(
	@id int
)
AS

	UPDATE
		fornecedor
	SET 
		ativo = 0
	WHERE
		id = @id

GO