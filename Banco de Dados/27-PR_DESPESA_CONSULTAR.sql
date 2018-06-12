USE BertoniAcessorios
GO

IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'PR_DESPESA_CONSULTAR')
BEGIN
    DROP Procedure PR_DESPESA_CONSULTAR
END
GO

CREATE PROCEDURE dbo.PR_DESPESA_CONSULTAR 
(
	@id int = null,
	@idtipodespesa int = null,
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
		(d.id = @id or @id is null)
		AND (d.id = @idtipodespesa or @idtipodespesa is null)
		AND (d.dtdespesa = @dtdespesa or @dtdespesa is null)
		and d.ativo = 1

GO