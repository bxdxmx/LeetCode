public class AuthenticationManager
{
    private int timeToLive;
    private Dictionary<string, int> sessions = new();

    public AuthenticationManager(int timeToLive)
    {
        this.timeToLive = timeToLive;
    }

    public void Generate(string tokenId, int currentTime)
    {
        sessions[tokenId] = currentTime + timeToLive;
    }

    public void Renew(string tokenId, int currentTime)
    {
        if (sessions.ContainsKey(tokenId))
        {
            if (sessions[tokenId] <= currentTime)
            {
                return;
            }
        }
        else
        {
            return;
        }

        sessions[tokenId] = currentTime + timeToLive;
    }

    public int CountUnexpiredTokens(int currentTime)
    {
        return sessions.Where( d => d.Value > currentTime).Count();
    }
}
