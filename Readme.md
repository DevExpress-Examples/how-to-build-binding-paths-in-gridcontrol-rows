<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/287471692/18.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T925592)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Build Binding Paths in WPF Data Grid Rows

![image](https://user-images.githubusercontent.com/65009440/186901531-22e01bbd-0629-45ab-a34e-8b2f3e75f64e.png)

Row elements contain [RowData](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.RowData) objects in their [DataContext](https://docs.microsoft.com/en-us/dotnet/api/system.windows.frameworkelement.datacontext). Use the following binding paths to access cell values and ViewModel properties:

* `Row.[YourPropertyName]` - access a property of an object in the [ItemsSource](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.DataControlBase.ItemsSource) collection (see [RowData.Row](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.RowData.Row));
* `DataContext.[FieldName]` - access a column value in [Server Mode](https://docs.devexpress.com/WPF/9588/controls-and-libraries/data-grid/binding-to-data/server-mode), access an [unbound column](https://docs.devexpress.com/WPF/6124/controls-and-libraries/data-grid/binding-to-data/unbound-columns) value (see [RowData.DataContext](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.RowData.DataContext));
* `View.DataContext.[YourPropertyName]` - access a property in the grid's ViewModel (see [RowDataBase.View](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.RowDataBase.View)).


The bindings used in this example work as follows:

* Bind the row `Background` to the `Color` property stored at the item level:

```xml
<Trigger Property="SelectionState" Value="None">
    <Setter Property="Background" Value="{Binding Row.Color, Converter={dxmvvm:ColorToBrushConverter}}" />
</Trigger>
```

* Highlight a row when the `HighlightVisited` property of the grid's `ViewModel` and the `Visited` column value are `true`:

```xml
<MultiDataTrigger>
    <MultiDataTrigger.Conditions>
        <Condition Binding="{Binding View.DataContext.HighlightVisited}" Value="True" />
        <Condition Binding="{Binding DataContext.Visited}" Value="True" />
    </MultiDataTrigger.Conditions>
    <Setter Property="TextElement.FontStyle" Value="Italic" />
    <Setter Property="TextElement.FontWeight" Value="Bold" />
</MultiDataTrigger>
```

## Files to Look at

* [MainWindow.xaml](./CS/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/MainWindow.xaml.vb))

## Documentation

* [RowData](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.RowData)
* [TableView.RowStyle](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.TableView.RowStyle)
* [Choose Templates Based on Custom Logic](https://docs.devexpress.com/WPF/6677/controls-and-libraries/data-grid/appearance-customization/choosing-templates-based-on-custom-logic)

## More Examples

* [Build Binding Paths in WPF Data Grid Cells](https://github.com/DevExpress-Examples/how-to-build-binding-paths-in-gridcontrol-cells)
* [WPF Data Grid - Select a Row Template Based on Custom Logic](https://github.com/DevExpress-Examples/how-to-select-templates-based-on-custom-logic-e1667)
