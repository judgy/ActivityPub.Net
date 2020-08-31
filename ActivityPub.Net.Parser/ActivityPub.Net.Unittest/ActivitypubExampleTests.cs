using System.Collections.Generic;
using System.Dynamic;
using ActivityPub.Net.ActivityTypes;
using ActivityPub.Net.ObjectAndLinkTypes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
            dynamic exampleCompareJson = JObject.Parse(exampleCompare);
            //var exampleCompareJson = JsonConvert.DeserializeObject<Dictionary<string, string>>(exampleCompare);

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
            dynamic example1ResultJson = JObject.Parse(example1Result);
            //Assert.IsTrue(example1ResultJson.Count == exampleCompareJson.Count);
            Assert.AreEqual((string)exampleCompareJson.GetValue("@context"), (string)example1ResultJson.GetValue("@context"));
            Assert.AreEqual((string)exampleCompareJson["type"], (string)example1ResultJson.GetValue("type"));
            Assert.AreEqual((string)exampleCompareJson["id"], (string)example1ResultJson["id"]);
            Assert.AreEqual((string)exampleCompareJson["name"], (string)example1ResultJson["name"]);
            Assert.AreEqual((string)exampleCompareJson["preferredUsername"], (string)example1ResultJson["preferredUsername"]);
            Assert.AreEqual((string)exampleCompareJson["summary"], (string)example1ResultJson["summary"]);
            Assert.AreEqual((string)exampleCompareJson["inbox"], (string)example1ResultJson["inbox"]);
            Assert.AreEqual((string)exampleCompareJson["outbox"], (string)example1ResultJson["outbox"]);
            Assert.AreEqual((string)exampleCompareJson["followers"], (string)example1ResultJson["followers"]);
            Assert.AreEqual((string)exampleCompareJson["following"], (string)example1ResultJson["following"]);
            Assert.AreEqual((string)exampleCompareJson["liked"], (string)example1ResultJson["liked"]);
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

            dynamic exampleCompareJson = JObject.Parse(exampleCompare);
            //var exampleCompareJson = JsonConvert.DeserializeObject<Note>(exampleCompare);

            //Act
            var example1Result = ActivityBuilderDirector.NewActivity.ObjectElement()
                .Note().To("https://chatty.example/ben/")
                .AttributedTo("https://social.example/alyssa/")
                .Content("Say, did you finish reading that book I lent you?")
                .EndNote()
                .Build();

            //Assert
            //var example1ResultJson = JsonConvert.DeserializeObject<Note>(example1Result);
            dynamic example1ResultJson = JObject.Parse(exampleCompare);
            Assert.AreEqual((string)exampleCompareJson.Type, (string)example1ResultJson.Type);
            Assert.AreEqual((string)exampleCompareJson.AttributedTo, (string)example1ResultJson.AttributedTo);
            Assert.AreEqual((string)exampleCompareJson.Content, (string)example1ResultJson.Content);
            Assert.AreEqual((string)exampleCompareJson.GetValue("@context"), (string)example1ResultJson.GetValue("@context"));
            Assert.AreEqual((string)exampleCompareJson.Id, (string)example1ResultJson.Id);
        }

        [Test]
        public void Example3Test()
        {
            //Arrange
            dynamic noteCompare = new ExpandoObject(); ;
            noteCompare.Context = "";
            noteCompare.Id = "https://social.example/alyssa/posts/49e2d03d-b53a-4c4c-a95c-94a6abf45a19";
            noteCompare.AttributedTo = "https://social.example/alyssa/";
            noteCompare.Content = "Say, did you finish reading that book I lent you?";
            noteCompare.To = new string[]{"https://chatty.example/ben/"};

            dynamic createActivity = new ExpandoObject();
            createActivity.Context = "https://www.w3.org/ns/activitystreams";
            createActivity.Actor = "https://social.example/alyssa/";
            createActivity.Id = "https://social.example/alyssa/posts/a29a6843-9feb-4c74-a7f7-081b9c9201d3";
            createActivity.To = new string[] { "https://chatty.example/ben/" };
            createActivity.Type = "Create";
            createActivity.Object = noteCompare;
            //createActivity.Object = "{" +
            //                        "\"type\": \"Note\"," +
            //                        "\"id\": \"https://social.example/alyssa/posts/49e2d03d-b53a-4c4c-a95c-94a6abf45a19\"," +
            //                        "\"attributedTo\": \"https://social.example/alyssa/\"," +
            //                        "\"to\": [\"https://chatty.example/ben/\"]," +
            //                        "\"content\": \"Say, did you finish reading that book I lent you?\"}";
            //var exampleCompareJson = JsonConvert.DeserializeObject<Note>(createActivity.Object);

            //https://www.w3.org/TR/activitypub Example 3
            //{
            //    "@context": "https://www.w3.org/ns/activitystreams",
            //    "type": "Create",
            //    "id": "https://social.example/alyssa/posts/a29a6843-9feb-4c74-a7f7-081b9c9201d3",
            //    "to": ["https://chatty.example/ben/"],
            //    "actor": "https://social.example/alyssa/",
            //    "object": {
            //        "type": "Note",
            //        "id": "https://social.example/alyssa/posts/49e2d03d-b53a-4c4c-a95c-94a6abf45a19",
            //        "attributedTo": "https://social.example/alyssa/",
            //        "to": ["https://chatty.example/ben/"],
            //        "content": "Say, did you finish reading that book I lent you?"}
            //}
            dynamic note = ActivityBuilderDirector.NewActivity.ObjectElement()
                .Note()
                .To("https://chatty.example/ben/")
                .Id("https://social.example/alyssa/posts/49e2d03d-b53a-4c4c-a95c-94a6abf45a19")
                .AttributedTo("https://social.example/alyssa/")
                .Content("Say, did you finish reading that book I lent you?")
                .EndNote()
                .GetObject();


            //Act
            var example1Result = ActivityBuilderDirector.NewActivity.Activity()
                .CreateActivity()
                .To("https://chatty.example/ben/")
                .Actor("https://social.example/alyssa/")
                .Id("https://social.example/alyssa/posts/a29a6843-9feb-4c74-a7f7-081b9c9201d3")
                .ActivityObject((JObject)note)
                .EndCreateActivity()
                .Build();

            //Assert
            var example1ResultJson = JsonConvert.DeserializeObject<CreateActivity>(example1Result);
            //var example2ResultJson = JsonConvert.DeserializeObject<Note>(example1ResultJson.Object);
            //Note noteResult = (Note) example1ResultJson.Object;
            //JObject
            //Note noteResult = example1ResultJson.Object.ToObject<Note>();
            Assert.AreEqual(createActivity.Actor, example1ResultJson.Actor);
            Assert.AreEqual(createActivity.Context, example1ResultJson.Context);
            Assert.AreEqual(createActivity.Id, example1ResultJson.Id);
            Assert.AreEqual(createActivity.To[0], example1ResultJson.To[0]);
            Assert.AreEqual(createActivity.Type, example1ResultJson.Type);

            //Assert.AreEqual(noteResult.Context, noteCompare.Context);
            //Assert.AreEqual(noteResult.AttributedTo, noteCompare.AttributedTo);
            //Assert.AreEqual(noteResult.To[0], noteCompare.To[0]);
            //Assert.AreEqual(noteResult.Content, noteCompare.Content);
            //Assert.AreEqual(noteResult.Type, noteCompare.Type);

        }
    }

    //public class Note
    //{
    //    [JsonPropertyName("@context")]
    //    public string Context { get; set; }
    //    [JsonPropertyName("type")]
    //    public string Type { get; set; }
    //    [JsonPropertyName("content")]
    //    public string Content { get; set; }
    //    [JsonPropertyName("attributedTo")]
    //    public string AttributedTo { get; set; }
    //    [JsonPropertyName("to")]
    //    public IList<string> To { get; set; }
    //}
}