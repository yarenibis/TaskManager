# 📝 Task Manager Uygulaması (Console ➡️ WinForms ➡️ Entity Framework)

Bu proje, **not ve kullanıcı yönetimi** üzerine kurulu çok katmanlı bir uygulamanın 3 aşamada gelişimini göstermektedir:  
Console → WinForms → Entity Framework + SQL Server.

---

## 🚀 Aşama 1: Console Uygulaması - `TaskManager`
İlk sürüm bir **konsol uygulamasıdır**. Basit kullanıcı ve not işlemleri yapılmıştır.

### Özellikler:
- Kullanıcı ekleme, listeleme,güncelleme,silme
- Not ekleme, silme, güncelleme, listeleme
- Basit `List<User>` ve `List<Note>` veri yapısı
- Kalıcı veri saklama **yok** 

---

## 🖥️ Aşama 2: WinForms Uygulaması - `TaskManagerForm`
İkinci aşamada, proje **Windows Forms arayüzüne taşınmıştır.**

### Eklenen Özellikler:
- GUI (Kullanıcı dostu arayüz)
- `DataGridView` ile kullanıcı ve not listeleri
- Kullanıcı girişi (login), CRUD işlemleri
- Veriler veritabanında tutulur

---

## 🧠 Aşama 3: Entity Framework Uygulaması - `TaskManagerEF`
Üçüncü ve son aşamada, proje **Entity Framework Code First** ile geliştirildi.  
Tüm veriler artık **SQL Server veritabanına** kalıcı olarak kaydediliyor.

### Özellikler:
- `User` ve `Note` sınıfları EF ile eşleştirildi
- `DbContext` (TaskManagerContext.cs) üzerinden işlem yapılıyor
- Foreign Key ilişkisi: Bir `User`, birden fazla `Note`'a sahip
- Lazy Loading devre dışı bırakılarak Eager Loading ile `Include()` kullanılıyor
- `App.config` üzerinden bağlantı dizesi tanımlandı
- Migration desteğiyle veritabanı güncellemeleri sağlandı

## 📸 Ekran Görüntüsü

Aşağıda uygulamanın ana ekranına ait görüntüler almaktadır:

![Uygulama Ana Ekranı](screenshots/mainform.png)


