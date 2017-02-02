// <auto-generated />
namespace Microsoft.AspNetCore.Mvc.Abstractions
{
    using System.Globalization;
    using System.Reflection;
    using System.Resources;

    internal static class Resources
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Microsoft.AspNetCore.Mvc.Abstractions.Resources", typeof(Resources).GetTypeInfo().Assembly);

        /// <summary>
        /// Value cannot be null or empty.
        /// </summary>
        internal static string ArgumentCannotBeNullOrEmpty
        {
            get { return GetString("ArgumentCannotBeNullOrEmpty"); }
        }

        /// <summary>
        /// Value cannot be null or empty.
        /// </summary>
        internal static string FormatArgumentCannotBeNullOrEmpty()
        {
            return GetString("ArgumentCannotBeNullOrEmpty");
        }

        /// <summary>
        /// The ModelMetadata property must be set before accessing this property.
        /// </summary>
        internal static string ModelBindingContext_ModelMetadataMustBeSet
        {
            get { return GetString("ModelBindingContext_ModelMetadataMustBeSet"); }
        }

        /// <summary>
        /// The ModelMetadata property must be set before accessing this property.
        /// </summary>
        internal static string FormatModelBindingContext_ModelMetadataMustBeSet()
        {
            return GetString("ModelBindingContext_ModelMetadataMustBeSet");
        }

        /// <summary>
        /// A field previously marked invalid should not be marked valid.
        /// </summary>
        internal static string Validation_InvalidFieldCannotBeReset
        {
            get { return GetString("Validation_InvalidFieldCannotBeReset"); }
        }

        /// <summary>
        /// A field previously marked invalid should not be marked valid.
        /// </summary>
        internal static string FormatValidation_InvalidFieldCannotBeReset()
        {
            return GetString("Validation_InvalidFieldCannotBeReset");
        }

        /// <summary>
        /// A field previously marked invalid should not be marked skipped.
        /// </summary>
        internal static string Validation_InvalidFieldCannotBeReset_ToSkipped
        {
            get { return GetString("Validation_InvalidFieldCannotBeReset_ToSkipped"); }
        }

        /// <summary>
        /// A field previously marked invalid should not be marked skipped.
        /// </summary>
        internal static string FormatValidation_InvalidFieldCannotBeReset_ToSkipped()
        {
            return GetString("Validation_InvalidFieldCannotBeReset_ToSkipped");
        }

        /// <summary>
        /// The maximum number of allowed model errors has been reached.
        /// </summary>
        internal static string ModelStateDictionary_MaxModelStateErrors
        {
            get { return GetString("ModelStateDictionary_MaxModelStateErrors"); }
        }

        /// <summary>
        /// The maximum number of allowed model errors has been reached.
        /// </summary>
        internal static string FormatModelStateDictionary_MaxModelStateErrors()
        {
            return GetString("ModelStateDictionary_MaxModelStateErrors");
        }

        /// <summary>
        /// Body
        /// </summary>
        internal static string BindingSource_Body
        {
            get { return GetString("BindingSource_Body"); }
        }

        /// <summary>
        /// Body
        /// </summary>
        internal static string FormatBindingSource_Body()
        {
            return GetString("BindingSource_Body");
        }

        /// <summary>
        /// Custom
        /// </summary>
        internal static string BindingSource_Custom
        {
            get { return GetString("BindingSource_Custom"); }
        }

        /// <summary>
        /// Custom
        /// </summary>
        internal static string FormatBindingSource_Custom()
        {
            return GetString("BindingSource_Custom");
        }

        /// <summary>
        /// Form
        /// </summary>
        internal static string BindingSource_Form
        {
            get { return GetString("BindingSource_Form"); }
        }

        /// <summary>
        /// Form
        /// </summary>
        internal static string FormatBindingSource_Form()
        {
            return GetString("BindingSource_Form");
        }

        /// <summary>
        /// Header
        /// </summary>
        internal static string BindingSource_Header
        {
            get { return GetString("BindingSource_Header"); }
        }

        /// <summary>
        /// Header
        /// </summary>
        internal static string FormatBindingSource_Header()
        {
            return GetString("BindingSource_Header");
        }

