using Blazored.LocalStorage;

namespace Client.Web.Services;

public class TokenProvider
{
    private readonly ILocalStorageService _localStorage;
    private string _accessToken = string.Empty;

    public TokenProvider(ILocalStorageService localStorage)
    {
        _localStorage = localStorage;
    }

    public string AccessToken => _accessToken;

    public event Action? OnTokenChanged;

    public async Task InitAsync()
    {
        _accessToken = await _localStorage.GetItemAsync<string>("accessToken") ?? string.Empty;
        OnTokenChanged?.Invoke();
    }

    public async void SetToken(string token)
    {
        _accessToken = token;
        await _localStorage.SetItemAsync("accessToken", token);
        OnTokenChanged?.Invoke();
    }

    public async void ClearToken()
    {
        _accessToken = string.Empty;
        await _localStorage.RemoveItemAsync("accessToken");
        OnTokenChanged?.Invoke();
    }

    internal string GetToken()
    {
        return _accessToken;
    }
}
