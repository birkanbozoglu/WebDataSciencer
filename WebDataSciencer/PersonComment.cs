using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDataSciencer
{
    public class PersonComment
    {
        [DisplayName("Yorumcu Adı")]
        public string Name { get; set; }
        [DisplayName("Yorumcu Yaşı")]
        public int Age { get; set; }
        [DisplayName("Yorumcu Şehir")]
        public string City { get; set; }
        [DisplayName("Yorum Zamanı")]
        public string CommentTime { get; set; }
        [DisplayName("Yorum")]
        public string Comment { get; set; }
    }
}
