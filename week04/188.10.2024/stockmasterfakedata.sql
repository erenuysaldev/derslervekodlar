-- Kategoriler Tablosuna Veri Ekleme
INSERT INTO Categories (Name, Description)
VALUES 
    ('Elektronik', 'Elektronik cihazlar ve aksesuarlar'), 
    ('Ofis Malzemeleri', 'Kalem, kaðýt, yazýcý gibi malzemeler'),
    ('Mutfak Gereçleri', 'Býçaklar, tencereler, mutfak aletleri'),
    ('Kitaplar', 'Her türden kitaplar ve basýlý yayýnlar'),
    ('Giyim', 'Her türlü giysi ve aksesuar'),
    ('Kozmetik', 'Cilt bakým ve güzellik ürünleri'),
    ('Spor Eþyalarý', 'Spor ve açýk hava etkinlikleri için malzemeler'),
    ('Ev Eþyalarý', 'Evde kullanýlan eþyalar'),
    ('Hobi Ürünleri', 'Hobi ve eðlence ile ilgili ürünler'),
    ('Oyunlar', 'Oyun ve eðlence malzemeleri');
GO

-- Tedarikçiler Tablosuna Veri Ekleme
INSERT INTO Suppliers (Name, ContactName, Phone, Address)
VALUES 
    ('ABC Elektronik', 'Ali Yýlmaz', '555-1234', 'Ýstanbul, Türkiye'),
    ('XYZ Ofis', 'Mehmet Kaya', '555-5678', 'Ankara, Türkiye'),
    ('Gourmet Mutfak', 'Ayþe Demir', '555-8765', 'Ýzmir, Türkiye'),
    ('Kitap Dünyasý', 'Deniz Yýlmaz', '555-4321', 'Bursa, Türkiye')
GO

-- Ürünler Tablosuna Veri Ekleme
-- Elektronik Kategorisi
INSERT INTO Products (Name, CategoryId, SupplierId, QuantityPerUnit, UnitPrice, UnitsInStock, ReorderLevel, Discounted)
VALUES 
    ('Laptop', 1, 1, '1 adet', 15000.00, 50, 10, 0),
    ('Akýllý Telefon', 1, 1, '1 adet', 7000.00, 30, 5, 0),
    ('Kulaklýk', 1, 1, '1 adet', 300.00, 100, 20, 0),
    ('Tablet', 1, 1, '1 adet', 4000.00, 15, 7, 0)
GO

-- Ofis Malzemeleri Kategorisi
INSERT INTO Products (Name, CategoryId, SupplierId, QuantityPerUnit, UnitPrice, UnitsInStock, ReorderLevel, Discounted)
VALUES 
    ('Yazýcý', 2, 2, '1 adet', 500.00, 100, 20, 0),
    ('Kalem', 2, 2, '10 adet', 20.00, 200, 50, 0),
    ('Defter', 2, 2, '5 adet', 15.00, 150, 25, 0),
    ('Dosya', 2, 2, '10 adet', 50.00, 80, 15, 0)
GO

-- Mutfak Gereçleri Kategorisi
INSERT INTO Products (Name, CategoryId, SupplierId, QuantityPerUnit, UnitPrice, UnitsInStock, ReorderLevel, Discounted)
VALUES 
    ('Mikser', 3, 3, '1 adet', 200.00, 75, 15, 0),
    ('Tencere Seti', 3, 3, '5 adet', 350.00, 30, 5, 0),
    ('Býçak Seti', 3, 3, '3 adet', 150.00, 60, 10, 0),
    ('Kesme Tahtasý', 3, 3, '1 adet', 25.00, 90, 12, 0)
GO

-- Kitaplar Kategorisi
INSERT INTO Products (Name, CategoryId, SupplierId, QuantityPerUnit, UnitPrice, UnitsInStock, ReorderLevel, Discounted)
VALUES 
    ('Roman Kitap', 4, 4, '1 adet', 30.00, 200, 50, 0),
    ('Bilim Kurgu Kitabý', 4, 4, '1 adet', 45.00, 150, 30, 0),
    ('Ders Kitabý', 4, 4, '1 adet', 60.00, 100, 20, 0),
    ('Kendi Kendine Öðrenme', 4, 4, '1 adet', 25.00, 250, 60, 0)
