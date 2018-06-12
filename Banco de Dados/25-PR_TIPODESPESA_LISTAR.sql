USE BertoniAcessorios
GO

IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'PR_TIPODESPESA_LISTAR')
BEGIN
    DROP Procedure PR_TIPODESPESA_LISTAR
END
GO

CREATE PROCEDURE dbo.PR_TIPODESPESA_LISTAR 
(
	@Nome varchar(200) = NULL, 
	@Ativo bit = NULL
)
AS

	SELECT
		id,
		nome,
		ativo,
		dtinclusao,
		dtalteracao
	FROM
		tipodespesa
	WHERE
		(nome like '%' + @Nome + '%' OR @Nome is null)
		AND (ativo = @Ativo OR @Ativo is null)
	ORDER by nome

GO