﻿// <auto-generated />
using System;
using DiaryApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DiaryApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DiaryApp.Models.DiaryEntry", b =>
                {
                    b.Property<int>("EntryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EntryId"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(1500)
                        .HasColumnType("nvarchar(1500)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("EntryId");

                    b.ToTable("DiaryEntries");

                    b.HasData(
                        new
                        {
                            EntryId = 1,
                            Content = "Went running in the morning. I did 10km in an hour.",
                            Created = new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Went running"
                        },
                        new
                        {
                            EntryId = 2,
                            Content = "I did workouts in the morning, for about 40 minutes.",
                            Created = new DateTime(2025, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Morning workout"
                        },
                        new
                        {
                            EntryId = 3,
                            Content = "Went to the supermarket and bought vegetables and fruits for the week.",
                            Created = new DateTime(2025, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Grocery Shopping"
                        },
                        new
                        {
                            EntryId = 4,
                            Content = "Watched an inspiring documentary about space exploration.",
                            Created = new DateTime(2025, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Watched a Movie"
                        },
                        new
                        {
                            EntryId = 5,
                            Content = "Cooked homemade pasta with a delicious creamy sauce.",
                            Created = new DateTime(2025, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Tried a New Recipe"
                        },
                        new
                        {
                            EntryId = 6,
                            Content = "Had a relaxing yoga session in the evening.",
                            Created = new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Yoga Session"
                        },
                        new
                        {
                            EntryId = 7,
                            Content = "Finished reading 'The Alchemist' by Paulo Coelho.",
                            Created = new DateTime(2025, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Read a Book"
                        },
                        new
                        {
                            EntryId = 8,
                            Content = "Did a thorough cleaning of the entire house.",
                            Created = new DateTime(2025, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Cleaned the House"
                        },
                        new
                        {
                            EntryId = 9,
                            Content = "Had a lovely lunch with friends at a nearby cafe.",
                            Created = new DateTime(2025, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Met Friends"
                        },
                        new
                        {
                            EntryId = 10,
                            Content = "Planted a small sapling in the garden.",
                            Created = new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Planted a Tree"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
