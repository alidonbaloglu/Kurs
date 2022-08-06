class Urun
{
    public int Id { get; set; }
    public string? Adi { get; set; }
    public int Fiyat { get; set; }
    public string? Aciklama { get; set; }

}

new Urun().Adi = "elma";
new Urun().Aciklama = "elamlar cok güzel";
new Urun().Fiyat = 45;

Console.WriteLine(new Urun().Adi);
