using ExcelTest.Data;
using ExcelTest.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace ExcelTest.Repository
{
    public class DtoInfomation : IDtoInfomation
    {
        private readonly DataContext _db;

        public DtoInfomation(DataContext db)
        {
            _db = db;
        }

        public async Task<HttpResponseModel> Create(AllinformationDTO allinformationDTO)
        {
            Patients patients = new Patients();
             
            patients.PatientName = allinformationDTO.PatientName;

            await _db.Patients.AddAsync(patients);
            await _db.SaveChangesAsync();

            DiseasesInformation diseasesInformation = new DiseasesInformation();

            diseasesInformation.DiseasesName = allinformationDTO.DiseasesName;

            await _db.DiseasesInformation.AddAsync(diseasesInformation);
            await _db.SaveChangesAsync();

            NCD nCD = new NCD();
            nCD.NCDName = allinformationDTO.NCDName;

            await _db.NCDs.AddAsync(nCD);
            await _db.SaveChangesAsync();

            Allergies allergies = new Allergies();
            allergies.AllergiesName = allinformationDTO.AllergiesName;

            await _db.Allergies.AddAsync(allergies);
            await _db.SaveChangesAsync();

            return new HttpResponseModel(allinformationDTO);


        }
    }
}
