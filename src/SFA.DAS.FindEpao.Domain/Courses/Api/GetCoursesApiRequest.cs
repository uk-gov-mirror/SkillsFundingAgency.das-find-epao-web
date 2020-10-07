﻿using SFA.DAS.FindEpao.Domain.Interfaces;

namespace SFA.DAS.FindEpao.Domain.Courses.Api
{
    public class GetCoursesApiRequest : IGetApiRequest
    {
        public string BuildGetUrl(string baseUrl) => $"{baseUrl}courses";
    }
}
