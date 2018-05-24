USE BertoniAcessorios
GO

IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'PR_VENDEDOR_LISTAR')
BEGIN
    DROP Procedure PR_VENDEDOR_LISTAR
END
GO

CREATE PROCEDURE dbo.PR_VENDEDOR_LISTAR 
(
	@Nome varchar(200) = NULL, 
	@Ativo bit = null
)
AS

	SELECT
		id,
		nome,
		porcentagem,
		dtinclusao,
		dtalteracao,
		ativo
	FROM
		vendedor
	WHERE
		(nome like '%' + @Nome + '%' OR @Nome is null)
		AND (ativo = @Ativo OR @Ativo is null)

GO