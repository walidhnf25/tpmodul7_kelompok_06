using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;

namespace tpmodul7_kelompok_06
{
    public class DataMahasiswa1302213120
    {
        public Nama nama { get; set; }
        public int nim { get; set; }
        public String fakultas { get; set; }


        public DataMahasiswa1302213120(Nama nama, int nim, String fakultas)
        {
            this.nama = nama;
            this.nim = nim;
            this.fakultas = fakultas;
        }
        public static void ReadJSON()
        {
            String jsonString = File.ReadAllText("C:\\Users\\walid\\source\\repos\\tpmodul7_kelompok_06\\tpmodul7_kelompok_06\\tp7_1_1302213120.json");

            DataMahasiswa1302213120 mahasiswa = JsonSerializer.Deserialize<DataMahasiswa1302213120>(jsonString);

            Console.WriteLine("Nama " + mahasiswa.nama.depan + " " + mahasiswa.nama.belakang + " dengan nim " + mahasiswa.nim + " dari fakultas " + mahasiswa.fakultas);
        }
    }
    public class Nama
    {
        public String depan { get; set; }
        public String belakang { get; set; }

        public Nama(String depan, String belakang)
        {
            this.depan = depan;
            this.belakang = belakang;
        }
    }
}