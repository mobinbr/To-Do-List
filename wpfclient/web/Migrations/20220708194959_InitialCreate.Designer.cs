﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace web.Migrations
{
    [DbContext(typeof(ItemsContext))]
    [Migration("20220708194959_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.5");

            modelBuilder.Entity("classlib.ToDoItems", b =>
                {
                    b.Property<string>("ToDoItemsId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DueTime")
                        .HasColumnType("TEXT");

                    b.HasKey("ToDoItemsId");

                    b.ToTable("items");
                });
#pragma warning restore 612, 618
        }
    }
}