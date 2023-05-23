using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.IO;
using System.Collections;
using System.Text.RegularExpressions;
using System.Xml;
using BuenosAires.Model;

public static class Util
{
    public static Type GetStaticType(object obj)
    {
        Type objType = null;

        if (obj.GetType().FullName.Contains("System.Data.Entity.DynamicProxies"))
        {
            objType = Type.GetType(obj.GetType().BaseType.FullName + ", " + obj.GetType().BaseType.Assembly);
        }
        else
        {
            objType = obj.GetType();
        }

        return objType;
    }

    public static object GetStaticObject(object obj)
    {
        var objInstance = Activator.CreateInstance(GetStaticType(obj));
        return objInstance;
    }

    public static string SerializarXML(object obj)
    {
        if (obj == null) return null;

        Type objType = GetStaticType(obj);
        var serializer = new XmlSerializer(objType);

        using (var writer = new StringWriter())
        {
            var newObj = GetStaticObject(obj);
            CopiarPropiedades(obj, newObj);
            serializer.Serialize(writer, newObj);
            string xml = writer.ToString();
            return xml;
        }
    }

    public static T DeserializarXML<T>(string xml)
    {
        if (string.IsNullOrEmpty(xml)) return default(T);
        var serializer = new XmlSerializer(typeof(T));
        using (var reader = new StringReader(xml))
        {
            return (T)serializer.Deserialize(reader);
        }
    }

    public static bool CopiarPropiedades(object objetoOrigen, object objetoDestino)
    {
        if (objetoOrigen == null) return false;
        Type tipo = null;
        PropertyInfo[] propiedades = null;
        tipo = objetoOrigen.GetType();
        propiedades = tipo.GetProperties();
        if (tipo.Name == "List`1")
        {
            foreach (var item in (IList)objetoOrigen)
            {
                if (item.GetType().FullName.Contains("System.Data.Entity.DynamicProxies"))
                {
                    var newItem = Activator.CreateInstance(Type.GetType(item.GetType().BaseType.FullName + ", " + item.GetType().BaseType.Assembly));
                    CopiarPropiedades(item, newItem);
                    ((IList)objetoDestino).Add(newItem);
                }
                else
                {
                    var newItem = Activator.CreateInstance(item.GetType());
                    CopiarPropiedades(item, newItem);
                    ((IList)objetoDestino).Add(newItem);
                }
            }
        }
        else
        {
            foreach (PropertyInfo propiedad in propiedades)
            {
                try
                {
                    PropertyInfo propInfo = objetoDestino.GetType().GetProperty(propiedad.Name);
                    propInfo.SetValue(objetoDestino, propiedad.GetValue(objetoOrigen, null));
                }
                catch
                {
                    /* Los valores que no se pueden asignar son ignorados */
                }
            }
        }

        return true;
    }

    //public static string SerializarObjetoEnXML<T>(T objeto)
    //{
    //    if (objeto == null) return null;
    //    var rootElement = new XElement(typeof(T).Name);
    //    var properties = typeof(T).GetProperties();
    //    foreach (var property in properties)
    //    {
    //        if (property.PropertyType.IsGenericType && (property.PropertyType.GetGenericTypeDefinition() == typeof(ICollection<>) || property.PropertyType.GetGenericTypeDefinition() == typeof(List<>)))
    //        {
    //            continue;
    //        }

    //        object value = null;

    //        try
    //        {
    //            value = property.GetValue(objeto);
    //        }
    //        catch (Exception)
    //        {
    //            continue;
    //        }

    //        if (value != null)
    //        {
    //            var elementValue = Convert.ToString(value);
    //            if (!string.IsNullOrEmpty(elementValue))
    //            {
    //                var element = new XElement(property.Name, elementValue);
    //                rootElement.Add(element);
    //            }
    //        }
    //    }
    //    return rootElement.ToString().Replace("&lt;", "<").Replace("&gt;", ">"); ;
    //}

    //public static string SerializarListaEnXML<T>(List<T> lista)
    //{
    //    if (lista == null) return null;
    //    var rootElement = new XElement(typeof(T).Name + "s");
    //    foreach (var item in lista)
    //    {
    //        var element = SerializarObjetoEnXML(item);
    //        rootElement.Add(element);
    //    }
    //    return rootElement.ToString().Replace("&lt;", "<").Replace("&gt;", ">"); ;
    //}

    //public static T DeserializarObjetoDesdeXML<T>(string xmlString)
    //{
    //    if (string.IsNullOrEmpty(xmlString))
    //    {
    //        return default(T);
    //    }
    //    xmlString = xmlString.Replace("&lt;", "<").Replace("&gt;", ">");
    //    XmlDocument xmlDoc = new XmlDocument();
    //    xmlDoc.LoadXml(xmlString);
    //    XmlElement root = xmlDoc.DocumentElement;
    //    T result = Activator.CreateInstance<T>();
    //    PropertyInfo[] properties = typeof(T).GetProperties();
    //    foreach (XmlNode node in root.ChildNodes)
    //    {
    //        PropertyInfo property = properties.FirstOrDefault(p => p.Name == node.Name);
    //        if (property != null)
    //        {
    //            Type propertyType = property.PropertyType;
    //            if (propertyType.IsGenericType && propertyType.GetGenericTypeDefinition() == typeof(List<>))
    //            {
    //                Type itemType = propertyType.GetGenericArguments()[0];
    //                var list = (IList)Activator.CreateInstance(typeof(List<>).MakeGenericType(itemType));
    //                foreach (XmlNode itemNode in node.ChildNodes)
    //                {
    //                    object item = Activator.CreateInstance(itemType);
    //                    foreach (XmlNode itemPropertyNode in itemNode.ChildNodes)
    //                    {
    //                        PropertyInfo itemProperty = itemType.GetProperty(itemPropertyNode.Name);
    //                        if (itemProperty != null)
    //                        {
    //                            object itemValue = Convert.ChangeType(itemPropertyNode.InnerText, itemProperty.PropertyType);
    //                            itemProperty.SetValue(item, itemValue);
    //                        }
    //                    }
    //                    list.Add(item);
    //                }
    //                property.SetValue(result, list);
    //            }
    //            else
    //            {
    //                object value = Convert.ChangeType(node.InnerText, propertyType);
    //                property.SetValue(result, value);
    //            }
    //        }
    //    }
    //    return result;
    //}

    //public static List<T> DeserializarListaDesdeXML<T>(string xml, string nombreElementoRaiz)
    //{
    //    xml = xml.Replace("&lt;", "<").Replace("&gt;", ">");
    //    XmlSerializer serializer = new XmlSerializer(typeof(List<T>), new XmlRootAttribute(nombreElementoRaiz));
    //    using (StringReader reader = new StringReader(xml))
    //    {
    //        return (List<T>)serializer.Deserialize(reader);
    //    }
    //}

}