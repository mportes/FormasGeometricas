Quadrado q1 = new Quadrado(2.0);
Quadrado q2 = new Quadrado(8.0);
Retangulo r1 = new Retangulo(3.0, 12.0);
Retangulo r2 = new Retangulo(4.0, 7.0);

Console.WriteLine("\n---------------------------\n");
Console.WriteLine("QUADRADO 1");
Console.WriteLine("Lado: {0}", q1.Lado);
Console.WriteLine("Área: {0}", q1.Area);
Console.WriteLine("Perímetro: {0}", q1.Perimetro);

Console.WriteLine("\n---------------------------\n");
Console.WriteLine("QUADRADO 2");
Console.WriteLine("Lado: {0}", q2.Lado);
Console.WriteLine("Área: {0}", q2.Area);
Console.WriteLine("Perímetro: {0}", q2.Perimetro);

//exemplo de set com prop
r1.Base = 5.0;

Console.WriteLine("\n---------------------------\n");
Console.WriteLine("RETÂNGULO 1");
Console.WriteLine("Base: {0}", r1.Base);
Console.WriteLine("Altura: {0}", r1.Altura);
Console.WriteLine("Área: {0}", r1.Area);
Console.WriteLine("Perímetro: {0}", r1.Perimetro);

Console.WriteLine("\n---------------------------\n");
Console.WriteLine("RETÂNGULO 2");
Console.WriteLine("Base: {0}", r2.Base);
Console.WriteLine("Altura: {0}", r2.Altura);
Console.WriteLine("Área: {0}", r2.Area);
Console.WriteLine("Perímetro: {0}", r2.Perimetro);