        /// <summary>
        /// Services
        /// </summary>
        internal static string BindingSource_Services
        {
            get { return GetString("BindingSource_Services"); }
        }

        /// <summary>
        /// Services
        /// </summary>
        internal static string FormatBindingSource_Services()
        {
            return GetString("BindingSource_Services");
        }

        /// <summary>
        /// Special
        /// </summary>
        internal static string BindingSource_Special
        {
            get { return GetString("BindingSource_Special"); }
        }

        /// <summary>
        /// Special
        /// </summary>
        internal static string FormatBindingSource_Special()
        {
            return GetString("BindingSource_Special");
        }

        /// <summary>
        /// ModelBinding
        /// </summary>
        internal static string BindingSource_ModelBinding
        {
            get { return GetString("BindingSource_ModelBinding"); }
        }

        /// <summary>
        /// ModelBinding
        /// </summary>
        internal static string FormatBindingSource_ModelBinding()
        {
            return GetString("BindingSource_ModelBinding");
        }

        /// <summary>
        /// Path
        /// </summary>
        internal static string BindingSource_Path
        {
            get { return GetString("BindingSource_Path"); }
        }

        /// <summary>
        /// Path
        /// </summary>
        internal static string FormatBindingSource_Path()
        {
            return GetString("BindingSource_Path");
        }

        /// <summary>
        /// Query
        /// </summary>
        internal static string BindingSource_Query
        {
            get { return GetString("BindingSource_Query"); }
        }

        /// <summary>
        /// Query
        /// </summary>
        internal static string FormatBindingSource_Query()
        {
            return GetString("BindingSource_Query");
        }

        /// <summary>
        /// The provided binding source '{0}' is a composite. '{1}' requires that the source must represent a single type of input.
        /// </summary>
        internal static string BindingSource_CannotBeComposite
        {
            get { return GetString("BindingSource_CannotBeComposite"); }
        }

        /// <summary>
        /// The provided binding source '{0}' is a composite. '{1}' requires that the source must represent a single type of input.
        /// </summary>
        internal static string FormatBindingSource_CannotBeComposite(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("BindingSource_CannotBeComposite"), p0, p1);
        }

        /// <summary>
        /// The provided binding source '{0}' is not a request-based binding source. '{1}' requires that the source must represent data from an HTTP request.
        /// </summary>
        internal static string BindingSource_MustBeFromRequest
        {
            get { return GetString("BindingSource_MustBeFromRequest"); }
        }

        /// <summary>
        /// The provided binding source '{0}' is not a request-based binding source. '{1}' requires that the source must represent data from an HTTP request.
        /// </summary>
        internal static string FormatBindingSource_MustBeFromRequest(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("BindingSource_MustBeFromRequest"), p0, p1);
        }

        /// <summary>
        /// The provided binding source '{0}' is a greedy data source. '{1}' does not support greedy data sources.
        /// </summary>
        internal static string BindingSource_CannotBeGreedy
        {
            get { return GetString("BindingSource_CannotBeGreedy"); }
        }

        /// <summary>
        /// The provided binding source '{0}' is a greedy data source. '{1}' does not support greedy data sources.
        /// </summary>
        internal static string FormatBindingSource_CannotBeGreedy(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("BindingSource_CannotBeGreedy"), p0, p1);
        }

        /// <summary>
        /// The provided binding source '{0}' is not a greedy data source. '{1}' only supports greedy data sources.
        /// </summary>
        internal static string BindingSource_MustBeGreedy
        {
            get { return GetString("BindingSource_MustBeGreedy"); }
        }

        /// <summary>
        /// The provided binding source '{0}' is not a greedy data source. '{1}' only supports greedy data sources.
        /// </summary>
        internal static string FormatBindingSource_MustBeGreedy(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("BindingSource_MustBeGreedy"), p0, p1);
        }

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);

            System.Diagnostics.Debug.Assert(value != null);

            if (formatterNames != null)
            {
                for (var i = 0; i < formatterNames.Length; i++)
                {
                    value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
                }
            }

            return value;
        }
    }
}
