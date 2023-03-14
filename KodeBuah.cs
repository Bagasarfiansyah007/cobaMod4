using System;
namespace modul3
{
    public class KodeBuah
    {
        public enum Buah{
            Apel,
            Aprikot,
            Alpukat,
            Pisang,
            Paprika,
            Blackberry,
            Ceri,
            Kelapa,
            Jagung,
            Kurma,
            Durian,
            Anggur,
            Melon,
            Semangka
        }

        public static string[,] tableBuah = {
            { "Apel", "A00" },
            { "Aprikot", "B00" },
            { "Alpukat", "C00" },
            { "Pisang", "D00" },
            { "Paprika", "E00" },
            { "Blackberry", "F00" },
            { "Ceri", "H00" },
            { "Kelapa", "I00" },
            { "Jagung", "J00" },
            { "Kurma", "K00" },
            { "Durian", "L00" },
            { "Anggur", "M00" },
            { "Melon", "N00" },
            { "Semangka", "O00" }
        };

        public static string getKodeBuah(string cariNamaBuah) {
            string namaBuahYangDicari="";

            for (int i = 0; i < 14; i++) {
                for (int j = 0; j < 2; j++) {
                    if (cariNamaBuah == tableBuah[i, j])
                    {
                        namaBuahYangDicari = tableBuah[i, 1];
                    }
                }
            }

            return namaBuahYangDicari;
        }

        public static string getKodeBuah (Buah namaBuah){
            // 3-iv. Terdapat array yang menampung semua kode pos untuk output di dalam method[max 10 pts]
            String[] kodeBuah = { "A00", "B00", "C00", "D00", "E00", "F00", "H00", "I00", "J00", "K00", "L00", "M00", "N00", "O00" };

            // 3-v. Terdapat return value dengan mengakses array dengan index dari hasil konversi enum/struct input ke integer[max 10 pts]
            return kodeBuah[(int)namaBuah];
        }
    }
}
