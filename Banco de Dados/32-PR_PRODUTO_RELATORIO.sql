USE BertoniAcessorios
GO

IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'PR_PRODUTO_RELATORIO')
BEGIN
    DROP Procedure PR_PRODUTO_RELATORIO
END
GO

CREATE PROCEDURE dbo.PR_PRODUTO_RELATORIO
(
	@idFornecedor INT = NULL,
	@idProduto INT = NULL,
	@mes INT = NULL,
	@ano INT = NULL,
	@vendido bit = NULL
)
AS
	DECLARE @QtdProdutos INT = NULL
	DECLARE @QtdProdutosVendidos INT = NULL
	DECLARE @ValorCompraProdutosNaoVendidos DECIMAL(16,2) = NULL
	DECLARE @ValorVendaProdutosNaoVendidos DECIMAL(16,2) = NULL

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

	SELECT @ValorCompraProdutosNaoVendidos = (
		SELECT 
			SUM(prd.valorcompra)
		FROM 
			produto prd
		WHERE
			prd.ativo = 1
			AND NOT EXISTS (Select 1 from venda v where v.idproduto = prd.id and v.ativo = 1))

	SELECT @ValorVendaProdutosNaoVendidos = (
		SELECT 
			SUM(prd.valorvenda)
		FROM 
			produto prd
		WHERE
			prd.ativo = 1
			AND NOT EXISTS (Select 1 from venda v where v.idproduto = prd.id and v.ativo = 1))

	SELECT 
		f.nome as nomefornecedor,
		p.codigo + '-' + p.nome as nomeproduto,
		p.dtcompra,
		p.valorcompra,
		p.valorvenda,
		CASE DATEPART(MONTH, p.dtcompra)
         WHEN 1 THEN 'Janeiro' + '/' + CONVERT(varchar(10), DATEPART(YEAR, p.dtcompra))
         WHEN 2 THEN 'Fevereiro' + '/' + CONVERT(varchar(10), DATEPART(YEAR, p.dtcompra))
         WHEN 3 THEN 'Março' + '/' + CONVERT(varchar(10), DATEPART(YEAR, p.dtcompra))
         WHEN 4 THEN 'Abril' + '/' + CONVERT(varchar(10), DATEPART(YEAR, p.dtcompra))
         WHEN 5 THEN 'Maio' + '/' + CONVERT(varchar(10), DATEPART(YEAR, p.dtcompra))
         WHEN 6 THEN 'Junho' + '/' + CONVERT(varchar(10), DATEPART(YEAR, p.dtcompra))
         WHEN 7 THEN 'Julho' + '/' + CONVERT(varchar(10), DATEPART(YEAR, p.dtcompra))
         WHEN 8 THEN 'Agosto' + '/' + CONVERT(varchar(10), DATEPART(YEAR, p.dtcompra))
         WHEN 9 THEN 'Setembro' + '/' + CONVERT(varchar(10), DATEPART(YEAR, p.dtcompra))
         WHEN 10 THEN 'Outubro' + '/' + CONVERT(varchar(10), DATEPART(YEAR, p.dtcompra))
         WHEN 11 THEN 'Novembro' + '/' + CONVERT(varchar(10), DATEPART(YEAR, p.dtcompra))
         WHEN 12 THEN 'Dezembro' + '/' + CONVERT(varchar(10), DATEPART(YEAR, p.dtcompra))
       END AS mes,
	   CONVERT(varchar(10), DATEPART(MONTH, p.dtcompra)) + CONVERT(varchar(10), DATEPART(YEAR, p.dtcompra)) as ordem,
	   p.idtipoproduto,
	   tp.nome as tipoproduto,
	   @QtdProdutos as quantidadeprodutos,
	   @QtdProdutosVendidos as quantidadeprodutosvendidos,
	   @QtdProdutos - @QtdProdutosVendidos as quantidadeprodutosnaovenddos,
	   (CASE WHEN EXISTS (Select 1 from venda v where v.idproduto = p.id and v.ativo = 1) 
      THEN 'S' ELSE 'N' END) vendido,
	  @ValorCompraProdutosNaoVendidos as valorcompraprodutosnaovendidos,
	  @ValorVendaProdutosNaoVendidos as valorvendaprodutosnaovendidos
	FROM
		produto p 
		INNER JOIN tipoproduto tp ON tp.id = p.idtipoproduto
		INNER JOIN fornecedor f ON f.id = p.idfornecedor
	WHERE
		p.ativo = 1
		AND (f.id = @idFornecedor OR @idFornecedor IS NULL)
		AND (p.id = @idProduto OR @idProduto IS NULL)
		AND (DATEPART(MONTH, p.dtcompra) = @mes OR @mes IS NULL)
		AND (DATEPART(YEAR, p.dtcompra) = @ano OR @ano IS NULL)
		AND ((CASE WHEN EXISTS (Select 1 from venda v where v.idproduto = p.id and v.ativo = 1) 
      THEN 1 ELSE 0 END) = @vendido or @vendido is null) 
GO