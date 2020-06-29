using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Ecommercer.Source.Edutalk
{
    public partial class ExamListentPage : ContentView
    {
        public ExamListent ExamListen
        {
            get => (ExamListent)GetValue(ExamListenProperty);
            set => SetValue(ExamListenProperty, value);
        }

        public static BindableProperty ExamListenProperty = BindableProperty.Create(
            nameof(ExamListen),
            typeof(ExamListent),
            typeof(ExamListentPage),
            default(ExamListent),
            BindingMode.TwoWay,
            propertyChanged: handleExamListenProperty
            );

        static void handleExamListenProperty(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is ExamListentPage elp)
            {
                elp.SetData();
            }
        }

        bool IsPlaying { get; set; } = true;

        string SourceMedia { get; set; }

        public ExamListentPage()
        {
            InitializeComponent();

        }

        private void SetData()
        {
            if (ExamListen != null)
            {
                var a = ExamListen.Answers;
                SourceMedia = ("https://www.soundhelix.com/examples/mp3/SoundHelix-Song-1.mp3");

                mediaElement.Source = SourceMedia;
            }
        }

        void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {
            if (IsPlaying == true)
            {
                IsPlaying = false;
                PlayButton.ImageSource = ("ic_pause_solid");
                mediaElement.Play();
            }
            else
            {
                IsPlaying = true;
                mediaElement.Pause();
                PlayButton.ImageSource = ("ic_play_solid");
            }
        }
    }
}
