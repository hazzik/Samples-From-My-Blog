namespace Application.DatePicker.Solution3
{
    using System;

    using MvcExtensions;

    public class Form3Metadata : ModelMetadataConfiguration<Form3>
    {
        public Form3Metadata()
        {
            Configure(x => x.Date1)
                .AsDatePicker(minDate: DateTime.Today);

            Configure(x => x.Date2)
                .AsDatePicker(maxDate: DateTime.Today);
        }
    }
}