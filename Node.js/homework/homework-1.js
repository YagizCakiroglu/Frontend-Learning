const radius = process.argv[2]; // Konsoldan girilen yarıçap değeri

if (isNaN(radius)) {
  console.log("Lütfen geçerli bir sayı girin.");
} else {
  const area = Math.PI * radius * radius; // Dairenin alanını hesapla
  console.log(`Yarıçapı ${radius} olan dairenin alanı: ${area}`);
}
