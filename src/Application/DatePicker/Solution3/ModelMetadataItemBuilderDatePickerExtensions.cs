namespace Application.DatePicker.Solution3
{
    using System;

    using MvcExtensions;

    public static class ModelMetadataItemBuilderDatePickerExtensions
    {
        public static ModelMetadataItemBuilder<T> AsDatePicker<T>(this ModelMetadataItemBuilder<T> self,
                                                                  DateTime? minDate = null,
                                                                  DateTime? maxDate = null)
        {
            self.Template("DatePicker3");

            var setting = self.Item.GetAdditionalSettingOrCreateNew<DatePickerSettings>();
            setting.MinDate = minDate;
            setting.MaxDate = maxDate;

            return self;
        }
    }
}