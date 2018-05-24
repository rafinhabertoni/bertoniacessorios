USE master ;  
GO  
CREATE DATABASE BertoniAcessorios  
ON   
( NAME = BertoniAcessorios_dat,  
    FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\bertoniacessoriosdat.mdf',  
    SIZE = 10,  
    MAXSIZE = 50,  
    FILEGROWTH = 5 )  
LOG ON  
( NAME = BertoniAcessorios_log,  
    FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\bertoniacessorioslog.ldf',  
    SIZE = 5MB,  
    MAXSIZE = 25MB,  
    FILEGROWTH = 5MB ) ;  
GO  