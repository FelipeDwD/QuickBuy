﻿// <auto-generated />
using System;
using Dwd.Lab.Repositorio.Contexto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Dwd.Lab.Repositorio.Migrations
{
    [DbContext(typeof(LabDataContext))]
    [Migration("20200127165400_RenameImagem")]
    partial class RenameImagem
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Dwd.Lab.Dominio.Entidades.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasMaxLength(12);

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasMaxLength(12);

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(8);

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<int>("Numero")
                        .HasMaxLength(4);

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("Dwd.Lab.Dominio.Entidades.ImagemUsuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("ImagemUsuario");
                });

            modelBuilder.Entity("Dwd.Lab.Dominio.Entidades.ItemPedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PedidoId");

                    b.Property<int>("ProdutoId")
                        .HasMaxLength(5);

                    b.Property<int>("Quantidade")
                        .HasMaxLength(4);

                    b.HasKey("Id");

                    b.HasIndex("PedidoId");

                    b.ToTable("ItemPedido");
                });

            modelBuilder.Entity("Dwd.Lab.Dominio.Entidades.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataPedido")
                        .HasMaxLength(11);

                    b.Property<DateTime>("DataPrevisaoEntrega")
                        .HasMaxLength(11);

                    b.Property<int>("EnderecoId");

                    b.Property<int>("FormaPagamentoId");

                    b.Property<int>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId");

                    b.HasIndex("FormaPagamentoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Pedido");
                });

            modelBuilder.Entity("Dwd.Lab.Dominio.Entidades.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<double>("Preco")
                        .HasMaxLength(12);

                    b.HasKey("Id");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("Dwd.Lab.Dominio.Entidades.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<int?>("ImagemId");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(400);

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.HasIndex("ImagemId");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("Dwd.Lab.Dominio.ObjetoDeValor.FormaPagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasMaxLength(100);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.ToTable("FormaPagamento");
                });

            modelBuilder.Entity("Dwd.Lab.Dominio.Entidades.ItemPedido", b =>
                {
                    b.HasOne("Dwd.Lab.Dominio.Entidades.Pedido", "Pedido")
                        .WithMany("ItemsPedido")
                        .HasForeignKey("PedidoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Dwd.Lab.Dominio.Entidades.Pedido", b =>
                {
                    b.HasOne("Dwd.Lab.Dominio.Entidades.Endereco", "Endereco")
                        .WithMany("Pedidos")
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Dwd.Lab.Dominio.ObjetoDeValor.FormaPagamento", "FormaPagamento")
                        .WithMany("Pedidos")
                        .HasForeignKey("FormaPagamentoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Dwd.Lab.Dominio.Entidades.Usuario", "Usuario")
                        .WithMany("Pedidos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Dwd.Lab.Dominio.Entidades.Usuario", b =>
                {
                    b.HasOne("Dwd.Lab.Dominio.Entidades.ImagemUsuario", "Imagem")
                        .WithMany()
                        .HasForeignKey("ImagemId");
                });
#pragma warning restore 612, 618
        }
    }
}
