use cinema;

/*aşağıdaki komut isprimary key diye entitiy framework de karşılaştığım hatayı gidermek için çözüm oldu*/
set global optimizer_switch='derived_merge=off';

create table tblPersonel(
p_TC varchar(11) not null,
p_Ad varchar(20) not null,
p_Soyad varchar(20) not null,
p_Sifre varchar(10) not null,
p_Mail varchar(80) not null,
p_Telefon varchar(11) not null,
p_Yetki varchar(10) not null,
primary key (p_TC)
);

create table tblFilm(
f_Id int not null auto_increment,
f_Adi varchar(150) not null,
f_Yili varchar(4) not null,
f_Yonetmen varchar(100) not null,
f_Oyuncular varchar(1500) not null,
f_Tur varchar(100) not null,
f_VGiris datetime not null,
f_VCikis datetime not null,
primary key (f_Id)
);

drop table tblfilm;

select * from tblfilm where f_Oyuncular like '%ben%';

select *from  tblFilm;
alter table tblFilm add f_Sure varchar(10) not null;
alter table tblFilm modify f_VGiris date not null;

create table tblSalon(
s_Id int not null,
s_Adi varchar(10) not null,
s_Kapasite int not null ,
primary key (s_Id)
);

use cinema;

select *from tblpersonel;

SELECT seans_Saat FROM tblsalon JOIN tblseans ON s_Id = seans_Salon;

select *from tblkoltuk where fk_Salonid=1 and k_Seans='15:10:00';
create table tblKoltuk(
k_Id int not null auto_increment,
fk_Salonid int not null,
CONSTRAINT tblKoltuk FOREIGN KEY (fk_Salonid)
REFERENCES tblSalon(s_Id),
k_Seans time,
k_durum char(10) not null,
primary key (k_Id)
);

alter table tblkoltuk add k_tipi char(10) ;

create table tblSeans(
seans_Id int not null auto_increment,
seans_Saat time not null,
seans_Tarih date not null,
seans_Film varchar(150) not null,
seans_Salon int not null,
primary key (seans_Id)
);


select *from tblpersonel;
select *from tblbilet where b_Film like '%bat%';
create table tblBilet(
b_Id int not null auto_increment,
b_Film varchar(150) not null,
b_Salon varchar(10) not null,
b_Seans time not null,
b_Koltuk int not null,
b_Personel varchar(11) not null,
b_Tipi varchar(10) not null,
b_Ucret varchar(10) not null,
primary key (b_Id)
);

select *from tblseans where seans_Salon=1 and seans_Saat='15:00:00'; 
select *from tblkoltuk;
drop table tblbilet;

/*constraint b_fk_koltuk foreign key (b_Koltuk) 
references tblkoltuk(k_Id),
constraint b_fk_personel foreign key (b_Personel) 
references tblpersonel(p_TC),;*/