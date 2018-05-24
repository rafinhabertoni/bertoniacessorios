USE BertoniAcessorios
GO

IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'PR_PRODUTO_CONSULTAR')
BEGIN
    DROP Procedure PR_PRODUTO_CONSULTAR
END
GO

CREATE PROCEDURE dbo.PR_PRODUTO_CONSULTAR 
(
	@id int = null,
	@codigo varchar(10) = null,
	@idfornecedor int = null
)
AS

	SELECT
		prd.id,
		prd.nome,
		prd.codigo,
		prd.idtipoproduto,
		prd.idfornecedor,
		prd.valorcompra,
		prd.valorvenda,
		prd.ativo,
		prd.dtcompra,
		prd.dtinclusao,
		prd.dtalteracao,
		tp.nome as tipoproduto,
		f.nome as nomefornecedor,
		prd.codigo + '-' + prd.nome as CodigoNome
	FROM
		produto prd
		INNER JOIN tipoproduto tp ON tp.id = prd.idtipoproduto
		INNER JOIN fornecedor f ON f.id = prd.idfornecedor
	WHERE
		(prd.id = @id or @id is null)
		AND (prd.codigo = @codigo or @codigo is null)
		AND (f.id = @idfornecedor or @idfornecedor is null)
		and prd.ativo = 1

GO