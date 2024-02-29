create database querobar;
use querobar;

create table pes_pessoas(
pes_codigo int primary key auto_increment,
pes_nome varchar(45) not null,
pes_nascimento date not null
);

create table alu_alunos(
alu_ra int primary key,
alu_datavest date not null,
pes_codigo int not null auto_increment,
foreign key(pes_codigo) references pes_pessoas(pes_codigo)
);

create table usu_usuario(
usu_email varchar(45) primary key,
usu_senha varchar(500) not null,
usu_dataadd date not null,
pes_codigo int not null auto_increment,
foreign key(pes_codigo) references pes_pessoas(pes_codigo)
);

insert into pes_pessoas values
(0, 'Admin', '2022-10-02'),
(0, 'Aluno A', '2018-04-22');

insert into alu_alunos values
(123456, '2022-10-25', 2);

insert into usu_usuario values
('admin@gmail.com', 'TmllUW1pbkRFNEdnY2V3bjk4bktsM0poZ3E3U21uM2RMbFExTXlMUHN3cTduanB0OHF3c0lQNGpRMk1SMW5oV1RReU5NRmt3VjE5ZzR0UFFTQmhOZVE9PQ==', '2023-04-25', 1),
('alunoA@gmail.com', '123', '2023-05-10', 2);

select alu_ra, pes_nome, usu_email, usu_dataadd from pes_pessoas pes
inner join usu_usuario usu on usu.pes_codigo = pes.pes_codigo
inner join alu_alunos alu on alu.pes_codigo = usu.pes_codigo;

select * from pes_pessoas;