﻿namespace System.Web.Services.Description
{
    using System;
    using System.Runtime;
    using System.Web.Services.Configuration;
    using System.Xml;
    using System.Xml.Serialization;

    [XmlFormatExtensionPoint("Extensions")]
    public sealed class Binding : NamedItem
    {
        private ServiceDescriptionFormatExtensionCollection extensions;
        private OperationBindingCollection operations;
        private System.Web.Services.Description.ServiceDescription parent;
        private XmlQualifiedName type = XmlQualifiedName.Empty;

        internal void SetParent(System.Web.Services.Description.ServiceDescription parent)
        {
            this.parent = parent;
        }

        [XmlIgnore]
        public override ServiceDescriptionFormatExtensionCollection Extensions
        {
            get
            {
                if (this.extensions == null)
                {
                    this.extensions = new ServiceDescriptionFormatExtensionCollection(this);
                }
                return this.extensions;
            }
        }

        [XmlElement("operation")]
        public OperationBindingCollection Operations
        {
            get
            {
                if (this.operations == null)
                {
                    this.operations = new OperationBindingCollection(this);
                }
                return this.operations;
            }
        }

        public System.Web.Services.Description.ServiceDescription ServiceDescription
        {
            [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
            get
            {
                return this.parent;
            }
        }

        [XmlAttribute("type")]
        public XmlQualifiedName Type
        {
            get
            {
                if (this.type == null)
                {
                    return XmlQualifiedName.Empty;
                }
                return this.type;
            }
            [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
            set
            {
                this.type = value;
            }
        }
    }
}

