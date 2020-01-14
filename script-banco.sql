create database locadora_ds;
use locadora_ds;
create table tb_funcionario
(
	tb_funcionario_id integer not null primary key auto_increment,
	tb_funcionario_nome varchar(64) not null, 
	tb_funcionario_tel varchar(16),
	tb_funcionario_dt_contrato datetime not null
)engine=InnoDB default charset=UTF8;

create table tb_locacao(
tb_locacao_id integer not null primary key auto_increment,
tb_locacao_tipo varchar(32) not null,
tb_locacao_valor double(10,2) not null,
tb_locacao_dt_inicio datetime,
tb_locacao_dt_fim datetime
)engine=InnoDB default charset=UTF8;

create table tb_cliente
(
	tb_cliente_id integer not null primary key auto_increment,
	tb_cliente_nome varchar(128) not null,
	tb_cliente_tel varchar(16) not null,
	tb_cliente_sexo varchar(16),
	tb_cliente_email varchar(32),
	tb_cliente_endereco varchar(64),
	tb_cliente_complemento varchar(32),
	tb_cliente_bairro varchar(64) not null,
	tb_cliente_cidade varchar(64) not null,
	tb_cliente_uf char(2) not null,
	tb_cliente_dt_nasc datetime not null,
	tb_cliente_dt_cad datetime not null
)engine=InnoDB default charset=UTF8;

create table tb_automovel (
tb_automovel_id integer not null primary key auto_increment,
tb_automovel_nome varchar(32) not null,
tb_automovel_ano_fab varchar(5),
tb_automovel_cor varchar(32) not null, 
tb_automovel_km decimal(10,2) default null,
tb_automovel_valor_d decimal(10,2),
tb_automovel_status varchar(16)

)engine=InnoDB default charset=UTF8;

create table tb_cargo
(
	tb_cargo_id integer not null primary key auto_increment,
	tb_cargo_nome varchar(64) not null
)engine=InnoDB default charset=UTF8;

create table tb_marca 
(
	tb_marca_id integer not null primary key auto_increment,
	tb_marca_nome varchar(32) not null
)engine=InnoDB default charset=UTF8;

create table tb_modelo 
(
	tb_modelo_id integer not null primary key auto_increment,
	tb_modelo_desc varchar(32) not null
)engine=InnoDB default charset=UTF8;

alter table tb_automovel add (tb_marca_id integer not null );
alter table tb_automovel add (tb_modelo_id integer not null );

alter table tb_funcionario add tb_cargo_id integer not null;
alter table tb_locacao add (tb_cliente_id integer not null, tb_funcionario_id integer not null, tb_automovel_id integer not null);

alter table tb_automovel add constraint FK_AUTOMOVEL_PK_MARCA foreign key(tb_marca_id) references tb_marca(tb_marca_id);
alter table tb_automovel add constraint FK_AUTOMOVEL_PK_MODELO foreign key(tb_modelo_id) references tb_modelo(tb_modelo_id);
alter table tb_funcionario add constraint FK_FUNCIONARIO_PK_CARGO foreign key(tb_cargo_id) references tb_cargo(tb_cargo_id);

alter table tb_locacao
add constraint FK_LOCACAO_PK_CLIENTE
foreign key (tb_cliente_id)
references tb_cliente(tb_cliente_id);

alter table tb_locacao
add constraint FK_LOCACAO_PK_FUNCIONARIO
foreign key (tb_funcionario_id)
references tb_funcionario(tb_funcionario_id)
;

alter table tb_locacao
add constraint FK_LOCACAO_PK_AUTOMOVEL
foreign key (tb_automovel_id)
references tb_automovel(tb_automovel_id)
;

insert into tb_marca(tb_marca_nome)value('LIFAN');

insert into tb_marca(tb_marca_nome)value('HONDA');

insert into tb_marca (tb_marca_nome)value('FIAT');

insert into tb_marca (tb_marca_nome)value('FORD');

insert into tb_marca (tb_marca_nome)value('CHEVROLET');

