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
            switch (app)
            {
                case AppEnum.AppleMaps:
                    switch (mode)
                    {
                        case ModeEnum.Walking:
                            return MKDirectionsMode.Walking;
                        case ModeEnum.Driving:
                        case ModeEnum.Taxi:// it is supported, but there's no key for this...
                            return MKDirectionsMode.Driving;
                        case ModeEnum.Transit:
                            return MKDirectionsMode.Transit;
                        default: return MKDirectionsMode.Default;
                    }
                default: return MKDirectionsMode.Default;
            }
        }

        public static string Identifier(this AppEnum app, ModeEnum mode)
        {
            switch (app)
            {
                case AppEnum.AppleMaps:
                    switch (mode)
                    {
                        case ModeEnum.Walking:
                            return MKDirectionsMode.Walking.ToString();
                        case ModeEnum.Driving:
                        case ModeEnum.Taxi:// it is supported, but there's no key for this...
                            return MKDirectionsMode.Driving.ToString();
                        case ModeEnum.Transit:
                            return MKDirectionsMode.Transit.ToString();
                        default: return null;
                    }
                case AppEnum.GoogleMaps:
                    switch (mode)
                    {
                        case ModeEnum.Walking:
                            return "walking";
                        case ModeEnum.Bicycling:
                            return "bicycling";
                        case ModeEnum.Driving:
                        case ModeEnum.Taxi: // it is supported, but there's no key for this...
                            return "driving";
                        case ModeEnum.Transit:
                            return "transit";
                        default: return null;
                    }
                default: return null;
            }
        }
