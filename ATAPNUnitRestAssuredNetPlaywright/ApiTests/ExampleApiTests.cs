using NUnit.Framework;
using static RestAssured.Dsl;

namespace ATAPNUnitRestAssuredNetPlaywright.ApiTests
{
    [TestFixture]
    public class ExampleApiTests
    {
        [TestCase(1, "Leanne Graham", "harness real-time e-markets", TestName = "User 1 is Leanne Graham")]
        [TestCase(2, "Ervin Howell", "synergize scalable supply-chains", TestName = "User 2 is Ervin Howell")]
        [TestCase(3, "Clementine Bauch", "e-enable strategic applications", TestName = "User 3 is Clementine Bauch")]
        public void GetDataForUser_CheckStatusCodeHeaderAndBody
            (int userId, string expectedName, string expectedBS)
        {
            Given()
                .When()
                .Get($"https://jsonplaceholder.typicode.com/users/{userId}")
                .Then()
                .StatusCode(200)
                .ContentType("application/json; charset=utf-8")
                .Body("$.name", NHamcrest.Is.EqualTo(expectedName))
                .Body("$.company.bs", NHamcrest.Is.EqualTo(expectedBS));
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
