using _7_nuget;
using Newtonsoft.Json;
using System.Drawing;
using TrueColorConsole;

RibbonLED ribbon = new(10);
void PaintRibbon(RibbonLED ribbon)
{
    Random random = new Random();
    for (int i = 0; i < RibbonLED.size; ++i)
    {
        ribbon.parts[i] = '0';
        for (int j = 0; j < 3; ++j)
            ribbon.colors[i, j] = random.Next(0, 255);
    }
}

void ShowFullRibbon(RibbonLED ribbon)
{
    string str = JsonConvert.SerializeObject(ribbon);
    for (int i = 0; i < RibbonLED.size; ++i)
    {
        int r = ribbon.colors[i, 0];
        int g = ribbon.colors[i, 1];
        int b = ribbon.colors[i, 2];
        VTConsole.Write(str, Color.FromArgb(r, g, b));
    }
}

void ShowStandartRibbon(RibbonLED ribbon)
{
    string str = JsonConvert.SerializeObject(ribbon);
    for (int i = 0; i < RibbonLED.size; ++i)
    {
        int r = ribbon.colors[i, 0];
        int g = ribbon.colors[i, 1];
        int b = ribbon.colors[i, 2];
        VTConsole.Write(Convert.ToString(ribbon.parts[i]), Color.FromArgb(r, g, b));
    }
}

PaintRibbon(ribbon);
ShowStandartRibbon(ribbon);

//ShowStandartRibbon(ribbon);