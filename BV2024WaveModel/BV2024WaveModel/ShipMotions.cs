using System;
using System.Diagnostics;

namespace Macs3.Modules.Lash.Abstractions.BV2017
{
    public class ShipMotions
    {

        private static readonly WaveParameterCoefficient[] WaveParametersRoute =
        {
            // LASHING, NR 625, Ch 4, Sec 3, 2.1, Table 1
            new WaveParameterCoefficient { A0 = 1.00, A1 = 1.5, e1 = 2.20, A2 = 0.45, e2 = 1.70, Lc = 486.0 }, 
            // LASHING, NR 467, Pt F, Ch 12, Sec 5, 4.3.5, Table 10
            new WaveParameterCoefficient { A0 = 0.67, A1 = 1.38, e1 = 1.90, A2 = 0.34, e2 = 1.12, Lc = 413.0 }, 
 
            new WaveParameterCoefficient { A0 = 0.83, A1 = 1.41, e1 = 1.87, A2 = 0.40, e2 = 1.30, Lc = 517.0  },

            new WaveParameterCoefficient { A0 = 1.00, A1 = 1.5, e1 = 2.20, A2 = 0.45, e2 = 1.70, Lc = 486.0 },

            new WaveParameterCoefficient { A0 = 0.79, A1 = 1.43, e1 = 1.90, A2 = 0.39, e2 = 1.30, Lc = 505.0  },

            new WaveParameterCoefficient { A0 = 0.82, A1 = 1.43, e1 = 1.89, A2 = 0.39, e2 = 1.30, Lc = 509.0  },

            new WaveParameterCoefficient { A0 = 0.60, A1 = 1.49, e1 = 1.94, A2 = 0.39, e2 = 1.21, Lc = 356.0  },

            new WaveParameterCoefficient { A0 = 0.63, A1 = 1.50, e1 = 2.00, A2 = 0.32, e2 = 1.18, Lc = 378.0  },

            new WaveParameterCoefficient { A0 = 0.77, A1 = 1.43, e1 = 1.90, A2 = 0.39, e2 = 1.31, Lc = 486.0  },

            new WaveParameterCoefficient { A0 = 0.75, A1 = 1.40, e1 = 1.91, A2 = 0.39, e2 = 1.31, Lc = 486.0  },

            new WaveParameterCoefficient { A0 = 0.84, A1 = 1.45, e1 = 1.92, A2 = 0.36, e2 = 1.24, Lc = 474.0  },

            new WaveParameterCoefficient { A0 = 0.84, A1 = 1.42, e1 = 1.92, A2 = 0.39, e2 = 1.32, Lc = 504.0  },

            new WaveParameterCoefficient { A0 = 0.70, A1 = 1.49, e1 = 1.89, A2 = 0.38, e2 = 1.24, Lc = 393.0  },

            new WaveParameterCoefficient { A0 = 0.60, A1 = 1.58, e1 = 1.98, A2 = 0.35, e2 = 1.10, Lc = 347.0  },

            new WaveParameterCoefficient { A0 = 0.81, A1 = 1.46, e1 = 1.97, A2 = 0.36, e2 = 1.29, Lc = 472.0  },

            new WaveParameterCoefficient { A0 = 1.00, A1 = 1.5, e1 = 2.20, A2 = 0.45, e2 = 1.70, Lc = 486.0 },

            new WaveParameterCoefficient { A0 = 1.00, A1 = 1.5, e1 = 2.20, A2 = 0.45, e2 = 1.70, Lc = 486.0 },

            new WaveParameterCoefficient { A0 = 0.85, A1 = 1.42, e1 = 1.91, A2 = 0.39, e2 = 1.31, Lc = 509.0  },

            new WaveParameterCoefficient { A0 = 0.73, A1 = 1.38, e1 = 1.85, A2 = 0.39, e2 = 1.25, Lc = 441.0  },

            new WaveParameterCoefficient { A0 = 0.65, A1 = 1.49, e1 = 1.95, A2 = 0.36, e2 = 1.18, Lc = 382.0  }
        };

        private static readonly WaveParameterCoefficient[] WaveParametersWAF =
        {
            // LASHING, NR 467, Pt F, Ch 12, Sec 5, 4.3.5, Table 11
            new WaveParameterCoefficient { A0 = 0.15, A1 = 2.53, e1 = 2.95, A2 = 0.21, e2 = 1.23, Lc = 118.0 }, 

            new WaveParameterCoefficient { A0 = 0.24, A1 = 2.26, e1 = 2.73, A2 = 0.15, e2 = 1.45, Lc = 150.0 }, 

            new WaveParameterCoefficient { A0 = 0.34, A1 = 1.94, e1 = 2.51, A2 = 0.19, e2 = 1.65, Lc = 188.0 },

            new WaveParameterCoefficient { A0 = 0.44, A1 = 1.78, e1 = 2.29, A2 = 0.24, e2 = 1.78, Lc = 218.0 },

            new WaveParameterCoefficient { A0 = 0.54, A1 = 1.76, e1 = 2.26, A2 = 0.28, e2 = 1.74, Lc = 255.0 },

            new WaveParameterCoefficient { A0 = 0.63, A1 = 1.71, e1 = 2.19, A2 = 0.31, e2 = 1.71, Lc = 291.0 },

            new WaveParameterCoefficient { A0 = 0.73, A1 = 1.63, e1 = 2.08, A2 = 0.37, e2 = 1.75, Lc = 324.0 },

            new WaveParameterCoefficient { A0 = 0.82, A1 = 1.61, e1 = 2.06, A2 = 0.43, e2 = 1.72, Lc = 363.0 }
        };

