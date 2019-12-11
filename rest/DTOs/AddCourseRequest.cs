using Common.Attr;
using Common.BaseRequestModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace rest.DTOs
{
    public class AddCourseRequest: BaseRequestModel
    {
        [Required("learning.pages.addCourse.titleWasRequired")]
        public string Title {get; set;}
        public string Description { get; set; }

    }
}