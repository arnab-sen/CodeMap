using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Input;

namespace CodeMap
{
    public class MainWindow : Window
    {
        //private Label label1;
        Canvas canvas = new Canvas();
        SolidColorBrush background = Brushes.White;
        public MainWindow()
        {
            Width = 500;
            Height = 500;
            Content = canvas;
            canvas.Children.Add(new Rectangle() { Fill = background, Width = 500, Height = 500 });
            canvas.MouseUp += new MouseButtonEventHandler(OnMouseUp);
        }

        private void OnMouseUp(object sender, MouseButtonEventArgs e)
        {
            DrawRectangle(sender, e);
        }
        private void DrawRectangle(object sender = null, MouseButtonEventArgs e = null)
        {
            Rectangle block = new Rectangle()
            {
                Fill = Brushes.LightBlue,
                Height = 50,
                Width = 100,
                RadiusX = 5,
                RadiusY = 5
            };
            Point position;
            if (e != null)
            {
                position = e.GetPosition(canvas);
            }
            else
            {
                position = new Point(0, 0);
            }

            // Align block centre with mouse position
            Canvas.SetLeft(block, position.X - (block.Width / 2));
            Canvas.SetTop(block, position.Y - (block.Height / 2));
            canvas.Children.Add(block);
        }

        [STAThread]
        public static void Main()
        {
            Application app = new Application();

            app.Run(new MainWindow());
        }
    }
}