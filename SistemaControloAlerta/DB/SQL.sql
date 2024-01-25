create table 
tbl_Depart_Est_Plan_Anal(
Num int identity(1,1) primary key, 
Assunto varchar(50) not null, 
conteudo_Despacho varchar(5000) not null, 
Area_Afectada varchar(50) not null, 
Numero_de_oficio varchar(30) not null, 
Data_Orientacao datetime not null, 
Prazo datetime not null, 
Obs varchar(2500)
);