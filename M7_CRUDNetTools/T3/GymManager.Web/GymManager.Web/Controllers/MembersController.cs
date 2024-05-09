
using GymManager.ApplicationServices.Members;
using GymManager.Core.Members;
using GymManager.Web.Accounts.Dto;
using GymManager.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace GymManager.Web.Controllers
{
    [Authorize]
    public class MembersController : Controller
    {
        private readonly IMembersAppService _membersAppService;

        public MembersController(IMembersAppService membersAppService)
        {
            _membersAppService = membersAppService;

        }

        public async Task<IActionResult> Index()
        {
            
            List<MemberDto> members = await _membersAppService.GetMembersAsync();

            MemberListViewModel viewModel = new MemberListViewModel();

            viewModel.NewMembersCount = 2;
            viewModel.Members = members;

            Log.Information("User executed Member's Index");

            return View(viewModel);
        }

        public IActionResult Create()
        {
            return View();
        }

        public async Task<IActionResult> Edit(int memberId)
        {
            MemberDto member = await _membersAppService.GetMemberAsync(memberId);

            MemberListViewModel viewModel = new MemberListViewModel();

            return View(member);
        }


        public async Task<IActionResult> Delete(int memberId)
        {
            await _membersAppService.DeleteMemberAsync(memberId);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> SearchMembershipDetailsList(int id)
        {
            try
            {
                // Obtener el miembro por su ID
                MemberDto member = await _membersAppService.GetMemberByIdAsync(id);

                // Verificar si se encontró el miembro
                if (member != null)
                {
                    // Devolver la vista con los detalles del miembro
                    return View("MemberDetails", member);
                }
                else
                {
                    // Si no se encontró el miembro, mostrar un mensaje de error o redirigir a una vista de error
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir
                var errorMessage = new { error = ex.Message };
                return Json(errorMessage);
            }
        }


        [HttpPost]
        public async Task<IActionResult> Create(MemberDto member)
		{
            await _membersAppService.AddMemberAsync(member);
			return RedirectToAction("Index");
		}

        //[HttpPost]
        //public async Task<IActionResult> Edit(int id, int membershipTypesId)
        //{
        //    // Obtener el miembro por su ID
        //    Member member = await _membersAppService.GetMemberAsync(id);

        //    // Actualizar solo la membresía
        //    member.MembershipTypes_Id = membershipTypesId;

        //    // Guardar los cambios
        //    await _membersAppService.EditMemberAsync(member);

        //    // Redirigir a la acción Index o a donde desees
        //    return RedirectToAction("Index");
        //}

        [HttpPost]
        public async Task<IActionResult> Edit(MemberDto member)
        {
            await _membersAppService.EditMemberAsync(member);
            return RedirectToAction("Index");
        }


    }
}
