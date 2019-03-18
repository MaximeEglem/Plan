using Foundation;
using MapKit;

namespace Plan
{
    public static class App
    {
        public static string UrlScheme(this AppEnum app)
        {
            switch (app)
            {
                case AppEnum.AppleMaps:
                    return string.Empty;
                case AppEnum.GoogleMaps:
                    return "comgooglemaps://";
                default: return null;
            }
        }

        public static string Name(AppEnum app)
        {
            throw new ModelNotImplementedException();
        }

        public static bool Supports(this AppEnum app, ModeEnum mode)
        {
            throw new ModelNotImplementedException();
        }

        public static MKDirectionsMode IdentifierApple(this AppEnum app, ModeEnum mode)
        {
            throw new ModelNotImplementedException();
        }

        public static string Identifier(this AppEnum app, ModeEnum mode)
        {
            throw new ModelNotImplementedException();
        }
    }
}
