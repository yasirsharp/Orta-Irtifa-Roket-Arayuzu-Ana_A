# Orta İrtifa Roket Arayüzü - Ana Aviyonik

Bir roketin aviyonik sisteminden gelen verileri yer bilgisayarında karşılamak için hazırlanmış bir program. 

Karşılayabileceği veriler kısıtlıdır. 


## Karşılanan veriler
- İrtifa verisi
- Konum verileri
- 2 görev göstergesi
- Sensör Hata Göstergeleri
- Tam ekran modu

  
## Ortam Değişkenleri

Programda seçilen COM Port üzerinden gelmesi gereken veri aşağıdadır her bir satırda bu formattan farklı bir veri gelmemelidir.

A4321B40,8500C31,1500FKUX

`A4321` | İrtifa

`B40,8500` | Enlem

`C31,1500` | Boylam

`F` | Görev 1 Sonu

`K` | Görev 2 Sonu

`X` | GPS Sensöründen Hata gelmesi durumu
  
## Ekran Görüntüleri

![Uygulama Ekran Görüntüsü](https://github.com/yasirsharp/Orta-Irtifa-Roket-Arayuzu-Ana_A/blob/master/Orta_Irtifa_Asel10000_AnaAviyonik.png)
