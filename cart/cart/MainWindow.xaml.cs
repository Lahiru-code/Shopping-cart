using System.Windows;
using System.Windows.Input;
using Shopping_cart.UserControls;


namespace Shopping_cart
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }



        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {

                this.DragMove();
            }
        }


    }
}
