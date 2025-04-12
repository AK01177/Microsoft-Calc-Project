using CalculatorApp.Utils;
using CalculatorApp.ViewModel;
using CalculatorApp.ViewModel.Common;

using System;
using Windows.ApplicationModel.Resources;
using Windows.Foundation;
using Windows.Globalization.NumberFormatting;
using Windows.UI.Core;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Automation;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Input;
using Windows.UI.Popups;

namespace Calculator.Views
{
    public partial class Optics : UserControl
    {
        public Optics()
        {
            InitializeComponent();
            TypeSelector.SelectionChanged += TypeSelector_SelectionChanged;
            BehaviorSelector.SelectionChanged += BehaviorSelector_SelectionChanged;
        }

        private async void TypeSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem selectedItem = (ComboBoxItem)TypeSelector.SelectedItem;
            string selectedType = selectedItem?.Content.ToString();
            var dialog = new MessageDialog($"Selected Type: {selectedType}");
            await dialog.ShowAsync();
        }

        private async void BehaviorSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem selectedItem = (ComboBoxItem)BehaviorSelector.SelectedItem;
            string selectedBehavior = selectedItem?.Content.ToString();
            var dialog = new MessageDialog($"Selected Behavior: {selectedBehavior}");
            await dialog.ShowAsync();
        }
    }
}
