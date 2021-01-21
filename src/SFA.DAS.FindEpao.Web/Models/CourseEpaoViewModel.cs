﻿using System;
using System.Collections.Generic;

namespace SFA.DAS.FindEpao.Web.Models
{
    public class CourseEpaoViewModel
    {
        public CourseListItemViewModel Course { set; get; }
        public EpaoDetailsViewModel Epao { get; set; }
        public int CourseEpaosCount { get; set; }
        public DateTime EffectiveFrom { get; set; }
        public IEnumerable<CourseListItemViewModel> OtherCourses { get; set; }
    }
}
