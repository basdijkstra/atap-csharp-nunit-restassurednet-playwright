using NUnit.Framework;
using static RestAssured.Dsl;

namespace ATAPNUnitRestAssuredNetPlaywright.ApiTests
{
    [TestFixture]
    public class ExampleApiTests
    {
        [Test]
        public void GetDataForUser1_CheckStatusCodeHeaderAndBody()
        {
            Given()
                .When()
                .Get("https://jsonplaceholder.typicode.com/users/1")
                .Then()
                .StatusCode(200)
                .ContentType("application/json; charset=utf-8")
                .Body("$.name", NHamcrest.Is.EqualTo("Leanne Graham"))
                .Body("$.company.bs", NHamcrest.Is.EqualTo("harness real-time e-markets"));
        }

        [Test]
        public void CreateNewPost_CheckStatusCode()
        {
            string post = """
                {
                    "userId": 1,
                    "title": "My blog post title",
                    "body": "This is the text of my latest blog post."
                }
                """;

            object id = Given()
                .ContentType("application/json")
                .Body(post)
                .When()
                .Post("https://jsonplaceholder.typicode.com/posts")
                .Then()
                .StatusCode(201)
                .Extract()
                .Body("$.id");

            // Normally, this should be an int, but the Extract() method returns numeric values as a long
            Assert.That(id, Is.InstanceOf(typeof(long)));
        }
    }
}