insert into tb_marca (tb_marca_nome) value ('JEEP');

insert into tb_marca (tb_marca_nome) value ('VOLKSWAGEM');

insert into tb_marca (tb_marca_nome) value ('KIA');

insert into tb_marca (tb_marca_nome) value ('MITSUBISHI');

insert into tb_marca (tb_marca_nome) value ('HYUNDAI');

insert into tb_marca (tb_marca_nome) value ('BMW');

insert into tb_marca (tb_marca_nome) value ('RENAULT');

insert into tb_marca (tb_marca_nome) value ('TOYOTA');

insert into tb_marca (tb_marca_nome) value ('AUDI');

insert into tb_marca (tb_marca_nome) value ('BUGATTI');

insert into tb_marca (tb_marca_nome) value ('FERRARI');

insert into tb_marca (tb_marca_nome) value ('SUBARU');

insert into tb_marca (tb_marca_nome) value ('ASTON MARTIN');

insert into tb_marca (tb_marca_nome) value ('PORCHE');

/*TABELA CARGO*/
/*insert into tb_cargo (tb_cargo_nome) value ('Novo cargo');*/
insert into tb_cargo (tb_cargo_nome) value ('LAVADOR');
insert into tb_cargo (tb_cargo_nome) value ('LOCADOR');
insert into tb_cargo (tb_cargo_nome) value ('MECANICO');
insert into tb_cargo (tb_cargo_nome) value ('MANOBRISTA');
insert into tb_cargo (tb_cargo_nome) value ('GERENTE');

/* tabela funcionario */ 

insert into tb_funcionario (tb_funcionario_nome, tb_funcionario_tel, tb_funcionario_dt_contrato, tb_cargo_id) value ('JOSÉ BENEDITO', '11 94553838', '2010-12-20', 5);
insert into tb_funcionario (tb_funcionario_nome, tb_funcionario_tel, tb_funcionario_dt_contrato, tb_cargo_id) value ('ANTONIO ', '12 3943939', '2011-01-05', 2);
insert into tb_funcionario (tb_funcionario_nome, tb_funcionario_tel, tb_funcionario_dt_contrato, tb_cargo_id) value ('LUIZA DA SILVA', '11 93423445', '2011-01-05', 2);


/*tabela modelo */
/*insert into tb_modelo (tb_modelo_desc) value ('Novo modelo');*/
insert into tb_modelo (tb_modelo_desc) value ('RACING');
insert into tb_modelo (tb_modelo_desc) value ('SEDAN');
insert into tb_modelo (tb_modelo_desc) value ('PICKUP');
insert into tb_modelo (tb_modelo_desc) value ('UTILITÁRIO');
insert into tb_modelo (tb_modelo_desc) value ('WAGON');
insert into tb_modelo (tb_modelo_desc) value ('HATCH');
insert into tb_modelo (tb_modelo_desc) value ('COUPÊ');
insert into tb_modelo (tb_modelo_desc) value ('SUV');
insert into tb_modelo (tb_modelo_desc) value ('OFF ROAD');

/*TABELA AUTOMOVEL */

insert into tb_automovel (tb_automovel_nome, tb_automovel_ano_fab, tb_automovel_cor, tb_automovel_km, tb_automovel_valor_d, tb_automovel_status, tb_marca_id, tb_modelo_id) value ('CIVIC EXS','2010','PRETO','60000','550','DISPONÍVEL',2,2);
insert into tb_automovel (tb_automovel_nome, tb_automovel_ano_fab, tb_automovel_cor, tb_automovel_km, tb_automovel_valor_d, tb_automovel_status, tb_marca_id, tb_modelo_id) value ('GOL MI','2000','PRETO','75000','100','DISPONÍVEL',7,6);
insert into tb_automovel (tb_automovel_nome, tb_automovel_ano_fab, tb_automovel_cor, tb_automovel_km, tb_automovel_valor_d, tb_automovel_status, tb_marca_id, tb_modelo_id) value ('LANCER','2014','VERMELHO','23000','160','DISPONÍVEL',9,2);


