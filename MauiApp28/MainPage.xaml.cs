using System.Diagnostics;
using System.Text.Json;
using Android.App;

namespace MauiApp28;

public partial class MainPage : ContentPage
{
    private readonly List<int[]> _data = new();
    private int[] _current = new int[65];
    private int[] _prev = new int[65];
    private readonly WallpaperManager _wallpaperManager = WallpaperManager.GetInstance(Platform.AppContext);
    
    public MainPage()
    {
        InitializeComponent();
        Main();
    }
    
    private async void Main()
    {
        while (true)
        {
            await Task.Delay(100);
            if (_data.Count == 4)
            {
                Debug.WriteLine("Done! Please select the FOURTH palette!");
                
                await File.WriteAllTextAsync(
                    $"/storage/emulated/0/Documents/{_wallpaperManager!.GetWallpaperId(WallpaperManagerFlags.System)}.fourth.json",
                    JsonSerializer.Serialize(_data));
                
                int prevId = _wallpaperManager.GetWallpaperId(WallpaperManagerFlags.System);
                while (prevId == _wallpaperManager.GetWallpaperId(WallpaperManagerFlags.System))
                {
                    await Task.Delay(300);
                }
                Debug.WriteLine("New wallpaper selected.");
                _data.Clear();
                await Task.Delay(1000);
            }
            
            Fill(_current);
            if (_current.SequenceEqual(_prev)) continue;
            
            Debug.WriteLine(_data.Count);
            _data.Add(_current);
            _prev = _current;
            _current = new int[65];
        }
    }

