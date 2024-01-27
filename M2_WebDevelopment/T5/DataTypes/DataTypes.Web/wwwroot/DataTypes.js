//funcion del boton
/*function onButtonClick() {
    debugger;
}*/

function onButtonClick(evt) {
    var b = evt.currentTarget;

    var classes = b.classList;

    var isGreen = false;

    for (var i = 0; i < classes.length; i++) {
        var c = classes[i];

        if (c == "greenButton") {
            isGreen = true;
            break;
        }
    }

    if (isGreen) {
        b.className = "btn redButton"
    } else {
        b.className = "btn greenButton"
    }

    var t = document.getElementById("sampleTable");

    var currentHtml = t.innerHTML;
    t.innerHTML += "<tr><td>" + b.getAttribute("name") + "</td><td>" + new Date() + "</td></tr>";

    //var buttonName = b.getAttribute("name");
    //alert("Click on: " + buttonName);
}


//localización de HTML por tag
var buttons = document.getElementsByTagName("button");

//por ID
//var button = document.getElementById("button1");
//debugger;

//por nombre
//var button = document.getElementsByName("testButton")[0];
//debugger;

//por clase
//var buttons = document.getElementsByClassName("btn");

for (var i = 0; i < buttons.length; i++) {
    buttons[i].addEventListener("click", onButtonClick);
}


//debugger;

//agrega manejador al boton
//buttons.addEventListener("click", onButtonClick);
