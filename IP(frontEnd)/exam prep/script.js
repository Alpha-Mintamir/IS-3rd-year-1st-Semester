var btn = document.getElementById("Click-Me")
var textbox = document.getElementById("textt")
var firstList = document.getElementById("hey")
var broo = document.createElement("li")
broo.innerHTML = "tetekteshal bro"
var secondList = document.getElementById("heyy")

var olList = document.getElementById("oredered_list")

btn.addEventListener("click", myFunc)

function myFunc(){
    var newEl = document.createElement("li")
    olList.appendChild(newEl)
    newEl.innerHTML = textbox.value
}

var removee = document.getElementById("remove")


removee.addEventListener("click", replace)
 
function replace(){
    olList.replaceChild(firstList, secondList);
}