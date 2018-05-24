 use BertoniAcessorios

 IF NOT EXISTS (Select 1 from tipoproduto where sigla = 'AN') 
 BEGIN
 INSERT INTO tipoproduto
 (
	nome,
	sigla,
	dtinclusao
 )
values
(
	'Anel',
	'AN',
	GETDATE()
)
END
 IF NOT EXISTS (Select 1 from tipoproduto where sigla = 'BR') 
 BEGIN
 INSERT INTO tipoproduto
 (
	nome,
	sigla,
	dtinclusao
 )
values
(
	'Brinco',
	'BR',
	GETDATE()
)
END
 IF NOT EXISTS (Select 1 from tipoproduto where sigla = 'CL') 
 BEGIN
 INSERT INTO tipoproduto
 (
	nome,
	sigla,
	dtinclusao
 )
values
(
	'Colar',
	'CL',
	GETDATE()
)
END
 IF NOT EXISTS (Select 1 from tipoproduto where sigla = 'PS') 
 BEGIN
 INSERT INTO tipoproduto
 (
	nome,
	sigla,
	dtinclusao
 )
values
(
	'Pulseira',
	'PS',
	GETDATE()
)
END