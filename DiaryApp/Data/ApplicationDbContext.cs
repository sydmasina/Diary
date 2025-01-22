using DiaryApp.Models;
using Microsoft.EntityFrameworkCore;
    
namespace DiaryApp.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<DiaryEntry> DiaryEntries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DiaryEntry>().HasData(
                new DiaryEntry { EntryId = 1, Title = "Went running", Content = "Went running in the morning. I did 10km in an hour.", Created = new DateTime(2025, 1, 20) },
                new DiaryEntry { EntryId = 2, Title = "Morning workout", Content = "I did workouts in the morning, for about 40 minutes.", Created = new DateTime(2025, 1, 19) },
                new DiaryEntry { EntryId = 3, Title = "Grocery Shopping", Content = "Went to the supermarket and bought vegetables and fruits for the week.", Created = new DateTime(2025, 1, 18) },
                new DiaryEntry { EntryId = 4, Title = "Watched a Movie", Content = "Watched an inspiring documentary about space exploration.", Created = new DateTime(2025, 1, 17) },
                new DiaryEntry { EntryId = 5, Title = "Tried a New Recipe", Content = "Cooked homemade pasta with a delicious creamy sauce.", Created = new DateTime(2025, 1, 16) },
                new DiaryEntry { EntryId = 6, Title = "Yoga Session", Content = "Had a relaxing yoga session in the evening.", Created = new DateTime(2025, 1, 15) },
                new DiaryEntry { EntryId = 7, Title = "Read a Book", Content = "Finished reading 'The Alchemist' by Paulo Coelho.", Created = new DateTime(2025, 1, 14) },
                new DiaryEntry { EntryId = 8, Title = "Cleaned the House", Content = "Did a thorough cleaning of the entire house.", Created = new DateTime(2025, 1, 13) },
                new DiaryEntry { EntryId = 9, Title = "Met Friends", Content = "Had a lovely lunch with friends at a nearby cafe.", Created = new DateTime(2025, 1, 12) },
                new DiaryEntry { EntryId = 10, Title = "Planted a Tree", Content = "Planted a small sapling in the garden.", Created = new DateTime(2025, 1, 11) }
            );


        }
    }
}
