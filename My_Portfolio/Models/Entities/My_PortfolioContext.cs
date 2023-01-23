using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace My_Portfolio.Models.Entities
{
    public partial class My_PortfolioContext : DbContext
    {
        public My_PortfolioContext()
        {
        }

        public My_PortfolioContext(DbContextOptions<My_PortfolioContext> options)
            : base(options)
        {
        }

        public virtual DbSet<About> Abouts { get; set; } = null!;
        public virtual DbSet<AboutEnd> AboutEnds { get; set; } = null!;
        public virtual DbSet<Admin> Admins { get; set; } = null!;
        public virtual DbSet<ContactForm> ContactForms { get; set; } = null!;
        public virtual DbSet<ContactLeft> ContactLefts { get; set; } = null!;
        public virtual DbSet<Footer> Footers { get; set; } = null!;
        public virtual DbSet<Header> Headers { get; set; } = null!;
        public virtual DbSet<Hero> Heroes { get; set; } = null!;
        public virtual DbSet<OzgecmisEgitim> OzgecmisEgitims { get; set; } = null!;
        public virtual DbSet<OzgecmisIsDeneyimleri> OzgecmisIsDeneyimleris { get; set; } = null!;
        public virtual DbSet<OzgecmisOzet> OzgecmisOzets { get; set; } = null!;
        public virtual DbSet<Portfolio> Portfolios { get; set; } = null!;
        public virtual DbSet<Referanslar> Referanslars { get; set; } = null!;
        public virtual DbSet<Service> Services { get; set; } = null!;
        public virtual DbSet<Title> Titles { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=DESKTOP-NJDMUNH; uid=sa; password=1234; database=My_Portfolio; trustServerCertificate=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<About>(entity =>
            {
                entity.ToTable("About");

                entity.Property(e => e.Aciklama1).HasMaxLength(100);

                entity.Property(e => e.Aciklama2).HasMaxLength(100);

                entity.Property(e => e.Aciklama3).HasMaxLength(100);

                entity.Property(e => e.Aciklama4).HasMaxLength(100);

                entity.Property(e => e.Age).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.Degree).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Img).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.Serbestlik).HasMaxLength(50);

                entity.Property(e => e.Website).HasMaxLength(50);
            });

            modelBuilder.Entity<AboutEnd>(entity =>
            {
                entity.ToTable("About_End");

                entity.Property(e => e.Bilgi).HasMaxLength(50);

                entity.Property(e => e.Deger).HasMaxLength(50);
            });

            modelBuilder.Entity<Admin>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Admin");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Password)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ContactForm>(entity =>
            {
                entity.ToTable("Contact_Form");

                entity.Property(e => e.Aciklama).HasMaxLength(250);

                entity.Property(e => e.AdSoyad).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Konu).HasMaxLength(100);
            });

            modelBuilder.Entity<ContactLeft>(entity =>
            {
                entity.ToTable("Contact_Left");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Link1).HasMaxLength(50);

                entity.Property(e => e.Link2).HasMaxLength(50);

                entity.Property(e => e.Link3).HasMaxLength(50);

                entity.Property(e => e.Link4).HasMaxLength(50);

                entity.Property(e => e.Link5).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(50);
            });

            modelBuilder.Entity<Footer>(entity =>
            {
                entity.ToTable("Footer");

                entity.Property(e => e.Aciklama).HasMaxLength(150);

                entity.Property(e => e.Link1).HasMaxLength(50);

                entity.Property(e => e.Link2).HasMaxLength(50);

                entity.Property(e => e.Link3).HasMaxLength(50);

                entity.Property(e => e.Link4).HasMaxLength(50);

                entity.Property(e => e.Link5).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Header>(entity =>
            {
                entity.ToTable("Header");

                entity.Property(e => e.Nav1).HasMaxLength(50);

                entity.Property(e => e.Nav1Link)
                    .HasMaxLength(50)
                    .HasColumnName("Nav1_Link");

                entity.Property(e => e.Nav2).HasMaxLength(50);

                entity.Property(e => e.Nav2Link)
                    .HasMaxLength(50)
                    .HasColumnName("Nav2_Link");

                entity.Property(e => e.Nav3).HasMaxLength(50);

                entity.Property(e => e.Nav3Link)
                    .HasMaxLength(50)
                    .HasColumnName("Nav3_Link");

                entity.Property(e => e.Nav4).HasMaxLength(50);

                entity.Property(e => e.Nav4Link)
                    .HasMaxLength(50)
                    .HasColumnName("Nav4_Link");

                entity.Property(e => e.Nav5).HasMaxLength(50);

                entity.Property(e => e.Nav5Link)
                    .HasMaxLength(50)
                    .HasColumnName("Nav5_Link");

                entity.Property(e => e.Nav6).HasMaxLength(50);

                entity.Property(e => e.Nav6Link)
                    .HasMaxLength(50)
                    .HasColumnName("Nav6_Link");
            });

            modelBuilder.Entity<Hero>(entity =>
            {
                entity.ToTable("Hero");

                entity.Property(e => e.Adi).HasMaxLength(50);

                entity.Property(e => e.Hakkinda).HasMaxLength(100);
            });

            modelBuilder.Entity<OzgecmisEgitim>(entity =>
            {
                entity.ToTable("Ozgecmis_Egitim");

                entity.Property(e => e.Aciklama).HasMaxLength(300);

                entity.Property(e => e.Bolum).HasMaxLength(50);

                entity.Property(e => e.Okul).HasMaxLength(100);

                entity.Property(e => e.Yil).HasMaxLength(50);
            });

            modelBuilder.Entity<OzgecmisIsDeneyimleri>(entity =>
            {
                entity.ToTable("Ozgecmis_IsDeneyimleri");

                entity.Property(e => e.Aciklama).HasMaxLength(300);

                entity.Property(e => e.Adres).HasMaxLength(100);

                entity.Property(e => e.Bolum).HasMaxLength(100);

                entity.Property(e => e.Tarih).HasMaxLength(50);
            });

            modelBuilder.Entity<OzgecmisOzet>(entity =>
            {
                entity.ToTable("Ozgecmis_Ozet");

                entity.Property(e => e.Aciklama).HasMaxLength(200);

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.Adres).HasMaxLength(100);

                entity.Property(e => e.Cinsiyet).HasMaxLength(50);

                entity.Property(e => e.Ehliyet).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.MedeniHal)
                    .HasMaxLength(50)
                    .HasColumnName("Medeni_Hal");

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.Telefon).HasMaxLength(50);
            });

            modelBuilder.Entity<Portfolio>(entity =>
            {
                entity.ToTable("Portfolio");

                entity.Property(e => e.Aciklama).HasMaxLength(100);

                entity.Property(e => e.Baslik).HasMaxLength(50);

                entity.Property(e => e.Img).HasMaxLength(50);
            });

            modelBuilder.Entity<Referanslar>(entity =>
            {
                entity.ToTable("Referanslar");

                entity.Property(e => e.Aciklama).HasMaxLength(200);

                entity.Property(e => e.AdSoyad).HasMaxLength(50);

                entity.Property(e => e.Img)
                    .HasMaxLength(50)
                    .HasColumnName("img");

                entity.Property(e => e.Title).HasMaxLength(50);
            });

            modelBuilder.Entity<Service>(entity =>
            {
                entity.Property(e => e.Aciklama).HasMaxLength(150);

                entity.Property(e => e.Baslik).HasMaxLength(50);

                entity.Property(e => e.Icon).HasMaxLength(50);
            });

            modelBuilder.Entity<Title>(entity =>
            {
                entity.Property(e => e.AboutAciklama)
                    .HasMaxLength(100)
                    .HasColumnName("About_Aciklama");

                entity.Property(e => e.AboutTitle)
                    .HasMaxLength(50)
                    .HasColumnName("About_Title");

                entity.Property(e => e.ContactAciklama)
                    .HasMaxLength(100)
                    .HasColumnName("Contact_Aciklama");

                entity.Property(e => e.ContactTitle)
                    .HasMaxLength(50)
                    .HasColumnName("Contact_Title");

                entity.Property(e => e.OzgecmisAciklama)
                    .HasMaxLength(100)
                    .HasColumnName("Ozgecmis_Aciklama");

                entity.Property(e => e.OzgecmisAltBaslik1)
                    .HasMaxLength(50)
                    .HasColumnName("Ozgecmis_Alt_Baslik1");

                entity.Property(e => e.OzgecmisAltBaslik2)
                    .HasMaxLength(50)
                    .HasColumnName("Ozgecmis_Alt_Baslik2");

                entity.Property(e => e.OzgecmisAltBaslik3)
                    .HasMaxLength(50)
                    .HasColumnName("Ozgecmis_Alt_Baslik3");

                entity.Property(e => e.OzgecmisTitle)
                    .HasMaxLength(50)
                    .HasColumnName("Ozgecmis_Title");

                entity.Property(e => e.PortfolioAciklama)
                    .HasMaxLength(100)
                    .HasColumnName("Portfolio_Aciklama");

                entity.Property(e => e.PortfolioTitle)
                    .HasMaxLength(50)
                    .HasColumnName("Portfolio_Title");

                entity.Property(e => e.ServicesAciklama)
                    .HasMaxLength(100)
                    .HasColumnName("Services_Aciklama");

                entity.Property(e => e.ServicesTitle)
                    .HasMaxLength(50)
                    .HasColumnName("Services_Title");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
