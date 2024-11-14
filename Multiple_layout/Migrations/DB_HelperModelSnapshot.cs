﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Multiple_layout.Data;

#nullable disable

namespace Multiple_layout.Migrations
{
    [DbContext(typeof(DB_Helper))]
    partial class DB_HelperModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Multiple_layout.Models.Category", b =>
                {
                    b.Property<int>("C_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("C_id"));

                    b.Property<string>("C_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("C_id");

                    b.ToTable("tbl_category");
                });

            modelBuilder.Entity("Multiple_layout.Models.Product", b =>
                {
                    b.Property<int>("P_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("P_id"));

                    b.Property<int>("C_id")
                        .HasColumnType("int");

                    b.Property<string>("P_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("P_id");

                    b.ToTable("tbl_products");
                });

            modelBuilder.Entity("Multiple_layout.Models.Register", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Dob")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("tbl_Register");
                });
<<<<<<< HEAD

            modelBuilder.Entity("Multiple_layout.Models.Viewmodel", b =>
                {
                    b.Property<int>("I_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("I_id"));

                    b.Property<int>("C_id")
                        .HasColumnType("int");

                    b.Property<string>("I_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("P_id")
                        .HasColumnType("int");

                    b.HasKey("I_id");

                    b.ToTable("tbl_Items");
                });
=======
>>>>>>> 738903146ff7e70420554bddc00952069093d883
#pragma warning restore 612, 618
        }
    }
}
