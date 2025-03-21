namespace Model.Entities;

public class LogInState
{
    public LogIn CurrentSession { get; set; }

    public void SetSession(LogIn session)
    {
        CurrentSession = session;
    }

    public void ClearSession()
    {
        CurrentSession = null;
    }
}