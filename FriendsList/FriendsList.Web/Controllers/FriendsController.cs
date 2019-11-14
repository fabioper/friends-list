using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FriendsList.Domain.Entities;
using FriendsList.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FriendsList.Web.Controllers
{
    [Route("")]
    public class FriendsController : Controller
    {
        private readonly IRepository<Friend> friendsRepository;

        public FriendsController(IRepository<Friend> friendsRepository)
        {
            this.friendsRepository = friendsRepository;
        }

        [Route("")]
        public IActionResult Index()
        {
            var friends = friendsRepository.GetAll();

            return View(friends);
        }

        [Route("page2")]
        public IActionResult Page2()
        {
            var friends = friendsRepository.GetAll();

            return View(friends);
        }
    }
}