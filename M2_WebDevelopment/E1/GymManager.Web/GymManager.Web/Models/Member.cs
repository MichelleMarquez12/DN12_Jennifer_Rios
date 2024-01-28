namespace GymManager.Web.Models
{
    //Estructura de la identidad de un modelo con sus propiedades que representan
    //los campos ligados a la vista
    public class Member
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime BrithDay { get; set; }

        //Es de tipo int porque en vista se presentara como liista despegable de ciudades
        //por ello se crea su modelo City.cs
        public int  CityId { get; set; }
        public string Email { get; set; }
        public bool AllowsNewsLetter { get; set; }
    }
}
