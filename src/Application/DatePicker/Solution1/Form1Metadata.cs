namespace Application.DatePicker.Solution1
{
    using MvcExtensions;

    public class Form1Metadata : ModelMetadataConfiguration<Form1>
    {
        public Form1Metadata()
        {
            Configure(x => x.Date)
                .Template("DatePicker1");
        }
    }
}