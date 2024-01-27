var element = document.getElementById("example");
var textExample = "this is a text";

//permite la instancia de una clase, de forma que devuelve el tipo de dato que es
element.innerHTML = typeof (textExample);

var aNumber = 10.333;
element.innerHTML = typeof (aNumber);

var complexObject = {
    name: "Israel",
    lastname: "Perez",
    age: 35

}

element.innerHTML = typeof (complexObject);

var u1 = "<u1>";

for (var i = 0; i < textExample.length; i++) {
    u1 += ( "<li>" + textExample[i] + "</li>");
}

u1 += "<u1>";

element.innerHTML = u1;

//conversion de string a entero
var data = "133333";
element.innerHTML = typeof (parseInt(data));

//la directiva debugger le indica al navegador que detenga la depuración del código
debugger;