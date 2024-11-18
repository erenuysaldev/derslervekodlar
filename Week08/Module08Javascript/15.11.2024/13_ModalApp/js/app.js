const btnModalOpen = document.getElementById("btn-modal-open");
const mainModal = document.querySelector(".main-modal");
const btnModalYes = document.querySelector(".btn-modal-yes");
const btnModalNo = document.querySelector(".btn-modal-no");
const btnModalClose = document.querySelector(".btn-modal-close");

//Modal açma
btnModalOpen.addEventListener("click", function () {
    mainModal.classList.remove("main-modal-none");
});

//Evet butonuna tıklayınca kapatma
btnModalYes.addEventListener("click", function () {
    //Burada gerekli operasyonlar yapılabilir
    alert("Silme işlemi başarıyla tamamlanmıştır.");
    closeModal();
});


//Hayır butonuna tıklayınca kapatma
btnModalNo.addEventListener("click", closeModal);

//Close butonuna tıklayınca kapatma
btnModalClose.addEventListener("click", closeModal);

//Arka plana tıklayınca kapatma
//Eğer arka plana tıklayınca kapatma istenmiyorsa, bu kod hiç yazılmamalıdır.
mainModal.addEventListener("click", function (e) {
    if (e.target.classList.contains("main-modal")) {
        closeModal();
    }
})

//Modal kapatma fonksiyonu
function closeModal() {
    mainModal.classList.add("main-modal-none");
}