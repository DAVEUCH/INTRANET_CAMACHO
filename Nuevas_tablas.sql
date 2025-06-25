create table FormInterIngre(
idFormInterIngre int IDENTITY(1,1) NOT NULL,
nombPersona varchar (100) NULL,
apePersona varchar (100) NULL,
fechaIng datetime NULL,
dniPersona varchar (12) NULL,
areaPersona varchar (50) NULL,
cargPersona varchar (50) NULL,
tipoPuesto bit NULL,
hardwlapt bit NULL,
hardwcompu bit NULL,
hardwcel bit NULL,
softoffice bit NULL,
softAntiv bit NULL,
softadob bit NULL,
softcorr bit NULL,
softsys bit NULL,
softflex bit NULL,
observacion varchar (8000) NULL,
idUsuario int references Usuario(idUsuario),
estado bit NULL
) 

create table FormInterSal(
idFormInterSal int IDENTITY(1,1) NOT NULL,
nombPersona varchar (100) NULL,
apePersona varchar (100) NULL,
fechaIng datetime NULL,
dniPersona varchar (12) NULL,
areaPersona varchar (50) NULL,
cargPersona varchar (50) NULL,
perfilADPersona varchar (100) NULL,
usured bit NULL,
correocorp bit NULL,
accefex bit NULL,
accessys bit NULL,
acceotro bit NULL,

devdescripmodelLappc varchar (8000) NULL,
devserienumLappc varchar (8000) NULL,
devdevuelto bit NULL,
devnoaplica bit NULL,
devobslappoc varchar (8000) NULL,

devdescripmodeotros varchar (8000) NULL,
devserienumotros varchar (8000) NULL,
devdevueltootros bit NULL,
devnoaplicaotros bit NULL,
devobslappocotros varchar (8000) NULL,

observacion varchar (8000) NULL,
idUsuario int references Usuario(idUsuario),
estado bit null
) 

select*from Usuario