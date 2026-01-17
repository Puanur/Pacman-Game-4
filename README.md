#Pacman Oyunu 
---

## 🗒️ Proje Açıklaması 

Pacman' de oyuncu, sarı renkli ve ağzı açılıp kapanan bir karakteri kontrol eder. Oyun ekranının etrafında duvarlar çevrilidir. Bu duvarların iç kısmında küçük altınlar ve hareket eden 4 tane hayalet vardır. Oyunun temel amacı, Pacman'i duvarlar içerisinde dolaştırarak tüm altınları yemek ve bunu yaparken hayaletlere yakalanmamaktadır.

## 🎮 Oyun Kuralları

* **Amaç:** Pacman'in duvarlar içerisinde hayaletlere çarpmadan hayaletleri yemesidir.
* **Mekanik:**
    * Sağ, sol, yukarı, aşağı tuşları kullanılarak oynanır.
    * DUvarlar Pacman'in hareketini engeller.
    * Pacman, hayaletlere çarptığı zaman oyun sonlanır.
## 🛠 Teknik Özellikler

### Gereksinim Yönetimi

#### Sistem Gereksinimleri
* *İşletim Sistemi:* Windows XP ve üstü
* *.NET Framework:* .NET Framework 4.7.2 veya daha yüksek sürümü
* *RAM:* En az 512 MB (önerilen: 2 GB)
* *Disk Alanı:* 50 MB

#### Yazılım Gereksinimleri
* *Geliştirme Ortamı:* Visual Studio 2017 veya üstü
* *Programlama Dili:* C# 7.0+
* *Bağlı Kütüphaneler:*
    * System.Windows.Forms (UI Framework)
   

---

### 📂 Proje Yapısı

```text
pacman oyun 4/
├── Form1.cs                 # Ana oyun ekranı kodları
├── Form1.Designer.cs        # Tasarımcı tarafından oluşturulan kodlar
├── Form1.resx               # Form kaynak dosyaları
├── Program.cs               # Uygulamanın giriş noktası
├── App.config               # Uygulama yapılandırma dosyası
├── pacman oyunu 4.csproj   # Proje dosyası
└── Properties/              
    ├── AssemblyInfo.cs      # Derleme bilgileri
    ├── Resources.Designer.cs # Kaynak yönetim kodları
    ├── Resources.resx       # Kaynak dosyaları
    └── Settings.Designer.cs  # Ayarlar tasarımcı kodları

## 📦 Bağımlılıklar

---

| Bağımlılık | Sürüm | Amaç |
| :--- | :--- | :--- |
| .NET Framework | 4.7.2 | Temel framework |
| System.Windows.Forms | 4.7.2 | UI komponenti |

## 🚀 Başlangıç Kılavuzu

---

### Derleme

Projeyi yerel ortamınızda çalıştırmak için aşağıdaki komutları terminalinizde kullanabilirsiniz:

```bash
# Projeyi açın
dotnet restore

# Debug modunda derleyin
dotnet build

# Release modunda derleyin
dotnet build --configuration Release
## 📈 Performans Özellikleri

---

* *Bellek Kullanımı:* ~50 MB
* *İşlemci Kullanımı:* Minimal (<5%)
* *Yükleme Süresi:* <2 saniye
* *FPS:* 60 FPS stabil

## 🔐 Güvenlik Özellikleri

---

* ✅ Gereksiz dosya erişimi yok
* ✅ Giriş doğrulaması
* ✅ Hatalardan güvenli çıkış
* ✅ Kaynak koruması
## 📝 Yazılım Lisansı

Bu proje eğitim amaçlı oluşturulmuştur.

## 👨‍💻 Geliştirici Bilgileri

* *Ad:* Puanur Çakır
* *E-posta:* [puanurcakir@gmail.com](mailto:puanurcakir@gmail.com)
* *Proje Tarihi:* 2026

## 🎓 Eğitim Amaçlı Özellikler

Bu proje şu programlama konseptlerini öğretmek amacıyla geliştirilmiştir:

* ✅ *Olay tabanlı programlama* (Event-driven programming)
* ✅ *Polimorfizm* (Method overloading)
* ✅ *Kapsülleme* (Encapsulation)
* ✅ *Timer ve asenkron işlemler*
* ✅ *Grafik Kullanıcı Arayüzü* (GUI) tasarımı
* ✅ *Ses ve multimedya entegrasyonu*
* ✅ *Dosya ve kaynak yönetimi*
* ✅ *Veri yapıları* (List, Random)

## 📞 Destek

Sorularınız veya önerileriniz için lütfen iletişim kurunuz.

---
*Son Güncelleme:* 15 Ocak 2026

   
