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

        public static List<Member> Members = new List<Member>();
        public int AddMember(Member member)
        {
            member.Id = new Random().Next();
            Members.Add(member);
            return member.Id;
        }

        public void DeleteMember(int memberId)
        {
            var m = Members.Where(x => x.Id == memberId).FirstOrDefault();
            Members.Remove(m);
        }

        public void EditMember(Member member)
        {
            var m = Members.Where(x => x.Id == member.Id).FirstOrDefault();
            m.AllowsNewsLetter = member.AllowsNewsLetter;
            m.LastName = member.LastName;
            m.Name = member.Name; 
            m.Email = member.Email;
            m.BirthDay = member.BirthDay;
            m.CityId = member.CityId;
        }

        public Member GetMember(int memberId)
        {
            var m = Members.Where(x => x.Id == memberId).FirstOrDefault();
            return m;
        }

        public List<Member> GetMembers()
        {
            ////throw new NotImplementedException();
            //List<Member> members = new List<Member>();

            //members.Add(new Member
            //{
            //    Name = "Michelle",
            //    LastName = "Marquez",
            //    BirthDay = new DateTime(2002, 7, 12),
            //    AllowsNewsLetter = true,
            //    CityId = 1,
            //    Email = "marquezmichel282@gmail.com"
            //});

            //members.Add(new Member
            //{
            //    Name = "Israel",
            //    LastName = "Mendez",
            //    BirthDay = new DateTime(2002, 9, 20),
            //    AllowsNewsLetter = true,
            //    CityId = 1,
            //    Email = "ohmaMendez2@gmail.com"
            //});

            //members.Add(new Member
            //{
            //    Name = "Jacqueline",
            //    LastName = "Gaspar",
            //    BirthDay = new DateTime(2002, 10, 26),
            //    AllowsNewsLetter = true,
            //    CityId = 1,
            //    Email = "jacqueGaspar@gmail.com"
            //});

            //members.Add(new Member
            //{
            //    Name = "Bryan",
            //    LastName = "Resendiz",
            //    BirthDay = new DateTime(2002, 1, 30),
            //    AllowsNewsLetter = true,
            //    CityId = 1,
            //    Email = "chiken123@gmail.com"
            //});

            //members.Add(new Member
            //{
            //    Name = "Ernesto",
            //    LastName = "Rocha",
            //    BirthDay = new DateTime(2002, 2, 14),
            //    AllowsNewsLetter = true,
            //    CityId = 1,
            //    Email = "ernestor@gmail.com"
            //});

            //members.Add(new Member
            //{
            //    Name = "David",
            //    LastName = "Zuñiga",
            //    BirthDay = new DateTime(2003, 9, 19),
            //    AllowsNewsLetter = true,
            //    CityId = 1,
            //    Email = "deivid456gmail.com"
            //});

            //members.Add(new Member
            //{
            //    Name = "Daniel",
            //    LastName = "Zuñiga",
            //    BirthDay = new DateTime(2003, 9, 19),
            //    AllowsNewsLetter = true,
            //    CityId = 1,
            //    Email = "dannyel789@gmail.com"
            //});

            //members.Add(new Member
            //{
            //    Name = "Dulce",
            //    LastName = "Marquez",
            //    BirthDay = new DateTime(2007, 1, 14),
            //    AllowsNewsLetter = true,
            //    CityId = 1,
            //    Email = "dulcemarquez@gmail.com"
            //});

            //members.Add(new Member
            //{
            //    Name = "Martin",
            //    LastName = "Lopez",
            //    BirthDay = new DateTime(2002, 5, 26),
            //    AllowsNewsLetter = true,
            //    CityId = 1,
            //    Email = "martinlop@gmail.com"
            //});

            //members.Add(new Member
            //{
            //    Name = "Miguel",
            //    LastName = "Rios",
            //    BirthDay = new DateTime(1950, 7, 31),
            //    AllowsNewsLetter = true,
            //    CityId = 1,
            //    Email = "miguelrios@gmail.com"
            //});

            return Members;
        }
    }
}
