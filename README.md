# Stok Yönetim Sistemi  
Bu proje market veya depolarda ürün, kategori ve stok işlemlerini yönetmek için geliştirilmiştir. Tüm bunları OOP kavramlarını kullanrak geliştirmek amaçlanmıştır.

# Urun, Kategori, ve StokYonetimi olmak üzere 3 ayrı sınıf oluşturulmuştur.

# Urun.cs; 
Id, Ad, Fiyat ve StokMiktarı propertyleri oluşturulmuş, negatif stoklar engellenmiştir. 
StokGuncelle metoduyla stok miktarı artırılır veya azaltılır.
ToString metoduyla ise ürün bilgisi ekrana yazdırılır.

# Kategori.cs;
Id, Ad ve List<Urun> Urunler propertyleri oluşturulmuştur.
UrunEkle metodu ürünü kategoriye ekler.
ToString metodu ise kategori bilgisini ekrana yazdırır.

# StokYonetimi.cs;
