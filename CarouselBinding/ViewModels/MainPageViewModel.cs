using System.Collections.ObjectModel;
using CarouselBinding.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CarouselBinding.ViewModels;

public partial class MainPageViewModel : ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<CarouselData> data;
    
    public MainPageViewModel()
    {
        Data = new ObservableCollection<CarouselData>();
        Data.Add(new CarouselData()
        {
            Image = "image1.png",
            Text = "Image 1"
        });        
        Data.Add(new CarouselData()
        {
            Image = "image2.png",
            Text = "Image 2"
        });        
        Data.Add(new CarouselData()
        {
            Image = "image3.png",
            Text = "Image 3"
        });        
        Data.Add(new CarouselData()
        {
            Image = "image4.png",
            Text = "Image 4"
        });        
        Data.Add(new CarouselData()
        {
            Image = "image5.png",
            Text = "Image 5"
        });        
        Data.Add(new CarouselData()
        {
            Image = "image6.png",
            Text = "Image 6"
        });
        
    }

    [RelayCommand]
    private void ChangeData()
    {
        Data[0].Text = "CHANGED";
    }
}