using Common.Data;
using Common.Validation;
using rest.DTOs;
using rest.Entity;
using rest.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace rest.Controllers
{
    [RoutePrefix("api/courses")]
    public class CoursesController : ApiController
    {
        [Route("")]
        [HttpGet()]
        public IList<Course> GetCourses()
        {
            var courseService = new CourseService();
            return courseService.GetCourses();
        } 
        [Route("addcourse")]
        [HttpPost()]
        public ResponseData AddCourse(AddCourseRequest model)
        {
            try
            {
                var coursService = new CourseService();
                coursService.AddCourse(model);
                return new ResponseData();
            }
            catch (ValidationException ex)
            {
                ResponseData res = new ResponseData();
                res.SetErrors(ex.ErrKeys);

                return res;
            }

        }         
        
    }
}
