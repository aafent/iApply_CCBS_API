namespace iApplyShared.Attributes
{
    /// <summary>
    /// Used to mark a property or field as mockup key
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter,
        AllowMultiple = false)]
    public class MockupAttribute : Attribute
    {
        #region Public Constructors

        public MockupAttribute(int Key=1)
        { 
            this.Key=Key;
        }

        /// <summary>
        /// Mockup Key number. First key is the 1, second the 2 etc.
        /// </summary>
        public int Key { get; set; } =1;

        #endregion Public Constructors
    }
}