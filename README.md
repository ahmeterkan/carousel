# Atlıkarınca
<p>
  Bir lunaparkta atlı karınca var. Atlı karıncaya her seferinde k kişi binebiliyor. Atlı karınca bir gün içerisinde R defa çalışıyor.
</p>
<p>
  Atlı karıncaya binmek isteyen N adet grup var. Her grupta 1 veya daha fazla kişi bulunabiliyor.
</p>
<p>
  Her turda, sıradaki ilk gruptan başlayarak atlı karıncaya biniliyor. Eğer bir grubun tamamı için yer kalmadıysa daha fazla kişi binmeden   tur başlıyor. Dolayısıyla atlı karınca tam dolmadan da çalışabiliyor. Tur bittikten sonra atlı karıncaya binen gruplar, bindikleri         sırada, kuyruğun en arkasına yeniden katılıyor.
</p>
<p>
  Atlı karıncaya her binen kişi 1 TL’ye bilet alıyor.
<p>
  Örneğin, R=4, k=6 varsayalım. Atlı karıncaya binecek dört grup var ve bunların kişi sayıları 1, 4, 2, 1. İlk turda ilk iki grup           sığabilir [1,4]. İlk tur bitince bu iki grup sıranın en sonuna geçecek ve sıra 2, 1, 1, 4 haline gelecek. İkinci turda [2, 1, 1]           şeklinde 4 kişi sığabilecek. Şimdi sıra 4, 2, 1, 1 haline geldi. Üçüncü turda atlı karıncaya 6 kişi binecek [4, 2]. Sıra 1, 1, 4, 2       oldu. Dördüncü ve son turda altı kişi binecek, [1, 1, 4]. Atlı karınca toplamda 21 lira kazanmış oldu.
</p>
<h3>Input</h3>
<p>
  İlk satırda boşlukla ayrılmış 3 adet rakam yer alacak: R, k ve N. İkinci satırda boşlukla ayrılmış şekilde N adet rakam yer alacak. Bu     rakamlar gruplardaki kişi sayısını belirtecek. Örnek Input
</p>
<p>
 R=4, k=6, N=4<br/>
  Rakamlar= 
  1, 4, 2, 1
</p>
<h3>Output</h3>
<p>
  Program toplam kazanılan parayı yazacak.
</p>
