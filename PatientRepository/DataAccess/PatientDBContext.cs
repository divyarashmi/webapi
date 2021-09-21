using Microsoft.EntityFrameworkCore;
using PatientRepository.Model;
namespace PatientRepository.DataAccess
{
    public class PatientDBContext:DbContext
    {
        public PatientDBContext(DbContextOptions dbContextOptions):base (dbContextOptions)
        {
            
        }
        public DbSet<Patient> patients {get;set;}// for local manupulation.
        
        
    }
}