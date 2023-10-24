
public class ChatHub : Hub
public class UsuarioService
{ 
 {
    private IHubContext<ChatHub> _hubContext;

    public UsuarioService(IHubContext<ChatHub> hubContext)
    {
        _hubContext = hubContext;
    }

    public async Task UsuarioIniciaSesion(string userId)
    {
        await _hubContext.Clients.All.SendAsync("UsuarioConectado", userId);
    }

    public async Task UsuarioCierraSesion(string userId)
    {
        await _hubContext.Clients.All.SendAsync("UsuarioDesconectado", userId);
    }
 }


    public async Task UsuarioConectado(string userId)
    {
        await Clients.All.SendAsync("UsuarioConectado", userId);
    }

    public async Task UsuarioDesconectado(string userId)
    {
        await Clients.All.SendAsync("UsuarioDesconectado", userId);
    }
}

