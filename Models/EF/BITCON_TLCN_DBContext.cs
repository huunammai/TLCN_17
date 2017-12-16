namespace Models.EF
{
	using System;
	using System.Data.Entity;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Linq;

	public partial class BITCON_TLCN_DBContext : DbContext
	{
		public BITCON_TLCN_DBContext()
			: base("name=BITCON_TLCN_DBContext")
		{
		}

		public virtual DbSet<ADMIN> ADMINs { get; set; }
		public virtual DbSet<USER> USERs { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<ADMIN>()
				.Property(e => e.Username)
				.IsFixedLength()
				.IsUnicode(false);

			modelBuilder.Entity<ADMIN>()
				.Property(e => e.Password)
				.IsFixedLength()
				.IsUnicode(false);
		}
	}
}
