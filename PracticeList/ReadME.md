# Davetli Listesi Konsol Uygulamas�

Bu proje, kullan�c�dan al�nan isimleri bir listeye ekleyen ve ard�ndan ekrana yazd�ran basit bir konsol uygulamas�d�r. Kullan�c� `q` yazarak isim ekleme i�lemini sonland�rabilir ve t�m davetli listesi ekrana yazd�r�l�r.

## �zellikler

- Kullan�c�dan isim alma ve bir listeye ekleme
- `q` ile isim ekleme i�lemini sonland�rma
- T�m davetlilerin isimlerini ekrana yazd�rma


Kullan�m

Uygulama �al��t���nda, kullan�c�dan davet etmek istedi�i ki�ilerin isimlerini girmesi istenir.
�simleri tek tek girin. �simlerin her biri Enter tu�una bas�ld���nda listeye eklenecektir.
�sim eklemeyi bitirmek i�in q yaz�n ve Enter tu�una bas�n.
Uygulama, t�m girilen isimleri "Davetlilerin listesi:" ba�l��� alt�nda ekrana yazd�racakt�r.
Kod A��klamas�

List<string> list = new List<string>();: Bo� bir string listesi olu�turur, davetli isimlerini bu listeye ekler.
while d�ng�s�: Kullan�c�dan s�rekli olarak isim al�r. Kullan�c� q yazarak d�ng�y� sonland�rabilir.
list.Add(invite);: Kullan�c�dan al�nan her ismi listeye ekler.
foreach d�ng�s�: Listedeki t�m isimleri tek tek ekrana yazd�r�r.

L�tfen davet etmek istedi�iniz ki�ilerin isimlerini giriniz (��leminiz bitti�inde 'q' yaz�n�z): Ali
L�tfen davet etmek istedi�iniz ki�ilerin isimlerini giriniz (��leminiz bitti�inde 'q' yaz�n�z): Ay�e
L�tfen davet etmek istedi�iniz ki�ilerin isimlerini giriniz (��leminiz bitti�inde 'q' yaz�n�z): Mehmet
L�tfen davet etmek istedi�iniz ki�ilerin isimlerini giriniz (��leminiz bitti�inde 'q' yaz�n�z): q

Davetlilerin listesi:
Ali
Ay�e
Mehmet
