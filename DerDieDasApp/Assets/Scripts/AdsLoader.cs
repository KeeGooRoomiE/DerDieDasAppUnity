using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SA.CrossPlatform.Advertisement;

public class AdsLoader : MonoBehaviour
{
    UM_iAdsClient client = UM_AdvertisementService.GetClient(UM_AdPlatform.Google);

    void Awake()
    {

//        Android

//Banner:
//ca - app - pub - 5730952597017034~5802531684
//ca - app - pub - 5730952597017034 / 5610959993

//Interstitial:
//        ca - app - pub - 5730952597017034~5802531684
//ca - app - pub - 5730952597017034 / 1024013575

//iOS

//Banner:
//ca - app - pub - 5730952597017034~1883661494
//ca - app - pub - 5730952597017034 / 1013432952

//Interstitial
//ca - app - pub - 5730952597017034~1883661494
//ca - app - pub - 5730952597017034 / 7526870416

        var settins = UM_GoogleAdsSettings.Instance;
        var android = settins.AndroidIds;

        android.AppId = "ca-app-pub-5730952597017034~5802531684";
        android.BannerId = "app-pub-5730952597017034/5610959993";
        android.RewardedId = "ca-app-pub-5730952597017034/1024013575";
        android.NonRewardedId = "ca-app-pub-5730952597017034/1024013575";

        var ios = settins.IOSIds;
        ios.AppId = "ca-app-pub-5730952597017034~1883661494";
        ios.BannerId = "ca-app-pub-5730952597017034/1013432952";
        ios.RewardedId = "ca-app-pub-5730952597017034/7526870416";
        ios.NonRewardedId = "ca-app-pub-5730952597017034/7526870416";

        RequestInterstitial();
        RequestBanner();
    }

    private void RequestBanner()
    {
        client.Banner.Load((result) =>
        {
            if (result.IsSucceeded)
            {
                Debug.Log("Banner ad loaded");
                if (client.Banner.IsReady == true) {
                    ShowBanner();
                }
            }
            else
            {
                Debug.Log("Failed to load banner ads: " + result.Error.Message);
            }
        });

        bool ready = client.Banner.IsReady;
    }

    private void RequestInterstitial()
    {
        client.NonRewardedAds.Load((result) =>
        {
            if (result.IsSucceeded)
            {
                Debug.Log("NonRewardedAds loaded");
            }
            else
            {
                Debug.Log("Failed to load NonRewardedAds: " + result.Error.Message);
            }
        });

        bool ready = client.Banner.IsReady;
    }


    public void ShowBanner()
    {

        client.Banner.Show(() => {
            Debug.Log("Banner Appeared");
        });
    }

    public void ShowInterst()
    {
        client.NonRewardedAds.Show(() => {
            Debug.Log("Non Rewarded Ads closed");
        });
    }

    public void HideBanner()
    {
        client.Banner.Hide();
    }
}
