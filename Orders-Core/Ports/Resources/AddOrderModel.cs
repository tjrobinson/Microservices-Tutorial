﻿using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Orders_Core.Ports.Resources
{
    [DataContract, XmlRoot]
    public class AddOrderModel
    {
        [DataMember(Name = "customerName"), XmlElement(ElementName = "customerName")]
        public string CustomerName { get; set; }
        [DataMember(Name = "description"), XmlElement(ElementName = "description")]
        public string Description { get; set; }
        [DataMember(Name = "dueDate"), XmlElement(ElementName = "dueDate")]
        public string DueDate { get; set; }
    }
}
