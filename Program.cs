ISmartphone hpKapibara = new IPhone();

Fotografer fotografer =  new Fotografer();
fotografer.Kerja(hpKapibara);

hpKapibara = new Samsung();
fotografer.Kerja(hpKapibara);

interface ISmartphone
{
    public void AmbilFoto();
}

class IPhone : ISmartphone
{
    public void AmbilFoto()
    {
        Console.WriteLine("Mengaktifkan sensor kamera premium... *cekrek!*");
    }
}

class Samsung : ISmartphone
{
    public void AmbilFoto()
    {
        Console.WriteLine("Mengaktifkan fitur beauty... *cekrek!*");
    }
}

class Fotografer
{
    public void Kerja(ISmartphone hp)
    {
        hp.AmbilFoto();
    }
}