USE BertoniAcessorios
GO

IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'PR_FORNECEDOR_CONSULTAR')
BEGIN
    DROP Procedure PR_FORNECEDOR_CONSULTAR
END
GO

CREATE PROCEDURE dbo.PR_FORNECEDOR_CONSULTAR 
(
	@id int = null,
	@codigo varchar(10) = null
)
AS

	SELECT
		id,
		nome,
		descricao,
		codigo,
		dtinclusao,
		dtalteracao
	FROM
		fornecedor
	WHERE
		(id = @id or @id is null)
		AND (codigo = @codigo or @codigo is null)
		AND ativo = 1

GO