﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace SeminarskaKNI107
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class ProdavnicaEntities11 : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new ProdavnicaEntities11 object using the connection string found in the 'ProdavnicaEntities11' section of the application configuration file.
        /// </summary>
        public ProdavnicaEntities11() : base("name=ProdavnicaEntities11", "ProdavnicaEntities11")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new ProdavnicaEntities11 object.
        /// </summary>
        public ProdavnicaEntities11(string connectionString) : base(connectionString, "ProdavnicaEntities11")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new ProdavnicaEntities11 object.
        /// </summary>
        public ProdavnicaEntities11(EntityConnection connection) : base(connection, "ProdavnicaEntities11")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<ViewSpecifikacii> ViewSpecifikaciis
        {
            get
            {
                if ((_ViewSpecifikaciis == null))
                {
                    _ViewSpecifikaciis = base.CreateObjectSet<ViewSpecifikacii>("ViewSpecifikaciis");
                }
                return _ViewSpecifikaciis;
            }
        }
        private ObjectSet<ViewSpecifikacii> _ViewSpecifikaciis;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the ViewSpecifikaciis EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToViewSpecifikaciis(ViewSpecifikacii viewSpecifikacii)
        {
            base.AddObject("ViewSpecifikaciis", viewSpecifikacii);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="ProdavnicaModel2", Name="ViewSpecifikacii")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class ViewSpecifikacii : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new ViewSpecifikacii object.
        /// </summary>
        /// <param name="proizvodID">Initial value of the ProizvodID property.</param>
        /// <param name="cena">Initial value of the Cena property.</param>
        /// <param name="ime">Initial value of the Ime property.</param>
        /// <param name="kolicina">Initial value of the Kolicina property.</param>
        /// <param name="proizvoditel">Initial value of the Proizvoditel property.</param>
        /// <param name="kategorija">Initial value of the Kategorija property.</param>
        /// <param name="opis">Initial value of the Opis property.</param>
        public static ViewSpecifikacii CreateViewSpecifikacii(global::System.Int32 proizvodID, global::System.Int64 cena, global::System.String ime, global::System.Int64 kolicina, global::System.String proizvoditel, global::System.String kategorija, global::System.String opis)
        {
            ViewSpecifikacii viewSpecifikacii = new ViewSpecifikacii();
            viewSpecifikacii.ProizvodID = proizvodID;
            viewSpecifikacii.Cena = cena;
            viewSpecifikacii.Ime = ime;
            viewSpecifikacii.Kolicina = kolicina;
            viewSpecifikacii.Proizvoditel = proizvoditel;
            viewSpecifikacii.Kategorija = kategorija;
            viewSpecifikacii.Opis = opis;
            return viewSpecifikacii;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ProizvodID
        {
            get
            {
                return _ProizvodID;
            }
            set
            {
                if (_ProizvodID != value)
                {
                    OnProizvodIDChanging(value);
                    ReportPropertyChanging("ProizvodID");
                    _ProizvodID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ProizvodID");
                    OnProizvodIDChanged();
                }
            }
        }
        private global::System.Int32 _ProizvodID;
        partial void OnProizvodIDChanging(global::System.Int32 value);
        partial void OnProizvodIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 Cena
        {
            get
            {
                return _Cena;
            }
            set
            {
                if (_Cena != value)
                {
                    OnCenaChanging(value);
                    ReportPropertyChanging("Cena");
                    _Cena = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Cena");
                    OnCenaChanged();
                }
            }
        }
        private global::System.Int64 _Cena;
        partial void OnCenaChanging(global::System.Int64 value);
        partial void OnCenaChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Ime
        {
            get
            {
                return _Ime;
            }
            set
            {
                if (_Ime != value)
                {
                    OnImeChanging(value);
                    ReportPropertyChanging("Ime");
                    _Ime = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("Ime");
                    OnImeChanged();
                }
            }
        }
        private global::System.String _Ime;
        partial void OnImeChanging(global::System.String value);
        partial void OnImeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 Kolicina
        {
            get
            {
                return _Kolicina;
            }
            set
            {
                if (_Kolicina != value)
                {
                    OnKolicinaChanging(value);
                    ReportPropertyChanging("Kolicina");
                    _Kolicina = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Kolicina");
                    OnKolicinaChanged();
                }
            }
        }
        private global::System.Int64 _Kolicina;
        partial void OnKolicinaChanging(global::System.Int64 value);
        partial void OnKolicinaChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Proizvoditel
        {
            get
            {
                return _Proizvoditel;
            }
            set
            {
                if (_Proizvoditel != value)
                {
                    OnProizvoditelChanging(value);
                    ReportPropertyChanging("Proizvoditel");
                    _Proizvoditel = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("Proizvoditel");
                    OnProizvoditelChanged();
                }
            }
        }
        private global::System.String _Proizvoditel;
        partial void OnProizvoditelChanging(global::System.String value);
        partial void OnProizvoditelChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Kategorija
        {
            get
            {
                return _Kategorija;
            }
            set
            {
                if (_Kategorija != value)
                {
                    OnKategorijaChanging(value);
                    ReportPropertyChanging("Kategorija");
                    _Kategorija = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("Kategorija");
                    OnKategorijaChanged();
                }
            }
        }
        private global::System.String _Kategorija;
        partial void OnKategorijaChanging(global::System.String value);
        partial void OnKategorijaChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Opis
        {
            get
            {
                return _Opis;
            }
            set
            {
                if (_Opis != value)
                {
                    OnOpisChanging(value);
                    ReportPropertyChanging("Opis");
                    _Opis = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("Opis");
                    OnOpisChanged();
                }
            }
        }
        private global::System.String _Opis;
        partial void OnOpisChanging(global::System.String value);
        partial void OnOpisChanged();

        #endregion
    
    }

    #endregion
    
}