        /// <summary>
        /// Gravitation constant in m/s2
        /// </summary>
        public double g0;

        /// <summary>
        /// Roll radius of gyration for considered loading condition, in m as per NR 625, Ch 4, Sec 3, 2.1.1, Table 2
        /// </summary>
        public double kr;

        /// <summary>
        /// Bilge keel coefficient  as per NR 625, Ch 4, Sec 3, 2.1.1
        /// </summary>
        public double fBK;

        /// <summary>
        /// Moulded breadth of the vessel, m
        /// </summary>
        public double B;

        /// <summary>
        /// Rule Length  of the vessel, m
        /// </summary>
        public double L;

        /// <summary>
        /// Longitudinal coordinate of the ship's centre of gravity from Rule aft end, m
        /// </summary>
        public double xG;

        /// <summary>
        /// Vertical coordinate of the ship's centre of gravity, m
        /// </summary>
        public double zG;

        /// <summary>
        /// Draught amidships for the considered loading condition, m
        /// </summary>
        public double Tlc;

        /// <summary>
        /// Ratio between draught at the considered loading condition and Rule Length
        /// </summary>
        public double fTL;

        /// <summary>
        /// Ratio between moulded breadth and Rule Length
        /// </summary>
        public double fBL;

        /// <summary>
        /// Routing factor
        /// </summary>
        public double fR = 0.85;

        /// <summary>
        /// Speed effect coefficient
        /// </summary>
        public double fS = 1.0;

        /// <summary>
        /// Coefficient for strength assessments which depends on the applicable design load scenario - to be taken as 1.0  as per NR 625, Ch 4, Sec 3, Symbols
        /// </summary>
        public double fPS = 1.0;

        /// <summary>
        /// Coefficient to be taken as fPS as per NR 625, Ch 4, Sec 3, Symbols
        /// </summary>
        public double fP;

        /// <summary>
        /// Non-linear factor to be taken as 1.0  as per NR 625, Ch 4, Sec 3, Symbols
        /// </summary>
        public double fNL = 1.0;

        /// <summary>
        /// Waterplane coefficient at considered  loading condition (0.8 per default in loadstar)
        /// </summary>
        public double Cw = 0.8;

        /// <summary>
        /// Roll angular frequency, in rad/s to be taken as 2 * PI / RollPeriod
        /// </summary>
        public double OmegaR;

        /// <summary>
        /// Heading correction factor, to be taken as : for extreme sea 0.80 for BR and BP, 1.00 for other equivalent design
        /// waves (EDWs) as per NR 625, Ch 4, Sec 3, Symbols
        /// </summary>
        public double[] fBeta;

        /// <summary>
        /// Block coefficient at considered loading condition
        /// </summary>
        public double Cb;

        /// <summary>
        /// Theta - Roll angle, deg  as per NR 625, Ch 4, Sec 3, 2.1.1
        /// </summary>
        public double MaxRollAngle;

        /// <summary>
        /// Theta - Roll angle, rad  as per NR 625, Ch 4, Sec 3, 2.1.1
        /// </summary>
        public double MaxRollAngleRadian;

        /// <summary>
        /// Theta - Roll angle, deg - Minimum value  as per NR 625, Ch 4, Sec 3, 2.1.1
        /// </summary>
        public double minRollAngle;

        /// <summary>
        /// Theta - Roll angle, deg - Calculated  as per NR 625, Ch 4, Sec 3, 2.1.1
        /// </summary>
        public double calcRollAngle;

        /// <summary>
        /// Phi - Pitch angle, deg as per NR 625, Ch 4, Sec 3, 2.1.2
        /// </summary>
        public double MaxPitchAngle;

        /// <summary>
        /// Phi - Pitch angle, rad as per NR 625, Ch 4, Sec 3, 2.1.2
        /// </summary>
        public double MaxPitchAngleRadian;

        /// <summary>
        /// Roll period, sec as per NR 625, Ch 4, Sec 3, 2.1.1
        /// </summary>
        public double RollPeriod;

        /// <summary>
        /// Calculated Dimensionless Roll period
        /// </summary>
        public double TRcalc;

        /// <summary>
        /// Maximum of dimensionless Roll period
        /// </summary>
        public double TRmax;

        /// <summary>
        /// Dimensionless Roll period
        /// </summary>
        public double TR;

