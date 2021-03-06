﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace SeminarskaKNI107
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class ProdavnicaEntities7 : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new ProdavnicaEntities7 object using the connection string found in the 'ProdavnicaEntities7' section of the application configuration file.
        /// </summary>
        public ProdavnicaEntities7() : base("name=ProdavnicaEntities7", "ProdavnicaEntities7")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new ProdavnicaEntities7 object.
        /// </summary>
        public ProdavnicaEntities7(string connectionString) : base(connectionString, "ProdavnicaEntities7")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new ProdavnicaEntities7 object.
        /// </summary>
        public ProdavnicaEntities7(EntityConnection connection) : base(connection, "ProdavnicaEntities7")
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
        public ObjectSet<Cena> Cenas
        {
            get
            {
                if ((_Cenas == null))
                {
                    _Cenas = base.CreateObjectSet<Cena>("Cenas");
                }
                return _Cenas;
            }
        }
        private ObjectSet<Cena> _Cenas;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Proizvod> Proizvods
        {
            get
            {
                if ((_Proizvods == null))
                {
                    _Proizvods = base.CreateObjectSet<Proizvod>("Proizvods");
                }
                return _Proizvods;
            }
        }
        private ObjectSet<Proizvod> _Proizvods;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<ProizvodCena> ProizvodCenas
        {
            get
            {
                if ((_ProizvodCenas == null))
                {
                    _ProizvodCenas = base.CreateObjectSet<ProizvodCena>("ProizvodCenas");
                }
                return _ProizvodCenas;
            }
        }
        private ObjectSet<ProizvodCena> _ProizvodCenas;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Cenas EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToCenas(Cena cena)
        {
            base.AddObject("Cenas", cena);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Proizvods EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToProizvods(Proizvod proizvod)
        {
            base.AddObject("Proizvods", proizvod);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the ProizvodCenas EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToProizvodCenas(ProizvodCena proizvodCena)
        {
            base.AddObject("ProizvodCenas", proizvodCena);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="ProdavnicaModel", Name="Cena")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Cena : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Cena object.
        /// </summary>
        /// <param name="proizvodID">Initial value of the ProizvodID property.</param>
        /// <param name="cena1">Initial value of the Cena1 property.</param>
        /// <param name="ime">Initial value of the Ime property.</param>
        /// <param name="sifraID">Initial value of the SifraID property.</param>
        public static Cena CreateCena(global::System.Int32 proizvodID, global::System.Int64 cena1, global::System.String ime, global::System.Int32 sifraID)
        {
            Cena cena = new Cena();
            cena.ProizvodID = proizvodID;
            cena.Cena1 = cena1;
            cena.Ime = ime;
            cena.SifraID = sifraID;
            return cena;
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
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 Cena1
        {
            get
            {
                return _Cena1;
            }
            set
            {
                OnCena1Changing(value);
                ReportPropertyChanging("Cena1");
                _Cena1 = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Cena1");
                OnCena1Changed();
            }
        }
        private global::System.Int64 _Cena1;
        partial void OnCena1Changing(global::System.Int64 value);
        partial void OnCena1Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Ime
        {
            get
            {
                return _Ime;
            }
            set
            {
                OnImeChanging(value);
                ReportPropertyChanging("Ime");
                _Ime = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Ime");
                OnImeChanged();
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
        public global::System.Int32 SifraID
        {
            get
            {
                return _SifraID;
            }
            set
            {
                if (_SifraID != value)
                {
                    OnSifraIDChanging(value);
                    ReportPropertyChanging("SifraID");
                    _SifraID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("SifraID");
                    OnSifraIDChanged();
                }
            }
        }
        private global::System.Int32 _SifraID;
        partial void OnSifraIDChanging(global::System.Int32 value);
        partial void OnSifraIDChanged();

        #endregion

    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="ProdavnicaModel", Name="Proizvod")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Proizvod : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Proizvod object.
        /// </summary>
        /// <param name="proizvodID">Initial value of the ProizvodID property.</param>
        /// <param name="ime">Initial value of the Ime property.</param>
        /// <param name="kolicina">Initial value of the Kolicina property.</param>
        /// <param name="proizvoditel">Initial value of the Proizvoditel property.</param>
        /// <param name="kategorija">Initial value of the Kategorija property.</param>
        public static Proizvod CreateProizvod(global::System.Int32 proizvodID, global::System.String ime, global::System.Int64 kolicina, global::System.String proizvoditel, global::System.String kategorija)
        {
            Proizvod proizvod = new Proizvod();
            proizvod.ProizvodID = proizvodID;
            proizvod.Ime = ime;
            proizvod.Kolicina = kolicina;
            proizvod.Proizvoditel = proizvoditel;
            proizvod.Kategorija = kategorija;
            return proizvod;
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
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Ime
        {
            get
            {
                return _Ime;
            }
            set
            {
                OnImeChanging(value);
                ReportPropertyChanging("Ime");
                _Ime = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Ime");
                OnImeChanged();
            }
        }
        private global::System.String _Ime;
        partial void OnImeChanging(global::System.String value);
        partial void OnImeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 Kolicina
        {
            get
            {
                return _Kolicina;
            }
            set
            {
                OnKolicinaChanging(value);
                ReportPropertyChanging("Kolicina");
                _Kolicina = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Kolicina");
                OnKolicinaChanged();
            }
        }
        private global::System.Int64 _Kolicina;
        partial void OnKolicinaChanging(global::System.Int64 value);
        partial void OnKolicinaChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Proizvoditel
        {
            get
            {
                return _Proizvoditel;
            }
            set
            {
                OnProizvoditelChanging(value);
                ReportPropertyChanging("Proizvoditel");
                _Proizvoditel = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Proizvoditel");
                OnProizvoditelChanged();
            }
        }
        private global::System.String _Proizvoditel;
        partial void OnProizvoditelChanging(global::System.String value);
        partial void OnProizvoditelChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Kategorija
        {
            get
            {
                return _Kategorija;
            }
            set
            {
                OnKategorijaChanging(value);
                ReportPropertyChanging("Kategorija");
                _Kategorija = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Kategorija");
                OnKategorijaChanged();
            }
        }
        private global::System.String _Kategorija;
        partial void OnKategorijaChanging(global::System.String value);
        partial void OnKategorijaChanged();

        #endregion

    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="ProdavnicaModel", Name="ProizvodCena")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class ProizvodCena : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new ProizvodCena object.
        /// </summary>
        /// <param name="proizvodID">Initial value of the ProizvodID property.</param>
        /// <param name="ime">Initial value of the Ime property.</param>
        /// <param name="opis">Initial value of the Opis property.</param>
        public static ProizvodCena CreateProizvodCena(global::System.Int32 proizvodID, global::System.String ime, global::System.String opis)
        {
            ProizvodCena proizvodCena = new ProizvodCena();
            proizvodCena.ProizvodID = proizvodID;
            proizvodCena.Ime = ime;
            proizvodCena.Opis = opis;
            return proizvodCena;
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
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Ime
        {
            get
            {
                return _Ime;
            }
            set
            {
                OnImeChanging(value);
                ReportPropertyChanging("Ime");
                _Ime = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Ime");
                OnImeChanged();
            }
        }
        private global::System.String _Ime;
        partial void OnImeChanging(global::System.String value);
        partial void OnImeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Opis
        {
            get
            {
                return _Opis;
            }
            set
            {
                OnOpisChanging(value);
                ReportPropertyChanging("Opis");
                _Opis = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Opis");
                OnOpisChanged();
            }
        }
        private global::System.String _Opis;
        partial void OnOpisChanging(global::System.String value);
        partial void OnOpisChanged();

        #endregion

    
    }

    #endregion

    
}
