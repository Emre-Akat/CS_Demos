# Çay Demlendi Uyarı Sistemi / Tea Ready Notification System

---

## Türkçe Açıklama

Bu proje, C# dilinde **Event ve EventHandler kullanarak** basit bir "Çay Demlendi" uyarı sistemi örneğidir.  
`CayMakinesi` sınıfı, çayın demlendiği anı bir event ile bildirir.  
`CayBilgisi` sınıfı ise event ile birlikte taşınan çay bilgilerini (çay adı ve demlenme süresi) içerir.  

Projede, bu event'e bağlı 3 farklı metod vardır:  
- Kullanıcıya mesaj gösterme  
- Ses efekti verme  
- Log kaydı tutma  

Event mekanizması sayesinde kod daha esnek, okunabilir ve genişletilebilir hale gelir.

---

## English Description

This project is a simple **Tea Ready Notification System** example in C# using **Events and EventHandler**.  
The `CayMakinesi` class raises an event when tea is brewed.  
The `CayBilgisi` class carries tea-related information (tea name and brewing time) with the event.  

There are 3 different methods subscribed to the event:  
- Display a message to the user  
- Play a sound effect  
- Write a log entry  

Thanks to the event mechanism, the code becomes more flexible, readable, and extensible.

---

## Kullanım / Usage

1. Projeyi klonlayın veya indirin.  
2. `Program.cs` dosyasını açın ve çalıştırın.  
3. `CayMakinesi.Demle()` metodu ile çay demleme simülasyonu yapılır ve event tetiklenir.  
4. Konsol üzerinde ilgili mesajlar gösterilir.

---

