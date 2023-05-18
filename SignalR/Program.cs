using SignalR;   // ������������ ���� ������ ChatHub

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSignalR();      // ���������� ������� SignalR

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

app.MapHub<ClassHub>("/chat");   // ChatHub ����� ������������ ������� �� ���� /chat

app.Run();
