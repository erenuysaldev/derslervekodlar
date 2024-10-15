/*
C-reate(Yeni �r�n Olu�turma)
R-ead(�r�n detay�n� getirme, �r�nleri listeleme)
U-pdate(�r�n g�ncelleme)
d-ELETE(�r�n silme)
CRUD ��lemleri
*/
--INSERT
/*
INSERT INTO Tablo Ad�(Kolon1,Kolon2,...)
VALUES
     (value1,value2,...),
	 (value1,value2,...),
	 ...
	 */
--INSERT INTO Categories(CategoryName,Description)
--VALUES ('Bilgisayar','Son teknoloji �r�n� bilgisayarlar burada')

--UPDATE
/*
UPDATE TabloAd� SET kolon1=value1, kolon2=value2,
WHERE ko�ul
*/
--UPDATE Categories SET Description='Yeni kategori a��klamas�'
--WHERE CategoryID=11

--DELETE
/*
		DELETE FROM TabloAd�
		Where ko�ul

*/
--DELETE FROM Categories
--WHERE CategoryID=11

SELECT * FROM Categories c
WHERE c.IsDeleted=0
