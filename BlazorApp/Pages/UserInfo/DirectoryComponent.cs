using BlazorApp.Models;

namespace BlazorApp.Pages.UserInfo
{
    public partial class DirectoryComponent
    {

        public List<PersonModel> People { get; set; }

        public DirectoryComponent()
        {
            People = new List<PersonModel>()
            {
                new PersonModel()
                {
                    FirstName = "Tim",
                    LastName = "Smith",
                    Adresses = new List<AddressModel> {
                    new AddressModel()
                    {
                        AddressType = "Home Address",
                        City = "LA",
                        ZipCode = "023314",
                        State = "CA",
                        StreetAddress = "123 Oak Street"
                    },
                    new AddressModel()
                    {
                        AddressType = "Vacation Home",
                        City = "Miami",
                        ZipCode = "935947",
                        State = "FL",
                        StreetAddress = "101 BeachFront Ave"
                    }}
                },
                new PersonModel()
                {
                    FirstName = "Sue",
                    LastName = "Storm",
                    Adresses= new List<AddressModel>
                    {
                        new AddressModel()
                        {
                           AddressType = "Home Address",
                        City = "Scranton",
                        ZipCode = "5765365",
                        State = "PA",
                        StreetAddress = "101 BeachFront Ave"
                        }
                    }
                },
                new PersonModel()
                {
                    FirstName = "Bob",
                    LastName = "Griffin",
                    Adresses= new List<AddressModel>{}
                }
            };
        }
    }
}
