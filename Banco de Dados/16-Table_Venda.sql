 use BertoniAcessorios
 
 IF NOT EXISTS(SELECT 1 FROM sys.Tables WHERE  Name = N'venda' AND Type = N'U')
 BEGIN
      CREATE TABLE venda
	  (
		 id int IDENTITY(1,1) NOT NULL,
         idvendedor int NOT NULL,
		 idproduto int NOT NULL,
		 valorvenda decimal(16,2) NOT NULL,
		 valorcomissao decimal(16,2) NOT NULL,
		 ativo bit NOT NULL,
         dtinclusao datetime not null,
		 dtalteracao datetime null
	   CONSTRAINT [PK_Venda] PRIMARY KEY CLUSTERED 
	(
		[id] ASC
	)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
	) ON [PRIMARY]
 END
 
IF NOT EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS WHERE CONSTRAINT_NAME ='FK_Produto_Venda')
BEGIN
	ALTER TABLE venda
	ADD CONSTRAINT FK_Produto_Venda
	FOREIGN KEY (idproduto) REFERENCES produto(id);
END

IF NOT EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS WHERE CONSTRAINT_NAME ='FK_Vendedor_Venda')
BEGIN
	ALTER TABLE venda
	ADD CONSTRAINT FK_Vendedor_Venda
	FOREIGN KEY (idvendedor) REFERENCES vendedor(id);
END
