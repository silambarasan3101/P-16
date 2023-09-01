using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assign_16.Migrations
{

    [DbContext(typeof(TaskDBContext))]
    [Migration("20230901094237_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        public partial class EmployeeMig : Migration
        {
            /// <inheritdoc />
            protected override void BuildTargetModel(ModelBuilder modelBuilder)
            {
#pragma warning disable 612, 618
                modelBuilder
                    .HasAnnotation("ProductVersion", "7.0.10")
                    .HasAnnotation("Relational:MaxIdentifierLength", 128);

                SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

                modelBuilder.Entity("Assign16.Models.Task", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Task");
                });
#pragma warning restore 612, 618
            }

            protected override void Up(MigrationBuilder migrationBuilder)
            {
                throw new NotImplementedException();
            }
        }

    }

    internal class TaskDBContext
    {
    }
}


