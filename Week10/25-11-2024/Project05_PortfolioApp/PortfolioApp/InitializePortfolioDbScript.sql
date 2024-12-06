-- Veritaban� yaratma operasyonu ba�l�yor
use master
go

if DB_ID('PortfolioDb') is not null
begin
	alter database PortfolioDb set single_user with rollback immediate
	drop database PortfolioDb
end
go

create database PortfolioDb collate Turkish_CI_AS
go

use PortfolioDb
go
--Veritaban� yaratma operasyonu sona erdi

--Uygulaman�n genel ayarlar� i�in Settings tablosu olu�turuluyor
create table Settings(
	Id int default 1,

	SiteName nvarchar(MAX) not null,
	FooterText nvarchar(MAX) not null,
	

	CreatedAt datetime2(3) not null default getdate(),
	UpdatedAt datetime2(3)
)
go

--Contacts tablosu olu�turuluyor
create table Contacts(
	Id int default 1,

	Address nvarchar(MAX) not null,
	PhoneNumber nvarchar(MAX) not null,
	Email nvarchar(MAX) not null,
	GoogleMap nvarchar(MAX) not null,

	CreatedAt datetime2(3) not null default getdate(),
	UpdatedAt datetime2(3)
)
go

--Abouts tablosu olu�turuluyor
create table Abouts(
	Id int default 1,

	AboutTitle nvarchar(MAX) not null,
	AboutText nvarchar(MAX) not null,
	AboutCvUrl nvarchar(MAX) not null,
	AboutImageUrl nvarchar(MAX) not null,

	CreatedAt datetime2(3) not null default getdate(),
	UpdatedAt datetime2(3)
)
go

--HomeBanners tablosu olu�turuluyor
create table HomeBanners(
	Id int default 1,

	HomeBannerTitle nvarchar(MAX) not null,
	HomeBannerSubTitle nvarchar(MAX) not null,
	HomeBannerText nvarchar(MAX) not null,
	HomeBannerImageUrl nvarchar(MAX) not null,

	CreatedAt datetime2(3) not null default getdate(),
	UpdatedAt datetime2(3)
)
go

create table ServiceInfos(
	Id int default 1,

	Title nvarchar(MAX) not null,
	SubTitle nvarchar(MAX) not null,
	
	CreatedAt datetime2(3) not null default getdate(),
	UpdatedAt datetime2(3)
)
go

create table Services(
	Id int primary key identity,

	Icon nvarchar(max) not null default '~/ui/img/services/s1.png',
	Title nvarchar(max) not null,
	SubTitle nvarchar(max) not null,
	Description nvarchar(max) not null,

	IsDeleted bit not null default 0,
	CreatedAt datetime2(3) not null default getdate(),
	UpdatedAt datetime2(3)
)
go

create table Categories(
	Id int primary key identity,

	Name nvarchar(max) not null,
	Description nvarchar(max) null default 'Kategori a��klamas�',

	IsDeleted bit not null default 0,
	CreatedAt datetime2(3) not null default getdate(),
	UpdatedAt datetime2(3)
)
go

create table Projects(
	Id int primary key identity,

	Title nvarchar(max) not null,
	SubTitle nvarchar(max) not null,
	Description nvarchar(max) null default 'Proje a��klamas�',
	ImageUrl nvarchar(max) not null,
	Team nvarchar(max) not null,
	Url nvarchar(max),
	GithubUrl nvarchar(max),
	ZipFileUrl nvarchar(max),
	CategoryId int not null foreign key references Categories(Id),

	IsDeleted bit not null default 0,
	CreatedAt datetime2(3) not null default getdate(),
	UpdatedAt datetime2(3)
)
go

create table Messages(
	Id int primary key identity,

	Name nvarchar(max) not null,
	Email nvarchar(max) not null,
	Subject nvarchar(max) not null,
	Content nvarchar(max) not null,

	IsDeleted bit not null default 0,
	IsRead bit not null default 0,
	SendingDate datetime2(3) default getdate(),
	ReadingDate datetime2(3)
)
go

create table SocialMediaAccounts(
	Id int primary key identity,

	Title nvarchar(max) not null,
	AccountUrl nvarchar(max) not null,
	Icon nvarchar(max) not null,

	IsDeleted bit not null default 0,
	CreatedAt datetime2(3) not null default getdate(),
	UpdatedAt datetime2(3)
)
go

