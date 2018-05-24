USE BertoniAcessorios
GO

IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'PR_VENDA_RELATORIO')
BEGIN
    DROP Procedure PR_VENDA_RELATORIO
END
GO

CREATE PROCEDURE dbo.PR_VENDA_RELATORIO 
AS
	SELECT 
		f.nome as nomefornecedor,
		p.codigo + '-' + p.nome as nomeproduto,
		vd.nome as nomevendedor,
		p.valorcompra,
		v.valorvenda,
		v.valorcomissao,
		v.dtinclusao as datavenda,
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

GO