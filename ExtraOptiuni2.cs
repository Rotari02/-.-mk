using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abonați_telefonici
{
    public abstract class ExtraOptiuni2
    {
        private int minuteInternationale;
        private int roaming;

        public int MinuteInternationale { get => minuteInternationale; set => minuteInternationale = value; }
        public int Roaming { get => roaming; set => roaming = value; }

        public ExtraOptiuni2()
        {
            this.minuteInternationale = 0;
            this.roaming = 0;
        }

        public ExtraOptiuni2(int minuteInternationale, int roaming)
        {
            this.minuteInternationale = minuteInternationale;
            this.roaming = roaming;
        }


        public override string ToString()
        {
            return "Abonamemtul are " + minuteInternationale + "minute Internationale si" + roaming + "GB roaming";
        }

        public abstract string alegeTipAbonament();
    }
}

