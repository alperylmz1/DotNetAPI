﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TodoApi.DataAccess;

namespace TodoApi.DataAccess.Migrations
{
    [DbContext(typeof(TodoDbContext))]
    [Migration("20230831113111_eleventhCreate")]
    partial class eleventhCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TodoApi.Entities.Notification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Message");

                    b.Property<int>("MessageStatus");

                    b.Property<string>("MessageTitle");

                    b.Property<int>("ReceiverId");

                    b.Property<int>("SenderId");

                    b.Property<DateTime>("SentDate");

                    b.HasKey("Id");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("TodoApi.Entities.Todo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AssignedByUser");

                    b.Property<DateTime>("AssignedDate");

                    b.Property<DateTime>("EndDate");

                    b.Property<bool>("TdActive");

                    b.Property<bool>("TdFavorite");

                    b.Property<int>("TdStatus");

                    b.Property<string>("TdText");

                    b.Property<string>("TdTitle");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.ToTable("Todos");
                });

            modelBuilder.Entity("TodoApi.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("UserId");

                    b.Property<string>("UserMail");

                    b.Property<string>("UserName");

                    b.Property<string>("UserPassword");

                    b.Property<int>("UserRole");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}