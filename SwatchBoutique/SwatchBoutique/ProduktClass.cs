using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace SwatchBoutique;

public class ProduktClass
{
    public string? Path { get; set; }
    public string? Info { get; set; }
    public string? Price { get; set; }

    public ProduktClass()
    {

    }
    public ProduktClass(string resource, string ınfo, string price)
    {
        this.Path = resource;
        this.Info = ınfo;
        this.Price = price;
    }

    public static ProduktClass? LoadProduct()
    {
        string usersJson = File.ReadAllText("Data/SelectedProduct.json");
        return JsonSerializer.Deserialize<ProduktClass>(usersJson);

    }

    public void SaveProduct(ProduktClass pr)
    {
        string usersJson = JsonSerializer.Serialize(pr);
        File.WriteAllText("Data/SelectedProduct.json", usersJson);
    }


}
