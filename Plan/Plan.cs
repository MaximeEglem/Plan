using UIKit;

namespace Plan
{
    public static class Plan
    {
        public static bool IsInstalled(this AppEnum app)
        {
            if (AppEnum.AppleMaps == app)
                return true;

            var urlScheme = app.UrlScheme();

            if (urlScheme == null)
                return false;

            return UIApplication.SharedApplication.CanOpenUrl(new Foundation.NSUrl(urlScheme));
        }
    }
}
