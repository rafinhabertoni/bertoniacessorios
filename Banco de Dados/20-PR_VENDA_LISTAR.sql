USE BertoniAcessorios
GO

IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'PR_VENDA_LISTAR')
BEGIN
    DROP Procedure PR_VENDA_LISTAR
END
GO

CREATE PROCEDURE dbo.PR_VENDA_LISTAR 
(
	@IdVendedor int = NULL,
	@IdProduto int = NULL,
	@Ativo bit = NULL,
	@DtVenda datetime = NULL,
	@IdFornecedor int = NULL
)
AS
	SELECT 
		v.id,
		v.idvendedor,
		v.idproduto,
		v.valorvenda,
		v.valorcomissao,
		v.ativo,
		v.dtinclusao,
		v.dtalteracao,
		p.nome as nomeproduto,
		vd.nome as nomevendedor,
		p.codigo + '-' + p.nome as codigonomeproduto,
		p.idfornecedor,
		f.nome as nomefornecedor
	FROM
		venda v
		INNER JOIN produto p ON p.id = v.idproduto
		INNER JOIN vendedor vd ON vd.id = v.idvendedor
		INNER JOIN fornecedor f ON f.id = p.idfornecedor
	WHERE
		(v.idvendedor = @IdVendedor OR @IdVendedor is null)
		AND (v.idproduto = @IdProduto OR @IdProduto is null)
		AND (v.ativo = @Ativo OR @Ativo is null)
		AND (CONVERT(date,v.dtinclusao) = CONVERT(date,@DtVenda) OR @DtVenda is null)
		AND (p.idfornecedor = @IdFornecedor OR @IdFornecedor is null)

GO