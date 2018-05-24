 use BertoniAcessorios

 IF NOT EXISTS (Select 1 from vendedor where nome = 'Elaine') 
 BEGIN
 INSERT INTO vendedor
 (
	nome,
	porcentagem,
	ativo,
	dtinclusao
 )
values
(
	'Elaine',
	0,
	1,
	GETDATE()
)
END
 IF NOT EXISTS (Select 1 from vendedor where nome = 'Naira') 
 BEGIN
 INSERT INTO vendedor
 (
	nome,
	porcentagem,
	ativo,
	dtinclusao
 )
values
(
	'Naira',
	40,
	1,
	GETDATE()
)
END
IF NOT EXISTS (Select 1 from vendedor where nome = 'Marister') 
 BEGIN
 INSERT INTO vendedor
 (
	nome,
	porcentagem,
	ativo,
	dtinclusao
 )
values
(
	'Marister',
	30,
	1,
	GETDATE()
)
END
IF NOT EXISTS (Select 1 from vendedor where nome = 'Larissa') 
 BEGIN
 INSERT INTO vendedor
 (
	nome,
	porcentagem,
	ativo,
	dtinclusao
 )
values
(
	'Larissa',
	30,
	1,
	GETDATE()
)
END
IF NOT EXISTS (Select 1 from vendedor where nome = 'Daniela') 
 BEGIN
 INSERT INTO vendedor
 (
	nome,
	porcentagem,
	ativo,
	dtinclusao
 )
values
(
	'Daniela',
	30,
	1,
	GETDATE()
)
END