# How to get the current dragging index during row drag and drop in .NET MAUI Datagrid (SfDataGrid) ?
In this article, we will show you how to get the current dragging index during row drag and drop in [.NET MAUI DataGrid](https://www.syncfusion.com/maui-controls/maui-datagrid).

## xaml
```
<ContentPage.BindingContext>
    <local:EmployeeViewModel x:Name="viewModel" />
</ContentPage.BindingContext>

<syncfusion:SfDataGrid x:Name="sfGrid" 
                       GridLinesVisibility="Both"
                       HeaderGridLinesVisibility="Both"
                       AllowDraggingRow="True"
                       ColumnWidthMode="Auto"
                       AutoGenerateColumnsMode="None"
                       AllowDraggingColumn="True"
                       QueryRowDragging="sfGrid_QueryRowDragging"
                       ItemsSource="{Binding Employees}">


    <syncfusion:SfDataGrid.Columns>
        <syncfusion:DataGridNumericColumn MappingName="EmployeeID"
                                          Format="#"
                                          HeaderText="Employee ID" />
        <syncfusion:DataGridTextColumn MappingName="Name"
                                       HeaderText="Employee Name" />
        <syncfusion:DataGridTextColumn MappingName="Title"
                                       HeaderText="Designation" />
        <syncfusion:DataGridDateColumn MappingName="HireDate"
                                       HeaderText="Hire Date" />

    </syncfusion:SfDataGrid.Columns>
</syncfusion:SfDataGrid>
``` 

## C#
The code below demonstrates how to get the current dragging index during row drag and drop in QueryRowDragging event.
```
private void sfGrid_QueryRowDragging(object sender, Syncfusion.Maui.DataGrid.DataGridQueryRowDraggingEventArgs e)
{
    var currrentDraggingIndex = e.From;
    if (e.DraggingAction == Syncfusion.Maui.DataGrid.DataGridDragAction.DragEnded)
    {
        DisplayAlert("CurrentDraggingIndex", $"CurrentDraggingIndex: {currrentDraggingIndex}", "ok");
    }
}
```

<img src="https://support.syncfusion.com/kb/agent/attachment/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjM0NzAwIiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.WvSkjOFu-bwuJI_xUX3d2ITNRvDOEmIcwhazxs2cCT0" width=700 />

[View sample in GitHub](https://github.com/SyncfusionExamples/How-to-get-the-current-dragging-index-during-row-drag-and-drop-in-.NET-MAUI-Datagrid-SfDataGrid)

Take a moment to explore this [documentation](https://help.syncfusion.com/maui/datagrid/overview), where you can find more information about Syncfusion .NET MAUI DataGrid (SfDataGrid) with code examples. Please refer to this [link](https://www.syncfusion.com/maui-controls/maui-datagrid) to learn about the essential features of Syncfusion .NET MAUI DataGrid (SfDataGrid).
 
##### Conclusion
 
I hope you enjoyed learning about how to get the current dragging index during row drag and drop in .NET MAUI DataGrid (SfDataGrid).
 
You can refer to our [.NET MAUI DataGrid’s feature tour](https://www.syncfusion.com/maui-controls/maui-datagrid) page to learn about its other groundbreaking feature representations. You can also explore our [.NET MAUI DataGrid Documentation](https://help.syncfusion.com/maui/datagrid/getting-started) to understand how to present and manipulate data. 
For current customers, you can check out our .NET MAUI components on the [License and Downloads](https://www.syncfusion.com/sales/teamlicense) page. If you are new to Syncfusion, you can try our 30-day [free trial](https://www.syncfusion.com/downloads/maui) to explore our .NET MAUI DataGrid and other .NET MAUI components.
 
If you have any queries or require clarifications, please let us know in the comments below. You can also contact us through our [support forums](https://www.syncfusion.com/forums), [Direct-Trac](https://support.syncfusion.com/create) or [feedback portal](https://www.syncfusion.com/feedback/maui?control=sfdatagrid), or the feedback portal. We are always happy to assist you!