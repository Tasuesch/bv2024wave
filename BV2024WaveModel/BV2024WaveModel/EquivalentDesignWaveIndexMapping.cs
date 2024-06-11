using System;
using System.Runtime.CompilerServices;

namespace Macs3.Modules.Lash.Abstractions.BV2017
{
    public class EquivalentDesignWaveIndexMapping
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int EquivalentDesignWaveToIndex(EquivalentDesignWaves equivalentDesignWaves)
        {
            switch (equivalentDesignWaves)
            {
                case EquivalentDesignWaves.BR1_P:
                    return 0;
                case EquivalentDesignWaves.BR2_P:
                    return 1;
                case EquivalentDesignWaves.BR1_S:
                    return 2;
                case EquivalentDesignWaves.BR2_S:
                    return 3;
                case EquivalentDesignWaves.BP1_P:
                    return 4;
                case EquivalentDesignWaves.BP2_P:
                    return 5;
                case EquivalentDesignWaves.BP1_S:
                    return 6;
                case EquivalentDesignWaves.BP2_S:
                    return 7;
                case EquivalentDesignWaves.OVA1_S:
                    return 8;
                case EquivalentDesignWaves.OVA2_S:
                    return 9;
                case EquivalentDesignWaves.OVA1_P:
                    return 10;
                case EquivalentDesignWaves.OVA2_P:
                    return 11;
                case EquivalentDesignWaves.SPLC_Max:
                    return 12;
                case EquivalentDesignWaves.SPLC_Min:
                    return 13;
                default:
                    throw new Exception("Invalid equivalentDesignWaves in EquivalentDesignWaveToIndex method");
            }
        }
        
    }
}
