using Microsoft.AspNetCore.Http;
using MoviePro.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MoviePro.Services
{
    public class BasicImageService : IImageService
    {

        private readonly IHttpClientFactory _httpClient;

        public BasicImageService(IHttpClientFactory httpClient)
        {
            _httpClient = httpClient;
        }

        public string DecodeImage(byte[] poster, string contentType)
        {
            if (poster is null) return null;

            var posterImage = Convert.ToBase64String(poster);

            return $"data:{contentType};base64,{posterImage}";
        }

        public async Task<byte[]> EncodeImageAsync(IFormFile poster)
        {
            if (poster is null) return null;

            using var ms = new MemoryStream();
            await poster.CopyToAsync(ms);

            return ms.ToArray();
        }

        public async Task<byte[]> EndodeImageURLAsync(string imageURL)
        {
            var client = _httpClient.CreateClient();
            var response = await client.GetAsync(imageURL);
            using Stream stream = await response.Content.ReadAsStreamAsync();

            var ms = new MemoryStream();
            await stream.CopyToAsync(ms);

            return ms.ToArray();
        }
    }
}
