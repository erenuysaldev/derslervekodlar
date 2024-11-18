// let products = [];
// products[0]="iphone 12"
// products[1]="iphone 12"
// products[3]="iphone 12"
// products[5]="4580";
// products[7]=true;
// products[9]= new Date();
// products[10]="iphone 12"

// console.log(products);

let students = ["Işık","Elif","Medine","Hümeyra","Zehra"]
let result;
result = students.length;
result = students;
result = students.toString;
result = students.join(" - ");
result = result.split(" - ");

let products1= ["Ürün1","Ürün2","Ürün3"];
let products2 = ["Ürün4", "Ürün5"];

result = products1.concat(products2)

students.push("ahmet");
students.unshift("murat");
students.pop();
students.shift();
result = students;

let index = students.indexOf("Hümeyra");
students[index] = "Hümeyra";
students.splice(index, 1);
result=students;


console.log(result)