/* tabela cliente */
/*insert into tb_cliente(tb_cliente_nome, tb_cliente_tel, tb_cliente_sexo, tb_cliente_email,  tb_cliente_endereco, tb_cliente_complemento, tb_cliente_bairro, tb_cliente_cidade, tb_cliente_uf, tb_cliente_dt_nasc, tb_cliente_dt_cad)
value('Novo cliente', '0', '0', '0', '0', '0', '0', '0', '0', '0-0-0', '0-0-0');*/
insert into tb_cliente(tb_cliente_nome, tb_cliente_tel, tb_cliente_sexo, tb_cliente_email,  tb_cliente_endereco, tb_cliente_complemento, tb_cliente_bairro, tb_cliente_cidade, tb_cliente_uf, tb_cliente_dt_nasc, tb_cliente_dt_cad)
value('Antonio', '11 971551446', 'MASCULINO', 'Tonintop@HOTMAIL.COM', 'AV. DOUTOR ALVARIO RIBEIRO, 777', 'CASA 39', 'JARDIM DEGHI', 'SANTANA DE PARNAÍBA', 'SP', '1979-12-19', '2010-10-10');
insert into tb_cliente(tb_cliente_nome, tb_cliente_tel, tb_cliente_sexo, tb_cliente_email, tb_cliente_endereco, tb_cliente_complemento, tb_cliente_bairro, tb_cliente_cidade, tb_cliente_uf, tb_cliente_dt_nasc, tb_cliente_dt_cad)
value('SILDO MENEZES', '11 95443921', 'MASCULINO', 'SILDMSILDO@GMAIL.COM',  'RUA DAS CASAS, 324', '', 'PARQUE SANTANA', 'SANTANA DE PARNAIBA', 'SP', '185-10-10', '2010-10-10');
insert into tb_cliente(tb_cliente_nome, tb_cliente_tel, tb_cliente_sexo, tb_cliente_email, tb_cliente_endereco, tb_cliente_complemento, tb_cliente_bairro, tb_cliente_cidade, tb_cliente_uf, tb_cliente_dt_nasc, tb_cliente_dt_cad)
value('MARIA DAS GRAÇAS', '13 98453321', 'FEMININO', 'MARIA2000@HOTMAIL.COM', 'RUA FLORENCIA, 4566', 'CASA B', 'CARAVAGIO', 'SÃO ROQUE', 'SP', '2010-05-30', '2010-10-10');


/* TABELA locação*/
insert into tb_locacao (tb_locacao_tipo, tb_locacao_valor, tb_locacao_dt_inicio, tb_locacao_dt_fim, tb_cliente_id, tb_funcionario_id, tb_automovel_id ) value ('MENSAL', '5400.00', '2016-06-05', '2016-07-05',1,2,1);
insert into tb_locacao (tb_locacao_tipo, tb_locacao_valor, tb_locacao_dt_inicio, tb_locacao_dt_fim, tb_cliente_id, tb_funcionario_id, tb_automovel_id ) value ('SEMANAL', '910.00', '2016-06-05', '2016-06-12',3,3,3);
insert into tb_locacao (tb_locacao_tipo, tb_locacao_valor, tb_locacao_dt_inicio, tb_locacao_dt_fim, tb_cliente_id, tb_funcionario_id, tb_automovel_id ) value ('MENSAL', '3900.00', '2016-06-05', '2016-07-05',1,3,2);

/*PROCEDURES */

/* criando procedure CADASTRAR CLIENTE */
DELIMITER $$ 
CREATE PROCEDURE sp_cadastra_cliente
(in nome varchar(128),
 in telefone varchar(16),
 in sexo varchar(32),
 in email varchar(128),
 in endereco varchar(128),
 in complemento varchar(10),
 in bairro varchar(128),
 in cidade varchar(128),
 in uf varchar(8),
 in dt_nascimento datetime,
 in dt_cadastro datetime
)
BEGIN
insert into tb_cliente 
(tb_cliente_nome,
 tb_cliente_tel,
 tb_cliente_sexo,
 tb_cliente_email,
 tb_cliente_endereco, 
 TB_CLIENTE_COMPLEMENTO,
 TB_CLIENTE_BAIRRO,
 TB_CLIENTE_CIDADE,
 TB_CLIENTE_UF,
 TB_CLIENTE_DT_NASC,
 TB_CLIENTE_DT_CAD)
