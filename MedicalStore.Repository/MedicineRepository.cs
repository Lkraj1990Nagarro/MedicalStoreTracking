using MedicalStore.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStore.Repository
{
    public class MedicineRepository: IMedicineRepository
    {
        private MedicineContext _context;
        public MedicineRepository(MedicineContext context)
        {
            _context = context;
        }

        public async Task<ResponseMessage> CreateEditMedicine(Medicine medicine)
        {
            if (medicine.Id == 0)
            {
                _context.Medicine.Add(medicine);
            }
            else
            {
                var record = _context.Medicine.FirstOrDefaultAsync(a=>a.Id==medicine.Id).Result;
                record.Name = medicine.Name;
                record.Price = medicine.Price;
                record.Brand = medicine.Brand;
                record.Quantity = medicine.Quantity;
                record.ExpiryDate = medicine.ExpiryDate;
                record.Notes = medicine.Notes;
                _context.Medicine.Update(medicine);
            }
           int flag= await _context.SaveChangesAsync();
            return flag >= 1 ? new ResponseMessage(true,"Record saved") : new ResponseMessage(false, "Record not saved");
        }

        public IAsyncEnumerable<Medicine> GetMedicineList()
        {
           return _context.Medicine.AsAsyncEnumerable();
        }
    }
}
