using System;

namespace PlayingWithHWInputs
{
    class Program : global::Xamarin.Forms.Platform.Tizen.FormsApplication
    {
        static public int WindowWidth { get; set; }
        static public int WindowHeight { get; set; }

        protected override void OnCreate()
        {
            base.OnCreate();

            LoadApplication(new App());
        }

        static void Main(string[] args)
        {
            var app = new Program();
            //Program.WindowWidth = app.MainWindow.MinimumWidth;
            //Program.WindowHeight = app.MainWindow.MinimumHeight;
            global::Xamarin.Forms.Platform.Tizen.Forms.Init(app);
            Tizen.Wearable.CircularUI.Forms.Renderer.FormsCircularUI.Init();
            app.Run(args);
        }
    }
}
