using GymManager.Core.Members;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.ApplicationServices.Members
{
    public class MembersAppService : IMembersAppService
    {
        public List<Member> GetMembers()
        {
            //throw new NotImplementedException();
            List<Member> members = new List<Member>();

            members.Add(new Member
            {
                Name = "Michelle",
                LastName = "Marquez",
                BrithDay = new DateTime(2002, 7, 12),
                AllowsNewsLetter = true,
                CityId = 1,
                Email = "marquezmichel282@gmail.com"
            });

            members.Add(new Member
            {
                Name = "Israel",
                LastName = "Mendez",
                BrithDay = new DateTime(2002, 9, 20),
                AllowsNewsLetter = true,
                CityId = 1,
                Email = "ohmaMendez2@gmail.com"
            });

            members.Add(new Member
            {
                Name = "Jacqueline",
                LastName = "Gaspar",
                BrithDay = new DateTime(2002, 10, 26),
                AllowsNewsLetter = true,
                CityId = 1,
                Email = "jacqueGaspar@gmail.com"
            });

            members.Add(new Member
            {
                Name = "Bryan",
                LastName = "Resendiz",
                BrithDay = new DateTime(2002, 1, 30),
                AllowsNewsLetter = true,
                CityId = 1,
                Email = "chiken123@gmail.com"
            });

            members.Add(new Member
            {
                Name = "Ernesto",
                LastName = "Rocha",
                BrithDay = new DateTime(2002, 2, 14),
                AllowsNewsLetter = true,
                CityId = 1,
                Email = "ernestor@gmail.com"
            });

            members.Add(new Member
            {
                Name = "David",
                LastName = "Zuñiga",
                BrithDay = new DateTime(2003, 9, 19),
                AllowsNewsLetter = true,
                CityId = 1,
                Email = "deivid456gmail.com"
            });

            members.Add(new Member
            {
                Name = "Daniel",
                LastName = "Zuñiga",
                BrithDay = new DateTime(2003, 9, 19),
                AllowsNewsLetter = true,
                CityId = 1,
                Email = "dannyel789@gmail.com"
            });

            members.Add(new Member
            {
                Name = "Dulce",
                LastName = "Marquez",
                BrithDay = new DateTime(2007, 1, 14),
                AllowsNewsLetter = true,
                CityId = 1,
                Email = "dulcemarquez@gmail.com"
            });

            members.Add(new Member
            {
                Name = "Martin",
                LastName = "Lopez",
                BrithDay = new DateTime(2002, 5, 26),
                AllowsNewsLetter = true,
                CityId = 1,
                Email = "martinlop@gmail.com"
            });

            members.Add(new Member
            {
                Name = "Miguel",
                LastName = "Rios",
                BrithDay = new DateTime(1950, 7, 31),
                AllowsNewsLetter = true,
                CityId = 1,
                Email = "miguelrios@gmail.com"
            });

            return members;
        }
    }
}