    private static void Fill(int[] arr)
    {
        arr[0] = Platform.AppContext.Resources!.GetColor(Android.Resource.Color.SystemAccent11000, null);
        arr[1] = Platform.AppContext.Resources!.GetColor(Android.Resource.Color.SystemAccent1900, null);
        arr[2] = Platform.AppContext.Resources!.GetColor(Android.Resource.Color.SystemAccent1800, null);
        arr[3] = Platform.AppContext.Resources!.GetColor(Android.Resource.Color.SystemAccent1700, null);
        arr[4] = Platform.AppContext.Resources!.GetColor(Android.Resource.Color.SystemAccent1600, null);
        arr[5] = Platform.AppContext.Resources!.GetColor(Android.Resource.Color.SystemAccent1500, null);
        arr[6] = Platform.AppContext.Resources!.GetColor(Android.Resource.Color.SystemAccent1400, null);
        arr[7] = Platform.AppContext.Resources!.GetColor(Android.Resource.Color.SystemAccent1300, null);
        arr[8] = Platform.AppContext.Resources!.GetColor(Android.Resource.Color.SystemAccent1200, null);
        arr[9] = Platform.AppContext.Resources!.GetColor(Android.Resource.Color.SystemAccent1100, null);
        arr[10] = Platform.AppContext.Resources!.GetColor(Android.Resource.Color.SystemAccent150, null);
        arr[11] = Platform.AppContext.Resources!.GetColor(Android.Resource.Color.SystemAccent110, null);
        arr[12] = Platform.AppContext.Resources!.GetColor(Android.Resource.Color.SystemAccent10, null);
        arr[13] = Platform.AppContext.Resources!.GetColor(Android.Resource.Color.SystemAccent21000, null);
        arr[14] = Platform.AppContext.Resources!.GetColor(Android.Resource.Color.SystemAccent2900, null);
        arr[15] = Platform.AppContext.Resources!.GetColor(Android.Resource.Color.SystemAccent2800, null);
        arr[16] = Platform.AppContext.Resources!.GetColor(Android.Resource.Color.SystemAccent2700, null);
        arr[17] = Platform.AppContext.Resources!.GetColor(Android.Resource.Color.SystemAccent2600, null);
        arr[18] = Platform.AppContext.Resources!.GetColor(Android.Resource.Color.SystemAccent2500, null);
        arr[19] = Platform.AppContext.Resources!.GetColor(Android.Resource.Color.SystemAccent2400, null);
        arr[20] = Platform.AppContext.Resources!.GetColor(Android.Resource.Color.SystemAccent2300, null);
        arr[21] = Platform.AppContext.Resources!.GetColor(Android.Resource.Color.SystemAccent2200, null);
        arr[22] = Platform.AppContext.Resources!.GetColor(Android.Resource.Color.SystemAccent2100, null);
        arr[23] = Platform.AppContext.Resources!.GetColor(Android.Resource.Color.SystemAccent250, null);
        arr[24] = Platform.AppContext.Resources!.GetColor(Android.Resource.Color.SystemAccent210, null);
        arr[25] = Platform.AppContext.Resources!.GetColor(Android.Resource.Color.SystemAccent20, null);
        arr[26] = Platform.AppContext.Resources!.GetColor(Android.Resource.Color.SystemAccent31000, null);
        arr[27] = Platform.AppContext.Resources!.GetColor(Android.Resource.Color.SystemAccent3900, null);
        arr[28] = Platform.AppContext.Resources!.GetColor(Android.Resource.Color.SystemAccent3800, null);
        arr[29] = Platform.AppContext.Resources!.GetColor(Android.Resource.Color.SystemAccent3700, null);
        arr[30] = Platform.AppContext.Resources!.GetColor(Android.Resource.Color.SystemAccent3600, null);
        arr[31] = Platform.AppContext.Resources!.GetColor(Android.Resource.Color.SystemAccent3500, null);
        arr[32] = Platform.AppContext.Resources!.GetColor(Android.Resource.Color.SystemAccent3400, null);
        arr[33] = Platform.AppContext.Resources!.GetColor(Android.Resource.Color.SystemAccent3300, null);
        arr[34] = Platform.AppContext.Resources!.GetColor(Android.Resource.Color.SystemAccent3200, null);
        arr[35] = Platform.AppContext.Resources!.GetColor(Android.Resource.Color.SystemAccent3100, null);
        arr[36] = Platform.AppContext.Resources!.GetColor(Android.Resource.Color.SystemAccent350, null);
        arr[37] = Platform.AppContext.Resources!.GetColor(Android.Resource.Color.SystemAccent310, null);
        arr[38] = Platform.AppContext.Resources!.GetColor(Android.Resource.Color.SystemAccent30, null);
        arr[39] = Platform.AppContext.Resources!.GetColor(Android.Resource.Color.SystemNeutral11000, null);
        arr[40] = Platform.AppContext.Resources!.GetColor(Android.Resource.Color.SystemNeutral1900, null);
        arr[41] = Platform.AppContext.Resources!.GetColor(Android.Resource.Color.SystemNeutral1800, null);
        arr[42] = Platform.AppContext.Resources!.GetColor(Android.Resource.Color.SystemNeutral1700, null);
        arr[43] = Platform.AppContext.Resources!.GetColor(Android.Resource.Color.SystemNeutral1600, null);
        arr[44] = Platform.AppContext.Resources!.GetColor(Android.Resource.Color.SystemNeutral1500, null);
        arr[45] = Platform.AppContext.Resources!.GetColor(Android.Resource.Color.SystemNeutral1400, null);
        arr[46] = Platform.AppContext.Resources!.GetColor(Android.Resource.Color.SystemNeutral1300, null);
        arr[47] = Platform.AppContext.Resources!.GetColor(Android.Resource.Color.SystemNeutral1200, null);
        arr[48] = Platform.AppContext.Resources!.GetColor(Android.Resource.Color.SystemNeutral1100, null);
        arr[49] = Platform.AppContext.Resources!.GetColor(Android.Resource.Color.SystemNeutral150, null);
        arr[50] = Platform.AppContext.Resources!.GetColor(Android.Resource.Color.SystemNeutral110, null);
        arr[51] = Platform.AppContext.Resources!.GetColor(Android.Resource.Color.SystemNeutral10, null);
        arr[52] = Platform.AppContext.Resources!.GetColor(Android.Resource.Color.SystemNeutral21000, null);
        arr[53] = Platform.AppContext.Resources!.GetColor(Android.Resource.Color.SystemNeutral2900, null);
        arr[54] = Platform.AppContext.Resources!.GetColor(Android.Resource.Color.SystemNeutral2800, null);
        arr[55] = Platform.AppContext.Resources!.GetColor(Android.Resource.Color.SystemNeutral2700, null);
        arr[56] = Platform.AppContext.Resources!.GetColor(Android.Resource.Color.SystemNeutral2600, null);
        arr[57] = Platform.AppContext.Resources!.GetColor(Android.Resource.Color.SystemNeutral2500, null);
        arr[58] = Platform.AppContext.Resources!.GetColor(Android.Resource.Color.SystemNeutral2400, null);
        arr[59] = Platform.AppContext.Resources!.GetColor(Android.Resource.Color.SystemNeutral2300, null);
        arr[60] = Platform.AppContext.Resources!.GetColor(Android.Resource.Color.SystemNeutral2200, null);
        arr[61] = Platform.AppContext.Resources!.GetColor(Android.Resource.Color.SystemNeutral2100, null);
        arr[62] = Platform.AppContext.Resources!.GetColor(Android.Resource.Color.SystemNeutral250, null);
        arr[63] = Platform.AppContext.Resources!.GetColor(Android.Resource.Color.SystemNeutral210, null);
        arr[64] = Platform.AppContext.Resources!.GetColor(Android.Resource.Color.SystemNeutral20, null);
    }
}