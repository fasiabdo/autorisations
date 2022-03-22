use Autorisation
create table Permis
(
	NDecision varchar(50) not null,
	NomPrenom varchar(50) not null,
	Autorisation varchar(50),
	Reference_Fonciers varchar(50),
	pv date,
	typePermis varchar(50) not null,
	document varbinary(max),
	constraint pk_Permis primary key(NDecision)
)