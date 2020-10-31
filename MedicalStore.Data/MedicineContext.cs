using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalStore.Data
{
    public class MedicineContext:DbContext
    {
        public MedicineContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Medicine> Medicine { get; set; }
    }
}
