using System;
using Microsoft.Maui.Handlers;
#if ANDROID
using NativeVideoPlayer = MAUI.Freakydeo.AndroidNativeVideoPlayer;
#endif
#if IOS
using NativeVideoPlayer = MAUI.Freakydeo.IOSNativeVideoPlayer;
#endif

namespace MAUI.Freakydeo
{
    public partial class FreakyPlayerHandler : ViewHandler<IFreakyPlayer, NativeVideoPlayer>
    {
        public FreakyPlayerHandler(IPropertyMapper mapper, CommandMapper commandMapper = null)
            : base(mapper, commandMapper)
        {
        }

        protected override NativeVideoPlayer CreatePlatformView()
        {
            throw new NotImplementedException();
        }
    }
}

