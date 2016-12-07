using System;
using System.ComponentModel;

namespace DemoForm.Models
{
    /// <summary>
    /// 題目選項
    /// </summary>
    public class TopicOption
    {
        [DisplayName("識別碼")]
        public Guid Id { get; set; }

        [DisplayName("題目識別碼")]
        public Guid TopicId { get; set; }

        [DisplayName("順序")]
        public int Sort { get; set; }

        [DisplayName("問題")]
        public string Question { get; set; }

        [DisplayName("類型")]
        public TopicOptionCategory Category { get; set; }

        [DisplayName("文字")]
        public string Text { get; set; }

        [DisplayName("特殊選項")]
        public SpecialOption Special { get; set; }
    }
}