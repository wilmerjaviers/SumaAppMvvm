using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace SumaAppMvvm.ViewModels
{
    public partial class SumaViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _valueA;

        [ObservableProperty]
        private string _valueB;

        [ObservableProperty]
        private double _result;

        private async Task ShowAlert(string message)
        {
            await Application.Current.MainPage.DisplayAlert("Alerta", message, "Aceptar");
        }

        [RelayCommand]
        private async void Sum()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(ValueA) || !double.TryParse(ValueA, out double valueA))
                {
                    await ShowAlert("El primer valor está vacío. Por favor, ingrese un número válido.");
                    return;
                }

                
                if (string.IsNullOrWhiteSpace(ValueB) || !double.TryParse(ValueB, out double valueB))
                {
                    await ShowAlert("El segundo valor está vacío. Por favor, ingrese un número válido.");
                    return;
                }

                
                Result = valueA + valueB;
            }
            catch (Exception ex)
            {
                await ShowAlert($"Ocurrió un error: {ex.Message}");
            }
        }

        [RelayCommand]
        private void Clear()
        {
            ValueA = string.Empty;
            ValueB = string.Empty;
            Result = 0;
        }

      
    }
}
