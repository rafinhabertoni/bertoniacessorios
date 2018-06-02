USE BertoniAcessorios
GO

IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'PR_VENDA_RELATORIO')
BEGIN
    DROP Procedure PR_VENDA_RELATORIO
END
GO

CREATE PROCEDURE dbo.PR_VENDA_RELATORIO
(
	@idFornecedor INT = NULL,
	@idVendedor INT = NULL,
	@idProduto INT = NULL,
	@tipoRelatorio INT = NULL
)
AS
	SELECT 
		f.nome as nomefornecedor,
		p.codigo + '-' + p.nome as nomeproduto,
		vd.nome as nomevendedor,
		p.valorcompra,
		v.valorvenda,
		v.valorcomissao,
		v.dtvenda as datavenda,
		(v.valorvenda - v.valorcomissao - p.valorcompra) as valorlucro
	FROM
		venda v
		INNER JOIN produto p ON p.id = v.idproduto
		INNER JOIN vendedor vd ON vd.id = v.idvendedor
		INNER JOIN fornecedor f ON f.id = p.idfornecedor
	WHERE
		v.ativo = 1
		and p.ativo = 1
		and vd.ativo = 1
		AND (f.id = @idFornecedor OR @idFornecedor IS NULL)
		AND (vd.id = @idVendedor OR @idVendedor IS NULL)
		AND (p.id = @idProduto OR @idProduto IS NULL)

GO