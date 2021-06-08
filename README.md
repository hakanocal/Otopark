# Otopark takip programı
### 20 araç kapasiteli otopark için araç işlemleri, ücret işlemleri ve geçmiş takibi gibi işlemler

Visual Basic .NET, MsSQL 2012 ve Visual Studio 2012 kullanılarak hazırlandı

#### Programı sorunsuz bir şekilde çalıştırabilmek için:
· MsSQL kurulu olmalı \
· Otopark veritabanını oluşturmak için "OTOPARK VERİTABANI/script.sql" çalıştırılmalı\
· anasayfa.vb dosyasındaki Public src As String = "buraya-server-name-yazilacak" satırına veritabanı server name'i yazılmalı\
· otoparkDataSet.xsd silinmeli ve tekrar tanımlanmalı\
· Tekrar dataset tanımlamak için: \
Project/Add new Data Source/Database/Dataset/New Connection (\
Data Source: Microsoft SQL SERVER, \
Server Name: veritabanı servername,\
Database Name: otopark\
) \
OK > Next > "Tables"a tik atılır ve "DataSet name: otoparkDataSet" olduğundan emin olunur. 

#### Özellikler:
· Park yerine araç ekleme.\
· Park yeri renklendirmeleri sayesinde dolu ve boş park alanlarının kolayca takip edilebilmesi.\
· Araç giriş tarihi, giriş saati, geçen süre, ücretlendirme ve kişisel bilgileri görüntüleme.\
· Aracın çıkışını yapma ve akabinde toplam tutarı görme.\
· Geçmiş sayfasını kullanarak geçmişe yönelik kayıtları görüntüleyebilme.\
· Otobüs, motosiklet, otomobil gibi araç tiplerine göre saatlik ücretlerin ayarlanması.





<kbd>
  <img src="/images/1anasayfa.jpg">
</kbd>

<kbd>
  <img src="/images/2arac-ekle.jpg">
</kbd>

<kbd>
  <img src="/images/3arac-detay.jpg">
</kbd>

<kbd>
  <img src="/images/4gecmis.jpg">
</kbd>

<kbd>
  <img src="/images/5ucretlendirme.jpg">
</kbd>
