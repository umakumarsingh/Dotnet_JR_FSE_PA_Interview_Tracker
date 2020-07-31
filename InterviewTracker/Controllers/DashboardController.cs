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
    public class DashboardController : Controller
    {
        /// <summary>
        /// Creating Referancce variable of IInterviewTrackerRepository and IUserInterviewTrackerRepository
        /// and injecting Referance into constructor
        /// </summary>
        private readonly IInterviewTrackerRepository _interviewTR;
        private readonly IUserInterviewTrackerRepository _userTR;
        public DashboardController(IInterviewTrackerRepository interviewTrackerRepository, 
            IUserInterviewTrackerRepository userInterviewTrackerRepository )
        {
            _interviewTR = interviewTrackerRepository;
            _userTR = userInterviewTrackerRepository;
        }
        /// <summary>
        /// Get all Interview From InMemory and display on AllInterviewAsync Page
        /// </summary>
        /// <param name="search"></param>
        /// <param name="page"></param>
        /// <returns></returns>
        public async Task<IActionResult> AllInterviewAsync(string search, int page = 1)
        {
            //Do Code here
            return View();
        }
        /// <summary>
        /// Edit Existing Interview to change or reschedule
        /// </summary>
        /// <param name="InterviewId"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult EditInterview(int InterviewId)
        {
            //Do Code here
            return View();
        }
        /// <summary>
        /// Post method after edit value is submitted
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> EditInterview(EditInterviewViewModel model)
        {
            //Do Code here
            return View();
        }
        /// <summary>
        /// Delete Interview from InMemory Db by passing ineterviewId
        /// </summary>
        /// <param name="interviewId"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult DeleteInterview(int interviewId)
        {
            //Do Code here
            return View();
        }
        /// <summary>
        /// Display confirmation message to delete Interview
        /// </summary>
        /// <param name="interviewId"></param>
        /// <returns></returns>
        [HttpPost, ActionName("DeleteInterview")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteInterviewConfirmed(int interviewId)
        {
            //Do Code here
            return View();
        }
    }
}
