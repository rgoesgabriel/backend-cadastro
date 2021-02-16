﻿// <auto-generated />
using System;
using EFCore.WebAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCore.WebAPI.Migrations
{
    [DbContext(typeof(PessoaContext))]
    [Migration("20210216030509_alteracoes2")]
    partial class alteracoes2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFCore.WebAPI.Models.Dependente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DtNascimento");

                    b.Property<string>("Nome");

                    b.Property<int?>("PessoaId");

                    b.HasKey("Id");

                    b.HasIndex("PessoaId");

                    b.ToTable("Dependentes");
                });

            modelBuilder.Entity("EFCore.WebAPI.Models.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao");

                    b.Property<string>("Nome");

                    b.Property<int?>("PessoaId");

                    b.HasKey("Id");

                    b.HasIndex("PessoaId");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("EFCore.WebAPI.Models.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DependenteId");

                    b.Property<DateTime>("DtNascimento");

                    b.Property<int>("EnderecoId");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Pessoas");
                });

            modelBuilder.Entity("EFCore.WebAPI.Models.Dependente", b =>
                {
                    b.HasOne("EFCore.WebAPI.Models.Pessoa")
                        .WithMany("Dependentes")
                        .HasForeignKey("PessoaId");
                });

            modelBuilder.Entity("EFCore.WebAPI.Models.Endereco", b =>
                {
                    b.HasOne("EFCore.WebAPI.Models.Pessoa")
                        .WithMany("Enderecos")
                        .HasForeignKey("PessoaId");
                });
#pragma warning restore 612, 618
        }
    }
}
