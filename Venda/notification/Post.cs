using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venda.notification
{
    class Post
    {
        public DateTime Moment { get; set; } = DateTime.Now;
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new();

        public Post(string title, string content)
        {
            Title = title;
            Content = content;
        }

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }

        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }

        public String GetTextComments()
        {
            StringBuilder sb = new();
            Comments.ForEach(comment => sb.Append(comment).Append('\n'));
            return sb.ToString();
        }
       

        public override string ToString()
        {
            return $"{Title} \n{Moment} \n{Content}\nLikes: {Likes}\n\n{GetTextComments()}";
        }
    }
}
