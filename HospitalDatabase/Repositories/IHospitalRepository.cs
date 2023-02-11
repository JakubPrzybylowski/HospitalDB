using HospitalDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDatabase.Repositories
{
    public interface IHospitalRepository
    {
        public void CreateHospital(Hospital hospital);
        public void GetHospitals();
        public Hospital GetHospital(int id);
        public List<Hospital> UpdateHospital(int id);
        public void DeleteHospital(int id);
    }
}