INSERT INTO Settings (SiteName, FooterText, CreatedAt)
VALUES 
('Portf�y Sitesi', '� 2024 T�m Haklar� Sakl�d�r', GETDATE());
go

INSERT INTO Contacts (Address, PhoneNumber, Email, GoogleMap, CreatedAt)
VALUES 
('Ankara, T�rkiye', '+90 312 123 45 67', 'iletisim@portfoy.com', 'https://maps.google.com?q=Ankara', GETDATE());
go

INSERT INTO Abouts (AboutTitle, AboutText, AboutCvUrl, AboutImageUrl, CreatedAt)
VALUES 
('Hakk�mda', 'Yaz�l�m geli�tirme alan�nda uzmanla�m�� bir profesyonelim.', '~/ui/images/about-cv.png', '~/ui/images/about-image.png', GETDATE());
go

INSERT INTO HomeBanners (HomeBannerTitle, HomeBannerSubTitle, HomeBannerText, HomeBannerImageUrl, CreatedAt)
VALUES 
('Ho� Geldiniz', 'Yaz�l�m Portf�y�m', 'Projelerimi ve deneyimlerimi ke�fedin.', '~/ui/images/home-banner.png', GETDATE());
go

INSERT INTO ServiceInfos (Title, SubTitle, CreatedAt)
VALUES 
('Hizmetlerimiz', 'Yaz�l�m geli�tirme, tasar�m ve daha fazlas�.', GETDATE());
go

INSERT INTO Services (Title, SubTitle, Description, CreatedAt)
VALUES 
('Web Geli�tirme', 'Modern ve etkili ��z�mler', 'Responsive ve kullan�c� dostu web siteleri.', GETDATE()),
('Mobil Uygulama Geli�tirme', 'Yenilik�i ve h�zl�', 'iOS ve Android i�in modern mobil uygulamalar.', GETDATE()),
('SEO Optimizasyonu', 'Daha fazla g�r�n�rl�k', 'Arama motoru optimizasyonu ile daha fazla eri�im.', GETDATE()),
('E-Ticaret ��z�mleri', 'Sat��lar�n�z� art�r�n', 'Kapsaml� ve g�venilir e-ticaret platformlar�.', GETDATE());
go

INSERT INTO Categories (Name, Description, CreatedAt)
VALUES 
('Web Geli�tirme', 'Web tabanl� uygulama ve site geli�tirme teknolojileri.', GETDATE()),
('Mobil Geli�tirme', 'Mobil cihazlar i�in uygulama geli�tirme teknolojileri.', GETDATE()),
('Yapay Zeka', 'Yapay zeka ve makine ��renimi uygulamalar�.', GETDATE()),
('Veri Bilimi', 'B�y�k veri analizi ve veri bilimine y�nelik ��z�mler.', GETDATE());
go

INSERT INTO Projects (Title, SubTitle, Description, ImageUrl, Team, Url, GithubUrl, ZipFileUrl, CategoryId, CreatedAt)
VALUES 
('Blog Platformu', 'Ki�isel blog sitesi.', 'ASP.NET Core ve Angular ile geli�tirilmi�.', '~/ui/images/projects/blog.png', '3 Ki�ilik Ekip', 'https://github.com/blog-platform', 'https://github.com/blog-platform', '~/ui/projects/blog.zip', 1, GETDATE()),
('�irket Web Sitesi', 'Kurumsal bir web sitesi.', 'HTML, CSS, JavaScript ve PHP tabanl�.', '~/ui/images/projects/sirket.png', 'Tek Ki�ilik Ekip', 'https://github.com/sirket-web', 'https://github.com/sirket-web', '~/ui/projects/sirket.zip', 1, GETDATE()),
('Haber Portal�', 'Haber sitesi uygulamas�.', 'Django ve Bootstrap ile tasarlanm��.', '~/ui/images/projects/haber.png', '2 Ki�ilik Ekip', 'https://github.com/haber-portal', 'https://github.com/haber-portal', '~/ui/projects/haber.zip', 1, GETDATE());
go

