using System;

namespace Venda.notification {
    public class Comment {
        public string Text { get; set; }
        public DateTime Moment { get; set; } = DateTime.Now;

        public Comment(string text)
        {
            Text = text;
        }

        public override string ToString()
        {
            return $"{Moment}\n{Text}\n";
        }
    }
}