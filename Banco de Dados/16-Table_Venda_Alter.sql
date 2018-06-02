 use BertoniAcessorios
 
IF NOT EXISTS(SELECT 1 FROM sys.columns 
          WHERE Name = N'dtvenda'
          AND Object_ID = Object_ID(N'venda'))
BEGIN
    ALTER TABLE VENDA
	ADD dtvenda datetime NULL
	
	UPDATE venda
	set dtvenda = dtinclusao
	
	ALTER TABLE VENDA
	ALTER COLUMN dtvenda datetime not null
END
