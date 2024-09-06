Kütüphane Yönetim Sistemi
Bu proje, C# dilinde yazılmış basit bir kütüphane yönetim sistemidir. Sistem, iki tabloya dayanır: Yazarlar (Authors) ve Kitaplar (Books). Yazarlar ve kitaplar arasındaki ilişkiyi bir LINQ sorgusu ile birleştirip, her kitabın başlığını ve yazarının adını görüntüler.
Proje Tanımı
Bu sistemde iki ana sınıf bulunmaktadır:

Author: Yazarlar için benzersiz bir kimlik (AuthorId) ve ad (Name) içerir.
Book: Kitaplar için benzersiz bir kimlik (BookId), başlık (Title) ve kitabın yazarını ilişkilendiren bir AuthorId içerir.
Proje, LINQ kullanarak Yazarlar ve Kitaplar tablolarını birleştirir ve her kitabın başlığını ve yazarın adını ekrana yazdırır.
