USE BertoniAcessorios
GO

IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'PR_DESPESA_LISTAR')
BEGIN
    DROP Procedure PR_DESPESA_LISTAR
END
GO

CREATE PROCEDURE dbo.PR_DESPESA_LISTAR 
(
	@idtipodespesa int = null,
	@ativo bit = null,
	@dtdespesa datetime = null
)
AS

	SELECT
		d.id,
		d.idtipodespesa,
		d.valor,
		d.ativo,
		d.dtdespesa,
		d.dtinclusao,
		d.dtalteracao,
		td.nome as NomeTipoDespesa
	FROM
		despesa d
		INNER JOIN tipodespesa td ON td.id = d.idtipodespesa
	WHERE
	    (d.idtipodespesa = @idtipodespesa or @idtipodespesa is null)
		AND (d.ativo = @ativo or @ativo is null)
		AND (d.dtdespesa = @dtdespesa or @dtdespesa is null)
	ORDER BY d.id

GO