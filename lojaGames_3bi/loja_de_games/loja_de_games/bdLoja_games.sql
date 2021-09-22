create database loja_games;
use loja_games;

describe jogo;
create table cliente(
	NomeCli varchar(150) not null,
    CPFCli varchar(15) primary key,
    Email varchar(150) not null,
    Celular int not null,
    Cidade varchar(150) not null,
    Estado varchar(150) not null,
    Logradouro varchar(150) not null,
    DataNascimento datetime not null
);

create table funcionario(
	CodigoFunc int primary key,
    NomeFunc varchar(150) not null,
    CPF_Func varchar(15) not null,
    RGFunc varchar(15) not null,
    Email varchar (150) not null,
	Celular int not null,
    Cidade varchar(150) not null,
    Estado varchar(150) not null,
    Logradouro varchar(150) not null,
    Cargo varchar(60) not null,
    DataNascimento datetime not null
);

create table jogo(
	CodigoJogo int primary key,
    NomeJogo varchar(150) not null,
    Versao varchar(10) not null,
    Desenvolvedor varchar(60) not null,
    Genero varchar(150) not null,
    FaixaEtaria int null,
    Plataforma varchar(100) not null,
    Sinopse varchar(250) not null,
    AnoLancamento int not null
);