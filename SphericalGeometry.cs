using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRDF_energy_tester
{
    public static class SphericalGeometry
    {

        /// <summary>
        /// Calculates the surface area patch of a sphere by the spherical coordinates theta and phi. The patch is rectangular. 
        /// Theta and phi are not great circles but the lattitude and longitude spherical coordinates
        /// </summary>
        /// <param name="theta1">The starting position of the "lattitude" marker. Unit should be provided in radians.</param>
        /// <param name="theta2">The ending position of the "lattitude" marker. Unit should be provided in radians.</param>
        /// <param name="phi1">The starting position of the "longitude" marker. Unit should be provided in radians.</param>
        /// <param name="phi2">the ending position of the "longitude" marker. Unit should be provided in radians.</param>
        /// <param name="R">The radius of the sphere. Assumed to be 1.0 if no value given.</param>
        /// <returns>The surface area in units squared. </returns>
        public static double SurfaceAreaPatch(double theta1, double theta2, double phi1, double phi2, double R = 1.0d)
        {
            return (theta2 - theta1) * (Math.Cos(phi1) - Math.Cos(phi2)) * R * R;
        }

        /// <summary>
        /// Calculates the surface area of a sphere based upon the radius length. 
        /// </summary>
        /// <param name="radius">Size of the sphere. Assumed to be 1.0 if no value given. </param>
        /// <returns></returns>
        public static double SurfaceArea(double radius = 1.0d)
        {
            return 4.0d * Math.PI * radius * radius;
        }
    }
}
