using BRDF_energy_tester;
using System;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

static string TestMethod()
{
    return "This is a test method.";
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





