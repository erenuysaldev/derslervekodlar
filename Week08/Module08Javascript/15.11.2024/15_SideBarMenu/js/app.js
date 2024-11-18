const menuLinks = document.querySelector(".menu-links");

function toggleNav(){
    if(windows.getComputedStyle(sideNav).width=="0"){
        sideNav.style.width="500px"
    }
}