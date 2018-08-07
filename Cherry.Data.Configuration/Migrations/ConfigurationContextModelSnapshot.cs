﻿// <auto-generated />
using Cherry.Data.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Cherry.Data.Configuration.Migrations
{
    [DbContext(typeof(ConfigurationContext))]
    partial class ConfigurationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Cherry.Data.Configuration.Customers.Tenant", b =>
                {
                    b.Property<string>("Tag")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(255);

                    b.Property<string>("Adrress");

                    b.Property<string>("CityName");

                    b.Property<string>("NamedBy");

                    b.Property<string>("OfficialName");

                    b.Property<string>("PseudoName");

                    b.HasKey("Tag");

                    b.HasIndex("CityName");

                    b.ToTable("Tenants");
                });

            modelBuilder.Entity("Cherry.Data.Configuration.Locales.City", b =>
                {
                    b.Property<string>("Name")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Name");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("Cherry.Data.Configuration.Security.DatabaseLogin", b =>
                {
                    b.Property<string>("Name")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("IP");

                    b.Property<string>("Login");

                    b.Property<string>("Password");

                    b.HasKey("Name");

                    b.ToTable("DatabaseLogins");
                });

            modelBuilder.Entity("Cherry.Data.Configuration.Customers.Tenant", b =>
                {
                    b.HasOne("Cherry.Data.Configuration.Locales.City", "City")
                        .WithMany("Tenants")
                        .HasForeignKey("CityName");
                });
#pragma warning restore 612, 618
        }
    }
}