values (nome, telefone, sexo, email, endereco, complemento, bairro, cidade, uf, dt_nascimento, dt_cadastro);
END $$
DELIMITER ;

/* CADASTRO DE CARGO */
DELIMITER $$
CREATE PROCEDURE sp_cadastra_cargo(in nome_cargo varchar(64))
begin
insert into tb_cargo(tb_cargo_nome)
values(nome_cargo);
end $$
DELIMITER $$ ;

/* CADASTRO DE MARCA */
DELIMITER $$
CREATE PROCEDURE sp_cadastra_marca(in nome_marca varchar(64))
begin
insert into tb_marca(tb_marca_nome)
values(nome_marca);
end $$
DELIMITER $$ ;

/* CADASTRO DE MODELO */
DELIMITER $$
CREATE PROCEDURE sp_cadastra_modelo(in nome_modelo varchar(64))
begin
insert into tb_modelo(tb_modelo_desc)
values(nome_modelo);
end $$
DELIMITER $$ ;

/* CADASTRO LOCACAO */
DELIMITER $$
CREATE PROCEDURE sp_cadastra_locacao(in tipo varchar(64), in valor int, in dt_inicio datetime, in dt_fim datetime, in id_cliente int, in id_funcionario int, in id_auto int)
begin 
insert into tb_locacao(tb_locacao_tipo, tb_locacao_valor, tb_locacao_dt_inicio, tb_locacao_dt_fim, tb_cliente_id, tb_funcionario_id, tb_automovel_id)
values(tipo, valor, dt_inicio, dt_fim, id_cliente, id_funcionario, id_auto);
end $$
DELIMITER $$ ;


/* CADASTRO FUNCIONARIO */
DELIMITER $$
CREATE PROCEDURE sp_cadastra_funcionario(in nome varchar(128), in tel varchar(15), in dt_contrato datetime, in cargo int)
begin 
	insert into tb_funcionario(tb_funcionario_nome, tb_funcionario_tel, tb_funcionario_dt_contrato, tb_cargo_id)
	values( nome, tel, dt_contrato, cargo);
end $$
DELIMITER $$ ;

/* CADASTRO AUTOMOVEL */
DELIMITER $$
create procedure sp_cadastra_automovel(in nome varchar(64), in ano_fab varchar(5), in cor varchar(64), in km int, 
in valor int, in stat varchar(60), in marca int, in modelo int)
begin
insert into tb_automovel(tb_automovel_nome, tb_automovel_ano_fab, tb_automovel_cor, tb_automovel_km, tb_automovel_valor_d, tb_automovel_status, tb_marca_id, tb_modelo_id)
values (nome, ano_fab, cor, km, valor, stat, marca, modelo);
end $$
DELIMITER $$ ;
 

/* PROCEDURES DE DELETAR*/

/* DELETAR CLIENTE */
CREATE PROCEDURE sp_deleta_cliente
    (in nome varchar(128),
 in telefone varchar(16),
 in sexo varchar(32),
 in email varchar(128),
 in endereco varchar(128),
 in complemento varchar(10),
 in bairro varchar(128),
 in cidade varchar(128),
 in uf varchar(8),
 in data_nascimento datetime,
 in data_cadastro datetime)
begin
delete from tb_cliente where tb_cliente_id = @clienteid ;
end $$
DELIMITER ;


/* DELETAR CARGO */
DELIMITER $$
CREATE PROCEDURE sp_deleta_cargo(in id int)
begin
delete from tb_cargo where tb_cargo_id = id ;
end $$
DELIMITER ;

