module DBModel

open Microsoft.EntityFrameworkCore
open EntityFrameworkCore.FSharp.Extensions
open System
open Microsoft.Extensions.Logging

[<CLIMutable>]
type Blog =
    { Id: int
      Title: string
      Content: string option }

type DBModelContext() =
    inherit DbContext()

    [<DefaultValue>]
    val mutable blogs: DbSet<Blog>

    member this.Blogs
        with get () = this.blogs
        and set v = this.blogs <- v

    override _.OnModelCreating builder = builder.RegisterOptionTypes()

    override _.OnConfiguring options =
        options.UseMySql(
            "server=localhost;user=testdb;password=abc123;database=testdb",
            MariaDbServerVersion(Version(10, 8, 3))
        )
        |> ignore
