//function that initializes page components
(function () {
    //# se usa para hacer referencia a jquery
    $("#CityId").select2();

    //instancia del componene date con el plugin
    $("#BirthDay").datepicker({ "dateFormat": "dd-mm-yy"});
}());