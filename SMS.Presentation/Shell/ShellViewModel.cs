﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
using Prism.Commands;


namespace SMS.Presentation
{
    class ShellViewModel
    {
        bool _isMainRibbonMinimized;
        bool _isServiceMessagePanelVisible;
        bool _isStatusBarVisible;

        public ShellViewModel()
        {
            /*            ProgressBeginRequest = new ProgressBeginRequest();
                        ProgressEndRequest = new ProgressEndRequest();*/
        }


        public String TestValue { get; set; }

        /// <summary>
        /// Service messages
        /// </summary>
        /*public ObservableCollection<ServiceMessage> ServiceMessages { get; set; }*/

        public RoutedCommand ClearMessages { get; set; }
        public RoutedCommand Exit { get; set; }
        public RoutedCommand ExecuteUpdate { get; set; }
        public RoutedCommand CheckForUpdate { get; set; }

        public DelegateCommand TestCommand { get; set; }
        /*public BackgroundCommand ExportGridToExcelWithStyle { get; set; }
        public BackgroundCommand ExportGridToExcelFast { get; set; }*/

        public string UserName { get; set; }
        public string ServerName { get; set; }
        public string BaseName { get; set; }

        /*public UpdateInfo UpdateInfo { get; set; }*/

        public bool IsFullScreen { get; set; }

        /* public bool IsMainRibbonMinimized
         {
             get { return _isMainRibbonMinimized; }
             set { OnPropertyChanged(ref _isMainRibbonMinimized, value, "IsMainRibbonMinimized"); }
         }        

         public bool IsServiceMessagePanelVisible
         {
             get { return _isServiceMessagePanelVisible; }
             set { OnPropertyChanged(ref _isServiceMessagePanelVisible, value, "IsServiceMessagePanelVisible"); }
         }

         public bool IsStatusBarVisible
         {
             get { return _isStatusBarVisible; }
             set { OnPropertyChanged(ref _isStatusBarVisible, value, "IsStatusBarVisible"); }
         }
 */

        /*public ProgressBeginRequest ProgressBeginRequest { get; private set; }
        public ProgressEndRequest ProgressEndRequest { get; private set; }

        public AbstractAsyncCommand AsyncCommand
        {
            get { return (AbstractAsyncCommand)GetValue(AsyncCommandProperty); }
            set { SetValue(AsyncCommandProperty, value); }
        }*/

        /*  public static readonly DependencyProperty AsyncCommandProperty =
              DependencyProperty.Register("AsyncCommand", typeof (AbstractAsyncCommand), typeof (ShellViewModel),
                  new UIPropertyMetadata(OnAsyncCommandChanged));*/


    }
}
