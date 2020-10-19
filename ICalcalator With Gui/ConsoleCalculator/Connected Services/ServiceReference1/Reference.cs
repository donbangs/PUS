﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleCalculator.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Complex", Namespace="http://schemas.datacontract.org/2004/07/ICalcalator")]
    [System.SerializableAttribute()]
    public partial class Complex : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double ImagValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double RealValueField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double ImagValue {
            get {
                return this.ImagValueField;
            }
            set {
                if ((this.ImagValueField.Equals(value) != true)) {
                    this.ImagValueField = value;
                    this.RaisePropertyChanged("ImagValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double RealValue {
            get {
                return this.RealValueField;
            }
            set {
                if ((this.RealValueField.Equals(value) != true)) {
                    this.RealValueField = value;
                    this.RaisePropertyChanged("RealValue");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ICalculator")]
    public interface ICalculator {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Add", ReplyAction="http://tempuri.org/ICalculator/AddResponse")]
        string Add(ConsoleCalculator.ServiceReference1.Complex Value1, ConsoleCalculator.ServiceReference1.Complex Value2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Add", ReplyAction="http://tempuri.org/ICalculator/AddResponse")]
        System.Threading.Tasks.Task<string> AddAsync(ConsoleCalculator.ServiceReference1.Complex Value1, ConsoleCalculator.ServiceReference1.Complex Value2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Subtraction", ReplyAction="http://tempuri.org/ICalculator/SubtractionResponse")]
        string Subtraction(ConsoleCalculator.ServiceReference1.Complex Value1, ConsoleCalculator.ServiceReference1.Complex Value2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Subtraction", ReplyAction="http://tempuri.org/ICalculator/SubtractionResponse")]
        System.Threading.Tasks.Task<string> SubtractionAsync(ConsoleCalculator.ServiceReference1.Complex Value1, ConsoleCalculator.ServiceReference1.Complex Value2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Multiply", ReplyAction="http://tempuri.org/ICalculator/MultiplyResponse")]
        string Multiply(ConsoleCalculator.ServiceReference1.Complex Value1, ConsoleCalculator.ServiceReference1.Complex Value2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Multiply", ReplyAction="http://tempuri.org/ICalculator/MultiplyResponse")]
        System.Threading.Tasks.Task<string> MultiplyAsync(ConsoleCalculator.ServiceReference1.Complex Value1, ConsoleCalculator.ServiceReference1.Complex Value2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Division", ReplyAction="http://tempuri.org/ICalculator/DivisionResponse")]
        string Division(ConsoleCalculator.ServiceReference1.Complex Value1, ConsoleCalculator.ServiceReference1.Complex Value2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Division", ReplyAction="http://tempuri.org/ICalculator/DivisionResponse")]
        System.Threading.Tasks.Task<string> DivisionAsync(ConsoleCalculator.ServiceReference1.Complex Value1, ConsoleCalculator.ServiceReference1.Complex Value2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Add2", ReplyAction="http://tempuri.org/ICalculator/Add2Response")]
        string Add2(double Value1, double Value2, double Value3, double Value4);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Add2", ReplyAction="http://tempuri.org/ICalculator/Add2Response")]
        System.Threading.Tasks.Task<string> Add2Async(double Value1, double Value2, double Value3, double Value4);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Subtraction2", ReplyAction="http://tempuri.org/ICalculator/Subtraction2Response")]
        string Subtraction2(double Value1, double Value2, double Value3, double Value4);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Subtraction2", ReplyAction="http://tempuri.org/ICalculator/Subtraction2Response")]
        System.Threading.Tasks.Task<string> Subtraction2Async(double Value1, double Value2, double Value3, double Value4);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Multiply2", ReplyAction="http://tempuri.org/ICalculator/Multiply2Response")]
        string Multiply2(double Value1, double Value2, double Value3, double Value4);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Multiply2", ReplyAction="http://tempuri.org/ICalculator/Multiply2Response")]
        System.Threading.Tasks.Task<string> Multiply2Async(double Value1, double Value2, double Value3, double Value4);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Division2", ReplyAction="http://tempuri.org/ICalculator/Division2Response")]
        string Division2(double Value1, double Value2, double Value3, double Value4);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Division2", ReplyAction="http://tempuri.org/ICalculator/Division2Response")]
        System.Threading.Tasks.Task<string> Division2Async(double Value1, double Value2, double Value3, double Value4);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalculatorChannel : ConsoleCalculator.ServiceReference1.ICalculator, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculatorClient : System.ServiceModel.ClientBase<ConsoleCalculator.ServiceReference1.ICalculator>, ConsoleCalculator.ServiceReference1.ICalculator {
        
        public CalculatorClient() {
        }
        
        public CalculatorClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculatorClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Add(ConsoleCalculator.ServiceReference1.Complex Value1, ConsoleCalculator.ServiceReference1.Complex Value2) {
            return base.Channel.Add(Value1, Value2);
        }
        
        public System.Threading.Tasks.Task<string> AddAsync(ConsoleCalculator.ServiceReference1.Complex Value1, ConsoleCalculator.ServiceReference1.Complex Value2) {
            return base.Channel.AddAsync(Value1, Value2);
        }
        
        public string Subtraction(ConsoleCalculator.ServiceReference1.Complex Value1, ConsoleCalculator.ServiceReference1.Complex Value2) {
            return base.Channel.Subtraction(Value1, Value2);
        }
        
        public System.Threading.Tasks.Task<string> SubtractionAsync(ConsoleCalculator.ServiceReference1.Complex Value1, ConsoleCalculator.ServiceReference1.Complex Value2) {
            return base.Channel.SubtractionAsync(Value1, Value2);
        }
        
        public string Multiply(ConsoleCalculator.ServiceReference1.Complex Value1, ConsoleCalculator.ServiceReference1.Complex Value2) {
            return base.Channel.Multiply(Value1, Value2);
        }
        
        public System.Threading.Tasks.Task<string> MultiplyAsync(ConsoleCalculator.ServiceReference1.Complex Value1, ConsoleCalculator.ServiceReference1.Complex Value2) {
            return base.Channel.MultiplyAsync(Value1, Value2);
        }
        
        public string Division(ConsoleCalculator.ServiceReference1.Complex Value1, ConsoleCalculator.ServiceReference1.Complex Value2) {
            return base.Channel.Division(Value1, Value2);
        }
        
        public System.Threading.Tasks.Task<string> DivisionAsync(ConsoleCalculator.ServiceReference1.Complex Value1, ConsoleCalculator.ServiceReference1.Complex Value2) {
            return base.Channel.DivisionAsync(Value1, Value2);
        }
        
        public string Add2(double Value1, double Value2, double Value3, double Value4) {
            return base.Channel.Add2(Value1, Value2, Value3, Value4);
        }
        
        public System.Threading.Tasks.Task<string> Add2Async(double Value1, double Value2, double Value3, double Value4) {
            return base.Channel.Add2Async(Value1, Value2, Value3, Value4);
        }
        
        public string Subtraction2(double Value1, double Value2, double Value3, double Value4) {
            return base.Channel.Subtraction2(Value1, Value2, Value3, Value4);
        }
        
        public System.Threading.Tasks.Task<string> Subtraction2Async(double Value1, double Value2, double Value3, double Value4) {
            return base.Channel.Subtraction2Async(Value1, Value2, Value3, Value4);
        }
        
        public string Multiply2(double Value1, double Value2, double Value3, double Value4) {
            return base.Channel.Multiply2(Value1, Value2, Value3, Value4);
        }
        
        public System.Threading.Tasks.Task<string> Multiply2Async(double Value1, double Value2, double Value3, double Value4) {
            return base.Channel.Multiply2Async(Value1, Value2, Value3, Value4);
        }
        
        public string Division2(double Value1, double Value2, double Value3, double Value4) {
            return base.Channel.Division2(Value1, Value2, Value3, Value4);
        }
        
        public System.Threading.Tasks.Task<string> Division2Async(double Value1, double Value2, double Value3, double Value4) {
            return base.Channel.Division2Async(Value1, Value2, Value3, Value4);
        }
    }
}
