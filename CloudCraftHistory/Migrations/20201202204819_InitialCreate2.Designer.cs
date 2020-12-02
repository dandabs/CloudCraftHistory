﻿// <auto-generated />
using System;
using CloudCraftHistory.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CloudCraftHistory.Migrations
{
    [DbContext(typeof(CloudCraftHistoryContext))]
    [Migration("20201202204819_InitialCreate2")]
    partial class InitialCreate2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9");

            modelBuilder.Entity("CloudCraftHistory.Models.Member", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .HasColumnType("TEXT");

                    b.Property<string>("Discord")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Instagram")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("JoinDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Languages")
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.Property<string>("PreferredName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Reddit")
                        .HasColumnType("TEXT");

                    b.Property<string>("Skype")
                        .HasColumnType("TEXT");

                    b.Property<string>("Snapchat")
                        .HasColumnType("TEXT");

                    b.Property<string>("Twitter")
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .HasColumnType("TEXT");

                    b.Property<int>("WasStaff")
                        .HasColumnType("INTEGER");

                    b.Property<int>("eighteen")
                        .HasColumnType("INTEGER");

                    b.Property<int>("fifteen")
                        .HasColumnType("INTEGER");

                    b.Property<int>("fourteen")
                        .HasColumnType("INTEGER");

                    b.Property<int>("nineteen")
                        .HasColumnType("INTEGER");

                    b.Property<int>("seventeen")
                        .HasColumnType("INTEGER");

                    b.Property<int>("sixteen")
                        .HasColumnType("INTEGER");

                    b.Property<int>("twenty")
                        .HasColumnType("INTEGER");

                    b.Property<int>("twentyone")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToTable("Member");
                });
#pragma warning restore 612, 618
        }
    }
}
