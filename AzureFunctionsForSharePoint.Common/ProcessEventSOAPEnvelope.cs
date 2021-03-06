﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;

namespace AzureFunctionsForSharePoint.Common.ProcessEvent
{
// 
// This source code was auto-generated by xsd, Version=4.6.1055.0.
// 


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true,
        Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.xmlsoap.org/soap/envelope/",
        IsNullable = false)]
    public partial class Envelope
    {

        private EnvelopeBody[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Body")]
        public EnvelopeBody[] Items
        {
            get { return this.itemsField; }
            set { this.itemsField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true,
        Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public partial class EnvelopeBody
    {

        private ProcessEventProperties[] processEventField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Namespace = "http://schemas.microsoft.com/sharepoint/remoteapp/")]
        [System.Xml.Serialization.XmlArrayItemAttribute("properties", IsNullable = false)]
        public ProcessEventProperties[] ProcessEvent
        {
            get { return this.processEventField; }
            set { this.processEventField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true,
        Namespace = "http://schemas.microsoft.com/sharepoint/remoteapp/")]
    public partial class ProcessEventProperties
    {

        private ProcessEventPropertiesAppEventProperties[] appEventPropertiesField;

        private string contextTokenField;

        private string correlationIdField;

        private string cultureLCIDField;

        private ProcessEventPropertiesInstanceEventProperties[] entityInstanceEventPropertiesField;

        private string errorCodeField;

        private string errorMessageField;

        private string eventTypeField;

        private ProcessEventPropertiesListEventProperties[] listEventPropertiesField;

        private ProcessEventPropertiesSecurityEventProperties[] securityEventPropertiesField;

        private string uICultureLCIDField;

        private ProcessEventPropertiesWebEventProperties[] webEventPropertiesField;

        private ProcessEventPropertiesItemEventProperties[] itemEventPropertiesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AppEventProperties")]
        public ProcessEventPropertiesAppEventProperties[] AppEventProperties
        {
            get { return this.appEventPropertiesField; }
            set { this.appEventPropertiesField = value; }
        }

        /// <remarks/>
        public string ContextToken
        {
            get { return this.contextTokenField; }
            set { this.contextTokenField = value; }
        }

        /// <remarks/>
        public string CorrelationId
        {
            get { return this.correlationIdField; }
            set { this.correlationIdField = value; }
        }

        /// <remarks/>
        public string CultureLCID
        {
            get { return this.cultureLCIDField; }
            set { this.cultureLCIDField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EntityInstanceEventProperties")]
        public ProcessEventPropertiesInstanceEventProperties[] EntityInstanceEventProperties
        {
            get { return this.entityInstanceEventPropertiesField; }
            set { this.entityInstanceEventPropertiesField = value; }
        }

        /// <remarks/>
        public string ErrorCode
        {
            get { return this.errorCodeField; }
            set { this.errorCodeField = value; }
        }

        /// <remarks/>
        public string ErrorMessage
        {
            get { return this.errorMessageField; }
            set { this.errorMessageField = value; }
        }

        /// <remarks/>
        public string EventType
        {
            get { return this.eventTypeField; }
            set { this.eventTypeField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ListEventProperties")]
        public ProcessEventPropertiesListEventProperties[] ListEventProperties
        {
            get { return this.listEventPropertiesField; }
            set { this.listEventPropertiesField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SecurityEventProperties")]
        public ProcessEventPropertiesSecurityEventProperties[] SecurityEventProperties
        {
            get { return this.securityEventPropertiesField; }
            set { this.securityEventPropertiesField = value; }
        }

        /// <remarks/>
        public string UICultureLCID
        {
            get { return this.uICultureLCIDField; }
            set { this.uICultureLCIDField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("WebEventProperties")]
        public ProcessEventPropertiesWebEventProperties[] WebEventProperties
        {
            get { return this.webEventPropertiesField; }
            set { this.webEventPropertiesField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemEventProperties")]
        public ProcessEventPropertiesItemEventProperties[] ItemEventProperties
        {
            get { return this.itemEventPropertiesField; }
            set { this.itemEventPropertiesField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true,
        Namespace = "http://schemas.microsoft.com/sharepoint/remoteapp/")]
    public partial class ProcessEventPropertiesListEventProperties
    {

        private string featureIdField;

        private string fieldNameField;

        private string fieldXmlField;

        private string listIdField;

        private string listTitleField;

        private string templateIdField;

        private string webUrlField;

        /// <remarks/>
        public string FeatureId
        {
            get { return this.featureIdField; }
            set { this.featureIdField = value; }
        }

        /// <remarks/>
        public string FieldName
        {
            get { return this.fieldNameField; }
            set { this.fieldNameField = value; }
        }

        /// <remarks/>
        public string FieldXml
        {
            get { return this.fieldXmlField; }
            set { this.fieldXmlField = value; }
        }

        /// <remarks/>
        public string ListId
        {
            get { return this.listIdField; }
            set { this.listIdField = value; }
        }

        /// <remarks/>
        public string ListTitle
        {
            get { return this.listTitleField; }
            set { this.listTitleField = value; }
        }

        /// <remarks/>
        public string TemplateId
        {
            get { return this.templateIdField; }
            set { this.templateIdField = value; }
        }

        /// <remarks/>
        public string WebUrl
        {
            get { return this.webUrlField; }
            set { this.webUrlField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true,
        Namespace = "http://schemas.microsoft.com/sharepoint/remoteapp/")]
    public class ProcessEventPropertiesAppEventProperties
    {
        public string HostWebFullUrl { get; set; }
        public string AppWebFullUrl { get; set; }
        public Version Version { get; set; }
        public Version PreviousVersion { get; set; }
        public Guid ProductId { get; set; }
        public string AssetId { get; set; }
        public string ContentMarket { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true,
        Namespace = "http://schemas.microsoft.com/sharepoint/remoteapp/")]
    public class ProcessEventPropertiesInstanceEventProperties
    {
        public string EntityName { get; set; }
        public string EntityNamespace { get; set; }
        public string NotificationContext { get; set; }
        public string LobSystemInstanceName { get; set; }
        public byte[] NotificationMessage { get; set; }
    }

    public class ProcessEventPropertiesSecurityEventProperties
    {
        public string UserDisplayName { get; set; }
        public string UserLoginName { get; set; }
        public Guid WebId { get; set; }
        public string WebFullUrl { get; set; }
        public string GroupName { get; set; }
        public int GroupId { get; set; }
        public int GroupOwnerId { get; set; }
        public int GroupNewOwnerId { get; set; }
        public int GroupUserId { get; set; }
        public string GroupUserLoginName { get; set; }
        public string RoleDefinitionName { get; set; }
        public ulong RoleDefinitionPermissions { get; set; }
        public int RoleDefinitionId { get; set; }
        public int ObjectType { get; set; }
        public string ScopeUrl { get; set; }
        public int PrincipalId { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true,
        Namespace = "http://schemas.microsoft.com/sharepoint/remoteapp/")]
    public partial class ProcessEventPropertiesWebEventProperties
    {

        private string fullUrlField;

        private string newServerRelativeUrlField;

        private string serverRelativeUrlField;

        /// <remarks/>
        public string FullUrl
        {
            get { return this.fullUrlField; }
            set { this.fullUrlField = value; }
        }

        /// <remarks/>
        public string NewServerRelativeUrl
        {
            get { return this.newServerRelativeUrlField; }
            set { this.newServerRelativeUrlField = value; }
        }

        /// <remarks/>
        public string ServerRelativeUrl
        {
            get { return this.serverRelativeUrlField; }
            set { this.serverRelativeUrlField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true,
        Namespace = "http://schemas.microsoft.com/sharepoint/remoteapp/")]
    public partial class ProcessEventPropertiesItemEventProperties
    {

        private string afterUrlField;

        private ProcessEventPropertiesItemEventPropertiesBeforeProperties[] beforePropertiesField;

        private string beforeUrlField;

        private string currentUserIdField;

        private string externalNotificationMessageField;

        private string isBackgroundSaveField;

        private string listIdField;

        private string listItemIdField;

        private string listTitleField;

        private string userDisplayNameField;

        private string userLoginNameField;

        private string versionlessField;

        private string webUrlField;

        private ProcessEventPropertiesItemEventPropertiesAfterProperties[] afterPropertiesField;

        /// <remarks/>
        public string AfterUrl
        {
            get { return this.afterUrlField; }
            set { this.afterUrlField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BeforeProperties")]
        public ProcessEventPropertiesItemEventPropertiesBeforeProperties[] BeforeProperties
        {
            get { return this.beforePropertiesField; }
            set { this.beforePropertiesField = value; }
        }

        /// <remarks/>
        public string BeforeUrl
        {
            get { return this.beforeUrlField; }
            set { this.beforeUrlField = value; }
        }

        /// <remarks/>
        public string CurrentUserId
        {
            get { return this.currentUserIdField; }
            set { this.currentUserIdField = value; }
        }

        /// <remarks/>
        public string ExternalNotificationMessage
        {
            get { return this.externalNotificationMessageField; }
            set { this.externalNotificationMessageField = value; }
        }

        /// <remarks/>
        public string IsBackgroundSave
        {
            get { return this.isBackgroundSaveField; }
            set { this.isBackgroundSaveField = value; }
        }

        /// <remarks/>
        public string ListId
        {
            get { return this.listIdField; }
            set { this.listIdField = value; }
        }

        /// <remarks/>
        public string ListItemId
        {
            get { return this.listItemIdField; }
            set { this.listItemIdField = value; }
        }

        /// <remarks/>
        public string ListTitle
        {
            get { return this.listTitleField; }
            set { this.listTitleField = value; }
        }

        /// <remarks/>
        public string UserDisplayName
        {
            get { return this.userDisplayNameField; }
            set { this.userDisplayNameField = value; }
        }

        /// <remarks/>
        public string UserLoginName
        {
            get { return this.userLoginNameField; }
            set { this.userLoginNameField = value; }
        }

        /// <remarks/>
        public string Versionless
        {
            get { return this.versionlessField; }
            set { this.versionlessField = value; }
        }

        /// <remarks/>
        public string WebUrl
        {
            get { return this.webUrlField; }
            set { this.webUrlField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AfterProperties")]
        public ProcessEventPropertiesItemEventPropertiesAfterProperties[] AfterProperties
        {
            get { return this.afterPropertiesField; }
            set { this.afterPropertiesField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true,
        Namespace = "http://schemas.microsoft.com/sharepoint/remoteapp/")]
    public partial class ProcessEventPropertiesItemEventPropertiesBeforeProperties
    {

        private KeyValueOfstringanyType keyValueOfstringanyTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(
            Namespace = "http://schemas.microsoft.com/2003/10/Serialization/Arrays")]
        public KeyValueOfstringanyType KeyValueOfstringanyType
        {
            get { return this.keyValueOfstringanyTypeField; }
            set { this.keyValueOfstringanyTypeField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true,
        Namespace = "http://schemas.microsoft.com/2003/10/Serialization/Arrays")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/2003/10/Serialization/Arrays",
        IsNullable = false)]
    public partial class KeyValueOfstringanyType
    {

        private string keyField;

        private string valueField;

        /// <remarks/>
        public string Key
        {
            get { return this.keyField; }
            set { this.keyField = value; }
        }

        /// <remarks/>
        public string Value
        {
            get { return this.valueField; }
            set { this.valueField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true,
        Namespace = "http://schemas.microsoft.com/sharepoint/remoteapp/")]
    public partial class ProcessEventPropertiesItemEventPropertiesAfterProperties
    {

        private KeyValueOfstringanyType keyValueOfstringanyTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(
            Namespace = "http://schemas.microsoft.com/2003/10/Serialization/Arrays")]
        public KeyValueOfstringanyType KeyValueOfstringanyType
        {
            get { return this.keyValueOfstringanyTypeField; }
            set { this.keyValueOfstringanyTypeField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true,
        Namespace = "http://schemas.microsoft.com/sharepoint/remoteapp/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/sharepoint/remoteapp/",
        IsNullable = false)]
    public partial class ProcessEvent
    {

        private ProcessEventProperties[] propertiesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("properties")]
        public ProcessEventProperties[] properties
        {
            get { return this.propertiesField; }
            set { this.propertiesField = value; }
        }
    }
}