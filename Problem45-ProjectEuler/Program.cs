
List<double> triangles = new();
List<double> pentagonals = new();
List<double> hexagonals = new();

for (double n = 1; n <= 100000; n++)
{
    triangles.Add(n* (n + 1) / 2);
    pentagonals.Add(n* ((3 * n) - 1) / 2);
    hexagonals.Add(n * ((2 * n) - 1));
}

double coincidence = 0;
foreach(double value in hexagonals)
{
    if(triangles.Contains(value) &&
        pentagonals.Contains(value) &&
        value > 40755)
        coincidence = value;
}

Console.WriteLine("The next triangle number that is also pentagonal and hexagonal is: " + coincidence);