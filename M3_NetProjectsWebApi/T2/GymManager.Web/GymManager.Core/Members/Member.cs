﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Core.Members
{
    public class Member
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime BrithDay { get; set; }

        //Es de tipo int porque en vista se presentara como liista despegable de ciudades
        //por ello se crea su modelo City.cs
        public int CityId { get; set; }
        public string Email { get; set; }
        public bool AllowsNewsLetter { get; set; }
    }
}
