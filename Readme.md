# How to build binding paths within WPF Grid control rows 

Row elements contain [RowData](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.RowData) objects in their [DataContext](https://docs.microsoft.com/en-us/dotnet/api/system.windows.frameworkelement.datacontext). Use the following binding paths to access cell values and ViewModel properties:

* `Row.[YourPropertyName]` - accesses a property of an object in the [ItemsSource](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.DataControlBase.ItemsSource) collection (see [RowData.Row](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.RowData.Row));
* `DataContext.[FieldName]` - accesses column values in [Server Mode](https://docs.devexpress.com/WPF/9588/controls-and-libraries/data-grid/binding-to-data/server-mode), accesses [unbound column](https://docs.devexpress.com/WPF/6124/controls-and-libraries/data-grid/binding-to-data/unbound-columns) values (see [RowData.DataContext](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.RowData.DataContext));
* `View.DataContext.[YourPropertyName]` - accesses a property in the grid's ViewModel (see [RowDataBase.View](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.RowDataBase.View)).


The bindings we used in this example work as follows.

* Bind rows' `Background` to the `Color` properties stored at the item level:

```xml
<Trigger Property="SelectionState" Value="None">
    <Setter Property="Background" Value="{Binding Row.Color, Converter={dxmvvm:ColorToBrushConverter}}" />
</Trigger>
```

* Highlight a row when the `HighlightVisited` property of the grid's `ViewModel` and the `Visited` column value are `true`.

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

**See also:**

[How to build binding paths in GridControl cells](https://github.com/DevExpress-Examples/how-to-build-binding-paths-in-gridcontrol-cells)
