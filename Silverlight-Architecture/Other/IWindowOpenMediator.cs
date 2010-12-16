using System;
using System.ComponentModel.Composition;
using System.Windows;
using System.Windows.Controls;
using GalaSoft.MvvmLight;

namespace SilverlightArchitecture.Other
{
    [InheritedExport]
    public interface IWindowOpenMediator
    {
        void OpenWindow(ViewModelBase viewModel, Action onClosed);
    }

    public class WindowOpenMeditator : IWindowOpenMediator
    {
        public void OpenWindow(ViewModelBase viewModel, Action onClosed)
        {
            var childWindow = new ChildWindow
                                  {
                                      Content = GetViewForViewModel(viewModel)
                                  };
            childWindow.Closed += (s,e) => onClosed();
            childWindow.Show();
        }

        private UIElement GetViewForViewModel(ViewModelBase viewModel)
        {
            return null;
        }
    }
}