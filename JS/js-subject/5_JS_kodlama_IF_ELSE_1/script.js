// yas >= 18
// mezuniyet == "lise" ya da mezuniyet == "üniversite"

let mezuniyet = "üniversite";
let yas = 20;

if (yas >= 18 && (mezuniyet == "lise" || mezuniyet == "üniversite")) {
    console.log("Ehliyet Alabilir.");
}else {
    console.log("Ehliyet Şartları Yetersiz.")
}

// and 
// true, true => true
// true, false => false

// or
// true, true => true
// true, false => true
// false, false => false