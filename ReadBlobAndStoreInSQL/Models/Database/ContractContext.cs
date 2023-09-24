using Microsoft.EntityFrameworkCore;

namespace ReadBlobAndStoreInSQL.Models.Database
{
    public partial class ContractContext : DbContext
    {
        public ContractContext()
        {
        }

        public ContractContext(DbContextOptions<ContractContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblContract> TblContracts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
