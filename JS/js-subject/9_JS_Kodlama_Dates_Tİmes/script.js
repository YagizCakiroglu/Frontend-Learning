let simdi = new Date(); // şimdiki tarih - saat

// Get Methods
sonuc = simdi;
sonuc = simdi.getDate();    // gün
sonuc = simdi.getDay();     // 0: pazar 6: cumartesi
sonuc = simdi.getFullYear(); // yıl
sonuc = simdi.getHours();   // saat
sonuc = simdi.getTime();

// Set Methods
// simdi.setFullYear(2025);
simdi.setMonth(7);          // 0: Ocak
simdi.setDate(15);

sonuc = simdi;

let dogumTarihi = new Date(1990, 5, 15);

// sonuc = simdi.getFullYear() - dogumTarihi.getFullYear();

let milisecond = simdi - dogumTarihi;
let saniye = milisecond / 1000;     // saniye
let dakika = saniye / 60;
let saat = dakika / 60;
let gun = saat / 24;

sonuc = gun;

console.log(sonuc);
console.log(typeof sonuc);








// https://www.w3schools.com/js/js_dates.asp,
// https://www.w3schools.com/js/js_date_formats.asp
// https://www.w3schools.com/js/js_date_methods.asp
// https://www.w3schools.com/js/js_date_methods_set.asp
// get : özellik değerini almak için bir Alıcı yöntemini karakterize etmek için kullanılır.
// set : özellik değerini ayarlamak için bir Ayarlayıcı yöntemini karakterize etmek için kullanılır.
// https://www.yusufsezer.com.tr/javascript-tarih-fonksiyonlari/#:~:text=getDay%20fonksiyonu%20haftan%C4%B1n%20ka%C3%A7%C4%B1nc%C4%B1%20g%C3%BCn,%2D6)%20oldu%C4%9Fu%20bilgisini%20verir.&text=JavaScript%20haftan%C4%B1n%20ilk%20g%C3%BCn%C3%BCn%C3%BC%20Pazar,ile%20haftan%C4%B1n%20g%C3%BCn%20ismini%20alabiliriz.
// setDate()	Ayın gününü ayarlar (1-31)
// setFullYear()	Yılı ayarlar (ay ve gün isteğe bağlı eklenebilir)
// setHours()	Saat bilgisini ayarlar (0-23)
// setMilliseconds()	Milisaniye bilgisini ayarlar (0-999)
// setMinutes()	Dakika bilgisin ayarlar (0-59)
// setMonth()	Ay bilgisini ayarlar (0-11)
// setSeconds()	Saniye bilgisin ayarlar (0-59)
// setTime()	Tarihi 1 Ocak , 1970’dan itibaren milisaniye olarak ayarlar