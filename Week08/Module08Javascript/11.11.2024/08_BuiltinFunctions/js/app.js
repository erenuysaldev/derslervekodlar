// let title = "String Functions";

// console.log("Başlık:" + title);
// console.log("Uzunluk:" + title.length);
// console.log("Başlığın 3.Karakteri:"+title.charAt(2));
// console.log("BAŞLIK:"+title.toUpperCase());
// console.log("başlık:"+title.toLowerCase());
// console.log("başlığın ilk 6 karakteri:"+title.slice(0,6));
// console.log("başlığın 8. karakterinden sonrası:"+title.slice(7));
// console.log("Yerine koy:"+title.replace("n","N"));
// let message="       Merhaba";
// console.log("Trim Left:" + message.trimStart());
// console.log("Trim Right:" + message.trimEnd());
// console.log("Trim:" + message.trim());
// console.log("g harfi kaçıncı sırada ?:" + title.indexOf("-"));
// console.log("S harfi ile başlıyor mu ?:" + title.startsWith("St"))
// console.log("S harfi ile bitiyor mu ?:" + title.endsWith("s"))

// let title ="Başakşehir Futbol Kulubü Tur Atladı";

// let titleArray = title.split(" ");
// let titleResult = titleArray.join("-");
// console.log(titleResult)
//*****Number ******\

// let result;

// result = parseInt(10.78);
// result = parseInt("10.78");
// result = parseInt("10.78");
// result = parseFloat("10.78fdsdf");

// let number=10.387450;
// result = number.toFixed(4);
// result = number.toPrecision(4);

// result =Math.round(2.4);
// result =Math.round(2.5);
// result =Math.ceil(2.1);
// result =Math.floor(2.9);
// result = Math.pow(5,5)
// result = Math.pow(5,2)
// result = Math.sqrt(25)//karekök
// result = Math.abs(40)//mutlak değer
// result = Math.min(12,13,14,15,1342,131212); //min değer
// result = Math.max(12,13,14,15,1342,131212); //max değer

// result = Math.random();
// result = parseInt(Math.random() *100)+1;

// console.log(result);
// date



let result;
let not;
now = new Date();
// result = now;

// result = now.getDate();
// result =now.getMonth();
// result =now.getDay();
// result =now.getFullYear();
// result =now.getHours();
// result =now.getTime();
let birthDate = new Date(1975,6,16); 

let year = birthDate.getFullYear(); //1975
let month = birthDate.getMonth();//6
let day = birthDate.getDate();//!6
result = "Sen " + year + "yılının " + (month + 1 ) + ".ayının " + day + ".gününde doğmuşssun.";
console.log(result);