        /// <summary>
        /// Pitch period, sec
        /// </summary>
        public double PitchPeriod;

        /// <summary>
        /// Roll motion related coefficient alpha for calculation of reference length Lref (used for navigation coefficient n as multiplier for roll period)
        /// </summary>
        public double Alpha;

        /// <summary>
        /// Roll motion related coefficient fAlpha for calculation of reference length Lref (used for navigation coefficient n as multiplier for roll period)
        /// </summary>
        public double fAlpha;

        /// <summary>
        /// Reference length, m, calculated for the notation LASHING, NR625, Ch14, Sec 1, 4.3.5
        /// </summary>
        public double Lref;

        /// <summary>
        /// Wave parameter, calculated for the notation LASHING, NR625, Ch14, Sec 1, 4.3.5
        /// </summary>
        public double H;

        /// <summary>
        /// Reference length, m, calculated for the notation LASHING-WW or LASHING(Restricted area), NR625, Ch14, Sec 1, 4.3.5
        /// </summary>
        public double LrefInRoute;

        /// <summary>
        /// Wave parameter, calculated for the notation LASHING-WW or LASHING(Restricted area), NR625, Ch14, Sec 1, 4.3.5
        /// </summary>
        public double HInRoute;

        /// <summary>
        /// H(InRoute)/H, the multiplier for Roll Angle, NR625, Ch14, Sec 1, 4.3.5
        /// </summary>
        public double RollAngleNotationFactor;

        #region Surge wave definitions as per NR 625, Ch 4, Sec 3, 2.2.1
        /// <summary>
        /// Coefficient alpha for calculation of reference length LrefSurge for calculation of wave parameter Hsurge 
        /// </summary>
        public double AlphaSurge;
        /// <summary>
        /// Coefficient fAlpha for calculation of reference length LrefSurge for calculation of wave parameter Hsurge 
        /// </summary>
        public double fAlphaSurge;
        /// <summary>
        /// Reference length LrefSurge for calculation of wave parameter Hsurge 
        /// </summary>
        public double LrefSurge;
        /// <summary>
        /// Wave parameter Hsurge, used for calculation of longitudinal acceleration due to surge
        /// </summary>
        public double Hsurge;
        #endregion Surge wave definitions as per NR 625, Ch 4, Sec 3, 2.2.1

        #region Sway wave definitions as per NR 625, Ch 4, Sec 3, 2.2.2
        /// <summary>
        /// Coefficient alpha for calculation of reference length LrefSway for calculation of wave parameter Hsway
        /// </summary>
        public double AlphaSway;
        /// <summary>
        /// Coefficient fAlpha for calculation of reference length LrefSway for calculation of wave parameter Hsway
        /// </summary>
        public double fAlphaSway;
        /// <summary>
        /// Reference length LrefSway for calculation of wave parameter Hsway
        /// </summary>
        public double LrefSway;
        /// <summary>
        /// Wave parameter Hsway, used for calculation of transversal acceleration due to sway
        /// </summary>
        public double Hsway;
        #endregion Sway wave definitions as per NR 625, Ch 4, Sec 3, 2.2.1

        #region Heave wave definitions as per NR 625, Ch 4, Sec 3, 2.2.3
        /// <summary>
        /// Coefficient alpha for calculation of reference length LrefHeave for calculation of wave parameter Hheave
        /// </summary>
        public double AlphaHeave;
        /// <summary>
        /// Coefficient fAlpha for calculation of reference length LrefHeave for calculation of wave parameter Hheave
        /// </summary>
        public double fAlphaHeave;
        /// <summary>
        /// Reference length LrefHeave for calculation of wave parameter Hheave
        /// </summary>
        public double LrefHeave;
        /// <summary>
        /// Wave parameter Hheave, used for calculation of vertical acceleration due to heave
        /// </summary>
        public double Hheave;
        #endregion Heave wave definitions as per NR 625, Ch 4, Sec 3, 2.2.3

        #region Pitch wave definitions as per NR 625, Ch 4, Sec 3, 2.2.5
        /// <summary>
        /// Coefficient alpha for calculation of reference length LrefPitch for calculation of wave parameter Hpitch
        /// </summary>
        public double AlphaPitch;
        /// <summary>
        /// Coefficient fAlpha for calculation of reference length LrefPitch for calculation of wave parameter Hpitch
        /// </summary>
        public double fAlphaPitch;
        /// <summary>
        /// Reference length LrefPitch for calculation of wave parameter Hpitch
        /// </summary>
        public double LrefPitch;
        /// <summary>
        /// Wave parameter Hpitch, used for calculation of pitch acceleration
        /// </summary>
        public double Hpitch;
        #endregion Pitch wave definitions as per NR 625, Ch 4, Sec 3, 2.2.5

