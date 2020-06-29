using System;
using Ecommercer.Source.Common.Bases;
using Prism.Navigation;

namespace Ecommercer.Source.Edutalk
{
    public class TestViewModel:ViewModelBase
    {
        public ExamListent Model { set; get; }
        public TestViewModel(INavigationService navigationService):base(navigationService)
        {
            Model = new ExamListent
            {
                Answers = new System.Collections.Generic.List<ExamAnswer>()
            {
                 new ExamAnswer()
                 {
                      Answer="alo alo",
                 }
            },
                 Question= "blo blo",

            };
        }
    }
}
