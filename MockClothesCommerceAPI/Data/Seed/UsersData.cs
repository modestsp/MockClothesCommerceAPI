using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MockClothesCommerceAPI.Data;
using MockClothesCommerceAPI.Models;

namespace MockClothesCommerceAPI.Data.Seed;
public static class UserSeed
{
  public static void Initialize(WebApplication app)
  {
    var scope = app.Services.CreateScope();
    var context = scope.ServiceProvider.GetService<DataContext>();

    context.Database.EnsureCreated();
    if (!context.Users.Any())
    {
      context.Users.Add(new User
      {
        Id = 1,
        Username = "mflade0",
        Name = "Maison",
        Email = "mcuttings0@stanford.edu",
        Password = "TNfcxywIOiA0",
        CreatedAt = DateTime.Parse("2022-10-10T22:53:13Z"),
        ModifiedAt = DateTime.Parse("2022-09-19T16:16:28Z")
      });
      context.Users.Add(new User
      {
        Id = 2,
        Username = "fbartleet1",
        Name = "Felix",
        Email = "fgann1@intel.com",
        Password = "bW3GDVm",
        CreatedAt = DateTime.Parse("2023-02-09T02:19:02Z"),
        ModifiedAt = DateTime.Parse("2022-09-13T17:36:59Z")
      });
      context.Users.Add(new User
      {
        Id = 3,
        Username = "dmaclure2",
        Name = "Daffy",
        Email = "dhadland2@google.nl",
        Password = "Ls0wtD",
        CreatedAt = DateTime.Parse("2023-02-16T20:15:15Z"),
        ModifiedAt = DateTime.Parse("2023-04-17T16:02:25Z")
      });
      context.Users.Add(new User
      {
        Id = 4,
        Username = "ekilleley3",
        Name = "Emmott",
        Email = "elaughton3@i2i.jp",
        Password = "YkFRu1I",
        CreatedAt = DateTime.Parse("2022-09-21T21:25:07Z"),
        ModifiedAt = DateTime.Parse("2022-10-14T14:58:44Z")
      });
      context.Users.Add(new User
      {
        Id = 5,
        Username = "csewill4",
        Name = "Clo",
        Email = "cginnane4@xrea.com",
        Password = "c7QVL3dN",
        CreatedAt = DateTime.Parse("2022-10-06T03:36:16Z"),
        ModifiedAt = DateTime.Parse("2023-04-07T22:35:27Z")
      });
      context.Users.Add(new User
      {
        Id = 6,
        Username = "agranleese5",
        Name = "Anna-diane",
        Email = "ayarr5@cdbaby.com",
        Password = "B0Z0k3KGarL",
        CreatedAt = DateTime.Parse("2023-04-18T17:08:36Z"),
        ModifiedAt = DateTime.Parse("2023-02-06T11:56:15Z")
      });
      context.Users.Add(new User
      {
        Id = 7,
        Username = "mzahor6",
        Name = "Monika",
        Email = "mheaney6@acquirethisname.com",
        Password = "BfHrjiU6a",
        CreatedAt = DateTime.Parse("2023-03-22T09:24:30Z"),
        ModifiedAt = DateTime.Parse("2022-12-13T02:55:11Z")
      });
      context.Users.Add(new User
      {
        Id = 8,
        Username = "celph7",
        Name = "Corbett",
        Email = "cgrestie7@eepurl.com",
        Password = "QwP2VMPHFllP",
        CreatedAt = DateTime.Parse("2022-07-30T01:09:54Z"),
        ModifiedAt = DateTime.Parse("2022-12-30T17:33:59Z")
      });
      context.Users.Add(new User
      {
        Id = 9,
        Username = "dcarloni8",
        Name = "Denney",
        Email = "dkeiley8@soup.io",
        Password = "1bxLuT",
        CreatedAt = DateTime.Parse("2022-09-13T23:26:26Z"),
        ModifiedAt = DateTime.Parse("2023-02-07T16:53:56Z")
      });
      context.Users.Add(new User
      {
        Id = 10,
        Username = "acolloff9",
        Name = "Aldis",
        Email = "amatthieson9@edublogs.org",
        Password = "2vwtAGrxgB",
        CreatedAt = DateTime.Parse("2022-06-22T23:51:20Z"),
        ModifiedAt = DateTime.Parse("2023-04-11T19:05:34Z")
      });
      context.Users.Add(new User
      {
        Id = 11,
        Username = "tmariettea",
        Name = "Talbert",
        Email = "tshanda@mozilla.org",
        Password = "WUB1IIA5n7lK",
        CreatedAt = DateTime.Parse("2023-03-26T06:47:49Z"),
        ModifiedAt = DateTime.Parse("2022-06-02T18:27:58Z")
      });
      context.Users.Add(new User
      {
        Id = 12,
        Username = "cjoreaub",
        Name = "Chadd",
        Email = "cdenerleyb@yandex.ru",
        Password = "Kmh7Dc1",
        CreatedAt = DateTime.Parse("2022-10-21T09:39:47Z"),
        ModifiedAt = DateTime.Parse("2022-07-13T00:19:16Z")
      });
      context.Users.Add(new User
      {
        Id = 13,
        Username = "ahovyc",
        Name = "Ashleigh",
        Email = "ademangelc@merriam-webster.com",
        Password = "aLUyU49jJJy",
        CreatedAt = DateTime.Parse("2023-04-25T14:32:10Z"),
        ModifiedAt = DateTime.Parse("2022-10-13T17:22:49Z")
      });
      context.Users.Add(new User
      {
        Id = 14,
        Username = "wmarklundd",
        Name = "Warde",
        Email = "wcookmand@microsoft.com",
        Password = "NwXhtxhguJ",
        CreatedAt = DateTime.Parse("2022-06-06T16:30:09Z"),
        ModifiedAt = DateTime.Parse("2022-09-27T18:16:50Z")
      });
      context.Users.Add(new User
      {
        Id = 15,
        Username = "abanaszczyke",
        Name = "Arlyne",
        Email = "athomse@wikimedia.org",
        Password = "UlWNTmQ",
        CreatedAt = DateTime.Parse("2022-11-08T01:27:36Z"),
        ModifiedAt = DateTime.Parse("2022-10-18T20:18:20Z")
      });
      context.Users.Add(new User
      {
        Id = 16,
        Username = "bschofieldf",
        Name = "Ban",
        Email = "bhefferanf@w3.org",
        Password = "EPhEDB",
        CreatedAt = DateTime.Parse("2022-11-18T01:07:57Z"),
        ModifiedAt = DateTime.Parse("2022-11-29T12:43:33Z")
      });
      context.Users.Add(new User
      {
        Id = 17,
        Username = "rwollastong",
        Name = "Rand",
        Email = "rvindeng@studiopress.com",
        Password = "UvzcN2khorU",
        CreatedAt = DateTime.Parse("2023-02-02T10:25:48Z"),
        ModifiedAt = DateTime.Parse("2022-07-19T12:28:40Z")
      });
      context.Users.Add(new User
      {
        Id = 18,
        Username = "jallflatth",
        Name = "Jedidiah",
        Email = "jlaith@dmoz.org",
        Password = "6v3Llc7BKH",
        CreatedAt = DateTime.Parse("2022-12-10T07:28:51Z"),
        ModifiedAt = DateTime.Parse("2022-11-15T13:37:37Z")
      });
      context.Users.Add(new User
      {
        Id = 19,
        Username = "cmeritti",
        Name = "Clarence",
        Email = "cgirardyi@hatena.ne.jp",
        Password = "PsKPF69bXM",
        CreatedAt = DateTime.Parse("2022-11-08T07:09:58Z"),
        ModifiedAt = DateTime.Parse("2022-12-26T05:42:09Z")
      });
      context.Users.Add(new User
      {
        Id = 20,
        Username = "lgunthorpej",
        Name = "Liesa",
        Email = "lbarhemj@mlb.com",
        Password = "0A780BTewrS8",
        CreatedAt = DateTime.Parse("2022-08-13T16:50:39Z"),
        ModifiedAt = DateTime.Parse("2022-12-17T19:20:34Z")
      });
      context.Users.Add(new User
      {
        Id = 21,
        Username = "mredrupk",
        Name = "Mia",
        Email = "mlupartok@4shared.com",
        Password = "0P44x14b",
        CreatedAt = DateTime.Parse("2023-02-09T12:51:11Z"),
        ModifiedAt = DateTime.Parse("2023-01-02T18:47:33Z")
      });
      context.Users.Add(new User
      {
        Id = 22,
        Username = "tharberl",
        Name = "Trixie",
        Email = "tgabbidonl@instagram.com",
        Password = "hIb5Czgdt",
        CreatedAt = DateTime.Parse("2022-10-14T23:02:53Z"),
        ModifiedAt = DateTime.Parse("2022-08-08T03:24:25Z")
      });
      context.Users.Add(new User
      {
        Id = 23,
        Username = "mstrassm",
        Name = "Matthieu",
        Email = "mbeachm@jimdo.com",
        Password = "pvqwXSheI",
        CreatedAt = DateTime.Parse("2022-10-17T18:07:15Z"),
        ModifiedAt = DateTime.Parse("2023-03-21T04:08:29Z")
      });
      context.Users.Add(new User
      {
        Id = 24,
        Username = "mchessern",
        Name = "Marget",
        Email = "mthrusselln@wufoo.com",
        Password = "Fgns5grZe",
        CreatedAt = DateTime.Parse("2022-06-10T17:57:10Z"),
        ModifiedAt = DateTime.Parse("2022-08-21T22:54:02Z")
      });
      context.Users.Add(new User
      {
        Id = 25,
        Username = "vquigleyo",
        Name = "Vannie",
        Email = "vstoiteo@list-manage.com",
        Password = "RnQfCWfzYq",
        CreatedAt = DateTime.Parse("2023-03-30T03:32:06Z"),
        ModifiedAt = DateTime.Parse("2022-12-16T16:41:17Z")
      });
      context.Users.Add(new User
      {
        Id = 26,
        Username = "mnevep",
        Name = "Maxie",
        Email = "mhadwenp@theatlantic.com",
        Password = "p7G9JI1udQBc",
        CreatedAt = DateTime.Parse("2022-12-16T08:14:13Z"),
        ModifiedAt = DateTime.Parse("2023-03-05T20:59:29Z")
      });
      context.Users.Add(new User
      {
        Id = 27,
        Username = "beickq",
        Name = "Bo",
        Email = "blawleffq@yale.edu",
        Password = "0WqCpUxX",
        CreatedAt = DateTime.Parse("2022-10-01T15:10:52Z"),
        ModifiedAt = DateTime.Parse("2022-07-29T13:02:37Z")
      });
      context.Users.Add(new User
      {
        Id = 28,
        Username = "sfalknerr",
        Name = "Sonni",
        Email = "ssomerbellr@nydailynews.com",
        Password = "XxicwCaKqd",
        CreatedAt = DateTime.Parse("2022-06-15T19:29:13Z"),
        ModifiedAt = DateTime.Parse("2022-12-05T16:47:45Z")
      });
      context.Users.Add(new User
      {
        Id = 29,
        Username = "nmcleeses",
        Name = "Nada",
        Email = "nmorls@narod.ru",
        Password = "VTgLGxb",
        CreatedAt = DateTime.Parse("2022-10-31T05:53:51Z"),
        ModifiedAt = DateTime.Parse("2022-07-10T21:56:18Z")
      });
      context.Users.Add(new User
      {
        Id = 30,
        Username = "rjohantgest",
        Name = "Ronni",
        Email = "rhailst@biblegateway.com",
        Password = "ylzDNEFDKE",
        CreatedAt = DateTime.Parse("2022-10-11T04:49:38Z"),
        ModifiedAt = DateTime.Parse("2022-12-13T08:48:13Z")
      });
      context.SaveChanges();
    }
  }
}