﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MuseumTourBackEnd.Models;

namespace MPBackends.Migrations
{
    [DbContext(typeof(MuseumContext))]
    [Migration("20200521181721_addStatus")]
    partial class addStatus
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MuseumTourBackEnd.Models.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int(11)");

                    b.Property<string>("Username")
                        .HasColumnName("username")
                        .HasColumnType("varchar(45)")
                        .HasMaxLength(45)
                        .IsUnicode(false);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnName("password")
                        .HasColumnType("varchar(45)")
                        .HasMaxLength(45)
                        .IsUnicode(false);

                    b.Property<int>("Roles")
                        .HasColumnName("roles")
                        .HasColumnType("int(11)");

                    b.HasKey("Id", "Username")
                        .HasName("PRIMARY");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("MuseumTourBackEnd.Models.Collection", b =>
                {
                    b.Property<int>("Oid")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("oid")
                        .HasColumnType("int(10) unsigned");

                    b.Property<int>("Midex")
                        .HasColumnName("midex")
                        .HasColumnType("int(11)");

                    b.Property<string>("Ointro")
                        .HasColumnName("ointro")
                        .HasColumnType("text");

                    b.Property<string>("Oname")
                        .IsRequired()
                        .HasColumnName("oname")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<string>("Ophoto")
                        .HasColumnName("ophoto")
                        .HasColumnType("text");

                    b.HasKey("Oid")
                        .HasName("PRIMARY");

                    b.ToTable("Collection");
                });

