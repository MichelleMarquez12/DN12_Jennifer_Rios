(function() {
    // Crear un array con las mismas propiedades de la clase Customer de C#
    var customers = [
        { Name: "Michelle", RegistrationDate: "2024/01/29"},
        { Name: "David", RegistrationDate: "2024/02/14"},
        { Name: "Juan", RegistrationDate: "2023/05/19"},
        { Name: "Dulce", RegistrationDate: "2021/01/30"},
        { Name: "Melania", RegistrationDate: "2020/09/19"},
        { Name: "Daniel", RegistrationDate: "2019/11/20"},
        { Name: "Miguel", RegistrationDate: "2018/12/01"},
        { Name: "Mario", RegistrationDate: "2017/06/03"},
        { Name: "Esther", RegistrationDate: "2016/10/15"},
        { Name: "Daniela", RegistrationDate: "2015/07/12"}
    ];

    // Recorrer el array con el ciclo 'for' y agregar un tag <li> dentro de un tag <ul> en la pantalla por cada elemento
    var customerList = document.getElementById("customerList");
    for (var i = 0; i < customers.length; i++) {
        var listItem = document.createElement("li");
        listItem.textContent = "Nombre: " + customers[i].Name + ", Fecha de registro: " + customers[i].RegistrationDate;
        customerList.appendChild(listItem);
    }
} ());

(function () {

    var bv = new Bideo();
    bv.init({
        // Video element
        videoEl: document.querySelector('#background_video'),

        // Container element
        container: document.querySelector('body'),

        // Resize
        resize: true,

        // autoplay: false,
        

        // Array of objects containing the src and type
        // of different video formats to add
        src: [
            {
                src: '/lib/bideo/night.mp4',
                type: 'video/mp4'
            }
        ],

        // What to do once video loads (initial frame)
        onLoad: function () {
            document.querySelector('#video_cover').style.display = 'none';
        }
    });
}());