global using OnlineExams.Models;
global using System.Text.Json;
global using OnlineExams.Brokers.JsonBroker;
global using  OnlineExams.Extensions;
global using Microsoft.AspNetCore.Components.Web;
global using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
global using OnlineExams;
global using OnlineExams.Services.Foundation;
global using Microsoft.AspNetCore.Components;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddSingleton<IJsonBroker, JsonBroker>();
builder.Services.AddSingleton<IExamService, ExamService>();
builder.Services.AddSingleton(sp => new HttpClient { BaseAddress = new (builder.HostEnvironment.BaseAddress) });
await builder.Build().RunAsync();