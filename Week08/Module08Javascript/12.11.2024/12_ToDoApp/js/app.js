const txtTaskDescription = document.getElementById("txt-task-description");
const btnAddTask = document.getElementById("btn-add-task");
const filters = document.querySelectorAll("#filters span");
const btnClearAll = document.getElementById("btn-clear-all");
const taskList = document.getElementById("task-list");

let isEditMode = false; //Eğer bu değişken true ise Edit Mode aktiftir. Değil ise New Mode aktiftir.
let editedTaskId;//O anda güncelleme işlemi yapılmakta olan Task'in Id'sini tutacak.
let filterMode = "all"; //O sırada hangi görevlerin listeleneceği bilgisini tutacak.

let taskListArray = [
    { "id": 1, "taskDescription": "Görev 1", "status": "pending" },
    { "id": 2, "taskDescription": "Görev 2", "status": "pending" },
    { "id": 3, "taskDescription": "Görev 3", "status": "completed" },
    { "id": 4, "taskDescription": "Görev 4", "status": "pending" },
    { "id": 5, "taskDescription": "Görev 5", "status": "completed" }
];

// btnAddTask.addEventListener("click", function(){
//     //btnAddTask butonuna tıklandığı zaman çalışacak kodlar.
// });

btnAddTask.addEventListener("click", addTask);
btnClearAll.addEventListener("click",clearAll);

function displayTasks(mode) {
    taskList.innerHTML = "";
    if (taskListArray.length == 0) {
        taskList.innerHTML = `
                    <div class="alert alert-warning m-2" role="alert">
                        Henüz bir görev bulunmamaktadır.
                    </div>
        `;
    } else {
        for (const task of taskListArray) {
            if (mode == "all" || mode == task.status) {
                let completed = task.status == "completed" ? "checked" : "";
                let taskItemLi = `
                    <li class="list-group-item task-item" itemid="${task.id}">
                        <div class="d-flex align-items-center gap-2">
                            <input onclick="updateStatus(this);" class="form-check-input mt-0" type="checkbox" itemid="${task.id}" ${completed}>
                            <div class="input-group">
                                
                                <input class="form-control bg-white ${completed}" type="text" itemid="${task.id}" value="${task.taskDescription}" disabled>
                                
                                <button onclick="editTask(this);" itemid="${task.id}" class="btn btn-warning btn-sm">Düzenle</button>
                                
                                <button onclick="deleteTask(this);" itemid="${task.id}" class="btn btn-danger btn-sm">Sil</button>
                                
                            </div>
                        </div>
                    </li>
                `;
                taskList.insertAdjacentHTML("afterbegin", taskItemLi);
            }
        }
    }

}

function addTask(e) {
    //formun default olan özelliğini(sunucuya gidip gelip, sayfayı yeniden render etme) kapatır!
    e.preventDefault();
    let value = txtTaskDescription.value.trim();
    if (value != "") {
        let id = parseInt(Math.random() * 1000000);
        taskListArray.push({
            "id": id,
            "taskDescription": value,
            "status": "pending"
        });
        displayTasks(filterMode);
    } else {
        alert("Açıklama boş bırakılamaz!");
    }
    txtTaskDescription.value = "";
    txtTaskDescription.focus();
}

function editTask(clickedButton) {
    editedTaskId = clickedButton.getAttribute("itemid");
    let editedTask = clickedButton.previousElementSibling;
    if (!isEditMode) {
        editedTask.removeAttribute("disabled");
        clickedButton.innerText = "Kaydet";
        clickedButton.classList.remove("btn-warning");
        clickedButton.classList.add("btn-primary");
        editedTask.focus();
        isEditMode = true;
    } else {
        let editedTaskDescription = editedTask.value.trim();
        if (editedTaskDescription == "") {
            alert("Lütfen açıklamayı boş bırakmayınız!");
        } else {
            for (const task of taskListArray) {
                if (editedTaskId == task.id) {
                    task.taskDescription = editedTaskDescription;
                    break;
                }
            }
            editedTask.setAttribute("disabled", "disabled");
            clickedButton.innerText = "Düzenle";
            clickedButton.classList.add("btn-warning");
            clickedButton.classList.remove("btn-primary");
            isEditMode = false;
            setTask();
            displayTasks(filterMode);
            console.log(taskListArray)
        }

    }



}

function updateStatus(clickedCheckBox) {
    const updatedTaskId = clickedCheckBox.getAttribute("itemid");
    const newStatus = clickedCheckBox.checked ? "completed" : "pending";
    for (const task of taskListArray) {
        if (task.id == updatedTaskId) {
            task.status = newStatus;
            break;
        }
    }
    displayTasks(filterMode);
}

function deleteTask(clickedButton) {
    const deletedTaskId = clickedButton.getAttribute("itemid");
    let deletedTaskIndex;
    for (let i = 0; i < taskListArray.length; i++) {
        if (deletedTaskId == taskListArray[i].id) {
            deletedTaskIndex = i;
            break;
        }
    }
    const answer = confirm(`${taskListArray[deletedTaskIndex].taskDescription} görevi silinecektir!`);
    if (answer) {
        taskListArray.splice(deletedTaskIndex, 1);
        displayTasks(filterMode);
    }

}
function clearAll(){
    const answer= confirm("Tüm görevler silinecektir!");
    if (answer) {
        taskListArray = []; // Görev listesini temizle
        setTask(); // Güncellenmiş görev listesini localStorage'a kaydet
        displayTasks(filterMode); // Görev listesini ekranda güncelle
    }
}
function assignEventsToSpans(){
    for(const span of filters){
        span.addEventListener("click",function () {
            const activeSpan = document.querySelector("#filters span.active");
            activeSpan.classList.remove("active");
            span.classList.add("active");
            filterMode=span.id;
            displayTasks(filterMode);
        })
    }
}

function setTask(){
    localStorage.setItem("Tasks",JSON.stringify(taskListArray));
}

function getTasks(){
    taskListArray=JSON.parse(localStorage.getItem("Tasks"));
    if(taskListArray==null){
        
    }
}



setTask();
assignEventsToSpans();
displayTasks(filterMode);