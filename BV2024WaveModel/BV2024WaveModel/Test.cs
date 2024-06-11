using System;

namespace Macs3.Modules.Lash.Abstractions.BV2017
{
    class Test
    {
        static void Main(string[] args)
        {
            //ShipMotions routeParam = new ShipMotions(300, 295, 55, true, 0.65, 0.889, 28, 9.81, 2, 12, 0, 1);
            Point[] points = new Point[3];
            points[0] = new Point(10.0, 10.0, 4.0);
            points[1] = new Point(300.0, 0.0, 34.0);
            points[2] = new Point(145.0, -20.0, 50.0);

      
            double longitudinalAcceleration;
            double transversalAcceleration;
            double verticalAcceleration;

            var shipMotionsForWaveHeights = new ShipMotions[8];

            var shipMotionsForRoutes = new ShipMotions[20];

            foreach (var point in points)
            {
                Console.WriteLine($"({point.x}, {point.y}, {point.z})");
                for (int region = 0; region < 20; region++)
                {
                    shipMotionsForRoutes[region] = new ShipMotions(300, 295, 55, true, 0.65, 0.889, 28, 9.81, 2, 12, region, 1);
                    Console.WriteLine($"Region= {region}");
                    for (var wave = EquivalentDesignWaves.BR1_P; wave <= EquivalentDesignWaves.SPLC_Min; wave++)
                    {
                        longitudinalAcceleration = shipMotionsForRoutes[region].GetLongitudinalAcceleration(point.y, point.z, wave);
                        transversalAcceleration = shipMotionsForRoutes[region].GetTransversalAcceleration(point.x, point.z, wave);
                        verticalAcceleration = shipMotionsForRoutes[region].GetVerticalAcceleration(point.x, point.y, wave);
                        Console.WriteLine($"wave={wave}, l = {longitudinalAcceleration:f03}m/s2, t= {transversalAcceleration:f03}m/s2, v={verticalAcceleration:f03}m/s2");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("ship Motions For Waves");
            var shipMotionsForWaves = new ShipMotions[8];
            foreach (var point in points)
            {
                Console.WriteLine($"({point.x}, {point.y}, {point.z})");
                for (double waveHeight = 0.1; waveHeight < 7; waveHeight++)
                {
                    int w = Convert.ToInt32(Math.Ceiling(waveHeight));
                    Console.WriteLine($"Wave height= {w}m");
                    shipMotionsForWaves[w] = new ShipMotions(300, 295, 55, true, 0.65, 0.889, 28, 9.81, 2, 12, waveHeight, 1);
                    for (var wave = EquivalentDesignWaves.BR1_P; wave <= EquivalentDesignWaves.SPLC_Min; wave++)
                    {
                        longitudinalAcceleration = shipMotionsForWaves[w].GetLongitudinalAcceleration(point.y, point.z, wave);
                        transversalAcceleration = shipMotionsForWaves[w].GetTransversalAcceleration(point.x, point.z, wave);
                        verticalAcceleration = shipMotionsForWaves[w].GetVerticalAcceleration(point.x, point.y, wave);
                        Console.WriteLine($"wave={wave},l = {longitudinalAcceleration:f03}m/s2, t= {transversalAcceleration:f03}m/s2, v={verticalAcceleration:f03}m/s2");
                    }   
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}