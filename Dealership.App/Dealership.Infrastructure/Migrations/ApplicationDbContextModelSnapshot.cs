// <auto-generated />
using System;
using Dealership.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Dealership.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.8");

            modelBuilder.Entity("Dealership.Domain.Entities.Car", b =>
                {
                    b.Property<int>("CarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("BrandCarBrandId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ImageName")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ModelCarModelId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CarId");

                    b.HasIndex("BrandCarBrandId");

                    b.HasIndex("ModelCarModelId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("Dealership.Domain.Entities.CarBrand", b =>
                {
                    b.Property<int>("CarBrandId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CarBrandName")
                        .HasColumnType("TEXT");

                    b.HasKey("CarBrandId");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("Dealership.Domain.Entities.CarModel", b =>
                {
                    b.Property<int>("CarModelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CarModelName")
                        .HasColumnType("TEXT");

                    b.HasKey("CarModelId");

                    b.ToTable("Models");
                });

            modelBuilder.Entity("Dealership.Domain.Entities.Car", b =>
                {
                    b.HasOne("Dealership.Domain.Entities.CarBrand", "Brand")
                        .WithMany("Cars")
                        .HasForeignKey("BrandCarBrandId");

                    b.HasOne("Dealership.Domain.Entities.CarModel", "Model")
                        .WithMany("Cars")
                        .HasForeignKey("ModelCarModelId");

                    b.Navigation("Brand");

                    b.Navigation("Model");
                });

            modelBuilder.Entity("Dealership.Domain.Entities.CarBrand", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("Dealership.Domain.Entities.CarModel", b =>
                {
                    b.Navigation("Cars");
                });
#pragma warning restore 612, 618
        }
    }
}
