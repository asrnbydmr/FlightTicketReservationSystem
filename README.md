# Uçak Bileti Rezervasyon Uygulaması

* Bu proje, uçak bileti rezervasyon bilgilerini JSON dosyasına kaydetme projesidir.
* Visual Studio 2022 (.Net Framework 4.8) ile yapılmıştır.
* Newtonsoft.Json NuGet paketi yüklenmiştir.
* Projede 7 sınıf (Program.cs ile birlikte 8 sınıf) bulunmaktadır.

## Kullanılan Kütüphaneler

### Dahili Kütüphaneler
- System
- System.Collections
- System.IO
- System.Text.RegularExpressions

### Harici Kütüphaneler
- Newtonsoft.Json

## Nasıl Çalışır

1. Program başlatıldığında, uçak, lokasyon ve uçuş bilgileri oluşturulur ve bilgiler ayrı ayrı JSON dosyalarına yazdırılır.
* Not: Program başlatıldığında files klasörü oluşturulur ve JSON dosyalarını files klasörünün içerisinde oluşturur.
2. Aktif uçuşlar listelenir ve aktif uçuş seçilir.
3. Müşteri bilgileri girilir ve rezervasyon yapılır.
* Not: Uçuşlar sıra numarasına göre seçilir. Girilen değer listelenen sıra numarasından büyük, sıfır veya sıfırdan küçük olamaz.
* Not: Ad ve soyad verisi sadece harfsel veri olmalıdır. Sayı veya sembol içeren veriler kabul edilmez.
* Not: Yaş ve telefon numarası (11 haneli olmalıdır) verisi sadece sayı olmalıdır. Harf veya sembol içeren veriler kabul edilmez.
* Not: Cinsiyet verisi sadece f - F, m - M ve o - O harfi olabilir. Bu harfler dışında veri kabul edilmez.
* Not: Yeni bir rezervasyon için y - Y harfi girilmelidir. Bu veri dışında girilen tüm veriler için rezervasyon işlemi sonlandırlır.
* Not: Her rezervasyon işlemi için, rezerve edilen uçağın yolcu kapasitesi bir azaltılır. Eğer uçak yolcu kapasitesi 0 dan büyük değil ise ve uçuş aktif değil ise listede listelenmez.

## Sınıflar

- Airplane: Uçak bilgilerini tutan ve uçak verilerini işleyen sınıftır.
- FileOperations: Dosya işlemlerini gerçekleştiren sınıftır.
- FilePath: Dosya isimlerini ve yollarını tutan sınıftır.
- Flight: Uçuş bilgilerini tutan ve uçuş verilerini işleyen sınıftır.
- InputControls: Girilen verileri kontrol eden sınıftır.
- Location: Lokasyon bilgilerini tutan ve lokasyon verilerini işleyen sınıftır.
- Program: Programın ana sınıfıdır.
- Reservation: Rezervasyon bilgilerini tutan ve rezervasyon verilerini işleyen sınıftır.

## Alanlar

- Airplane -> brand: Uçak marka bilgisini tutan alandır.
- Airplane -> model: Uçak model bilgisini tutan alandır.
- Airplane -> serialNumber: Uçak seri numarası bilgisini tutan alandır.
- Airplane -> seatCapacity: Uçak yolcu kapasitesi bilgisini tutan alandır.

- FileOperations -> folderName: JSON belgelerinin oluşturulacağı dosya adını tutan alandır.

- FilePath -> filepathAirplane: Uçak JSON belgesinin adını ve dosya yolunu tutan alandır.
- FilePath -> filepathLocation: Lokasyon JSON belgesinin adını ve dosya yolunu tutan alandır.
- FilePath -> filepathFlight: Uçuş JSON belgesinin adını ve dosya yolunu tutan alandır.
- FilePath -> filepathRezervation: Rezervasyon JSON belgesinin adını ve dosya yolunu tutan alandır.

- Flight -> Airplane: Uçak bilgilerini (nesnesini) tutan alandır.
- Flight -> Location: Lokasyon bilgilerini (nesnesini) tutan alandır.
- Flight -> Date: Tarih bilgilerini tutan alandır.

- Location -> country: Lokasyon ülke bilgisini tutan alandır.
- Location -> city: Lokasyon şehir bilgisini tutan alandır.
- Location -> airport: Lokasyon havaalanı bilgisini tutan alandır.
- Location -> activePassive: Lokasyonun aktif olup olmadığının bilgisini tutan alandır.

- Program -> listCounter: Uçuş listesinin sıra numarasını tutan alandır.

- Reservation -> flight: Uçuş bilgilerini (nesnesini) tutan alandır.
- Reservation -> firstName: Müşteri ad bilgisini tutan alandır.
- Reservation -> lastName: Müşteri soyad bilgisini tutan alandır.
- Reservation -> age: Müşteri yaş bilgisini tutan alandır.
- Reservation -> gender: Müşteri cinsiyet bilgisini tutan alandır.
- Reservation -> phoneNumber: Müşteri telefon numarası bilgisini tutan alandır.

