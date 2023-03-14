using System;
namespace modul3
{
    public class PosisiKarakterGame
    {
        public enum PosisiState { Berdiri, Jongkok, Tengkurap, Terbang }
        public enum TriggerPosisi { TombolW, TombolS, TombolX }

        public PosisiState currentState = PosisiState.Berdiri;

        public class PerubahanPosisi
        {
            public PosisiState prevState;
            public PosisiState nextState;
            public TriggerPosisi tombol;

            public PerubahanPosisi(PosisiState prevState, TriggerPosisi tombol, PosisiState nextState) {
                this.prevState = prevState;
                this.nextState = nextState;
                this.tombol = tombol;
            }
        }

        PerubahanPosisi[] listPerubahanPosisi = {
            new PerubahanPosisi(PosisiState.Berdiri,  TriggerPosisi.TombolS, PosisiState.Jongkok),
            new PerubahanPosisi(PosisiState.Berdiri,  TriggerPosisi.TombolW, PosisiState.Terbang),
            new PerubahanPosisi(PosisiState.Terbang,  TriggerPosisi.TombolX, PosisiState.Jongkok),
            new PerubahanPosisi(PosisiState.Terbang,  TriggerPosisi.TombolS, PosisiState.Berdiri),
            new PerubahanPosisi(PosisiState.Tengkurap,  TriggerPosisi.TombolW, PosisiState.Jongkok),
            new PerubahanPosisi(PosisiState.Jongkok,  TriggerPosisi.TombolS, PosisiState.Tengkurap),
            new PerubahanPosisi(PosisiState.Jongkok,  TriggerPosisi.TombolW, PosisiState.Berdiri),
        };

        public PosisiState getNextState(PosisiState prevState, TriggerPosisi tombol) {
            PosisiState nextState = prevState;
            

            for (int i = 0; i < listPerubahanPosisi.Length; i++)
            {
                PosisiState posisiIBerjalan = listPerubahanPosisi[i].prevState;
                TriggerPosisi tombolIBerjalan = listPerubahanPosisi[i].tombol;

                if (posisiIBerjalan == prevState && tombolIBerjalan == tombol) {
                    nextState = listPerubahanPosisi[i].nextState;
                }
            }

            if (prevState == PosisiState.Terbang && nextState == PosisiState.Jongkok) {
                Console.WriteLine("Posisi Landing");
            } else if (prevState == PosisiState.Berdiri && nextState == PosisiState.Terbang)
            {
                Console.WriteLine("Posisi Take Off");
            }

            return nextState;
        }

        public void triggerTombolUntukBerjalan(TriggerPosisi tombol) {
            if (tombol == TriggerPosisi.TombolS)
            {
                Console.WriteLine("Tombol arah bawah ditekan");
            }
            else if (tombol == TriggerPosisi.TombolW) {
                Console.WriteLine("Tombol arah atas ditekan");
            }

            currentState = getNextState(currentState, tombol);
            
            if (currentState == PosisiState.Berdiri)
            {
                Console.WriteLine("posisi standby");
            }
            else if (currentState == PosisiState.Tengkurap)
            {
                Console.WriteLine("posisi istirahat");
            }
        }
    }
}
