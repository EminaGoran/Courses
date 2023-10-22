using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Courses.Services.Database;

public partial class CoursesContext : DbContext
{
    public CoursesContext()
    {
    }

    public CoursesContext(DbContextOptions<CoursesContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Drzave> Drzaves { get; set; }

    public virtual DbSet<Gradovi> Gradovis { get; set; }

    public virtual DbSet<Korisnici> Korisnicis { get; set; }

    public virtual DbSet<KursKorisnici> KursKorisnicis { get; set; }

    public virtual DbSet<KursOcjena> KursOcjenas { get; set; }

    public virtual DbSet<Kursevi> Kursevis { get; set; }

    public virtual DbSet<MaterijalOcjena> MaterijalOcjenas { get; set; }

    public virtual DbSet<Materijali> Materijalis { get; set; }

    public virtual DbSet<Obavijesti> Obavijestis { get; set; }

    public virtual DbSet<Oblasti> Oblastis { get; set; }

    public virtual DbSet<Ocjena> Ocjenas { get; set; }

    public virtual DbSet<PredavacOcjena> PredavacOcjenas { get; set; }

    public virtual DbSet<Predavanja> Predavanjas { get; set; }

    public virtual DbSet<Prisustva> Prisustvas { get; set; }

    public virtual DbSet<TipMaterijala> TipMaterijalas { get; set; }

    public virtual DbSet<TipoviObavijesti> TipoviObavijestis { get; set; }

    public virtual DbSet<Uloga> Ulogas { get; set; }

    public virtual DbSet<Uplate> Uplates { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=Courses; Trusted_Connection=true; TrustServerCertificate=True; Encrypt=False;  ");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("SQL_Latin1_General_CP1_CI_AS");

        modelBuilder.Entity<Drzave>(entity =>
        {
            entity.ToTable("Drzave");
        });

        modelBuilder.Entity<Gradovi>(entity =>
        {
            entity.ToTable("Gradovi");

            entity.HasIndex(e => e.DrzavaId, "IX_Gradovi_DrzavaId");

            entity.HasOne(d => d.Drzava).WithMany(p => p.Gradovis).HasForeignKey(d => d.DrzavaId);
        });

        modelBuilder.Entity<Korisnici>(entity =>
        {
            entity.ToTable("Korisnici");

            entity.HasIndex(e => e.GradId, "IX_Korisnici_GradId");

            entity.HasOne(d => d.Grad).WithMany(p => p.Korisnicis).HasForeignKey(d => d.GradId);

            entity.HasOne(d => d.UlogaNavigation).WithMany(p => p.Korisnicis)
                .HasForeignKey(d => d.Uloga)
                .HasConstraintName("FK__Korisnici__Uloga__07C12930");
        });

        modelBuilder.Entity<KursKorisnici>(entity =>
        {
            entity.ToTable("KursKorisnici");

            entity.HasIndex(e => e.KorisnikId, "IX_KursKorisnici_KorisnikId");

            entity.HasIndex(e => e.KursId, "IX_KursKorisnici_KursId");

            entity.HasIndex(e => e.PredavanjeId, "IX_KursKorisnici_PredavanjeId");

            entity.Property(e => e.Certifikat)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.Polozio)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");

            entity.HasOne(d => d.Korisnik).WithMany(p => p.KursKorisnicis).HasForeignKey(d => d.KorisnikId);

            entity.HasOne(d => d.Kurs).WithMany(p => p.KursKorisnicis).HasForeignKey(d => d.KursId);

            entity.HasOne(d => d.Predavanje).WithMany(p => p.KursKorisnicis).HasForeignKey(d => d.PredavanjeId);
        });

        modelBuilder.Entity<KursOcjena>(entity =>
        {
            entity.HasKey(e => e.KursOcjenaId).HasName("PK__KursOcje__DB868B48CDF66F1D");

            entity.ToTable("KursOcjena");

            entity.Property(e => e.KursOcjenaId).ValueGeneratedOnAdd();

            entity.HasOne(d => d.KursOcjenaNavigation).WithOne(p => p.KursOcjena)
                .HasForeignKey<KursOcjena>(d => d.KursOcjenaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__KursOcjen__KursO__123EB7A3");

            entity.HasOne(d => d.Ocjena).WithMany(p => p.KursOcjenas)
                .HasForeignKey(d => d.OcjenaId)
                .HasConstraintName("FK__KursOcjen__Ocjen__1332DBDC");
        });

        modelBuilder.Entity<Kursevi>(entity =>
        {
            entity.ToTable("Kursevi");

            entity.HasIndex(e => e.OblastId, "IX_Kursevi_OblastId");

            entity.HasOne(d => d.Oblast).WithMany(p => p.Kursevis).HasForeignKey(d => d.OblastId);
        });

        modelBuilder.Entity<MaterijalOcjena>(entity =>
        {
            entity.HasKey(e => e.MaterijalOcjenaId).HasName("PK__Materija__52C76081530C85AE");

            entity.ToTable("MaterijalOcjena");

            entity.HasOne(d => d.Materijal).WithMany(p => p.MaterijalOcjenas)
                .HasForeignKey(d => d.MaterijalId)
                .HasConstraintName("FK__Materijal__Mater__0E6E26BF");

            entity.HasOne(d => d.Ocjena).WithMany(p => p.MaterijalOcjenas)
                .HasForeignKey(d => d.OcjenaId)
                .HasConstraintName("FK__Materijal__Ocjen__0F624AF8");
        });

        modelBuilder.Entity<Materijali>(entity =>
        {
            entity.ToTable("Materijali");

            entity.HasIndex(e => e.KursId, "IX_Materijali_KursId");

            entity.HasIndex(e => e.TipMaterijalaId, "IX_Materijali_TipMaterijalaId");

            entity.HasOne(d => d.Kurs).WithMany(p => p.Materijalis).HasForeignKey(d => d.KursId);

            entity.HasOne(d => d.TipMaterijala).WithMany(p => p.Materijalis).HasForeignKey(d => d.TipMaterijalaId);
        });

        modelBuilder.Entity<Obavijesti>(entity =>
        {
            entity.ToTable("Obavijesti");

            entity.HasIndex(e => e.KursId, "IX_Obavijesti_KursId");

            entity.HasIndex(e => e.TipObavijestiId, "IX_Obavijesti_TipObavijestiId");

            entity.HasOne(d => d.Kurs).WithMany(p => p.Obavijestis).HasForeignKey(d => d.KursId);

            entity.HasOne(d => d.TipObavijesti).WithMany(p => p.Obavijestis).HasForeignKey(d => d.TipObavijestiId);
        });

        modelBuilder.Entity<Oblasti>(entity =>
        {
            entity.ToTable("Oblasti");
        });

        modelBuilder.Entity<Ocjena>(entity =>
        {
            entity.HasKey(e => e.OcjenaId).HasName("PK__Ocjena__E6FC7AA9FC29A649");

            entity.ToTable("Ocjena");

            entity.Property(e => e.Opis).HasMaxLength(20);
        });

        modelBuilder.Entity<PredavacOcjena>(entity =>
        {
            entity.HasKey(e => e.PredavacOcjenaId).HasName("PK__Predavac__5AC6BB9D38E84800");

            entity.ToTable("PredavacOcjena");

            entity.HasOne(d => d.Ocjena).WithMany(p => p.PredavacOcjenas)
                .HasForeignKey(d => d.OcjenaId)
                .HasConstraintName("FK__PredavacO__Ocjen__0B91BA14");

            entity.HasOne(d => d.Predavac).WithMany(p => p.PredavacOcjenas)
                .HasForeignKey(d => d.PredavacId)
                .HasConstraintName("FK__PredavacO__Preda__0A9D95DB");
        });

        modelBuilder.Entity<Predavanja>(entity =>
        {
            entity.ToTable("Predavanja");

            entity.HasIndex(e => e.KursId, "IX_Predavanja_KursId");

            entity.HasOne(d => d.Kurs).WithMany(p => p.Predavanjas).HasForeignKey(d => d.KursId);
        });

        modelBuilder.Entity<Prisustva>(entity =>
        {
            entity.ToTable("Prisustva");

            entity.HasIndex(e => e.KursKorisnikId, "IX_Prisustva_KursKorisnikId");

            entity.HasIndex(e => e.PredavanjeId, "IX_Prisustva_PredavanjeId");

            entity.HasOne(d => d.KursKorisnik).WithMany(p => p.Prisustvas).HasForeignKey(d => d.KursKorisnikId);

            entity.HasOne(d => d.Predavanje).WithMany(p => p.Prisustvas)
                .HasForeignKey(d => d.PredavanjeId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<TipMaterijala>(entity =>
        {
            entity.ToTable("TipMaterijala");
        });

        modelBuilder.Entity<TipoviObavijesti>(entity =>
        {
            entity.ToTable("TipoviObavijesti");
        });

        modelBuilder.Entity<Uloga>(entity =>
        {
            entity.HasKey(e => e.UlogaId).HasName("PK__Uloga__DCAB23CB55C1037A");

            entity.ToTable("Uloga");

            entity.Property(e => e.Naziv).HasMaxLength(20);
            entity.Property(e => e.Opis).HasMaxLength(50);
        });

        modelBuilder.Entity<Uplate>(entity =>
        {
            entity.ToTable("Uplate");

            entity.HasIndex(e => e.KorisnikId, "IX_Uplate_KorisnikId");

            entity.HasIndex(e => e.KursId, "IX_Uplate_KursId");

            entity.HasOne(d => d.Korisnik).WithMany(p => p.Uplates).HasForeignKey(d => d.KorisnikId);

            entity.HasOne(d => d.Kurs).WithMany(p => p.Uplates).HasForeignKey(d => d.KursId);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
