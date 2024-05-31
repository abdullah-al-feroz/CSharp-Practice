Country country1 = new Country() { Code = "BAN", Name = "Bangladesh", Capital = "Dhaka" };
Country country2 = new Country() { Code = "NEW", Name = "Newzeland", Capital = "Abc" };
Country country3 = new Country() { Code = "AUS", Name = "Australia", Capital = "Melborne" };
Country country4 = new Country() { Code = "USA", Name = "America", Capital = "NewYork" };
Country country5 = new Country() { Code = "UAE", Name = "Dubai", Capital = "Dubai" };

//List<Country> listCountries = new List<Country>();
//listCountries.Add(country1);
//listCountries.Add(country2);
//listCountries.Add(country3);
//listCountries.Add(country4);
//listCountries.Add(country5);

//Dictionary
Dictionary<string, Country> dictionaryCountries = new Dictionary<string, Country>();
dictionaryCountries.Add(country1.Code, country1);
dictionaryCountries.Add(country2.Code, country2);
dictionaryCountries.Add(country3.Code, country3);
dictionaryCountries.Add(country4.Code, country4);
dictionaryCountries.Add(country5.Code, country5);
string strUserChoice= string.Empty;

//do
//{
//    Console.WriteLine("Please Enter Country Code");
//    string strCountryCode = Console.ReadLine().ToUpper();
    
//    Country resultCountry = listCountries.Find(country => country.Code == strCountryCode);
//    if (resultCountry == null)
//    {
//        Console.WriteLine("Country code not valid");
//    }
//    else
//    {
//        Console.WriteLine("Name = {0}, Capital = {1}", resultCountry.Name, resultCountry.Capital);
//    }
//    do
//    {
//        Console.WriteLine("Do you want to continue");
//        strUserChoice = Console.ReadLine().ToUpper();
//    }
//    while (strUserChoice != "No" && strUserChoice != "Yes");
//}
//while (strUserChoice == "Yes");

do
{
    Console.WriteLine("Please Enter Country Code");
    string strCountryCode = Console.ReadLine().ToUpper();

    Country resultCountry = dictionaryCountries.ContainsKey(strCountryCode) ? dictionaryCountries[strCountryCode] : null;
    if (resultCountry == null)
    {
        Console.WriteLine("Country code not valid");
    }
    else
    {
        Console.WriteLine("Name = {0}, Capital = {1}", resultCountry.Name, resultCountry.Capital);
    }
    do
    {
        Console.WriteLine("Do you want to continue - Yes or No");
        strUserChoice = Console.ReadLine().ToUpper();
    }
    while (strUserChoice != "NO" && strUserChoice != "YES");
}
while (strUserChoice == "Yes");


public class Country
{
    public string Name { get; set; }
    public string Code { get; set; }
    public string Capital { get; set; } 
}
