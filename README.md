# Mustafa-Gundogdu_Final_Homework
Mustafa Gündoğdu Bitirme Projesi


# Bitirme Projesi
Açıklama : Bir sitede yöneticisiniz. Sitenizde yer alan dairelerin aidat ve ortak kullanım
elektrik, su ve doğalgaz faturalarının yönetimini bir sistem üzerinden yapacaksınız.
İki tip kullanıcınız var:
1-Admin/Yönetici
* Daire bilgilerini girebilir.
* İkamet eden kullanıcı bilgilerini girer.
* Daire başına ödenmesi gereken aidat ve fatura bilgilerini girer(Aylık olarak). Toplu veya
tek tek atama yapılabilir.
* Gelen ödeme bilgilerini görür.
* Gelen mesajları görür.
* Mesajların okunmuş/okunmamış/yeni mesaj olduğu anlaşılmalı.
* Aylık olarak borç-alacak listesini görür.
* Kişileri listeler, düzenler, siler.
* Daire/konut bilgilerini listeler, düzenler siler.
2-Kullanıcı
* Kendisine atanan fatura ve aidat bilgilerini görür.
* Sadece kredi kartı ile ödeme yapabilir.
* Yöneticiye mesaj gönderebilir.
* Mesajların okunmuş/okunmamış/yeni mesaj olduğu anlaşılmalı.
* Yaptığı ödemelerini görür.
Daire/Konut bilgilerinde:
* Hangi blokda
* Durumu (Dolu-boş)
* Tipi (2+1 vb.)
* Bulunduğu kat

* Daire numarası
* Daire sahibi veya kiracı
Kullanıcı bilgilerinde
* Ad-soyad
* TCNo
* E-Mail
* Telefon
* Araç bilgisi(varsa plaka no)

Sistem kullanılmaya başladığında ilk olarak,
1.Yönetici daire bilgilerini girer.
2.Kullanıcı bilgilerini girer.Giriş yapması için otomatik olarak bir şifre
oluşturulur. 3.Kullanıcıları dairelere atar
4.Ay bazlı olarak aidat bilgilerini girer.
5.Ay bazlı olarak fatura bilgilerini girer
Arayüz dışında kullanıcıların kredi kartı ile ödeme yapabilmesi için ayrı bir servis
yazılacaktır.
Bu serviste sistemde ki her bir kullanıcı için banka bilgileri (bakiye, kredi kartı no
vb.) kontrol edilerek ödeme yapılması sağlanır.
Ödeme sadece kredi kartı ile yapılabilir.
Projede kullanılacaklar:
1.Web projesi backend için .Net Core, frontend için
Razorkullanılmalı.
2.Sistemin yönetimi/database için MS SQL Server kullanılmalı.
3.Kredi kartı servisi için. Veriler mongodb de tutulmalı. Servis .Net WebApi olarak
yazılacaktır.
4.Mümkün olduğu kadar derslerde işlenen konular projeye entegre edilmelidir.
 

# Projeyi Bilgisayarınızda kurmak için adımları izleyin
## 

![image](https://github.com/PatikaDev-Logo-Net-Bootcamp/Mustafa-Gundogdu_Final_Homework/blob/main/images/solution_tanitimi.png )

*Öncelikle veritabanlarını kurmamız gerekiyor
Apartment.App.Web projesinde appsettings.json dosyasına gidiyoruz ve Connectionstring->DefaultConnection içerisindeki connection String i kendi bilgisayarınıza göre ayarlamanız gerekliyor.
"Server= YOUR_SERVER"

![image](https://github.com/PatikaDev-Logo-Net-Bootcamp/Mustafa-Gundogdu_Final_Homework/blob/main/images/update-database.png )
*Package Manager Console içerisinde Resimdeki gibi default projeyi seçip UPDATE-DATABASE komutunu çalıştırıyoruz.

*Web Projemiz hazır şimdi API'yi oluşturalım
Mongo Db Yükledikten sonra bknz: https://www.mongodb.com/try/download/community üzerinden indirip kurduktan sonra 

![image](https://github.com/PatikaDev-Logo-Net-Bootcamp/Mustafa-Gundogdu_Final_Homework/blob/main/images/mongo-create-db.png )
*Resimdeki adımları izleyerek veritabanın kuruyoruz.

![image](https://github.com/PatikaDev-Logo-Net-Bootcamp/Mustafa-Gundogdu_Final_Homework/blob/main/images/mongo-connectionstring.png )
*Resimdeki adımları izleyerek mongo için kullanacağımız bağlantıyı kopyalıyoruz bağlana tıklayıp kapatıyoruz.


![image](https://github.com/PatikaDev-Logo-Net-Bootcamp/Mustafa-Gundogdu_Final_Homework/blob/main/images/paymentservice-update.png )
*Resimdeki adımları izleyerek mongodb konfigürasyonlarını API mize ekliyoruz. Veritabanı oluştururken kullandığımız veritabanı ve collectionName i doğru yazdığımızdan emin olmalıyız