GO

-- Giyim Kategorisi
INSERT INTO Products (Name, CategoryId, SupplierId, QuantityPerUnit, UnitPrice, UnitsInStock, ReorderLevel, Discounted)
VALUES 
    ('Tiþört', 5, 1, '1 adet', 50.00, 100, 20, 0),
    ('Pantolon', 5, 1, '1 adet', 150.00, 80, 15, 0),
    ('Ceket', 5, 1, '1 adet', 200.00, 50, 10, 0),
    ('Kazak', 5, 1, '1 adet', 80.00, 60, 12, 0)
GO

-- Kozmetik Kategorisi
INSERT INTO Products (Name, CategoryId, SupplierId, QuantityPerUnit, UnitPrice, UnitsInStock, ReorderLevel, Discounted)
VALUES 
    ('Nemlendirici Krem', 6, 2, '1 adet', 100.00, 120, 25, 0),
    ('Dudak Balmý', 6, 2, '1 adet', 30.00, 200, 30, 0),
    ('Parfüm', 6, 2, '1 adet', 250.00, 50, 10, 0),
    ('Makyaj Fýrçasý', 6, 2, '1 adet', 75.00, 70, 12, 0)
GO

-- Spor Eþyalarý Kategorisi
INSERT INTO Products (Name, CategoryId, SupplierId, QuantityPerUnit, UnitPrice, UnitsInStock, ReorderLevel, Discounted)
VALUES 
    ('Dumbbell Seti', 7, 3, '2 adet', 200.00, 30, 5, 0),
    ('Yoga Matý', 7, 3, '1 adet', 75.00, 50, 10, 0),
    ('Koþu Bandý', 7, 3, '1 adet', 2500.00, 10, 2, 0),
    ('Bisiklet', 7, 3, '1 adet', 1500.00, 20, 4, 0)
GO

-- Ev Eþyalarý Kategorisi
INSERT INTO Products (Name, CategoryId, SupplierId, QuantityPerUnit, UnitPrice, UnitsInStock, ReorderLevel, Discounted)
VALUES 
    ('Koltuk Takýmý', 8, 4, '1 takým', 5000.00, 10, 2, 0),
    ('Masa', 8, 4, '1 adet', 800.00, 15, 3, 0),
    ('Sandalye', 8, 4, '4 adet', 400.00, 25, 5, 0),
    ('Lamba', 8, 4, '1 adet', 150.00, 30, 6, 0)
GO

-- Hobi Ürünleri Kategorisi
INSERT INTO Products (Name, CategoryId, SupplierId, QuantityPerUnit, UnitPrice, UnitsInStock, ReorderLevel, Discounted)
VALUES 
    ('Resim Seti', 9, 1, '1 set', 120.00, 40, 8, 0),
    ('Maket Seti', 9, 1, '1 set', 150.00, 20, 4, 0),
    ('Yapboz', 9, 1, '1 adet', 30.00, 60, 12, 0),
    ('Müzik Aleti', 9, 1, '1 adet', 500.00, 15, 3, 0)
GO

-- Oyunlar Kategorisi
INSERT INTO Products (Name, CategoryId, SupplierId, QuantityPerUnit, UnitPrice, UnitsInStock, ReorderLevel, Discounted)
VALUES 
    ('Masa Oyunu', 10, 2, '1 adet', 100.00, 50, 10, 0),
    ('Video Oyunu', 10, 2, '1 adet', 300.00, 20, 5, 0),
    ('Kart Oyunu', 10, 2, '1 adet', 50.00, 70, 15, 0),
    ('Bulmaca', 10, 2, '1 adet', 40.00, 80, 20, 0)
GO

-- Stok Hareketleri Veri Ekleme
INSERT INTO StockTransactions (ProductId, TransactionType, Quantity)
VALUES 
    (1, 'IN', 50),
    (2, 'IN', 100),
    (1, 'OUT', 10),
    (3, 'IN', 75),
    (4, 'IN', 30),
    (5, 'IN', 200),
    (6, 'OUT', 30),
    (7, 'IN', 20),
    (3, 'OUT', 5)
GO