INSERT INTO Projects (Title, SubTitle, Description, ImageUrl, Team, Url, GithubUrl, ZipFileUrl, CategoryId, CreatedAt)
VALUES 
('Mobil Al��veri� Uygulamas�', 'E-ticaret mobil uygulamas�.', 'Flutter ile geli�tirilmi�.', '~/ui/images/projects/mobil-alisveris.png', '4 Ki�ilik Ekip', 'https://github.com/mobil-alisveris', 'https://github.com/mobil-alisveris', '~/ui/projects/mobil-alisveris.zip', 2, GETDATE()),
('Fitness Takip Uygulamas�', 'Ki�isel fitness takip sistemi.', 'React Native ile tasarlanm��.', '~/ui/images/projects/fitness.png', '2 Ki�ilik Ekip', 'https://github.com/fitness-takip', 'https://github.com/fitness-takip', '~/ui/projects/fitness.zip', 2, GETDATE()),
('Hava Durumu Uygulamas�', 'Lokasyon bazl� hava durumu tahmini.', 'Swift ve iOS i�in geli�tirilmi�.', '~/ui/images/projects/hava-durumu.png', 'Tek Ki�ilik Ekip', 'https://github.com/hava-durumu', 'https://github.com/hava-durumu', '~/ui/projects/hava-durumu.zip', 2, GETDATE());
go
INSERT INTO Projects (Title, SubTitle, Description, ImageUrl, Team, Url, GithubUrl, ZipFileUrl, CategoryId, CreatedAt)
VALUES 
('G�r�nt� Tan�ma Sistemi', 'Resimlerdeki nesneleri tan�yan uygulama.', 'Python ve TensorFlow kullan�lm��.', '~/ui/images/projects/goruntu-tanima.png', '5 Ki�ilik Ekip', 'https://github.com/goruntu-tanima', 'https://github.com/goruntu-tanima', '~/ui/projects/goruntu-tanima.zip', 3, GETDATE()),
('Chatbot Uygulamas�', 'Do�al dil i�leme tabanl� chatbot.', 'Python ve Rasa Framework.', '~/ui/images/projects/chatbot.png', '3 Ki�ilik Ekip', 'https://github.com/chatbot', 'https://github.com/chatbot', '~/ui/projects/chatbot.zip', 3, GETDATE()),
('Tahmin Modeli', 'Sat�� tahmini i�in makine ��renimi modeli.', 'Scikit-learn ve Pandas kullan�lm��.', '~/ui/images/projects/tahmin-modeli.png', '2 Ki�ilik Ekip', 'https://github.com/tahmin-modeli', 'https://github.com/tahmin-modeli', '~/ui/projects/tahmin-modeli.zip', 3, GETDATE());
go

INSERT INTO Projects (Title, SubTitle, Description, ImageUrl, Team, Url, GithubUrl, ZipFileUrl, CategoryId, CreatedAt)
VALUES 
('Sat�� Analiz Sistemi', 'Sat�� verilerini analiz eden platform.', 'Tableau ve Python tabanl�.', '~/ui/images/projects/satis-analiz.png', '2 Ki�ilik Ekip', 'https://github.com/satis-analiz', 'https://github.com/satis-analiz', '~/ui/projects/satis-analiz.zip', 4, GETDATE()),
('Veri G�rselle�tirme Ara�lar�', 'B�y�k veriyi g�rselle�tiren uygulama.', 'D3.js ve Python ile geli�tirilmi�.', '~/ui/images/projects/veri-gorsellestirme.png', '3 Ki�ilik Ekip', 'https://github.com/veri-gorsellestirme', 'https://github.com/veri-gorsellestirme', '~/ui/projects/veri-gorsellestirme.zip', 4, GETDATE()),
('Makine ��renimi Ara� Kutusu', 'Kullan�ma haz�r ML ara�lar� sunan bir platform.', 'Sklearn, Flask ve React kullan�lm��.', '~/ui/images/projects/ml-arac-kutusu.png', 'Tek Ki�ilik Ekip', 'https://github.com/ml-arac-kutusu', 'https://github.com/ml-arac-kutusu', '~/ui/projects/ml-arac-kutusu.zip', 4, GETDATE());
go

INSERT INTO SocialMediaAccounts (Title, AccountUrl, Icon, CreatedAt)
VALUES 
('Instagram', 'https://instagram.com/portfoy', 'fa-instagram', GETDATE()),
('Facebook', 'https://facebook.com/portfoy', 'fa-facebook', GETDATE()),
('LinkedIn', 'https://linkedin.com/in/portfoy', 'fa-linkedin', GETDATE()),
('Medium', 'https://medium.com/@portfoy', 'fa-medium', GETDATE());
go

