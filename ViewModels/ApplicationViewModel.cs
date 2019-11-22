namespace DialogHostTest.ViewModels
{
    public class ApplicationViewModel : ViewModel
    {
        private bool canEdit;

        public bool CanEdit
        {
            get => this.canEdit;
            set => this.RaiseAndSetIfChanged(ref this.canEdit, value);
        }
    }
}
