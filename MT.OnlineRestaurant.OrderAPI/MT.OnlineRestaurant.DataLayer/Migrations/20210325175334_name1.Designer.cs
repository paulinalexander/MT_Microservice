﻿// <auto-generated />
using System;
using MT.OnlineRestaurant.DataLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MT.OnlineRestaurant.DataLayer.Migrations
{
    [DbContext(typeof(OrderManagementContext))]
    [Migration("20210325175334_name1")]
    partial class name1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
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

            modelBuilder.Entity("MT.OnlineRestaurant.DataLayer.Context.TblFoodOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DeliveryAddress")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValueSql("('')");

                    b.Property<DateTime>("RecordTimeStamp")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("((0))");

                    b.Property<DateTime>("RecordTimeStampCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("((0))");

                    b.Property<int?>("TblCustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("tblCustomerID")
                        .HasDefaultValueSql("((0))");

                    b.Property<int?>("TblOrderStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("tblOrderStatusID")
                        .HasDefaultValueSql("((0))");

                    b.Property<int?>("TblPaymentTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("tblPaymentTypeID")
                        .HasDefaultValueSql("((0))");

                    b.Property<int?>("TblRestaurantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("tblRestaurantID")
                        .HasDefaultValueSql("((0))");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UserCreated")
                        .HasColumnType("int");

                    b.Property<int>("UserModified")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TblOrderStatusId");

                    b.HasIndex("TblPaymentTypeId");

                    b.ToTable("tblFoodOrder");
                });

            modelBuilder.Entity("MT.OnlineRestaurant.DataLayer.Context.TblFoodOrderMapping", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("RecordTimeStamp")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("((0))");

                    b.Property<DateTime>("RecordTimeStampCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("((0))");

                    b.Property<int?>("TblFoodOrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("tblFoodOrderID")
                        .HasDefaultValueSql("((0))");

                    b.Property<int?>("TblMenuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("tblMenuID")
                        .HasDefaultValueSql("((0))");

                    b.Property<int>("UserCreated")
                        .HasColumnType("int");

                    b.Property<int>("UserModified")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TblFoodOrderId");

                    b.ToTable("tblFoodOrderMapping");
                });

            modelBuilder.Entity("MT.OnlineRestaurant.DataLayer.Context.TblOrderPayment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("RecordTimeStamp")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("((0))");

                    b.Property<DateTime>("RecordTimeStampCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("Remarks")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValueSql("('')");

                    b.Property<int>("TblCustomerId")
                        .HasColumnType("int")
                        .HasColumnName("tblCustomerID");

                    b.Property<int>("TblFoodOrderId")
                        .HasColumnType("int")
                        .HasColumnName("tblFoodOrderID");

                    b.Property<int>("TblPaymentStatusId")
                        .HasColumnType("int")
                        .HasColumnName("tblPaymentStatusID");

                    b.Property<int>("TblPaymentTypeId")
                        .HasColumnType("int")
                        .HasColumnName("tblPaymentTypeID");

                    b.Property<string>("TransactionId")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("TransactionID")
                        .HasDefaultValueSql("('0000000000')");

                    b.Property<int>("UserCreated")
                        .HasColumnType("int");

                    b.Property<int>("UserModified")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TblFoodOrderId");

                    b.HasIndex("TblPaymentStatusId");

                    b.HasIndex("TblPaymentTypeId");

                    b.ToTable("tblOrderPayment");
                });

            modelBuilder.Entity("MT.OnlineRestaurant.DataLayer.Context.TblOrderStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("RecordTimeStamp")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("((0))");

                    b.Property<DateTime>("RecordTimeStampCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("Status")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasDefaultValueSql("((0))");

                    b.Property<int>("UserCreated")
                        .HasColumnType("int");

                    b.Property<int>("UserModified")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("tblOrderStatus");
                });

            modelBuilder.Entity("MT.OnlineRestaurant.DataLayer.Context.TblPaymentStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("RecordTimeStamp")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("((0))");

                    b.Property<DateTime>("RecordTimeStampCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("Status")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasDefaultValueSql("((0))");

                    b.Property<int>("UserCreated")
                        .HasColumnType("int");

                    b.Property<int>("UserModified")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("tblPaymentStatus");
                });

            modelBuilder.Entity("MT.OnlineRestaurant.DataLayer.Context.TblPaymentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("RecordTimeStamp")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("((0))");

                    b.Property<DateTime>("RecordTimeStampCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("Type")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasDefaultValueSql("((0))");

                    b.Property<int>("UserCreated")
                        .HasColumnType("int");

                    b.Property<int>("UserModified")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("tblPaymentType");
                });

            modelBuilder.Entity("MT.OnlineRestaurant.DataLayer.Context.TblTableOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("FromDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("((0))");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("RecordTimeStamp")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("((0))");

                    b.Property<DateTime>("RecordTimeStampCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("((0))");

                    b.Property<int?>("TblCustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("tblCustomerID")
                        .HasDefaultValueSql("((0))");

                    b.Property<int?>("TblOrderStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("tblOrderStatusID")
                        .HasDefaultValueSql("((0))");

                    b.Property<int?>("TblPaymentTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("tblPaymentTypeID")
                        .HasDefaultValueSql("((0))");

                    b.Property<int?>("TblRestaurantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("tblRestaurantID")
                        .HasDefaultValueSql("((0))");

                    b.Property<DateTime>("ToDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("((0))");

                    b.Property<int>("UserCreated")
                        .HasColumnType("int");

                    b.Property<int>("UserModified")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TblOrderStatusId");

                    b.HasIndex("TblPaymentTypeId");

                    b.ToTable("tblTableOrder");
                });

            modelBuilder.Entity("MT.OnlineRestaurant.DataLayer.Context.TblTableOrderMapping", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("RecordTimeStamp")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("((0))");

                    b.Property<DateTime>("RecordTimeStampCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("((0))");

                    b.Property<int?>("TableNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("((0))");

                    b.Property<int?>("TblTableOrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("tblTableOrderID")
                        .HasDefaultValueSql("((0))");

                    b.Property<int>("UserCreated")
                        .HasColumnType("int");

                    b.Property<int>("UserModified")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TblTableOrderId");

                    b.ToTable("tblTableOrderMapping");
                });

            modelBuilder.Entity("MT.OnlineRestaurant.DataLayer.Context.TblFoodOrder", b =>
                {
                    b.HasOne("MT.OnlineRestaurant.DataLayer.Context.TblOrderStatus", "TblOrderStatus")
                        .WithMany("TblFoodOrder")
                        .HasForeignKey("TblOrderStatusId")
                        .HasConstraintName("FK_tblFoodOrder_tblOrderStatusID");

                    b.HasOne("MT.OnlineRestaurant.DataLayer.Context.TblPaymentType", "TblPaymentType")
                        .WithMany("TblFoodOrder")
                        .HasForeignKey("TblPaymentTypeId")
                        .HasConstraintName("FK_tblFoodOrder_tblPaymentTypeID");

                    b.Navigation("TblOrderStatus");

                    b.Navigation("TblPaymentType");
                });

            modelBuilder.Entity("MT.OnlineRestaurant.DataLayer.Context.TblFoodOrderMapping", b =>
                {
                    b.HasOne("MT.OnlineRestaurant.DataLayer.Context.TblFoodOrder", "TblFoodOrder")
                        .WithMany("TblFoodOrderMapping")
                        .HasForeignKey("TblFoodOrderId")
                        .HasConstraintName("FK_tblFoodOrderMapping_tblFoodOrderID");

                    b.Navigation("TblFoodOrder");
                });

            modelBuilder.Entity("MT.OnlineRestaurant.DataLayer.Context.TblOrderPayment", b =>
                {
                    b.HasOne("MT.OnlineRestaurant.DataLayer.Context.TblFoodOrder", "TblFoodOrder")
                        .WithMany("TblOrderPayment")
                        .HasForeignKey("TblFoodOrderId")
                        .HasConstraintName("FK_tblOrderPayment_tblFoodOrderID")
                        .IsRequired();

                    b.HasOne("MT.OnlineRestaurant.DataLayer.Context.TblPaymentStatus", "TblPaymentStatus")
                        .WithMany("TblOrderPayment")
                        .HasForeignKey("TblPaymentStatusId")
                        .HasConstraintName("FK_tblOrderPayment_tblPaymentStatusID")
                        .IsRequired();

                    b.HasOne("MT.OnlineRestaurant.DataLayer.Context.TblPaymentType", "TblPaymentType")
                        .WithMany("TblOrderPayment")
                        .HasForeignKey("TblPaymentTypeId")
                        .HasConstraintName("FK_tblOrderPayment_tblPaymentType")
                        .IsRequired();

                    b.Navigation("TblFoodOrder");

                    b.Navigation("TblPaymentStatus");

                    b.Navigation("TblPaymentType");
                });

            modelBuilder.Entity("MT.OnlineRestaurant.DataLayer.Context.TblTableOrder", b =>
                {
                    b.HasOne("MT.OnlineRestaurant.DataLayer.Context.TblOrderStatus", "TblOrderStatus")
                        .WithMany("TblTableOrder")
                        .HasForeignKey("TblOrderStatusId")
                        .HasConstraintName("FK_tblTableOrder_tblOrderStatusID");

                    b.HasOne("MT.OnlineRestaurant.DataLayer.Context.TblPaymentType", "TblPaymentType")
                        .WithMany("TblTableOrder")
                        .HasForeignKey("TblPaymentTypeId")
                        .HasConstraintName("FK_tblTableOrder_tblPaymentTypeID");

                    b.Navigation("TblOrderStatus");

                    b.Navigation("TblPaymentType");
                });

            modelBuilder.Entity("MT.OnlineRestaurant.DataLayer.Context.TblTableOrderMapping", b =>
                {
                    b.HasOne("MT.OnlineRestaurant.DataLayer.Context.TblTableOrder", "TblTableOrder")
                        .WithMany("TblTableOrderMapping")
                        .HasForeignKey("TblTableOrderId")
                        .HasConstraintName("FK_tblTableOrderMapping_tblTableOrderID");

                    b.Navigation("TblTableOrder");
                });

            modelBuilder.Entity("MT.OnlineRestaurant.DataLayer.Context.TblFoodOrder", b =>
                {
                    b.Navigation("TblFoodOrderMapping");

                    b.Navigation("TblOrderPayment");
                });

            modelBuilder.Entity("MT.OnlineRestaurant.DataLayer.Context.TblOrderStatus", b =>
                {
                    b.Navigation("TblFoodOrder");

                    b.Navigation("TblTableOrder");
                });

            modelBuilder.Entity("MT.OnlineRestaurant.DataLayer.Context.TblPaymentStatus", b =>
                {
                    b.Navigation("TblOrderPayment");
                });

            modelBuilder.Entity("MT.OnlineRestaurant.DataLayer.Context.TblPaymentType", b =>
                {
                    b.Navigation("TblFoodOrder");

                    b.Navigation("TblOrderPayment");

                    b.Navigation("TblTableOrder");
                });

            modelBuilder.Entity("MT.OnlineRestaurant.DataLayer.Context.TblTableOrder", b =>
                {
                    b.Navigation("TblTableOrderMapping");
                });
#pragma warning restore 612, 618
        }
    }
}
