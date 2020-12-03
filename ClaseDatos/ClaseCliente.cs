using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 using dim.rutinas;


namespace ClaseDatos
{
   public  class ClaseCliente
    {




            SqlQuery sqlquery = new SqlQuery();
            RutinasGenerales rg = new RutinasGenerales(); 
            //public string Ruc { get; set; }
            //public string CodigoParticipante { get; set; }
            //public string UrlEndPoint { get; set; }


            public  ClaseDatosCliente ObtenerDatosCliente(string dominio)
            {
                DataSet ds;
                ClaseDatosCliente cdc = new ClaseDatosCliente();
                string sqlstr = "";

                try
                {
                    sqlstr = "EXEC P_GET_Datos_Cliente " + "'"  + dominio + "'"; 

                    if (rg.PalabrasClaveSQL(sqlstr))
                    {
                        cdc.ruc = "";
                        cdc.codigoParticipante = "";
                        cdc.urlEndPoint = "";
                    }
                    else
                    {

                        ds = sqlquery.ExecuteDataSet(sqlstr);

                        if (ds != null && ds.Tables.Count>0)
                        {
                            cdc.ruc = ds.Tables[0].Rows[0]["Cliente_Ruc"].ToString();
                            cdc.codigoParticipante = ds.Tables[0].Rows[0]["Cliente_Cod_Part"].ToString();
                            cdc.urlEndPoint = ds.Tables[0].Rows[0]["EndPoint_Cli_Cone_xion"].ToString();

                        }
                    }

                    return cdc;


                }
                catch (Exception e)
                {
                    cdc.ruc = "";
                    cdc.codigoParticipante = "";
                    cdc.urlEndPoint = "";
                }

                return cdc;

            }

        }
    }


