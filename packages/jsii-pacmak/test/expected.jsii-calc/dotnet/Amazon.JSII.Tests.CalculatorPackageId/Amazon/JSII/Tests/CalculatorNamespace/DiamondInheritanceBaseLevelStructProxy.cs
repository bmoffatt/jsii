using Amazon.JSII.Runtime.Deputy;

namespace Amazon.JSII.Tests.CalculatorNamespace
{
    /// <remarks>
    /// <strong>Stability</strong>: Experimental
    /// </remarks>
    [JsiiTypeProxy(nativeType: typeof(IDiamondInheritanceBaseLevelStruct), fullyQualifiedName: "jsii-calc.DiamondInheritanceBaseLevelStruct")]
    internal sealed class DiamondInheritanceBaseLevelStructProxy : DeputyBase, Amazon.JSII.Tests.CalculatorNamespace.IDiamondInheritanceBaseLevelStruct
    {
        private DiamondInheritanceBaseLevelStructProxy(ByRefValue reference): base(reference)
        {
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiProperty(name: "baseLevelProperty", typeJson: "{\"primitive\":\"string\"}")]
        public string BaseLevelProperty
        {
            get => GetInstanceProperty<string>();
        }
    }
}
