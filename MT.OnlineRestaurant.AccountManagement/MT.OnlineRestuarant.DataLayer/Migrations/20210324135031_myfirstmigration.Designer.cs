﻿// <auto-generated />
using System;
using MT.OnlineRestaurant.DataLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MT.OnlineRestuarant.DataLayer.Migrations
{
    [DbContext(typeof(CustomerManagementContext))]
    [Migration("20210324135031_myfirstmigration")]
    partial class myfirstmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MT.OnlineRestaurant.DataLayer.Context.LoggingInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ActionName")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasDefaultValueSql("('')");

                    b.Property<string>("ControllerName")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasDefaultValueSql("('')");

                    b.Property<string>("Description")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValueSql("('')");

                    b.Property<DateTime?>("RecordTimeStamp")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("('')");

                    b.HasKey("Id");

                    b.ToTable("LoggingInfo");
                });

            modelBuilder.Entity("MT.OnlineRestaurant.DataLayer.Context.TblCustomer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Address")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValueSql("('')");

                    b.Property<string>("Email")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(225)
                        .HasColumnType("nvarchar(225)")
                        .HasDefaultValueSql("('')");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(225)
                        .HasColumnType("nvarchar(225)")
                        .HasDefaultValueSql("('')");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(225)
                        .HasColumnType("nvarchar(225)")
                        .HasDefaultValueSql("('')");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasDefaultValueSql("('')");

                    b.Property<string>("Password")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(225)
                        .HasColumnType("nvarchar(225)")
                        .HasDefaultValueSql("('')");

                    b.Property<string>("PasswordKey")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RecordTimeStamp")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("((0))");

                    b.Property<DateTime>("RecordTimeStampCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("((0))");

                    b.Property<int>("UserCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("((0))");

                    b.Property<int>("UserModified")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("((0))");

                    b.HasKey("Id");

                    b.ToTable("tblCustomer");
                });
#pragma warning restore 612, 618
        }
    }
}
