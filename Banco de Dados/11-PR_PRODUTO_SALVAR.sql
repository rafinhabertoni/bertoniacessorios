USE BertoniAcessorios
GO

IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'PR_PRODUTO_SALVAR')
BEGIN
    DROP Procedure PR_PRODUTO_SALVAR
END
GO

CREATE PROCEDURE dbo.PR_PRODUTO_SALVAR 
(
	@Id int = null,
	@Nome varchar(200), 
	@Codigo varchar(10),
	@IdTipoProduto int,
	@IdFornecedor int,
	@ValorCompra decimal(16,2),
	@ValorVenda decimal(16,2),
	@DtCompra datetime
)
AS

IF (@Id is null)
BEGIN
	INSERT INTO dbo.produto
	(
		nome,
		codigo,
		idtipoproduto,
		idfornecedor,
		valorcompra,
		valorvenda,
		ativo,
		dtcompra,
		dtinclusao
	) 
	VALUES
	(
		@Nome,
		@Codigo,
		@IdTipoProduto,
		@IdFornecedor,
		@ValorCompra,
		@ValorVenda,
		1,
		@DtCompra,
		Getdate()
	)

	SELECT SCOPE_IDENTITY();
END
ELSE
BEGIN
	UPDATE dbo.produto
	set nome = @Nome,
	codigo = @Codigo,
	idtipoproduto = @IdTipoProduto,
	idfornecedor = @IdFornecedor,
	valorcompra = @ValorCompra,
	valorvenda = @ValorVenda,
	dtcompra = @DtCompra,
	dtalteracao = Getdate()
	where id = @Id

	Select @Id
END

GO