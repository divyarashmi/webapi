using System.Collections.Generic;
using PatientRepository.Model;
using System.Linq;
namespace PatientRepository.DataAccess
{
    public class PatientsRepository : IPatientsRepository
    {
        PatientDBContext patientDBContext;
        public PatientsRepository( PatientDBContext _patientDBContext)
        {
            patientDBContext=_patientDBContext;
        }
        void IPatientsRepository.AddPatientRecord(Patient patient)
        {
            patientDBContext.Add(patient);
            patientDBContext.SaveChanges();
        }

        void IPatientsRepository.DeletePatientRecord(string id)
        {
            var entity = patientDBContext.patients.FirstOrDefault(t => t.id == id);  
            patientDBContext.patients.Remove(entity);  
            patientDBContext.SaveChanges();  
        }

        List<Patient> IPatientsRepository.GetPatientRecords()
        {
             return patientDBContext.patients.ToList(); 
        }

        Patient IPatientsRepository.GetPatientSingleRecord(string id)
        {
             return patientDBContext.patients.FirstOrDefault(t => t.id == id);
        }

        void IPatientsRepository.UpdatePatientRecord(Patient patient)
        {
            patientDBContext.Update(patient);  
            patientDBContext.SaveChanges();  
        }
    }
}