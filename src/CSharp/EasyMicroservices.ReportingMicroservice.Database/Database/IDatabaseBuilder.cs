using Microsoft.EntityFrameworkCore;

namespace EasyMicroservices.ReportingMicroservice.Database
{
    public interface IDatabaseBuilder
    {
        void OnConfiguring(DbContextOptionsBuilder optionsBuilder);
    }
}
