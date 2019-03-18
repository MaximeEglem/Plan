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
            switch (app)
            {
                case AppEnum.AppleMaps:
                    return "Apple Maps";
                case AppEnum.GoogleMaps:
                    return "Google Maps";
                default: return string.Empty;
            }
        }

        public static bool Supports(this AppEnum app, ModeEnum mode)
        {
            if (mode == ModeEnum.Default)
                return true;
            switch (app)
            {
                case AppEnum.AppleMaps:
                    return mode != ModeEnum.Bicycling;
                case AppEnum.GoogleMaps:
                    return true;
                default: return false;
            }
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
