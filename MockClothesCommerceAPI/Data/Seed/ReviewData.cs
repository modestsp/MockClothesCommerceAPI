
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MockClothesCommerceAPI.Data;
using MockClothesCommerceAPI.Models;

namespace MockClothesCommerceAPI.Data.Seed;
public static class ReviewSeed
{
  public static void Initialize(WebApplication app)
  {
    var scope = app.Services.CreateScope();
    var context = scope.ServiceProvider.GetService<DataContext>();

    context.Database.EnsureCreated();
    if (!context.Reviews.Any())
    {
      context.Reviews.Add(new Review
      {
        Id = 1,
        Content = "magnis dis parturient montes nascetur ridiculus mus etiam vel augue vestibulum rutrum rutrum neque",
        Rating = (decimal)4.9,
        UserId = 1,
        ProductId = 3,
        CreatedAt = DateTime.Parse("2022-12-13T12:50:25Z"),
        ModifiedAt = DateTime.Parse("2022-05-28T03:29:45Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 2,
        Content = "lacinia eget tincidunt eget tempus vel pede morbi porttitor lorem id ligula suspendisse ornare consequat lectus",
        Rating = (decimal)3.6,
        UserId = 12,
        ProductId = 22,
        CreatedAt = DateTime.Parse("2022-11-29T15:23:00Z"),
        ModifiedAt = DateTime.Parse("2023-01-16T20:05:51Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 3,
        Content = "leo odio porttitor id consequat in consequat ut nulla sed accumsan felis ut at dolor quis odio consequat varius integer",
        Rating = (decimal)2.2,
        UserId = 15,
        ProductId = 17,
        CreatedAt = DateTime.Parse("2023-01-13T10:51:57Z"),
        ModifiedAt = DateTime.Parse("2022-05-22T00:35:08Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 4,
        Content = "non interdum in ante vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae",
        Rating = (decimal)2.5,
        UserId = 24,
        ProductId = 45,
        CreatedAt = DateTime.Parse("2022-09-06T19:04:44Z"),
        ModifiedAt = DateTime.Parse("2022-08-26T10:42:48Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 5,
        Content = "vestibulum velit id pretium iaculis diam erat fermentum justo nec condimentum neque sapien",
        Rating = (decimal)2.1,
        UserId = 2,
        ProductId = 5,
        CreatedAt = DateTime.Parse("2022-05-27T13:03:52Z"),
        ModifiedAt = DateTime.Parse("2023-01-06T09:47:42Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 6,
        Content = "sapien a libero nam dui proin leo odio porttitor id consequat in consequat ut nulla",
        Rating = (decimal)1.8,
        UserId = 26,
        ProductId = 25,
        CreatedAt = DateTime.Parse("2022-05-17T00:57:08Z"),
        ModifiedAt = DateTime.Parse("2022-08-14T05:19:26Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 7,
        Content = "morbi vel lectus in quam fringilla rhoncus mauris enim leo rhoncus sed vestibulum sit",
        Rating = (decimal)3.0,
        UserId = 4,
        ProductId = 51,
        CreatedAt = DateTime.Parse("2022-09-23T10:11:20Z"),
        ModifiedAt = DateTime.Parse("2023-03-21T18:21:24Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 8,
        Content = "turpis a pede posuere nonummy integer non velit donec diam neque vestibulum",
        Rating = (decimal)2.3,
        UserId = 12,
        ProductId = 58,
        CreatedAt = DateTime.Parse("2022-06-22T23:47:51Z"),
        ModifiedAt = DateTime.Parse("2022-10-26T05:31:19Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 9,
        Content = "curae mauris viverra diam vitae quam suspendisse potenti nullam porttitor lacus at",
        Rating = (decimal)2.4,
        UserId = 7,
        ProductId = 48,
        CreatedAt = DateTime.Parse("2022-08-11T06:21:46Z"),
        ModifiedAt = DateTime.Parse("2022-12-24T10:56:17Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 10,
        Content = "eget orci vehicula condimentum curabitur in libero ut massa volutpat convallis morbi odio odio elementum eu interdum",
        Rating = (decimal)2.7,
        UserId = 26,
        ProductId = 26,
        CreatedAt = DateTime.Parse("2023-03-20T01:44:45Z"),
        ModifiedAt = DateTime.Parse("2023-03-22T08:08:49Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 11,
        Content = "semper interdum mauris ullamcorper purus sit amet nulla quisque arcu libero rutrum ac lobortis",
        Rating = (decimal)3.8,
        UserId = 4,
        ProductId = 8,
        CreatedAt = DateTime.Parse("2023-04-22T02:34:45Z"),
        ModifiedAt = DateTime.Parse("2022-05-09T01:17:01Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 12,
        Content = "lacinia aenean sit amet justo morbi ut odio cras mi pede malesuada in imperdiet et commodo",
        Rating = (decimal)2.5,
        UserId = 29,
        ProductId = 18,
        CreatedAt = DateTime.Parse("2022-06-27T01:00:22Z"),
        ModifiedAt = DateTime.Parse("2022-08-21T04:59:23Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 13,
        Content = "nisl aenean lectus pellentesque eget nunc donec quis orci eget",
        Rating = (decimal)0.7,
        UserId = 14,
        ProductId = 44,
        CreatedAt = DateTime.Parse("2023-03-12T03:52:58Z"),
        ModifiedAt = DateTime.Parse("2022-10-11T14:03:05Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 14,
        Content = "in lectus pellentesque at nulla suspendisse potenti cras in purus eu magna vulputate luctus cum sociis",
        Rating = (decimal)1.9,
        UserId = 10,
        ProductId = 7,
        CreatedAt = DateTime.Parse("2023-02-07T17:37:22Z"),
        ModifiedAt = DateTime.Parse("2022-05-29T17:09:28Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 15,
        Content = "vulputate elementum nullam varius nulla facilisi cras non velit nec nisi vulputate nonummy",
        Rating = (decimal)3.6,
        UserId = 10,
        ProductId = 36,
        CreatedAt = DateTime.Parse("2022-07-08T15:33:34Z"),
        ModifiedAt = DateTime.Parse("2022-10-01T13:56:19Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 16,
        Content = "donec semper sapien a libero nam dui proin leo odio porttitor id consequat in",
        Rating = (decimal)1.3,
        UserId = 9,
        ProductId = 42,
        CreatedAt = DateTime.Parse("2023-01-24T18:05:26Z"),
        ModifiedAt = DateTime.Parse("2023-04-04T16:25:40Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 17,
        Content = "magnis dis parturient montes nascetur ridiculus mus vivamus vestibulum sagittis sapien cum sociis",
        Rating = (decimal)1.9,
        UserId = 17,
        ProductId = 5,
        CreatedAt = DateTime.Parse("2022-07-22T01:21:10Z"),
        ModifiedAt = DateTime.Parse("2023-04-26T22:07:50Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 18,
        Content = "porttitor lorem id ligula suspendisse ornare consequat lectus in est risus auctor sed tristique in tempus sit amet",
        Rating = (decimal)2.8,
        UserId = 23,
        ProductId = 61,
        CreatedAt = DateTime.Parse("2023-02-16T22:10:58Z"),
        ModifiedAt = DateTime.Parse("2022-07-13T19:06:25Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 19,
        Content = "id consequat in consequat ut nulla sed accumsan felis ut at",
        Rating = (decimal)3.2,
        UserId = 6,
        ProductId = 19,
        CreatedAt = DateTime.Parse("2023-04-09T03:43:09Z"),
        ModifiedAt = DateTime.Parse("2022-11-09T12:11:08Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 20,
        Content = "diam id ornare imperdiet sapien urna pretium nisl ut volutpat sapien arcu sed augue aliquam erat volutpat in congue",
        Rating = (decimal)4.5,
        UserId = 12,
        ProductId = 58,
        CreatedAt = DateTime.Parse("2023-03-08T05:57:27Z"),
        ModifiedAt = DateTime.Parse("2022-05-11T01:42:01Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 21,
        Content = "primis in faucibus orci luctus et ultrices posuere cubilia curae duis faucibus accumsan odio curabitur",
        Rating = (decimal)4.5,
        UserId = 20,
        ProductId = 31,
        CreatedAt = DateTime.Parse("2023-03-31T21:01:16Z"),
        ModifiedAt = DateTime.Parse("2023-04-27T15:28:54Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 22,
        Content = "ante nulla justo aliquam quis turpis eget elit sodales scelerisque mauris sit amet eros suspendisse accumsan tortor quis",
        Rating = (decimal)3.2,
        UserId = 19,
        ProductId = 64,
        CreatedAt = DateTime.Parse("2023-01-24T00:14:26Z"),
        ModifiedAt = DateTime.Parse("2022-09-13T09:05:42Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 23,
        Content = "nonummy maecenas tincidunt lacus at velit vivamus vel nulla eget",
        Rating = (decimal)2.7,
        UserId = 10,
        ProductId = 42,
        CreatedAt = DateTime.Parse("2023-03-26T18:47:09Z"),
        ModifiedAt = DateTime.Parse("2022-09-30T01:36:32Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 24,
        Content = "faucibus orci luctus et ultrices posuere cubilia curae mauris viverra diam vitae quam suspendisse potenti nullam porttitor lacus",
        Rating = (decimal)4.4,
        UserId = 8,
        ProductId = 53,
        CreatedAt = DateTime.Parse("2022-05-05T04:48:51Z"),
        ModifiedAt = DateTime.Parse("2022-11-05T15:11:20Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 25,
        Content = "ac tellus semper interdum mauris ullamcorper purus sit amet nulla quisque arcu libero rutrum ac",
        Rating = (decimal)2.7,
        UserId = 11,
        ProductId = 49,
        CreatedAt = DateTime.Parse("2022-06-12T05:23:36Z"),
        ModifiedAt = DateTime.Parse("2023-04-20T16:15:38Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 26,
        Content = "tortor risus dapibus augue vel accumsan tellus nisi eu orci",
        Rating = (decimal)4.6,
        UserId = 2,
        ProductId = 6,
        CreatedAt = DateTime.Parse("2023-02-20T16:38:46Z"),
        ModifiedAt = DateTime.Parse("2022-11-11T21:03:19Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 27,
        Content = "hac habitasse platea dictumst morbi vestibulum velit id pretium iaculis diam erat fermentum justo",
        Rating = (decimal)0.9,
        UserId = 1,
        ProductId = 61,
        CreatedAt = DateTime.Parse("2022-11-28T12:39:04Z"),
        ModifiedAt = DateTime.Parse("2022-09-02T22:17:53Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 28,
        Content = "sit amet cursus id turpis integer aliquet massa id lobortis convallis tortor risus dapibus augue vel accumsan tellus nisi eu",
        Rating = (decimal)2.1,
        UserId = 22,
        ProductId = 8,
        CreatedAt = DateTime.Parse("2022-08-12T19:15:41Z"),
        ModifiedAt = DateTime.Parse("2022-06-09T02:57:37Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 29,
        Content = "quis lectus suspendisse potenti in eleifend quam a odio in hac habitasse",
        Rating = (decimal)0.1,
        UserId = 23,
        ProductId = 58,
        CreatedAt = DateTime.Parse("2023-03-01T08:25:14Z"),
        ModifiedAt = DateTime.Parse("2022-09-07T16:46:54Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 30,
        Content = "amet diam in magna bibendum imperdiet nullam orci pede venenatis non",
        Rating = (decimal)1.2,
        UserId = 14,
        ProductId = 11,
        CreatedAt = DateTime.Parse("2022-05-11T00:01:57Z"),
        ModifiedAt = DateTime.Parse("2022-06-13T23:02:24Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 31,
        Content = "in hac habitasse platea dictumst etiam faucibus cursus urna ut tellus",
        Rating = (decimal)2.9,
        UserId = 30,
        ProductId = 36,
        CreatedAt = DateTime.Parse("2022-12-04T21:40:06Z"),
        ModifiedAt = DateTime.Parse("2022-05-04T09:23:52Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 32,
        Content = "vitae consectetuer eget rutrum at lorem integer tincidunt ante vel ipsum",
        Rating = (decimal)3.2,
        UserId = 9,
        ProductId = 15,
        CreatedAt = DateTime.Parse("2022-10-30T13:12:53Z"),
        ModifiedAt = DateTime.Parse("2022-06-12T14:06:00Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 33,
        Content = "morbi odio odio elementum eu interdum eu tincidunt in leo maecenas pulvinar lobortis est",
        Rating = (decimal)4.0,
        UserId = 19,
        ProductId = 63,
        CreatedAt = DateTime.Parse("2023-01-23T13:04:09Z"),
        ModifiedAt = DateTime.Parse("2022-09-17T05:20:01Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 34,
        Content = "vel pede morbi porttitor lorem id ligula suspendisse ornare consequat lectus in est risus auctor sed tristique",
        Rating = (decimal)0.5,
        UserId = 2,
        ProductId = 39,
        CreatedAt = DateTime.Parse("2022-11-18T16:04:25Z"),
        ModifiedAt = DateTime.Parse("2022-08-14T22:05:16Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 35,
        Content = "montes nascetur ridiculus mus etiam vel augue vestibulum rutrum rutrum neque aenean",
        Rating = (decimal)4.2,
        UserId = 19,
        ProductId = 25,
        CreatedAt = DateTime.Parse("2023-02-13T08:04:50Z"),
        ModifiedAt = DateTime.Parse("2022-11-09T19:01:03Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 36,
        Content = "vestibulum sed magna at nunc commodo placerat praesent blandit nam nulla integer",
        Rating = (decimal)1.3,
        UserId = 25,
        ProductId = 2,
        CreatedAt = DateTime.Parse("2022-05-16T02:45:53Z"),
        ModifiedAt = DateTime.Parse("2022-11-12T10:28:22Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 37,
        Content = "vivamus vel nulla eget eros elementum pellentesque quisque porta volutpat erat",
        Rating = (decimal)3.7,
        UserId = 27,
        ProductId = 6,
        CreatedAt = DateTime.Parse("2022-11-11T17:01:00Z"),
        ModifiedAt = DateTime.Parse("2022-08-06T18:40:04Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 38,
        Content = "dolor quis odio consequat varius integer ac leo pellentesque ultrices mattis odio donec vitae nisi nam",
        Rating = (decimal)3.6,
        UserId = 2,
        ProductId = 31,
        CreatedAt = DateTime.Parse("2022-11-26T18:55:15Z"),
        ModifiedAt = DateTime.Parse("2022-06-22T05:42:51Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 39,
        Content = "augue vestibulum rutrum rutrum neque aenean auctor gravida sem praesent id massa id",
        Rating = (decimal)2.9,
        UserId = 24,
        ProductId = 43,
        CreatedAt = DateTime.Parse("2022-08-29T00:46:16Z"),
        ModifiedAt = DateTime.Parse("2022-08-26T10:08:20Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 40,
        Content = "ligula vehicula consequat morbi a ipsum integer a nibh in quis",
        Rating = (decimal)3.4,
        UserId = 9,
        ProductId = 27,
        CreatedAt = DateTime.Parse("2022-07-05T21:55:19Z"),
        ModifiedAt = DateTime.Parse("2022-09-12T08:01:12Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 41,
        Content = "justo pellentesque viverra pede ac diam cras pellentesque volutpat dui maecenas",
        Rating = (decimal)3.2,
        UserId = 27,
        ProductId = 29,
        CreatedAt = DateTime.Parse("2023-03-23T09:03:07Z"),
        ModifiedAt = DateTime.Parse("2022-07-29T12:43:21Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 42,
        Content = "ante vel ipsum praesent blandit lacinia erat vestibulum sed magna",
        Rating = (decimal)3.5,
        UserId = 21,
        ProductId = 18,
        CreatedAt = DateTime.Parse("2023-04-17T12:15:08Z"),
        ModifiedAt = DateTime.Parse("2022-06-09T21:25:48Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 43,
        Content = "lacinia aenean sit amet justo morbi ut odio cras mi pede malesuada in imperdiet et commodo vulputate justo in blandit",
        Rating = (decimal)3.9,
        UserId = 29,
        ProductId = 4,
        CreatedAt = DateTime.Parse("2022-09-13T08:01:18Z"),
        ModifiedAt = DateTime.Parse("2022-12-06T06:50:42Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 44,
        Content = "cras mi pede malesuada in imperdiet et commodo vulputate justo in",
        Rating = (decimal)3.8,
        UserId = 6,
        ProductId = 35,
        CreatedAt = DateTime.Parse("2023-02-11T07:55:23Z"),
        ModifiedAt = DateTime.Parse("2023-02-25T13:39:54Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 45,
        Content = "aliquam non mauris morbi non lectus aliquam sit amet diam",
        Rating = (decimal)2.3,
        UserId = 27,
        ProductId = 8,
        CreatedAt = DateTime.Parse("2022-05-13T10:58:48Z"),
        ModifiedAt = DateTime.Parse("2022-06-12T05:44:10Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 46,
        Content = "tellus semper interdum mauris ullamcorper purus sit amet nulla quisque arcu libero rutrum ac lobortis vel dapibus at",
        Rating = (decimal)2.5,
        UserId = 23,
        ProductId = 8,
        CreatedAt = DateTime.Parse("2022-11-13T08:59:28Z"),
        ModifiedAt = DateTime.Parse("2022-05-15T16:28:41Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 47,
        Content = "ac est lacinia nisi venenatis tristique fusce congue diam id ornare imperdiet sapien urna pretium",
        Rating = (decimal)3.9,
        UserId = 11,
        ProductId = 37,
        CreatedAt = DateTime.Parse("2023-01-04T04:10:20Z"),
        ModifiedAt = DateTime.Parse("2022-07-30T01:55:28Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 48,
        Content = "amet consectetuer adipiscing elit proin interdum mauris non ligula pellentesque ultrices phasellus id sapien in sapien iaculis congue",
        Rating = (decimal)2.6,
        UserId = 18,
        ProductId = 36,
        CreatedAt = DateTime.Parse("2023-02-04T20:30:53Z"),
        ModifiedAt = DateTime.Parse("2023-02-18T05:03:00Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 49,
        Content = "libero convallis eget eleifend luctus ultricies eu nibh quisque id justo sit amet sapien dignissim vestibulum vestibulum ante ipsum primis",
        Rating = (decimal)4.6,
        UserId = 4,
        ProductId = 60,
        CreatedAt = DateTime.Parse("2023-03-29T23:31:29Z"),
        ModifiedAt = DateTime.Parse("2022-12-23T18:02:28Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 50,
        Content = "posuere nonummy integer non velit donec diam neque vestibulum eget vulputate ut ultrices",
        Rating = (decimal)1.2,
        UserId = 4,
        ProductId = 27,
        CreatedAt = DateTime.Parse("2022-10-07T16:16:10Z"),
        ModifiedAt = DateTime.Parse("2022-09-05T16:12:53Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 51,
        Content = "orci luctus et ultrices posuere cubilia curae donec pharetra magna vestibulum aliquet ultrices erat tortor",
        Rating = (decimal)0.3,
        UserId = 16,
        ProductId = 52,
        CreatedAt = DateTime.Parse("2022-05-18T10:21:08Z"),
        ModifiedAt = DateTime.Parse("2022-08-23T23:31:10Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 52,
        Content = "lacus at velit vivamus vel nulla eget eros elementum pellentesque quisque",
        Rating = (decimal)0.0,
        UserId = 20,
        ProductId = 55,
        CreatedAt = DateTime.Parse("2022-10-14T13:07:28Z"),
        ModifiedAt = DateTime.Parse("2023-03-28T15:19:07Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 53,
        Content = "pulvinar nulla pede ullamcorper augue a suscipit nulla elit ac nulla sed vel enim sit amet nunc viverra dapibus",
        Rating = (decimal)2.9,
        UserId = 30,
        ProductId = 50,
        CreatedAt = DateTime.Parse("2022-11-21T18:20:35Z"),
        ModifiedAt = DateTime.Parse("2022-12-30T03:16:42Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 54,
        Content = "nec dui luctus rutrum nulla tellus in sagittis dui vel nisl duis ac nibh",
        Rating = (decimal)4.8,
        UserId = 24,
        ProductId = 52,
        CreatedAt = DateTime.Parse("2023-02-05T12:46:21Z"),
        ModifiedAt = DateTime.Parse("2022-09-02T20:04:44Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 55,
        Content = "consectetuer adipiscing elit proin interdum mauris non ligula pellentesque ultrices phasellus id sapien in sapien iaculis congue vivamus metus",
        Rating = (decimal)5.0,
        UserId = 4,
        ProductId = 2,
        CreatedAt = DateTime.Parse("2022-12-06T15:13:11Z"),
        ModifiedAt = DateTime.Parse("2022-10-14T11:35:40Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 56,
        Content = "vel augue vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae donec pharetra magna vestibulum aliquet",
        Rating = (decimal)0.1,
        UserId = 9,
        ProductId = 29,
        CreatedAt = DateTime.Parse("2022-10-30T21:58:53Z"),
        ModifiedAt = DateTime.Parse("2022-07-30T20:58:33Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 57,
        Content = "mauris laoreet ut rhoncus aliquet pulvinar sed nisl nunc rhoncus dui vel sem sed sagittis",
        Rating = (decimal)3.7,
        UserId = 13,
        ProductId = 27,
        CreatedAt = DateTime.Parse("2022-11-17T22:28:47Z"),
        ModifiedAt = DateTime.Parse("2022-07-16T21:08:52Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 58,
        Content = "libero convallis eget eleifend luctus ultricies eu nibh quisque id justo sit amet sapien",
        Rating = (decimal)3.9,
        UserId = 18,
        ProductId = 36,
        CreatedAt = DateTime.Parse("2022-08-03T09:56:11Z"),
        ModifiedAt = DateTime.Parse("2022-07-13T11:23:20Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 59,
        Content = "in faucibus orci luctus et ultrices posuere cubilia curae nulla dapibus dolor vel est donec odio justo",
        Rating = (decimal)4.4,
        UserId = 3,
        ProductId = 10,
        CreatedAt = DateTime.Parse("2022-06-01T21:31:11Z"),
        ModifiedAt = DateTime.Parse("2022-06-17T10:19:31Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 60,
        Content = "quis augue luctus tincidunt nulla mollis molestie lorem quisque ut erat curabitur gravida nisi at nibh in hac habitasse",
        Rating = (decimal)2.7,
        UserId = 16,
        ProductId = 24,
        CreatedAt = DateTime.Parse("2022-05-02T09:07:27Z"),
        ModifiedAt = DateTime.Parse("2022-08-28T19:42:58Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 61,
        Content = "auctor sed tristique in tempus sit amet sem fusce consequat nulla nisl nunc nisl duis bibendum felis sed interdum venenatis",
        Rating = (decimal)0.7,
        UserId = 6,
        ProductId = 44,
        CreatedAt = DateTime.Parse("2022-07-13T20:19:08Z"),
        ModifiedAt = DateTime.Parse("2022-10-06T09:55:28Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 62,
        Content = "erat volutpat in congue etiam justo etiam pretium iaculis justo in",
        Rating = (decimal)2.7,
        UserId = 6,
        ProductId = 4,
        CreatedAt = DateTime.Parse("2022-12-23T14:34:49Z"),
        ModifiedAt = DateTime.Parse("2022-12-13T16:55:11Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 63,
        Content = "hac habitasse platea dictumst etiam faucibus cursus urna ut tellus nulla ut erat id",
        Rating = (decimal)4.8,
        UserId = 5,
        ProductId = 61,
        CreatedAt = DateTime.Parse("2022-05-16T03:23:37Z"),
        ModifiedAt = DateTime.Parse("2022-12-12T09:03:08Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 64,
        Content = "congue eget semper rutrum nulla nunc purus phasellus in felis donec",
        Rating = (decimal)3.5,
        UserId = 7,
        ProductId = 19,
        CreatedAt = DateTime.Parse("2022-09-16T15:30:35Z"),
        ModifiedAt = DateTime.Parse("2023-03-22T06:12:37Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 65,
        Content = "dapibus duis at velit eu est congue elementum in hac habitasse platea dictumst morbi vestibulum velit",
        Rating = (decimal)4.4,
        UserId = 18,
        ProductId = 16,
        CreatedAt = DateTime.Parse("2022-08-17T13:03:21Z"),
        ModifiedAt = DateTime.Parse("2023-03-17T03:53:39Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 66,
        Content = "tincidunt lacus at velit vivamus vel nulla eget eros elementum pellentesque quisque porta volutpat erat quisque erat",
        Rating = (decimal)4.1,
        UserId = 8,
        ProductId = 39,
        CreatedAt = DateTime.Parse("2022-09-16T02:24:02Z"),
        ModifiedAt = DateTime.Parse("2023-03-18T01:23:18Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 67,
        Content = "cursus urna ut tellus nulla ut erat id mauris vulputate elementum nullam varius nulla",
        Rating = (decimal)4.1,
        UserId = 24,
        ProductId = 43,
        CreatedAt = DateTime.Parse("2022-08-03T12:55:05Z"),
        ModifiedAt = DateTime.Parse("2022-11-05T03:29:41Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 68,
        Content = "ac leo pellentesque ultrices mattis odio donec vitae nisi nam ultrices libero non mattis",
        Rating = (decimal)3.1,
        UserId = 27,
        ProductId = 6,
        CreatedAt = DateTime.Parse("2023-01-17T10:20:31Z"),
        ModifiedAt = DateTime.Parse("2022-12-18T13:19:53Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 69,
        Content = "habitasse platea dictumst aliquam augue quam sollicitudin vitae consectetuer eget rutrum at lorem integer tincidunt ante vel ipsum praesent",
        Rating = (decimal)3.4,
        UserId = 11,
        ProductId = 10,
        CreatedAt = DateTime.Parse("2022-12-28T03:03:36Z"),
        ModifiedAt = DateTime.Parse("2022-09-24T14:00:28Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 70,
        Content = "imperdiet nullam orci pede venenatis non sodales sed tincidunt eu felis fusce posuere felis sed lacus morbi sem mauris",
        Rating = (decimal)2.6,
        UserId = 19,
        ProductId = 59,
        CreatedAt = DateTime.Parse("2022-10-11T15:09:58Z"),
        ModifiedAt = DateTime.Parse("2022-09-03T20:17:48Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 71,
        Content = "eget vulputate ut ultrices vel augue vestibulum ante ipsum primis in faucibus",
        Rating = (decimal)2.9,
        UserId = 9,
        ProductId = 60,
        CreatedAt = DateTime.Parse("2022-05-01T20:48:00Z"),
        ModifiedAt = DateTime.Parse("2022-11-13T18:02:16Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 72,
        Content = "lacus at turpis donec posuere metus vitae ipsum aliquam non mauris morbi",
        Rating = (decimal)0.2,
        UserId = 19,
        ProductId = 60,
        CreatedAt = DateTime.Parse("2022-06-07T20:24:16Z"),
        ModifiedAt = DateTime.Parse("2023-02-07T07:52:58Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 73,
        Content = "nisl nunc nisl duis bibendum felis sed interdum venenatis turpis enim blandit mi in porttitor",
        Rating = (decimal)2.1,
        UserId = 24,
        ProductId = 40,
        CreatedAt = DateTime.Parse("2022-10-08T12:43:26Z"),
        ModifiedAt = DateTime.Parse("2022-07-07T21:08:30Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 74,
        Content = "etiam vel augue vestibulum rutrum rutrum neque aenean auctor gravida sem praesent id",
        Rating = (decimal)0.3,
        UserId = 19,
        ProductId = 56,
        CreatedAt = DateTime.Parse("2022-08-22T01:06:20Z"),
        ModifiedAt = DateTime.Parse("2022-11-05T03:16:36Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 75,
        Content = "lacinia aenean sit amet justo morbi ut odio cras mi pede malesuada in imperdiet et commodo vulputate",
        Rating = (decimal)4.0,
        UserId = 5,
        ProductId = 25,
        CreatedAt = DateTime.Parse("2022-12-15T16:48:40Z"),
        ModifiedAt = DateTime.Parse("2022-07-20T00:59:45Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 76,
        Content = "faucibus cursus urna ut tellus nulla ut erat id mauris vulputate elementum nullam",
        Rating = (decimal)0.9,
        UserId = 18,
        ProductId = 27,
        CreatedAt = DateTime.Parse("2023-01-14T19:24:22Z"),
        ModifiedAt = DateTime.Parse("2023-03-09T18:18:18Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 77,
        Content = "tempor turpis nec euismod scelerisque quam turpis adipiscing lorem vitae mattis nibh ligula nec sem duis aliquam convallis nunc proin",
        Rating = (decimal)0.5,
        UserId = 23,
        ProductId = 39,
        CreatedAt = DateTime.Parse("2023-02-17T18:34:46Z"),
        ModifiedAt = DateTime.Parse("2023-02-28T02:17:10Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 78,
        Content = "imperdiet nullam orci pede venenatis non sodales sed tincidunt eu",
        Rating = (decimal)0.9,
        UserId = 2,
        ProductId = 39,
        CreatedAt = DateTime.Parse("2022-09-17T19:07:14Z"),
        ModifiedAt = DateTime.Parse("2022-10-07T17:05:03Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 79,
        Content = "odio condimentum id luctus nec molestie sed justo pellentesque viverra pede ac diam",
        Rating = (decimal)3.0,
        UserId = 5,
        ProductId = 2,
        CreatedAt = DateTime.Parse("2023-02-23T16:34:32Z"),
        ModifiedAt = DateTime.Parse("2022-11-02T06:07:10Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 80,
        Content = "at nunc commodo placerat praesent blandit nam nulla integer pede justo lacinia eget tincidunt eget tempus vel pede morbi porttitor",
        Rating = (decimal)1.5,
        UserId = 21,
        ProductId = 26,
        CreatedAt = DateTime.Parse("2023-02-25T19:19:14Z"),
        ModifiedAt = DateTime.Parse("2022-07-24T16:14:32Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 81,
        Content = "turpis sed ante vivamus tortor duis mattis egestas metus aenean fermentum donec",
        Rating = (decimal)4.5,
        UserId = 15,
        ProductId = 10,
        CreatedAt = DateTime.Parse("2022-05-13T17:26:18Z"),
        ModifiedAt = DateTime.Parse("2022-08-20T04:25:20Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 82,
        Content = "ut dolor morbi vel lectus in quam fringilla rhoncus mauris",
        Rating = (decimal)1.7,
        UserId = 23,
        ProductId = 58,
        CreatedAt = DateTime.Parse("2022-11-07T22:40:41Z"),
        ModifiedAt = DateTime.Parse("2023-03-26T05:21:39Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 83,
        Content = "iaculis congue vivamus metus arcu adipiscing molestie hendrerit at vulputate vitae nisl aenean lectus pellentesque eget nunc",
        Rating = (decimal)1.5,
        UserId = 30,
        ProductId = 3,
        CreatedAt = DateTime.Parse("2023-03-02T14:42:00Z"),
        ModifiedAt = DateTime.Parse("2022-11-21T11:42:13Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 84,
        Content = "pulvinar lobortis est phasellus sit amet erat nulla tempus vivamus in felis eu",
        Rating = (decimal)3.0,
        UserId = 1,
        ProductId = 46,
        CreatedAt = DateTime.Parse("2022-05-17T18:47:23Z"),
        ModifiedAt = DateTime.Parse("2022-09-11T06:33:52Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 85,
        Content = "libero quis orci nullam molestie nibh in lectus pellentesque at nulla suspendisse potenti cras in purus eu magna vulputate luctus",
        Rating = (decimal)4.0,
        UserId = 15,
        ProductId = 40,
        CreatedAt = DateTime.Parse("2022-06-16T09:53:55Z"),
        ModifiedAt = DateTime.Parse("2023-02-18T19:53:31Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 86,
        Content = "eget semper rutrum nulla nunc purus phasellus in felis donec semper",
        Rating = (decimal)1.6,
        UserId = 16,
        ProductId = 39,
        CreatedAt = DateTime.Parse("2022-08-19T21:17:56Z"),
        ModifiedAt = DateTime.Parse("2022-07-05T04:25:57Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 87,
        Content = "enim lorem ipsum dolor sit amet consectetuer adipiscing elit proin interdum mauris non ligula pellentesque ultrices",
        Rating = (decimal)4.8,
        UserId = 17,
        ProductId = 1,
        CreatedAt = DateTime.Parse("2022-05-03T01:52:55Z"),
        ModifiedAt = DateTime.Parse("2022-11-07T15:59:17Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 88,
        Content = "sem mauris laoreet ut rhoncus aliquet pulvinar sed nisl nunc rhoncus dui vel sem sed sagittis nam congue risus semper",
        Rating = (decimal)4.1,
        UserId = 4,
        ProductId = 30,
        CreatedAt = DateTime.Parse("2022-06-14T16:30:05Z"),
        ModifiedAt = DateTime.Parse("2022-07-20T20:04:36Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 89,
        Content = "ligula pellentesque ultrices phasellus id sapien in sapien iaculis congue vivamus metus",
        Rating = (decimal)4.2,
        UserId = 28,
        ProductId = 60,
        CreatedAt = DateTime.Parse("2023-01-03T07:48:52Z"),
        ModifiedAt = DateTime.Parse("2022-07-05T19:49:52Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 90,
        Content = "eros vestibulum ac est lacinia nisi venenatis tristique fusce congue diam id ornare imperdiet sapien urna pretium",
        Rating = (decimal)2.1,
        UserId = 3,
        ProductId = 62,
        CreatedAt = DateTime.Parse("2023-01-01T08:53:51Z"),
        ModifiedAt = DateTime.Parse("2023-01-10T11:24:34Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 91,
        Content = "eget vulputate ut ultrices vel augue vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae donec",
        Rating = (decimal)0.8,
        UserId = 23,
        ProductId = 14,
        CreatedAt = DateTime.Parse("2023-04-11T00:17:39Z"),
        ModifiedAt = DateTime.Parse("2022-09-21T06:54:23Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 92,
        Content = "non mauris morbi non lectus aliquam sit amet diam in magna bibendum imperdiet nullam orci",
        Rating = (decimal)1.6,
        UserId = 20,
        ProductId = 12,
        CreatedAt = DateTime.Parse("2023-02-11T22:15:56Z"),
        ModifiedAt = DateTime.Parse("2023-02-16T02:03:26Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 93,
        Content = "phasellus in felis donec semper sapien a libero nam dui proin",
        Rating = (decimal)2.1,
        UserId = 20,
        ProductId = 29,
        CreatedAt = DateTime.Parse("2023-03-19T17:11:47Z"),
        ModifiedAt = DateTime.Parse("2022-12-18T06:42:16Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 94,
        Content = "vehicula consequat morbi a ipsum integer a nibh in quis justo maecenas rhoncus aliquam lacus morbi quis tortor id",
        Rating = (decimal)2.2,
        UserId = 19,
        ProductId = 35,
        CreatedAt = DateTime.Parse("2022-05-16T10:41:46Z"),
        ModifiedAt = DateTime.Parse("2023-03-26T07:01:24Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 95,
        Content = "sit amet sapien dignissim vestibulum vestibulum ante ipsum primis in faucibus orci luctus",
        Rating = (decimal)0.2,
        UserId = 12,
        ProductId = 50,
        CreatedAt = DateTime.Parse("2022-11-08T13:52:10Z"),
        ModifiedAt = DateTime.Parse("2022-07-21T07:32:54Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 96,
        Content = "placerat ante nulla justo aliquam quis turpis eget elit sodales scelerisque",
        Rating = (decimal)1.1,
        UserId = 4,
        ProductId = 11,
        CreatedAt = DateTime.Parse("2023-04-12T00:19:13Z"),
        ModifiedAt = DateTime.Parse("2022-07-27T16:49:26Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 97,
        Content = "tortor risus dapibus augue vel accumsan tellus nisi eu orci mauris lacinia sapien quis libero",
        Rating = (decimal)3.5,
        UserId = 14,
        ProductId = 48,
        CreatedAt = DateTime.Parse("2022-11-29T10:19:52Z"),
        ModifiedAt = DateTime.Parse("2022-12-17T02:06:00Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 98,
        Content = "habitasse platea dictumst morbi vestibulum velit id pretium iaculis diam erat fermentum justo nec",
        Rating = (decimal)2.6,
        UserId = 8,
        ProductId = 58,
        CreatedAt = DateTime.Parse("2022-07-28T02:49:52Z"),
        ModifiedAt = DateTime.Parse("2022-06-01T11:43:52Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 99,
        Content = "habitasse platea dictumst morbi vestibulum velit id pretium iaculis diam erat",
        Rating = (decimal)4.4,
        UserId = 18,
        ProductId = 61,
        CreatedAt = DateTime.Parse("2022-05-28T11:31:38Z"),
        ModifiedAt = DateTime.Parse("2023-03-18T06:50:26Z")
      });
      context.Reviews.Add(new Review
      {
        Id = 100,
        Content = "id mauris vulputate elementum nullam varius nulla facilisi cras non velit nec nisi vulputate nonummy maecenas tincidunt lacus at",
        Rating = (decimal)4.3,
        UserId = 20,
        ProductId = 46,
        CreatedAt = DateTime.Parse("2022-05-27T01:42:23Z"),
        ModifiedAt = DateTime.Parse("2022-08-15T11:48:21Z")
      });
      context.SaveChanges();
    }
  }
}
