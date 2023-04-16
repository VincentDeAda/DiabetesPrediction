
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DiabetesPrediction.ML;
using System;
using static DiabetesPrediction.ML.DiabetesPredictions;

namespace DiabetesPrediction.ViewModels;
public partial class MainViewModel : ObservableObject
{
    [ObservableProperty,NotifyPropertyChangedFor(nameof(IsNotBusy))]
    private bool isBusy = false;


    [ObservableProperty]
    private bool isNotBusy = true;


    [ObservableProperty]
    private double resultPercentage;

    [ObservableProperty]
    private ModelInput model = new ModelInput();

    [RelayCommand]
    public void CheckResult()
    {
        IsBusy = true;
        var predictionResult = DiabetesPredictions.Predict(Model);
        ResultPercentage = Math.Round(predictionResult.Score[0] * 100, 2);
        IsBusy = false;

    }

}
