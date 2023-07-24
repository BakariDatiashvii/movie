global using movie.FilmebiDTO;
global using movie.Services.FilmMsaxiobebiServices;
using Microsoft.EntityFrameworkCore;
using movie.EntityModel;
using System.Collections.Generic;
using System.Reflection.Emit;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace movie.DBcontex
{
    public class FilmMsaxiobiDBcontext : Microsoft.EntityFrameworkCore.DbContext
    {
        public FilmMsaxiobiDBcontext(DbContextOptions<FilmMsaxiobiDBcontext> context) : base(context)
        {

        }
        public DbSet<msaxiobi> msaxiobi { get; set; }
        public DbSet<Film> film { get; set; }
        public DbSet<FilmMsaxiobi> filmmsaxiobi { get; set; }

        public DbSet<Filmpiradi> filmpiradis { get; set; }

        public DbSet<msaxiobispiradi> msaxiobispiradis { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Film>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<Film>()
                .Property(x => x.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<msaxiobi>()
                .HasKey(x=> x.Id);

            modelBuilder.Entity<msaxiobi>()
                .Property(x => x.Id)
                .ValueGeneratedOnAdd();


            modelBuilder.Entity<FilmMsaxiobi>()
               .HasKey(x => x.Id);


            modelBuilder.Entity<FilmMsaxiobi>()
                .Property(x => x.Id)
                .ValueGeneratedOnAdd();



            modelBuilder.Entity<FilmMsaxiobi>()
                .HasOne(x => x.Filmebi)
                .WithMany(x => x.Msaxiobebi)
                .HasForeignKey(x => x.filmID)
                .IsRequired(false);



            modelBuilder.Entity<FilmMsaxiobi>()
               .HasOne(x => x.Msaxiebebi)
               .WithMany(x => x.Filmebinatamashebi)
               .HasForeignKey(x => x.msaxiobiID)
               .IsRequired(false);


          

            modelBuilder.Entity<Filmpiradi>()
                .HasKey(x => x.Id);


            modelBuilder.Entity<Filmpiradi>()
                .Property(x => x.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Film>()
               .HasOne(x => x.filmpiradi)
               .WithOne(x => x.filmzogadi)
               .HasForeignKey<Filmpiradi>(p => p.filmebisid)
               .IsRequired(false);




            modelBuilder.Entity<msaxiobispiradi>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<msaxiobispiradi>()
                .Property(x => x.Id)
                .ValueGeneratedOnAdd();



            


            modelBuilder.Entity<msaxiobi>()
             .HasOne(x => x.msaxiobispiradi)
             .WithOne(x => x.msaxiobizogadi)
             .HasForeignKey<msaxiobispiradi>(p => p.msaxiobiId)
             .IsRequired(false);


        }
    }
}


