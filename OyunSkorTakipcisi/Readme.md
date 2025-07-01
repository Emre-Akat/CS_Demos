# Oyun Skor Takipçisi / Game Score Tracker

## Proje Hakkında / About the Project
Bu proje, oyun içi skor takibini ve seviye atlamayı basitçe simüle eden C# konsol uygulamasıdır.  
Event ve delegate kullanarak, skor değiştiğinde ilgili metodlar tetiklenir ve oyuncu skoruna göre seviye atlaması kontrol edilir.

This project is a simple C# console application simulating game score tracking and level-up system.  
Using events and delegates, related methods are triggered on score changes and player leveling is checked accordingly.

---

## Özellikler / Features
- Oyuncu skorunu artırma  
- Skor değişiminde event ile bildirim  
- Seviye atlama kontrolü  
- Loglama fonksiyonu

- Increase player score  
- Event-driven notifications on score change  
- Level up checking  
- Logging functionality

---

## Kullanım / How to Use
1. Projeyi klonlayın veya indirin  
2. Visual Studio veya .NET destekli bir IDE ile açın  
3. `Main` metodunda `SkorKazandı` metodunu çağırarak skor ekleyin  
4. Konsolda skor değişimi, seviye atlama ve log çıktıları göreceksiniz

1. Clone or download the project  
2. Open with Visual Studio or any .NET supported IDE  
3. Call the `SkorKazandı` method in `Main` to add score  
4. Observe score changes, level-up, and logs in console output

---

## Örnek Kod / Sample Code

```csharp
SkorDurumu skor = new SkorDurumu();
skor.SkorYap += SkorDegisimi;
skor.SkorYap += LevelUp;
skor.SkorYap += Log;

skor.SkorKazandı("Emre", 60);
skor.SkorKazandı("Emre", 40);
