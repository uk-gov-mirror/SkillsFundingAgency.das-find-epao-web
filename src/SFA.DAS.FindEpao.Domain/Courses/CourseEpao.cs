﻿using System.Collections.Generic;
using SFA.DAS.FindEpao.Domain.Epaos;

namespace SFA.DAS.FindEpao.Domain.Courses
{
    public class CourseEpao
    {
        public CourseListItem Course { get; set; }
        public EpaoDetails Epao { get; set; }
        public int CourseEpaosCount { get; set; }
        public IReadOnlyList<EpaoDeliveryArea> EpaoDeliveryAreas { get; set; }
        public IReadOnlyList<DeliveryArea> DeliveryAreas { get; set; }
    }
}
