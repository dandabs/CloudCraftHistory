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
    [Migration("20201202203807_InitialCreate")]
    partial class InitialCreate
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

                    b.Property<bool>("WasStaff")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("eighteen")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("fifteen")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("fourteen")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("nineteen")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("seventeen")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("sixteen")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("twenty")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("twentyone")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToTable("Member");
                });
#pragma warning restore 612, 618
        }
    }
}
