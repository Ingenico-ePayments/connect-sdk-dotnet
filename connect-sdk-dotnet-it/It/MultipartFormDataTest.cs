using NUnit.Framework;
using Ingenico.Connect.Sdk.DefaultImpl;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Ingenico.Connect.Sdk.It
{
    [TestFixture]
    public class MultipartFormDataTest : IntegrationTest
    {
        [TestCase]
        public async Task TestMultipartFormDataUploadPostMultipartFormDataObjectWithResponse()
        {
            CommunicatorConfiguration configuration = GetCommunicatorConfiguration();
            // changing the ApiEndpoint changes the underlying configuration section; restore it afterwards
            var apiEndpoint = configuration.ApiEndpoint;
            try
            {
                configuration.ApiEndpoint = new Uri("http://httpbin.org");

                using (Communicator communicator = Factory.CreateCommunicator(configuration))
                {
                    MemoryStream content = new MemoryStream();
                    StreamWriter writer = new StreamWriter(content);
                    writer.Write("file-content");
                    writer.Flush();
                    content.Position = 0;
                    MultipartFormDataObject multipart = new MultipartFormDataObject();
                    multipart.AddFile("file", new UploadableFile("file.txt", content, "text/plain"));
                    multipart.AddValue("value", "Hello World");

                    HttpBinResponse response = await communicator.Post<HttpBinResponse>("/post", null, null, multipart, null);

                    Assert.NotNull(response.Form);
                    Assert.AreEqual(1, response.Form.Count);
                    Assert.IsTrue(response.Form.ContainsKey("value"));
                    Assert.AreEqual("Hello World", response.Form["value"]);

                    Assert.NotNull(response.Files);
                    Assert.AreEqual(1, response.Files.Count);
                    Assert.IsTrue(response.Files.ContainsKey("file"));
                    Assert.AreEqual("file-content", response.Files["file"]);
                }
            }
            finally
            {
                configuration.ApiEndpoint = apiEndpoint;
            }
        }

        [TestCase]
        public async Task TestMultipartFormDataUploadPostIMultipartFormDataRequestWithResponse()
        {
            CommunicatorConfiguration configuration = GetCommunicatorConfiguration();
            // changing the ApiEndpoint changes the underlying configuration section; restore it afterwards
            var apiEndpoint = configuration.ApiEndpoint;
            try
            {
                configuration.ApiEndpoint = new Uri("http://httpbin.org");

                using (Communicator communicator = Factory.CreateCommunicator(configuration))
                {
                    MemoryStream content = new MemoryStream();
                    StreamWriter writer = new StreamWriter(content);
                    writer.Write("file-content");
                    writer.Flush();
                    content.Position = 0;
                    MultipartFormDataObject multipart = new MultipartFormDataObject();
                    multipart.AddFile("file", new UploadableFile("file.txt", content, "text/plain"));
                    multipart.AddValue("value", "Hello World");

                    HttpBinResponse response = await communicator.Post<HttpBinResponse>("/post", null, null, new MultipartFormDataObjectWrapper(multipart), null);

                    Assert.NotNull(response.Form);
                    Assert.AreEqual(1, response.Form.Count);
                    Assert.IsTrue(response.Form.ContainsKey("value"));
                    Assert.AreEqual("Hello World", response.Form["value"]);

                    Assert.NotNull(response.Files);
                    Assert.AreEqual(1, response.Files.Count);
                    Assert.IsTrue(response.Files.ContainsKey("file"));
                    Assert.AreEqual("file-content", response.Files["file"]);
                }
            }
            finally
            {
                configuration.ApiEndpoint = apiEndpoint;
            }
        }

        [TestCase]
        public async Task TestMultipartFormDataUploadPostMultipartFormDataObjectWithBodyHandler()
        {
            CommunicatorConfiguration configuration = GetCommunicatorConfiguration();
            // changing the ApiEndpoint changes the underlying configuration section; restore it afterwards
            var apiEndpoint = configuration.ApiEndpoint;
            try
            {
                configuration.ApiEndpoint = new Uri("http://httpbin.org");

                using (Communicator communicator = Factory.CreateCommunicator(configuration))
                {
                    MemoryStream content = new MemoryStream();
                    StreamWriter writer = new StreamWriter(content);
                    writer.Write("file-content");
                    writer.Flush();
                    content.Position = 0;
                    MultipartFormDataObject multipart = new MultipartFormDataObject();
                    multipart.AddFile("file", new UploadableFile("file.txt", content, "text/plain"));
                    multipart.AddValue("value", "Hello World");

                    await communicator.Post("/post", null, null, multipart, (stream, headers) => {
                        HttpBinResponse response = DefaultMarshaller.Instance.Unmarshal<HttpBinResponse>(stream);

                        Assert.NotNull(response.Form);
                        Assert.AreEqual(1, response.Form.Count);
                        Assert.IsTrue(response.Form.ContainsKey("value"));
                        Assert.AreEqual("Hello World", response.Form["value"]);

                        Assert.NotNull(response.Files);
                        Assert.AreEqual(1, response.Files.Count);
                        Assert.IsTrue(response.Files.ContainsKey("file"));
                        Assert.AreEqual("file-content", response.Files["file"]);
                    }, null);
                }
            }
            finally
            {
                configuration.ApiEndpoint = apiEndpoint;
            }
        }

        [TestCase]
        public async Task TestMultipartFormDataUploadPostIMultipartFormDataRequestWithBodyHandler()
        {
            CommunicatorConfiguration configuration = GetCommunicatorConfiguration();
            // changing the ApiEndpoint changes the underlying configuration section; restore it afterwards
            var apiEndpoint = configuration.ApiEndpoint;
            try
            {
                configuration.ApiEndpoint = new Uri("http://httpbin.org");

                using (Communicator communicator = Factory.CreateCommunicator(configuration))
                {
                    MemoryStream content = new MemoryStream();
                    StreamWriter writer = new StreamWriter(content);
                    writer.Write("file-content");
                    writer.Flush();
                    content.Position = 0;
                    MultipartFormDataObject multipart = new MultipartFormDataObject();
                    multipart.AddFile("file", new UploadableFile("file.txt", content, "text/plain"));
                    multipart.AddValue("value", "Hello World");

                    await communicator.Post("/post", null, null, new MultipartFormDataObjectWrapper(multipart), (stream, headers) => {
                        HttpBinResponse response = DefaultMarshaller.Instance.Unmarshal<HttpBinResponse>(stream);

                        Assert.NotNull(response.Form);
                        Assert.AreEqual(1, response.Form.Count);
                        Assert.IsTrue(response.Form.ContainsKey("value"));
                        Assert.AreEqual("Hello World", response.Form["value"]);

                        Assert.NotNull(response.Files);
                        Assert.AreEqual(1, response.Files.Count);
                        Assert.IsTrue(response.Files.ContainsKey("file"));
                        Assert.AreEqual("file-content", response.Files["file"]);
                    }, null);
                }
            }
            finally
            {
                configuration.ApiEndpoint = apiEndpoint;
            }
        }

        [TestCase]
        public async Task TestMultipartFormDataUploadPutMultipartFormDataObjectWithResponse()
        {
            CommunicatorConfiguration configuration = GetCommunicatorConfiguration();
            // changing the ApiEndpoint changes the underlying configuration section; restore it afterwards
            var apiEndpoint = configuration.ApiEndpoint;
            try
            {
                configuration.ApiEndpoint = new Uri("http://httpbin.org");

                using (Communicator communicator = Factory.CreateCommunicator(configuration))
                {
                    MemoryStream content = new MemoryStream();
                    StreamWriter writer = new StreamWriter(content);
                    writer.Write("file-content");
                    writer.Flush();
                    content.Position = 0;
                    MultipartFormDataObject multipart = new MultipartFormDataObject();
                    multipart.AddFile("file", new UploadableFile("file.txt", content, "text/plain"));
                    multipart.AddValue("value", "Hello World");

                    HttpBinResponse response = await communicator.Put<HttpBinResponse>("/put", null, null, multipart, null);

                    Assert.NotNull(response.Form);
                    Assert.AreEqual(1, response.Form.Count);
                    Assert.IsTrue(response.Form.ContainsKey("value"));
                    Assert.AreEqual("Hello World", response.Form["value"]);

                    Assert.NotNull(response.Files);
                    Assert.AreEqual(1, response.Files.Count);
                    Assert.IsTrue(response.Files.ContainsKey("file"));
                    Assert.AreEqual("file-content", response.Files["file"]);
                }
            }
            finally
            {
                configuration.ApiEndpoint = apiEndpoint;
            }
        }

        [TestCase]
        public async Task TestMultipartFormDataUploadPutIMultipartFormDataRequestWithResponse()
        {
            CommunicatorConfiguration configuration = GetCommunicatorConfiguration();
            // changing the ApiEndpoint changes the underlying configuration section; restore it afterwards
            var apiEndpoint = configuration.ApiEndpoint;
            try
            {
                configuration.ApiEndpoint = new Uri("http://httpbin.org");

                using (Communicator communicator = Factory.CreateCommunicator(configuration))
                {
                    MemoryStream content = new MemoryStream();
                    StreamWriter writer = new StreamWriter(content);
                    writer.Write("file-content");
                    writer.Flush();
                    content.Position = 0;
                    MultipartFormDataObject multipart = new MultipartFormDataObject();
                    multipart.AddFile("file", new UploadableFile("file.txt", content, "text/plain"));
                    multipart.AddValue("value", "Hello World");

                    HttpBinResponse response = await communicator.Put<HttpBinResponse>("/put", null, null, new MultipartFormDataObjectWrapper(multipart), null);

                    Assert.NotNull(response.Form);
                    Assert.AreEqual(1, response.Form.Count);
                    Assert.IsTrue(response.Form.ContainsKey("value"));
                    Assert.AreEqual("Hello World", response.Form["value"]);

                    Assert.NotNull(response.Files);
                    Assert.AreEqual(1, response.Files.Count);
                    Assert.IsTrue(response.Files.ContainsKey("file"));
                    Assert.AreEqual("file-content", response.Files["file"]);
                }
            }
            finally
            {
                configuration.ApiEndpoint = apiEndpoint;
            }
        }

        [TestCase]
        public async Task TestMultipartFormDataUploadPutMultipartFormDataObjectWithBodyHandler()
        {
            CommunicatorConfiguration configuration = GetCommunicatorConfiguration();
            // changing the ApiEndpoint changes the underlying configuration section; restore it afterwards
            var apiEndpoint = configuration.ApiEndpoint;
            try
            {
                configuration.ApiEndpoint = new Uri("http://httpbin.org");

                using (Communicator communicator = Factory.CreateCommunicator(configuration))
                {
                    MemoryStream content = new MemoryStream();
                    StreamWriter writer = new StreamWriter(content);
                    writer.Write("file-content");
                    writer.Flush();
                    content.Position = 0;
                    MultipartFormDataObject multipart = new MultipartFormDataObject();
                    multipart.AddFile("file", new UploadableFile("file.txt", content, "text/plain"));
                    multipart.AddValue("value", "Hello World");

                    await communicator.Put("/put", null, null, multipart, (stream, headers) => {
                        HttpBinResponse response = DefaultMarshaller.Instance.Unmarshal<HttpBinResponse>(stream);

                        Assert.NotNull(response.Form);
                        Assert.AreEqual(1, response.Form.Count);
                        Assert.IsTrue(response.Form.ContainsKey("value"));
                        Assert.AreEqual("Hello World", response.Form["value"]);

                        Assert.NotNull(response.Files);
                        Assert.AreEqual(1, response.Files.Count);
                        Assert.IsTrue(response.Files.ContainsKey("file"));
                        Assert.AreEqual("file-content", response.Files["file"]);
                    }, null);
                }
            }
            finally
            {
                configuration.ApiEndpoint = apiEndpoint;
            }
        }

        [TestCase]
        public async Task TestMultipartFormDataUploadPutIMultipartFormDataRequestWithBodyHandler()
        {
            CommunicatorConfiguration configuration = GetCommunicatorConfiguration();
            // changing the ApiEndpoint changes the underlying configuration section; restore it afterwards
            var apiEndpoint = configuration.ApiEndpoint;
            try
            {
                configuration.ApiEndpoint = new Uri("http://httpbin.org");

                using (Communicator communicator = Factory.CreateCommunicator(configuration))
                {
                    MemoryStream content = new MemoryStream();
                    StreamWriter writer = new StreamWriter(content);
                    writer.Write("file-content");
                    writer.Flush();
                    content.Position = 0;
                    MultipartFormDataObject multipart = new MultipartFormDataObject();
                    multipart.AddFile("file", new UploadableFile("file.txt", content, "text/plain"));
                    multipart.AddValue("value", "Hello World");

                    await communicator.Put("/put", null, null, new MultipartFormDataObjectWrapper(multipart), (stream, headers) => {
                        HttpBinResponse response = DefaultMarshaller.Instance.Unmarshal<HttpBinResponse>(stream);

                        Assert.NotNull(response.Form);
                        Assert.AreEqual(1, response.Form.Count);
                        Assert.IsTrue(response.Form.ContainsKey("value"));
                        Assert.AreEqual("Hello World", response.Form["value"]);

                        Assert.NotNull(response.Files);
                        Assert.AreEqual(1, response.Files.Count);
                        Assert.IsTrue(response.Files.ContainsKey("file"));
                        Assert.AreEqual("file-content", response.Files["file"]);
                    }, null);
                }
            }
            finally
            {
                configuration.ApiEndpoint = apiEndpoint;
            }
        }

        sealed class HttpBinResponse
        {
            public Dictionary<string, string> Form { get; set; }
            public Dictionary<string, string> Files { get; set; }
        }

        sealed class MultipartFormDataObjectWrapper : IMultipartFormDataRequest
        {
            readonly MultipartFormDataObject multipart;

            public MultipartFormDataObjectWrapper(MultipartFormDataObject multipart)
            {
                this.multipart = multipart;
            }

            public MultipartFormDataObject ToMultipartFormDataObject()
            {
                return multipart;
            }
        }
    }
}
