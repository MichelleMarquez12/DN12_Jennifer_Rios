using GymManager.Accounts.Dto;
using GymManager.Core.Members;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace GymManager.Web.Models
{
    public class EquipamentTypeListViewModel
    {
        public int NewEquipamentTypeCount { get; set; }

        public List<EquipamentTypeDto> EquipamentTypes { get; set; }
    }
}
