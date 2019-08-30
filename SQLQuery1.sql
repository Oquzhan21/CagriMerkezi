
use CagriMerkez
Create table Giris
(
	ID int identity(1,1),
	KullaniciAdi nvarchar(max),
	Sifre nvarchar(max),
	KullanýcýId int,
	Yetki nvarchar(50)
)
create table Calisan
(
	ID int identity(1,1),
	Ad nvarchar(max),
	Soyad nvarchar(max),
	mail nvarchar(max),
	DogumTar datetime,
	Numara bigint,
	Tc nvarchar(max)

)
create table Musteri
(
	ID int identity(1,1),
	MusteriAdi nvarchar(max),
	MusteriSoyadi nvarchar(max),
	MusteriNumarasi bigint,
	MusteriProblemi nvarchar(max),
	GorusmeId int
)
Create table GorusmeKaydi
(
	ID int identity(1,1),
	ArananKisi nvarchar(max),
	ArananNo bigint,
	GorusmeNotu nvarchar(max),
	GorusmeTar datetime,
	ErtelemeTar datetime,
	GorusmeDurumu nvarchar(max),
)
Create Table Gorev
(
	ID int identity(1,1),
	GorevAdi nvarchar(max),
	GorevDetay nvarchar(max),
	GorevSahibiID int,
	YapilacakSTarih datetime
)