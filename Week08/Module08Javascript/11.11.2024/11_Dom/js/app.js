// DOM-Document Object Modal

//1-Single Element

// let result;
// result = document.getElementById("task-list");
// result = document.querySelector("#task-list");
// result.style.backgroundColor ="blue"
// result.stylecolor="white"
// let baslik = document.getElementById("page-title").
// document.getElementById("page-title").style.color="green";
// document.getElementById("page-title").style.fontFamily="Tahomoa";
// document.getElementById("page-title").style.backgroundColor="Yellow";
// document.getElementById("page-title").style.padding="15px";
//const taskItem = document.querySelector("#task-list-2 .task-item");

// console.log(taskItem);
//2)multi elements
// let result;
// result = document.getElementsByClassName("card-title");
// result = document.getElementsByClassName("task-item");
// result = document.getElementByTagName("div");
// result = document.getElementByTagName("ul")

// result= document.querySelectorAll(".task-item");
// result =document.querySelectorAll("div");

// console.log(result)
//ödev htmlcollection ile nodelist arasındaki farklılıkları benzerlikleri araştırın

//3 traversing
let result;
// const taskList =document.getElementById("task-list")
// result = taskList.children;
// const cardHeader =document.querySelector(".card-header");
// result = cardHeader.children;

// const body=document.querySelector("body")
// result = body.children
// const taskList =document.getElementById("task-list")
// result= taskList.firstElementChild;
// result= taskList.lastElementChild;
// result= taskList.firstChild;
// result = taskList.children[2];
const firstTask = document.getElementById("task-list").firstElementChild;
result = firstTask.textContent;
result =firstTask.nextElementSibling;
result =result.previousElementSibling.textContent;
console.log(result);