 use BertoniAcessorios

 IF NOT EXISTS (Select 1 from tipodespesa where nome = 'Ped�gio') 
 BEGIN
 INSERT INTO tipodespesa
 (
	nome,
	ativo,
	dtinclusao
 )
values
(
	'Ped�gio',
	1,
	GETDATE()
)
END
 IF NOT EXISTS (Select 1 from tipodespesa where nome = 'Gasolina') 
 BEGIN
 INSERT INTO tipodespesa
 (
	nome,
	ativo,
	dtinclusao
 )
values
(
	'Gasolina',
	1,
	GETDATE()
)
END
 IF NOT EXISTS (Select 1 from tipodespesa where nome = 'Maleta') 
 BEGIN
 INSERT INTO tipodespesa
 (
	nome,
	ativo,
	dtinclusao
 )
values
(
	'Maleta',
	1,
	GETDATE()
)
END
 IF NOT EXISTS (Select 1 from tipodespesa where nome = 'Cord�o de encaixe') 
 BEGIN
 INSERT INTO tipodespesa
 (
	nome,
	ativo,
	dtinclusao
 )
values
(
	'Cord�o de encaixe',
	1,
	GETDATE()
)
END
 IF NOT EXISTS (Select 1 from tipodespesa where nome = 'Etiqueta de pre�o') 
 BEGIN
 INSERT INTO tipodespesa
 (
	nome,
	ativo,
	dtinclusao
 )
values
(
	'Etiqueta de pre�o',
	1,
	GETDATE()
)
END
 IF NOT EXISTS (Select 1 from tipodespesa where nome = 'Etiqueta de logo') 
 BEGIN
 INSERT INTO tipodespesa
 (
	nome,
	ativo,
	dtinclusao
 )
values
(
	'Etiqueta de logo',
	1,
	GETDATE()
)
END
 IF NOT EXISTS (Select 1 from tipodespesa where nome = 'Medidor de Anel') 
 BEGIN
 INSERT INTO tipodespesa
 (
	nome,
	ativo,
	dtinclusao
 )
values
(
	'Medidor de Anel',
	1,
	GETDATE()
)
END
 IF NOT EXISTS (Select 1 from tipodespesa where nome = 'Flanela') 
 BEGIN
 INSERT INTO tipodespesa
 (
	nome,
	ativo,
	dtinclusao
 )
values
(
	'Flanela',
	1,
	GETDATE()
)
END
 IF NOT EXISTS (Select 1 from tipodespesa where nome = 'Embalagem') 
 BEGIN
 INSERT INTO tipodespesa
 (
	nome,
	ativo,
	dtinclusao
 )
values
(
	'Embalagem',
	1,
	GETDATE()
)
END