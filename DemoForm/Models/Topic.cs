using System;
using System.ComponentModel;

namespace DemoForm.Models
{
    /// <summary>
    /// 題目
    /// </summary>
    public class Topic
    {
        [DisplayName("識別碼")]
        public Guid Id { get; set; }

        [DisplayName("順序")]
        public int Sort { get; set; }

        [DisplayName("問題")]
        public string Question { get; set; }

        [DisplayName("題型")]
        public TopicCategory Category { get; set; }

        [DisplayName("選項/文字框 數量")]
        public int Amount { get; set; }

        [DisplayName("選項/文字框內文 上限")]
        public int Max { get; set; }

        [DisplayName("選項/文字框內文 下限")]
        public int Min { get; set; }

        [DisplayName("文字框內文格式")]
        public FormatCategory ContentType { get; set; }
    }
}