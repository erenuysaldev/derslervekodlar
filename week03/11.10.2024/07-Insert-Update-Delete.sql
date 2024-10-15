/*
C-reate(Yeni Ürün Oluþturma)
R-ead(Ürün detayýný getirme, ürünleri listeleme)
U-pdate(Ürün güncelleme)
d-ELETE(Ürün silme)
CRUD Ýþlemleri
*/
--INSERT
/*
INSERT INTO Tablo Adý(Kolon1,Kolon2,...)
VALUES
     (value1,value2,...),
	 (value1,value2,...),
	 ...
	 */
--INSERT INTO Categories(CategoryName,Description)
--VALUES ('Bilgisayar','Son teknoloji ürünü bilgisayarlar burada')

--UPDATE
/*
UPDATE TabloAdý SET kolon1=value1, kolon2=value2,
WHERE koþul
*/
--UPDATE Categories SET Description='Yeni kategori açýklamasý'
--WHERE CategoryID=11

--DELETE
/*
		DELETE FROM TabloAdý
		Where koþul

*/
--DELETE FROM Categories
--WHERE CategoryID=11

SELECT * FROM Categories c
WHERE c.IsDeleted=0
