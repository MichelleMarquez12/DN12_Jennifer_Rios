﻿using GymManager.Accounts.Dto;
using GymManager.ApplicationServices.Members;
using GymManager.Core.Members;
using GymManager.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GymManager.Web.Controllers
{
    [Authorize]
    public class EquipamentTypeController : Controller
    {
        private readonly IEquipamentTypeAppService _equipamentTypeAppService;
        public EquipamentTypeController(IEquipamentTypeAppService equipamentTypeAppService)
        {
            _equipamentTypeAppService = equipamentTypeAppService;
        }

        public async Task<IActionResult> Index()
        {

            List<EquipamentTypeDto> equipamentType = await _equipamentTypeAppService.GetEquipamentTypesAsync();
            EquipamentTypeListViewModel viewModel = new EquipamentTypeListViewModel();

            viewModel.NewEquipamentTypeCount = 2;
            viewModel.EquipamentTypes = equipamentType;

            return View(viewModel);
        }

        public IActionResult Create()
        {
            return View();
        }

        public async Task<IActionResult> Edit(int equipamentTypeId)
        {
            EquipamentTypeDto equipamentType = await _equipamentTypeAppService.GetEquipamentTypeAsync(equipamentTypeId);
            EquipamentTypeListViewModel viewModel = new EquipamentTypeListViewModel();

            return View(equipamentType);
        }

        public async Task<IActionResult> Delete(int equipamentTypeId)
        {
            await _equipamentTypeAppService.DeleteEquipamentTypeAsync(equipamentTypeId);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Create(EquipamentTypeDto equipamentType)
        {
            await _equipamentTypeAppService.AddEquipamentTypeAsync(equipamentType);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EquipamentTypeDto equipamentType)
        {
            await _equipamentTypeAppService.EditEquipamentTypeAsync(equipamentType);
            return RedirectToAction("Index");
        }
    }
}
