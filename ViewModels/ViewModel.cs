namespace DialogHostTest.ViewModels
{
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    public abstract class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected bool RaiseAndSetIfChanged<TRet>(ref TRet backingField, TRet newValue, [CallerMemberName] string propertyName = null)
        {
            if (backingField != null && backingField.Equals(newValue) && !IsEnumAndHasDefaultValue(newValue))
            {
                return false;
            }

            var oldValue = backingField;

            backingField = newValue;

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

            return true;
        }

        private bool IsEnumAndHasDefaultValue<TRet>(TRet newValue)
        {
            return typeof(TRet).IsEnum && default(TRet).Equals(newValue);
        }
    }
}