INSERT INTO Messages (Name, Email, Subject, Content, IsDeleted, IsRead, SendingDate)
VALUES 
('Ahmet Y�lmaz', 'ahmet@ornek.com', 'Portf�y�n� �ok be�endim!', 'Projelerin �ok ilham verici, tebrik ederim!', 0, 0, GETDATE()),
('Zeynep Kaya', 'zeynep@ornek.com', '��birli�i Hakk�nda', 'Birlikte �al��mak isterim, ileti�ime ge�ebilir misiniz?', 0, 0, GETDATE()),
('Mehmet �z', 'mehmet@ornek.com', 'Proje �nerisi', 'Yeni bir fikirle ilgilenebilece�inizi d���nd�m.', 0, 0, GETDATE()),
('Elif Demir', 'elif@ornek.com', 'Destek Hakk�nda', 'Portf�y�n�z� �ok be�endim, baz� sorular�m var.', 0, 0, GETDATE()),
('Canan Arslan', 'canan@ornek.com', 'Proje Sunumu', 'Birlikte bir sunum haz�rlamak isterim.', 0, 0, GETDATE()),
('Hakan �elik', 'hakan@ornek.com', 'Tasar�m Hakk�nda', 'Web tasar�m�n�z ilham verici!', 0, 0, GETDATE()),
('Ay�e Kurt', 'ayse@ornek.com', 'Te�ekk�rler', 'Projelerinizden �ok �ey ��rendim, te�ekk�r ederim!', 0, 0, GETDATE()),
('Berkay Ko�', 'berkay@ornek.com', '�leti�im', 'Bir i� f�rsat�yla ilgileniyor musunuz?', 0, 0, GETDATE()),
('Merve �ahin', 'merve@ornek.com', 'Soru', 'Backend geli�tirme hakk�nda �nerileriniz var m�?', 0, 0, GETDATE()),
('Fatih K�l��', 'fatih@ornek.com', 'Teknik Destek', 'Projenizde bir hata fark ettim, yard�mc� olabilir misiniz?', 0, 0, GETDATE()),
('Gizem Y�ld�z', 'gizem@ornek.com', 'Harika ��ler', 'Portf�y�n�zdeki projelere hayran kald�m.', 0, 0, GETDATE()),
('Ali Vural', 'ali@ornek.com', 'Yard�m Talebi', 'Bir konuda yard�ma ihtiyac�m var.', 0, 0, GETDATE()),
('Cansu U�ar', 'cansu@ornek.com', 'E�itim Tavsiyesi', 'Hangi kaynaklar� �nerirsiniz?', 0, 0, GETDATE()),
('Burak Ak', 'burak@ornek.com', 'G�r��me Talebi', 'Bir toplant� yapabilir miyiz?', 0, 0, GETDATE()),
('Seda �zt�rk', 'seda@ornek.com', '�nerileriniz', 'Portf�y geli�tirme i�in �nerileriniz var m�?', 0, 0, GETDATE()),
('Yunus Emre', 'yunus@ornek.com', '��birli�i', 'Birlikte �al��abilece�imiz bir alan var m�?', 0, 0, GETDATE()),
('Pelin Ko�', 'pelin@ornek.com', 'Proje Yorumu', 'Son projeniz harika g�r�n�yor!', 0, 0, GETDATE()),
('O�uzhan ��nar', 'oguzhan@ornek.com', 'E�itim Hakk�nda', 'Portf�y olu�turma e�itimleri veriyor musunuz?', 0, 0, GETDATE()),
('Asl� Ta�', 'asli@ornek.com', 'Web Sitesi', 'Web sitenizi geli�tirmek i�in bir �nerim var.', 0, 0, GETDATE()),
('Efe Y�ld�r�m', 'efe@ornek.com', 'Sorular�m Var', 'Size birka� teknik soru sormak istiyorum.', 0, 0, GETDATE()),
('Beyza Kaya', 'beyza@ornek.com', 'Projeleriniz', 'Projeleriniz ger�ekten �ok etkileyici.', 0, 0, GETDATE()),
('Mert Deniz', 'mert@ornek.com', '��birli�i', 'Yeni bir proje �zerinde birlikte �al��abiliriz.', 0, 0, GETDATE()),
('Deniz Ak�n', 'deniz@ornek.com', 'Tebrikler', 'Portf�y�n�z� inceledim ve �ok be�endim.', 0, 0, GETDATE()),
('Serkan Demir', 'serkan@ornek.com', 'Yeni Fikirler', 'Birlikte yeni projeler geli�tirmek isterim.', 0, 0, GETDATE()),
('Gamze �zkan', 'gamze@ornek.com', 'Etkileyici Projeler', 'Projelerinizi �ok ilham verici buluyorum.', 0, 0, GETDATE());
go