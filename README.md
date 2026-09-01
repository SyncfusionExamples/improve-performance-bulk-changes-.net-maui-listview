# How to improve performance when doing bulk changes in .NET MAUI ListView (SfListView) ?

The [.NET MAUI ListView (SfListView)](https://www.syncfusion.com/maui-controls/maui-listview) offers a way to enhance performance when applying bulk changes to a bound collection. This can be achieved by suspending and resuming the refresh of the ListView using the [DataSource’s](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataSource.DataSource.html) [BeginInit](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataSource.DataSource.html#Syncfusion_Maui_DataSource_DataSource_BeginInit) and [EndInit](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataSource.DataSource.html#Syncfusion_Maui_DataSource_DataSource_EndInit) methods.

**Steps:**
1. Install [Refractored.MVVMHelpers](https://www.nuget.org/packages/Refractored.MvvmHelpers) NuGet package to utilize the [ObservableRangeCollection](https://github.com/jamesmontemagno/mvvm-helpers#observablerangecollection) within your project.
2. Create an ObservableRangeCollection in the ViewModel class.
3. Bind the ObservableRangeCollection to the [SfListView.ItemsSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemsSource) property.
4. Use the **AddRange** method to add items to your ViewModel collection, and apply the **BeginInit** and **EndInit** methods to update the UI efficiently.

Download the complete sample on [GitHub](https://github.com/SyncfusionExamples/improve-performance-bulk-changes-.net-maui-listview).

**Conclusion**

I hope you enjoyed learning how to improve performance when doing bulk changes in .NET MAUI ListView.

You can refer to our [.NET MAUI ListView feature tour](https://www.syncfusion.com/maui-controls/maui-listview) page to learn about its other groundbreaking feature representations and [documentation](https://help.syncfusion.com/maui/listview/getting-started), and how to quickly get started with configuration specifications. Explore our [.NET MAUI ListView example](https://github.com/syncfusion/maui-demos/tree/master/MAUI/ListView) to understand how to create and manipulate data.

For current customers, check out our components from the [License and Downloads](https://www.syncfusion.com/sales/teamlicense) page. If you are new to Syncfusion®, try our 30-day [free trial](https://www.syncfusion.com/downloads/maui) to check out our other controls.

Please let us know in the comments section if you have any queries or require clarification. Contact us through our [support forums](https://www.syncfusion.com/forums), [Direct-Trac](https://support.syncfusion.com/create), or [feedback portal](https://www.syncfusion.com/feedback/maui?control=sflistview). We are always happy to assist you!
