namespace Macs3.Modules.Lash.Abstractions.BV2017
{
    /// <summary>
    /// Equivalent Design Waves (EDW) definition as per NR625, Ch 4, Sec 2, 2.2 Table 1
    /// (only those Equivalent Design Waves, which are used in lashing calculations as per NR 625, Ch 14, Sec 1, 4.3)
    /// EDWs can be considered as "physical" motion cases.
    /// Each "logical" Load case LC1...LC4 for cargo units is mapped into one "physical" EDW, depending on cargo position on board.
    /// </summary>
    public enum EquivalentDesignWaves
    {
        /// <summary>
        /// Beam sea with maximum negative roll motion, portside exposed to waves
        /// </summary>
        BR1_P,

        /// <summary>
        /// Beam sea with maximum positive roll motion, portside exposed to waves
        /// </summary>
        BR2_P,

        /// <summary>
        /// Beam sea with maximum positive roll motion, starboard exposed to waves
        /// </summary>
        BR1_S,

        /// <summary>
        /// Beam sea with maximum negative roll motion, starboard exposed to waves
        /// </summary>
        BR2_S,

        /// <summary>
        /// Beam sea with maximum negative hydrodynamic pressure at the waterline amidships, portside exposed to waves
        /// </summary>
        BP1_P,

        /// <summary>
        /// Beam sea with maximum positive hydrodynamic pressure at the waterline amidships, portside exposed to waves
        /// </summary>
        BP2_P,

        /// <summary>
        /// Beam sea with maximum negative hydrodynamic pressure at the waterline amidships, starboard exposed to waves
        /// </summary>
        BP1_S,

        /// <summary>
        /// Beam sea with maximum positive hydrodynamic pressure at the waterline amidships, starboard exposed to waves
        /// </summary>
        BP2_S,

        /// <summary>
        /// Oblique sea with maximum negative vertical acceleration at L from AE, portside exposed to waves
        /// </summary>
        OVA1_P,

        /// <summary>
        /// Oblique sea with maximum positive vertical acceleration at L from AE, portside exposed to waves
        /// </summary>
        OVA2_P,

        /// <summary>
        /// Oblique sea with maximum negative vertical acceleration at L from AE, starboard exposed to waves
        /// </summary>
        OVA1_S,

        /// <summary>
        /// Oblique sea with maximum positive vertical acceleration at L from AE, starboard exposed to waves
        /// </summary>
        OVA2_S,

        /// <summary>
        /// Specific load case
        /// </summary>
        SPLC_Max,

        /// <summary>
        /// Specific load case
        /// </summary>
        SPLC_Min
    }
}