using Microsoft.EntityFrameworkCore;
using PersonsInfoV2Api.Entities;
using PersonsInfoV2Api.IRepository;
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.Repository
{
    public class InstitutionCourseRepository : IInstitutionCourseRepository
    {
        private PersonsInfoV3NewContext _context;


        public InstitutionCourseRepository(PersonsInfoV3NewContext context)
        {
            _context = context;
        }


        // Deleting Institution Course based on InstitutionCourseId
        public async Task<int> DeleteInstitutionCourseByInstitutionCourseId(int institutionCourseId)
        {
            var a = _context.InstitutionCourses.Where(c => c.Id == institutionCourseId).FirstOrDefault();
            _context.InstitutionCourses.Remove(a);
            await _context.SaveChangesAsync();
            return 1;
        }

        // Getting Institution Course based on InstitutionCourseId
        public async Task<InstitutionCourse> GetInstitutionCourseByInstitutionCourseId(int institutionCourseId)
        {
            return await _context.InstitutionCourses.Where(c => c.Id == institutionCourseId).FirstOrDefaultAsync();
        }


        // Getting All Institution Courses
        public async Task<List<InstitutionCourse>> GetInstitutionCourse()
        {
            return await _context.InstitutionCourses.ToListAsync();
        }


        // Inserting  Institution Course
        public async Task<int> AddInstitutionCourse(InstitutionCourse institutionCourse)
        {
            _context.InstitutionCourses.Add(institutionCourse);
            await _context.SaveChangesAsync();
            return institutionCourse.Id;

        }


        // Updating Institution Course   
        public async Task<int> UpdateInstitutionCourse(InstitutionCourse institutionCourse)
        {
            _context.InstitutionCourses.Update(institutionCourse);
            await _context.SaveChangesAsync();
            return institutionCourse.Id;
        }



        //Adding  more than one Institution Courses
        public async Task<bool> AddRangeInstitutionCourseDetails(List<InstitutionCourse> institutionCourses)
        {
            try
            {
                if (institutionCourses != null)
                {
                    _context.InstitutionCourses.AddRange(institutionCourses);
                    if (_context != null)
                    {
                        await _context.SaveChangesAsync();
                    }
                    return true;

                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<int> UpdateRangeInstitutionCourse(List<InstitutionCourse> institutionCourse)
        {
            try
            {

                if (institutionCourse != null)
                {


                    _context.InstitutionCourses.UpdateRange(institutionCourse);
                    await _context.SaveChangesAsync();

                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {


            }
            return 0;
        }


        public async Task<bool> DeleteRangeInstitutionCourseDetails(List<InstitutionCourse> institutionCourses)

        {


            try
            {
                if(institutionCourses!=null && institutionCourses.Count>0)
                {
                    _context.InstitutionCourses.RemoveRange(institutionCourses);
                    await _context.SaveChangesAsync();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {

                return false;
            }



         

        }
    }
}
