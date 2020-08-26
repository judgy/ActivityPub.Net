using System.Collections.Generic;
using System.Diagnostics;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using NUnit.Framework;

namespace ActivityPub.Net.Unittest
{
    public class ActivitypubExampleTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Example1Test()
        {
            //https://www.w3.org/TR/activitypub Example 1

            //Arrange
            var exampleCompare =
                "{" +
                "\"@context\": \"https://www.w3.org/ns/activitystreams\"," +
                "\"type\": \"Person\"," +
                "\"id\": \"https://social.example/alyssa/\"," +
                "\"name\": \"Alyssa P. Hacker\"," +
                "\"preferredUsername\": \"alyssa\"," +
                "\"summary\": \"Lisp enthusiast hailing from MIT\"," +
                "\"inbox\": \"https://social.example/alyssa/inbox/\"," +
                "\"outbox\": \"https://social.example/alyssa/outbox/\"," +
                "\"followers\": \"https://social.example/alyssa/followers/\"," +
                "\"following\": \"https://social.example/alyssa/following/\"," +
                "\"liked\": \"https://social.example/alyssa/liked/\"}";
            Dictionary<string, string> exampleCompareJson = JsonConvert.DeserializeObject<Dictionary<string, string>>(exampleCompare);

            //Act
            var example1Result = ActivityBuilderDirector.NewActivity
                .Actor().Person().Id("https://social.example/alyssa/")
                        .Name("Alyssa P. Hacker")
                        .Id("https://social.example/alyssa/")
                        .PreferredUsername("alyssa")
                        .Summary("Lisp enthusiast hailing from MIT")
                        .Inbox("https://social.example/alyssa/inbox/")
                        .OutBox("https://social.example/alyssa/outbox/")
                        .Followers("https://social.example/alyssa/followers/")
                        .Following("https://social.example/alyssa/following/")
                        .Liked("https://social.example/alyssa/liked/")
                        .EndPerson()
                .Build();

            //var example1Person = ActivityBuilderDirector.NewActivity
            //    .Actor().Person().Id("https://social.example/alyssa/")
            //    .Name("Alyssa P. Hacker")
            //    .Id("https://social.example/alyssa/")
            //    .PreferredUsername("alyssa")
            //    .Summary("Lisp enthusiast hailing from MIT")
            //    .Inbox("https://social.example/alyssa/inbox/")
            //    .OutBox("https://social.example/alyssa/outbox/")
            //    .Followers("https://social.example/alyssa/followers/")
            //    .Following("https://social.example/alyssa/following/")
            //    .Liked("https://social.example/alyssa/liked/")
            //    .GetPerson();

            //Assert
            Dictionary<string, string> example1ResultJson = JsonConvert.DeserializeObject<Dictionary<string, string>>(example1Result);
            Assert.IsTrue(example1ResultJson.Count== exampleCompareJson.Count);
            Assert.AreEqual(exampleCompareJson["@context"], example1ResultJson["@context"]);
            Assert.AreEqual(exampleCompareJson["type"], example1ResultJson["type"]);
            Assert.AreEqual(exampleCompareJson["id"], example1ResultJson["id"]);
            Assert.AreEqual(exampleCompareJson["name"], example1ResultJson["name"]);
            Assert.AreEqual(exampleCompareJson["preferredUsername"], example1ResultJson["preferredUsername"]);
            Assert.AreEqual(exampleCompareJson["summary"], example1ResultJson["summary"]);
            Assert.AreEqual(exampleCompareJson["inbox"], example1ResultJson["inbox"]);
            Assert.AreEqual(exampleCompareJson["outbox"], example1ResultJson["outbox"]);
            Assert.AreEqual(exampleCompareJson["followers"], example1ResultJson["followers"]);
            Assert.AreEqual(exampleCompareJson["following"], example1ResultJson["following"]);
            Assert.AreEqual(exampleCompareJson["liked"], example1ResultJson["liked"]);

        }

        [Test]
        public void Example2Test()
        {
            //https://www.w3.org/TR/activitypub Example 2

            //Arrange
            var exampleCompare =
                "{" +
                "\"@context\": \"https://www.w3.org/ns/activitystreams\"," +
                "\"type\": \"Note\"," +
                "\"to\": [\"https://chatty.example/ben/\"]," +
                "\"attributedTo\": \"https://social.example/alyssa/\"," +
                "\"content\": \"Say, did you finish reading that book I lent you?\"}";

            var exampleCompareJson = JsonConvert.DeserializeObject<Note>(exampleCompare);

            //Act
            var example1Result = ActivityBuilderDirector.NewActivity.ObjectElement()
                        .Note().To("https://chatty.example/ben/")
                        .AttributedTo("https://social.example/alyssa/")
                        .Content("Say, did you finish reading that book I lent you?")
                        .EndNote()
                .Build();

            //Assert
            var example1ResultJson = JsonConvert.DeserializeObject<Note>(example1Result);
            Assert.AreSame(exampleCompareJson, example1ResultJson);
            //Assert.AreEqual(exampleCompareJson["type"], example1ResultJson["type"]);
            //Assert.AreEqual(exampleCompareJson["to"], example1ResultJson["to"]);
            //Assert.AreEqual(exampleCompareJson["attributedTo"], example1ResultJson["attributedTo"]);
            //Assert.AreEqual(exampleCompareJson["content"], example1ResultJson["content"]);

        }

    }

    public class Note
    {
        [JsonPropertyName("@context")]
        public string Context { get; set; }
        [JsonPropertyName("type")]
        public string Type { get; set; }
        [JsonPropertyName("content")]
        public string Content { get; set; }
        [JsonPropertyName("attributedTo")]
        public string AttributedTo { get; set; }
        [JsonPropertyName("to")]
        public IList<string> To { get; set; }
    }



}