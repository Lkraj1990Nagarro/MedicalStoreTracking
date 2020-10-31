using MedicalStore.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStore.Repository
{
    public interface IMedicineRepository
    {
       public Task<ResponseMessage> CreateEditMedicine(Medicine medicine);
        public IAsyncEnumerable<Medicine> GetMedicineList();
    }
}