        #region Yaw wave definitions as per NR 625, Ch 4, Sec 3, 2.2.6
        /// <summary>
        /// Coefficient alpha for calculation of reference length LrefYaw for calculation of wave parameter Hyaw
        /// </summary>
        public double AlphaYaw;
        /// <summary>
        /// Coefficient fAlpha for calculation of reference length LrefYaw for calculation of wave parameter Hyaw
        /// </summary>
        public double fAlphaYaw;
        /// <summary>
        /// Reference length LrefYaw for calculation of wave parameter Hyaw
        /// </summary>
        public double LrefYaw;
        /// <summary>
        /// Wave parameter Hyaw, used for calculation of yaw acceleration
        /// </summary>
        public double HYaw;
        #endregion Yaw wave definitions as per NR 625, Ch 4, Sec 3, 2.2.6

        /// <summary>
        /// The longitudinal acceleration due to surge, in m/s2 as per NR 625, Ch 4, Sec 3, 2.2.1
        /// </summary>
        public double aSurge; // m/s2

        /// <summary>
        /// The transverse acceleration due to sway, in m/s2 as per NR 625, Ch 4, Sec 3, 2.2.2
        /// </summary>
        public double aSway; // m/s2

        /// <summary>
        /// The vertical acceleration due to heave, m/s2 as per NR 625, Ch 4, Sec 3, 2.2.3
        /// </summary>
        public double aHeave;

        /// <summary>
        /// The roll acceleration in rad/s2 as per NR 625, Ch 4, Sec 3, 2.2.4
        /// </summary>
        public double aRoll;

        /// <summary>
        /// The pitch acceleration in rad/s2 as per NR 625, Ch 4, Sec 3, 2.2.5
        /// </summary>
        public double aPitch;

        /// <summary>
        /// The yaw acceleration in rad/s2 as per NR 625, Ch 4, Sec 3, 2.2.6
        /// </summary>
        public double aYaw;

        #region Loading combination factors as per NR 625, Ch 4, Sec 2, Symbols
        /// <summary>
        /// Loading combination factor for surge acceleration
        /// </summary>
        public double[] CxS;

        /// <summary>
        /// Loading combination factor for longitudinal acceleration due to pitch
        /// </summary>
        public double[] CxP;

        /// <summary>
        /// Loading combination factor for longitudinal acceleration due to yaw
        /// </summary>
        public double[] CxY;

        /// <summary>
        /// Loading combination factor for gravitational acceleration due to pitch
        /// </summary>
        public double[] CxG;

        /// <summary>
        /// Loading combination factor for sway acceleration
        /// </summary>
        public double[] CyS;

        /// <summary>
        /// Loading combination factor for transverse acceleration due to roll
        /// </summary>
        public double[] CyR;

        /// <summary>
        /// Loading combination factor for transverse acceleration due to yaw
        /// </summary>
        public double[] CyY;

        /// <summary>
        /// Loading combination factor for gravitational acceleration due to roll
        /// </summary>
        public double[] CyG;

        /// <summary>
        /// Loading combination factor for heave acceleration
        /// </summary>
        public double[] CzH;

        /// <summary>
        /// Loading combination factor for vertical acceleration due to roll
        /// </summary>
        public double[] CzR;

        /// <summary>
        /// Loading combination factor for vertical acceleration due to pitch
        /// </summary>
        public double[] CzP;
        #endregion Loading combination factors as per NR 625, Ch 4, Sec 2, Symbols

        private WaveParameterCoefficient _waveParameterCoefficient;

        public WaveParameterCoefficient WaveParameterCoefficient => _waveParameterCoefficient;

        public ShipMotions(double vesselLength, double ruleLength, double vesselBreadth, bool hasBilgeKeel, double blockCoefficient, double waterplaneCoefficient, double deckHeight, double gravitationConstant, double GM, double draught, int region, double fART)
        {
            if (region < 0 || region >= WaveParametersRoute.Length )
            {
                throw new Exception($"Region must be an integer between 0 and {WaveParametersRoute.Length}.");
            }
            _waveParameterCoefficient = WaveParametersRoute[region];
            ShipMotionsCount(vesselLength, ruleLength, vesselBreadth, hasBilgeKeel, blockCoefficient, waterplaneCoefficient, deckHeight, gravitationConstant, GM, draught, _waveParameterCoefficient, fART);
        }
        public ShipMotions(double vesselLength, double ruleLength, double vesselBreadth, bool hasBilgeKeel, double blockCoefficient, double waterplaneCoefficient, double deckHeight, double gravitationConstant, double GM, double draught, double waveHeight, double fART)
        {
            if (waveHeight <= 0 || waveHeight > 8)
            {
                throw new Exception("Wave height must be greater greater then 0 and less than 8.");
            }

            _waveParameterCoefficient = WaveParametersWAF[Convert.ToInt32(Math.Ceiling(waveHeight))];
            ShipMotionsCount(vesselLength, ruleLength, vesselBreadth, hasBilgeKeel, blockCoefficient, waterplaneCoefficient, deckHeight, gravitationConstant, GM, draught, _waveParameterCoefficient, fART);
        }

