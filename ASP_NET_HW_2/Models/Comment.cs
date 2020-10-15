using System;

namespace ASP_NET_HW_2.Models
{
    public class Comment
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string CommentText { get; set; }

        public DateTime DateTime { get; set; }

        public byte[] ImageData { get; set; }

        public string ImageMimeType { get; set; }
    }
}