const fs = require('fs');

// Veri objesi
const employeeData = {
  name: 'Employee 1 Name',
  salary: 2000
};

// Veriyi JSON formatına dönüştür
const jsonData = JSON.stringify(employeeData);

// Dosyaya veriyi yazma işlemi (CREATE)
fs.writeFileSync('employees.json', jsonData);

// Veriyi dosyadan okuma işlemi (READ)
const data = fs.readFileSync('employees.json', 'utf8');
console.log('Okunan Veri:', JSON.parse(data));

// Yeni bir veri oluşturalım
const updatedEmployeeData = {
    name: 'Employee 2 Name',
    salary: 2500
  };
  
  // Yeni veriyi JSON formatına dönüştür
  const updatedJsonData = JSON.stringify(updatedEmployeeData);
  
  // Dosyayı güncelleme işlemi (UPDATE)
  fs.writeFileSync('employees.json', updatedJsonData);

  // Dosyayı silme işlemi (DELETE)
fs.unlinkSync('employees.json');
