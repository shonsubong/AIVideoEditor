using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace AIVideoEditor.ViewModels
{
    public class VideoEditorViewModel : BaseViewModel
    {
        public VideoEditorViewModel()
        {
            Title = "인공지능 비디오 편집기";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
        }

        public ICommand OpenWebCommand { get; }
    }
}