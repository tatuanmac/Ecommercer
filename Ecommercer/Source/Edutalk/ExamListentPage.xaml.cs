using System;
using System.Collections.Generic;
using System.Threading.Tasks;
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

                clView.ItemsSource = ExamListen.Answers;
            }
        }

        void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {
            SwitchButton();
        }

        async Task SwitchButton()
        {
            await Task.WhenAll(IsPlaying == true ? PlayButton.RotateTo(360, 250) : PlayButton.RotateTo(0, 250), PlayButton.FadeTo(0, 250));
            if (IsPlaying == true)
            {
                IsPlaying = false;
                PlayButton.Source = ("ic_pause_solid");
                mediaElement.Play();
            }
            else
            {
                IsPlaying = true;
                mediaElement.Pause();
                PlayButton.Source = ("ic_play_solid");
            }
            await PlayButton.FadeTo(1, 250);
        }
    }
}
