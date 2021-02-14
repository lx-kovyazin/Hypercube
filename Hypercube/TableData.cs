using System.Data.Entity;

namespace Database
{
	public class User
	{
		public const int numOfFields = 3;
		public int Id { get; set; }
		public string Name { get; set; }
		public int Age { get; set; }
	}

	class DatabaseContent : DbContext
	{
		private string schemaName = "public";
		public DatabaseContent() : base("DefaultConnect") { }
		public DbSet<User> Users { get; set; }
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.HasDefaultSchema(schemaName);
		}
	}
}
