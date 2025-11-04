🏪 # Stok Yönetim Sistemi  
Bu proje market veya depolarda ürün, kategori ve stok işlemlerini yönetmek için geliştirilmiştir. Tüm bunları OOP kavramlarını kullanrak geliştirmek amaçlanmıştır.
Urun, Kategori, ve StokYonetimi olmak üzere 3 ayrı sınıf oluşturulmuştur.

🔴 # Urun.cs; 
Id, Ad, Fiyat ve StokMiktarı propertyleri oluşturulmuş, negatif stoklar engellenmiştir. 
StokGuncelle metoduyla stok miktarı artırılır veya azaltılır.
ToString metoduyla ise ürün bilgisi ekrana yazdırılır.
<img width="1031" height="705" alt="urun" src="https://github.com/user-attachments/assets/f6b9cc56-ec66-4eef-8ec7-19c5e6b73b0c" />


🟣 # Kategori.cs;
Id, Ad ve List<Urun> Urunler propertyleri oluşturulmuştur.
UrunEkle metodu ürünü kategoriye ekler.
ToString metodu ise kategori bilgisini ekrana yazdırır.

<img width="806" height="635" alt="kategori" src="https://github.com/user-attachments/assets/3ef0840b-c2a9-447f-816d-29e62e2e7ca0" />


🟢 # StokYonetimi.cs;
Birden fazla kategori ekleyebilmek için List<Kategori> tanımlanmıştır.
KategoriEkle metodu ile yeni bir kategori eklemesi yapılır ve bilgi mesajı gösterir.
TumStokListele metoduyla ise tüm kategoriler ve içinde bulunan ürünler listelenir.

🟡 # Program.cs;
StokYonetimi stok = new StokIslemleri(); ile nesne oluşturuldu.
Kategori kirtasiyeKategori = new Kategori(1, "Kırtasiye"); ile Kırtasiye adında bir kategori oluşturuldu.
Urun sınıfından kalem,silgi,defter adında 3 nesne oluşturuldu. Bu ürünler Kırtasiye kategorisine eklendi.
Kırtasiye kategorisi ise stok sistemine eklendi.
TumStokListele metoduyla kategori ve ürünlerin listelenmesi sağlandı.
StokGuncelle metodu kullanılarak kalem 5 azaltıldı.


