using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseDatos
{
    public class ClaseEntradaSalida
    {


        public partial class MENSAJEREQ_Type : object, System.ComponentModel.INotifyPropertyChanged
        {

            private INTEGRACIONREQ_Type iNTEGREQField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
            public INTEGRACIONREQ_Type INTEGREQ
            {
                get
                {
                    return this.iNTEGREQField;
                }
                set
                {
                    this.iNTEGREQField = value;
                    this.RaisePropertyChanged("INTEGREQ");
                }
            }

            public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

            protected void RaisePropertyChanged(string propertyName)
            {
                System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
                if ((propertyChanged != null))
                {
                    propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3130.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://cavali.com.pe/ib/esb/srv04001")]
        public partial class INTEGRACIONREQ_Type : object, System.ComponentModel.INotifyPropertyChanged
        {

            private CABECERA_Type cABECERAField;

            private DETALLE_Type dETALLEField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
            public CABECERA_Type CABECERA
            {
                get
                {
                    return this.cABECERAField;
                }
                set
                {
                    this.cABECERAField = value;
                    this.RaisePropertyChanged("CABECERA");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
            public DETALLE_Type DETALLE
            {
                get
                {
                    return this.dETALLEField;
                }
                set
                {
                    this.dETALLEField = value;
                    this.RaisePropertyChanged("DETALLE");
                }
            }

            public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

            protected void RaisePropertyChanged(string propertyName)
            {
                System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
                if ((propertyChanged != null))
                {
                    propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3130.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://cavali.com.pe/ib/esb")]
        public partial class CABECERA_Type : object, System.ComponentModel.INotifyPropertyChanged
        {


            private string aPP_CONSUMIDORAField;

     

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
            public string APP_CONSUMIDORA
            {
                get
                {
                    return this.aPP_CONSUMIDORAField;
                }
                set
                {
                    this.aPP_CONSUMIDORAField = value;
                    this.RaisePropertyChanged("APP_CONSUMIDORA");
                }
            }

            public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

            protected void RaisePropertyChanged(string propertyName)
            {
                System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
                if ((propertyChanged != null))
                {
                    propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3130.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://cavali.com.pe/ib/esb/srv04001")]
        public partial class AddInvoiceResponseDetail_Type : object, System.ComponentModel.INotifyPropertyChanged
        {

            private string Cliente_RucField;

            private string Cliente_Cod_PartField;

            private string EndPoint_Cli_Cone_xionField;


            //private string resultCodeField;

            //private string messageField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, /*DataType = "integer",*/ Order = 0)]
            public string Cliente_Ruc
            {
                get
                {
                    return this.Cliente_RucField;
                }
                set
                {
                    this.Cliente_RucField = value;
                    this.RaisePropertyChanged("Cliente_Ruc");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, /*DataType = "integer",*/ Order = 1)]
            public string Cliente_Cod_Part
            {
                get
                {
                    return this.Cliente_Cod_PartField;
                }
                set
                {
                    this.Cliente_Cod_PartField = value;
                    this.RaisePropertyChanged("Cliente_Cod_Partc");
                }
            }


            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, /*DataType = "integer",*/ Order = 2)]
            public string EndPoint_Cli_Cone_xion
            {
                get
                {
                    return this.EndPoint_Cli_Cone_xionField;
                }
                set
                {
                    this.EndPoint_Cli_Cone_xionField = value;
                    this.RaisePropertyChanged("EndPoint_Cli_Cone_xion");
                }
            }

            ///// <remarks/>
            //[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "integer", Order = 4)]
            //public string resultCode
            //{
            //    get
            //    {
            //        return this.resultCodeField;
            //    }
            //    set
            //    {
            //        this.resultCodeField = value;
            //        this.RaisePropertyChanged("resultCode");
            //    }
            //}

            ///// <remarks/>
            //[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
            //public string message
            //{
            //    get
            //    {
            //        return this.messageField;
            //    }
            //    set
            //    {
            //        this.messageField = value;
            //        this.RaisePropertyChanged("message");
            //    }
            //}

            public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

            protected void RaisePropertyChanged(string propertyName)
            {
                System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
                if ((propertyChanged != null))
                {
                    propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
                }
            }
        }

    
        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3130.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://cavali.com.pe/ib/esb/srv04001")]
        public partial class DATOSRes_Type : object, System.ComponentModel.INotifyPropertyChanged
        {

            


            private string Cliente_RucField;

            private string Cliente_Cod_PartField;

            private string EndPoint_Cli_Cone_xionField;


            //private string resultCodeField;

            //private string messageField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, /*DataType = "integer",*/ Order = 0)]
            public string Cliente_Ruc
            {
                get
                {
                    return this.Cliente_RucField;
                }
                set
                {
                    this.Cliente_RucField = value;
                    this.RaisePropertyChanged("Cliente_Ruc");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, /*DataType = "integer",*/ Order = 1)]
            public string Cliente_Cod_Part
            {
                get
                {
                    return this.Cliente_Cod_PartField;
                }
                set
                {
                    this.Cliente_Cod_PartField = value;
                    this.RaisePropertyChanged("Cliente_Cod_Partc");
                }
            }


            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, /*DataType = "integer",*/ Order = 2)]
            public string EndPoint_Cli_Cone_xion
            {
                get
                {
                    return this.EndPoint_Cli_Cone_xionField;
                }
                set
                {
                    this.EndPoint_Cli_Cone_xionField = value;
                    this.RaisePropertyChanged("EndPoint_Cli_Cone_xion");
                }
            }

            ///// <remarks/>
            //[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "integer", Order = 3)]
            //public string resultCode
            //{
            //    get
            //    {
            //        return this.resultCodeField;
            //    }
            //    set
            //    {
            //        this.resultCodeField = value;
            //        this.RaisePropertyChanged("resultCode");
            //    }
            //}

            ///// <remarks/>
            //[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
            //public string message
            //{
            //    get
            //    {
            //        return this.messageField;
            //    }
            //    set
            //    {
            //        this.messageField = value;
            //        this.RaisePropertyChanged("message");
            //    }
            //}

            public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

            protected void RaisePropertyChanged(string propertyName)
            {
                System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
                if ((propertyChanged != null))
                {
                    propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
                }
            }


        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }


        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3130.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://cavali.com.pe/ib/esb/srv04001")]
        public partial class DETALLERes_Type : object, System.ComponentModel.INotifyPropertyChanged
        {

            private DATOSRes_Type dATOSField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
            public DATOSRes_Type DATOS
            {
                get
                {
                    return this.dATOSField;
                }
                set
                {
                    this.dATOSField = value;
                    this.RaisePropertyChanged("DATOS");
                }
            }

            public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

            protected void RaisePropertyChanged(string propertyName)
            {
                System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
                if ((propertyChanged != null))
                {
                    propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3130.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://cavali.com.pe/ib/esb")]
        public partial class CABECERARes_Type : object, System.ComponentModel.INotifyPropertyChanged
        {


            private string aPP_CONSUMIDORAField;


            private string cOD_RESPUESTAField;

            private string dES_RESPUESTAField;

        

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
            public string APP_CONSUMIDORA
            {
                get
                {
                    return this.aPP_CONSUMIDORAField;
                }
                set
                {
                    this.aPP_CONSUMIDORAField = value;
                    this.RaisePropertyChanged("APP_CONSUMIDORA");
                }
            }

         
            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
            public string COD_RESPUESTA
            {
                get
                {
                    return this.cOD_RESPUESTAField;
                }
                set
                {
                    this.cOD_RESPUESTAField = value;
                    this.RaisePropertyChanged("COD_RESPUESTA");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
            public string DES_RESPUESTA
            {
                get
                {
                    return this.dES_RESPUESTAField;
                }
                set
                {
                    this.dES_RESPUESTAField = value;
                    this.RaisePropertyChanged("DES_RESPUESTA");
                }
            }

            public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

            protected void RaisePropertyChanged(string propertyName)
            {
                System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
                if ((propertyChanged != null))
                {
                    propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3130.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://cavali.com.pe/ib/esb/srv04001")]
        public partial class INTEGRACIONRES_Type : object, System.ComponentModel.INotifyPropertyChanged
        {

            private CABECERARes_Type cABECERAField;

            private DETALLERes_Type dETALLEField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
            public CABECERARes_Type CABECERA
            {
                get
                {
                    return this.cABECERAField;
                }
                set
                {
                    this.cABECERAField = value;
                    this.RaisePropertyChanged("CABECERA");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
            public DETALLERes_Type DETALLE
            {
                get
                {
                    return this.dETALLEField;
                }
                set
                {
                    this.dETALLEField = value;
                    this.RaisePropertyChanged("DETALLE");
                }
            }

            public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

            protected void RaisePropertyChanged(string propertyName)
            {
                System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
                if ((propertyChanged != null))
                {
                    propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3130.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://cavali.com.pe/ib/esb/srv04001")]
        public partial class MENSAJERES_Type : object, System.ComponentModel.INotifyPropertyChanged
        {

            private INTEGRACIONRES_Type iNTEGRESField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
            public INTEGRACIONRES_Type INTEGRES
            {
                get
                {
                    return this.iNTEGRESField;
                }
                set
                {
                    this.iNTEGRESField = value;
                    this.RaisePropertyChanged("INTEGRES");
                }
            }

            public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

            protected void RaisePropertyChanged(string propertyName)
            {
                System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
                if ((propertyChanged != null))
                {
                    propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
                }
            }
        }

   

      



        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3130.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://cavali.com.pe/ib/esb/srv04001")]
        public partial class DATOS_Type : object, System.ComponentModel.INotifyPropertyChanged
        {
            private string DominioField;


            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, /*DataType = "integer",*/ Order = 0)]
            public string Dominio
            {
                get
                {
                    return this.DominioField;
                }
                set
                {
                    this.DominioField = value;
                    this.RaisePropertyChanged("Dominio");
                }
            }

            public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

            protected void RaisePropertyChanged(string propertyName)
            {
                System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
                if ((propertyChanged != null))
                {
                    propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3130.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://cavali.com.pe/ib/esb/srv04001")]
        public partial class DETALLE_Type : object, System.ComponentModel.INotifyPropertyChanged
        {

            private DATOS_Type dATOSField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
            public DATOS_Type DATOS
            {
                get
                {
                    return this.dATOSField;
                }
                set
                {
                    this.dATOSField = value;
                    this.RaisePropertyChanged("DATOS");
                }
            }

            public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

            protected void RaisePropertyChanged(string propertyName)
            {
                System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
                if ((propertyChanged != null))
                {
                    propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
                }
            }
        }
    }
}
