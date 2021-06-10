using FluentAssertions;
using Flurl.Http;
using NUnit.Framework;


namespace Homework8
{
    public class Tests
    {
        [Test]
        public void GetTest()
        {
        var response = "https://jsonplaceholder.typicode.com/posts".GetAsync().Result;
           var responseBody = response.ResponseMessage.Content.ReadAsStringAsync().Result;
            Assert.AreEqual(200,response.StatusCode);
        }

        [Test]
        public void PostTest()
        {

            var response = "https://jsonplaceholder.typicode.com/posts"
                .PostJsonAsync(new
                {
                   title = "PostI",
                    body = "fkjhg",
                    userId = 1
               });
            var responseBody = response.Result.ResponseMessage.Content.ReadAsStringAsync().Result;
            Assert.AreEqual(201,response.Result.StatusCode);
        }
        [Test]
        public void PutTest()
        {
            var response = "https://jsonplaceholder.typicode.com/posts/1"
                .PutJsonAsync(new
                {
                    id = 1,
                    title = "Put",
                    body = "fkjhg",
                    userId = 1
                });
            var responseBody = response.Result.ResponseMessage.Content.ReadAsStringAsync().Result;
            Assert.AreEqual(200,response.Result.StatusCode);
        }
        [Test]
        public void PatchTest1()
        {
            var response = "https://jsonplaceholder.typicode.com/posts/1"
                .PatchJsonAsync(new
                {
                    title = "Patch",

                });
            var responseBody = response.Result.ResponseMessage.Content.ReadAsStringAsync().Result;
            Assert.AreEqual(200,response.Result.StatusCode);
        }
        [Test]
        public void DeletTest()
        {
            var response = "https://jsonplaceholder.typicode.com/posts/1".DeleteAsync();
            var responseBody = response.Result.ResponseMessage.Content.ReadAsStringAsync().Result;
           Assert.AreEqual(200, response.Result.StatusCode);
        }
    }
}
