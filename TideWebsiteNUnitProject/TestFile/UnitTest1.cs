using TideWebsiteNUnitProject.PageObjectModel;
using TideWebsiteNUnitProject.DriverFile;

namespace TideWebsiteNUnitProject.TestFile
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            MethodFile.InitializeDriver();
        }

        [Test]
        public void LiveChat()
        {
            LiveChatFile.NavigateURL();
            LiveChatFile.ClickOnLiveChat();
            LiveChatFile.ScrollToElement();
            LiveChatFile.TakeScreenShot();
        }

        [Test]
        public void SearchBar()
        {
            SearchBarFile.NavigateURL();
            SearchBarFile.ClickOnSearchBar();
            SearchBarFile.PutValueInSearchBar();
            SearchBarFile.TakeScreenShot();
        }

        [Test]
        public void LanguageChangeTest()
        {
            LanguageChange.NavigateURL();
            LanguageChange.ClickButton();
            LanguageChange.ChooseLanguage();
            LanguageChange.TakeScreenShot();
        }

        [Test]
        public void ContactUsTest()
        {
            ContactUsFile.NavigateURL();
            ContactUsFile.ClickButton();
            ContactUsFile.TakeScreenShot();
        }

        [Test]
        public void OurCommitmentTest()
        {
            OurCommitmentFile.NavigateURL();
            OurCommitmentFile.ClickButton();
            OurCommitmentFile.TakeScreenShot();
        }

        [Test]
        public void ShopProductsTest()
        {
            ShopProductsFile.NavigateURL();
            ShopProductsFile.ClickButton();
            ShopProductsFile.SelectProduct();
            ShopProductsFile.TakeScreenShot();
        }

        [Test]
        public void WhatsNewTest()
        {
            WhatsNewFile.NavigateURL();
            WhatsNewFile.ClickButton();
           // WhatsNewFile.ClickLatestArticle();
            WhatsNewFile.TakeScreenShot();
        }

        [Test]
        public void HowToWashClothesTest()
        {
            HowToWashClothesFile.NavigateURL();
            HowToWashClothesFile.ClickButton();
            HowToWashClothesFile.ScrollToElement();
            HowToWashClothesFile.TakeScreenShot();
        }

        [Test]
        public void CouponsAndRewardsTest()
        {
            CouponsAndRewardsFile.NavigateURL();
            CouponsAndRewardsFile.ClickCouponsAndRewards();
            CouponsAndRewardsFile.TakeScreenShot();
        }
    }
}