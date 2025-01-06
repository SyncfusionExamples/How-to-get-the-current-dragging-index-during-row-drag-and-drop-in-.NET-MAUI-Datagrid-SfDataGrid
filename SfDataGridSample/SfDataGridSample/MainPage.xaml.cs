namespace SfDataGridSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void sfGrid_QueryRowDragging(object sender, Syncfusion.Maui.DataGrid.DataGridQueryRowDraggingEventArgs e)
        {
            var currrentDraggingIndex = e.From;
            if (e.DraggingAction == Syncfusion.Maui.DataGrid.DataGridDragAction.DragEnded)
            {
                DisplayAlert("CurrentDraggingIndex", $"CurrentDraggingIndex: {currrentDraggingIndex}", "ok");
            }
        }
    }
}
