﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using movie.DBcontex;

#nullable disable

namespace movie.Migrations
{
    [DbContext(typeof(FilmMsaxiobiDBcontext))]
    partial class FilmMsaxiobiDBcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("movie.EntityModel.Film", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("janri")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("film");
                });

            modelBuilder.Entity("movie.EntityModel.FilmMsaxiobi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("filmID")
                        .HasColumnType("int");

                    b.Property<int>("msaxiobiID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("filmID");

                    b.HasIndex("msaxiobiID");

                    b.ToTable("filmmsaxiobi");
                });

            modelBuilder.Entity("movie.EntityModel.Filmpiradi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("filmebisid")
                        .HasColumnType("int");

                    b.Property<string>("rejisori")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("shemosavali")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("filmebisid")
                        .IsUnique();

                    b.ToTable("filmpiradis");
                });

            modelBuilder.Entity("movie.EntityModel.msaxiobi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("asaki")
                        .HasColumnType("int");

                    b.Property<string>("gvari")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("msaxiobi");
                });

            modelBuilder.Entity("movie.EntityModel.msaxiobispiradi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("kanisferi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("msaxiobiId")
                        .HasColumnType("int");

                    b.Property<int>("piradinomeri")
                        .HasColumnType("int");

                    b.Property<int>("shemosavali")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("msaxiobiId")
                        .IsUnique();

                    b.ToTable("msaxiobispiradis");
                });

            modelBuilder.Entity("movie.EntityModel.FilmMsaxiobi", b =>
                {
                    b.HasOne("movie.EntityModel.Film", "Filmebi")
                        .WithMany("Msaxiobebi")
                        .HasForeignKey("filmID");

                    b.HasOne("movie.EntityModel.msaxiobi", "Msaxiebebi")
                        .WithMany("Filmebinatamashebi")
                        .HasForeignKey("msaxiobiID");

                    b.Navigation("Filmebi");

                    b.Navigation("Msaxiebebi");
                });

            modelBuilder.Entity("movie.EntityModel.Filmpiradi", b =>
                {
                    b.HasOne("movie.EntityModel.Film", "filmzogadi")
                        .WithOne("filmpiradi")
                        .HasForeignKey("movie.EntityModel.Filmpiradi", "filmebisid");

                    b.Navigation("filmzogadi");
                });

            modelBuilder.Entity("movie.EntityModel.msaxiobispiradi", b =>
                {
                    b.HasOne("movie.EntityModel.msaxiobi", "msaxiobizogadi")
                        .WithOne("msaxiobispiradi")
                        .HasForeignKey("movie.EntityModel.msaxiobispiradi", "msaxiobiId");

                    b.Navigation("msaxiobizogadi");
                });

            modelBuilder.Entity("movie.EntityModel.Film", b =>
                {
                    b.Navigation("Msaxiobebi");

                    b.Navigation("filmpiradi")
                        .IsRequired();
                });

            modelBuilder.Entity("movie.EntityModel.msaxiobi", b =>
                {
                    b.Navigation("Filmebinatamashebi");

                    b.Navigation("msaxiobispiradi")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}