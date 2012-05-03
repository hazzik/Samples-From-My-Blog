namespace Application.DatePicker.Solution2
{
    using MvcExtensions;

    public class Form2Metadata : ModelMetadataConfiguration<Form2>
    {
        public Form2Metadata()
        {
            Configure(x => x.Date)
                .Template("DatePicker2");
        }
    }
}