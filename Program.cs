using System.Globalization;

Console.Clear();

decimal valor = 10.25m;
Console.WriteLine(
    valor.ToString(
        "C",
        CultureInfo.CreateSpecificCulture("en-US")
        ));



Console.WriteLine(
    Math.Round(valor)
);
Console.WriteLine(
    Math.Ceiling(valor)
);
Console.WriteLine(
    Math.Floor(valor)
);