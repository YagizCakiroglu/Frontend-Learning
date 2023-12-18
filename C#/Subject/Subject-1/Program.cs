// Operatörler

// 1- Aritmetik Operatörler (+,-,*,/,%,++,--)

// int a = 10;
// int b = 20;
// int val;

// val = a + b; // 30
// val = a - b; // -10
// val = a * b; // 200
// val = a / b; // 0
// val = b % a; // 0
// val = a++;
// val = ++a;
// val = --a;

// System.Console.WriteLine("a: "+ a);
// System.Console.WriteLine("value: "+ val);

// 2- Atama Operatörleri (=,+=,-=,*=,/=,%=)

// int x = 5, y = 10, z=20;
// double val;

// x += 5;
// x -= 5;
// x *= 5;
// x /= 5;
// x %= 5;

// val = Math.Pow(2,5);
// val = Math.Sqrt(25);
// val = Math.Abs(-10);
// val = Math.Round(4.4);
// val = Math.Round(4.5);
// val = Math.Round(4.6);
// val = Math.Ceiling(4.6);
// val = Math.Floor(5.5);

// System.Console.WriteLine($"x: {x} y: {y} z: {z}");
// System.Console.WriteLine(val);

// 3- Karşılaştırma Operatörleri (==,!=,<,>,<=,>=,?:)

// password,username => database
// '12345','yagizcan'

// int a=5, b=5, c=10,d=4;
// string username = "yagizcan";
// string password = "123456";

// var result = (a == b);
// result = (a == c);
// result = (username == "ygzcan");
// result = (password == "123456");
// result = (a != b);
// result = (a != c);
// result = (a > c);
// result = (c > a);
// result = (a >= b);
// result = (a <= b);

// string sonuc = (a == b)?"a=b":"a!=b";
// sonuc = (username == "yagizcan")?
//                      (password == "123456")?"username doğru ve parola doğru":"username doğru ve parola yanlış":
//                      (password == "123456")?"username yanlış ve parola doğru":"username yanlış ve parola yanlış";
           

// Console.WriteLine(sonuc);
// Console.WriteLine("result: "+result);

 // 4- Mantıksal Operatörler (&&,||,!)
            int x = 6;

            int hak = 0;
            char devammi='e';
            // and (&&)
            // true && true => true
            // false && true => false
            // false || false => false

            var result = (x>5) && (x<10); 
            result = (hak>0) && (devammi=='e');

            // or (||)
            // true || true => true
            // false || true => true
            // false || false => false

            result = (x > 0) || (x % 2 == 0);

            // not (!)
            // true => false
            // false => true

            result = !(x>0);

            // x, 5-10 arasında olan bir çift sayı mıdır?
            result = ((x>5) && (x<10)) && (x%2==0); // (true && true) && true

            Console.Write(result);