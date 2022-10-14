using Microsoft.EntityFrameworkCore;
using Src.Data;

var builder = WebApplication.CreateBuilder(args);

// string de conexao
builder.Services.AddDbContext<Context>(options =>                     
options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoPadrao")));  // poderia colocar aqui o "Server=localhost\\sqlserver...... que ta la em Development.json"
                                                                                    //Dessa forma é muito melhor caso eu queria mudar de banco de Dados So mudo lá em Development.json
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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
