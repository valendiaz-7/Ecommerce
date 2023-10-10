﻿// <auto-generated />
using System;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(EcommercedbContext))]
    [Migration("20231010024042_descripcionmaxima")]
    partial class descripcionmaxima
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DataAccess.Entities.Categoria", b =>
                {
                    b.Property<int>("IdCategoria")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("idCategoria");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("descripcion");

                    b.Property<DateTime>("FechaDesde")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("FechaHasta")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("FechaModificacion")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("IdCategoria")
                        .HasName("PRIMARY");

                    b.ToTable("categoria", (string)null);
                });

            modelBuilder.Entity("DataAccess.Entities.Domicilio", b =>
                {
                    b.Property<int>("IdDomicilio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("idDomicilio");

                    b.Property<int>("Altura")
                        .HasColumnType("int")
                        .HasColumnName("altura");

                    b.Property<string>("Calle")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("calle");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int")
                        .HasColumnName("id_usuario");

                    b.HasKey("IdDomicilio")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdUsuario" }, "id_usuario_FK_idx");

                    b.ToTable("domicilio", (string)null);
                });

            modelBuilder.Entity("DataAccess.Entities.EfmigrationsHistory", b =>
                {
                    b.Property<string>("MigrationId")
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("ProductVersion")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.HasKey("MigrationId")
                        .HasName("PRIMARY");

                    b.ToTable("__EFMigrationsHistory", (string)null);
                });

            modelBuilder.Entity("DataAccess.Entities.Envio", b =>
                {
                    b.Property<int>("IdEnvio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("idEnvio");

                    b.Property<string>("CodigoSeguimiento")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("codigo_seguimiento");

                    b.Property<int>("IdDomicilio")
                        .HasColumnType("int")
                        .HasColumnName("id_domicilio");

                    b.Property<int>("IdPedido")
                        .HasColumnType("int")
                        .HasColumnName("id_pedido");

                    b.HasKey("IdEnvio")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdDomicilio" }, "id_domicilio_idx");

                    b.HasIndex(new[] { "IdPedido" }, "id_pedido_FK_idx");

                    b.HasIndex(new[] { "IdPedido" }, "id_pedido_UNIQUE")
                        .IsUnique();

                    b.ToTable("envio", (string)null);
                });

            modelBuilder.Entity("DataAccess.Entities.Estadopedido", b =>
                {
                    b.Property<int>("IdEstadoPedido")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("idEstadoPedido");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("descripcion");

                    b.HasKey("IdEstadoPedido")
                        .HasName("PRIMARY");

                    b.ToTable("estadopedido", (string)null);
                });

            modelBuilder.Entity("DataAccess.Entities.Estadopublicacion", b =>
                {
                    b.Property<int>("IdEstadoPublicacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("idEstadoPublicacion");

                    b.Property<string>("Descripcion")
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("descripcion");

                    b.HasKey("IdEstadoPublicacion")
                        .HasName("PRIMARY");

                    b.ToTable("estadopublicacion", (string)null);
                });

            modelBuilder.Entity("DataAccess.Entities.Pedido", b =>
                {
                    b.Property<int>("IdPedido")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("idPedido");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int")
                        .HasColumnName("cantidad");

                    b.Property<int>("IdEstadoPedido")
                        .HasColumnType("int")
                        .HasColumnName("id_estado_pedido");

                    b.Property<int>("IdPublicacion")
                        .HasColumnType("int")
                        .HasColumnName("id_publicacion");

                    b.Property<int?>("IdSucursal")
                        .HasColumnType("int")
                        .HasColumnName("id_sucursal");

                    b.Property<int>("IdTipoEntrega")
                        .HasColumnType("int")
                        .HasColumnName("id_tipo_entrega");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int")
                        .HasColumnName("id_usuario");

                    b.Property<string>("Token")
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("token");

                    b.HasKey("IdPedido")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdEstadoPedido" }, "id_estado_pedido_FK_idx");

                    b.HasIndex(new[] { "IdPublicacion" }, "id_publicacion_FK_idx");

                    b.HasIndex(new[] { "IdSucursal" }, "id_sucursal_FK_idx");

                    b.HasIndex(new[] { "IdTipoEntrega" }, "id_tipo_entrega_FK_idx");

                    b.HasIndex(new[] { "IdUsuario" }, "id_usuario_FK_idx1");

                    b.ToTable("pedido", (string)null);
                });

            modelBuilder.Entity("DataAccess.Entities.Producto", b =>
                {
                    b.Property<int>("IdProducto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("idProducto");

                    b.Property<string>("Descripcion")
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("descripcion");

                    b.Property<DateTime>("FechaAlta")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("FechaBaja")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("FechaModificacion")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IdCategoria")
                        .HasColumnType("int")
                        .HasColumnName("id_categoria");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UrlImagen")
                        .HasColumnType("longtext");

                    b.HasKey("IdProducto")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdCategoria" }, "id_categoria_FK_idx");

                    b.ToTable("producto", (string)null);
                });

            modelBuilder.Entity("DataAccess.Entities.Publicacion", b =>
                {
                    b.Property<int>("IdPublicacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("idPublicacion");

                    b.Property<DateTime>("FechaDesde")
                        .HasColumnType("datetime")
                        .HasColumnName("fecha_desde");

                    b.Property<DateTime?>("FechaHasta")
                        .HasColumnType("datetime")
                        .HasColumnName("fecha_hasta");

                    b.Property<int?>("IdEstado")
                        .HasColumnType("int")
                        .HasColumnName("id_estado");

                    b.Property<int>("IdProducto")
                        .HasColumnType("int")
                        .HasColumnName("id_producto");

                    b.Property<float?>("Precio")
                        .HasColumnType("float")
                        .HasColumnName("precio");

                    b.Property<int>("Stock")
                        .HasColumnType("int")
                        .HasColumnName("stock");

                    b.HasKey("IdPublicacion")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdEstado" }, "id_estadopublicacion_fk1_idx");

                    b.HasIndex(new[] { "IdProducto" }, "id_producto_fkp_idx");

                    b.ToTable("publicacion", (string)null);
                });

            modelBuilder.Entity("DataAccess.Entities.Rol", b =>
                {
                    b.Property<int>("IdRol")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("idRol");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("descripcion");

                    b.HasKey("IdRol")
                        .HasName("PRIMARY");

                    b.ToTable("rol", (string)null);
                });

            modelBuilder.Entity("DataAccess.Entities.Sucursal", b =>
                {
                    b.Property<int>("IdSucursal")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("idSucursal");

                    b.HasKey("IdSucursal")
                        .HasName("PRIMARY");

                    b.ToTable("sucursal", (string)null);
                });

            modelBuilder.Entity("DataAccess.Entities.Usuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("idUsuario");

                    b.Property<string>("Apellido")
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("apellido");

                    b.Property<int?>("Dni")
                        .HasColumnType("int")
                        .HasColumnName("dni");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("email");

                    b.Property<int>("IdRol")
                        .HasColumnType("int")
                        .HasColumnName("id_rol");

                    b.Property<string>("Nombre")
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("nombre");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("password");

                    b.Property<int?>("Telefono")
                        .HasColumnType("int")
                        .HasColumnName("telefono");

                    b.HasKey("IdUsuario")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "Dni" }, "dni_UNIQUE")
                        .IsUnique();

                    b.HasIndex(new[] { "Email" }, "email_UNIQUE")
                        .IsUnique();

                    b.HasIndex(new[] { "IdRol" }, "id_rol_FK_idx");

                    b.ToTable("usuario", (string)null);
                });

            modelBuilder.Entity("DataAccess.Entities.Domicilio", b =>
                {
                    b.HasOne("DataAccess.Entities.Usuario", "IdUsuarioNavigation")
                        .WithMany("Domicilio")
                        .HasForeignKey("IdUsuario")
                        .IsRequired()
                        .HasConstraintName("id_usuario_FK2");

                    b.Navigation("IdUsuarioNavigation");
                });

            modelBuilder.Entity("DataAccess.Entities.Envio", b =>
                {
                    b.HasOne("DataAccess.Entities.Domicilio", "IdDomicilioNavigation")
                        .WithMany("Envio")
                        .HasForeignKey("IdDomicilio")
                        .IsRequired()
                        .HasConstraintName("id_domicilio");

                    b.HasOne("DataAccess.Entities.Pedido", "IdPedidoNavigation")
                        .WithOne("Envio")
                        .HasForeignKey("DataAccess.Entities.Envio", "IdPedido")
                        .IsRequired()
                        .HasConstraintName("id_pedido_FK");

                    b.Navigation("IdDomicilioNavigation");

                    b.Navigation("IdPedidoNavigation");
                });

            modelBuilder.Entity("DataAccess.Entities.Pedido", b =>
                {
                    b.HasOne("DataAccess.Entities.Estadopedido", "IdEstadoPedidoNavigation")
                        .WithMany("Pedido")
                        .HasForeignKey("IdEstadoPedido")
                        .IsRequired()
                        .HasConstraintName("id_estado_pedido_FK");

                    b.HasOne("DataAccess.Entities.Publicacion", "IdPublicacionNavigation")
                        .WithMany("Pedido")
                        .HasForeignKey("IdPublicacion")
                        .IsRequired()
                        .HasConstraintName("id_publicacion_FK");

                    b.HasOne("DataAccess.Entities.Sucursal", "IdSucursalNavigation")
                        .WithMany("Pedido")
                        .HasForeignKey("IdSucursal")
                        .HasConstraintName("id_sucursal_FK");

                    b.HasOne("DataAccess.Entities.Usuario", "IdUsuarioNavigation")
                        .WithMany("Pedido")
                        .HasForeignKey("IdUsuario")
                        .IsRequired()
                        .HasConstraintName("id_usuario_FK");

                    b.Navigation("IdEstadoPedidoNavigation");

                    b.Navigation("IdPublicacionNavigation");

                    b.Navigation("IdSucursalNavigation");

                    b.Navigation("IdUsuarioNavigation");
                });

            modelBuilder.Entity("DataAccess.Entities.Producto", b =>
                {
                    b.HasOne("DataAccess.Entities.Categoria", "IdCategoriaNavigation")
                        .WithMany("Producto")
                        .HasForeignKey("IdCategoria")
                        .IsRequired()
                        .HasConstraintName("id_categoria_FK");

                    b.Navigation("IdCategoriaNavigation");
                });

            modelBuilder.Entity("DataAccess.Entities.Publicacion", b =>
                {
                    b.HasOne("DataAccess.Entities.Estadopublicacion", "IdEstadoNavigation")
                        .WithMany("Publicacion")
                        .HasForeignKey("IdEstado")
                        .HasConstraintName("id_estadopublicacion_fk1");

                    b.HasOne("DataAccess.Entities.Producto", "IdProductoNavigation")
                        .WithMany("Publicacion")
                        .HasForeignKey("IdProducto")
                        .IsRequired()
                        .HasConstraintName("id_producto_fkp");

                    b.Navigation("IdEstadoNavigation");

                    b.Navigation("IdProductoNavigation");
                });

            modelBuilder.Entity("DataAccess.Entities.Usuario", b =>
                {
                    b.HasOne("DataAccess.Entities.Rol", "IdRolNavigation")
                        .WithMany("Usuario")
                        .HasForeignKey("IdRol")
                        .IsRequired()
                        .HasConstraintName("id_rol_FK");

                    b.Navigation("IdRolNavigation");
                });

            modelBuilder.Entity("DataAccess.Entities.Categoria", b =>
                {
                    b.Navigation("Producto");
                });

            modelBuilder.Entity("DataAccess.Entities.Domicilio", b =>
                {
                    b.Navigation("Envio");
                });

            modelBuilder.Entity("DataAccess.Entities.Estadopedido", b =>
                {
                    b.Navigation("Pedido");
                });

            modelBuilder.Entity("DataAccess.Entities.Estadopublicacion", b =>
                {
                    b.Navigation("Publicacion");
                });

            modelBuilder.Entity("DataAccess.Entities.Pedido", b =>
                {
                    b.Navigation("Envio");
                });

            modelBuilder.Entity("DataAccess.Entities.Producto", b =>
                {
                    b.Navigation("Publicacion");
                });

            modelBuilder.Entity("DataAccess.Entities.Publicacion", b =>
                {
                    b.Navigation("Pedido");
                });

            modelBuilder.Entity("DataAccess.Entities.Rol", b =>
                {
                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("DataAccess.Entities.Sucursal", b =>
                {
                    b.Navigation("Pedido");
                });

            modelBuilder.Entity("DataAccess.Entities.Usuario", b =>
                {
                    b.Navigation("Domicilio");

                    b.Navigation("Pedido");
                });
#pragma warning restore 612, 618
        }
    }
}
