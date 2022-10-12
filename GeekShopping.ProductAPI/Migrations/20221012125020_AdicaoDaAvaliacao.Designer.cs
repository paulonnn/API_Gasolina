﻿// <auto-generated />
using API_Gasolina.GasolinaAPI.Model.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API_Gasolina.Migrations
{
    [DbContext(typeof(MySQLContext))]
    [Migration("20221012125020_AdicaoDaAvaliacao")]
    partial class AdicaoDaAvaliacao
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("API_Gasolina.GasolinaAPI.Model.Avaliacao", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<string>("Data")
                        .HasColumnType("longtext")
                        .HasColumnName("data");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext")
                        .HasColumnName("descricao");

                    b.Property<string>("IdUsuarioTelegram")
                        .HasColumnType("longtext")
                        .HasColumnName("idusuariotelegram");

                    b.Property<int>("Nota")
                        .HasColumnType("int")
                        .HasColumnName("nota");

                    b.HasKey("Id");

                    b.ToTable("avaliacao");
                });

            modelBuilder.Entity("API_Gasolina.GasolinaAPI.Model.Registro_cotacao", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<string>("Data")
                        .HasColumnType("longtext")
                        .HasColumnName("data");

                    b.Property<string>("Estado")
                        .HasColumnType("longtext")
                        .HasColumnName("estado");

                    b.Property<string>("Municipio")
                        .HasColumnType("longtext")
                        .HasColumnName("municipio");

                    b.Property<int>("Numero_de_postos_pesquisados")
                        .HasColumnType("int")
                        .HasColumnName("numero_de_postos_pesquisados");

                    b.Property<double>("Preco_maximo_revenda")
                        .HasColumnType("double")
                        .HasColumnName("preco_maximo_revenda");

                    b.Property<double>("Preco_medio_revenda")
                        .HasColumnType("double")
                        .HasColumnName("preco_medio_revenda");

                    b.Property<double>("Preco_minimo_revenda")
                        .HasColumnType("double")
                        .HasColumnName("preco_minimo_revenda");

                    b.Property<string>("Produto")
                        .HasColumnType("longtext")
                        .HasColumnName("produto");

                    b.HasKey("Id");

                    b.ToTable("registro_cotacao");
                });
#pragma warning restore 612, 618
        }
    }
}
