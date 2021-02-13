using System.Collections.Generic;
using Dapper;
using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace _NET_React_Boiler
{


    public class /*RepoClassName*/ : BaseRepository, IRepository</*classNameType*/>
    {

        public /*RepoClassName*/(IConfiguration configuration) : base(configuration) { }
public async Task<IEnumerable</*ClassNameType*/>> GetAll()
{
    using var connection = CreateConnection();
    return await connection.QueryAsync</*ClassNameType*/>("SELECT * FROM Learnings;");
}
public async Task</*ClassNameType*/> GetOne(long id)
{
    using var connection = CreateConnection();
    return await connection.QuerySingleAsync</*ClassNameType*/>("SELECT * FROM Learnings WHERE Id = @Id", new { Id = id });
}

public async Task</*ClassNameType*/> Insert(/*ClassNameType*/ TodayILearned)
{
    using var connection = CreateConnection();
    return await connection.QuerySingleAsync</*ClassNameType*/>("INSERT INTO Learnings (Name, Learned) Values (@Name, @Learned)", new { Name = /*ClassNameType*/.Name, Learned = /*ClassNameType*/.Learned });
}

public async Task Delete(long id)
{
    using var connection = CreateConnection();
    await connection.ExecuteAsync("DELETE FROM Learnings WHERE Id = @Id", new { Id = id });
}

    }
}