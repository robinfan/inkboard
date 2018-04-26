using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace InkBoard
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //声明一个 DrawingAttributes 类型的变量  
        DrawingAttributes drawingAttributes;
        private void Btn_Pen_Click(object sender, RoutedEventArgs e)
        {
            IB_Canvas.EditingMode = InkCanvasEditingMode.Ink;
            //Cursor tmpcur= new Cursor("e:\\laser.cur");
            //IB_Canvas.UseCustomCursor = true;
            IB_Canvas.Cursor = Cursors.None;
            
        }

        private void Btn_PenGesture_Click(object sender, RoutedEventArgs e)
        {
            IB_Canvas.EditingMode = InkCanvasEditingMode.InkAndGesture;
        }

        private void Btn_Earse_Click(object sender, RoutedEventArgs e)
        {
            IB_Canvas.EditingMode = InkCanvasEditingMode.EraseByPoint;
            drawingAttributes = new DrawingAttributes();
            drawingAttributes.Width = Convert.ToInt32(Cmb_penWidth.SelectedValue);
            drawingAttributes.Height = Convert.ToInt32(Cmb_penWidth.SelectedValue);
            IB_Canvas.DefaultDrawingAttributes = drawingAttributes;
            //Cursor tmpcur = new Cursor("e:\\laser.cur");
            //IB_Canvas.UseCustomCursor = true;
            //IB_Canvas.Cursor = tmpcur;
        }

        private void Btn_ClearNote_Click(object sender, RoutedEventArgs e)
        {
            IB_Canvas.EditingMode = InkCanvasEditingMode.EraseByStroke;
        }

        private void Btn_nSelect_Click(object sender, RoutedEventArgs e)
        {
            IB_Canvas.EditingMode = InkCanvasEditingMode.Select;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            Cmb_penWidth.Items.Add(3);
            Cmb_penWidth.Items.Add(5);
            Cmb_penWidth.Items.Add(8);
            Cmb_penWidth.Items.Add(12);
            Cmb_penWidth.Items.Add(20);
            Cmb_penWidth.SelectedIndex = 0;



        }

        private void Cmb_penWidth_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            drawingAttributes = new DrawingAttributes();
            drawingAttributes.Width= Convert.ToInt32(Cmb_penWidth.SelectedValue);
            drawingAttributes.Height = Convert.ToInt32(Cmb_penWidth.SelectedValue);
            drawingAttributes.Color = Color.FromRgb(255, 0, 0);
            IB_Canvas.DefaultDrawingAttributes = drawingAttributes;
        }
    }
}
