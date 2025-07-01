# 🎥 Admin Panelli Cv Sitesi

Admin Panelli Cv Sitesi, kullanıcıların özgeçmişlerini (CV) web tabanlı olarak oluşturup görüntüleyebileceği, kişisel bilgiler, deneyimler, projeler, eğitimler, beceriler ve daha fazlasını yönetebileceği bir ASP.NET MVC uygulamasıdır. Kullanıcı dostu arayüzü ile kolayca özgeçmiş bilgileri eklenebilir, güncellenebilir ve ziyaretçilere sunulabilir.

## 🚀 Özellikler

- Kişisel bilgiler, deneyimler, projeler, eğitimler, beceriler, hobiler, sertifikalar ve kurslar bölümleri
- Dinamik olarak sosyal medya bağlantıları ekleme
- Proje ve deneyimlerin detaylı listelenmesi
- Yönetici paneli ile içerik güncelleme
- Modern ve mobil uyumlu arayüz
- SQL Server ile veri saklama
- Giriş (login) ve yönetici yetkilendirme sistemi

## ⚡ Kullanılan Teknolojiler

- ASP.NET MVC 5
- .NET Framework 4.7.2
- Entity Framework
- Sql Server
- Bootstrap 4
- jQuery
- HTML5 & CSS3

## 🧰 Yapı

- **controllers**: Uygulamanın iş mantığını ve veri akışını yöneten denetleyiciler. Örneğin: DefaultController, AdminController, LoginController gibi dosyalar burada bulunur.
- **models**: Veritabanı tablolarını temsil eden Entity Framework sınıfları ve veri modelleri. Örneğin: TblAbout, TblProjects, TblEducation vb.
- **views**: Kullanıcıya gösterilen arayüz dosyaları. Her controller için ayrı klasörler ve bu klasörlerde ilgili .cshtml dosyaları (ör: Views/Default/Index.cshtml, Views/Admin/Index.cshtml). 
- **Views/Shared**: Tüm sayfalarda ortak kullanılan layout ve parça görünümler (ör: _AdminLayout.cshtml).
- **content**: CSS ve tema dosyalarını içerir. Bootstrap, özel stiller ve ikonlar burada yer alır.
- **scripts**: JavaScript ve jQuery dosyaları, eklentiler ve özel scriptler burada bulunur.
- **app_start**: Uygulama başlangıç ayarları (RouteConfig, FilterConfig vb.) bu klasörde yer alır.
- **global.asax**: Uygulamanın başlangıç noktası ve genel olay yönetimi burada yapılır.
- **web_config**: Uygulama yapılandırma ve veritabanı bağlantı ayarlarının bulunduğu dosya.

## ✂️ Ekran Görüntüleri

## Site

### Ana Sayfa
![hakkımda](https://github.com/user-attachments/assets/8227ffbc-8803-4cea-94cd-67f4d1a95c28)

### Beceriler 
![beceriler](https://github.com/user-attachments/assets/9f92bbfa-769f-4cb0-9b9a-d06a03134150)

### Kurslar
![kurslar](https://github.com/user-attachments/assets/bdf46ae6-b741-4312-bd2c-16b111e523cc)


## Admin Paneli

### Giriş Yapma Ekranı
![login](https://github.com/user-attachments/assets/85e05761-7462-4c49-a71c-2bca7bb3d9f8)

### Hakkımda 
![hakkımda-panel](https://github.com/user-attachments/assets/8632f249-143d-4180-beae-9f3059ea52f0)

### Beceriler
![skills-panel](https://github.com/user-attachments/assets/df29cbec-3062-4e7b-b402-99abc98ad3fe)

### Projeler
![projeler-panel](https://github.com/user-attachments/assets/fb1de476-6430-4322-b1fa-92c272c922a2)

### İletişim ve Mesajlar Ekranı
![contact-panel](https://github.com/user-attachments/assets/b472ca98-148d-41d3-9ae7-77766aeebd2d)

### Proje Ekleme Sayfası
![add-project-panel](https://github.com/user-attachments/assets/b4c5a223-f309-4cf2-9a9d-be1b5cc1c82e)

### Düzenleme Sayfası
![update-panel](https://github.com/user-attachments/assets/7aff868c-9068-4e3e-802a-a90299838168)



## 👊 Katkıda Bulunma

- Katkılar her zaman açıktır! Eğer hata bulursanız veya yeni bir özellik eklemek isterseniz, lütfen bir pull request gönderin.
- Bu depoyu fork'layın.
- Yeni bir branch oluşturun: git checkout -b feature/yeniden-özellik.
- Değişikliklerinizi yapın ve commit edin: git commit -am 'Yeni özellik ekle'.
- Branch'ınızı GitHub'a gönderin: git push origin feature/yeniden-özellik.
- Pull request oluşturun.

## 📦 Kurulum

Projenin çalışması için aşağıdaki adımları izle:

### 1. Depoyu Klonlayın

Projeyi bilgisayarınıza klonlamak için aşağıdaki komutu kullanabilirsiniz:

```bash
git clone https://github.com/portfolio-website.git
cd portfolio-website
```

### 2. Visual Studio 2022 ile projeyi açın.

### 3. Gerekli NuGet paketlerini yükleyin:

- Çözüm Gezgini'nde projeye sağ tıklayın ve NuGet Paketlerini Yönet seçeneğini seçin.
- Gerekli paketler: EntityFramework, Microsoft.AspNet.Mvc, Microsoft.AspNet.Razor, Microsoft.AspNet.WebPages vb.
- Paketleri Geri Yükle seçeneğini kullanarak eksik bağımlılıkları yükleyin.

### 4. Veritabanı bağlantı ayarlarını yapın:

- Proje kökündeki Web.config dosyasındaki <connectionStrings> bölümünü kendi SQL Server bilgilerinizle güncelleyin.

### 5. Projeyi başlatın:

- F5 tuşuna basarak veya Başlat butonunu kullanarak projeyi çalıştırabilirsiniz.

### 6. Uygulamayı Görüntüle
Bu komut, uygulamayı http://localhost:3000 adresinde başlatacaktır.
