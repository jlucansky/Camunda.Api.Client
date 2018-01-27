using Refit;
using System;
using System.Net.Http;

namespace Camunda.Api.Client
{
    public class HttpContentMultipartItem<T> : MultipartItem
        where T : HttpContent
    {
        public HttpContentMultipartItem(T content, string fileName = "") : base(fileName, null)
        {
            Content = content ?? throw new ArgumentNullException("content");
        }

        public T Content { get; set; }

        protected override HttpContent CreateContent()
        {
            return Content;
        }
    }
}
