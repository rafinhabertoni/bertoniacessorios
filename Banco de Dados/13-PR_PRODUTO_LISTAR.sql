USE BertoniAcessorios
GO

IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'PR_PRODUTO_LISTAR')
BEGIN
    DROP Procedure PR_PRODUTO_LISTAR
END
GO

CREATE PROCEDURE dbo.PR_PRODUTO_LISTAR 
(
	@Nome varchar(200) = NULL, 
	@Codigo varchar(10) = NULL,
	@IdTipoProduto int = NULL,
	@IdFornecedor int = NULL,
	@Ativo bit = NULL,
	@DtCompra datetime = NULL
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
		dbo.produto prd
		INNER JOIN tipoproduto tp ON tp.id = prd.idtipoproduto
		INNER JOIN fornecedor f ON f.id = prd.idfornecedor
	WHERE
		(prd.nome like '%' + @Nome + '%' OR @Nome is null)
		AND (prd.codigo like '%' + @Codigo + '%' OR @Codigo is null)
		AND (prd.idtipoproduto = @IdTipoProduto OR @IdTipoProduto is null)
		AND (prd.idfornecedor = @IdFornecedor OR @IdFornecedor is null)
		AND (prd.ativo = @Ativo OR @Ativo is null)
		AND (prd.dtcompra = @DtCompra OR @DtCompra is null)
	ORDER BY prd.codigo

GO