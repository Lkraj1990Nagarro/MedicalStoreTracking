using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MedicalStore.Data;
using MedicalStore.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MedicalStore.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicineController : ControllerBase
    {
        private IMedicineRepository _repository;
        
        public MedicineController(IMedicineRepository repository)
        {
            this._repository = repository;

        }
        [HttpGet("GetAllMedicine")]
        public IAsyncEnumerable<Medicine> GetAllMedicine()
        {
            return _repository.GetMedicineList();
        }

        [HttpPost("CreateEditMedicine")]
        public async Task<ResponseMessage> CreateEditMedicine(Medicine medicine)
        {
            return await _repository.CreateEditMedicine(medicine);
           

        }
    }
}