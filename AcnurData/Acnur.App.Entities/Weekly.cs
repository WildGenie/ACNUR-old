//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Acnur.App.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Serialization;
    
    
    /// <summary>
    /// DTO TabCuenta
    /// </summary>
    [System.Runtime.Serialization.DataContract(IsReference=true)]
    [Serializable]
    public partial class Weekly
    {
    
    	/// <summary>
        /// Atributo IdWeekly
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public int IdWeekly { get; set; }
    
    	/// <summary>
        /// Atributo IdWeeklyRequest
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public int IdWeeklyRequest { get; set; }
    
    	/// <summary>
        /// Atributo IdCharacteristic
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public int IdCharacteristic { get; set; }
    
    	/// <summary>
        /// Atributo IdSubCharacteristic
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public int IdSubCharacteristic { get; set; }
    
    	/// <summary>
        /// Atributo IdDepartament
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public int IdDepartament { get; set; }
    
    	/// <summary>
        /// Atributo IdMunicipality
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public int IdMunicipality { get; set; }
    
    	/// <summary>
        /// Atributo SubMunicipality
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public string SubMunicipality { get; set; }
    
    	/// <summary>
        /// Atributo Description
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public string Description { get; set; }
    
    
    	/// <summary>
        /// Atributo de agregacion ParameterDetail
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public virtual ParameterDetail ParameterDetail { get; set; }
    
    	/// <summary>
        /// Atributo de agregacion ParameterDetail1
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public virtual ParameterDetail ParameterDetail1 { get; set; }
    
    	/// <summary>
        /// Atributo de agregacion ParameterDetail2
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public virtual ParameterDetail ParameterDetail2 { get; set; }
    
    	/// <summary>
        /// Atributo de agregacion ParameterDetail3
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public virtual ParameterDetail ParameterDetail3 { get; set; }
    
    	/// <summary>
        /// Atributo de agregacion WeeklyRequest
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public virtual WeeklyRequest WeeklyRequest { get; set; }
    }
}
