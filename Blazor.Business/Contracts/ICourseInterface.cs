using Blazor.Common;
using Blazor.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blazor.Business.Contracts
{
    public  interface ICourseInterface
    {
        public Task<Result<CourseDto>> CretaeCourse(CourseDto courseDto);
        public Task<Result<CourseDto>>  UpdateCourse ( int courseId, CourseDto courseDto);
        public Task<Result<CourseDto>> GetCourse(int courseId);
        public Task<Result<CourseDto>> DeleteCourse(int courseId);
        public Task<Result<IEnumerable<CourseDto>>> GetAllCourse();
    }
}
