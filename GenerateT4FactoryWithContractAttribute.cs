using System;

namespace T4Factories
{
    /// <summary>
    /// This attribute tells the T4 template to automatically generate a factory for the type this attribute is applied to.
    /// </summary>
    public class GenerateT4FactoryWithContractAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateT4FactoryWithContractAttribute"/> class, telling the T4 template to automatically generate a factory for the type this attribute is applied to.
        /// </summary>
        /// <remarks>
        /// The contract type is assumed to be an interface with the same name as the target class (e.g. ContractType for Foo is IFoo).
        /// </remarks>
        public GenerateT4FactoryWithContractAttribute()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateT4FactoryWithContractAttribute"/> class, telling the T4 template to automatically generate a factory for the type this attribute is applied to.
        /// </summary>
        /// <param name="contractType">
        /// The interface representing the return value of the factory method.
        /// </param>
        public GenerateT4FactoryWithContractAttribute(Type contractType)
        {
            this.ContractType = contractType;
        }

        /// <summary>
        /// Gets the interface representing the return value of the factory method.
        /// </summary>
        public Type ContractType { get; private set; }
    }
}