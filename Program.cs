using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.VisualBasic;
using System;
using System.Diagnostics;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
/*
 * Student Name: Jadepat Chernsonthi
 * Student Number: 041074866
 * Student Email: cher0151@algonquinlive.com
 * Course & Section #: 23F_CST8333_370
 */

var builder = WebApplication.CreateBuilder(args);

#region "add cors origin/policy"
builder.Services.AddCors();
builder.Services.AddCors(options =>
{
    options.AddPolicy("Access-Control-Allow-Origin", p =>
    {
        p.AllowAnyOrigin()
        .AllowAnyHeader()
        .AllowAnyMethod();
    });
    options.AddPolicy("CorsPolicy",
 builder => builder.AllowAnyOrigin()
     .AllowAnyMethod()
     .AllowAnyHeader());

});
#endregion

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

#region "use cors origin"
app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
app.UseCors("Access-Control-Allow-Origin");
app.UseCors("CorsPolicy");
#endregion

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

//app.Run();
#region "starting app script"
// ASP.NET Core Server application start script
var hostThread = new Thread(() =>
{
    app.Run();
});
// Start server thread
hostThread.Start();

// Angular Client application start script
var ngThread = new Thread(() =>
{
    System.Diagnostics.Process process = new System.Diagnostics.Process();
    process.StartInfo.FileName = "cmd.exe";
    // Change dir to client, if success run Angular CLI to start client app
    process.StartInfo.Arguments = "/C cd ../PracticalProjectClient/Client && ng serve --o";
    process.Start();
});

// Strat Client application
ngThread.Start();

// Wait for both threads to finish
hostThread.Join();
ngThread.Join();
#endregion