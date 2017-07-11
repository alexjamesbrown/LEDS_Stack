using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using AcronymVote.Models;

namespace AcronymVote.Migrations
{
    [DbContext(typeof(AcronymVoteDbContext))]
    [Migration("20170709225459_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AcronymVote.Models.Acronym", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Value")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Acronyms");
                });

            modelBuilder.Entity("AcronymVote.Models.Vote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AcronymId");

                    b.Property<DateTime>("Date");

                    b.Property<string>("IPAddress");

                    b.Property<int>("StackNameId");

                    b.HasKey("Id");

                    b.HasIndex("AcronymId");

                    b.ToTable("Vote");
                });

            modelBuilder.Entity("AcronymVote.Models.Vote", b =>
                {
                    b.HasOne("AcronymVote.Models.Acronym", "Acronym")
                        .WithMany("Votes")
                        .HasForeignKey("AcronymId");
                });
        }
    }
}
