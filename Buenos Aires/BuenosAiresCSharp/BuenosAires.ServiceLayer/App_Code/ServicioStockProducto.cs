using System.Collections.Generic;
using BuenosAires.BusinessLayer;
using BuenosAires.Model;
using System.IO;
using System.Xml.Serialization;

public class ServicioStockProducto : IServicioStockProducto
{
    public Respuesta ObtenerRespuesta(BcStockProducto bc)
    {
        //BcProducto bcProd = null;
        //BcFactura bcFac = null;
        //XmlSerializer serializer = null;
        //StringWriter stringWriter = null;
        //string xml1 = null;
        //string xml2 = null;
        //string xml3 = null;

        //bcProd = new BcProducto();
        //bcProd.LeerTodos();
        //serializer = new XmlSerializer(typeof(List<Producto>));
        //stringWriter = new StringWriter();
        //List<Producto> listaProd = new List<Producto>();
        //Util.CopiarPropiedades(bcProd.Lista, listaProd);
        //serializer.Serialize(stringWriter, listaProd);
        //xml2 = stringWriter.ToString();

        //bcProd = new BcProducto();
        //bcProd.LeerTodos();
        //xml2 = Util.SerializarXML(bcProd.Lista);

        //var lista = Util.DeserializarXML<List<Producto>>(xml2);


        var respuesta = new Respuesta();
        respuesta.Accion = bc.Accion;
        respuesta.Mensaje = bc.Mensaje;
        respuesta.HayErrores = bc.HayErrores;
        respuesta.XmlStockProducto = Util.SerializarXML(bc.StockProducto);

        //List<Producto> listaProd = new List<Producto>();
        //listaProd.Add(new Producto() { idprod=1, descprod="desc", nomprod="nom", imagen="ima", precio=123});
        //respuesta.XmlListaStockProducto = Util.SerializarXML(listaProd);
        //Util.CopiarPropiedades(bc.Lista, listaProd);

        respuesta.XmlListaStockProducto = Util.SerializarXML(bc.Lista);
        return respuesta;
    }

    public Respuesta ValidarStockProducto(StockProducto stockProducto)
    {
        var bc = new BcStockProducto();
        bc.ValidarStockProducto(stockProducto);
        return ObtenerRespuesta(bc);
    }

    public Respuesta Crear(StockProducto stockProducto)
    {
        var bc = new BcStockProducto();
        bc.Crear(stockProducto);
        return ObtenerRespuesta(bc);
    }

    public Respuesta LeerTodos()
    {
        var bc = new BcStockProducto();
        bc.LeerTodos();
        return ObtenerRespuesta(bc);
    }

    public Respuesta Leer(int id)
    {
        var bc = new BcStockProducto();
        bc.Leer(id);
        return ObtenerRespuesta(bc);
    }

    public Respuesta Actualizar(StockProducto stockProducto)
    {
        var bc = new BcStockProducto();
        bc.Actualizar(stockProducto);
        return ObtenerRespuesta(bc);
    }

    public Respuesta Eliminar(int id)
    {
        var bc = new BcStockProducto();
        bc.Eliminar(id);
        return ObtenerRespuesta(bc);
    }
}
