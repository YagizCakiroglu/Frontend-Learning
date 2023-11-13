var a = 5;
var b = 'a';
var c = true;
var d;
var e = [1, 2, 3];
var f = [1, 2, 3];
var g = [1, 'a', true];
var h = ['a', 5, false]; //tuple
var krediPayment = 0;
var havalePayment = 1;
var efterPayment = 2;
var Payment;
(function (Payment) {
})(Payment || (Payment = {}));
{
    kredi = 0, havale = 1, kapidaodeme = 2, eft = 3;
}
;
var kredi = Payment.kredi; // 0
var havale = Payment.havale; // 1
var havale = Payment.kapidaodeme; // 2
var eft = Payment.eft; // 3
