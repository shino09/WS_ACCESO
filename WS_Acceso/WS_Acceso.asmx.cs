using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using ClaseDatos;

namespace WS_Acceso
{
    /// <summary>
    /// Descripción breve de WS_Acceso
    /// </summary>
    //[WebService(Namespace = "http://tempuri.org/")]
    //[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    //[System.ComponentModel.ToolboxItem(false)]

    [WebService(Namespace = "http://cesion.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class WS_Acceso : System.Web.Services.WebService
    {

        [WebMethod(Description = "Buscar Cliente")]
        public ClaseEntradaSalida.MENSAJERES_Type BuscarCliente(ClaseEntradaSalida.CABECERA_Type cabecera,  ClaseEntradaSalida.DATOS_Type datosWC)

        {
            /****** DECLARAR TIPO DE DATOS PARA RESPUESTA********/
            ClaseEntradaSalida.MENSAJERES_Type MENSAJERES = new ClaseEntradaSalida.MENSAJERES_Type();
            ClaseEntradaSalida.INTEGRACIONRES_Type INTEGRES = new ClaseEntradaSalida.INTEGRACIONRES_Type();
            ClaseEntradaSalida.CABECERARes_Type CABECERA = new ClaseEntradaSalida.CABECERARes_Type();
            ClaseEntradaSalida.DETALLERes_Type DETALLE = new ClaseEntradaSalida.DETALLERes_Type();
            ClaseEntradaSalida.DATOSRes_Type DATOS = new ClaseEntradaSalida.DATOSRes_Type();
            ClaseDatosCliente cdc = new ClaseDatosCliente();
            ClaseCliente datos = new ClaseCliente();
            string dominio = datosWC.Dominio;

            CABECERA.APP_CONSUMIDORA = cabecera.APP_CONSUMIDORA;
            CABECERA.COD_RESPUESTA = "0";
            CABECERA.DES_RESPUESTA = "Ejecución Erronea";
            DATOS.Cliente_Ruc = null;
            DATOS.Cliente_Cod_Part = null;
            DATOS.EndPoint_Cli_Cone_xion = null;
            DETALLE.DATOS = DATOS;
            INTEGRES.CABECERA = CABECERA;
            INTEGRES.DETALLE = DETALLE;
            MENSAJERES.INTEGRES = INTEGRES;
            try
            {
                try
                {
                    cdc = datos.ObtenerDatosCliente(dominio);
                }
                catch (Exception ex)
                {
                    return MENSAJERES;
                }
                /*******ARMAR RESPUESTA CORRECTA CON LOS DATOS DEL CLIENTE OBTENIDOS DEL SP*********/
                if (cdc.ruc != "" && cdc.codigoParticipante != "" && cdc.urlEndPoint != "")
                {
                    CABECERA.APP_CONSUMIDORA = cabecera.APP_CONSUMIDORA;
                    CABECERA.COD_RESPUESTA = "1";
                    CABECERA.DES_RESPUESTA = "Ejecución Correcta";
                    DATOS.Cliente_Ruc = cdc.ruc;
                    DATOS.Cliente_Cod_Part = cdc.codigoParticipante;
                    DATOS.EndPoint_Cli_Cone_xion = cdc.urlEndPoint;
                    DETALLE.DATOS = DATOS;
                    INTEGRES.CABECERA = CABECERA;
                    INTEGRES.DETALLE = DETALLE;
                    MENSAJERES.INTEGRES = INTEGRES;
                }
                /*******ARMAR RESPUESTA ERRONEA CON LOS DATOS DEL CLIENTE VACIOS*********/
                else
                {
                    CABECERA.APP_CONSUMIDORA = cabecera.APP_CONSUMIDORA;
                    CABECERA.COD_RESPUESTA = "0";
                    CABECERA.DES_RESPUESTA = "Ejecución Erronea";
                    DATOS.Cliente_Ruc = null;
                    DATOS.Cliente_Cod_Part = null;
                    DATOS.EndPoint_Cli_Cone_xion = null;
                    DETALLE.DATOS = DATOS;
                    INTEGRES.CABECERA = CABECERA;
                    INTEGRES.DETALLE = DETALLE;
                    MENSAJERES.INTEGRES = INTEGRES;
                }
            

            }
            catch (Exception ex)
            {

            }
            return MENSAJERES;
        }
    }
}
