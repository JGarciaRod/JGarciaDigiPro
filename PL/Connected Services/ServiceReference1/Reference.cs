﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PL.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Result", Namespace="http://schemas.datacontract.org/2004/07/SL_WCF")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(System.Exception))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(object[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ML.Alumnos))]
    public partial class Result : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool CorrectField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorMassageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Exception ExField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private object ObjectField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private object[] ObjectsField;
        
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
        public bool Correct {
            get {
                return this.CorrectField;
            }
            set {
                if ((this.CorrectField.Equals(value) != true)) {
                    this.CorrectField = value;
                    this.RaisePropertyChanged("Correct");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ErrorMassage {
            get {
                return this.ErrorMassageField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorMassageField, value) != true)) {
                    this.ErrorMassageField = value;
                    this.RaisePropertyChanged("ErrorMassage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Exception Ex {
            get {
                return this.ExField;
            }
            set {
                if ((object.ReferenceEquals(this.ExField, value) != true)) {
                    this.ExField = value;
                    this.RaisePropertyChanged("Ex");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public object Object {
            get {
                return this.ObjectField;
            }
            set {
                if ((object.ReferenceEquals(this.ObjectField, value) != true)) {
                    this.ObjectField = value;
                    this.RaisePropertyChanged("Object");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public object[] Objects {
            get {
                return this.ObjectsField;
            }
            set {
                if ((object.ReferenceEquals(this.ObjectsField, value) != true)) {
                    this.ObjectsField = value;
                    this.RaisePropertyChanged("Objects");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IAlumnoOperation")]
    public interface IAlumnoOperation {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAlumnoOperation/Add", ReplyAction="http://tempuri.org/IAlumnoOperation/AddResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Exception))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PL.ServiceReference1.Result))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        PL.ServiceReference1.Result Add(ML.Alumnos alumnos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAlumnoOperation/Add", ReplyAction="http://tempuri.org/IAlumnoOperation/AddResponse")]
        System.Threading.Tasks.Task<PL.ServiceReference1.Result> AddAsync(ML.Alumnos alumnos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAlumnoOperation/Update", ReplyAction="http://tempuri.org/IAlumnoOperation/UpdateResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Exception))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PL.ServiceReference1.Result))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        PL.ServiceReference1.Result Update(ML.Alumnos alumnos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAlumnoOperation/Update", ReplyAction="http://tempuri.org/IAlumnoOperation/UpdateResponse")]
        System.Threading.Tasks.Task<PL.ServiceReference1.Result> UpdateAsync(ML.Alumnos alumnos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAlumnoOperation/Delete", ReplyAction="http://tempuri.org/IAlumnoOperation/DeleteResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Exception))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PL.ServiceReference1.Result))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        PL.ServiceReference1.Result Delete(ML.Alumnos alumnos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAlumnoOperation/Delete", ReplyAction="http://tempuri.org/IAlumnoOperation/DeleteResponse")]
        System.Threading.Tasks.Task<PL.ServiceReference1.Result> DeleteAsync(ML.Alumnos alumnos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAlumnoOperation/GetAll", ReplyAction="http://tempuri.org/IAlumnoOperation/GetAllResponse")]
        PL.ServiceReference1.Result GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAlumnoOperation/GetAll", ReplyAction="http://tempuri.org/IAlumnoOperation/GetAllResponse")]
        System.Threading.Tasks.Task<PL.ServiceReference1.Result> GetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAlumnoOperation/GetById", ReplyAction="http://tempuri.org/IAlumnoOperation/GetByIdResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Exception))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PL.ServiceReference1.Result))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        PL.ServiceReference1.Result GetById(ML.Alumnos alumnos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAlumnoOperation/GetById", ReplyAction="http://tempuri.org/IAlumnoOperation/GetByIdResponse")]
        System.Threading.Tasks.Task<PL.ServiceReference1.Result> GetByIdAsync(ML.Alumnos alumnos);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAlumnoOperationChannel : PL.ServiceReference1.IAlumnoOperation, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AlumnoOperationClient : System.ServiceModel.ClientBase<PL.ServiceReference1.IAlumnoOperation>, PL.ServiceReference1.IAlumnoOperation {
        
        public AlumnoOperationClient() {
        }
        
        public AlumnoOperationClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AlumnoOperationClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AlumnoOperationClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AlumnoOperationClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public PL.ServiceReference1.Result Add(ML.Alumnos alumnos) {
            return base.Channel.Add(alumnos);
        }
        
        public System.Threading.Tasks.Task<PL.ServiceReference1.Result> AddAsync(ML.Alumnos alumnos) {
            return base.Channel.AddAsync(alumnos);
        }
        
        public PL.ServiceReference1.Result Update(ML.Alumnos alumnos) {
            return base.Channel.Update(alumnos);
        }
        
        public System.Threading.Tasks.Task<PL.ServiceReference1.Result> UpdateAsync(ML.Alumnos alumnos) {
            return base.Channel.UpdateAsync(alumnos);
        }
        
        public PL.ServiceReference1.Result Delete(ML.Alumnos alumnos) {
            return base.Channel.Delete(alumnos);
        }
        
        public System.Threading.Tasks.Task<PL.ServiceReference1.Result> DeleteAsync(ML.Alumnos alumnos) {
            return base.Channel.DeleteAsync(alumnos);
        }
        
        public PL.ServiceReference1.Result GetAll() {
            return base.Channel.GetAll();
        }
        
        public System.Threading.Tasks.Task<PL.ServiceReference1.Result> GetAllAsync() {
            return base.Channel.GetAllAsync();
        }
        
        public PL.ServiceReference1.Result GetById(ML.Alumnos alumnos) {
            return base.Channel.GetById(alumnos);
        }
        
        public System.Threading.Tasks.Task<PL.ServiceReference1.Result> GetByIdAsync(ML.Alumnos alumnos) {
            return base.Channel.GetByIdAsync(alumnos);
        }
    }
}
