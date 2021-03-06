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
	@mes INT = NULL,
	@ano INT = NULL
)
AS
	DECLARE @QtdProdutos INT = NULL
	DECLARE @QtdProdutosVendidos INT = NULL

	SELECT @QtdProdutos = (
		SELECT 
			COUNT(1)
		FROM 
			produto prd
		WHERE
			prd.ativo = 1)

	SELECT @QtdProdutosVendidos = (
		SELECT 
			COUNT(1)
		FROM 
			produto prd
		INNER JOIN venda v ON v.idproduto = prd.id
		WHERE
			prd.ativo = 1
		AND v.ativo = 1)

Select * from (
	SELECT 
		f.nome as nomefornecedor,
		p.codigo + '-' + p.nome as nomeproduto,
		vd.nome as nomevendedor,
		p.valorcompra,
		v.valorvenda,
		v.valorcomissao,
		v.dtvenda as datavenda,
		(v.valorvenda - v.valorcomissao - p.valorcompra) as valorlucro,
		CASE DATEPART(MONTH, dtvenda)
         WHEN 1 THEN 'Janeiro' + '/' + CONVERT(varchar(10), DATEPART(YEAR, dtvenda))
         WHEN 2 THEN 'Fevereiro' + '/' + CONVERT(varchar(10), DATEPART(YEAR, dtvenda))
         WHEN 3 THEN 'Mar�o' + '/' + CONVERT(varchar(10), DATEPART(YEAR, dtvenda))
         WHEN 4 THEN 'Abril' + '/' + CONVERT(varchar(10), DATEPART(YEAR, dtvenda))
         WHEN 5 THEN 'Maio' + '/' + CONVERT(varchar(10), DATEPART(YEAR, dtvenda))
         WHEN 6 THEN 'Junho' + '/' + CONVERT(varchar(10), DATEPART(YEAR, dtvenda))
         WHEN 7 THEN 'Julho' + '/' + CONVERT(varchar(10), DATEPART(YEAR, dtvenda))
         WHEN 8 THEN 'Agosto' + '/' + CONVERT(varchar(10), DATEPART(YEAR, dtvenda))
         WHEN 9 THEN 'Setembro' + '/' + CONVERT(varchar(10), DATEPART(YEAR, dtvenda))
         WHEN 10 THEN 'Outubro' + '/' + CONVERT(varchar(10), DATEPART(YEAR, dtvenda))
         WHEN 11 THEN 'Novembro' + '/' + CONVERT(varchar(10), DATEPART(YEAR, dtvenda))
         WHEN 12 THEN 'Dezembro' + '/' + CONVERT(varchar(10), DATEPART(YEAR, dtvenda))
       END AS mes,
	   CONVERT(varchar(10), DATEPART(MONTH, dtvenda)) + CONVERT(varchar(10), DATEPART(YEAR, dtvenda)) as ordem,
	   p.idtipoproduto,
	   tp.nome as tipoproduto,
	   @QtdProdutos as quantidadeprodutos,
	   @QtdProdutosVendidos as quantidadeprodutosvendidos,
	   @QtdProdutos - @QtdProdutosVendidos as quantidadeprodutosnaovenddos 
	FROM
		venda v
		INNER JOIN produto p ON p.id = v.idproduto
		INNER JOIN tipoproduto tp ON tp.id = p.idtipoproduto
		INNER JOIN vendedor vd ON vd.id = v.idvendedor
		INNER JOIN fornecedor f ON f.id = p.idfornecedor
	WHERE
		v.ativo = 1
		and p.ativo = 1
		and vd.ativo = 1
		AND (f.id = @idFornecedor OR @idFornecedor IS NULL)
		AND (vd.id = @idVendedor OR @idVendedor IS NULL)
		AND (p.id = @idProduto OR @idProduto IS NULL)
		AND (DATEPART(MONTH, dtvenda) = @mes OR @mes IS NULL)
		AND (DATEPART(YEAR, dtvenda) = @ano OR @ano IS NULL)

	UNION 

	SELECT 
		'Despesa' as nomefornecedor,
		td.nome as nomeproduto,
		'' as nomevendedor,
		d.valor as valorcompra,
		0 as valorvenda,
		0 valorcomissao,
		d.dtdespesa as datavenda,
		(0 - d.valor) as valorlucro,
		CASE DATEPART(MONTH, d.dtdespesa)
         WHEN 1 THEN 'Janeiro' + '/' + CONVERT(varchar(10), DATEPART(YEAR, d.dtdespesa))
         WHEN 2 THEN 'Fevereiro' + '/' + CONVERT(varchar(10), DATEPART(YEAR, d.dtdespesa))
         WHEN 3 THEN 'Mar�o' + '/' + CONVERT(varchar(10), DATEPART(YEAR, d.dtdespesa))
         WHEN 4 THEN 'Abril' + '/' + CONVERT(varchar(10), DATEPART(YEAR, d.dtdespesa))
         WHEN 5 THEN 'Maio' + '/' + CONVERT(varchar(10), DATEPART(YEAR, d.dtdespesa))
         WHEN 6 THEN 'Junho' + '/' + CONVERT(varchar(10), DATEPART(YEAR, d.dtdespesa))
         WHEN 7 THEN 'Julho' + '/' + CONVERT(varchar(10), DATEPART(YEAR, d.dtdespesa))
         WHEN 8 THEN 'Agosto' + '/' + CONVERT(varchar(10), DATEPART(YEAR, d.dtdespesa))
         WHEN 9 THEN 'Setembro' + '/' + CONVERT(varchar(10), DATEPART(YEAR, d.dtdespesa))
         WHEN 10 THEN 'Outubro' + '/' + CONVERT(varchar(10), DATEPART(YEAR, d.dtdespesa))
         WHEN 11 THEN 'Novembro' + '/' + CONVERT(varchar(10), DATEPART(YEAR, d.dtdespesa))
         WHEN 12 THEN 'Dezembro' + '/' + CONVERT(varchar(10), DATEPART(YEAR, d.dtdespesa))
       END AS mes,
	   CONVERT(varchar(10), DATEPART(MONTH, d.dtdespesa)) + CONVERT(varchar(10), DATEPART(YEAR, d.dtdespesa)) as ordem,
	   0 as idtipoproduto,
	   '' as tipoproduto,
	   @QtdProdutos as quantidadeprodutos,
	   @QtdProdutosVendidos as quantidadeprodutosvendidos,
	   @QtdProdutos - @QtdProdutosVendidos as quantidadeprodutosnaovenddos 
	FROM
		despesa d
		INNER JOIN tipodespesa td ON d.idtipodespesa = td.id
	WHERE
		d.ativo = 1
		and td.ativo = 1
		AND (DATEPART(MONTH, d.dtdespesa) = @mes OR @mes IS NULL)
		AND (DATEPART(YEAR, d.dtdespesa) = @ano OR @ano IS NULL)
	) as tabela
	ORDER by mes 
GO