using System;
using Ecommercer.Source.Common.Bases;
using Prism.Navigation;

namespace Ecommercer.Source.Edutalk
{
    public class TestViewModel : ViewModelBase
    {
        public ExamListent Model { set; get; }

        public TestViewModel(INavigationService navigationService) : base(navigationService)
        {
            Model = new ExamListent
            {
                Answers = new System.Collections.Generic.List<ExamAnswer>()
            {
                 new ExamAnswer()
                 {
                      Answer="a",
                 },
                 new ExamAnswer()
                 {
                      Answer="b",
                 },
                 new ExamAnswer()
                 {
                      Answer="c",
                 },
                 new ExamAnswer()
                 {
                      Answer="d",
                 },
                 new ExamAnswer()
                 {
                      Answer="e",
                 },
                 new ExamAnswer()
                 {
                      Answer="f",
                 }
            },
                Question = "blo blo",

            } ;
        }
    }
}
