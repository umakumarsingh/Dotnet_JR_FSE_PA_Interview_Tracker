using InterviewTracker.BusinessLayer.Interfaces;
using InterviewTracker.BusinessLayer.Services.Repository;
using InterviewTracker.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTracker.BusinessLayer.Services
{
    public class InterviewTrackerServices : IInterviewTrackerServices
    {
        /// <summary>
        /// Creating Referance variable of IInterviewTrackerRepository
        /// Injecting in InterviewTrackerServices constructor
        /// </summary>
        private readonly IInterviewTrackerRepository _interviewTR;

        public InterviewTrackerServices(IInterviewTrackerRepository interviewTrackerRepository)
        {
            _interviewTR = interviewTrackerRepository;
        }
        /// <summary>
        /// Add New Interview in InMemoryDb calling by InterviewTrackerRepository method
        /// </summary>
        /// <param name="interview"></param>
        /// <returns></returns>
        public async Task<Interview> AddInterview(Interview interview)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Delete a interview form InMemoryDb
        /// </summary>
        /// <param name="interviewId"></param>
        /// <returns></returns>
        public async Task<bool> DeleteInterviewById(int interviewId)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get all Interview from InMemoryDb
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Interview>> GetAllInterview()
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// get a interview by interviewId
        /// </summary>
        /// <param name="interviewId"></param>
        /// <returns></returns>
        public Interview GetInterviewrById(int interviewId)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get interview By Interview name or Interviewer Name 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Interview>> InterviewByName(string name)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get total count of inteview in InMemoryDb
        /// </summary>
        /// <returns></returns>
        public int TotalCount()
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Update Interview in InMemoryDb
        /// </summary>
        /// <param name="interview"></param>
        /// <returns></returns>
        public async Task<Interview> UpdateInterview(Interview interview)
        {
            //Do code here
            throw new NotImplementedException();
        }
    }
}
