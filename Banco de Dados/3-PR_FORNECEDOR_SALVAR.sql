USE BertoniAcessorios
GO

IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'PR_FORNECEDOR_SALVAR')
BEGIN
    DROP Procedure PR_FORNECEDOR_SALVAR
END
GO

CREATE PROCEDURE dbo.PR_FORNECEDOR_SALVAR 
(
	@Id int = null,
	@Nome varchar(200), 
	@Descricao varchar(500),
	@Codigo varchar(10)
)
AS

IF (@Id is null)
BEGIN
	INSERT INTO dbo.fornecedor
	(
		nome,
		descricao,
		codigo,
		dtinclusao,
		ativo
	) 
	VALUES
	(
		@Nome,
		@Descricao,
		@Codigo,
		Getdate(),
		1
	)

	SELECT SCOPE_IDENTITY();
END
ELSE
BEGIN
	UPDATE dbo.fornecedor
	set nome = @Nome,
	descricao = @Descricao,
	codigo = @Codigo,
	dtalteracao = Getdate()
	where id = @Id

	Select @Id
END

GO