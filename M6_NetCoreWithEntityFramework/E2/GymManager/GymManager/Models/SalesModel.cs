using GymManager.Core.Members;

namespace GymManager.Web.Models
{
    public class SalesModel
    {

        public int Id { get; set; }

        public int Products_idProducts { get; set; }

        public int Members_idMembers  { get; set; }

        public int Cantidad {  get; set; }

        public DateTime Date {  get; set; }
    }
}
