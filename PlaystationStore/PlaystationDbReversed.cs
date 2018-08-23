namespace PlaystationStore
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PlaystationDbReversed : DbContext
    {
        public PlaystationDbReversed()
            : base("name=PlaystationDbReversed")
        {
        }

        public virtual DbSet<Table> Tables { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Table>()
                .Property(e => e.GameName)
                .IsUnicode(false);

            modelBuilder.Entity<Table>()
                .Property(e => e.GameGenric)
                .IsUnicode(false);
        }
    }
}
