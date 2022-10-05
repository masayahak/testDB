using System.Data.Entity;

namespace テストDB.Models
{
    public partial class テストDBContext : DbContext
    {
        public テストDBContext()
            : base("name=locaDbConnection")
        {
        }

        public virtual DbSet<M社員> M社員s { get; set; }
        public virtual DbSet<M得意先> M得意先s { get; set; }
        public virtual DbSet<M商品> M商品s { get; set; }
        public virtual DbSet<T売上> T売上s { get; set; }
        public virtual DbSet<T売上明細> T売上明細s { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<T売上>()
                .HasMany(e => e.T売上明細)
                .WithRequired(e => e.T売上)
                .HasForeignKey(e => e.売上ID);
        }
    }
}
