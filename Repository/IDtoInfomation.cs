using ExcelTest.Models;

namespace ExcelTest.Repository
{
    public interface IDtoInfomation
    {
        public Task<HttpResponseModel> Create(AllinformationDTO allinformationDTO);
    }
}
