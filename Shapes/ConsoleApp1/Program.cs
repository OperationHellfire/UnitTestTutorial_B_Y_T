using NUnit.Framework;
using Tut2_s20123;
using Tut2_s20123_Tests;

/*// Create a Sphere with radius 5
IShape sphere = new Sphere(5);
Console.WriteLine("Sphere:");
Console.WriteLine($"Area: {sphere.CalculateArea():F3}");
Console.WriteLine($"Volume: {sphere.CalculateVolume():F3}");
Console.WriteLine();

// Create a Cylinder with radius 3 and height 7
IShape cylinder = new Cylinder(3, 7);
Console.WriteLine("Cylinder:");
Console.WriteLine($"Area: {cylinder.CalculateArea():F3}");
Console.WriteLine($"Volume: {cylinder.CalculateVolume():F3}");
Console.WriteLine();

// Create a Rectangle with length 4 and width 8
IShape rectangle = new Rectangle(4, 8);
Console.WriteLine("Rectangle:");
Console.WriteLine($"Area: {rectangle.CalculateArea():F3}");
// Rectangle is a 2D shape, so volume is 0
Console.WriteLine($"Volume: {rectangle.CalculateVolume():F3}");
Console.WriteLine();

// Create a Cube with side 4
IShape cube = new Cube(4);
Console.WriteLine("Cube:");
Console.WriteLine($"Area: {cube.CalculateArea():F3}");
Console.WriteLine($"Volume: {cube.CalculateVolume():F3}");*/


Tests ty = new Tests();

try
{
    ty.TestCylinderCalculateVolume();
    Console.WriteLine("Test 1 passed");
    ty.TestCylinderCalculateArea();
    Console.WriteLine("Test 2 passed");
    ty.TestSphereCalculateArea();
    Console.WriteLine("Test 3 passed");
    ty.TestSphereCalculateVolume();
    Console.WriteLine("Test 4 passed");
    ty.TestRectangleCalculateArea();
    Console.WriteLine("Test 5 passed");
    ty.TestRectangleCalculateVolume();
    Console.WriteLine("Test 6 passed");
    ty.TestCubeCalculateArea();
    Console.WriteLine("Test 7 passed");
    ty.TestCubeCalculateVolume();
    Console.WriteLine("Test 8 passed");

    Console.WriteLine("All Tests passed");
} catch (AssertionException e)
{
    Console.WriteLine(e.Message);
}
