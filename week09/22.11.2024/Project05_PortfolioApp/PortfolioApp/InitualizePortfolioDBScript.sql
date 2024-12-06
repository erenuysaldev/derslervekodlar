--Veritabaný yaratma operasyonu baþlýyor
use master
go

if DB_ID('PortfolioDb') is not null
begin 
	alter database PortfolioDb set single_user with rollback
	immediate
	drop database PortfolioDb
end


create database PortfolioDb collate Turkish_CI_AS

use PortfolioDb
go
--Veri tabaný yaratma operasyonu sona erdi
--Uygulamaýn genel ayarlarý için Settings tablosu oluþturuluyor

create table Settings(
	Id int default 1,
	SiteName nvarchar(MAX),
	FooterText nvarchar(MAX) not null,
	Adress nvarchar(MAX) not null,
	PhoneNumber nvarchar(MAX) not null,
	Email nvarchar(MAX) not null,	
	GoogleMap nvarchar(MAX) not null,
	AboutTitle nvarchar(MAX) not null,
	AboutText nvarchar(MAX) not null,
	AboutCvUrl nvarchar(MAX) not null,
	AboutImageUrl nvarchar(MAX) not null,
	CreatedAt datetime2(3) not null default getdate(),
	UpdatedAt datetime2(3)
	

)
go
insert into Settings(SiteName,FooterText,Adress,PhoneNumber,Email,GoogleMap,AboutCvUrl,AboutImageUrl,AboutText,AboutTitle)
values
(
 