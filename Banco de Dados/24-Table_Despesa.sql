 use BertoniAcessorios

 IF NOT EXISTS(SELECT 1 FROM sys.Tables WHERE  Name = N'despesa' AND Type = N'U')
 BEGIN
      CREATE TABLE despesa
	  (
		 id int IDENTITY(1,1) NOT NULL,
		 idtipodespesa int not null,
		 valor decimal(16, 2) not null,
		 ativo bit not null,
		 dtdespesa  datetime not null,
         dtinclusao datetime not null,
		 dtalteracao datetime null,
	   CONSTRAINT [PK_Despesa] PRIMARY KEY CLUSTERED 
	(
		[id] ASC
	)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
	) ON [PRIMARY]
 END

IF NOT EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS WHERE CONSTRAINT_NAME ='FK_TipoDespesa_Despesa')
BEGIN
	ALTER TABLE despesa
	ADD CONSTRAINT FK_TipoDespesa_Despesa
	FOREIGN KEY (idtipodespesa) REFERENCES tipodespesa(id);
END