        public void ShipMotionsCount(double vesselLength, double ruleLength, double vesselBreadth, bool hasBilgeKeel, double blockCoefficient, double waterplaneCoefficient, double deckHeight, double gravitationConstant, double GM, double draught, WaveParameterCoefficient _waveParameterCoefficient, double fART)
        {
            g0 = gravitationConstant;
            
            var waveParameterCoefficientUnrestricted = WaveParametersRoute[0];
            L = 0.96 * vesselLength;
            if (ruleLength > 0.1)
            {
                L = ruleLength;
            }
            var gm = Math.Max(GM, 0.1);
            B = vesselBreadth;
            kr = 0.35 * B;
            Tlc = draught;
            if (waterplaneCoefficient > 0.1 && waterplaneCoefficient < 1.0)
            {
                Cw = waterplaneCoefficient;
            }
            Cb = blockCoefficient;
            if (Cb < 0.01)
            {
                Cb = 0.65;
            }
            // NR625, Ch 4, Sec 3, Symbols, p. 124
            xG = 0.57 * Math.Pow(Cb, 0.4) * L;
            // NR625, Ch 4, Sec 3, Symbols, p. 124
            zG = 1.08 * (Tlc / 2 + B * B / (12 * Tlc)) - GM;
            // NR625, Ch 4, Sec 3, 2.1.1, p. 125
            fBK = hasBilgeKeel ? 1.0 : 1.2;
            if (fBK > 1.0)
            {
                Debug.WriteLine("No bilge keel, fBK = 1.2!!!");
            }
            fP = fPS;
            // NR625, Ch 4, Sec 3, Symbols, p. 124
            fTL = Tlc / L;
            // NR625, Ch 4, Sec 3, Symbols, p. 124
            fBL = B / L;
            // NR 625, Ch 4, Sec 3, 2.1.1
            RollPeriod = 2.3 * Math.PI * kr / Math.Sqrt(g0 * gm);
            // NR 625, Ch 4, Sec 3, 2.1.2
            PitchPeriod = 0.8 * Math.Sqrt(L);
            OmegaR = 2 * Math.PI / RollPeriod;
            TR = TRcalc = RollPeriod * Math.Sqrt(g0 / L);
            TRmax = 75 / Math.Sqrt(L);
            if (TR > TRmax)
            {
                TR = TRmax;
            }
            InitLoadCombinationFactors();
            // NR625, Ch 14, Sec 1, 4.3.5, p. 318 and NR625, Ch 4, Sec 3, 2.1.1, p. 125
            Alpha = 4.6 / (TR * TR);
            // NR625, Ch 14, Sec 1, 4.3.5, p. 318 and NR625, Ch 4, Sec 3, 2.1.1, p. 125
            fAlpha = 1.0;
            Lref = GetLref(Alpha, fAlpha, waveParameterCoefficientUnrestricted.Lc);
            LrefInRoute = GetLref(Alpha, fAlpha, _waveParameterCoefficient.Lc);
            H = GetH(L, Lref, fP, waveParameterCoefficientUnrestricted);
            HInRoute = GetH(L, LrefInRoute, fP, _waveParameterCoefficient);
            RollAngleNotationFactor = HInRoute / H;
            MaxRollAngle = GetDefMaxRollAngle(B, RollPeriod, fBK, 1.0, ref calcRollAngle, ref minRollAngle);
            MaxRollAngle *= RollAngleNotationFactor;
            if (fART > 0.1)
            {
                MaxRollAngle *= fART;
            }
            MaxPitchAngle = GetDefMaxPitchAngle(_waveParameterCoefficient, L, fP, fR, fS, fNL, Cw);
            MaxRollAngleRadian = MaxRollAngle * Math.PI / 180.0;
            MaxPitchAngleRadian = MaxPitchAngle * Math.PI / 180.0;
            // NR 625, Ch 4, Sec 3, 2.2.1
            AlphaSurge = 0.37 / Math.Pow(Cw, 0.9);
            fAlphaSurge = 1.0;
            LrefSurge = GetLref(AlphaSurge, fAlphaSurge, _waveParameterCoefficient.Lc);
            Hsurge = GetH(L, LrefSurge, fP, _waveParameterCoefficient);
            aSurge = 115 * fR * fS * fNL * Hsurge / (L * Math.Pow(fTL, 0.2) * Math.Pow(Cb, 0.6)); // m/s2
            // NR 625, Ch 4, Sec 3, 2.2.2
            AlphaSway = 0.24 / Math.Pow(fBL, 0.65);
            fAlphaSway = 1.0;
            LrefSway = GetLref(AlphaSway, fAlphaSway, _waveParameterCoefficient.Lc);
            Hsway = GetH(L, LrefSway, fP, _waveParameterCoefficient);
            aSway = 115 * fR * fS * fNL * Hsway / (L * Math.Pow(fTL, 0.15) * Math.Pow(fBL, 0.5)); // m/s2
            // NR 625, Ch 4, Sec 3, 2.2.3
            AlphaHeave = 0.35 / Math.Pow(fTL, 0.35);
            fAlphaHeave = 1.0; 
            LrefHeave = GetLref(AlphaHeave, fAlphaHeave, _waveParameterCoefficient.Lc);
            Hheave = GetH(L, LrefHeave, fP, _waveParameterCoefficient);
            aHeave = 350 * fR * fS * fNL * Hheave / (L * Math.Pow(fBL, 0.5)); // m/s2
            // NR 625, Ch 4, Sec 3, 2.2.4
            var rollFrequency = 2 * Math.PI / RollPeriod;
            aRoll = MaxRollAngle * Math.PI * (rollFrequency * rollFrequency) / 180.0; //rad/s2
            // NR 625, Ch 4, Sec 3, 2.2.5
            AlphaPitch = 0.24 / Math.Pow(fBL, 0.8);
            fAlphaPitch = 1.0;
            LrefPitch = GetLref(AlphaPitch, fAlphaPitch, _waveParameterCoefficient.Lc);
            Hpitch = GetH(L, LrefPitch, fP, _waveParameterCoefficient);
            const double pitchConstant = 60000 * Math.PI / 180.0;
            aPitch = pitchConstant * fR * fS * fNL * Hpitch / (L * L * Math.Sqrt(fBL) * Math.Pow(Cw, 1.5));
            // NR 625, Ch 4, Sec 3, 2.2.6
            AlphaYaw = 1.14 / Math.Pow(Cb, 0.7);
            fAlphaYaw = 1.0; 
            LrefYaw = GetLref(AlphaYaw, fAlphaYaw, _waveParameterCoefficient.Lc);
            HYaw = GetH(L, LrefYaw, fP, _waveParameterCoefficient);
            var yawConstant = 200.4 * 100 * Math.PI / 180.0;
            aYaw = yawConstant * fR * fS * fNL * HYaw / (L * L * Math.Pow(fBL, 0.73));
        }