            modelBuilder.Entity("MuseumTourBackEnd.Models.Comment", b =>
                {
                    b.Property<int>("Midex")
                        .HasColumnName("midex")
                        .HasColumnType("int(11)");

                    b.Property<string>("Userid")
                        .HasColumnName("userid")
                        .HasColumnType("varchar(45)")
                        .HasMaxLength(45)
                        .IsUnicode(false);

                    b.Property<int?>("Envscore")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("envscore")
                        .HasColumnType("int(11)")
                        .HasDefaultValueSql("'0'");

                    b.Property<int?>("Exhscore")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("exhscore")
                        .HasColumnType("int(11)")
                        .HasDefaultValueSql("'0'");

                    b.Property<string>("Msg")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("msg")
                        .HasColumnType("varchar(200)")
                        .HasDefaultValueSql("'null'")
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.Property<int?>("Serscore")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("serscore")
                        .HasColumnType("int(11)")
                        .HasDefaultValueSql("'0'");

                    b.HasKey("Midex", "Userid")
                        .HasName("PRIMARY");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("MuseumTourBackEnd.Models.Education", b =>
                {
                    b.Property<int>("Aid")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("aid")
                        .HasColumnType("int(11)");

                    b.Property<int?>("Mid")
                        .HasColumnName("mid")
                        .HasColumnType("int(11)");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("Url")
                        .HasColumnName("url")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.HasKey("Aid")
                        .HasName("PRIMARY");

                    b.ToTable("Education");
                });

            modelBuilder.Entity("MuseumTourBackEnd.Models.EfmigrationsHistory", b =>
                {
                    b.Property<string>("MigrationId")
                        .HasColumnType("varchar(95)")
                        .HasMaxLength(95)
                        .IsUnicode(false);

                    b.Property<string>("ProductVersion")
                        .IsRequired()
                        .HasColumnType("varchar(32)")
                        .HasMaxLength(32)
                        .IsUnicode(false);

                    b.HasKey("MigrationId")
                        .HasName("PRIMARY");

                    b.ToTable("__EFMigrationsHistory");
                });

            modelBuilder.Entity("MuseumTourBackEnd.Models.Exhibition", b =>
                {
                    b.Property<int>("Eid")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("eid")
                        .HasColumnType("int(11)");

                    b.Property<string>("Eintro")
                        .HasColumnName("eintro")
                        .HasColumnType("text");

                    b.Property<string>("Ename")
                        .IsRequired()
                        .HasColumnName("ename")
                        .HasColumnType("varchar(450)")
                        .HasMaxLength(450)
                        .IsUnicode(false);

                    b.Property<int>("Midex")
                        .HasColumnName("midex")
                        .HasColumnType("int(150)");

                    b.HasKey("Eid")
                        .HasName("PRIMARY");

                    b.ToTable("Exhibition");
                });

            modelBuilder.Entity("MuseumTourBackEnd.Models.Maintable", b =>
                {
                    b.Property<int>("Midex")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("midex")
                        .HasColumnType("int(11)");

                    b.Property<string>("Mbase")
                        .HasColumnName("mbase")
                        .HasColumnType("text");

                    b.Property<string>("Mname")
                        .IsRequired()
                        .HasColumnName("mname")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.HasKey("Midex")
                        .HasName("PRIMARY");

                    b.ToTable("maintable");
                });

            modelBuilder.Entity("MuseumTourBackEnd.Models.MuseumInformation", b =>
                {
                    b.Property<int>("Midex")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("midex")
                        .HasColumnType("int(11)");

                    b.Property<string>("Maddress")
                        .IsRequired()
                        .HasColumnName("maddress")
                        .HasColumnType("varchar(45)")
                        .HasMaxLength(45)
                        .IsUnicode(false);

                    b.Property<string>("Mbase")
                        .HasColumnName("mbase")
                        .HasColumnType("varchar(45)")
                        .HasMaxLength(45)
                        .IsUnicode(false);

                    b.Property<string>("Mname")
                        .IsRequired()
                        .HasColumnName("mname")
                        .HasColumnType("varchar(45)")
                        .HasMaxLength(45)
                        .IsUnicode(false);

                    b.Property<string>("Mopentime")
                        .IsRequired()
                        .HasColumnName("mopentime")
                        .HasColumnType("varchar(2000)")
                        .HasMaxLength(2000)
                        .IsUnicode(false);

                    b.Property<string>("PictureAddress")
                        .HasColumnName("picture_address")
                        .HasColumnType("varchar(2000)")
                        .HasMaxLength(2000)
                        .IsUnicode(false);

                    b.HasKey("Midex")
                        .HasName("PRIMARY");

                    b.ToTable("Museum_Information");
                });

            modelBuilder.Entity("MuseumTourBackEnd.Models.News", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint(20)");

                    b.Property<string>("Analyseresult")
                        .HasColumnType("longtext");

                    b.Property<string>("Content")
                        .HasColumnType("longtext");

                    b.Property<string>("Museum")
                        .HasColumnType("longtext");

                    b.Property<string>("Publishtime")
                        .HasColumnType("longtext");

                    b.Property<string>("Source")
                        .HasColumnType("longtext");

                    b.Property<string>("Title")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("News");
                });

            modelBuilder.Entity("MuseumTourBackEnd.Models.Uploadvideo", b =>
                {
                    b.Property<int>("Vid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("OriginName")
                        .HasColumnType("text");

                    b.Property<string>("Status")
                        .HasColumnType("text");

                    b.HasKey("Vid");

                    b.ToTable("Uploadvideo");
                });

            modelBuilder.Entity("MuseumTourBackEnd.Models.User", b =>
                {
                    b.Property<string>("Userid")
                        .HasColumnName("userid")
                        .HasColumnType("varchar(45)")
                        .HasMaxLength(45)
                        .IsUnicode(false);

                    b.Property<int?>("Coright")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("coright")
                        .HasColumnType("int(11)")
                        .HasDefaultValueSql("'1'");

                    b.Property<string>("Nickname")
                        .HasColumnName("nickname")
                        .HasColumnType("varchar(45)")
                        .HasMaxLength(45)
                        .IsUnicode(false);

                    b.Property<string>("Userpwd")
                        .HasColumnName("userpwd")
                        .HasColumnType("varchar(45)")
                        .HasMaxLength(45)
                        .IsUnicode(false);

                    b.HasKey("Userid");

                    b.ToTable("User");
                });
#pragma warning restore 612, 618
        }
    }
}
