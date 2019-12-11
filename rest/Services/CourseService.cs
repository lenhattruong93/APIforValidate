using Common.Validation;
using rest.Context;
using rest.DTOs;
using rest.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace rest.Services
{
    public class CourseService
    {
        public IList<Course> GetCourses()
        {
            var context = new RestDbContext();
            return context.Courses.ToList();
        }
        public void AddCourse(AddCourseRequest model)
        {
            //if (string.IsNullOrWhiteSpace(model.Title))
            //{
            //    throw new ValidationException("learning.pages.addCourse.titleWasRequired");
            //}
            if (!model.IsValid())
            {
                throw new ValidationException(model.GetValidationMessages());
            }
            var course = new Course();
            course.Description = model.Description;
            course.Title = model.Title;
            var context = new RestDbContext();
            context.Courses.Add(course);
            context.SaveChanges();

        }
    }
}