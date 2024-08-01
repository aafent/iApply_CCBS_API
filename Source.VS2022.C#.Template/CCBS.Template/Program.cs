/*
    MIT License

    Copyright (c) 1996-2024 Relational SA / Part of iApply Platform

    Permission is hereby granted, free of charge, to any person obtaining a copy
    of this software and associated documentation files (the "Software"), to deal
    in the Software without restriction, including without limitation the rights
    to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
    copies of the Software, and to permit persons to whom the Software is
    furnished to do so, subject to the following conditions:

    The above copyright notice and this permission notice shall be included in all
    copies or substantial portions of the Software.

    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
    IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
    FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
    AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
    LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
    OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
    SOFTWARE.
*/
using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

#region (+) OpenAPI
builder.Services.AddSwaggerGen(c =>
{

    // https://www.c-sharpcorner.com/article/using-xml-comments-as-web-api-documentation-with-swagger/
    string xmlHelpFilename = Path.Combine(AppContext.BaseDirectory, $"{Assembly.GetExecutingAssembly().GetName().Name}.xml");
    bool enableComments = File.Exists(xmlHelpFilename);

    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "CCBS Template API v1.0.230918",
        Version = "v1",
        Description = "Common Core Banking System API Bank's side.",

        TermsOfService = new Uri("https://www.relationalfs.com/legal-information/#"),
        Contact = new OpenApiContact
        {
            Name = "Find CCBS on GitHub",
            Url = new Uri("https://github.com/aafent/iApply_CCBS_API")
        },
        License = new OpenApiLicense
        {
            Name = "Apache 2.0",
            Url = new Uri("http://www.apache.org/licenses/LICENSE-2.0.html")
        }
        //,Extensions = new Dictionary<string, IOpenApiExtension>
        //{
        //    { "x-company", new OpenApiString("Company Name") },
        //    { "x-contact", new OpenApiString("contact@email.com") }
        //}

    });

    //c.DocInclusionPredicate((_, api) => !string.IsNullOrWhiteSpace(api.GroupName));
    c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());

    if (enableComments)
    {
        c.IncludeXmlComments(xmlHelpFilename); // (<) enable notes and comments to the swagger

        if (File.Exists("iApplyShared.CCBS.Shared.xml")) c.IncludeXmlComments("iApplyShared.CCBS.Shared.xml");
        if (File.Exists("iApplyDataAccess.xml")) c.IncludeXmlComments("iApplyDataAccess.xml");
    }

});
#endregion (+) OpenAPI


//builder.Services.AddSingleton<ServiceInjections>(injections);



var app = builder.Build();

//Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint($"v1/swagger.json", "CCBS API");
    });
}


app.UseStaticFiles();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
