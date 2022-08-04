﻿// <auto-generated />
namespace ef_pomelo_fsharp.Migrations

open System
open Microsoft.EntityFrameworkCore
open Microsoft.EntityFrameworkCore.Infrastructure
open Microsoft.EntityFrameworkCore.Metadata
open Microsoft.EntityFrameworkCore.Migrations
open Microsoft.EntityFrameworkCore.Storage.ValueConversion

[<DbContext(typeof<DBModel.DBModelContext>)>]
[<Migration("20220804174220_test1")>]
type test1() =
    inherit Migration()

    override this.Up(migrationBuilder:MigrationBuilder) =
        migrationBuilder.AlterDatabase(
            ).Annotation("MySql:CharSet", "utf8mb4") |> ignore

        migrationBuilder.CreateTable(
            name = "Blogs"
            ,columns = (fun table -> 
            {|
                Id =
                    table.Column<int>(
                        nullable = false
                        ,``type`` = "int"
                    ).Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                Title =
                    table.Column<string>(
                        nullable = false
                        ,``type`` = "longtext"
                    ).Annotation("MySql:CharSet", "utf8mb4")
                Content =
                    table.Column<string>(
                        nullable = false
                        ,``type`` = "longtext"
                    ).Annotation("MySql:CharSet", "utf8mb4")
            |})
            , constraints =
                (fun table -> 
                    table.PrimaryKey("PK_Blogs", (fun x -> (x.Id) :> obj)
                    ) |> ignore
                )
        ).Annotation("MySql:CharSet", "utf8mb4") |> ignore


    override this.Down(migrationBuilder:MigrationBuilder) =
        migrationBuilder.DropTable(
            name = "Blogs"
            ) |> ignore


    override this.BuildTargetModel(modelBuilder: ModelBuilder) =
        modelBuilder
            .HasAnnotation("ProductVersion", "6.0.7")
            .HasAnnotation("Relational:MaxIdentifierLength", 64) |> ignore

        modelBuilder.Entity("DBModel+Blog", (fun b ->

            b.Property<int>("Id")
                .IsRequired(true)
                .ValueGeneratedOnAdd()
                .HasColumnType("int")
                |> ignore

            b.Property<string>("Content")
                .IsRequired(true)
                .HasColumnType("longtext")
                |> ignore

            b.Property<string>("Title")
                .IsRequired(true)
                .HasColumnType("longtext")
                |> ignore

            b.HasKey("Id")
                |> ignore


            b.ToTable("Blogs") |> ignore

        )) |> ignore

