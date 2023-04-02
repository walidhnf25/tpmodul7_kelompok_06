using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;

namespace tpmodul7_kelompok_2
{
    internal class KuliahMahasiswa1302213120
    {
        public List<courses> courses { get; set; }

        public KuliahMahasiswa1302213120(List<courses> courses)
        {
            this.courses = courses;
        }

        public static void ReadJSON()
        {
            String jsonString = File.ReadAllText("D:\\KULIAH 4\\KPL\\TP\\TPmodul7_1302210049\\tpmodul7_kelompok_06\\tpmodul7_kelompok_06\\tp7_2_1302213120.json");

            KuliahMahasiswa1302213120 matkul = JsonSerializer.Deserialize<KuliahMahasiswa1302213120>(jsonString);

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