using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics.ES10;
using OpenTK.Graphics.ES30;
using Xamarin.Forms;
using All = OpenTK.Graphics.ES10.All;
using ClearBufferMask = OpenTK.Graphics.ES10.ClearBufferMask;
using GL = OpenTK.Graphics.ES10.GL;

namespace _3DScan.Views
{
    public partial class HomeView : ContentPage
    {
        float[] rot;
        float[] rateOfRotationPS;//degrees
        int viewportWidth, viewportHeight;

        public HomeView()
        {
            InitializeComponent();

            rateOfRotationPS = new float[] { 30, 45, 60 };
            rot = new float[] { 0, 0, 0 };

            OGLView.OnDisplay = OnDisplay;
        }

        private void OnDisplay(Rectangle rectangle)
        {
            GL.ClearColor(0.0f, 0.0f, 1.0f, 1.0f);
            GL.Clear(ClearBufferMask.ColorBufferBit);
            GL.Viewport(0, 0, (int)OGLView.Width, (int)OGLView.Height);
            var indices = new byte[] {0, 1, 2};
                (All.Triangles, indices.Length,All.UnsignedByte, indices);
            GL.Finish();
            GL.Flush();

        }
    }
}
