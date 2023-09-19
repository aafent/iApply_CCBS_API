namespace iApplyShared.Attributes
{
    /// <summary>
    /// Used to allow the <see cref="iApplyShared.Core.RegisterService.RegisterServiceContracts">RegisterServiceContracts</see> and
    /// <see cref="iApplyShared.Core.ServiceBuilderExtensions.UseRegisteredSoapEndpoints">UseRegisteredSoapEndpoints</see> to
    /// setup the SOAP interfaces.
    /// <para>
    /// <br>The targed class must only implent a single interface, that of the data contract (interfaces implemented by inhereted classes do not count).</br>
    /// <br>If the above rule is not followed then the registration proccess will fail.</br>
    /// </para>
    ///
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class RegisterSoapServiceAttribute : Attribute
    {
        #region Public Constructors

        public RegisterSoapServiceAttribute()
        { }

        #endregion Public Constructors
    }
}