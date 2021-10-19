using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
//using SA.Foundation.Utility;
//using SA.CrossPlatform.Social;

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


    
    //public void OpenShareDialog()
    //{
    //    var client = UM_SocialService.SharingClient;
    //    var builder = new UM_ShareDialogBuilder();
    //    builder.SetText("Hello world!");
    //    builder.SetUrl("https://laaany.com/");

    //    //Juts generating sample red texture with 32x32 resolution
    //    Texture2D sampleRedTexture = SA_IconManager.GetIcon(Color.red, 32, 32);
    //    builder.AddImage(sampleRedTexture);

    //    client.SystemSharingDialog(builder, (result) => {
    //        if (result.IsSucceeded)
    //        {
    //            Debug.Log("Sharing started ");
    //        }
    //        else
    //        {
    //            Debug.Log("Failed to share: " + result.Error.FullMessage);
    //        }
    //    });
    //}


    public void SendMailToSupport()
    {
        SendEmail();
    }

    public void OpenGWALink()
    {
        Application.OpenURL("https://www.germanwithandy.com");
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
        Application.OpenURL("https://www.artikel-andy.com");
    }

    private void SendEmail()
    {
        string email = "contact@laaany.com";
        string subject = MyEscapeURL("DerDieDas Support Request");
        string body = MyEscapeURL("Mail sent via DDD-App.");
        Application.OpenURL("mailto:" + email + "?subject=" + subject + "&body=" + body);
    }

    //[System.Obsolete]
    string MyEscapeURL(string url)
    {
        return UnityWebRequest.EscapeURL(url).Replace("+", "%20");
    }
}
