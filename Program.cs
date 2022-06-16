using ConcertKanban.DBContext;
using KanBan;
using KanBan.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddControllers().AddNewtonsoftJson(options => {
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
} );
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add Db context
builder.Services.AddEntityFrameworkNpgsql()
    .AddDbContext<KanbanContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("KanbanDB")));


builder.Services.AddScoped<SprintRepository>();
builder.Services.AddScoped<CardRepository>();
builder.Services.AddScoped<UserRepository>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

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








