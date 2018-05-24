USE BertoniAcessorios
GO

IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'PR_TIPOPRODUTO_LISTAR')
BEGIN
    DROP Procedure PR_TIPOPRODUTO_LISTAR
END
GO

CREATE PROCEDURE dbo.PR_TIPOPRODUTO_LISTAR 
(
	@Nome varchar(200) = NULL, 
	@Sigla varchar(10) = NULL
)
AS

	SELECT
		id,
		nome,
		sigla,
		dtinclusao,
		dtalteracao
	FROM
		tipoproduto
	WHERE
		(nome like '%' + @Nome + '%' OR @Nome is null)
		AND (sigla like '%' + @Sigla + '%' OR @Sigla is null)
	ORDER by nome

GO