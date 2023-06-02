using System;

using Tizen.NUI;
using Tizen.NUI.BaseComponents;

namespace TFMSample
{
    internal class Program : NUIApplication
    {
        protected override void OnCreate()
        {
            base.OnCreate();
            Initialize();
        }

        void Initialize()
        {
            Window.Instance.KeyEvent += OnKeyEvent;

            View layoutView = new View() {
                HeightResizePolicy = ResizePolicyType.FillToParent,
                WidthResizePolicy = ResizePolicyType.FillToParent
            };
            var linearLayout = new LinearLayout()
            {
                LinearOrientation = LinearLayout.Orientation.Vertical,
            };
            layoutView.Layout = linearLayout;

            View text = new TextLabel("Hello Tizen")
            {
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                TextColor = Color.Blue,
                PointSize = 12.0f,
                HeightResizePolicy = ResizePolicyType.FillToParent,
                WidthResizePolicy = ResizePolicyType.FillToParent
            };

            TextLabel text_netstandard = new TextLabel()
            {
                Text = new NetStandardLibrary.NetstandrdClass().MessageFromNetStandard(),
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                TextColor = Color.Blue,
                PointSize = 12.0f,
                HeightResizePolicy = ResizePolicyType.FillToParent,
                WidthResizePolicy = ResizePolicyType.FillToParent
            };

            TextLabel text_netcore = new TextLabel()
            {
                Text = new NetCoreLibrary.NetCoreClass().MessageFromNetCore(),
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                TextColor = Color.Blue,
                PointSize = 12.0f,
                HeightResizePolicy = ResizePolicyType.FillToParent,
                WidthResizePolicy = ResizePolicyType.FillToParent
            };

            TextLabel text_net60 = new TextLabel()
            {
                Text = new Net60Library.Net60Class().MessageFromNet60(),
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                TextColor = Color.Blue,
                PointSize = 12.0f,
                HeightResizePolicy = ResizePolicyType.FillToParent,
                WidthResizePolicy = ResizePolicyType.FillToParent
            };

            layoutView.Add(text);
            layoutView.Add(text_netstandard);
            layoutView.Add(text_netcore);
            layoutView.Add(text_net60);

            Window.Instance.GetDefaultLayer().Add(layoutView);


        }

        public void OnKeyEvent(object sender, Window.KeyEventArgs e)
        {
            if (e.Key.State == Key.StateType.Down && (e.Key.KeyPressedName == "XF86Back" || e.Key.KeyPressedName == "Escape"))
            {
                Exit();
            }
        }

        static void Main(string[] args)
        {
            var app = new Program();
            app.Run(args);
        }
    }
}
