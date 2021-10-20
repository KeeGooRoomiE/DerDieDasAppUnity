using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using SA.CrossPlatform.Advertisement;
using GoogleMobileAds.Api;

public class AdsLoader : MonoBehaviour
{
    //UM_iAdsClient client = UM_AdvertisementService.GetClient(UM_AdPlatform.Google);
    // Create a 320x50 banner ad at coordinate (0,50) on screen.
    //string adUnitId = "unexpected_platform";
    //BannerView bannerView = new BannerView(adUnitId, AdSize.Banner, 0, 50);
    private BannerView bannerView;
    private InterstitialAd interstitial;

    public void Awake()
    {
        // Initialize the Google Mobile Ads SDK.
        MobileAds.Initialize(initStatus => { });

        this.RequestBanner();
        this.RequestInterstitial();
        
    }

    private void RequestBanner()
    {
#if UNITY_ANDROID
        string adUnitId = "ca-app-pub-5730952597017034/5610959993";
#elif UNITY_IPHONE
            string adUnitId = "ca-app-pub-5730952597017034~1883661494";
#else
            string adUnitId = "unexpected_platform";
#endif

        this.bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Top);

        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();

        // Load the banner with the request.
        this.bannerView.LoadAd(request);
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
        this.interstitial = new InterstitialAd(adUnitId);
        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the interstitial with the request.
        this.interstitial.LoadAd(request);
    }

    public void ShowInterstitial()
    {
        if (this.interstitial.IsLoaded())
        {
            this.interstitial.Show();
        } else
        {
            this.RequestInterstitial();
        }
    }
    //void Awake()
    //{

    //        Android

    //Banner:
    //ca-app-pub-5730952597017034~5802531684
    //ca-app-pub-5730952597017034/5610959993

    //Interstitial:
    //ca-app-pub-5730952597017034~5802531684
    //ca-app-pub-5730952597017034/1024013575

    //iOS

    //Banner:
    //ca-app-pub-5730952597017034~1883661494
    //ca-app-pub-5730952597017034/1013432952

    //Interstitial
    //ca-app-pub-5730952597017034~1883661494
    //ca-app-pub-5730952597017034/7526870416

    //    var settins = UM_GoogleAdsSettings.Instance;
    //    var android = settins.AndroidIds;

    //    android.AppId = "ca-app-pub-5730952597017034~5802531684";
    //    android.BannerId = "app-pub-5730952597017034/5610959993";
    //    android.RewardedId = "ca-app-pub-5730952597017034/1024013575";
    //    android.NonRewardedId = "ca-app-pub-5730952597017034/1024013575";

    //    var ios = settins.IOSIds;
    //    ios.AppId = "ca-app-pub-5730952597017034~1883661494";
    //    ios.BannerId = "ca-app-pub-5730952597017034/1013432952";
    //    ios.RewardedId = "ca-app-pub-5730952597017034/7526870416";
    //    ios.NonRewardedId = "ca-app-pub-5730952597017034/7526870416e";

    //    RequestInterstitial();
    //    RequestBanner();
    //}

    //private void RequestBanner()
    //{
    //    client.Banner.Load((result) =>
    //    {
    //        if (result.IsSucceeded)
    //        {
    //            Debug.Log("Banner ad loaded");
    //            if (client.Banner.IsReady == true) {
    //                ShowBanner();
    //            }
    //        }
    //        else
    //        {
    //            Debug.Log("Failed to load banner ads: " + result.Error.Message);
    //        }
    //    });

    //    bool ready = client.Banner.IsReady;
    //}

    //private void RequestInterstitial()
    //{
    //    client.NonRewardedAds.Load((result) =>
    //    {
    //        if (result.IsSucceeded)
    //        {
    //            Debug.Log("NonRewardedAds loaded");
    //        }
    //        else
    //        {
    //            Debug.Log("Failed to load NonRewardedAds: " + result.Error.Message);
    //        }
    //    });

    //    bool ready = client.Banner.IsReady;
    //}


    //public void ShowBanner()
    //{

    //    client.Banner.Show(() => {
    //        Debug.Log("Banner Appeared");
    //    });
    //}

    //public void ShowInterst()
    //{
    //    client.NonRewardedAds.Show(() => {
    //        Debug.Log("Non Rewarded Ads closed");
    //    });
    //}

    //public void HideBanner()
    //{
    //    client.Banner.Hide();
    //}
}
