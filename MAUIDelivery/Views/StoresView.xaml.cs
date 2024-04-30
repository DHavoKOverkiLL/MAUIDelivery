using MAUIDelivery.Models;

namespace MAUIDelivery.Views;

public partial class StoresView : ContentPage
{
    public List<Store> Stores { get; set; }
    public StoresView()
	{
		InitializeComponent();
		LoadData();
		BindingContext = this;
	}
	private void LoadData()
	{
        Stores = new List<Store>
        {
            new Store
            {
            Id=1,
            Header="header1.jpg",
            Logo="logo1.jpg",
            Name="Maugly",
            DeliveryTime="30-40 mins",
            Minimum=50,
            ServiceFee=10,
            Rating=4.5
            },
            new Store
            {
            Id = 2,
            Header = "header2.jpg",
            Logo = "logo2.jpg",
            Name = "Maulicious",
            DeliveryTime = "40-50 mins",
            Minimum = 60,
            ServiceFee = 15,
            Rating = 5
            },
            new Store
            {
            Id = 3,
            Header = "header3.jpg",
            Logo = "logo3.jpg",
            Name = "Ulicious",
            DeliveryTime = "35-45 mins",
            Minimum = 20,
            ServiceFee = 8,
            Rating = 4
            },
            new Store
            {
            Id = 4,
            Header = "header4.jpg",
            Logo = "logo4.jpg",
            Name = "MAUImitor",
            DeliveryTime = "55-60 mins",
            Minimum = 45,
            ServiceFee = 12,
            Rating = 4.8
            },
            new Store
            {
            Id = 5,
            Header = "header5.jpg",
            Logo = "logo5.jpg",
            Name = "maUgly",
            DeliveryTime = "35-45 mins",
            Minimum = 40,
            ServiceFee = 5,
            Rating = 3.5
            },
        };
	}
}