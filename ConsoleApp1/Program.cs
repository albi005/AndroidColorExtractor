using System.Globalization;
using System.Text.Json;
using MaterialColorUtilities.ColorAppearance;

List<List<Palette>> wallpapers = Directory
    .EnumerateFiles("Data/")
    .Where(f => f.EndsWith(".json") && !f.Contains("four"))
    .Select(file => JsonSerializer.Deserialize<List<int[]>>(File.ReadAllText(file))!)
    .Select(wallpaper => wallpaper.Select(x => x.ToPalette()).ToList())
    .ToList();

// wallpapers
//     .SelectMany(w => w.Count == 16 ? w.Where((_,i) => i % 4 == 3) : w)
//     .Select(p => $"{(p.Primary50.Hue + 120) % 360:0}\t{Math.Round((360 + (p.Secondary50.Hue - (p.Primary50.Hue + 120) % 360)) % 360 / 5) * 5}")
//     .Print();
//
// Enumerable.Range(0, 360)
//     .Select(x => Hct.From(x, 150, 60).Chroma.ToString("0"))
//     .Print();

wallpapers
    .SelectMany(x => x)
    .Where((_, i) => i % 4 == 2)
    .Select(p => $"{p.Primary50.Chroma}\t{Hct.From(p.Primary50.Hue, 150, 49.6).Chroma}")
    .Print();

public static class Extensions
{
    private static readonly JsonSerializerOptions s_jsonSerializerOptions = new()
    {
        WriteIndented = true
    };
    public static void PrintJson(this object value) => Console.WriteLine(JsonSerializer.Serialize(value, s_jsonSerializerOptions));

    public static void Print(this IEnumerable<string> strings)
    {
        strings = strings.ToList();
        foreach(string s in strings)
            Console.WriteLine(s);
        File.WriteAllLines("output.txt", strings);
    }

    public static Palette ToPalette(this int[] colors) => new(
        Hct.FromInt(colors[0]),
        Hct.FromInt(colors[1]),
        Hct.FromInt(colors[2]),
        Hct.FromInt(colors[3]),
        Hct.FromInt(colors[4]),
        Hct.FromInt(colors[5]),
        Hct.FromInt(colors[6]),
        Hct.FromInt(colors[7]),
        Hct.FromInt(colors[8]),
        Hct.FromInt(colors[9]),
        Hct.FromInt(colors[10]),
        Hct.FromInt(colors[11]),
        Hct.FromInt(colors[12]),
        Hct.FromInt(colors[13]),
        Hct.FromInt(colors[14]),
        Hct.FromInt(colors[15]),
        Hct.FromInt(colors[16]),
        Hct.FromInt(colors[17]),
        Hct.FromInt(colors[18]),
        Hct.FromInt(colors[19]),
        Hct.FromInt(colors[20]),
        Hct.FromInt(colors[21]),
        Hct.FromInt(colors[22]),
        Hct.FromInt(colors[23]),
        Hct.FromInt(colors[24]),
        Hct.FromInt(colors[25]),
        Hct.FromInt(colors[26]),
        Hct.FromInt(colors[27]),
        Hct.FromInt(colors[28]),
        Hct.FromInt(colors[29]),
        Hct.FromInt(colors[30]),
        Hct.FromInt(colors[31]),
        Hct.FromInt(colors[32]),
        Hct.FromInt(colors[33]),
        Hct.FromInt(colors[34]),
        Hct.FromInt(colors[35]),
        Hct.FromInt(colors[36]),
        Hct.FromInt(colors[37]),
        Hct.FromInt(colors[38]),
        Hct.FromInt(colors[39]),
        Hct.FromInt(colors[40]),
        Hct.FromInt(colors[41]),
        Hct.FromInt(colors[42]),
        Hct.FromInt(colors[43]),
        Hct.FromInt(colors[44]),
        Hct.FromInt(colors[45]),
        Hct.FromInt(colors[46]),
        Hct.FromInt(colors[47]),
        Hct.FromInt(colors[48]),
        Hct.FromInt(colors[49]),
        Hct.FromInt(colors[50]),
        Hct.FromInt(colors[51]),
        Hct.FromInt(colors[52]),
        Hct.FromInt(colors[53]),
        Hct.FromInt(colors[54]),
        Hct.FromInt(colors[55]),
        Hct.FromInt(colors[56]),
        Hct.FromInt(colors[57]),
        Hct.FromInt(colors[58]),
        Hct.FromInt(colors[59]),
        Hct.FromInt(colors[60]),
        Hct.FromInt(colors[61]),
        Hct.FromInt(colors[62]),
        Hct.FromInt(colors[63]),
        Hct.FromInt(colors[64])
    );
}

public record Palette(
    Hct Primary0,
    Hct Primary10,
    Hct Primary20,
    Hct Primary30,
    Hct Primary40,
    Hct Primary50,
    Hct Primary60,
    Hct Primary70,
    Hct Primary80,
    Hct Primary90,
    Hct Primary95,
    Hct Primary99,
    Hct Primary100,
    Hct Secondary0,
    Hct Secondary10,
    Hct Secondary20,
    Hct Secondary30,
    Hct Secondary40,
    Hct Secondary50,
    Hct Secondary60,
    Hct Secondary70,
    Hct Secondary80,
    Hct Secondary90,
    Hct Secondary95,
    Hct Secondary99,
    Hct Secondary100,
    Hct Tertiary0,
    Hct Tertiary10,
    Hct Tertiary20,
    Hct Tertiary30,
    Hct Tertiary40,
    Hct Tertiary50,
    Hct Tertiary60,
    Hct Tertiary70,
    Hct Tertiary80,
    Hct Tertiary90,
    Hct Tertiary95,
    Hct Tertiary99,
    Hct Tertiary100,
    Hct Neutral0,
    Hct Neutral10,
    Hct Neutral20,
    Hct Neutral30,
    Hct Neutral40,
    Hct Neutral50,
    Hct Neutral60,
    Hct Neutral70,
    Hct Neutral80,
    Hct Neutral90,
    Hct Neutral95,
    Hct Neutral99,
    Hct Neutral100,
    Hct NeutralVariant0,
    Hct NeutralVariant10,
    Hct NeutralVariant20,
    Hct NeutralVariant30,
    Hct NeutralVariant40,
    Hct NeutralVariant50,
    Hct NeutralVariant60,
    Hct NeutralVariant70,
    Hct NeutralVariant80,
    Hct NeutralVariant90,
    Hct NeutralVariant95,
    Hct NeutralVariant99,
    Hct NeutralVariant100
);