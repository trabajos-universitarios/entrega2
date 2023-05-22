
package BuenosAires.ServiceClient.ServicioStockProducto;

import javax.xml.bind.JAXBElement;
import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlElementRef;
import javax.xml.bind.annotation.XmlType;


/**
 * <p>Clase Java para Respuesta complex type.
 * 
 * <p>El siguiente fragmento de esquema especifica el contenido que se espera que haya en esta clase.
 * 
 * <pre>
 * &lt;complexType name="Respuesta"&gt;
 *   &lt;complexContent&gt;
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType"&gt;
 *       &lt;sequence&gt;
 *         &lt;element name="Accion" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="HayErrores" type="{http://www.w3.org/2001/XMLSchema}boolean" minOccurs="0"/&gt;
 *         &lt;element name="Mensaje" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="XmlFactura" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="XmlGuiaDespacho" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="XmlListaFactura" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="XmlListaGuiaDespacho" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="XmlListaPerfilUsuario" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="XmlListaProducto" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="XmlListaSolicitudServicio" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="XmlListaStockProducto" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="XmlPerfilUsuario" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="XmlProducto" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="XmlSolicitudServicio" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="XmlStockProducto" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *       &lt;/sequence&gt;
 *     &lt;/restriction&gt;
 *   &lt;/complexContent&gt;
 * &lt;/complexType&gt;
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "Respuesta", namespace = "http://schemas.datacontract.org/2004/07/", propOrder = {
    "accion",
    "hayErrores",
    "mensaje",
    "xmlFactura",
    "xmlGuiaDespacho",
    "xmlListaFactura",
    "xmlListaGuiaDespacho",
    "xmlListaPerfilUsuario",
    "xmlListaProducto",
    "xmlListaSolicitudServicio",
    "xmlListaStockProducto",
    "xmlPerfilUsuario",
    "xmlProducto",
    "xmlSolicitudServicio",
    "xmlStockProducto"
})
public class Respuesta {

    @XmlElementRef(name = "Accion", namespace = "http://schemas.datacontract.org/2004/07/", type = JAXBElement.class, required = false)
    protected JAXBElement<String> accion;
    @XmlElement(name = "HayErrores")
    protected Boolean hayErrores;
    @XmlElementRef(name = "Mensaje", namespace = "http://schemas.datacontract.org/2004/07/", type = JAXBElement.class, required = false)
    protected JAXBElement<String> mensaje;
    @XmlElementRef(name = "XmlFactura", namespace = "http://schemas.datacontract.org/2004/07/", type = JAXBElement.class, required = false)
    protected JAXBElement<String> xmlFactura;
    @XmlElementRef(name = "XmlGuiaDespacho", namespace = "http://schemas.datacontract.org/2004/07/", type = JAXBElement.class, required = false)
    protected JAXBElement<String> xmlGuiaDespacho;
    @XmlElementRef(name = "XmlListaFactura", namespace = "http://schemas.datacontract.org/2004/07/", type = JAXBElement.class, required = false)
    protected JAXBElement<String> xmlListaFactura;
    @XmlElementRef(name = "XmlListaGuiaDespacho", namespace = "http://schemas.datacontract.org/2004/07/", type = JAXBElement.class, required = false)
    protected JAXBElement<String> xmlListaGuiaDespacho;
    @XmlElementRef(name = "XmlListaPerfilUsuario", namespace = "http://schemas.datacontract.org/2004/07/", type = JAXBElement.class, required = false)
    protected JAXBElement<String> xmlListaPerfilUsuario;
    @XmlElementRef(name = "XmlListaProducto", namespace = "http://schemas.datacontract.org/2004/07/", type = JAXBElement.class, required = false)
    protected JAXBElement<String> xmlListaProducto;
    @XmlElementRef(name = "XmlListaSolicitudServicio", namespace = "http://schemas.datacontract.org/2004/07/", type = JAXBElement.class, required = false)
    protected JAXBElement<String> xmlListaSolicitudServicio;
    @XmlElementRef(name = "XmlListaStockProducto", namespace = "http://schemas.datacontract.org/2004/07/", type = JAXBElement.class, required = false)
    protected JAXBElement<String> xmlListaStockProducto;
    @XmlElementRef(name = "XmlPerfilUsuario", namespace = "http://schemas.datacontract.org/2004/07/", type = JAXBElement.class, required = false)
    protected JAXBElement<String> xmlPerfilUsuario;
    @XmlElementRef(name = "XmlProducto", namespace = "http://schemas.datacontract.org/2004/07/", type = JAXBElement.class, required = false)
    protected JAXBElement<String> xmlProducto;
    @XmlElementRef(name = "XmlSolicitudServicio", namespace = "http://schemas.datacontract.org/2004/07/", type = JAXBElement.class, required = false)
    protected JAXBElement<String> xmlSolicitudServicio;
    @XmlElementRef(name = "XmlStockProducto", namespace = "http://schemas.datacontract.org/2004/07/", type = JAXBElement.class, required = false)
    protected JAXBElement<String> xmlStockProducto;

    /**
     * Obtiene el valor de la propiedad accion.
     * 
     * @return
     *     possible object is
     *     {@link JAXBElement }{@code <}{@link String }{@code >}
     *     
     */
    public JAXBElement<String> getAccion() {
        return accion;
    }

    /**
     * Define el valor de la propiedad accion.
     * 
     * @param value
     *     allowed object is
     *     {@link JAXBElement }{@code <}{@link String }{@code >}
     *     
     */
    public void setAccion(JAXBElement<String> value) {
        this.accion = value;
    }

    /**
     * Obtiene el valor de la propiedad hayErrores.
     * 
     * @return
     *     possible object is
     *     {@link Boolean }
     *     
     */
    public Boolean isHayErrores() {
        return hayErrores;
    }

    /**
     * Define el valor de la propiedad hayErrores.
     * 
     * @param value
     *     allowed object is
     *     {@link Boolean }
     *     
     */
    public void setHayErrores(Boolean value) {
        this.hayErrores = value;
    }

    /**
     * Obtiene el valor de la propiedad mensaje.
     * 
     * @return
     *     possible object is
     *     {@link JAXBElement }{@code <}{@link String }{@code >}
     *     
     */
    public JAXBElement<String> getMensaje() {
        return mensaje;
    }

    /**
     * Define el valor de la propiedad mensaje.
     * 
     * @param value
     *     allowed object is
     *     {@link JAXBElement }{@code <}{@link String }{@code >}
     *     
     */
    public void setMensaje(JAXBElement<String> value) {
        this.mensaje = value;
    }

    /**
     * Obtiene el valor de la propiedad xmlFactura.
     * 
     * @return
     *     possible object is
     *     {@link JAXBElement }{@code <}{@link String }{@code >}
     *     
     */
    public JAXBElement<String> getXmlFactura() {
        return xmlFactura;
    }

    /**
     * Define el valor de la propiedad xmlFactura.
     * 
     * @param value
     *     allowed object is
     *     {@link JAXBElement }{@code <}{@link String }{@code >}
     *     
     */
    public void setXmlFactura(JAXBElement<String> value) {
        this.xmlFactura = value;
    }

    /**
     * Obtiene el valor de la propiedad xmlGuiaDespacho.
     * 
     * @return
     *     possible object is
     *     {@link JAXBElement }{@code <}{@link String }{@code >}
     *     
     */
    public JAXBElement<String> getXmlGuiaDespacho() {
        return xmlGuiaDespacho;
    }

    /**
     * Define el valor de la propiedad xmlGuiaDespacho.
     * 
     * @param value
     *     allowed object is
     *     {@link JAXBElement }{@code <}{@link String }{@code >}
     *     
     */
    public void setXmlGuiaDespacho(JAXBElement<String> value) {
        this.xmlGuiaDespacho = value;
    }

    /**
     * Obtiene el valor de la propiedad xmlListaFactura.
     * 
     * @return
     *     possible object is
     *     {@link JAXBElement }{@code <}{@link String }{@code >}
     *     
     */
    public JAXBElement<String> getXmlListaFactura() {
        return xmlListaFactura;
    }

    /**
     * Define el valor de la propiedad xmlListaFactura.
     * 
     * @param value
     *     allowed object is
     *     {@link JAXBElement }{@code <}{@link String }{@code >}
     *     
     */
    public void setXmlListaFactura(JAXBElement<String> value) {
        this.xmlListaFactura = value;
    }

    /**
     * Obtiene el valor de la propiedad xmlListaGuiaDespacho.
     * 
     * @return
     *     possible object is
     *     {@link JAXBElement }{@code <}{@link String }{@code >}
     *     
     */
    public JAXBElement<String> getXmlListaGuiaDespacho() {
        return xmlListaGuiaDespacho;
    }

    /**
     * Define el valor de la propiedad xmlListaGuiaDespacho.
     * 
     * @param value
     *     allowed object is
     *     {@link JAXBElement }{@code <}{@link String }{@code >}
     *     
     */
    public void setXmlListaGuiaDespacho(JAXBElement<String> value) {
        this.xmlListaGuiaDespacho = value;
    }

    /**
     * Obtiene el valor de la propiedad xmlListaPerfilUsuario.
     * 
     * @return
     *     possible object is
     *     {@link JAXBElement }{@code <}{@link String }{@code >}
     *     
     */
    public JAXBElement<String> getXmlListaPerfilUsuario() {
        return xmlListaPerfilUsuario;
    }

    /**
     * Define el valor de la propiedad xmlListaPerfilUsuario.
     * 
     * @param value
     *     allowed object is
     *     {@link JAXBElement }{@code <}{@link String }{@code >}
     *     
     */
    public void setXmlListaPerfilUsuario(JAXBElement<String> value) {
        this.xmlListaPerfilUsuario = value;
    }

    /**
     * Obtiene el valor de la propiedad xmlListaProducto.
     * 
     * @return
     *     possible object is
     *     {@link JAXBElement }{@code <}{@link String }{@code >}
     *     
     */
    public JAXBElement<String> getXmlListaProducto() {
        return xmlListaProducto;
    }

    /**
     * Define el valor de la propiedad xmlListaProducto.
     * 
     * @param value
     *     allowed object is
     *     {@link JAXBElement }{@code <}{@link String }{@code >}
     *     
     */
    public void setXmlListaProducto(JAXBElement<String> value) {
        this.xmlListaProducto = value;
    }

    /**
     * Obtiene el valor de la propiedad xmlListaSolicitudServicio.
     * 
     * @return
     *     possible object is
     *     {@link JAXBElement }{@code <}{@link String }{@code >}
     *     
     */
    public JAXBElement<String> getXmlListaSolicitudServicio() {
        return xmlListaSolicitudServicio;
    }

    /**
     * Define el valor de la propiedad xmlListaSolicitudServicio.
     * 
     * @param value
     *     allowed object is
     *     {@link JAXBElement }{@code <}{@link String }{@code >}
     *     
     */
    public void setXmlListaSolicitudServicio(JAXBElement<String> value) {
        this.xmlListaSolicitudServicio = value;
    }

    /**
     * Obtiene el valor de la propiedad xmlListaStockProducto.
     * 
     * @return
     *     possible object is
     *     {@link JAXBElement }{@code <}{@link String }{@code >}
     *     
     */
    public JAXBElement<String> getXmlListaStockProducto() {
        return xmlListaStockProducto;
    }

    /**
     * Define el valor de la propiedad xmlListaStockProducto.
     * 
     * @param value
     *     allowed object is
     *     {@link JAXBElement }{@code <}{@link String }{@code >}
     *     
     */
    public void setXmlListaStockProducto(JAXBElement<String> value) {
        this.xmlListaStockProducto = value;
    }

    /**
     * Obtiene el valor de la propiedad xmlPerfilUsuario.
     * 
     * @return
     *     possible object is
     *     {@link JAXBElement }{@code <}{@link String }{@code >}
     *     
     */
    public JAXBElement<String> getXmlPerfilUsuario() {
        return xmlPerfilUsuario;
    }

    /**
     * Define el valor de la propiedad xmlPerfilUsuario.
     * 
     * @param value
     *     allowed object is
     *     {@link JAXBElement }{@code <}{@link String }{@code >}
     *     
     */
    public void setXmlPerfilUsuario(JAXBElement<String> value) {
        this.xmlPerfilUsuario = value;
    }

    /**
     * Obtiene el valor de la propiedad xmlProducto.
     * 
     * @return
     *     possible object is
     *     {@link JAXBElement }{@code <}{@link String }{@code >}
     *     
     */
    public JAXBElement<String> getXmlProducto() {
        return xmlProducto;
    }

    /**
     * Define el valor de la propiedad xmlProducto.
     * 
     * @param value
     *     allowed object is
     *     {@link JAXBElement }{@code <}{@link String }{@code >}
     *     
     */
    public void setXmlProducto(JAXBElement<String> value) {
        this.xmlProducto = value;
    }

    /**
     * Obtiene el valor de la propiedad xmlSolicitudServicio.
     * 
     * @return
     *     possible object is
     *     {@link JAXBElement }{@code <}{@link String }{@code >}
     *     
     */
    public JAXBElement<String> getXmlSolicitudServicio() {
        return xmlSolicitudServicio;
    }

    /**
     * Define el valor de la propiedad xmlSolicitudServicio.
     * 
     * @param value
     *     allowed object is
     *     {@link JAXBElement }{@code <}{@link String }{@code >}
     *     
     */
    public void setXmlSolicitudServicio(JAXBElement<String> value) {
        this.xmlSolicitudServicio = value;
    }

    /**
     * Obtiene el valor de la propiedad xmlStockProducto.
     * 
     * @return
     *     possible object is
     *     {@link JAXBElement }{@code <}{@link String }{@code >}
     *     
     */
    public JAXBElement<String> getXmlStockProducto() {
        return xmlStockProducto;
    }

    /**
     * Define el valor de la propiedad xmlStockProducto.
     * 
     * @param value
     *     allowed object is
     *     {@link JAXBElement }{@code <}{@link String }{@code >}
     *     
     */
    public void setXmlStockProducto(JAXBElement<String> value) {
        this.xmlStockProducto = value;
    }

}
