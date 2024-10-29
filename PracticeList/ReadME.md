# Davetli Listesi Konsol Uygulamasý

Bu proje, kullanýcýdan alýnan isimleri bir listeye ekleyen ve ardýndan ekrana yazdýran basit bir konsol uygulamasýdýr. Kullanýcý `q` yazarak isim ekleme iþlemini sonlandýrabilir ve tüm davetli listesi ekrana yazdýrýlýr.

## Özellikler

- Kullanýcýdan isim alma ve bir listeye ekleme
- `q` ile isim ekleme iþlemini sonlandýrma
- Tüm davetlilerin isimlerini ekrana yazdýrma


Kullaným

Uygulama çalýþtýðýnda, kullanýcýdan davet etmek istediði kiþilerin isimlerini girmesi istenir.
Ýsimleri tek tek girin. Ýsimlerin her biri Enter tuþuna basýldýðýnda listeye eklenecektir.
Ýsim eklemeyi bitirmek için q yazýn ve Enter tuþuna basýn.
Uygulama, tüm girilen isimleri "Davetlilerin listesi:" baþlýðý altýnda ekrana yazdýracaktýr.
Kod Açýklamasý

List<string> list = new List<string>();: Boþ bir string listesi oluþturur, davetli isimlerini bu listeye ekler.
while döngüsü: Kullanýcýdan sürekli olarak isim alýr. Kullanýcý q yazarak döngüyü sonlandýrabilir.
list.Add(invite);: Kullanýcýdan alýnan her ismi listeye ekler.
foreach döngüsü: Listedeki tüm isimleri tek tek ekrana yazdýrýr.

Lütfen davet etmek istediðiniz kiþilerin isimlerini giriniz (Ýþleminiz bittiðinde 'q' yazýnýz): Ali
Lütfen davet etmek istediðiniz kiþilerin isimlerini giriniz (Ýþleminiz bittiðinde 'q' yazýnýz): Ayþe
Lütfen davet etmek istediðiniz kiþilerin isimlerini giriniz (Ýþleminiz bittiðinde 'q' yazýnýz): Mehmet
Lütfen davet etmek istediðiniz kiþilerin isimlerini giriniz (Ýþleminiz bittiðinde 'q' yazýnýz): q

Davetlilerin listesi:
Ali
Ayþe
Mehmet
