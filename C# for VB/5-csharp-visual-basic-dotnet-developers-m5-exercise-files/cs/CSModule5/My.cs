using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Devices;
using System.Configuration;

public class My
{
    // Static members
    private static My _instance = null;

    public static My Instance
    {
        get 
        {
            if (_instance == null)
            {
                _instance = new My();
            }
            return _instance; 
        }
    }

    // Instance members
    private ApplicationBase _application = null;
    private Computer _computer = null;
    private SettingsContext _settings = null;
    private User _user = null;

    public ApplicationBase Application
    {
        get 
        {
            if (_application == null)
            {
                this._application = new ApplicationBase();
            }
            return this._application; 
        }
    }

    public Computer Computer
    {
        get 
        {
            if (this._computer == null)
            {
                this._computer = new Computer();
            }
            return this._computer; 
        }
    }

    public SettingsContext Settings
    {
        get 
        {
            if (this._settings == null)
            {
                this._settings = new SettingsContext();
            }
            return this._settings;
        }
    }

    public User User
    {
        get 
        {
            if (this._user == null)
            {
                this._user = new User();
            }
            return this._user;
        }
    }

    private My() { }
}
