using iApplyShared.Attributes;

namespace iApply.CCBS.Shared.CCbsModels
{
    public class MockupModel
    {
        [Mockup(0)]
        public object MockupKey { get; set; }
    }
}
