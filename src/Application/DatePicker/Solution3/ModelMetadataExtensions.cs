namespace Application.DatePicker.Solution3
{
    using System.Web.Mvc;

    using MvcExtensions;

    public static class ModelMetadataExtensions
    {
        public static T GetAdditionalSettingOrCreateNew<T>(this ModelMetadata self) where T : class, IModelMetadataAdditionalSetting, new()
        {
            var extended = self as ExtendedModelMetadata;
            if (extended == null)
            {
                return new T();
            }

            return extended.Metadata.GetAdditionalSettingOrCreateNew<T>();
        }
    }
}