USE BertoniAcessorios
GO

IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'PR_VENDA_CONSULTAR')
BEGIN
    DROP Procedure PR_VENDA_CONSULTAR
END
GO

CREATE PROCEDURE dbo.PR_VENDA_CONSULTAR 
(
	@id int = null,
	@idproduto varchar(10) = null
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
		(v.id = @id or @id is null)
		AND (v.idproduto = @idproduto or @idproduto is null)
		AND v.ativo = 1

GO