using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterviewTracker.BusinessLayer.Services.Repository;
using InterviewTracker.BusinessLayer.ViewModels;
using InterviewTracker.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace InterviewTracker.Controllers
{
    public class InterviewController : Controller
    {
        /// <summary>
        /// Creating Referancce variable of IInterviewTrackerRepository and IUserInterviewTrackerRepository
        /// and injecting Referance into constructor
        /// </summary>
        private readonly IInterviewTrackerRepository _interview;
        private readonly IUserInterviewTrackerRepository _userTR;
        public InterviewController(IInterviewTrackerRepository interviewTrackerRepository, IUserInterviewTrackerRepository userInterviewTrackerRepository)
        {
            _interview = interviewTrackerRepository;
            _userTR = userInterviewTrackerRepository;
        }
        /// <summary>
        /// Add New Interview in InMemorydb
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult AddNewInterview()
        {
            //Do Code here
            return View();
        }
        /// <summary>
        /// Post method of AddNewInterview after AddNewInterview page is added.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> AddNewInterview(AddInterviewViewModel model)
        {
            //Do Code here
            return View();
        }
    }
}
