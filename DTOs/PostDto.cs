﻿namespace E24_Amazon.DTOs
{
    public class PostDto
    {
        public int UserId { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public DateTime PublicationDate { get; set; }
        public string Image { get; set; }
        public string Content { get; set; }
        public bool Approved { get; set; }
    }
}
