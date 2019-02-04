﻿// <auto-generated />
using System;
using Atividade1POO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Atividade1POO.Migrations
{
    [DbContext(typeof(StoreContext))]
    [Migration("20190204115226_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028");

            modelBuilder.Entity("Agencia", b =>
                {
                    b.Property<int>("idAgencia")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("BancoidBanco");

                    b.HasKey("idAgencia");

                    b.HasIndex("BancoidBanco");

                    b.ToTable("Agencias");
                });

            modelBuilder.Entity("Banco", b =>
                {
                    b.Property<int>("idBanco")
                        .ValueGeneratedOnAdd();

                    b.HasKey("idBanco");

                    b.ToTable("Bancos");
                });

            modelBuilder.Entity("Cliente", b =>
                {
                    b.Property<int>("idCliente")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("nome");

                    b.HasKey("idCliente");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("ContaCorrente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Saldo");

                    b.Property<string>("Titular");

                    b.HasKey("Id");

                    b.ToTable("ContasCorrentes");
                });

            modelBuilder.Entity("ContaPoupanca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataAniversario");

                    b.Property<decimal>("Juros");

                    b.Property<decimal>("Saldo");

                    b.Property<string>("Titular");

                    b.HasKey("Id");

                    b.ToTable("ContasPoupanca");
                });

            modelBuilder.Entity("Solicitacoes", b =>
                {
                    b.Property<int>("idSolicitacao")
                        .ValueGeneratedOnAdd();

                    b.HasKey("idSolicitacao");

                    b.ToTable("Solicitacoes");
                });

            modelBuilder.Entity("Agencia", b =>
                {
                    b.HasOne("Banco")
                        .WithMany("Agencias")
                        .HasForeignKey("BancoidBanco");
                });
#pragma warning restore 612, 618
        }
    }
}
