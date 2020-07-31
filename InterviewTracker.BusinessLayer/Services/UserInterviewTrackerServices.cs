using InterviewTracker.BusinessLayer.Interfaces;
using InterviewTracker.BusinessLayer.Services.Repository;
using InterviewTracker.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTracker.BusinessLayer.Services
{
    public class UserInterviewTrackerServices : IUserInterviewTrackerServices
    {
        /// <summary>
        /// Creating Referance variable of IUserInterviewTrackerRepository
        /// Injecting in UserInterviewTrackerServices constructor
        /// </summary>
        private readonly IUserInterviewTrackerRepository _interviewTR;

        public UserInterviewTrackerServices(IUserInterviewTrackerRepository interviewTrackerRepository)
        {
            _interviewTR = interviewTrackerRepository;
        }
        /// <summary>
        /// Delete a user from InMemoryDb
        /// </summary>
        /// <param name="UserId"></param>
        /// <returns></returns>
        public async Task<bool> DeleteUserById(int UserId)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// get All user from InMemoryDb
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<ApplicationUser>> GetAllUser()
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// get a user by userid
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public ApplicationUser GetUserById(int userId)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Register a new User in InMemoryDb
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<ApplicationUser> Register(ApplicationUser user)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Update a existing user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<ApplicationUser> UpdateUser(ApplicationUser user)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// get a user
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ApplicationUser> User()
        {
            //Do code here
            throw new NotImplementedException();
        }
    }
}
