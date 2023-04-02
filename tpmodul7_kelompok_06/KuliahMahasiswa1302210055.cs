using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;

namespace tpmodul7_kelompok_06
{
    internal class KuliahMahasiswa1302210055
    {
        public List<courses> courses { get; set; }

        public KuliahMahasiswa1302210055(List<courses> courses)
        {
            this.courses = courses;
        }

        public static void ReadJSON()
        {
            String jsonString = File.ReadAllText("D:\\Praktek Smstr 4\\KPL\\tpmodul7_kelompok_06\\tpmodul7_kelompok_06\\tp7_2_1302210055.json");

            KuliahMahasiswa1302210055 matkul = JsonSerializer.Deserialize<KuliahMahasiswa1302210055>(jsonString);

            for (int i = 0; i < matkul.courses.Count; i++)
            {
                Console.WriteLine("MK " + (i + 1) + " " + matkul.courses[i].code + " - " + matkul.courses[i].name);
            }

        }


    }
    public class courses
    {
        public String code { get; set; }
        public String name { get; set; }

        public courses(String code, String name)
        {
            this.code = code;
            this.name = name;
        }
    }
}