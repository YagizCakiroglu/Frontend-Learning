// Daire alanını hesaplayan fonksiyon
const circleArea = (radius) => {
    const area = Math.PI * radius ** 2;
    console.log(`Daire alanı: ${area.toFixed(2)}`);
  };
  
  // Daire çevresini hesaplayan fonksiyon
  const circleCircumference = (radius) => {
    const circumference = 2 * Math.PI * radius;
    console.log(`Daire çevresi: ${circumference.toFixed(2)}`);
  };
  
  module.exports = { circleArea, circleCircumference };
  