var ogrenci1Ad = "Ada";
var ogrenci1Soyad = "Bilgi";
var ogrenci1dogumTarihi = "2010";
var ogrenci1Matematik1 = 70;
var ogrenci1Matematik2 = 70;
var ogrenci1Matematik3 = 80;
var ogrenci1ortalama = (ogrenci1Matematik1 + ogrenci1Matematik2 + ogrenci1Matematik3) / 3
console.log(parseFloat(ogrenci1ortalama));
console.log(typeof ogrenci1ortalama);
console.log(ogrenci1ortalama >= 50);

var ogrenci2Ad = "Yiğit";
var ogrenci2Soyad = "Bilgi";
var ogrenci2dogumTarihi = "2012";
var ogrenci2Matematik1 = 40;
var ogrenci2Matematik2 = 40;
var ogrenci2Matematik3 = 50;
var ogrenci2ortalama = (ogrenci2Matematik1 + ogrenci2Matematik2 + ogrenci2Matematik3) / 3
console.log(parseFloat(ogrenci2ortalama));
console.log(typeof ogrenci2ortalama);
console.log(ogrenci2ortalama >= 50);


var suankiYil = new Date().getFullYear();


var ogrenci1_yas = suankiYil - parseInt(ogrenci1dogumTarihi);
var ogrenci2_yas = suankiYil - parseInt(ogrenci2dogumTarihi);
console.log(ogrenci1_yas);
console.log(ogrenci2_yas);
