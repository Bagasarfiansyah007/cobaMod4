using System;

namespace modul3
{
    class Program
    {
        static void Main(string[] args)
        {
            KodeBuah tableBuah = new KodeBuah();
            Console.WriteLine(KodeBuah.getKodeBuah(KodeBuah.Buah.Alpukat));

            PosisiKarakterGame posisi = new PosisiKarakterGame();

            Console.WriteLine("Posisi saat ini              : "+ posisi.currentState);
            posisi.triggerTombolUntukBerjalan(PosisiKarakterGame.TriggerPosisi.TombolW);
            Console.WriteLine("Posisi setelah menakan tombol: " + posisi.currentState);

            Console.WriteLine("");

            Console.WriteLine("Posisi saat ini              : " + posisi.currentState);
            posisi.triggerTombolUntukBerjalan(PosisiKarakterGame.TriggerPosisi.TombolX);
            Console.WriteLine("Posisi setelah menakan tombol: " + posisi.currentState);

            Console.WriteLine("");

            Console.WriteLine("Posisi saat ini              : " + posisi.currentState);
            posisi.triggerTombolUntukBerjalan(PosisiKarakterGame.TriggerPosisi.TombolW);
            Console.WriteLine("Posisi setelah menakan tombol: " + posisi.currentState);

        }
    }
}
