 use BertoniAcessorios
 
 IF NOT EXISTS(SELECT 1 FROM sys.Tables WHERE  Name = N'tipodespesa' AND Type = N'U')
 BEGIN
      CREATE TABLE tipodespesa
	  (
		 id int IDENTITY(1,1) NOT NULL,
         nome varchar(200) NOT NULL,
		 ativo bit not null,
         dtinclusao datetime not null,
		 dtalteracao datetime null,
	   CONSTRAINT [PK_TipoDespesa] PRIMARY KEY CLUSTERED 
	(
		[id] ASC
	)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
	) ON [PRIMARY]
 END