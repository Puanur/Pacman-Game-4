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

   