/* DELETAR MARCA */
DELIMITER $$
CREATE PROCEDURE sp_deleta_marca(in marcaid varchar(64))
begin
delete from tb_marca where tb_marca_id = marcaid ;
end $$
DELIMITER ;

/* DELETAR MODELO */
DELIMITER $$
CREATE PROCEDURE sp_deleta_modelo(in id int)
begin
delete from tb_modelo where tb_modelo_id = id ;
end $$
DELIMITER ;
/* DELETAR LOCACAO */

/* DELETAR FUNCIONARIO */
DELIMITER $$
CREATE PROCEDURE sp_deleta_funcionario(in funcionario_id int)
begin 
delete from tb_funcionario where tb_funcionario_id = funcionario_id;
end $$
DELIMITER ;

/* DELETAR AUTOMOVEL */
DELIMITER $$
CREATE PROCEDURE sp_deleta_automovel(in id int)
begin 
delete from tb_automovel where tb_automovel_id = id ;
end $$
DELIMITER ;

/* PROCEDURES DE ALTERAR*/
DELIMITER $$
create procedure sp_altera_marca(in id_marca int, in nome varchar(32) )
begin
update tb_marca set tb_marca_nome = nome where tb_marca_id = id_marca ;
end $$
DELIMITER ;


DELIMITER $$
create procedure sp_altera_modelo(in id_modelo int, in mod_desc varchar(32))
begin
update tb_modelo set tb_modelo_desc = mod_desc where tb_modelo_id = id_modelo;
end $$
DELIMITER ;

DELIMITER $$
create procedure sp_altera_cargo(in id int, in nome varchar(11))
begin
update tb_cargo set tb_cargo_nome = nome where tb_cargo_id = id;
end$$
DELIMITER $$

DELIMITER $$
create procedure sp_altera_funcionario(	in funcionario_id integer,	in nome varchar(64), in tel varchar(16),in dt_contrato datetime, in cargo integer)
begin
update tb_funcionario set
	tb_funcionario_nome = nome,
	tb_funcionario_tel = tel,
	tb_funcionario_dt_contrato = dt_contrato,
    tb_cargo_id = cargo where tb_funcionario_id = funcionario_id;

end$$
DELIMITER ;

DELIMITER $$
create procedure sp_altera_automovel(in id integer, in nome varchar(64), in ano_fab varchar(5), in cor varchar(64), in km int, 
in valor int, in stat varchar(60), in marca int, in modelo int)
begin
update tb_automovel set
	tb_automovel_nome = nome,
	tb_automovel_ano_fab = ano_fab,
	tb_automovel_cor= cor,
    tb_automovel_km = km,
    tb_automovel_valor_d = valor,
    tb_automovel_status = stat,
    tb_marca_id = marca,
    tb_modelo_id = modelo
    where tb_automovel_id = id;

end$$
DELIMITER ;

/* PROCEDURES DE VISUALISAR*/
DELIMITER $$
create procedure sp_mostra_funcionario()
begin 
select tb_funcionario_id as 'ID',tb_funcionario_nome as 'Nome', tb_funcionario_tel as 'Telefone', tb_funcionario_dt_contrato as 'Data de contrato', tb_cargo_nome as 'Cargo' from tb_funcionario
inner join tb_cargo
on tb_funcionario.tb_cargo_id=tb_cargo.tb_cargo_id ; 
end $$
DELIMITER ;

DELIMITER $$
create procedure sp_mostra_locacao()
begin
select tb_locacao_id as 'ID', tb_locacao_tipo as 'Tipo', tb_locacao_valor as 'Valor',
tb_locacao_dt_inicio 'Data de início', tb_locacao_dt_fim as 'Data Final', tb_cliente_nome as 'Cliente',
tb_funcionario_nome as 'Funcionário', tb_automovel_nome as 'Automovel'
from tb_locacao
inner join tb_cliente
on tb_locacao.tb_cliente_id = tb_cliente.tb_cliente_id
inner join tb_funcionario
on tb_locacao.tb_funcionario_id = tb_funcionario.tb_funcionario_id
inner join tb_automovel
on tb_locacao.tb_automovel_id = tb_automovel.tb_automovel_id;
end $$
DELIMITER $$

