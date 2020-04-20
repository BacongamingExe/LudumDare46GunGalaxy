using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;


public class Admanagermain : MonoBehaviour
{

    private BannerView bannerView;

    [SerializeField] private string appID = "ca-app-pub-2526099739887593~8043547647";

    [SerializeField] private string banner = "ca-app-pub-2526099739887593/4384585800";
    [SerializeField] private string regularAD = "ca-app-pub-2526099739887593/4598486027";

    //this.RequestRegularAD();

    private void Awake()
    {
        MobileAds.Initialize(appID);
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.RequestBanner();
    }
    private void RequestRegularAD()
    {
        InterstitialAd AD = new InterstitialAd(regularAD);

        AdRequest request = new AdRequest.Builder().Build();

        AD.LoadAd(request);
    }

    private void RequestBanner()
    {
        bannerView = new BannerView(appID, AdSize.Banner, AdPosition.Bottom);

        AdRequest request = new AdRequest.Builder().Build();

        bannerView.LoadAd(request);
    }

    public void OnClickShowAd()
    {
        this.RequestRegularAD();
    }
}
