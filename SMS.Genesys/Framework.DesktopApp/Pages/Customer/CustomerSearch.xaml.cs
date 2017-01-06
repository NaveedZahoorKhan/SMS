﻿//-----------------------------------------------------------------------
// <copyright file="CustomerSearch.cs" company="Genesys Source">
//      Copyright (c) Genesys Source. All rights reserved.
//      All rights are reserved. Reproduction or transmission in whole or in part, in
//      any form or by any means, electronic, mechanical or otherwise, is prohibited
//      without the prior written consent of the copyright owner.
// </copyright>
//-----------------------------------------------------------------------
using Framework.Entity;
using Framework.UserControls;
using Framework.ViewModels;
using Genesys.Extensions;
using Genesys.Foundation.Process;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Framework.Pages
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class CustomerSearch : SaveablePage
    {
        /// <summary>
        /// Uri to this resource
        /// </summary>
        public static Uri Uri = new Uri("/Pages/Customer/CustomerSearch.xaml", UriKind.RelativeOrAbsolute);

        /// <summary>
        /// Controller route that handles requests for this page
        /// </summary>
        public override string ControllerName { get; } = "CustomerSearch";

        /// <summary>
        /// ViewModel holds model and is responsible for server calls, navigation, etc.
        /// </summary>
        public WpfViewModel<CustomerSearchModel> MyViewModel { get; } = new WpfViewModel<CustomerSearchModel>("CustomerSearch");

        /// <summary>
        /// Page and controls have been loaded
        /// </summary>
        /// <param name="sender">Sender of this event call</param>
        /// <param name="e">Event arguments</param>
        protected override void Page_Loaded(object sender, EventArgs e)
        {
            base.Page_Loaded(sender, e);
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public CustomerSearch()
        {
            InitializeComponent();
            TextID.KeyDown += MapEnterKey;
            TextFirstName.KeyDown += MapEnterKey;
            TextLastName.KeyDown += MapEnterKey;
            ListResults.MouseUp += ListView_MouseUp;
        }

        /// <summary>
        /// Handles click events on list
        /// </summary>
        /// <param name="sender">Event sender</param>
        /// <param name="e">Event args</param>
        private void ListView_MouseUp(object sender, MouseButtonEventArgs e)
        {
            int id = ListResults.SelectedItem.DirectCastSafe<CustomerModel>().ID;
            MyViewModel.Navigate(CustomerSummary.Uri, id, this.NavigationService);
        }

        /// <summary>
        /// Sets model data, binds to controls and handles event that introduce new model data to page
        /// </summary>
        /// <param name="sender">Sender of event</param>
        /// <param name="e">Event arguments</param>
        protected override void Page_ModelReceived(object sender, NewModelReceivedEventArgs e)
        {
            BindModel(MyViewModel.Model = new CustomerSearchModel());
        }

        /// <summary>
        /// Binds new model data to screen
        /// </summary>
        /// <param name="modelData"></param>
        protected override void BindModel(object modelData)
        {
            MyViewModel.Model = modelData.DirectCastSafe<CustomerSearchModel>();
            DataContext = MyViewModel.Model;
            //BindControl(ref this.TextID, MyViewModel.Model.ID.ToString(), "ID");
            BindControl(ref this.TextFirstName, MyViewModel.Model.FirstName, "FirstName");
            BindControl(ref this.TextLastName, MyViewModel.Model.LastName, "LastName");
        }

        /// <summary>
        /// Link actual XAML buttons to base class
        ///  A XAML template will eliminate need for this.
        /// </summary>
        protected override OkCancel OkCancel
        {
            get { return ButtonOkCancel; }
            set { ButtonOkCancel = value; }
        }

        public ObservableCollection<CustomerModel> Results { get; set; } = new ObservableCollection<CustomerModel>();

        /// <summary>
        /// Processes any page data via workflow
        /// </summary>
        public override async Task<ProcessResult> Process(object sender, RoutedEventArgs e)
        {
            var returnValue = new ProcessResult();
            string searchUri = String.Format("{0}/{1}/{2}?firstName={3}&lastName={4}", this.MyApplication.MyWebService, "CustomerSearch", MyViewModel.Model.ID, MyViewModel.Model.FirstName, MyViewModel.Model.LastName);
            BindModel(await MyViewModel.SendGetAsync<CustomerSearchModel>(searchUri));
            this.ListResults.ItemsSource = MyViewModel.Model.Results;
            if (this.MyViewModel.Model.Results.Count > 0)
            {
                OkCancel.TextSuccessful = "Customer matches listed below";
                this.StackResults.Visibility = Visibility.Visible;
            }
            else
            {
                OkCancel.TextSuccessful = "No results found";
                this.StackResults.Visibility = Visibility.Collapsed;
            }
            returnValue.ReturnData = this.MyViewModel.Model.Serialize();
            return returnValue;
        }

        /// <summary>
        /// Cancels the  and/or process
        /// </summary>
        /// <param name="sender">Sender of event</param>
        /// <param name="e">Event arguments</param>
        public override void Cancel(object sender, RoutedEventArgs e)
        {
            MyViewModel.GoBack();
        }
    }
}
