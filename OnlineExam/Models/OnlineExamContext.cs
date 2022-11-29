using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace OnlineExam.Models
{
    public partial class OnlineExamContext : DbContext
    {
        public OnlineExamContext()
        {
        }

        public OnlineExamContext(DbContextOptions<OnlineExamContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AdminLogin> AdminLogins { get; set; }
        public virtual DbSet<AdminRegister> AdminRegisters { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<QuestionBank> QuestionBanks { get; set; }
        public virtual DbSet<Registration> Registration { get; set; }
        public virtual DbSet<ReportCard> ReportCards { get; set; }
        public virtual DbSet<SearchStudent> SearchStudents { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=DESKTOP-3MP3VAU\\SQLEXPRESS;initial catalog=OnlineExam;trusted_connection=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AdminLogin>(entity =>
            {
                entity.HasKey(e => e.Adminid)
                    .HasName("PK__Admin_Lo__AD040D7EF2B3F22A");

                entity.ToTable("Admin_Login");

                entity.Property(e => e.Adminid)
                    .ValueGeneratedNever()
                    .HasColumnName("adminid");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("password");
            });

            modelBuilder.Entity<AdminRegister>(entity =>
            {
                entity.HasKey(e => e.Adminid)
                    .HasName("PK__Admin_Re__AD040D7E682FA7D5");

                entity.ToTable("Admin_Register");

                entity.Property(e => e.Adminid)
                    .ValueGeneratedNever()
                    .HasColumnName("adminid");

                entity.Property(e => e.AdminDob)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("adminDob");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("city");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Mobile)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("mobile");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("password");

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("state");
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Login");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("password");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.HasOne(d => d.User)
                    .WithMany()
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Login__userId__15502E78");
            });

            modelBuilder.Entity<QuestionBank>(entity =>
            {
                entity.HasKey(e => e.QuestionId)
                    .HasName("PK__Question__6238D4B234EEB4F5");

                entity.ToTable("Question_Bank");

                entity.Property(e => e.QuestionId)
                    .ValueGeneratedNever()
                    .HasColumnName("questionId");

                entity.Property(e => e.Answer)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("answer");

                entity.Property(e => e.ExamLevel)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("examLevel");

                entity.Property(e => e.ExamSpecialization)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("examSpecialization");

                entity.Property(e => e.OptionA)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("optionA");

                entity.Property(e => e.OptionB)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("optionB");

                entity.Property(e => e.OptionC)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("optionC");

                entity.Property(e => e.OptionD)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("optionD");

                entity.Property(e => e.Question)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("question");
            });

            modelBuilder.Entity<Registration>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__Registra__CB9A1CFFCDA28FB0");

                entity.ToTable("Registration");

                entity.Property(e => e.UserId)
                    .ValueGeneratedNever()
                    .HasColumnName("userId");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .HasColumnName("city");

                entity.Property(e => e.DateOfBirth)
                    .HasMaxLength(50)
                    .HasColumnName("dateOfBirth");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.FullName)
                    .HasMaxLength(50)
                    .HasColumnName("fullName");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .HasColumnName("mobile");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .HasColumnName("password");

                entity.Property(e => e.Qualification)
                    .HasMaxLength(50)
                    .HasColumnName("qualification");

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .HasColumnName("state");

                entity.Property(e => e.YearOfCompletion)
                    .HasMaxLength(50)
                    .HasColumnName("yearOfCompletion");
            });

            modelBuilder.Entity<ReportCard>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Report_card");

                entity.Property(e => e.ExamLevel)
                    .HasMaxLength(50)
                    .HasColumnName("examLevel");

                entity.Property(e => e.ExamSpec)
                    .HasMaxLength(50)
                    .HasColumnName("examSpec");

                entity.Property(e => e.Marks).HasColumnName("marks");
            });

            modelBuilder.Entity<SearchStudent>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Search_Students");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Technology)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
