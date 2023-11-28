const Koa = require('koa');
const app = new Koa();

app.use(async (ctx) => {
    if (ctx.path === '/') {
      ctx.body = '<h1>index sayfasına hoşgeldiniz</h1>';
    } else if (ctx.path === '/hakkimda') {
      ctx.body = '<h1>hakkimda sayfasına hoşgeldiniz</h1>';
    } else if (ctx.path === '/iletisim') {
      ctx.body = '<h1>iletisim sayfasına hoşgeldiniz</h1>';
    } else {
      ctx.body = '<h1>Sayfa bulunamadı</h1>';
    }
  });
  
  const port = 3000;
  app.listen(port, () => {
    console.log(`Server http://localhost:${port} adresinde çalışıyor`);
  });