        /// <summary>
        /// Calculates Roll Angle amplitude in degreesas per NR 625, Ch 4, Sec 3, 2.1.1
        /// </summary>
        /// <param name="B">Breadth, m</param>
        /// <param name="RollPeriod">Roll period, seconds</param>
        /// <param name="fBK">Bilge keel factor</param>
        /// <param name="fFA">Coefficient for assessment</param>
        /// <param name="calcRollAngle">Roll angle, calculated by formula</param>
        /// <param name="minRollAngle">Minimal value of roll angle ("without being taken less than...")</param>
        /// <returns>Roll Angle Theta as per NR 625, Ch 4, Sec 3, 2.1.1</returns>
        public static double GetDefMaxRollAngle(double B, double RollPeriod, double fBK, double fFA, ref double calcRollAngle, ref double minRollAngle)
        {
            var rollAngle = calcRollAngle = 9000 * (1.25 - 0.025 * RollPeriod) * fFA * fBK / (Math.PI * (B + 75.0));
            minRollAngle = fFA * fBK * 1862.0 / (B + 75.0);
            if (calcRollAngle < minRollAngle)
            {
                rollAngle = minRollAngle;
            }
            return rollAngle;
        }

        /// <summary>
        /// Calculates Pitch Angle amplitude in degrees as per NR 625, Ch 4, Sec 3, 2.1.2
        /// </summary>
        /// <param name="waveParameters">Wave Parameter Coefficients, e.g. as defined in NR 625, Ch 4, Sec 3, Table 1</param>
        /// <param name="L">Rule Length</param>
        /// <param name="fP">Pitching factor</param>
        /// <param name="fR">Routing factor</param>
        /// <param name="fS">Speed effect coefficient</param>
        /// <param name="fNL">Non-linear coefficient</param>
        /// <param name="Cw">Waterplane coefficient</param>
        /// <returns>Pitch Angle amplitude, in degrees as per NR 625, Ch 4, Sec 3, 2.1.2</returns>
        private static double GetDefMaxPitchAngle(WaveParameterCoefficient waveParameters, double L, double fP, double fR, double fS, double fNL, double Cw)
        {
            //Pitch Angle amplitude, in degrees
            var AlphaPitch = 0.56;
            var fAlphaPitch = 1.0; // as for strength assessment
            var LrefPitch = GetLref(AlphaPitch, fAlphaPitch, waveParameters.Lc);
            var HPitch = GetH(L, LrefPitch, fP, waveParameters);
            var maxPitchAngle = 1970 * fR * fS * fNL * HPitch / (L * Math.Pow(Cw, 0.75));
            return maxPitchAngle;
        }

