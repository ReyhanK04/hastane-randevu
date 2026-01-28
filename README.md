# Hasta Takip ve Yönetim Sistemi (Patient Management System)

Bu proje, **Kocaeli Üniversitesi Programlama Laboratuvarı II** kapsamında geliştirilmiştir. Sağlık hizmetlerinin verimliliğini artırmak amacıyla; hasta kayıtları, randevu yönetimi ve tıbbi rapor saklama gibi kritik süreçleri dijital ortama taşıyan kapsamlı bir web uygulamasıdır.

## 🚀 Öne Çıkan Özellikler

* **Hasta Kayıt ve Yönetimi:** Yeni hastaların sisteme tanımlanması, mevcut bilgilerin güncellenmesi ve sağlık geçmişlerinin dijital olarak takip edilmesi.
* **Randevu Planlama Modülü:** Hastaların doktorlarla randevu oluşturabildiği, mevcut randevuların takvim üzerinde yönetilebildiği dinamik yapı.
* **Tıbbi Rapor Arşivi:** Hastalara ait teşhis, analiz ve tıbbi raporların güvenli bir şekilde saklanması ve doktorların erişimine sunulması.
* **Doktor ve Yönetici Paneli:** Sağlık personelinin kendi hastalarını yönetebildiği, adminlerin ise sistem genelindeki veri akışını denetleyebildiği yetkilendirilmiş paneller.
* **Kullanıcı Dostu Arayüz:** Tüm işlemlerin kolayca takip edilebileceği, modern ve sade bir web arayüzü tasarımı.

## 🛠 Teknik Detaylar

* **Platform:** Web Tabanlı Uygulama (ASP.NET)
* **Dil:** C#
* **Veritabanı:** MSSQL (İlişkisel veritabanı tasarımı ve normalizasyon kurallarına uygun yapı)
* **Bağlantı Katmanı:** Veritabanı iletişimi için özel olarak geliştirilmiş `sqlconnection` sınıfı ve güvenli veri bağlantı mimarisi.
* **Mimari Yaklaşım:** Nesne Yönelimli Programlama (OOP) prensipleri ve katmanlı yazılım tasarımı.

## 🧠 Çalışma Mantığı

1. **Giriş ve Karşılama:** Sistem, kullanıcıları rollerine göre karşılar ve yetkileri dahilindeki işlemlere yönlendirir.
2. **Dijital Kayıt:** Hasta ve doktor bilgileri veritabanında ilişkisel bir modelle tutulur; bu sayede bir hastaya ait randevu ve raporlar kolayca ilişkilendirilir.
3. **Randevu Süreci:** Kullanıcı randevu aldığında, sistem ilgili doktorun takvimiyle entegre çalışarak çakışmaları önler.
4. **Veri Güvenliği:** Tüm veritabanı bağlantıları kontrollü sınıflar üzerinden açılıp kapatılarak veri güvenliği ve performans optimizasyonu sağlanır.

## 👥 Geliştiriciler

* **Sena KÖSEOĞLU**
* **Reyhan KURTULMUŞ**

<img width="1767" height="985" alt="Ekran görüntüsü 2024-05-20 015301" src="https://github.com/user-attachments/assets/3213b6b4-b43f-4e5b-bae1-8d3c988defb4" />
<img width="1730" height="1135" alt="Ekran görüntüsü 2024-05-20 015435" src="https://github.com/user-attachments/assets/5a8bd122-5e8d-46b6-a005-7f474bdbb285" />
<img width="1681" height="1132" alt="Ekran görüntüsü 2024-05-20 015421" src="https://github.com/user-attachments/assets/93ee4a3f-7680-4de8-b536-7c117ab170e3" />
<img width="1790" height="1137" alt="Ekran görüntüsü 2024-05-20 015401" src="https://github.com/user-attachments/assets/ec2e3a7d-b7d4-43ee-ad4f-7f538a6c527f" />
<img width="1894" height="1133" alt="Ekran görüntüsü 2024-05-20 015453" src="https://github.com/user-attachments/assets/eea82f7d-c15d-49de-9862-94a9921eac32" />
<img width="1676" height="1044" alt="Ekran görüntüsü 2024-05-20 015502" src="https://github.com/user-attachments/assets/375d636f-ee12-4a73-a57d-7e2dc09db88d" />




