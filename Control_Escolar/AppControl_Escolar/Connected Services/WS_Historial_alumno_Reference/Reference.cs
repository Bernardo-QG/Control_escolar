﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppControl_Escolar.WS_Historial_alumno_Reference {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WS_Historial_alumno_Reference.WS_Historial_alumnoSoap")]
    public interface WS_Historial_alumnoSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SELECT_Historial_alumno", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet SELECT_Historial_alumno(string id, string nombre, string idProfesore, string idGrupo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SELECT_Historial_alumno", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> SELECT_Historial_alumnoAsync(string id, string nombre, string idProfesore, string idGrupo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UPDATE_Historial_alumno", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void UPDATE_Historial_alumno(int nIdAlumno, int nIdGrupo, int IdAlumno, int IdGrupo, double Calificacion, int Oportunidad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UPDATE_Historial_alumno", ReplyAction="*")]
        System.Threading.Tasks.Task UPDATE_Historial_alumnoAsync(int nIdAlumno, int nIdGrupo, int IdAlumno, int IdGrupo, double Calificacion, int Oportunidad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INSERT_Historial_alumno", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void INSERT_Historial_alumno(int IdAlumno, int IdGrupo, double Calificacion, int Oportunidad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INSERT_Historial_alumno", ReplyAction="*")]
        System.Threading.Tasks.Task INSERT_Historial_alumnoAsync(int IdAlumno, int IdGrupo, double Calificacion, int Oportunidad);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WS_Historial_alumnoSoapChannel : AppControl_Escolar.WS_Historial_alumno_Reference.WS_Historial_alumnoSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WS_Historial_alumnoSoapClient : System.ServiceModel.ClientBase<AppControl_Escolar.WS_Historial_alumno_Reference.WS_Historial_alumnoSoap>, AppControl_Escolar.WS_Historial_alumno_Reference.WS_Historial_alumnoSoap {
        
        public WS_Historial_alumnoSoapClient() {
        }
        
        public WS_Historial_alumnoSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WS_Historial_alumnoSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WS_Historial_alumnoSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WS_Historial_alumnoSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet SELECT_Historial_alumno(string id, string nombre, string idProfesore, string idGrupo) {
            return base.Channel.SELECT_Historial_alumno(id, nombre, idProfesore, idGrupo);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> SELECT_Historial_alumnoAsync(string id, string nombre, string idProfesore, string idGrupo) {
            return base.Channel.SELECT_Historial_alumnoAsync(id, nombre, idProfesore, idGrupo);
        }
        
        public void UPDATE_Historial_alumno(int nIdAlumno, int nIdGrupo, int IdAlumno, int IdGrupo, double Calificacion, int Oportunidad) {
            base.Channel.UPDATE_Historial_alumno(nIdAlumno, nIdGrupo, IdAlumno, IdGrupo, Calificacion, Oportunidad);
        }
        
        public System.Threading.Tasks.Task UPDATE_Historial_alumnoAsync(int nIdAlumno, int nIdGrupo, int IdAlumno, int IdGrupo, double Calificacion, int Oportunidad) {
            return base.Channel.UPDATE_Historial_alumnoAsync(nIdAlumno, nIdGrupo, IdAlumno, IdGrupo, Calificacion, Oportunidad);
        }
        
        public void INSERT_Historial_alumno(int IdAlumno, int IdGrupo, double Calificacion, int Oportunidad) {
            base.Channel.INSERT_Historial_alumno(IdAlumno, IdGrupo, Calificacion, Oportunidad);
        }
        
        public System.Threading.Tasks.Task INSERT_Historial_alumnoAsync(int IdAlumno, int IdGrupo, double Calificacion, int Oportunidad) {
            return base.Channel.INSERT_Historial_alumnoAsync(IdAlumno, IdGrupo, Calificacion, Oportunidad);
        }
    }
}