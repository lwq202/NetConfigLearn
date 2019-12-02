namespace ConsoleCodeFirst
{

    public class Rootobject
    {
        public string sl_translate { get; set; }
        public Group[] groups { get; set; }
    }

    public class Group
    {
        public string categoryName { get; set; }
        public string displayName { get; set; }
        public string displayNameNotTranslated { get; set; }
        public object description { get; set; }
        public object[] subGroups { get; set; }
        public Fieldmapping[] fieldMappings { get; set; }
    }

    public class Fieldmapping
    {
        public string fieldKey { get; set; }
        public string categoryName { get; set; }
        public string categoryDisplayName { get; set; }
        public string categoryDisplayNameNotTranslated { get; set; }
        public string name { get; set; }
        public string displayName { get; set; }
        public string displayNameNotTranslated { get; set; }
        public string description { get; set; }
        public string example { get; set; }
        public int varyByEnum { get; set; }
        public string varyBy { get; set; }
        public string targetFieldName { get; set; }
        public bool isTargetSelector { get; set; }
        public bool multipleValues { get; set; }
        public string multipleValuesDelimiter { get; set; }
        public Allowedvalue[] allowedValues { get; set; }
        public bool allowedValuesTruncated { get; set; }
        public bool restricted { get; set; }
        public Expression expression { get; set; }
        public int priorityEnum { get; set; }
        public string priority { get; set; }
        public int compressedFieldCount { get; set; }
        public bool compressedFieldsAllVaryByGroup { get; set; }
        public bool disabled { get; set; }
        public int maxLength { get; set; }
        public bool setBySystem { get; set; }
        public bool allowIfBlank { get; set; }
        public bool allowIfTooLong { get; set; }
        public object preview { get; set; }
        public string relatedFieldName { get; set; }
        public bool isDescriptionField { get; set; }
    }

    public class Expression
    {
        public int typeEnum { get; set; }
        public string type { get; set; }
        public string attributeName { get; set; }
        public object ifBlankAttributeName { get; set; }
        public object ifTooLongFallback { get; set; }
        public object text { get; set; }
        public object ruleId { get; set; }
        public object lookupListName { get; set; }
        public bool expand { get; set; }
        public object descriptionTemplateId { get; set; }
        public object inlineRule { get; set; }
    }

    public class Allowedvalue
    {
        public string label { get; set; }
        public string value { get; set; }
    }

}
