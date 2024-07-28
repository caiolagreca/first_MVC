var builder = WebApplication.CreateBuilder(args);

// Adicionar serviços MVC ao contêiner
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configurar o pipeline de solicitação HTTP
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
