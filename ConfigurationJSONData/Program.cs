using System;

namespace ConfigurationJSONData
{
    class Program
    {
        static void Main(string[] args)
        {
            ConfigurationHelper configurationHelper = new ConfigurationHelper();

            #region Read Dictionary Begin
            var dictionaryCollection = configurationHelper.DictionaryCollection;
            Console.WriteLine("Dictionary collection:");
            foreach (var item in dictionaryCollection)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
            Console.WriteLine();
            #endregion Read Dictionary End

            #region Read User Begin
            var user = configurationHelper.User;
            Console.WriteLine("User information:");
            Console.WriteLine("Name : " + user.FirstName + ". Surname : " + user.LastName);
            Console.WriteLine("Address : " + user.Address.Country + ", " + user.Address.Capital);

            Console.WriteLine("Read user adress without user object. Address :" + configurationHelper.UserAddress.Country + ", " + configurationHelper.UserAddress.Capital);
            Console.WriteLine();

            #endregion Read User End

            #region Read Countries Begin
            var countries = configurationHelper.Countries;
            Console.WriteLine("Countries:");
            foreach (var country in countries)
                Console.WriteLine(country.Country + ", " + country.Capital);
            Console.WriteLine();
            #endregion Read Countries End

            Console.WriteLine("Application information:");
            Console.WriteLine("Application version is " + configurationHelper.Version);
            Console.WriteLine("Release date is " + configurationHelper.ReleaseDate);

            Console.ReadLine();
        }
    }
}
