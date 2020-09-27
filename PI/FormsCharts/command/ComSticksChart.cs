﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PI
{
    public class ComSticksChart: ICommand
    {
        private ViewModelCharts Cvm;

        public ViewModelMainWindow MCvm;
        public ComSticksChart(ViewModelCharts vm, ViewModelMainWindow mvm)
        {
            Cvm = vm;
            MCvm = mvm;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            MCvm.UserControl = new UserControlChartFour();
        }
    }
}