DELIMITER $$
create procedure sp_mostra_auto()
begin
select tb_automovel_id as 'ID', tb_automovel_nome as 'Veiculo', tb_automovel_ano_fab as 'Ano de Fabricação', tb_automovel_cor as 'Cor',
tb_automovel_km as 'Quilometragem', tb_automovel_valor_d as 'Valor da diária', tb_automovel_status as 'Status', tb_marca_nome as 'Marca',
tb_modelo_desc as 'Modelo' from tb_automovel
inner join tb_marca
on tb_automovel.tb_marca_id = tb_marca.tb_marca_id
inner join tb_modelo
on tb_automovel.tb_modelo_id = tb_modelo.tb_modelo_id;
end $$
DELIMITER ;

DELIMITER $$
create procedure sp_deleta_locacao(in id integer)
BEGIN
delete from tb_locacao where tb_locacao_id = id;
END $$
DELIMITER ;

DELIMITER $$
create procedure sp_mostra_cliente()
begin 
select tb_cliente_id as 'ID', tb_cliente_nome as 'Nome', tb_cliente_tel as 'Telefone', tb_cliente_sexo as 'Sexo', tb_cliente_email as 'Email', tb_cliente_endereco as 'Endereco',
tb_cliente_complemento as 'Complemento', tb_cliente_bairro as 'Bairro', tb_cliente_cidade as 'Cidade', tb_cliente_uf 'UF', tb_cliente_dt_nasc as 'Data de nascimento',
tb_cliente_dt_cad as 'Data de cadastro' from tb_cliente
;

end $$
DELIMITER ;

DELIMITER $$
create procedure sp_deleta_cliente(in id integer)
BEGIN
delete from tb_cliente where tb_cliente_id = id;
END $$
DELIMITER ;



DELIMITER $$
create procedure sp_altera_locacao(in id integer, in tipo varchar(64), in valor double, in dt_inicio datetime, in dt_fim datetime, in cliente_id int,
 in funcionario_id int, in auto_id int)
begin
update tb_locacao set
tb_locacao_tipo = tipo,
tb_locacao_valor = valor,
tb_locacao_dt_inicio = dt_inicio,
tb_locacao_dt_fim = dt_fim,
tb_cliente_id = cliente_id,
tb_funcionario_id = funcionario_id,
tb_automovel_id = auto_id
where tb_locacao_id = id;
end $$
DELIMITER ;


DELIMITER $$
create procedure sp_altera_cliente(
 in id integer,
 in nome varchar(128),
 in telefone varchar(16),
 in sexo varchar(32),
 in email varchar(128),
 in endereco varchar(128),
 in complemento varchar(10),
 in bairro varchar(128),
 in cidade varchar(128),
 in uf varchar(8),
 in dt_nascimento datetime,
 in dt_cadastro datetime)
begin
update tb_cliente set
tb_cliente_nome = nome,
tb_cliente_tel = telefone,
tb_cliente_sexo = sexo,
tb_cliente_email = email,
tb_cliente_endereco = endereco,
tb_cliente_complemento = complemento,
tb_cliente_bairro = bairro,
tb_cliente_cidade = cidade ,
tb_cliente_uf = uf ,
tb_cliente_dt_nasc = dt_nascimento,
tb_cliente_dt_cad = dt_cadastro
where tb_cliente_id = id;
end $$
DELIMITER ;

create table tb_usuario
(
tb_usuario_id integer auto_increment primary key not null,
tb_usuario_email varchar(32) not null,
tb_usuario_senha varchar(32) not null,
tb_usuario_tipo varchar(32) not null,
tb_usuario_img longblob
)engine=InnoDB default charset=UTF8;


DELIMITER $$
create procedure sp_login(in login varchar(64), in senha varchar(64))
BEGIN

	select * from tb_usuario where tb_usuario_email = login and tb_usuario_senha = senha;

