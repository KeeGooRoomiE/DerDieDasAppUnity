using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class AdditionalBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SendMailToSupport()
    {
        SendEmail();
    }

    public void OpenGWALink()
    {
        Application.OpenURL("www.germanwithandy.com");
    }

    public void OpenPreplyLink()
    {
        Application.OpenURL("https://preply.com/en/?pref=Mzg4NTU4");
    }

    public void OpenATLink()
    {
        Application.OpenURL("https://amazingtalker.com/invitee/Heyn9ZCKJCypzrZu1QSANHCj");
    }

    public void OpenAndyLink()
    {
        Application.OpenURL("www.artikel-andy.com");
    }

    private void SendEmail()
    {
        string email = "contact@laaany.com";
        string subject = MyEscapeURL("DerDieDas Support Request");
        string body = MyEscapeURL("Mail sended via DerDieDasApp.");
        Application.OpenURL("mailto:" + email + "?subject=" + subject + "&body=" + body);
    }

    //[System.Obsolete]
    string MyEscapeURL(string url)
    {
        return UnityWebRequest.EscapeURL(url).Replace("+", "%20");
    }
}
