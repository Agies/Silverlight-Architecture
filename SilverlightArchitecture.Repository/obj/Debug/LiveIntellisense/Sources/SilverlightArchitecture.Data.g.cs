//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SilverlightArchitecture.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.ServiceModel;
    using System.ServiceModel.DomainServices;
    using System.ServiceModel.DomainServices.Client;
    using System.ServiceModel.DomainServices.Client.ApplicationServices;
    using System.ServiceModel.Web;
    using System.Xml.Serialization;
    
    
    /// <summary>
    /// The 'Address' entity class.
    /// </summary>
    [DataContract(Namespace="http://schemas.datacontract.org/2004/07/SilverlightArchitecture.Data")]
    public sealed partial class Address : BusinessBase
    {
        
        private string _address1;
        
        private string _address2;
        
        private int _entityId;
        
        private EntityRef<Entity> _owner;
        
        #region Extensibility Method Definitions

        /// <summary>
        /// This method is invoked from the constructor once initialization is complete and
        /// can be used for further object setup.
        /// </summary>
        partial void OnCreated();
        partial void OnAddress1Changing(string value);
        partial void OnAddress1Changed();
        partial void OnAddress2Changing(string value);
        partial void OnAddress2Changed();
        partial void OnEntityIdChanging(int value);
        partial void OnEntityIdChanged();

        #endregion
        
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Address"/> class.
        /// </summary>
        public Address()
        {
            this.OnCreated();
        }
        
        /// <summary>
        /// Gets or sets the 'Address1' value.
        /// </summary>
        [DataMember()]
        [Required()]
        public string Address1
        {
            get
            {
                return this._address1;
            }
            set
            {
                if ((this._address1 != value))
                {
                    this.OnAddress1Changing(value);
                    this.RaiseDataMemberChanging("Address1");
                    this.ValidateProperty("Address1", value);
                    this._address1 = value;
                    this.RaiseDataMemberChanged("Address1");
                    this.OnAddress1Changed();
                }
            }
        }
        
        /// <summary>
        /// Gets or sets the 'Address2' value.
        /// </summary>
        [DataMember()]
        [Required()]
        public string Address2
        {
            get
            {
                return this._address2;
            }
            set
            {
                if ((this._address2 != value))
                {
                    this.OnAddress2Changing(value);
                    this.RaiseDataMemberChanging("Address2");
                    this.ValidateProperty("Address2", value);
                    this._address2 = value;
                    this.RaiseDataMemberChanged("Address2");
                    this.OnAddress2Changed();
                }
            }
        }
        
        /// <summary>
        /// Gets or sets the 'EntityId' value.
        /// </summary>
        [DataMember()]
        [RoundtripOriginal()]
        public int EntityId
        {
            get
            {
                return this._entityId;
            }
            set
            {
                if ((this._entityId != value))
                {
                    this.OnEntityIdChanging(value);
                    this.RaiseDataMemberChanging("EntityId");
                    this.ValidateProperty("EntityId", value);
                    this._entityId = value;
                    this.RaiseDataMemberChanged("EntityId");
                    this.OnEntityIdChanged();
                }
            }
        }
        
        /// <summary>
        /// Gets or sets the associated <see cref="Entity"/> entity.
        /// </summary>
        [Association("Entity_Address", "EntityId", "Id", IsForeignKey=true)]
        [XmlIgnore()]
        public Entity Owner
        {
            get
            {
                if ((this._owner == null))
                {
                    this._owner = new EntityRef<Entity>(this, "Owner", this.FilterOwner);
                }
                return this._owner.Entity;
            }
            set
            {
                Entity previous = this.Owner;
                if ((previous != value))
                {
                    this.ValidateProperty("Owner", value);
                    if ((previous != null))
                    {
                        this._owner.Entity = null;
                        previous.Addresses.Remove(this);
                    }
                    if ((value != null))
                    {
                        this.EntityId = value.Id;
                    }
                    else
                    {
                        this.EntityId = default(int);
                    }
                    this._owner.Entity = value;
                    if ((value != null))
                    {
                        value.Addresses.Add(this);
                    }
                    this.RaisePropertyChanged("Owner");
                }
            }
        }
        
        private bool FilterOwner(Entity entity)
        {
            return (entity.Id == this.EntityId);
        }
    }
    
    /// <summary>
    /// The 'BusinessBase' entity class.
    /// </summary>
    [DataContract(Namespace="http://schemas.datacontract.org/2004/07/SilverlightArchitecture.Data")]
    [KnownType(typeof(Address))]
    [KnownType(typeof(Company))]
    [KnownType(typeof(Entity))]
    [KnownType(typeof(Person))]
    public abstract partial class BusinessBase : System.ServiceModel.DomainServices.Client.Entity
    {
        
        private string _createdBy;
        
        private DateTime _createdDate;
        
        private int _id;
        
        #region Extensibility Method Definitions

        /// <summary>
        /// This method is invoked from the constructor once initialization is complete and
        /// can be used for further object setup.
        /// </summary>
        partial void OnCreated();
        partial void OnCreatedByChanging(string value);
        partial void OnCreatedByChanged();
        partial void OnCreatedDateChanging(DateTime value);
        partial void OnCreatedDateChanged();
        partial void OnIdChanging(int value);
        partial void OnIdChanged();

        #endregion
        
        
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessBase"/> class.
        /// </summary>
        protected BusinessBase()
        {
            this.OnCreated();
        }
        
        /// <summary>
        /// Gets or sets the 'CreatedBy' value.
        /// </summary>
        [DataMember()]
        [Required()]
        public string CreatedBy
        {
            get
            {
                return this._createdBy;
            }
            set
            {
                if ((this._createdBy != value))
                {
                    this.OnCreatedByChanging(value);
                    this.RaiseDataMemberChanging("CreatedBy");
                    this.ValidateProperty("CreatedBy", value);
                    this._createdBy = value;
                    this.RaiseDataMemberChanged("CreatedBy");
                    this.OnCreatedByChanged();
                }
            }
        }
        
        /// <summary>
        /// Gets or sets the 'CreatedDate' value.
        /// </summary>
        [DataMember()]
        public DateTime CreatedDate
        {
            get
            {
                return this._createdDate;
            }
            set
            {
                if ((this._createdDate != value))
                {
                    this.OnCreatedDateChanging(value);
                    this.RaiseDataMemberChanging("CreatedDate");
                    this.ValidateProperty("CreatedDate", value);
                    this._createdDate = value;
                    this.RaiseDataMemberChanged("CreatedDate");
                    this.OnCreatedDateChanged();
                }
            }
        }
        
        /// <summary>
        /// Gets or sets the 'Id' value.
        /// </summary>
        [DataMember()]
        [Editable(false, AllowInitialValue=true)]
        [Key()]
        [RoundtripOriginal()]
        public int Id
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((this._id != value))
                {
                    this.OnIdChanging(value);
                    this.ValidateProperty("Id", value);
                    this._id = value;
                    this.RaisePropertyChanged("Id");
                    this.OnIdChanged();
                }
            }
        }
        
        /// <summary>
        /// Computes a value from the key fields that uniquely identifies this entity instance.
        /// </summary>
        /// <returns>An object instance that uniquely identifies this entity instance.</returns>
        public override object GetIdentity()
        {
            return this._id;
        }
    }
    
    /// <summary>
    /// The 'Company' entity class.
    /// </summary>
    [DataContract(Namespace="http://schemas.datacontract.org/2004/07/SilverlightArchitecture.Data")]
    public sealed partial class Company : Entity
    {
        
        private EntityCollection<Company> _children;
        
        private int _companyId;
        
        private EntityRef<Company> _parent;
        
        #region Extensibility Method Definitions

        /// <summary>
        /// This method is invoked from the constructor once initialization is complete and
        /// can be used for further object setup.
        /// </summary>
        partial void OnCreated();
        partial void OnCompanyIdChanging(int value);
        partial void OnCompanyIdChanged();

        #endregion
        
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Company"/> class.
        /// </summary>
        public Company()
        {
            this.OnCreated();
        }
        
        /// <summary>
        /// Gets the collection of associated <see cref="Company"/> entities.
        /// </summary>
        [Association("Company_Company", "Id", "CompanyId")]
        [XmlIgnore()]
        public EntityCollection<Company> Children
        {
            get
            {
                if ((this._children == null))
                {
                    this._children = new EntityCollection<Company>(this, "Children", this.FilterChildren, this.AttachChildren, this.DetachChildren);
                }
                return this._children;
            }
        }
        
        /// <summary>
        /// Gets or sets the 'CompanyId' value.
        /// </summary>
        [DataMember()]
        [RoundtripOriginal()]
        public int CompanyId
        {
            get
            {
                return this._companyId;
            }
            set
            {
                if ((this._companyId != value))
                {
                    this.OnCompanyIdChanging(value);
                    this.RaiseDataMemberChanging("CompanyId");
                    this.ValidateProperty("CompanyId", value);
                    this._companyId = value;
                    this.RaiseDataMemberChanged("CompanyId");
                    this.OnCompanyIdChanged();
                }
            }
        }
        
        /// <summary>
        /// Gets or sets the associated <see cref="Company"/> entity.
        /// </summary>
        [Association("Company_Company", "CompanyId", "Id", IsForeignKey=true)]
        [XmlIgnore()]
        public Company Parent
        {
            get
            {
                if ((this._parent == null))
                {
                    this._parent = new EntityRef<Company>(this, "Parent", this.FilterParent);
                }
                return this._parent.Entity;
            }
            set
            {
                Company previous = this.Parent;
                if ((previous != value))
                {
                    this.ValidateProperty("Parent", value);
                    if ((previous != null))
                    {
                        this._parent.Entity = null;
                        previous.Children.Remove(this);
                    }
                    if ((value != null))
                    {
                        this.CompanyId = value.Id;
                    }
                    else
                    {
                        this.CompanyId = default(int);
                    }
                    this._parent.Entity = value;
                    if ((value != null))
                    {
                        value.Children.Add(this);
                    }
                    this.RaisePropertyChanged("Parent");
                }
            }
        }
        
        private void AttachChildren(Company entity)
        {
            entity.Parent = this;
        }
        
        private void DetachChildren(Company entity)
        {
            entity.Parent = null;
        }
        
        private bool FilterChildren(Company entity)
        {
            return (entity.CompanyId == this.Id);
        }
        
        private bool FilterParent(Company entity)
        {
            return (entity.Id == this.CompanyId);
        }
    }
    
    /// <summary>
    /// The 'Entity' entity class.
    /// </summary>
    [DataContract(Namespace="http://schemas.datacontract.org/2004/07/SilverlightArchitecture.Data")]
    public abstract partial class Entity : BusinessBase
    {
        
        private EntityCollection<Address> _addresses;
        
        #region Extensibility Method Definitions

        /// <summary>
        /// This method is invoked from the constructor once initialization is complete and
        /// can be used for further object setup.
        /// </summary>
        partial void OnCreated();

        #endregion
        
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Entity"/> class.
        /// </summary>
        protected Entity()
        {
            this.OnCreated();
        }
        
        /// <summary>
        /// Gets the collection of associated <see cref="Address"/> entities.
        /// </summary>
        [Association("Entity_Address", "Id", "EntityId")]
        [XmlIgnore()]
        public EntityCollection<Address> Addresses
        {
            get
            {
                if ((this._addresses == null))
                {
                    this._addresses = new EntityCollection<Address>(this, "Addresses", this.FilterAddresses, this.AttachAddresses, this.DetachAddresses);
                }
                return this._addresses;
            }
        }
        
        private void AttachAddresses(Address entity)
        {
            entity.Owner = this;
        }
        
        private void DetachAddresses(Address entity)
        {
            entity.Owner = null;
        }
        
        private bool FilterAddresses(Address entity)
        {
            return (entity.EntityId == this.Id);
        }
    }
    
    /// <summary>
    /// The 'Person' entity class.
    /// </summary>
    [DataContract(Namespace="http://schemas.datacontract.org/2004/07/SilverlightArchitecture.Data")]
    public sealed partial class Person : Entity
    {
        
        private string _firstName;
        
        private string _lastName;
        
        #region Extensibility Method Definitions

        /// <summary>
        /// This method is invoked from the constructor once initialization is complete and
        /// can be used for further object setup.
        /// </summary>
        partial void OnCreated();
        partial void OnFirstNameChanging(string value);
        partial void OnFirstNameChanged();
        partial void OnLastNameChanging(string value);
        partial void OnLastNameChanged();

        #endregion
        
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// </summary>
        public Person()
        {
            this.OnCreated();
        }
        
        /// <summary>
        /// Gets or sets the 'FirstName' value.
        /// </summary>
        [DataMember()]
        [Required()]
        public string FirstName
        {
            get
            {
                return this._firstName;
            }
            set
            {
                if ((this._firstName != value))
                {
                    this.OnFirstNameChanging(value);
                    this.RaiseDataMemberChanging("FirstName");
                    this.ValidateProperty("FirstName", value);
                    this._firstName = value;
                    this.RaiseDataMemberChanged("FirstName");
                    this.OnFirstNameChanged();
                }
            }
        }
        
        /// <summary>
        /// Gets or sets the 'LastName' value.
        /// </summary>
        [DataMember()]
        [Required()]
        public string LastName
        {
            get
            {
                return this._lastName;
            }
            set
            {
                if ((this._lastName != value))
                {
                    this.OnLastNameChanging(value);
                    this.RaiseDataMemberChanging("LastName");
                    this.ValidateProperty("LastName", value);
                    this._lastName = value;
                    this.RaiseDataMemberChanged("LastName");
                    this.OnLastNameChanged();
                }
            }
        }
    }
    
    /// <summary>
    /// The domain context corresponding to the 'SampleDataService' domain service.
    /// </summary>
    public sealed partial class SampleDataContext : DomainContext
    {
        
        #region Extensibility Method Definitions

        /// <summary>
        /// This method is invoked from the constructor once initialization is complete and
        /// can be used for further object setup.
        /// </summary>
        partial void OnCreated();

        #endregion
        
        
        /// <summary>
        /// Initializes a new instance of the <see cref="SampleDataContext"/> class.
        /// </summary>
        public SampleDataContext() : 
                this(new WebDomainClient<ISampleDataServiceContract>(new Uri("SilverlightArchitecture-Data-SampleDataService.svc", UriKind.Relative)))
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="SampleDataContext"/> class with the specified service URI.
        /// </summary>
        /// <param name="serviceUri">The SampleDataService service URI.</param>
        public SampleDataContext(Uri serviceUri) : 
                this(new WebDomainClient<ISampleDataServiceContract>(serviceUri))
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="SampleDataContext"/> class with the specified <paramref name="domainClient"/>.
        /// </summary>
        /// <param name="domainClient">The DomainClient instance to use for this domain context.</param>
        public SampleDataContext(DomainClient domainClient) : 
                base(domainClient)
        {
            this.OnCreated();
        }
        
        /// <summary>
        /// Gets the set of <see cref="BusinessBase"/> entities that have been loaded into this <see cref="SampleDataContext"/> instance.
        /// </summary>
        public EntitySet<BusinessBase> BusinessBases
        {
            get
            {
                return base.EntityContainer.GetEntitySet<BusinessBase>();
            }
        }
        
        /// <summary>
        /// Gets an EntityQuery instance that can be used to load <see cref="BusinessBase"/> entities using the 'GetBusinessBases' query.
        /// </summary>
        /// <returns>An EntityQuery that can be loaded to retrieve <see cref="BusinessBase"/> entities.</returns>
        public EntityQuery<BusinessBase> GetBusinessBasesQuery()
        {
            this.ValidateMethod("GetBusinessBasesQuery", null);
            return base.CreateQuery<BusinessBase>("GetBusinessBases", null, false, true);
        }
        
        /// <summary>
        /// Creates a new entity container for this domain context's entity sets.
        /// </summary>
        /// <returns>A new container instance.</returns>
        protected override EntityContainer CreateEntityContainer()
        {
            return new SampleDataContextEntityContainer();
        }
        
        /// <summary>
        /// Service contract for the 'SampleDataService' domain service.
        /// </summary>
        [ServiceContract()]
        public interface ISampleDataServiceContract
        {
            
            /// <summary>
            /// Asynchronously invokes the 'GetBusinessBases' operation.
            /// </summary>
            /// <param name="callback">Callback to invoke on completion.</param>
            /// <param name="asyncState">Optional state object.</param>
            /// <returns>An IAsyncResult that can be used to monitor the request.</returns>
            [FaultContract(typeof(DomainServiceFault), Action="http://tempuri.org/SampleDataService/GetBusinessBasesDomainServiceFault", Name="DomainServiceFault", Namespace="DomainServices")]
            [OperationContract(AsyncPattern=true, Action="http://tempuri.org/SampleDataService/GetBusinessBases", ReplyAction="http://tempuri.org/SampleDataService/GetBusinessBasesResponse")]
            [WebGet()]
            IAsyncResult BeginGetBusinessBases(AsyncCallback callback, object asyncState);
            
            /// <summary>
            /// Completes the asynchronous operation begun by 'BeginGetBusinessBases'.
            /// </summary>
            /// <param name="result">The IAsyncResult returned from 'BeginGetBusinessBases'.</param>
            /// <returns>The 'QueryResult' returned from the 'GetBusinessBases' operation.</returns>
            QueryResult<BusinessBase> EndGetBusinessBases(IAsyncResult result);
            
            /// <summary>
            /// Asynchronously invokes the 'SubmitChanges' operation.
            /// </summary>
            /// <param name="changeSet">The change-set to submit.</param>
            /// <param name="callback">Callback to invoke on completion.</param>
            /// <param name="asyncState">Optional state object.</param>
            /// <returns>An IAsyncResult that can be used to monitor the request.</returns>
            [FaultContract(typeof(DomainServiceFault), Action="http://tempuri.org/SampleDataService/SubmitChangesDomainServiceFault", Name="DomainServiceFault", Namespace="DomainServices")]
            [OperationContract(AsyncPattern=true, Action="http://tempuri.org/SampleDataService/SubmitChanges", ReplyAction="http://tempuri.org/SampleDataService/SubmitChangesResponse")]
            IAsyncResult BeginSubmitChanges(IEnumerable<ChangeSetEntry> changeSet, AsyncCallback callback, object asyncState);
            
            /// <summary>
            /// Completes the asynchronous operation begun by 'BeginSubmitChanges'.
            /// </summary>
            /// <param name="result">The IAsyncResult returned from 'BeginSubmitChanges'.</param>
            /// <returns>The collection of change-set entry elements returned from 'SubmitChanges'.</returns>
            IEnumerable<ChangeSetEntry> EndSubmitChanges(IAsyncResult result);
        }
        
        internal sealed class SampleDataContextEntityContainer : EntityContainer
        {
            
            public SampleDataContextEntityContainer()
            {
                this.CreateEntitySet<BusinessBase>(EntitySetOperations.All);
            }
        }
    }
}
