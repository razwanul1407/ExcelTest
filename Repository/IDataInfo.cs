using ExcelTest.Models;

namespace ExcelTest.Repository
{
    public interface IDataInfo
    {
        Task<Patients> Create();
    }
}
