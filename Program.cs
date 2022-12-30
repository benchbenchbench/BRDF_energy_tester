using BRDF_energy_tester;
using System;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

static string TestMethod()
{
    double halfSphereTest = BRDF_energy_tester.SphericalGeometry.SurfaceAreaPatch( Math.PI, 0.0d, Math.PI, 0.0d);
    double quarterSphereTest = BRDF_energy_tester.SphericalGeometry.SurfaceAreaPatch(Math.PI, 0.0d, (Math.PI/2.0d), 0.0d);
    double fullSphereTest = SphericalGeometry.SurfaceArea(1.0d);


    double numberOfSegments_long = 4;
    double segment_long = (Math.PI * 2.0d) / numberOfSegments_long;

    double numberOfSegments_lat = 4;
    double segment_lat = (Math.PI / 2.0d) / numberOfSegments_lat;

    double totalArea = 0.0d;
    for (int i = 0; i < numberOfSegments_long; i++)
    {
        
        double phi0 = (double)i * segment_long;
        double phi1 = (double)(i + 1) * segment_long;
        for(int j = 0; j < numberOfSegments_lat; j++)
        {
            double theta0 = (double)j * segment_lat;
            double theta1 = (double)(j + 1) * segment_lat;
            totalArea += Math.Abs(SphericalGeometry.SurfaceAreaPatch(theta1, theta0, phi1, phi0));
        }
        
    }
    
    
    
    
    return string.Format("Result:  {0}", totalArea);
}

Console.WriteLine(TestMethod());



public class TestClass : TestInterface
{
    private string m_child = "Ella";
    private string m_parent = "Joe";

    public void TestCLass(string name)
    {
        Name = name;
    }

    public string? Name { get; set; }
    public string Child
    {
        get { return m_child; }
        set { m_child = value; }
    }

    public string Parent
    {
        get { return m_parent; }
        set { m_parent = value; }
    }

    public string GetParent()
    {
        return m_parent;
    }

}