        /// <summary>
        /// Calculates Wave Parameter H in meters as per NR 625, Ch 4, Sec 3, 1.1.1
        /// </summary>
        /// <param name="L">Rule length in meters</param>
        /// <param name="Lref">Reference length in meters</param>
        /// <param name="w">Wave Parameter Coefficients, e.g. as defined in NR 625, Ch 4, Sec 3, Table 1</param>
        /// <returns> Wave Parameter H in meters</returns>
        private static double GetH(double L, double Lref, double fP, WaveParameterCoefficient w)
        {
            double aPow;
            if (L <= Lref)
            {
                aPow = w.A1 * Math.Pow(1 - Math.Sqrt(L / Lref), w.e1);
            }
            else
            {
                aPow = w.A2 * Math.Pow(Math.Sqrt(L / Lref) - 1, w.e2);
            }
            var waveParameterH = fP * w.A0 * (1 - aPow);
            return waveParameterH;
        }

        /// <summary>
        /// Calculates reference length in meters as per NR 625, Ch 4, Sec 3, 1.1.1
        /// </summary>
        /// <param name="alpha">Parameter defined fir the considered load</param>
        /// <param name="fAlpha">Speed effect coefficient</param>
        /// <param name="Lc">Length in wave parameter coefficients table, e.g. as defined in NR 625, Ch 4, Sec 3, Table 1</param>
        /// <returns>Reference length in meters</returns>
        private static double GetLref(double alpha, double fAlpha, double Lc)
        {
            var Lref = alpha * fAlpha * Lc;
            return Lref;
        }

        /// <summary>
        /// Initialization of load combination factors (LCFs) as per NR 625, Ch 4, Sec 3
        /// </summary>
        private void InitLoadCombinationFactors()
        {
            var CyS_BR = 1.71 * OmegaR - 0.73;
            var CzH_BR = 0.88 - 0.15 * TR;
            var CyS_BP = 1.73 - 2.11 * OmegaR;
            var CyR_BP = 0.39 * TR - 1.82;
            var CyG_BP = 1.35 - 0.27 * TR;
            var CzR_BP = CyR_BP;
            var CxS_OVA = 8.40 * fTL - 0.81;
            var CxY_OVA = 0.30 + 13.3 * fTL;
            var CyR_OVA = 0.50 - 1.20 * OmegaR;
            var CyY_OVA = CxY_OVA;
            var CyG_OVA = -CyR_OVA;
            var CzH_OVA = -0.17 - 7.40 * fTL;
            var CzR_OVA = CyR_OVA;
            var CzH_SPLC = 10.72 * fTL - 0.28;
            var CzP_SPLC = 1.2 - 6.84 * fTL;
            CxS = new[] { 0.00, 0.00, 0.00, 0.00, /*BP*/ 0.00, 0.00, 0.00, 0.00, /*OVA*/ CxS_OVA, -CxS_OVA, CxS_OVA, -CxS_OVA, /*SPLC*/ 0.00, 0.00 };
            CxP = new[] { 0.00, 0.00, 0.00, 0.00, /*BP*/ 0.00, 0.00, 0.00, 0.00, /*OVA*/ 1.00, -1.00, 1.00, -1.00, /*SPLC*/ 0.00, 0.00 };
            CxY = new[] { 0.00, 0.00, 0.00, 0.00, /*BP*/ 0.10, -0.10, -0.10, 0.10, /*OVA*/ CxY_OVA, -CxY_OVA, -CxY_OVA, CxY_OVA, /*SPLC*/ 0.00, 0.00 };
            CxG = new[] { 0.00, 0.00, 0.00, 0.00, /*BP*/ 0.00, 0.00, 0.00, 0.00, /*OVA*/ -0.70, 0.70, -0.70, 0.70, /*SPLC*/ 0.00, 0.00 };
            CyS = new[] { CyS_BR, -CyS_BR, -CyS_BR, CyS_BR, /*BP*/ CyS_BP, -CyS_BP, -CyS_BP, CyS_BP, /*OVA*/ -0.36, 0.36, 0.36, -0.36, /*SPLC*/ 0.00, 0.00 };
            CyR = new[] { 1.00, -1.00, -1.00, 1.00, /*BP*/ CyR_BP, -CyR_BP, -CyR_BP, CyR_BP, /*OVA*/ CyR_OVA, -CyR_OVA, -CyR_OVA, CyR_OVA, /*SPLC*/ 0.00, 0.00 };
            CyY = new[] { 0.00, 0.00, 0.00, 0.00, /*BP*/ 0.10, -0.10, -0.10, 0.10, /*OVA*/ CyY_OVA, -CyY_OVA, -CyY_OVA, CyY_OVA, /*SPLC*/ 0.00, 0.00 };
            CyG = new[] { -1.00, 1.00, 1.00, -1.00, /*BP*/ CyG_BP, -CyG_BP, -CyG_BP, CyG_BP, /*OVA*/ CyG_OVA, -CyG_OVA, -CyG_OVA, CyG_OVA, /*SPLC*/ 0.00, 0.00 };
            CzH = new[] { CzH_BR, -CzH_BR, CzH_BR, -CzH_BR, /*BP*/ -1.00, 1.00, -1.00, 1.00, /*OVA*/ CzH_OVA, -CzH_OVA, CzH_OVA, -CzH_OVA, /*SPLC*/ CzH_SPLC, -CzH_SPLC };
            CzR = new[] { 1.00, -1.00, -1.00, 1.00, /*BP*/ CzR_BP, -CzR_BP, -CzR_BP, CzR_BP, /*OVA*/ CzR_OVA, -CzR_OVA, -CzR_OVA, CzR_OVA, /*SPLC*/ 0.00, 0.00 };
            CzP = new[] { 0.00, 0.00, 0.00, 0.00, /*BP*/ 0.00, 0.00, 0.00, 0.00, /*OVA*/ 1.00, -1.00, 1.00, -1.00, /*SPLC*/ CzP_SPLC, -CzP_SPLC };
            fBeta = new[] { 0.80, 0.80, 0.80, 0.80, /*BP*/ 0.80, 0.80, 0.80, 0.80, /*OVA*/ 1.00, 1.00, 1.00, 1.00, /*SPLC*/ 1.00, 1.00 };
        }

