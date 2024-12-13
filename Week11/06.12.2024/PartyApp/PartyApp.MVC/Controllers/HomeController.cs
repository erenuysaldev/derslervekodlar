using Microsoft.AspNetCore.Mvc;
using PartyApp.Business.Concrete;
using PartyApp.MVC.Models;
using System.Diagnostics;

namespace PartyApp.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly InvitationService _invitationService;

        public HomeController(InvitationService invitationService)
        {
            _invitationService = invitationService;
        }

        public IActionResult Index()
        {
            var invitations = _invitationService.GetAll();
            return View(invitations);
        }
        public IActionResult Join(int id)
        {
            var invitation = _invitationService.GetById(id);
            return View();
        }




    }



}
