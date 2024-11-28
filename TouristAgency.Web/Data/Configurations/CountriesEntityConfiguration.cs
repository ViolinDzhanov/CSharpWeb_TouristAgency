using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TouristAgency.Data.Models.Models;

namespace TouristAgency.Web.Data.Configurations
{
    public class CountriesEntityConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            ICollection<Country> countries = CreateCoutries();
        }

        private ICollection<Country> CreateCoutries()
        {
            List<Country> countries = new List<Country>()
            {
                new Country()
                {
                    Name = "Bulgaria",
                    Towns = new List<Town>()
                    {
                        new Town()
                        {
                            Name = "Sofia",
                            Addresses = new List<Address>()
                            {
                                new Address()
                                {
                                StreetName = "Vitosha",
                                StreetNumber = 1
                                },

                                new Address()
                                {
                                    StreetName = "Rakovski Street",
                                    StreetNumber = 49
                                },

                                new Address()
                                {
                                    StreetName = "Tsarigradsko shose",
                                    StreetNumber = 67
                                }
                            }
                        },

                        new Town()
                        {
                            Name = "Plovdiv",
                            Addresses = new List<Address>()
                            {
                                new Address()
                                {
                                    StreetName = "Vasil Aprilov",
                                    StreetNumber = 123
                                },
                                new Address()
                                {
                                    StreetName = "Knyaz Alexander I",
                                    StreetNumber = 325
                                },
                                new Address()
                                {
                                    StreetName = "Vasil Levski",
                                    StreetNumber = 10
                                }
                            }
                        },

                        new Town()
                        {
                            Name = "Varna",
                            Addresses = new List<Address>()
                            {
                                new Address()
                                {
                                    StreetName = "Vladislav Varnenchik",
                                    StreetNumber = 33
                                },
                                new Address()
                                {
                                    StreetName = "Tsar Osvoboditel",
                                    StreetNumber = 1
                                },
                                new Address()
                                {
                                    StreetName = "Slivnitsa",
                                    StreetNumber = 12
                                }
                            }
                        }
                    }
                },

                new Country()
                {
                    Name = "Greece",
                    Towns = new List<Town>()
                    {
                        new Town()
                        {
                            Name = "Athens",
                            Addresses = new List<Address>()
                            {
                                new Address()
                                {
                                    StreetName = "Syntagma Square",
                                    StreetNumber = 1
                                },
                                new Address()
                                {
                                    StreetName = "Omonia Square",
                                    StreetNumber = 2
                                },
                                new Address()
                                {
                                    StreetName = "Monastiraki",
                                    StreetNumber = 3
                                }
                            }
                        },
                        new Town()
                        {
                            Name = "Thessaloniki",
                            Addresses = new List<Address>()
                            {
                                new Address()
                                {
                                    StreetName = "Aristotelous Square",
                                    StreetNumber = 1
                                },
                                new Address()
                                {
                                    StreetName = "Tsimiski",
                                    StreetNumber = 2
                                },
                                new Address()
                                {
                                    StreetName = "Egnatia",
                                    StreetNumber = 3
                                }
                            }
                        },
                        new Town()
                        {
                            Name = "Patras",
                            Addresses = new List<Address>()
                            {
                                new Address()
                                {
                                    StreetName = "Riga Feraiou",
                                    StreetNumber = 1
                                },
                                new Address()
                                {
                                    StreetName = "Agias Sofias",
                                    StreetNumber = 2
                                },
                                new Address()
                                {
                                    StreetName = "Korinthou",
                                    StreetNumber = 3
                                }
                            }
                        }
                    }
                },

                new Country()
                {
                    Name = "Italy",
                    Towns = new List<Town>()
                    {
                        new Town()
                        {
                            Name = "Rome",
                            Addresses = new List<Address>()
                            {
                                new Address()
                                {
                                    StreetName = "Via del Corso",
                                    StreetNumber = 1
                                },
                                new Address()
                                {
                                    StreetName = "Via dei Fori Imperiali",
                                    StreetNumber = 2
                                },
                                new Address()
                                {
                                    StreetName = "Via Veneto",
                                    StreetNumber = 3
                                }
                            }
                        },
                        new Town()
                        {
                            Name = "Milan",
                            Addresses = new List<Address>()
                            {
                                new Address()
                                {
                                    StreetName = "Via Montenapoleone",
                                    StreetNumber = 1
                                },
                                new Address()
                                {
                                    StreetName = "Corso Buenos Aires",
                                    StreetNumber = 2
                                },
                                new Address()
                                {
                                    StreetName = "Via della Spiga",
                                    StreetNumber = 3
                                }
                            }
                        },
                        new Town()
                        {
                            Name = "Venice",
                            Addresses = new List<Address>()
                            {
                                new Address()
                                {
                                    StreetName = "Piazza San Marco",
                                    StreetNumber = 1
                                },
                                new Address()
                                {
                                    StreetName = "Rialto Bridge",
                                    StreetNumber = 2
                                },
                                new Address()
                                {
                                    StreetName = "Grand Canal",
                                    StreetNumber = 3
                                }
                            }
                        }
                    }
                }
            };

            return countries;
        }
    }
}
