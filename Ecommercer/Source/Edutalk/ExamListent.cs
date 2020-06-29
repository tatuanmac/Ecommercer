using System;
using System.Collections.Generic;
using Ecommercer.Source.Common.Bases;

namespace Ecommercer.Source.Edutalk
{

    public class ExamListent : ModelBase
    {
        public string Question { get; set; }
        public string UrlAudio { get; set; }
        public List<ExamAnswer> Answers { get; set; }
    }
    public class ExamAnswer : ModelBase
    {
        public string Answer { get; set; }
    }
}
