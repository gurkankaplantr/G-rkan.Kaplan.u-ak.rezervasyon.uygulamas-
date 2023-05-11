# Gürkan.Kaplan.uçak.rezervasyon.uygulaması
Kurulum;
Bu uygulama, .NET Framework sürümleri gerektirir. 
Ayrıca, uygulamayı çalıştırmak için Visual Studio IDE veya benzeri bir C# geliştirme ortamına ihtiyacınız olabilir.

c# dilinde yazdığım uçak rezervasyon konsol uygulaması;
Uçak clası , müşteri clası, lokasyon clası, ucusOluşturma clası, MüşteriOluşturma clası , UçakOluşturma clası , lokasyonOluşturma clası, rezervasyon oluşturma clası ve program clasından oluşmaktadır.
Bin dosyaasında var olan konum dosyayı uçakların nereden nereye uçacagını tutan veri dosyasıdır.

>>>>> Program.cs
Program, havayolu şirketi hakkında bazı bilgileri göstererek ve kullanıcıyı rezervasyon sistemi için karşılayarak başlar. Ardından, MusteriOlusturma sınıfını kullanarak yeni bir müşteri nesnesi oluşturur ve kullanıcıdan bilgilerini girmesini isteyerek müşteri bilgilerini elde eder. Müşteri bilgileri elde edildikten sonra, UcusOlusturma sınıfını kullanarak yeni bir uçuş rezervasyonu oluşturur ve uçuş ayrıntılarını kullanıcıya gösterir.

>>>>>> Uçak.cs
Bu C# kodu bir arayüz (interface) içerir ve IUcak olarak adlandırılır. Bu arayüz, uçak nesnelerinin sahip olması gereken özellikleri tanımlar. IUcak arayüzünde, uçak nesnelerinin aşağıdaki özelliklere sahip olması gerektiği belirtilir:

Model: Uçağın modeli (string türünde)
SeriNo: Uçağın seri numarası (string türünde)
YolcuKapasitesi: Uçağın taşıyabileceği yolcu sayısı (int türünde)
BagajKapasitesi: Uçağın taşıyabileceği bagaj kapasitesi (string türünde)
Hiz: Uçağın maksimum hızı (int türünde)

>>>>>> Müşteri.cs
Bu C# kodu Musteri sınıfını içerir. Musteri sınıfı, uygulamanın müşteri bilgilerini temsil etmek için kullanılır ve aşağıdaki özelliklere sahiptir:

Ad: Müşterinin adı (string türünde)
Soyad: Müşterinin soyadı (string türünde)
Yaş: Müşterinin yaş bilgisi (string türünde)
KimlikNo: Müşterinin kimlik numarası (string türünde)
IletisimNo: Müşterinin iletişim numarası (string türünde)
Cinsiyet: Müşterinin cinsiyeti (int türünde, örneğin 1: erkek, 2: kadın gibi)
Engelli: Müşterinin engelli olup olmadığı (int türünde, örneğin 0: engelli değil, 1: engelli)
Musteri sınıfı, ayrıca bir constructor (yapıcı) metodu içerir. Bu constructor metodu, Musteri sınıfından yeni bir nesne oluşturulduğunda çalışır ve sınıfın özelliklerini parametre olarak verilen değerlerle tanımlar. Bu şekilde, müşteri bilgileri Musteri sınıfı tarafından saklanabilir ve uygulamanın diğer kısımlarında kullanılabilir.

>>>>> Lokasyon.cs
Bu C# kodu ILokasyon arayüzünü (interface) içerir. ILokasyon arayüzü, uygulamanın lokasyon bilgilerini temsil etmek için kullanılır ve aşağıdaki özelliklere sahiptir:

Ulke: Lokasyonun bulunduğu ülke (string türünde)
Sehir: Lokasyonun bulunduğu şehir (string türünde)
Havalimanı: Lokasyonun havalimanı (string türünde)

>>>>> LokasyonOlusturma.cs
Bu C# kodu LokasyonOlusturma sınıfını ve ILokasyon arayüzünü içerir. LokasyonOlusturma sınıfı, ILokasyon arayüzünden türetilir ve uygulamanın lokasyonlarını oluşturmak ve yönetmek için kullanılır. Ayrıca, LokasyonList özelliği, oluşturulan lokasyonların listesini tutmak için kullanılır.

LokasyonOlusturma sınıfı, konum bilgilerinin dosyadan okunmasını ve LokasyonList'e eklenmesini sağlar. Eğer dosya mevcut değilse, sınıfın varsayılan değerleri (Türkiye, Kars, Harakani Havalimanı) kullanılarak bir lokasyon oluşturulur ve LokasyonList'e eklenir.

Ayrıca, FilePath özelliği, konum bilgilerinin dosyasının yolu ve TLokasyon özelliği, her bir lokasyonun birleştirilmiş hali olarak tanımlanır.

>>>>> MüsteriOlusturma
Bu C# kodu bir MusteriOlusturma sınıfını içerir. Bu sınıf, kullanıcıdan müşteri bilgilerini almak için kullanılır ve aşağıdaki özelliklere sahiptir:

Ad: Müşterinin adı (string türünde)
Soyad: Müşterinin soyadı (string türünde)
Yaş: Müşterinin yaşını temsil eden bir dize (string türünde)
KimlikNo: Müşterinin kimlik numarası (string türünde)
IletisimNo: Müşterinin iletişim numarası (string türünde)
Cinsiyet: Müşterinin cinsiyetini temsil eden bir tamsayı (int türünde). 1 Erkek, 2 Kadın
Engelli: Müşterinin engelli olup olmadığını belirten bir tamsayı (int türünde). 1 Evet, 2 Hayır

Ayrıca, musteri () adlı bir fonksiyon, kullanıcıdan bilgileri alır ve bir Musteri nesnesi döndürür. Bu nesne, müşteri bilgilerini tutmak için kullanılır.

>>>>> ucusOlusturma.cs
Bu kod, uçak rezervasyon sistemi uygulamasında uçuş oluşturma işlemlerinin yapıldığı sınıfı içerir. Bu sınıf, müşteri adı ve soyadını alarak, uçuşla ilgili diğer bilgileri müşteri seçimlerine göre alır ve bu bilgileri bir rezervasyon nesnesi içinde saklar. Bu sınıf, uçuş oluşturma işlemi tamamlandığında, rezervasyon nesnesini döndürür.

>>>>> UcakOlusturma.cs
Bu kod parçası, IUcak arayüzünü uygulayan UcakOlusturma sınıfını içerir. UcakOlusturma sınıfı, rastgele bir uçak modeli ve seri numarası oluşturur ve bu uçak modeli için yolcu kapasitesi, bagaj kapasitesi ve hız gibi özellikleri tanımlar. UcakOlusturma sınıfı, UcusOlusturma sınıfı tarafından kullanılır ve uçuş için kullanılacak bir uçağın modeli, seri numarası ve özelliklerini sağlar.

>>>>> Rezervasyon.cs
Bu sınıf, rezervasyon yapılırken oluşan ücretleri rastgele olarak belirlemek için bir Random nesnesi kullanır.
Sınıfın "ucret" adında bir tam sayı değişkeni vardır. Bu değişken, Rezervasyon nesnesi oluşturulduğunda, belirtilen aralıkta (1000-6500) rastgele bir değerle başlatılır. Bu değer, uçuşun ücretini temsil eder ve müşteriye sunulurken kullanılır.







