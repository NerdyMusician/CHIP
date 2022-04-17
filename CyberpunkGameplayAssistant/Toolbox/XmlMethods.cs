using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Xml;
using System.Xml.Linq;

#pragma warning disable CS8602 // Dereference of a possibly null reference.
#pragma warning disable CS8603 // Possible null reference return.
#pragma warning disable CS8604 // Possible null reference argument.
namespace CyberpunkGameplayAssistant.Toolbox
{
    public static class XmlMethods
    {
        // Public Methods
        public static XElement ListToXml(IEnumerable itemList, string enumName = "")
        {
            string elementName = "";
            List<XElement> items = new();
            foreach (object item in itemList)
            {
                elementName = item.GetType().ToString().Split('.').Last();
                items.Add(new XElement(elementName));
                foreach (PropertyInfo propertyInfo in item.GetType().GetProperties())
                {
                    foreach (CustomAttributeData attr in propertyInfo.CustomAttributes)
                    {
                        if (attr.AttributeType.Name == "XmlSaveMode")
                        {
                            if (attr.ConstructorArguments[0].Value.ToString() == "0")
                            {
                                if (propertyInfo.GetValue(item, null) == null || string.IsNullOrEmpty(propertyInfo.GetValue(item, null).ToString())) { continue; } // don't write blanks to data
                                if (propertyInfo.PropertyType == typeof(bool)) { if (propertyInfo.GetValue(item, null).ToString() == "False") { continue; } } // don't write falses (bool default)
                                if (propertyInfo.PropertyType == typeof(int)) { if (propertyInfo.GetValue(item, null).ToString() == "0") { continue; } } // don't write zeroes (int default)
                                items.Last().Add(new XAttribute(propertyInfo.Name, (propertyInfo.GetValue(item, null) != null) ? propertyInfo.GetValue(item, null).ToString() : ""));
                            }
                            if (attr.ConstructorArguments[0].Value.ToString() == "1")
                            {
                                items.Last().Add(ListToXml(propertyInfo.GetValue(item, null) as IEnumerable, propertyInfo.Name));
                            }
                        }
                    }
                }
            }

            if (items.Count == 0) { return null; }
            return new XElement(elementName + "Set", items, new XAttribute("Name", enumName));

        }

        // Private Methods
        private static object SetObjectPropertiesFromNode(XmlNode node, object newObject)
        {
            foreach (PropertyInfo propertyInfo in newObject.GetType().GetProperties())
            {
                if (node.Attributes[propertyInfo.Name] != null)
                {
                    string value = node.Attributes[propertyInfo.Name].InnerText;
                    Type propType = propertyInfo.PropertyType;
                    if (propType == typeof(int)) { propertyInfo.SetValue(newObject, Convert.ToInt32(value)); }
                    if (propType == typeof(decimal)) { propertyInfo.SetValue(newObject, Convert.ToDecimal(value)); }
                    if (propType == typeof(bool)) { propertyInfo.SetValue(newObject, Convert.ToBoolean(value)); }
                    if (propType == typeof(long)) { propertyInfo.SetValue(newObject, Convert.ToInt64(value)); }
                    if (propType == typeof(string)) { propertyInfo.SetValue(newObject, value); }
                }
            }
            return newObject;
        }
        private static XmlNodeList GetXmlNodeListFromXmlDoc(string filePath, string setName, XmlDocument xmlDoc)
        {
            XmlNodeList xmlNodes;
            if (xmlDoc == null)
            {
                xmlDoc = new XmlDocument();
                xmlDoc.Load(filePath);
                if (xmlDoc.ChildNodes[1].Name != setName)
                {
                    HelperMethods.WriteToLogFile($"Invalid XML for Import: {filePath}", true);
                    return null;
                }
                xmlNodes = xmlDoc.ChildNodes[1].ChildNodes;
            }
            else
            {
                xmlNodes = xmlDoc.ChildNodes[0].ChildNodes;
            }
            return xmlNodes;
        }

    }
}
#pragma warning restore CS8602 // Dereference of a possibly null reference.
#pragma warning restore CS8603 // Possible null reference return.
#pragma warning restore CS8604 // Possible null reference argument.
