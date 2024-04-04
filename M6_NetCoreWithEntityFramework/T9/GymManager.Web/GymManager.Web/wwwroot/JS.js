document.getElementById('modalButton').addEventListener('click', function () {
    var identificador = info.value;
    // Obtener la hora actual
    var fecha = new Date();
    var hora = fecha.getHours();
    var minutos = fecha.getMinutes();
    var segundos = fecha.getSeconds();
    // Crear el mensaje de la alerta
    var mensaje = "Hola: " + " " + identificador + " , a las: " + hora + ":" + minutos + ":" + segundos;
    $("#mensajeModal").text(mensaje);
    $('#myModal').modal('show');

    setTimeout(function () {
        $('#myModal').modal('hide');
    }, 3000);
});


$("#info").on('keydown', function (e) {
    var keycode = (e.keyCode ? e.keyCode : e.which);
    if (keycode == 13) {
        var identificador = info.value;
        var fecha = new Date();
        var hora = fecha.getHours();
        var minutos = fecha.getMinutes();
        var segundos = fecha.getSeconds();
        var mensaje1 = "Hola: " + " " + identificador + " , a las: " + hora + ":" + minutos + ":" + segundos;

        // Mostrar el mensaje en el modal
        $("#mensajeModal").text(mensaje1);

        // Mostrar el modal
        $('.modal').modal('show');

        // Cerrar el modal después de 3 segundos
        setTimeout(function () {
            $('.modal').modal('hide');
        }, 3000);
    }
});