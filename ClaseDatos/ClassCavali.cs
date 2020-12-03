using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ClaseDatos
{
    public class ClassCavali
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

            private string cOD_SERVICIOField;

            private string aPP_CONSUMIDORAField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
            public string COD_SERVICIO
            {
                get
                {
                    return this.cOD_SERVICIOField;
                }
                set
                {
                    this.cOD_SERVICIOField = value;
                    this.RaisePropertyChanged("COD_SERVICIO");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
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


            private string resultCodeField;

            private string messageField;

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
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, /*DataType = "integer",*/ Order = 0)]
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
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, /*DataType = "integer",*/ Order = 0)]
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

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "integer", Order = 1)]
            public string resultCode
            {
                get
                {
                    return this.resultCodeField;
                }
                set
                {
                    this.resultCodeField = value;
                    this.RaisePropertyChanged("resultCode");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
            public string message
            {
                get
                {
                    return this.messageField;
                }
                set
                {
                    this.messageField = value;
                    this.RaisePropertyChanged("message");
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
        public partial class AddInvoiceResponse_Type : object, System.ComponentModel.INotifyPropertyChanged
        {

            private AddInvoiceResponseDetail_Type addInvoiceResponseDetailField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
            public AddInvoiceResponseDetail_Type addInvoiceResponseDetail
            {
                get
                {
                    return this.addInvoiceResponseDetailField;
                }
                set
                {
                    this.addInvoiceResponseDetailField = value;
                    this.RaisePropertyChanged("addInvoiceResponseDetail");
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
        public partial class DATOSRes_Type : object, System.ComponentModel.INotifyPropertyChanged
        {




            private string Cliente_RucField;

            private string Cliente_Cod_PartField;

            private string EndPoint_Cli_Cone_xionField;


            private string resultCodeField;

            private string messageField;

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
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, /*DataType = "integer",*/ Order = 0)]
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
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, /*DataType = "integer",*/ Order = 0)]
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

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "integer", Order = 1)]
            public string resultCode
            {
                get
                {
                    return this.resultCodeField;
                }
                set
                {
                    this.resultCodeField = value;
                    this.RaisePropertyChanged("resultCode");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
            public string message
            {
                get
                {
                    return this.messageField;
                }
                set
                {
                    this.messageField = value;
                    this.RaisePropertyChanged("message");
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


            ///// <remarks/>
            //[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
            //public AddInvoiceResponse_Type addInvoiceResponse
            //{
            //    get
            //    {
            //        return this.addInvoiceResponseField;
            //    }
            //    set
            //    {
            //        this.addInvoiceResponseField = value;
            //        this.RaisePropertyChanged("addInvoiceResponse");
            //    }
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

            private string cOD_SERVICIOField;

            private string aPP_CONSUMIDORAField;

            private string tIP_RESPUESTAField;

            private string cOD_RESPUESTAField;

            private string dES_RESPUESTAField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
            public string COD_SERVICIO
            {
                get
                {
                    return this.cOD_SERVICIOField;
                }
                set
                {
                    this.cOD_SERVICIOField = value;
                    this.RaisePropertyChanged("COD_SERVICIO");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
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
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
            public string TIP_RESPUESTA
            {
                get
                {
                    return this.tIP_RESPUESTAField;
                }
                set
                {
                    this.tIP_RESPUESTAField = value;
                    this.RaisePropertyChanged("TIP_RESPUESTA");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
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
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
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
        public partial class Payment_Type : object, System.ComponentModel.INotifyPropertyChanged
        {

            private string numberField;

            private decimal netAmountField;

            private string paymentDateField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "integer", Order = 0)]
            public string number
            {
                get
                {
                    return this.numberField;
                }
                set
                {
                    this.numberField = value;
                    this.RaisePropertyChanged("number");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
            public decimal netAmount
            {
                get
                {
                    return this.netAmountField;
                }
                set
                {
                    this.netAmountField = value;
                    this.RaisePropertyChanged("netAmount");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
            public string paymentDate
            {
                get
                {
                    return this.paymentDateField;
                }
                set
                {
                    this.paymentDateField = value;
                    this.RaisePropertyChanged("paymentDate");
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
        public partial class Invoice_Type : object, System.ComponentModel.INotifyPropertyChanged
        {

            private string invoiceTypeField;

            private string providerRucField;

            private string seriesField;

            private string numerationField;

            private string authorizationNumberField;

            private string businessNameField;

            private string departmentField;

            private string provinceField;

            private string districtField;

            private string addressField;

            private string phoneNumberField;

            private string acqFullNameField;

            private string acqContactNameField;

            private string acqRUCField;

            private string acqDepartmentField;

            private string acqProvinceField;

            private string acqDistrictField;

            private string acqAddressField;

            private string acqPhoneNumberField;

            private string acqEmailField;

            private string emissionDateField;

            private string guideNumberField;

            private string ocNumberField;

            private string currencyTypeField;

            private decimal grossAmountField;

            private decimal igvField;

            private decimal netAmountField;

            private string conceptField;

            private string expirationDateField;

            private string typePaymentField;

            private string numberQuotaField;

            private string deliverDateInvoiceField;

            private string deliverDateAcqField;

            private string aceptedDateField;

            private string paymentDateField;

            private decimal netAmountPendingField;

            private bool netAmountPendingFieldSpecified;

            private string other1Field;

            private string other2Field;

            private Payment_Type[] paymentDetailField;

            private string additionalField1Field;

            private string additionalField2Field;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
            public string invoiceType
            {
                get
                {
                    return this.invoiceTypeField;
                }
                set
                {
                    this.invoiceTypeField = value;
                    this.RaisePropertyChanged("invoiceType");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "integer", Order = 1)]
            public string providerRuc
            {
                get
                {
                    return this.providerRucField;
                }
                set
                {
                    this.providerRucField = value;
                    this.RaisePropertyChanged("providerRuc");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
            public string series
            {
                get
                {
                    return this.seriesField;
                }
                set
                {
                    this.seriesField = value;
                    this.RaisePropertyChanged("series");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "integer", Order = 3)]
            public string numeration
            {
                get
                {
                    return this.numerationField;
                }
                set
                {
                    this.numerationField = value;
                    this.RaisePropertyChanged("numeration");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
            public string authorizationNumber
            {
                get
                {
                    return this.authorizationNumberField;
                }
                set
                {
                    this.authorizationNumberField = value;
                    this.RaisePropertyChanged("authorizationNumber");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
            public string businessName
            {
                get
                {
                    return this.businessNameField;
                }
                set
                {
                    this.businessNameField = value;
                    this.RaisePropertyChanged("businessName");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 6)]
            public string department
            {
                get
                {
                    return this.departmentField;
                }
                set
                {
                    this.departmentField = value;
                    this.RaisePropertyChanged("department");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 7)]
            public string province
            {
                get
                {
                    return this.provinceField;
                }
                set
                {
                    this.provinceField = value;
                    this.RaisePropertyChanged("province");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 8)]
            public string district
            {
                get
                {
                    return this.districtField;
                }
                set
                {
                    this.districtField = value;
                    this.RaisePropertyChanged("district");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 9)]
            public string address
            {
                get
                {
                    return this.addressField;
                }
                set
                {
                    this.addressField = value;
                    this.RaisePropertyChanged("address");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 10)]
            public string phoneNumber
            {
                get
                {
                    return this.phoneNumberField;
                }
                set
                {
                    this.phoneNumberField = value;
                    this.RaisePropertyChanged("phoneNumber");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 11)]
            public string acqFullName
            {
                get
                {
                    return this.acqFullNameField;
                }
                set
                {
                    this.acqFullNameField = value;
                    this.RaisePropertyChanged("acqFullName");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 12)]
            public string acqContactName
            {
                get
                {
                    return this.acqContactNameField;
                }
                set
                {
                    this.acqContactNameField = value;
                    this.RaisePropertyChanged("acqContactName");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "integer", Order = 13)]
            public string acqRUC
            {
                get
                {
                    return this.acqRUCField;
                }
                set
                {
                    this.acqRUCField = value;
                    this.RaisePropertyChanged("acqRUC");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 14)]
            public string acqDepartment
            {
                get
                {
                    return this.acqDepartmentField;
                }
                set
                {
                    this.acqDepartmentField = value;
                    this.RaisePropertyChanged("acqDepartment");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 15)]
            public string acqProvince
            {
                get
                {
                    return this.acqProvinceField;
                }
                set
                {
                    this.acqProvinceField = value;
                    this.RaisePropertyChanged("acqProvince");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 16)]
            public string acqDistrict
            {
                get
                {
                    return this.acqDistrictField;
                }
                set
                {
                    this.acqDistrictField = value;
                    this.RaisePropertyChanged("acqDistrict");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 17)]
            public string acqAddress
            {
                get
                {
                    return this.acqAddressField;
                }
                set
                {
                    this.acqAddressField = value;
                    this.RaisePropertyChanged("acqAddress");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 18)]
            public string acqPhoneNumber
            {
                get
                {
                    return this.acqPhoneNumberField;
                }
                set
                {
                    this.acqPhoneNumberField = value;
                    this.RaisePropertyChanged("acqPhoneNumber");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 19)]
            public string acqEmail
            {
                get
                {
                    return this.acqEmailField;
                }
                set
                {
                    this.acqEmailField = value;
                    this.RaisePropertyChanged("acqEmail");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 20)]
            public string emissionDate
            {
                get
                {
                    return this.emissionDateField;
                }
                set
                {
                    this.emissionDateField = value;
                    this.RaisePropertyChanged("emissionDate");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 21)]
            public string guideNumber
            {
                get
                {
                    return this.guideNumberField;
                }
                set
                {
                    this.guideNumberField = value;
                    this.RaisePropertyChanged("guideNumber");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "integer", Order = 22)]
            public string ocNumber
            {
                get
                {
                    return this.ocNumberField;
                }
                set
                {
                    this.ocNumberField = value;
                    this.RaisePropertyChanged("ocNumber");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "integer", Order = 23)]
            public string currencyType
            {
                get
                {
                    return this.currencyTypeField;
                }
                set
                {
                    this.currencyTypeField = value;
                    this.RaisePropertyChanged("currencyType");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 24)]
            public decimal grossAmount
            {
                get
                {
                    return this.grossAmountField;
                }
                set
                {
                    this.grossAmountField = value;
                    this.RaisePropertyChanged("grossAmount");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 25)]
            public decimal igv
            {
                get
                {
                    return this.igvField;
                }
                set
                {
                    this.igvField = value;
                    this.RaisePropertyChanged("igv");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 26)]
            public decimal netAmount
            {
                get
                {
                    return this.netAmountField;
                }
                set
                {
                    this.netAmountField = value;
                    this.RaisePropertyChanged("netAmount");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 27)]
            public string concept
            {
                get
                {
                    return this.conceptField;
                }
                set
                {
                    this.conceptField = value;
                    this.RaisePropertyChanged("concept");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 28)]
            public string expirationDate
            {
                get
                {
                    return this.expirationDateField;
                }
                set
                {
                    this.expirationDateField = value;
                    this.RaisePropertyChanged("expirationDate");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "integer", Order = 29)]
            public string typePayment
            {
                get
                {
                    return this.typePaymentField;
                }
                set
                {
                    this.typePaymentField = value;
                    this.RaisePropertyChanged("typePayment");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "integer", Order = 30)]
            public string numberQuota
            {
                get
                {
                    return this.numberQuotaField;
                }
                set
                {
                    this.numberQuotaField = value;
                    this.RaisePropertyChanged("numberQuota");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 31)]
            public string deliverDateInvoice
            {
                get
                {
                    return this.deliverDateInvoiceField;
                }
                set
                {
                    this.deliverDateInvoiceField = value;
                    this.RaisePropertyChanged("deliverDateInvoice");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 32)]
            public string deliverDateAcq
            {
                get
                {
                    return this.deliverDateAcqField;
                }
                set
                {
                    this.deliverDateAcqField = value;
                    this.RaisePropertyChanged("deliverDateAcq");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 33)]
            public string aceptedDate
            {
                get
                {
                    return this.aceptedDateField;
                }
                set
                {
                    this.aceptedDateField = value;
                    this.RaisePropertyChanged("aceptedDate");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 34)]
            public string paymentDate
            {
                get
                {
                    return this.paymentDateField;
                }
                set
                {
                    this.paymentDateField = value;
                    this.RaisePropertyChanged("paymentDate");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 35)]
            public decimal netAmountPending
            {
                get
                {
                    return this.netAmountPendingField;
                }
                set
                {
                    this.netAmountPendingField = value;
                    this.RaisePropertyChanged("netAmountPending");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool netAmountPendingSpecified
            {
                get
                {
                    return this.netAmountPendingFieldSpecified;
                }
                set
                {
                    this.netAmountPendingFieldSpecified = value;
                    this.RaisePropertyChanged("netAmountPendingSpecified");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 36)]
            public string other1
            {
                get
                {
                    return this.other1Field;
                }
                set
                {
                    this.other1Field = value;
                    this.RaisePropertyChanged("other1");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 37)]
            public string other2
            {
                get
                {
                    return this.other2Field;
                }
                set
                {
                    this.other2Field = value;
                    this.RaisePropertyChanged("other2");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 38)]
            [System.Xml.Serialization.XmlArrayItemAttribute("payment", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
            public Payment_Type[] paymentDetail
            {
                get
                {
                    return this.paymentDetailField;
                }
                set
                {
                    this.paymentDetailField = value;
                    this.RaisePropertyChanged("paymentDetail");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 39)]
            public string additionalField1
            {
                get
                {
                    return this.additionalField1Field;
                }
                set
                {
                    this.additionalField1Field = value;
                    this.RaisePropertyChanged("additionalField1");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 40)]
            public string additionalField2
            {
                get
                {
                    return this.additionalField2Field;
                }
                set
                {
                    this.additionalField2Field = value;
                    this.RaisePropertyChanged("additionalField2");
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
        public partial class ProcessDetail_Type : object, System.ComponentModel.INotifyPropertyChanged
        {

            private string processNumberField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "integer", Order = 0)]
            public string processNumber
            {
                get
                {
                    return this.processNumberField;
                }
                set
                {
                    this.processNumberField = value;
                    this.RaisePropertyChanged("processNumber");
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
        public partial class Consumer_Type : object, System.ComponentModel.INotifyPropertyChanged
        {

            private string typeField;

            private string participantCodeField;

            private string rucField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                    this.RaisePropertyChanged("type");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "integer", Order = 1)]
            public string participantCode
            {
                get
                {
                    return this.participantCodeField;
                }
                set
                {
                    this.participantCodeField = value;
                    this.RaisePropertyChanged("participantCode");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "integer", Order = 2)]
            public string ruc
            {
                get
                {
                    return this.rucField;
                }
                set
                {
                    this.rucField = value;
                    this.RaisePropertyChanged("ruc");
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
        public partial class AddInvoiceRequestDetail_Type : object, System.ComponentModel.INotifyPropertyChanged
        {

            private Consumer_Type consumerField;

            private ProcessDetail_Type processDetailField;

            private Invoice_Type[] invoiceDetailField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
            public Consumer_Type consumer
            {
                get
                {
                    return this.consumerField;
                }
                set
                {
                    this.consumerField = value;
                    this.RaisePropertyChanged("consumer");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
            public ProcessDetail_Type processDetail
            {
                get
                {
                    return this.processDetailField;
                }
                set
                {
                    this.processDetailField = value;
                    this.RaisePropertyChanged("processDetail");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
            [System.Xml.Serialization.XmlArrayItemAttribute("invoice", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
            public Invoice_Type[] invoiceDetail
            {
                get
                {
                    return this.invoiceDetailField;
                }
                set
                {
                    this.invoiceDetailField = value;
                    this.RaisePropertyChanged("invoiceDetail");
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
        public partial class AddInvoiceRequest_Type : object, System.ComponentModel.INotifyPropertyChanged
        {

            private AddInvoiceRequestDetail_Type addInvoiceRequestDetailField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
            public AddInvoiceRequestDetail_Type addInvoiceRequestDetail
            {
                get
                {
                    return this.addInvoiceRequestDetailField;
                }
                set
                {
                    this.addInvoiceRequestDetailField = value;
                    this.RaisePropertyChanged("addInvoiceRequestDetail");
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

            //private AddInvoiceRequest_Type addInvoiceRequestField;

            ///// <remarks/>
            //[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
            //public AddInvoiceRequest_Type addInvoiceRequest
            //{
            //    get
            //    {
            //        return this.addInvoiceRequestField;
            //    }
            //    set
            //    {
            //        this.addInvoiceRequestField = value;
            //        this.RaisePropertyChanged("addInvoiceRequest");
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

