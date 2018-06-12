USE BertoniAcessorios
GO

IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'PR_DESPESA_SALVAR')
BEGIN
    DROP Procedure PR_DESPESA_SALVAR
END
GO

CREATE PROCEDURE dbo.PR_DESPESA_SALVAR 
(
	@Id int = null,
	@IdTipoDespesa int,
	@Valor decimal(16,2),
	@DtDespesa datetime
)
AS

IF (@Id is null)
BEGIN
	INSERT INTO dbo.despesa
	(
		idtipodespesa,
		valor,
		ativo,
		dtdespesa,
		dtinclusao
	) 
	VALUES
	(
		@IdTipoDespesa,
		@Valor,
		1,
		@DtDespesa,
		Getdate()
	)

	SELECT SCOPE_IDENTITY();
END
ELSE
BEGIN
	UPDATE dbo.despesa
	set idtipodespesa = @IdTipoDespesa,
	valor = @Valor,
	dtdespesa = @DtDespesa,
	dtalteracao = Getdate()
	where id = @Id

	Select @Id
END

GO