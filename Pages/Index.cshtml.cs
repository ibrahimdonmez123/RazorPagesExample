
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

public class IndexModel : PageModel
{
    public List<Arac> Araclar { get; set; }

    public IndexModel()
    {
        Araclar = new List<Arac>
        {
            new Arac { Marka = "Honda", Renk = "Siyah", Yýl = 2022 },
            new Arac { Marka = "Tesla", Renk = "Kýrmýzý", Yýl = 2021 },
            new Arac { Marka = "Ford", Renk = "Lacivert", Yýl = 2023 }
        };
    }

    
}

public class Arac
{
    public string Marka { get; set; }
    public string Renk { get; set; }
    public int Yýl { get; set; }
}
