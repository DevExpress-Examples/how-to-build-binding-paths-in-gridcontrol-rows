# How to build binding paths in GridControl rows

Cell elements contain [RowData](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.RowData) objects in their [DataContext](https://docs.microsoft.com/en-us/dotnet/api/system.windows.frameworkelement.datacontext). Use the following binding paths to access cell values and ViewModel properties:
* `Row.[YourPropertyName]` - access a property of an object in the [ItemsSource](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.DataControlBase.ItemsSource) collection;
* `DataContext.[FieldName]` - access column values in [Server Mode](https://docs.devexpress.com/WPF/9588/controls-and-libraries/data-grid/binding-to-data/server-mode), access [unbound column](https://docs.devexpress.com/WPF/6124/controls-and-libraries/data-grid/binding-to-data/unbound-columns) values;
* `View.DataContext.[YourPropertyName]` - access a property in the grid's ViewModel.
