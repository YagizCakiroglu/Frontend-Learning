let posts = []; // Postları tutacak olan dizi

// Postları konsola yazdıran fonksiyon
function listPosts() {
  console.log("Postlar:");
  posts.forEach((post, index) => {
    console.log(`${index + 1}. ${post}`);
  });
  console.log("----------");
}

// Post ekleme fonksiyonu
function addPost(newPost) {
  posts.push(newPost);
  console.log(`"${newPost}" başlıklı yeni post oluşturuldu.`);
}

// Postları oluştur ve listele
listPosts();

// Yeni bir post ekle
addPost("Yeni Başlangıç: Blog Oluşturma");

// Postları tekrar listele
listPosts();