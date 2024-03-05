# .NET Core Kurumsal Mimariye Uygun Backend Projesi

Bu proje, .NET Core teknolojisi kullanılarak geliştirilmiş, kurumsal düzeyde bir backend uygulamasını içermektedir. Aşağıda proje içeriği ve yapılan teknik seçimler hakkında detaylı bilgi bulabilirsiniz.

## Teknolojiler ve Kavramlar

- .NET Core
- Entity Framework Core
- Generic Repository Pattern
- RESTful API
- SOLID Prensipleri
- LINQ
- Autofac (IoC Container)
- Fluent Validation
- Aspect-Oriented Programming (AOP)
- JSON Web Token (JWT)
- Cache Yönetimi
- Transactional Yönetim
- Performans İyileştirmeleri

## Proje İçeriği

- **Katmanlı Mimarî Yapı**: Veri Erişim, İş Mantığı ve API iletişim katmanlarını içerir.
- **Abstract ve Concrete Klasörleri**: Soyut ve somut nesneleri, arayüzleri ve base class'ları içerir.
- **IoC Container (Autofac)**: Inversion of Control prensibi ile bağımlılıkları azaltır.
- **DTO (Data Transformation Object)**: Veri tabanı tablolarından veri çekerken veri dönüşümlerini sağlar.
- **Result ve DataResult Sınıfları**: İşlem sonuçlarını standartlaştırır.
- **Utilities Klasörü**: Ortak kullanılan araçları içerir.
- **Middleware'ler**: JWT ile yetkilendirme ve hata yönetimi gibi ortak işlevler.
- **Cache Mekanizması**: Performansı artırmak için veri saklama stratejisi.
- **Transactional Yönetim**: Veritabanı işlemlerinde tutarlılığı sağlar.
- **Validation**: Kullanıcı girişlerinin doğrulanması için Fluent Validation kullanımı.
- **Logging**: Uygulama üzerinde yapılan işlemlerin izlenmesi ve hata takibi için loglama sistemi.
- **Security**: Kullanıcı şifrelerinin güvenli bir şekilde saklanması ve iletilmesi için hashing ve encryption kullanımı.

## Kullanım

Projenin kullanımıyla ilgili adımları buraya ekleyin. Örneğin:

1. Proje klasörünü indirin veya klonlayın.
2. Gerekli bağımlılıkları yükleyin (`dotnet restore`).
3. Veritabanı yapılandırmasını gerçekleştirin (`dotnet ef database update`).
4. Uygulamayı çalıştırın (`dotnet run`).

## Katkı

Eğer proje ile ilgili bir sorun bulursanız veya katkıda bulunmak isterseniz, lütfen bir issue açın veya bir pull request gönderin.
