using System;
using System.ComponentModel;

namespace DemoForm.Models
{
    /// <summary>
    /// 答案回覆
    /// </summary>
    public class Replycation
    {
        [DisplayName("題目識別碼")]
        public Guid TopicId { get; set; }

        [DisplayName("選項識別碼")]
        public Guid TopicOptionId { get; set; }

        [DisplayName("答案")]
        public string Answer { get; set; }
    }
}