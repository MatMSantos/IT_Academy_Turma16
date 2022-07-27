var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//builder.Services.Add... Lista grande de serviços (configurados no injetor de dependências)
//asp.net controla quando adicionar serviços

//builder.Services.AddLogging();

// Builder cria o objeto configurado com todos os serviços adicionados anteriormente
var app = builder.Build();


// Middleware
// Escadinha de requisições

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // HSTS cuida de segurança
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"); // Se ninguém passar nada, controller é Home, action é Index e Id pode ser nula
    // https://localhost:7133 é o mesmo que https://localhost:7096/Home/Index
    // Este é o roteador, ele mapeia para controle e ação (ROTAS!)
    // Requisição é redirecionada.
    // Controlador (neste caso Home) executa uma ação (neste caso Index)

// Execute o aplicativo
// Aplicação no ar
app.Run();
