using System;
using Ecommercer.Source.Common.Bases;

namespace Ecommercer.Source.Edutalk
{
    public enum ListeningEnum
    {
        Play, Pause, Stop
    }

    public class ExampleListentButton: ModelBase
    {
        public string ButtonImageSource { get; set; }
        public ListeningEnum Type { get; set; }
        public bool IsSelected { get; set; }
    }
}
