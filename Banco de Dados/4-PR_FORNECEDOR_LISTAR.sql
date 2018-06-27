USE BertoniAcessorios
GO

IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'PR_FORNECEDOR_LISTAR')
BEGIN
    DROP Procedure PR_FORNECEDOR_LISTAR
END
GO

CREATE PROCEDURE dbo.PR_FORNECEDOR_LISTAR 
(
	@Nome varchar(200) = NULL, 
	@Descricao varchar(500) = NULL,
	@Codigo varchar(10) = NULL,
	@Ativo bit = null
)
AS

	SELECT
		id,
		nome,
		descricao,
		codigo,
		dtinclusao,
		dtalteracao,
		ativo,
		codigo + '-' + nome as codigonome
	FROM
		fornecedor
	WHERE
		(nome like '%' + @Nome + '%' OR @Nome is null)
		AND (descricao like '%' + @Descricao + '%' OR @Descricao is null)
		AND (codigo like '%' + @Codigo + '%' OR @Codigo is null)
		AND (ativo = @Ativo OR @Ativo is null)
	ORDER BY codigo
GO