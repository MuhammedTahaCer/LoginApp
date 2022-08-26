using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace LoginApp
{
    internal class Showide : TriggerAction<ImageButton>, INotifyPropertyChanged
    {
        public string Show { get; set; }
        public string Hide { get; set; }

        bool _hidePassword = true;
        public bool HidePassword
        {
            get=> _hidePassword;
            set
            {
                if (_hidePassword != value)
                {
                    _hidePassword = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(HidePassword)));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected override void Invoke(ImageButton sender)
        {
            sender.Source = HidePassword ? Show : Show;
            HidePassword = !HidePassword;
        }

    }
}