        /// <summary>
        /// Calculates longitudinal acceleration ax in m/s2 for given point in given Equivalent Design Waves case as per NR 625, Ch4, Sec 3, 3.2.2
        /// </summary>
        /// <param name="y">Transversal distance from center line, m</param>
        /// <param name="z">Vertical distance above b.o.k</param>
        /// <param name="equivalentDesignWaves">Equivalent Design Waves in which we have to calculate the acceleration</param>
        /// <returns>Longitudinal acceleration in m/s2</returns>
        public double GetLongitudinalAcceleration(double y, double z, EquivalentDesignWaves equivalentDesignWaves)
        {
            var equivalentDesignWaveIndex = EquivalentDesignWaveIndexMapping.EquivalentDesignWaveToIndex(equivalentDesignWaves);
            var gravitation = -CxG[equivalentDesignWaveIndex] * g0 * Math.Sin(fBeta[equivalentDesignWaveIndex] * MaxPitchAngleRadian);
            var surge = CxS[equivalentDesignWaveIndex] * aSurge;
            var aPitchX = aPitch * (z - zG);
            var pitch = CxP[equivalentDesignWaveIndex] * aPitchX;
            var aYawX = aYaw * y;
            var yaw = -CxY[equivalentDesignWaveIndex] * aYawX;
            var longitudinalAcceleration = gravitation + fBeta[equivalentDesignWaveIndex] * (surge + pitch + yaw);
            return longitudinalAcceleration;
        }

        /// <summary>
        /// Calculates transversal acceleration ay in m/s2 for given point in given Equivalent Design Waves case as per NR 625, Ch4, Sec 3, 3.2.3
        /// </summary>
        /// <param name="x">Longitudinal distance from the Rule aft end, m</param>
        /// <param name="z">Vertical distance above b.o.k</param>
        /// <param name="equivalentDesignWaves">Equivalent Design Waves in which we have to calculate the acceleration</param>
        /// <returns>Transversal acceleration ay in m/s2</returns>
        public double GetTransversalAcceleration(double x, double z, EquivalentDesignWaves equivalentDesignWaves)
        {
            var equivalentDesignWaveIndex = EquivalentDesignWaveIndexMapping.EquivalentDesignWaveToIndex(equivalentDesignWaves);
            var gravitation = CyG[equivalentDesignWaveIndex] * g0 * Math.Sin(MaxRollAngleRadian);
            var sway = CyS[equivalentDesignWaveIndex] * aSway;
            var aYawY = aYaw * (x - xG);
            var yaw = CyY[equivalentDesignWaveIndex] * aYawY;
            var aRollY = aRoll * (z - zG);
            var roll = CyR[equivalentDesignWaveIndex] * aRollY;
            var transversalAcceleration = gravitation + fBeta[equivalentDesignWaveIndex] * (sway + yaw) - roll;
            return transversalAcceleration;
        }

        /// <summary>
        /// Calculates vertical acceleration av in m/s2 for given point for given Equivalent Design Waves case as per NR 625, Ch4, Sec 3, 3.2.4
        /// </summary>
        /// <param name="x">Longitudinal distance from the Rule aft end, m</param>
        /// <param name="y">Transversal distance from center line, m</param>
        /// <param name="equivalentDesignWaves">Equivalent Design Waves in which we have to calculate the acceleration</param>
        /// <returns>Vertical acceleration av in m/s2</returns>
        public double GetVerticalAcceleration(double x, double y, EquivalentDesignWaves equivalentDesignWaves)
        {
            var equivalentDesignWaveIndex = EquivalentDesignWaveIndexMapping.EquivalentDesignWaveToIndex(equivalentDesignWaves);
            var heave = CzH[equivalentDesignWaveIndex] * aHeave;
            var aPitchZ = aPitch * (x - xG);
            var pitch = CzP[equivalentDesignWaveIndex] * aPitchZ;
            var aRollZ = aRoll * y;
            var roll = CzR[equivalentDesignWaveIndex] * aRollZ;
            var verticalAcceleration = fBeta[equivalentDesignWaveIndex] * (heave - pitch) + roll;
            return verticalAcceleration;
        }

    }
}