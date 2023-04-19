using System.Text.Json;

internal class Program
{
    private static void Main(string[] args)
    {
        //List<Mahasiswa> listMahasiswa = new List<Mahasiswa>();
        //listMahasiswa.Add(new Mahasiswa("Gabriella",1302217845));
        //listMahasiswa.Add(new Mahasiswa("Isabella", 1302213478));
        //listMahasiswa.Add(new Mahasiswa("Hermawan", 1302213080));

        //Serialisasikeun(listMahasiswa,"test.json");
        //List<Mahasiswa> listMhs = Deserialisasi<List<Mahasiswa>>("test.json");
        //Console.WriteLine(listMhs[1].nama + " : " + listMahasiswa[1].nim);

        Mahasiswa obj = Deserialisasi<Mahasiswa>("test.json");
        Console.WriteLine(obj.nama.depan + " " + obj.nama.belakang + " " + obj.nim);
        Console.WriteLine("Daftar Mata Kuliah");
        for(int i = 0; i < obj.matkul.Count; i++)
        {
            Console.WriteLine(" - " + obj.matkul[i]);
        }
    }

    private static void Serialisasikeun(Object obj, string filename)
    {
        JsonSerializerOptions options = new JsonSerializerOptions()
        {
            WriteIndented = true
        };
        string hasilSerialisasi = JsonSerializer.Serialize(obj, options);
        File.WriteAllText("D:\\kuliah\\semester 4\\konstruksi PL\\parsing\\parsing\\parsing\\" + filename, hasilSerialisasi);
    }

    private static tipe Deserialisasi<tipe>(string filename)
    {
        string jsonString = File.ReadAllText("D:\\kuliah\\semester 4\\konstruksi PL\\parsing\\parsing\\parsing\\" + filename);
        return JsonSerializer.Deserialize<tipe>(jsonString);
    }
}

public class Mahasiswa
{
    public NamaLengkap nama { get; set; }
    public int nim { get; set; }
    public List<string> matkul { get; set; }
    public Mahasiswa() { }
    public Mahasiswa(NamaLengkap nama, int nim, List<string>kuliah)
    {
        this.nama = nama;
        this.nim = nim;
        matkul = kuliah;
    }
}

public class NamaLengkap
{
    public string depan { get; set; }
    public string belakang { get; set; }
    public NamaLengkap() { }
    public NamaLengkap(string depan, string belakang)
    {
        this.depan = depan;
        this.belakang = belakang;
    }
}
