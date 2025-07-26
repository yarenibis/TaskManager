# 📝 Task Manager Uygulaması (Console ➡️ WinForms ➡️ Entity Framework)

Bu proje, **not ve kullanıcı yönetimi** üzerine kurulu çok katmanlı bir uygulamanın 3 aşamada gelişimini göstermektedir: 
Admin ve kullanıcı olmak üzere 2 rol bulunmaktadır. Admin hem kullanıcı hem notlar sayfasını görebiliyorken kullanıcılar sadece kendi notları üzerinde işlem yapabilmektedir.
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

![Uygulama Ana Ekranı](<img width="1052" height="653" alt="Ekran görüntüsü 2025-07-26 145222" src="https://github.com/user-attachments/assets/9a07149c-83c9-4455-9903-2de641ae80ac" />
)
![Uygulama Ana Ekranı](<img width="748" height="622" alt="Ekran görüntüsü 2025-07-26 145307" src="https://github.com/user-attachments/assets/8dc4bd61-55e7-4f02-8814-980039050ec2" />
)


