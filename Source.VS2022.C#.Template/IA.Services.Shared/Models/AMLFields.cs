namespace IA.Shared.Models
{
    public class AMLFields
    {
        public string estTransLevel { get; set; }
        public string[] fundsSD { get; set; }
        //public string[] fundsSource { get; set; }
        //public string[] fundsDestination { get; set; }
        public string polExp { get; set; }
        public string[] repRisk { get; set; }
        public string[] busRelPurpose { get; set; }
        public string[] typeOfProduct { get; set; }
        public string clientStatus { get; set; }

        //public object this[string propertyName]
        //{
        //    get
        //    {
        //        Type mType = typeof(AMLFields);
        //        PropertyInfo? mInfo = mType.GetProperty(propertyName);
        //        return mInfo?.GetValue(this, null);
        //    }
        //    set
        //    {
        //        Type mType = typeof(AMLFields);
        //        PropertyInfo? mInfo = mType.GetProperty(propertyName);
        //        mInfo.SetValue(this,value, null);
        //    }
        //}
    }
}
