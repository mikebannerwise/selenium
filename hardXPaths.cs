namespace selenium
{
    class hardXPaths
    {   
        public string getXPaths(string network)
        {
            string xPath="";
            switch (network)
            
            {
                case "googleads":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[1]/h5";
                break;
                case "360":
                xPath="/html/body/div[7]/div/div[2]/div[1]/div/div[2]/h5";
                break;
                case "gcm":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[3]/h5";
                break;
                case "googlestudio":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[4]/h5";
                break;
                case "adform":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[5]/h5";
                break;
                case "aol":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[6]/h5";
                break;
                case "adlib":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[7]/h5";
                break;
                case "adroll":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[8]/h5";
                break;
                case "adcombi":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[9]/h5";
                break;
                case "adcrowd":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[10]/h5";
                break;
                case "adformmraid":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[11]/h5";
                break;
                case "adition":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[12]/h5";
                break;
                case "adscience":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[13]/h5";
                break;
                case "adtech":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[14]/h5";
                break;
                case "atlasfacebook":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[15]/h5";
                break;
                case "bvdw":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[16]/h5";
                break;
                case "beeinteractive":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[17]/h5";
                break;
                case "bidtheatre":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[18]/h5";
                break;
                case "campusmedia":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[19]/h5";
                break;
                case "daisycon":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[20]/h5";
                break;
                case "delta":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[21]/h5";
                break;
                case "exterion":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[22]/h5";
                break;
                case "flashtalking":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[23]/h5";
                break;
                case "fusion":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[24]/h5";
                break;
                case "googleadmanager":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[25]/h5";
                break;
                case "horizont":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[26]/h5";
                break;
                case "iab":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[27]/h5";
                break;
                case "iabaustria":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[28]/h5";
                break;
                case "iabmraid":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[29]/h5";
                break;
                case "mediaimpact":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[30]/h5";
                break;
                case "mediamath":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[31]/h5";
                break;
                case "openx":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[32]/h5";
                break;
                case "161":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[33]/h5";
                break;
                case "quantcast":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[34]/h5";
                break;
                case "rtl":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[35]/h5";
                break;
                case "revive":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[36]/h5";
                break;
                case "rocketfuel":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[37]/h5";
                break;
                case "sizmek":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[38]/h5";
                break;
                case "smartadserver":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[39]/h5";
                break;
                case "smartadtags":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[40]/h5";
                break;
                case "targetoo":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[41]/h5";
                break;
                case "tradedesk":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[42]/h5";
                break;
                case "tradedoubler":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[43]/h5";
                break;
                case "tradetracker":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[44]/h5";
                break;
                case "turn":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[45]/h5";
                break;
                case "verivox":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[46]/h5";
                break;
                case "weborama":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[47]/h5";
                break;
                case "xandr":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[48]/h5";
                break;
                case "yahoo":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[49]/h5";
                break;
                case "html":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[50]/h5";
                break;
                case "match2one":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[51]/h5";
                break;
                case "yielder":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[52]/h5";
                break;
            }
            return xPath;
        }
    }
} 