using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;
using System.Collections;
using System.Xml.Serialization;
using System.IO;

namespace BuenosAires.VentaBA
{
    public static class Util
    {
        public static T DeserializarXML<T>(string xml)
        {
            if (string.IsNullOrEmpty(xml)) return default(T);
            var serializer = new XmlSerializer(typeof(T));
            using (var reader = new StringReader(xml))
            {
                return (T)serializer.Deserialize(reader);
            }
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

        //        var value = property.GetValue(objeto);
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
        //                object value = null;
        //                if (propertyType.FullName.Contains("System.Nullable") && propertyType.FullName.Contains("System.Int32"))
        //                {
        //                    if (node.InnerText != "")
        //                    {
        //                        value = int.Parse(node.InnerText);
        //                    }
        //                } 
        //                else
        //                {
        //                    value = Convert.ChangeType(node.InnerText, propertyType);
        //                }
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

        //public static bool CopiarPropiedades(object objetoOrigen, object objetoDestino)
        //{
        //    if (objetoOrigen == null) return false;

        //    /* Auxiliares para Reflection del Tipo de Dato Origen */
        //    Type tipo = null;
        //    PropertyInfo[] propiedades = null;

        //    /* Obtiene información del Tipo Origen y sus Propiedades */
        //    tipo = objetoOrigen.GetType();
        //    propiedades = tipo.GetProperties();

        //    /* Recorre las propiedades del Origen para asignar los valores al destino */
        //    foreach (PropertyInfo propiedad in propiedades)
        //    {
        //        try
        //        {
        //            /* Recupera propiedad destino por su nombre */
        //            PropertyInfo propInfo = objetoDestino.GetType().GetProperty(propiedad.Name);

        //            /* Asigna valor destino desde el origen */
        //            propInfo.SetValue(objetoDestino, propiedad.GetValue(objetoOrigen, null));
        //        }
        //        catch {/* Los valores que no se pueden asignar son ignorados */}
        //    }

        //    return true;
        //}

        public static string PonerPuntoFinal(string texto)
        {
            texto = texto.Trim();
            if (texto != "")
            {
                if (!texto.EndsWith("."))
                {
                    return texto + ".";
                }
            }
            return texto;
        }

        public static string MensajeError(string mensajeGeneral, Exception ex)
        {
            var mensajeError = "";

            if (mensajeGeneral.Trim() != "")
            {
                mensajeError += PonerPuntoFinal(mensajeGeneral);
            }

            if (ex != null)
            {
                if (ex.Message.Trim() != "")
                {
                    if (mensajeError == "")
                    {
                        mensajeError = PonerPuntoFinal(ex.Message);
                    }
                    else
                    {
                        mensajeError += " " + PonerPuntoFinal(ex.Message);
                    }
                }

                if (ex.InnerException != null)
                {
                    if (mensajeError == "")
                    {
                        mensajeError = PonerPuntoFinal(ex.InnerException.Message);
                    }
                    else
                    {
                        mensajeError += " " + PonerPuntoFinal(ex.InnerException.Message);
                    }
                }
            }

            if (mensajeError == "")
            {
                return "ERROR: Comuníquese con el Administrador del Sistema.";
            }
            else
            {
                return mensajeError + " Comuníquese con el Administrador del Sistema.";
            }
        }

        public static void MostrarMensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Buenos Aires", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void MostrarMensajeInformativo(string mensaje)
        {
            MessageBox.Show(mensaje, "Buenos Aires", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void MostrarMensaje(string mensaje, bool hayErrores)
        {
            if (hayErrores)
            {
                MostrarMensajeError(mensaje);
                return;
            }
            MostrarMensajeInformativo(mensaje);
        }
    }
}