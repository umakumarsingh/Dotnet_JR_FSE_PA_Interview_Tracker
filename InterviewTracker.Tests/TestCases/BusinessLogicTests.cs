using InterviewTracker.BusinessLayer.Interfaces;
using InterviewTracker.BusinessLayer.Services;
using InterviewTracker.BusinessLayer.Services.Repository;
using Moq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace InterviewTracker.Tests.TestCases
{
    public class BusinessLogicTests
    {
        /// <summary>
        /// Creating Referance of all Service Interfaces and Mocking All Repository
        /// </summary>
        private readonly IInterviewTrackerServices _interviewTS;
        private readonly IUserInterviewTrackerServices _interviewUserTS;
        public readonly Mock<IInterviewTrackerRepository> service = new Mock<IInterviewTrackerRepository>();
        public readonly Mock<IUserInterviewTrackerRepository> serviceUser = new Mock<IUserInterviewTrackerRepository>();

        /// <summary>
        /// Injecting service object into Test class constructor
        /// </summary>
        public BusinessLogicTests()
        {
            _interviewTS = new InterviewTrackerServices(service.Object);
            _interviewUserTS = new UserInterviewTrackerServices(serviceUser.Object);
        }

        static BusinessLogicTests()
        {
            if (!File.Exists("../../../../output_business_revised.txt"))
                try
                {
                    File.Create("../../../../output_business_revised.txt").Dispose();
                }
                catch (Exception)
                {

                }
            else
            {
                File.Delete("../../../../output_business_revised.txt");
                File.Create("../../../../output_business_revised.txt").Dispose();
            }
        }
        //Write your own test cases
    }
}
