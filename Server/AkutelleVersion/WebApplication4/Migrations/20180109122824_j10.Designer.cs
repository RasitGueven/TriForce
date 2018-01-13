﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using WebApplication4.Daten;

namespace WebApplication4.Migrations
{
    [DbContext(typeof(LolocoContext))]
    [Migration("20180109122824_j10")]
    partial class j10
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication4.Models.Consumer", b =>
                {
                    b.Property<int>("Consumerid")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Beruf");

                    b.Property<string>("Firstname");

                    b.Property<string>("Lastname");

                    b.Property<string>("i");

                    b.Property<int>("number");

                    b.Property<string>("street");

                    b.HasKey("Consumerid");

                    b.ToTable("Consumer");
                });

            modelBuilder.Entity("WebApplication4.Models.Coupon", b =>
                {
                    b.Property<string>("Couponid")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Points");

                    b.Property<string>("Selleri");

                    b.Property<string>("Useri");

                    b.HasKey("Couponid");

                    b.ToTable("Coupon");
                });

            modelBuilder.Entity("WebApplication4.Models.User", b =>
                {
                    b.Property<int>("Userid")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("Firstname");

                    b.Property<string>("I");

                    b.Property<bool>("IsSeller");

                    b.Property<string>("Lastname");

                    b.Property<string>("Street");

                    b.Property<bool>("vorhanden");

                    b.HasKey("Userid");

                    b.ToTable("User");
                });
#pragma warning restore 612, 618
        }
    }
}
