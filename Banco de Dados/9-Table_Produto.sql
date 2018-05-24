 use BertoniAcessorios

 IF NOT EXISTS(SELECT 1 FROM sys.Tables WHERE  Name = N'produto' AND Type = N'U')
 BEGIN
      CREATE TABLE produto
	  (
		 id int IDENTITY(1,1) NOT NULL,
         nome varchar(200) NOT NULL,
		 codigo varchar(10) NOT NULL,
		 idtipoproduto int not null,
		 idfornecedor int not null,
		 valorcompra decimal(16, 2) not null,
		 valorvenda decimal(16, 2) not null,
		 ativo bit not null,
		 dtcompra  datetime not null,
         dtinclusao datetime not null,
		 dtalteracao datetime null,
	   CONSTRAINT [PK_Produto] PRIMARY KEY CLUSTERED 
	(
		[id] ASC
	)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
	) ON [PRIMARY]
 END

IF NOT EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS WHERE CONSTRAINT_NAME ='FK_TipoProduto_Produto')
BEGIN
	ALTER TABLE produto
	ADD CONSTRAINT FK_TipoProduto_Produto
	FOREIGN KEY (idtipoproduto) REFERENCES tipoproduto(id);
END

IF NOT EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS WHERE CONSTRAINT_NAME ='FK_Fornecedor_Produto')
BEGIN
	ALTER TABLE produto
	ADD CONSTRAINT FK_Fornecedor_Produto
	FOREIGN KEY (idfornecedor) REFERENCES fornecedor(id);
END