using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using RateMyTalk.Models;

namespace RateMyTalk.Migrations
{
    [DbContext(typeof(RateMyTalkDbContext))]
    partial class RateMyTalkDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RateMyTalk.Models.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Comments");

                    b.Property<int?>("TalkId");

                    b.Property<int>("Value");

                    b.HasKey("Id");

                    b.HasIndex("TalkId");

                    b.ToTable("Rating");
                });

            modelBuilder.Entity("RateMyTalk.Models.Talk", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<string>("Description");

                    b.Property<string>("Speaker");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Talks");
                });

            modelBuilder.Entity("RateMyTalk.Models.Rating", b =>
                {
                    b.HasOne("RateMyTalk.Models.Talk", "Talk")
                        .WithMany("Ratings")
                        .HasForeignKey("TalkId");
                });
        }
    }
}
