﻿namespace NewsMaking.AsconNews.Models
{
 public class NewsModel
 {
   public string Title { get; set; }

   public DateTime CreationTime { get; set; }

   public string ContentType { get; set; }

   public string Body { get; set; }

   public Uri Link { get; set; }
 }
}
