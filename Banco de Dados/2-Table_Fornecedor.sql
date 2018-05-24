 use BertoniAcessorios
 
 IF NOT EXISTS(SELECT 1 FROM sys.Tables WHERE  Name = N'fornecedor' AND Type = N'U')
 BEGIN
      CREATE TABLE fornecedor
	  (
		 id int IDENTITY(1,1) NOT NULL,
         nome varchar(200) NOT NULL,
         descricao varchar(500) NOT NULL,
		 codigo varchar(10) not null,
         dtinclusao datetime not null,
		 dtalteracao datetime null,
	   CONSTRAINT [PK_History] PRIMARY KEY CLUSTERED 
	(
		[id] ASC
	)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
	) ON [PRIMARY]
 END

IF NOT EXISTS(SELECT 1 FROM sys.columns 
          WHERE Name = N'ativo'
          AND Object_ID = Object_ID(N'dbo.fornecedor'))
BEGIN
    ALTER TABLE fornecedor
	ADD ativo bit not null
END