# Yuksi Web API

# Yuksi Web API

Bu depo, `Yuksi` projesinin .NET ile geliştirilmiş Web API uygulamasını içerir. Amaç; okunabilir, genişletilebilir ve üretime hazır yaklaşımlar kullanılarak API tabanlı servislerin oluşturulmasıdır.

Özellikler
- .NET 10 hedefli uygulama
- C# 14.0 ile yazılmış kod
- Test projeleri ile temel birim testi desteği

Gereksinimler
- .NET 10 SDK
- `dotnet` CLI (komut satırı aracı)
- Tercihe bağlı: Visual Studio / Visual Studio Code gibi bir IDE

Hızlı Başlangıç
1. Depoyu klonlayın:

```bash
git clone https://github.com/Yuksi-Teknoloji/YuksiWebApiDotnet.git
cd Yuksi
```

2. Bağımlılıkları geri yükleyin ve projeyi derleyin:

```bash
dotnet restore
dotnet build
```

3. API'yi çalıştırın (proje yolunu kendi yapınıza göre düzenleyin):

```bash
# Eğer tek bir proje dizinindeyseniz
dotnet run --project <ProjeDizini>

# veya çözüm kökünde genel çalıştırma
dotnet run
```

Testler

Testleri çalıştırmak için:

```bash
dotnet test
```

Katkıda bulunma
- Hata bildirimi (issue) açın.
- Yeni özellik veya düzeltme için pull request gönderin.
- Kod standartlarına uymaya çalışın; mümkünse küçük ve odaklı PR'lar gönderin.

Lisans
- Projede bir `LICENSE` dosyası varsa ona bakın. Yoksa lisans bilgisi için depo sahibi ile iletişime geçin.

İletişim
- Sorular, öneriler veya destek talepleri için GitHub üzerinden issue açabilirsiniz.

Teşekkürler!

Kullanılan Teknolojiler, Mimariler ve Paketler

- Mimari yaklaşımlar: Layered / Clean-like (Domain, Application, Infrastructure, WebAPI), CQRS komut/handler modeli (`MediatR`), bağımlılık enjeksiyonu (DI), Options pattern.
- Yetkilendirme/kimlik: `Microsoft.AspNetCore.Identity`, JWT (`Microsoft.AspNetCore.Authentication.JwtBearer`).
- Veri erişimi: `Entity Framework Core` + `Npgsql` (PostgreSQL). EF Core için naming conventions ve tooling paketleri kullanılıyor.
- Validasyon: `FluentValidation`.
- Nesne/hata/sonuç modeli: `TS.Result`, repository yardımcı paketleri.
- API dokümantasyon: `Swashbuckle.AspNetCore` (Swagger).
- Testler: `xUnit`, `Moq`, `coverlet.collector`.
- Container: Çok aşamalı `Dockerfile` ile image üretimi.

Proje bazlı paket özeti
- Yuksi.Domain
  - `Ardalis.SmartEnum` 8.2.0
  - `Microsoft.AspNetCore.Identity.EntityFrameworkCore` 10.0.3
  - `Npgsql` 10.0.1
  - `TS.EntityFrameworkCore.GenericRepository` 10.0.0

- Yuksi.Application
  - `AutoMapper` 16.0.0
  - `AutoMapper.Extensions.Microsoft.DependencyInjection` 12.0.0
  - `FluentValidation` 12.1.1
  - `FluentValidation.DependencyInjectionExtensions` 12.1.1
  - `MediatR` 14.0.0
  - `Microsoft.AspNetCore.Identity` 2.3.9
  - `TS.Result` 10.0.0

- Yuksi.Infrastructure
  - `EFCore.NamingConventions` 10.0.1
  - `Microsoft.AspNetCore.Authentication.JwtBearer` 10.0.3
  - `Microsoft.EntityFrameworkCore.SqlServer` 10.0.3
  - `Microsoft.EntityFrameworkCore.Tools` 10.0.3
  - `Npgsql.EntityFrameworkCore.PostgreSQL` 10.0.0
  - `Scrutor` 7.0.0

- Yuksi.WebAPI
  - `DefaultCorsPolicy` 8.0.0
  - `Microsoft.EntityFrameworkCore.Design` 10.0.3
  - `Newtonsoft.Json` 13.0.4
  - `Swashbuckle.AspNetCore` 10.1.4

- Yuksi.Test
  - `coverlet.collector` 6.0.4
  - `Microsoft.NET.Test.Sdk` 17.14.1
  - `xunit` 2.9.3
  - `xunit.runner.visualstudio` 3.1.4
  - `Moq` 4.18.4

Yazılım olgunluğu / Seniorlik seviyesi
- Proje: Kıdemli (Senior) seviye yaklaşımlar ve uygulama örnekleri içerir. Mimari seçimler, test kapsaması, bağımlılık yönetimi ve üretim odaklı konfigürasyonlar (telemetri, logging, rate limiting, health checks, background jobs, cache,signalr,docker,docker compose) göz önünde bulundurularak hazırlanmıştır.


