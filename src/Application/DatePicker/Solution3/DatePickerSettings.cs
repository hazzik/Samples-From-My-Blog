namespace Application.DatePicker.Solution3
{
    using System;

    using MvcExtensions;

    public class DatePickerSettings : IModelMetadataAdditionalSetting
    {
        public DateTime? MinDate { get; set; }
        public DateTime? MaxDate { get; set; }

        public object ToHtmlAttributes()
        {
            return new
                       {
                           role = "datepicker",
                           type = "date",
                           data_date_format = "dd.mm.yy",
                           data_min_date = string.Format("{0:dd.MM.yyyy}", MinDate),
                           data_max_date = string.Format("{0:dd.MM.yyyy}", MaxDate),
                       };
        }
    }
}