END $$
DELIMITER ;

DELIMITER $$
create procedure sp_altera_imagem(in id int, img longblob)
begin
update tb_usuario set tb_usuario_img = img where tb_usuario_id= id;
end $$
DELIMITER ;

DELIMITER $$
create procedure sp_busca_imagem(in id int)
begin
select tb_usuario_img from tb_usuario where tb_usuario_id = id;
end $$
DELIMITER ;


DELIMITER $$
create procedure sp_cadastra_usuario(in email varchar(32), in senha varchar(32), in tipo varchar(64), out resultado varchar(60))
begin
	if not exists(select * from tb_usuario where tb_usuario_email = email) then
		insert into tb_usuario(tb_usuario_email, tb_usuario_senha, tb_usuario_tipo) values(email, senha, tipo);
		set resultado = 'Usuario cadastrado.';
select resultado;		
	else 
		set resultado = 'Email já existente.';
select resultado;
end if ;
end $$
DELIMITER ;
call sp_cadastra_usuario('email','123','Gerente',@r);

DELIMITER $$
create procedure sp_mostra_user()
begin
select tb_usuario_id as 'ID', tb_usuario_email as 'User',tb_usuario_senha as 'Senha', tb_usuario_tipo as 'Tipo' from tb_usuario;
end $$
DELIMITER ;

DELIMITER $$
create procedure sp_altera_usuario(in id int, in email varchar(32), in senha varchar(32), in tipo varchar(64), out resultado varchar(60))
begin
if not exists(select * from tb_usuario where tb_usuario_email = email) then
update tb_usuario set tb_usuario_email = email, tb_usuario_senha = senha, tb_usuario_tipo =tipo where tb_usuario_id = id;    
set resultado = 'Alterado com sucesso !';
select resultado;
else
set resultado = 'Erro ao alterar';
select resultado;
end if;
end $$
DELIMITER ;

DELIMITER $$
create procedure sp_exclui_usuario(in id int)
begin
delete from tb_usuario where tb_usuario_id = id;  
end $$
DELIMITER ;



DELIMITER $$
create procedure sp_busca_cliente(in nome varchar(100))
begin
select tb_cliente_id as 'ID', tb_cliente_nome as 'Nome', tb_cliente_tel as 'Telefone', tb_cliente_sexo as 'Sexo', tb_cliente_email as 'Email', tb_cliente_endereco as 'Endereco',
tb_cliente_complemento as 'Complemento', tb_cliente_bairro as 'Bairro', tb_cliente_cidade as 'Cidade', tb_cliente_uf 'UF', tb_cliente_dt_nasc as 'Data de nascimento',
tb_cliente_dt_cad as 'Data de cadastro' from tb_cliente where tb_cliente_nome like concat('%',nome,'%');
end $$
DELIMITER ;

DELIMITER $$
create procedure sp_busca_auto(in nome varchar(100))
begin
select tb_automovel_id as 'ID', tb_automovel_nome as 'Veiculo', tb_automovel_ano_fab as 'Ano de Fabricação', tb_automovel_cor as 'Cor',
tb_automovel_km as 'Quilometragem', tb_automovel_valor_d as 'Valor da diária', tb_automovel_status as 'Status', tb_marca_nome as 'Marca',
tb_modelo_desc as 'Modelo' from tb_automovel where tb_automovel_nome like concat('%',nome,'%');
end $$
DELIMITER ;

DELIMITER $$
create procedure sp_busca_funcionario(in nome varchar(100))
begin
select tb_funcionario_id as 'ID',tb_funcionario_nome as 'Nome', tb_funcionario_tel as 'Telefone', 
tb_funcionario_dt_contrato as 'Data de contrato', tb_cargo_nome as 'Cargo' 
from tb_funcionario
inner join tb_cargo
on tb_funcionario.tb_cargo_id=tb_cargo.tb_cargo_id 
where tb_funcionario_nome like concat('%',nome,'%');
end $$
DELIMITER ;

