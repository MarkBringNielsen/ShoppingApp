using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShoppingApp.Views.ViewComponents
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductView : ContentView
    {

        public static readonly BindableProperty ProductNameProperty =
            BindableProperty.Create("ProductName", typeof(string), typeof(ProductView), default(string));

        public string ProductName
        {
            get { return (string)GetValue(ProductNameProperty); }
            set { SetValue(ProductNameProperty, value); }
        }

        public static readonly BindableProperty ProductPriceProperty =
            BindableProperty.Create("ProductPrice", typeof(string), typeof(ProductView), default(string));

        public string ProductPrice
        {
            get { return (string)GetValue(ProductPriceProperty); }
            set { SetValue(ProductPriceProperty, value); }
        }

        public static readonly BindableProperty ImageSourceProperty =
            BindableProperty.Create("Source", typeof(ImageSource), typeof(ProductView), default(ImageSource));

        public ImageSource Source
        {
            get { return (ImageSource)GetValue(ImageSourceProperty); }
            set { SetValue(ImageSourceProperty, value); }
        }

        public ProductView()
        {
            InitializeComponent();

            productName.SetBinding(Label.TextProperty, new Binding("ProductName", source: this));
            productPrice.SetBinding(Label.TextProperty, new Binding("ProductPrice", source: this));
            productImage.SetBinding(Image.SourceProperty, new Binding("Source", source: this));
        }
    }
}