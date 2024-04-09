string Country = null;
string strCountry = Enum.GetName(enumType: typeof(Country), value: 20);
strCountry ??= "Unknown";
Console.WriteLine(strCountry); // Unknown