## Diziler

- Airplane -> airplanes: Uçak bilgilerini tutan dizidir.
- Flight -> flights: Uçuş bilgilerini tutan dizidir.
- Location -> locations: Lokasyon bilgilerini tutan dizidir.
- Reservation -> reservations: Rezervasyon bilgilerini tutan dizidir.

## Metotlar

- Airplane -> newAirplane: Uçak bilgilerini parametre olarak alan, verileri uygun alanlara aktaran ve airplanes dizisine verileri ekleyen metotdur.
- Airplane -> fillAirplanes: 4 adet uçak bilgisini tutan ve newAirplane metodunu çalıştıran metotdur.
- Airplane -> getAirplane: İndeks değeri yok ise airplanes dizisini, indeks değeri var ise belirtilen Airplane nesnesini geri döndüren metotdur.
- Airplane -> getAirplaneCount: airplanes dizisinin uzunluğunu geri döndüren metotdur.

- FileOperations -> folderExists: Parametre olarak belirtilen dosya var mı yok mu kontrol eder, yok ise dosyayı oluşturur.
- FileOperations -> fileExists: Parametre olarak belirtilen belge var mı yok mu kontrol eder, yok ise belgeyi oluşturur.
- FileOperations -> fileRead: JSON dosyasının içeriğini okur ve belirtilen sınıf nesnesine çevirerek geri döndürür. Belge içerisinde veri yok ise null değer döndürür.
- FileOperations -> fileWrite: Parametre olarak belirtilen belgeye parametre olarak belirtilen veriyi yazdırır.
- FileOperations -> fillAirplaneFile: Uçak bilgilerini JSON dosyasına yazdırır.
- FileOperations -> fillLocationFile: Lokasyon bilgilerini JSON dosyasına yazdırır.
- FileOperations -> fillFlightFile: Uçuş bilgilerini JSON dosyasına yazdırır.
- FileOperations -> fillFiles: Uçak, lokasyon ve uçuş bilgilerinin JSON dosyalarına yazılması için belirtilen metotları çalıştırır.

- Flight -> fillFlights: Rastgele uçuş oluşturan ve flights dizisine verileri ekleyen metotdur.
- Flight -> getFlight: flights dizisini geri döndüren metotdur.

- InputControls -> lettersControl: Parametre olarak belirtilen metini kontrol eder. Tüm karakterler harf ise true, değil ise false değerini geri döndürür.
- InputControls -> stringControl: Parametre olarak belirtilen verinin harflerden oluşup oluşmadığını kontrol eder.
- InputControls -> intControl: Parametre olarak belirtilen verinin rakamlardan oluşup oluşmadığını kontrol eder. Part değeri 0 ise; parametre olarak belirtilen verinin 1 ile uçuş liste sıra numarası arasında olup olmadığını, part değeri 1 ise; 0 ile 101 arasında olup olmadığını kontrol eder.
- InputControls -> genderControl: Parametre olarak belirtilen veriyi kontrol eder. Verinin {f - F, m - M veya o - O} harflerinden birisi olması gerekir.
- InputControls -> phoneNumberControl: Parametre olarak belirtilen veriyi kontrol eder. Verinin 11 haneli bir sayı olması gerekir.

- Location -> newLocation: Lokasyon bilgilerini parametre olarak alan, verileri uygun alanlara aktaran ve locations dizisine verileri ekleyen metotdur.
- Location -> fillLocations: 6 adet lokasyon bilgisini tutan ve newLocation metodunu çalıştıran metotdur.
- Location -> getLocation: İndeks değeri yok ise locations dizisini, indeks değeri var ise belirtilen Location nesnesini geri döndüren metotdur.

- Program -> Main: Ana metotdur. Aktif uçuş listesini konsol ekranına yazdırır. Kullanıcıya uçuş seçtirir ve müşteri bilgilerini girdi olarak alır. Rezervasyon oluşturulduktan sonra uçak yolcu kapasitesini azaltır. While döngüsü ile {y - Y} değeri girilene kadar rezervasyon yaptırır.
* Not: Programın aniden kapanmasını engellemek için Console.ReadKey() metodu kullanılmıştır. Programı tamamen kapatmak için bir tuşa basmanız gerekmektedir.

- Reservation -> newReservation: Rezervasyon bilgilerini parametre olarak alan, verileri uygun alanlara aktaran ve reservations dizisine verileri ekleyen metotdur. FileOperations sınıfının fileWrite metodu ile rezervasyon bilgisini JSON dosyasına yazdırır.
- Reservation -> getReservation: reservations dizisini geri döndüren metotdur.