namespace Macs3.Modules.Lash.Abstractions.BV2017
{
    public class PermissibleStackForceForTiersCalculatorInput
    {
        public bool ToppedByCellGuideLengthContainers { get; set; }

        public int NumberOfShorterTiers { get; set; }

        public double[] OverwritedUntopped { get; set; }

        public double[] OverwritedTopped { get; set; }
    }
}