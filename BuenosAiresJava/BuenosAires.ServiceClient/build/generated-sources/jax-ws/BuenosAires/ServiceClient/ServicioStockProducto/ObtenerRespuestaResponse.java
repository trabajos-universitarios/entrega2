
package BuenosAires.ServiceClient.ServicioStockProducto;

import javax.xml.bind.JAXBElement;
import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElementRef;
import javax.xml.bind.annotation.XmlRootElement;
import javax.xml.bind.annotation.XmlType;


/**
 * <p>Clase Java para anonymous complex type.
 * 
 * <p>El siguiente fragmento de esquema especifica el contenido que se espera que haya en esta clase.
 * 
 * <pre>
 * &lt;complexType&gt;
 *   &lt;complexContent&gt;
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType"&gt;
 *       &lt;sequence&gt;
 *         &lt;element name="ObtenerRespuestaResult" type="{http://schemas.datacontract.org/2004/07/}Respuesta" minOccurs="0"/&gt;
 *       &lt;/sequence&gt;
 *     &lt;/restriction&gt;
 *   &lt;/complexContent&gt;
 * &lt;/complexType&gt;
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "", propOrder = {
    "obtenerRespuestaResult"
})
@XmlRootElement(name = "ObtenerRespuestaResponse", namespace = "http://tempuri.org/")
public class ObtenerRespuestaResponse {

    @XmlElementRef(name = "ObtenerRespuestaResult", namespace = "http://tempuri.org/", type = JAXBElement.class, required = false)
    protected JAXBElement<Respuesta> obtenerRespuestaResult;

    /**
     * Obtiene el valor de la propiedad obtenerRespuestaResult.
     * 
     * @return
     *     possible object is
     *     {@link JAXBElement }{@code <}{@link Respuesta }{@code >}
     *     
     */
    public JAXBElement<Respuesta> getObtenerRespuestaResult() {
        return obtenerRespuestaResult;
    }

    /**
     * Define el valor de la propiedad obtenerRespuestaResult.
     * 
     * @param value
     *     allowed object is
     *     {@link JAXBElement }{@code <}{@link Respuesta }{@code >}
     *     
     */
    public void setObtenerRespuestaResult(JAXBElement<Respuesta> value) {
        this.obtenerRespuestaResult = value;
    }

}
