using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using GoogleMobileAds.Api;

public class AdsLoader : MonoBehaviour
{
    //private InterstitialAd interstitial;
    //private BannerView bannerView;

    // Start is called before the first frame update
    void Awake()
    {
        // Initialize the Google Mobile Ads SDK.
        //MobileAds.Initialize(initStatus => { });
        RequestInterstitial();
        RequestBanner();
    }

    private void RequestInterstitial()
    {
#if UNITY_ANDROID
        string adUnitId = "ca-app-pub-5730952597017034/1024013575";
#elif UNITY_IPHONE
        string adUnitId = "ca-app-pub-5730952597017034/7526870416";
#else
        string adUnitId = "unexpected_platform";
#endif

        // Initialize an InterstitialAd.
        //interstitial = new InterstitialAd(adUnitId);

        // Create an empty ad request.
        //AdRequest request = new AdRequest.Builder().Build();
        // Load the interstitial with the request.
        //interstitial.LoadAd(request);
    }

    private void RequestBanner()
    {
#if UNITY_ANDROID
            string adUnitId = "ca-app-pub-5730952597017034/5610959993";
#elif UNITY_IPHONE
            string adUnitId = "ca-app-pub-5730952597017034/1013432952";
#else
        string adUnitId = "unexpected_platform";
#endif
        // Custom size of the banner
        //AdSize adSize = new AdSize(250, 250);
        // Create a 320x50 banner at the top of the screen.
        //bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Bottom);

        // Create an empty ad request.
        //AdRequest request = new AdRequest.Builder().Build();

        // Load the banner with the request.
        //bannerView.LoadAd(request);
    }

    public void ShowAds()
    {
        //if (interstitial.IsLoaded())
        {
            //interstitial.Show();
        }
    }
}
