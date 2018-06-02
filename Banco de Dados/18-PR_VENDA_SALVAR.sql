USE BertoniAcessorios
GO

IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'PR_VENDA_SALVAR')
BEGIN
    DROP Procedure PR_VENDA_SALVAR
END
GO

CREATE PROCEDURE dbo.PR_VENDA_SALVAR 
(
	@Id int = null,
	@IdVendedor int,
	@IdProduto int,
	@ValorVenda decimal(16,2),
	@ValorComissao decimal(16,2),
	@DataVenda datetime
)
AS

IF (@Id is null)
BEGIN
	INSERT INTO dbo.venda
	(
		idvendedor,
		idproduto,
		valorvenda,
		valorcomissao,
		ativo,
		dtinclusao,
		dtvenda
	) 
	VALUES
	(
		@IdVendedor,
		@IdProduto,
		@ValorVenda,
		@ValorComissao,
		1,
		Getdate(),
		@DataVenda
	)

	SELECT SCOPE_IDENTITY();
END
ELSE
BEGIN
	UPDATE dbo.venda
	set idvendedor = @IdVendedor,
	idproduto = @IdProduto,
	valorvenda = @ValorVenda,
	valorcomissao = @ValorComissao,
	dtalteracao = Getdate(),
	dtvenda = @DataVenda
	where id = @Id

	Select @Id
END

GO