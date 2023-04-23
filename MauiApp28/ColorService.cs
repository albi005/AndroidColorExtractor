using MaterialColorUtilities.ColorAppearance;
using MaterialColorUtilities.Maui;
using MaterialColorUtilities.Palettes;
using MaterialColorUtilities.Schemes;
using Microsoft.Extensions.Options;
using Microsoft.Maui.LifecycleEvents;

namespace MauiApp28;

public class ColorService : DynamicColorService<CorePalette, Scheme<int>, Scheme<Color>, LightSchemeMapper, DarkSchemeMapper>
{
    public ColorService(IOptions<DynamicColorOptions> options, IApplication application, ILifecycleEventService lifecycleEventService) : base(options, application, lifecycleEventService)
    {
    }

    public override void Initialize()
    {
        base.Initialize();
        var asd = Application.Current;
    }

    protected override async void Apply()
    {
        base.Apply();
        int[] primaryIds =
        {
            Android.Resource.Color.SystemAccent1500,
            Android.Resource.Color.SystemAccent110,
            Android.Resource.Color.SystemAccent150,
            Android.Resource.Color.SystemAccent1100,
            Android.Resource.Color.SystemAccent1200,
            Android.Resource.Color.SystemAccent1300,
            Android.Resource.Color.SystemAccent1400,
            Android.Resource.Color.SystemAccent1600,
            Android.Resource.Color.SystemAccent1700,
            Android.Resource.Color.SystemAccent1800,
            Android.Resource.Color.SystemAccent1900,
        };
        double maxChroma = -1;
        uint closestColor = 0;
        foreach (int id in primaryIds)
        {
            int color = Platform.AppContext.Resources!.GetColor(id, null);

            Hct hct = Hct.FromInt(color);
            if (hct.Chroma > maxChroma)
            {
                maxChroma = hct.Chroma;
                closestColor = (uint)color;
            }
        }

        await Task.Delay(1000);
        await Permissions.RequestAsync<Permissions.StorageRead>();

    }
}