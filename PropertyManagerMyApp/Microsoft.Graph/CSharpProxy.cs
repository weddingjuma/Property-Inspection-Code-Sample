namespace Microsoft.Graph

{

    using global::Microsoft.OData.Client;

    using global::Microsoft.OData.Edm;

    using System;

    using System.Collections.Generic;

    using System.ComponentModel;

    using System.Linq;

    using System.Reflection;

    using System.Threading.Tasks;

    public enum attendeeType : int

    {

        required
         = 0
        ,
        optional
         = 1
        ,
        resource
         = 2
        ,
    }

    

    public enum freeBusyStatus : int

    {

        free
         = 0
        ,
        tentative
         = 1
        ,
        busy
         = 2
        ,
        oof
         = 3
        ,
        workingElsewhere
         = 4
        ,
        unknown
         = -1
        ,
    }

    

    public enum activityDomain : int

    {

        unknown
         = 0
        ,
        work
         = 1
        ,
        personal
         = 2
        ,
    }

    

    public enum bodyType : int

    {

        text
         = 0
        ,
        html
         = 1
        ,
    }

    

    public enum importance : int

    {

        low
         = 0
        ,
        normal
         = 1
        ,
        high
         = 2
        ,
    }

    

    public enum inferenceClassificationType : int

    {

        focused
         = 0
        ,
        other
         = 1
        ,
    }

    

    public enum calendarColor : int

    {

        lightBlue
         = 0
        ,
        lightGreen
         = 1
        ,
        lightOrange
         = 2
        ,
        lightGray
         = 3
        ,
        lightYellow
         = 4
        ,
        lightTeal
         = 5
        ,
        lightPink
         = 6
        ,
        lightBrown
         = 7
        ,
        lightRed
         = 8
        ,
        maxColor
         = 9
        ,
        auto
         = -1
        ,
    }

    

    public enum responseType : int

    {

        none
         = 0
        ,
        organizer
         = 1
        ,
        tentativelyAccepted
         = 2
        ,
        accepted
         = 3
        ,
        declined
         = 4
        ,
        notResponded
         = 5
        ,
    }

    

    public enum sensitivity : int

    {

        normal
         = 0
        ,
        personal
         = 1
        ,
        Private
         = 2
        ,
        confidential
         = 3
        ,
    }

    

    public enum recurrencePatternType : int

    {

        daily
         = 0
        ,
        weekly
         = 1
        ,
        absoluteMonthly
         = 2
        ,
        relativeMonthly
         = 3
        ,
        absoluteYearly
         = 4
        ,
        relativeYearly
         = 5
        ,
    }

    

    public enum dayOfWeek : int

    {

        sunday
         = 0
        ,
        monday
         = 1
        ,
        tuesday
         = 2
        ,
        wednesday
         = 3
        ,
        thursday
         = 4
        ,
        friday
         = 5
        ,
        saturday
         = 6
        ,
    }

    

    public enum weekIndex : int

    {

        first
         = 0
        ,
        second
         = 1
        ,
        third
         = 2
        ,
        fourth
         = 3
        ,
        last
         = 4
        ,
    }

    

    public enum recurrenceRangeType : int

    {

        endDate
         = 0
        ,
        noEnd
         = 1
        ,
        numbered
         = 2
        ,
    }

    

    public enum eventType : int

    {

        singleInstance
         = 0
        ,
        occurrence
         = 1
        ,
        exception
         = 2
        ,
        seriesMaster
         = 3
        ,
    }

    

    public enum meetingMessageType : int

    {

        none
         = 0
        ,
        meetingRequest
         = 1
        ,
        meetingCancelled
         = 2
        ,
        meetingAccepted
         = 3
        ,
        meetingTenativelyAccepted
         = 4
        ,
        meetingDeclined
         = 5
        ,
    }

    

    public enum groupAccessType : int

    {

        none
         = 0
        ,
        Private
         = 1
        ,
        secret
         = 2
        ,
        Public
         = 3
        ,
    }

    

    public enum PatchInsertPosition : int

    {

        After
         = 0
        ,
        Before
         = 1
        ,
    }

    

    public enum PatchActionType : int

    {

        Replace
         = 0
        ,
        Append
         = 1
        ,
        Delete
         = 2
        ,
        Insert
         = 3
        ,
        Prepend
         = 4
        ,
    }

    

    public enum UserRole : int

    {

        Owner
         = 0
        ,
        Contributor
         = 1
        ,
        Reader
         = 2
        ,
        None
         = -1
        ,
    }

    

    public enum taskBoardType : int

    {

        progress
         = 0
        ,
        assignedTo
         = 1
        ,
        bucket
         = 2
        ,
    }

    

    public enum previewType : int

    {

        automatic
         = 0
        ,
        noPreview
         = 1
        ,
        checklist
         = 2
        ,
        description
         = 3
        ,
        reference
         = 4
        ,
    }

    

    public partial class addIn:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private System.Nullable<System.Guid> _id;

        private System.String _type;

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.keyValue> _properties;

        public System.Nullable<System.Guid> id

        {

            get

            {

                return _id;

            }

            set

            {

                if (value != _id)

                {

                    _id = value;

                    OnPropertyChanged("id");

                }

            }

        }

        public System.String type

        {

            get

            {

                return _type;

            }

            set

            {

                if (value != _type)

                {

                    _type = value;

                    OnPropertyChanged("type");

                }

            }

        }

        public System.Collections.Generic.IList<global::Microsoft.Graph.keyValue> properties

        {

            get

            {

                if (this._properties == default(System.Collections.Generic.IList<global::Microsoft.Graph.keyValue>))

                {

                    this._properties = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.keyValue>();

                    this._properties.SetContainer(() => GetContainingEntity("properties"));

                }

                return this._properties;

            }

            set

            {

                properties.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        properties.Add(i);

                    }

                }

            }

        }

        public addIn(): base()

        {

        }

    }

    public partial class keyValue:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private System.String _key;

        private System.String _value;

        public System.String key

        {

            get

            {

                return _key;

            }

            set

            {

                if (value != _key)

                {

                    _key = value;

                    OnPropertyChanged("key");

                }

            }

        }

        public System.String value

        {

            get

            {

                return _value;

            }

            set

            {

                if (value != _value)

                {

                    _value = value;

                    OnPropertyChanged("value");

                }

            }

        }

        public keyValue(): base()

        {

        }

    }

    public partial class appRole:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.String> _allowedMemberTypes;

        private System.String _description;

        private System.String _displayName;

        private System.Guid _id;

        private System.Boolean _isEnabled;

        private System.String _origin;

        private System.String _value;

        public System.Collections.Generic.IList<System.String> allowedMemberTypes

        {

            get

            {

                if (this._allowedMemberTypes == default(System.Collections.Generic.IList<System.String>))

                {

                    this._allowedMemberTypes = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.String>();

                    this._allowedMemberTypes.SetContainer(() => GetContainingEntity("allowedMemberTypes"));

                }

                return this._allowedMemberTypes;

            }

            set

            {

                allowedMemberTypes.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        allowedMemberTypes.Add(i);

                    }

                }

            }

        }

        public System.String description

        {

            get

            {

                return _description;

            }

            set

            {

                if (value != _description)

                {

                    _description = value;

                    OnPropertyChanged("description");

                }

            }

        }

        public System.String displayName

        {

            get

            {

                return _displayName;

            }

            set

            {

                if (value != _displayName)

                {

                    _displayName = value;

                    OnPropertyChanged("displayName");

                }

            }

        }

        public System.Guid id

        {

            get

            {

                return _id;

            }

            set

            {

                if (value != _id)

                {

                    _id = value;

                    OnPropertyChanged("id");

                }

            }

        }

        public System.Boolean isEnabled

        {

            get

            {

                return _isEnabled;

            }

            set

            {

                if (value != _isEnabled)

                {

                    _isEnabled = value;

                    OnPropertyChanged("isEnabled");

                }

            }

        }

        public System.String origin

        {

            get

            {

                return _origin;

            }

            set

            {

                if (value != _origin)

                {

                    _origin = value;

                    OnPropertyChanged("origin");

                }

            }

        }

        public System.String value

        {

            get

            {

                return _value;

            }

            set

            {

                if (value != _value)

                {

                    _value = value;

                    OnPropertyChanged("value");

                }

            }

        }

        public appRole(): base()

        {

        }

    }

    public partial class keyCredential:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private System.Byte[] _customKeyIdentifier;

        private System.Nullable<System.DateTimeOffset> _endDate;

        private System.Nullable<System.Guid> _keyId;

        private System.Nullable<System.DateTimeOffset> _startDate;

        private System.String _type;

        private System.String _usage;

        private System.Byte[] _value;

        public System.Byte[] customKeyIdentifier

        {

            get

            {

                return _customKeyIdentifier;

            }

            set

            {

                if (value != _customKeyIdentifier)

                {

                    _customKeyIdentifier = value;

                    OnPropertyChanged("customKeyIdentifier");

                }

            }

        }

        public System.Nullable<System.DateTimeOffset> endDate

        {

            get

            {

                return _endDate;

            }

            set

            {

                if (value != _endDate)

                {

                    _endDate = value;

                    OnPropertyChanged("endDate");

                }

            }

        }

        public System.Nullable<System.Guid> keyId

        {

            get

            {

                return _keyId;

            }

            set

            {

                if (value != _keyId)

                {

                    _keyId = value;

                    OnPropertyChanged("keyId");

                }

            }

        }

        public System.Nullable<System.DateTimeOffset> startDate

        {

            get

            {

                return _startDate;

            }

            set

            {

                if (value != _startDate)

                {

                    _startDate = value;

                    OnPropertyChanged("startDate");

                }

            }

        }

        public System.String type

        {

            get

            {

                return _type;

            }

            set

            {

                if (value != _type)

                {

                    _type = value;

                    OnPropertyChanged("type");

                }

            }

        }

        public System.String usage

        {

            get

            {

                return _usage;

            }

            set

            {

                if (value != _usage)

                {

                    _usage = value;

                    OnPropertyChanged("usage");

                }

            }

        }

        public System.Byte[] value

        {

            get

            {

                return _value;

            }

            set

            {

                if (value != _value)

                {

                    _value = value;

                    OnPropertyChanged("value");

                }

            }

        }

        public keyCredential(): base()

        {

        }

    }

    public partial class oAuth2Permission:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private System.String _adminConsentDescription;

        private System.String _adminConsentDisplayName;

        private System.Guid _id;

        private System.Boolean _isEnabled;

        private System.String _origin;

        private System.String _type;

        private System.String _userConsentDescription;

        private System.String _userConsentDisplayName;

        private System.String _value;

        public System.String adminConsentDescription

        {

            get

            {

                return _adminConsentDescription;

            }

            set

            {

                if (value != _adminConsentDescription)

                {

                    _adminConsentDescription = value;

                    OnPropertyChanged("adminConsentDescription");

                }

            }

        }

        public System.String adminConsentDisplayName

        {

            get

            {

                return _adminConsentDisplayName;

            }

            set

            {

                if (value != _adminConsentDisplayName)

                {

                    _adminConsentDisplayName = value;

                    OnPropertyChanged("adminConsentDisplayName");

                }

            }

        }

        public System.Guid id

        {

            get

            {

                return _id;

            }

            set

            {

                if (value != _id)

                {

                    _id = value;

                    OnPropertyChanged("id");

                }

            }

        }

        public System.Boolean isEnabled

        {

            get

            {

                return _isEnabled;

            }

            set

            {

                if (value != _isEnabled)

                {

                    _isEnabled = value;

                    OnPropertyChanged("isEnabled");

                }

            }

        }

        public System.String origin

        {

            get

            {

                return _origin;

            }

            set

            {

                if (value != _origin)

                {

                    _origin = value;

                    OnPropertyChanged("origin");

                }

            }

        }

        public System.String type

        {

            get

            {

                return _type;

            }

            set

            {

                if (value != _type)

                {

                    _type = value;

                    OnPropertyChanged("type");

                }

            }

        }

        public System.String userConsentDescription

        {

            get

            {

                return _userConsentDescription;

            }

            set

            {

                if (value != _userConsentDescription)

                {

                    _userConsentDescription = value;

                    OnPropertyChanged("userConsentDescription");

                }

            }

        }

        public System.String userConsentDisplayName

        {

            get

            {

                return _userConsentDisplayName;

            }

            set

            {

                if (value != _userConsentDisplayName)

                {

                    _userConsentDisplayName = value;

                    OnPropertyChanged("userConsentDisplayName");

                }

            }

        }

        public System.String value

        {

            get

            {

                return _value;

            }

            set

            {

                if (value != _value)

                {

                    _value = value;

                    OnPropertyChanged("value");

                }

            }

        }

        public oAuth2Permission(): base()

        {

        }

    }

    public partial class passwordCredential:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private System.Byte[] _customKeyIdentifier;

        private System.Nullable<System.DateTimeOffset> _endDate;

        private System.Nullable<System.Guid> _keyId;

        private System.Nullable<System.DateTimeOffset> _startDate;

        private System.String _value;

        public System.Byte[] customKeyIdentifier

        {

            get

            {

                return _customKeyIdentifier;

            }

            set

            {

                if (value != _customKeyIdentifier)

                {

                    _customKeyIdentifier = value;

                    OnPropertyChanged("customKeyIdentifier");

                }

            }

        }

        public System.Nullable<System.DateTimeOffset> endDate

        {

            get

            {

                return _endDate;

            }

            set

            {

                if (value != _endDate)

                {

                    _endDate = value;

                    OnPropertyChanged("endDate");

                }

            }

        }

        public System.Nullable<System.Guid> keyId

        {

            get

            {

                return _keyId;

            }

            set

            {

                if (value != _keyId)

                {

                    _keyId = value;

                    OnPropertyChanged("keyId");

                }

            }

        }

        public System.Nullable<System.DateTimeOffset> startDate

        {

            get

            {

                return _startDate;

            }

            set

            {

                if (value != _startDate)

                {

                    _startDate = value;

                    OnPropertyChanged("startDate");

                }

            }

        }

        public System.String value

        {

            get

            {

                return _value;

            }

            set

            {

                if (value != _value)

                {

                    _value = value;

                    OnPropertyChanged("value");

                }

            }

        }

        public passwordCredential(): base()

        {

        }

    }

    public partial class requiredResourceAccess:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private System.String _resourceAppId;

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.resourceAccess> _resourceAccess;

        public System.String resourceAppId

        {

            get

            {

                return _resourceAppId;

            }

            set

            {

                if (value != _resourceAppId)

                {

                    _resourceAppId = value;

                    OnPropertyChanged("resourceAppId");

                }

            }

        }

        public System.Collections.Generic.IList<global::Microsoft.Graph.resourceAccess> resourceAccess

        {

            get

            {

                if (this._resourceAccess == default(System.Collections.Generic.IList<global::Microsoft.Graph.resourceAccess>))

                {

                    this._resourceAccess = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.resourceAccess>();

                    this._resourceAccess.SetContainer(() => GetContainingEntity("resourceAccess"));

                }

                return this._resourceAccess;

            }

            set

            {

                resourceAccess.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        resourceAccess.Add(i);

                    }

                }

            }

        }

        public requiredResourceAccess(): base()

        {

        }

    }

    public partial class resourceAccess:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private System.Guid _id;

        private System.String _type;

        public System.Guid id

        {

            get

            {

                return _id;

            }

            set

            {

                if (value != _id)

                {

                    _id = value;

                    OnPropertyChanged("id");

                }

            }

        }

        public System.String type

        {

            get

            {

                return _type;

            }

            set

            {

                if (value != _type)

                {

                    _type = value;

                    OnPropertyChanged("type");

                }

            }

        }

        public resourceAccess(): base()

        {

        }

    }

    public partial class alternativeSecurityId:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private System.Nullable<System.Int32> _type;

        private System.String _identityProvider;

        private System.Byte[] _key;

        public System.Nullable<System.Int32> type

        {

            get

            {

                return _type;

            }

            set

            {

                if (value != _type)

                {

                    _type = value;

                    OnPropertyChanged("type");

                }

            }

        }

        public System.String identityProvider

        {

            get

            {

                return _identityProvider;

            }

            set

            {

                if (value != _identityProvider)

                {

                    _identityProvider = value;

                    OnPropertyChanged("identityProvider");

                }

            }

        }

        public System.Byte[] key

        {

            get

            {

                return _key;

            }

            set

            {

                if (value != _key)

                {

                    _key = value;

                    OnPropertyChanged("key");

                }

            }

        }

        public alternativeSecurityId(): base()

        {

        }

    }

    public partial class licenseUnitsDetail:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private System.Nullable<System.Int32> _enabled;

        private System.Nullable<System.Int32> _suspended;

        private System.Nullable<System.Int32> _warning;

        public System.Nullable<System.Int32> enabled

        {

            get

            {

                return _enabled;

            }

            set

            {

                if (value != _enabled)

                {

                    _enabled = value;

                    OnPropertyChanged("enabled");

                }

            }

        }

        public System.Nullable<System.Int32> suspended

        {

            get

            {

                return _suspended;

            }

            set

            {

                if (value != _suspended)

                {

                    _suspended = value;

                    OnPropertyChanged("suspended");

                }

            }

        }

        public System.Nullable<System.Int32> warning

        {

            get

            {

                return _warning;

            }

            set

            {

                if (value != _warning)

                {

                    _warning = value;

                    OnPropertyChanged("warning");

                }

            }

        }

        public licenseUnitsDetail(): base()

        {

        }

    }

    public partial class servicePlanInfo:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private System.Nullable<System.Guid> _servicePlanId;

        private System.String _servicePlanName;

        private System.String _provisioningStatus;

        private System.String _appliesTo;

        public System.Nullable<System.Guid> servicePlanId

        {

            get

            {

                return _servicePlanId;

            }

            set

            {

                if (value != _servicePlanId)

                {

                    _servicePlanId = value;

                    OnPropertyChanged("servicePlanId");

                }

            }

        }

        public System.String servicePlanName

        {

            get

            {

                return _servicePlanName;

            }

            set

            {

                if (value != _servicePlanName)

                {

                    _servicePlanName = value;

                    OnPropertyChanged("servicePlanName");

                }

            }

        }

        public System.String provisioningStatus

        {

            get

            {

                return _provisioningStatus;

            }

            set

            {

                if (value != _provisioningStatus)

                {

                    _provisioningStatus = value;

                    OnPropertyChanged("provisioningStatus");

                }

            }

        }

        public System.String appliesTo

        {

            get

            {

                return _appliesTo;

            }

            set

            {

                if (value != _appliesTo)

                {

                    _appliesTo = value;

                    OnPropertyChanged("appliesTo");

                }

            }

        }

        public servicePlanInfo(): base()

        {

        }

    }

    public partial class assignedPlan:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private System.Nullable<System.DateTimeOffset> _assignedDateTime;

        private System.String _capabilityStatus;

        private System.String _service;

        private System.Nullable<System.Guid> _servicePlanId;

        public System.Nullable<System.DateTimeOffset> assignedDateTime

        {

            get

            {

                return _assignedDateTime;

            }

            set

            {

                if (value != _assignedDateTime)

                {

                    _assignedDateTime = value;

                    OnPropertyChanged("assignedDateTime");

                }

            }

        }

        public System.String capabilityStatus

        {

            get

            {

                return _capabilityStatus;

            }

            set

            {

                if (value != _capabilityStatus)

                {

                    _capabilityStatus = value;

                    OnPropertyChanged("capabilityStatus");

                }

            }

        }

        public System.String service

        {

            get

            {

                return _service;

            }

            set

            {

                if (value != _service)

                {

                    _service = value;

                    OnPropertyChanged("service");

                }

            }

        }

        public System.Nullable<System.Guid> servicePlanId

        {

            get

            {

                return _servicePlanId;

            }

            set

            {

                if (value != _servicePlanId)

                {

                    _servicePlanId = value;

                    OnPropertyChanged("servicePlanId");

                }

            }

        }

        public assignedPlan(): base()

        {

        }

    }

    public partial class provisionedPlan:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private System.String _capabilityStatus;

        private System.String _provisioningStatus;

        private System.String _service;

        public System.String capabilityStatus

        {

            get

            {

                return _capabilityStatus;

            }

            set

            {

                if (value != _capabilityStatus)

                {

                    _capabilityStatus = value;

                    OnPropertyChanged("capabilityStatus");

                }

            }

        }

        public System.String provisioningStatus

        {

            get

            {

                return _provisioningStatus;

            }

            set

            {

                if (value != _provisioningStatus)

                {

                    _provisioningStatus = value;

                    OnPropertyChanged("provisioningStatus");

                }

            }

        }

        public System.String service

        {

            get

            {

                return _service;

            }

            set

            {

                if (value != _service)

                {

                    _service = value;

                    OnPropertyChanged("service");

                }

            }

        }

        public provisionedPlan(): base()

        {

        }

    }

    public partial class verifiedDomain:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private System.String _capabilities;

        private System.Nullable<System.Boolean> _isDefault;

        private System.Nullable<System.Boolean> _isInitial;

        private System.String _name;

        private System.String _type;

        public System.String capabilities

        {

            get

            {

                return _capabilities;

            }

            set

            {

                if (value != _capabilities)

                {

                    _capabilities = value;

                    OnPropertyChanged("capabilities");

                }

            }

        }

        public System.Nullable<System.Boolean> isDefault

        {

            get

            {

                return _isDefault;

            }

            set

            {

                if (value != _isDefault)

                {

                    _isDefault = value;

                    OnPropertyChanged("isDefault");

                }

            }

        }

        public System.Nullable<System.Boolean> isInitial

        {

            get

            {

                return _isInitial;

            }

            set

            {

                if (value != _isInitial)

                {

                    _isInitial = value;

                    OnPropertyChanged("isInitial");

                }

            }

        }

        public System.String name

        {

            get

            {

                return _name;

            }

            set

            {

                if (value != _name)

                {

                    _name = value;

                    OnPropertyChanged("name");

                }

            }

        }

        public System.String type

        {

            get

            {

                return _type;

            }

            set

            {

                if (value != _type)

                {

                    _type = value;

                    OnPropertyChanged("type");

                }

            }

        }

        public verifiedDomain(): base()

        {

        }

    }

    public partial class assignedLicense:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.Guid> _disabledPlans;

        private System.Nullable<System.Guid> _skuId;

        public System.Collections.Generic.IList<System.Guid> disabledPlans

        {

            get

            {

                if (this._disabledPlans == default(System.Collections.Generic.IList<System.Guid>))

                {

                    this._disabledPlans = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.Guid>();

                    this._disabledPlans.SetContainer(() => GetContainingEntity("disabledPlans"));

                }

                return this._disabledPlans;

            }

            set

            {

                disabledPlans.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        disabledPlans.Add(i);

                    }

                }

            }

        }

        public System.Nullable<System.Guid> skuId

        {

            get

            {

                return _skuId;

            }

            set

            {

                if (value != _skuId)

                {

                    _skuId = value;

                    OnPropertyChanged("skuId");

                }

            }

        }

        public assignedLicense(): base()

        {

        }

    }

    public partial class passwordProfile:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private System.String _password;

        private System.Nullable<System.Boolean> _forceChangePasswordNextSignIn;

        public System.String password

        {

            get

            {

                return _password;

            }

            set

            {

                if (value != _password)

                {

                    _password = value;

                    OnPropertyChanged("password");

                }

            }

        }

        public System.Nullable<System.Boolean> forceChangePasswordNextSignIn

        {

            get

            {

                return _forceChangePasswordNextSignIn;

            }

            set

            {

                if (value != _forceChangePasswordNextSignIn)

                {

                    _forceChangePasswordNextSignIn = value;

                    OnPropertyChanged("forceChangePasswordNextSignIn");

                }

            }

        }

        public passwordProfile(): base()

        {

        }

    }

    public partial class recipient:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private global::Microsoft.Graph.emailAddress _emailAddress;

        public global::Microsoft.Graph.emailAddress emailAddress

        {

            get

            {

                return _emailAddress;

            }

            set

            {

                if (value != _emailAddress)

                {

                    _emailAddress = value;

                    OnPropertyChanged("emailAddress");

                }

            }

        }

        public recipient(): base()

        {

        }

    }

    public partial class emailAddress:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private System.String _name;

        private System.String _address;

        public System.String name

        {

            get

            {

                return _name;

            }

            set

            {

                if (value != _name)

                {

                    _name = value;

                    OnPropertyChanged("name");

                }

            }

        }

        public System.String address

        {

            get

            {

                return _address;

            }

            set

            {

                if (value != _address)

                {

                    _address = value;

                    OnPropertyChanged("address");

                }

            }

        }

        public emailAddress(): base()

        {

        }

    }

    public partial class attendeeBase:global::Microsoft.Graph.recipient

    {

        private global::Microsoft.Graph.attendeeType _type;

        public global::Microsoft.Graph.attendeeType type

        {

            get

            {

                return _type;

            }

            set

            {

                if (value != _type)

                {

                    _type = value;

                    OnPropertyChanged("type");

                }

            }

        }

        public attendeeBase()

        {

        }

    }

    public partial class meetingTimeCandidate:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private global::Microsoft.Graph.timeSlot _meetingTimeSlot;

        private System.Nullable<System.Double> _confidence;

        private System.Nullable<System.Int32> _score;

        private global::Microsoft.Graph.freeBusyStatus _organizerAvailability;

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.attendeeAvailability> _attendeeAvailability;

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.location> _locations;

        public global::Microsoft.Graph.timeSlot meetingTimeSlot

        {

            get

            {

                return _meetingTimeSlot;

            }

            set

            {

                if (value != _meetingTimeSlot)

                {

                    _meetingTimeSlot = value;

                    OnPropertyChanged("meetingTimeSlot");

                }

            }

        }

        public System.Nullable<System.Double> confidence

        {

            get

            {

                return _confidence;

            }

            set

            {

                if (value != _confidence)

                {

                    _confidence = value;

                    OnPropertyChanged("confidence");

                }

            }

        }

        public System.Nullable<System.Int32> score

        {

            get

            {

                return _score;

            }

            set

            {

                if (value != _score)

                {

                    _score = value;

                    OnPropertyChanged("score");

                }

            }

        }

        public global::Microsoft.Graph.freeBusyStatus organizerAvailability

        {

            get

            {

                return _organizerAvailability;

            }

            set

            {

                if (value != _organizerAvailability)

                {

                    _organizerAvailability = value;

                    OnPropertyChanged("organizerAvailability");

                }

            }

        }

        public System.Collections.Generic.IList<global::Microsoft.Graph.attendeeAvailability> attendeeAvailability

        {

            get

            {

                if (this._attendeeAvailability == default(System.Collections.Generic.IList<global::Microsoft.Graph.attendeeAvailability>))

                {

                    this._attendeeAvailability = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.attendeeAvailability>();

                    this._attendeeAvailability.SetContainer(() => GetContainingEntity("attendeeAvailability"));

                }

                return this._attendeeAvailability;

            }

            set

            {

                attendeeAvailability.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        attendeeAvailability.Add(i);

                    }

                }

            }

        }

        public System.Collections.Generic.IList<global::Microsoft.Graph.location> locations

        {

            get

            {

                if (this._locations == default(System.Collections.Generic.IList<global::Microsoft.Graph.location>))

                {

                    this._locations = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.location>();

                    this._locations.SetContainer(() => GetContainingEntity("locations"));

                }

                return this._locations;

            }

            set

            {

                locations.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        locations.Add(i);

                    }

                }

            }

        }

        public meetingTimeCandidate(): base()

        {

        }

    }

    public partial class timeSlot:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private global::Microsoft.Graph.timeStamp _start;

        private global::Microsoft.Graph.timeStamp _end;

        public global::Microsoft.Graph.timeStamp start

        {

            get

            {

                return _start;

            }

            set

            {

                if (value != _start)

                {

                    _start = value;

                    OnPropertyChanged("start");

                }

            }

        }

        public global::Microsoft.Graph.timeStamp end

        {

            get

            {

                return _end;

            }

            set

            {

                if (value != _end)

                {

                    _end = value;

                    OnPropertyChanged("end");

                }

            }

        }

        public timeSlot(): base()

        {

        }

    }

    public partial class timeStamp:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private System.Nullable<System.DateTimeOffset> _date;

        private System.Nullable<System.DateTimeOffset> _time;

        private System.String _timeZone;

        public System.Nullable<System.DateTimeOffset> date

        {

            get

            {

                return _date;

            }

            set

            {

                if (value != _date)

                {

                    _date = value;

                    OnPropertyChanged("date");

                }

            }

        }

        public System.Nullable<System.DateTimeOffset> time

        {

            get

            {

                return _time;

            }

            set

            {

                if (value != _time)

                {

                    _time = value;

                    OnPropertyChanged("time");

                }

            }

        }

        public System.String timeZone

        {

            get

            {

                return _timeZone;

            }

            set

            {

                if (value != _timeZone)

                {

                    _timeZone = value;

                    OnPropertyChanged("timeZone");

                }

            }

        }

        public timeStamp(): base()

        {

        }

    }

    public partial class attendeeAvailability:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private global::Microsoft.Graph.attendeeBase _attendee;

        private global::Microsoft.Graph.freeBusyStatus _availability;

        public global::Microsoft.Graph.attendeeBase attendee

        {

            get

            {

                return _attendee;

            }

            set

            {

                if (value != _attendee)

                {

                    _attendee = value;

                    OnPropertyChanged("attendee");

                }

            }

        }

        public global::Microsoft.Graph.freeBusyStatus availability

        {

            get

            {

                return _availability;

            }

            set

            {

                if (value != _availability)

                {

                    _availability = value;

                    OnPropertyChanged("availability");

                }

            }

        }

        public attendeeAvailability(): base()

        {

        }

    }

    public partial class location:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private System.String _displayName;

        private System.String _locationEmailAddress;

        private global::Microsoft.Graph.physicalAddress _address;

        private global::Microsoft.Graph.outlookGeoCoordinates _coordinates;

        public System.String displayName

        {

            get

            {

                return _displayName;

            }

            set

            {

                if (value != _displayName)

                {

                    _displayName = value;

                    OnPropertyChanged("displayName");

                }

            }

        }

        public System.String locationEmailAddress

        {

            get

            {

                return _locationEmailAddress;

            }

            set

            {

                if (value != _locationEmailAddress)

                {

                    _locationEmailAddress = value;

                    OnPropertyChanged("locationEmailAddress");

                }

            }

        }

        public global::Microsoft.Graph.physicalAddress address

        {

            get

            {

                return _address;

            }

            set

            {

                if (value != _address)

                {

                    _address = value;

                    OnPropertyChanged("address");

                }

            }

        }

        public global::Microsoft.Graph.outlookGeoCoordinates coordinates

        {

            get

            {

                return _coordinates;

            }

            set

            {

                if (value != _coordinates)

                {

                    _coordinates = value;

                    OnPropertyChanged("coordinates");

                }

            }

        }

        public location(): base()

        {

        }

    }

    public partial class physicalAddress:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private System.String _street;

        private System.String _city;

        private System.String _state;

        private System.String _countryOrRegion;

        private System.String _postalCode;

        public System.String street

        {

            get

            {

                return _street;

            }

            set

            {

                if (value != _street)

                {

                    _street = value;

                    OnPropertyChanged("street");

                }

            }

        }

        public System.String city

        {

            get

            {

                return _city;

            }

            set

            {

                if (value != _city)

                {

                    _city = value;

                    OnPropertyChanged("city");

                }

            }

        }

        public System.String state

        {

            get

            {

                return _state;

            }

            set

            {

                if (value != _state)

                {

                    _state = value;

                    OnPropertyChanged("state");

                }

            }

        }

        public System.String countryOrRegion

        {

            get

            {

                return _countryOrRegion;

            }

            set

            {

                if (value != _countryOrRegion)

                {

                    _countryOrRegion = value;

                    OnPropertyChanged("countryOrRegion");

                }

            }

        }

        public System.String postalCode

        {

            get

            {

                return _postalCode;

            }

            set

            {

                if (value != _postalCode)

                {

                    _postalCode = value;

                    OnPropertyChanged("postalCode");

                }

            }

        }

        public physicalAddress(): base()

        {

        }

    }

    public partial class outlookGeoCoordinates:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private System.Nullable<System.Double> _altitude;

        private System.Nullable<System.Double> _latitude;

        private System.Nullable<System.Double> _longitude;

        private System.Nullable<System.Double> _accuracy;

        private System.Nullable<System.Double> _altitudeAccuracy;

        public System.Nullable<System.Double> altitude

        {

            get

            {

                return _altitude;

            }

            set

            {

                if (value != _altitude)

                {

                    _altitude = value;

                    OnPropertyChanged("altitude");

                }

            }

        }

        public System.Nullable<System.Double> latitude

        {

            get

            {

                return _latitude;

            }

            set

            {

                if (value != _latitude)

                {

                    _latitude = value;

                    OnPropertyChanged("latitude");

                }

            }

        }

        public System.Nullable<System.Double> longitude

        {

            get

            {

                return _longitude;

            }

            set

            {

                if (value != _longitude)

                {

                    _longitude = value;

                    OnPropertyChanged("longitude");

                }

            }

        }

        public System.Nullable<System.Double> accuracy

        {

            get

            {

                return _accuracy;

            }

            set

            {

                if (value != _accuracy)

                {

                    _accuracy = value;

                    OnPropertyChanged("accuracy");

                }

            }

        }

        public System.Nullable<System.Double> altitudeAccuracy

        {

            get

            {

                return _altitudeAccuracy;

            }

            set

            {

                if (value != _altitudeAccuracy)

                {

                    _altitudeAccuracy = value;

                    OnPropertyChanged("altitudeAccuracy");

                }

            }

        }

        public outlookGeoCoordinates(): base()

        {

        }

    }

    public partial class locationConstraint:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private System.Nullable<System.Boolean> _isRequired;

        private System.Nullable<System.Boolean> _suggestLocation;

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.location> _locations;

        public System.Nullable<System.Boolean> isRequired

        {

            get

            {

                return _isRequired;

            }

            set

            {

                if (value != _isRequired)

                {

                    _isRequired = value;

                    OnPropertyChanged("isRequired");

                }

            }

        }

        public System.Nullable<System.Boolean> suggestLocation

        {

            get

            {

                return _suggestLocation;

            }

            set

            {

                if (value != _suggestLocation)

                {

                    _suggestLocation = value;

                    OnPropertyChanged("suggestLocation");

                }

            }

        }

        public System.Collections.Generic.IList<global::Microsoft.Graph.location> locations

        {

            get

            {

                if (this._locations == default(System.Collections.Generic.IList<global::Microsoft.Graph.location>))

                {

                    this._locations = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.location>();

                    this._locations.SetContainer(() => GetContainingEntity("locations"));

                }

                return this._locations;

            }

            set

            {

                locations.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        locations.Add(i);

                    }

                }

            }

        }

        public locationConstraint(): base()

        {

        }

    }

    public partial class timeConstraint:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private global::Microsoft.Graph.activityDomain _activityDomain;

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.timeSlot> _timeslots;

        public global::Microsoft.Graph.activityDomain activityDomain

        {

            get

            {

                return _activityDomain;

            }

            set

            {

                if (value != _activityDomain)

                {

                    _activityDomain = value;

                    OnPropertyChanged("activityDomain");

                }

            }

        }

        public System.Collections.Generic.IList<global::Microsoft.Graph.timeSlot> timeslots

        {

            get

            {

                if (this._timeslots == default(System.Collections.Generic.IList<global::Microsoft.Graph.timeSlot>))

                {

                    this._timeslots = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.timeSlot>();

                    this._timeslots.SetContainer(() => GetContainingEntity("timeslots"));

                }

                return this._timeslots;

            }

            set

            {

                timeslots.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        timeslots.Add(i);

                    }

                }

            }

        }

        public timeConstraint(): base()

        {

        }

    }

    public partial class reminder:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private System.String _eventId;

        private global::Microsoft.Graph.dateTimeTimeZone _eventStartTime;

        private global::Microsoft.Graph.dateTimeTimeZone _eventEndTime;

        private System.String _changeKey;

        private System.String _eventSubject;

        private global::Microsoft.Graph.location _eventLocation;

        private System.String _eventWebLink;

        private global::Microsoft.Graph.dateTimeTimeZone _reminderFireTime;

        public System.String eventId

        {

            get

            {

                return _eventId;

            }

            set

            {

                if (value != _eventId)

                {

                    _eventId = value;

                    OnPropertyChanged("eventId");

                }

            }

        }

        public global::Microsoft.Graph.dateTimeTimeZone eventStartTime

        {

            get

            {

                return _eventStartTime;

            }

            set

            {

                if (value != _eventStartTime)

                {

                    _eventStartTime = value;

                    OnPropertyChanged("eventStartTime");

                }

            }

        }

        public global::Microsoft.Graph.dateTimeTimeZone eventEndTime

        {

            get

            {

                return _eventEndTime;

            }

            set

            {

                if (value != _eventEndTime)

                {

                    _eventEndTime = value;

                    OnPropertyChanged("eventEndTime");

                }

            }

        }

        public System.String changeKey

        {

            get

            {

                return _changeKey;

            }

            set

            {

                if (value != _changeKey)

                {

                    _changeKey = value;

                    OnPropertyChanged("changeKey");

                }

            }

        }

        public System.String eventSubject

        {

            get

            {

                return _eventSubject;

            }

            set

            {

                if (value != _eventSubject)

                {

                    _eventSubject = value;

                    OnPropertyChanged("eventSubject");

                }

            }

        }

        public global::Microsoft.Graph.location eventLocation

        {

            get

            {

                return _eventLocation;

            }

            set

            {

                if (value != _eventLocation)

                {

                    _eventLocation = value;

                    OnPropertyChanged("eventLocation");

                }

            }

        }

        public System.String eventWebLink

        {

            get

            {

                return _eventWebLink;

            }

            set

            {

                if (value != _eventWebLink)

                {

                    _eventWebLink = value;

                    OnPropertyChanged("eventWebLink");

                }

            }

        }

        public global::Microsoft.Graph.dateTimeTimeZone reminderFireTime

        {

            get

            {

                return _reminderFireTime;

            }

            set

            {

                if (value != _reminderFireTime)

                {

                    _reminderFireTime = value;

                    OnPropertyChanged("reminderFireTime");

                }

            }

        }

        public reminder(): base()

        {

        }

    }

    public partial class dateTimeTimeZone:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private System.String _dateTime;

        private System.String _timeZone;

        public System.String dateTime

        {

            get

            {

                return _dateTime;

            }

            set

            {

                if (value != _dateTime)

                {

                    _dateTime = value;

                    OnPropertyChanged("dateTime");

                }

            }

        }

        public System.String timeZone

        {

            get

            {

                return _timeZone;

            }

            set

            {

                if (value != _timeZone)

                {

                    _timeZone = value;

                    OnPropertyChanged("timeZone");

                }

            }

        }

        public dateTimeTimeZone(): base()

        {

        }

    }

    public partial class itemBody:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private global::Microsoft.Graph.bodyType _contentType;

        private System.String _content;

        public global::Microsoft.Graph.bodyType contentType

        {

            get

            {

                return _contentType;

            }

            set

            {

                if (value != _contentType)

                {

                    _contentType = value;

                    OnPropertyChanged("contentType");

                }

            }

        }

        public System.String content

        {

            get

            {

                return _content;

            }

            set

            {

                if (value != _content)

                {

                    _content = value;

                    OnPropertyChanged("content");

                }

            }

        }

        public itemBody(): base()

        {

        }

    }

    public partial class responseStatus:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private global::Microsoft.Graph.responseType _response;

        private System.Nullable<System.DateTimeOffset> _time;

        public global::Microsoft.Graph.responseType response

        {

            get

            {

                return _response;

            }

            set

            {

                if (value != _response)

                {

                    _response = value;

                    OnPropertyChanged("response");

                }

            }

        }

        public System.Nullable<System.DateTimeOffset> time

        {

            get

            {

                return _time;

            }

            set

            {

                if (value != _time)

                {

                    _time = value;

                    OnPropertyChanged("time");

                }

            }

        }

        public responseStatus(): base()

        {

        }

    }

    public partial class patternedRecurrence:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private global::Microsoft.Graph.recurrencePattern _pattern;

        private global::Microsoft.Graph.recurrenceRange _range;

        public global::Microsoft.Graph.recurrencePattern pattern

        {

            get

            {

                return _pattern;

            }

            set

            {

                if (value != _pattern)

                {

                    _pattern = value;

                    OnPropertyChanged("pattern");

                }

            }

        }

        public global::Microsoft.Graph.recurrenceRange range

        {

            get

            {

                return _range;

            }

            set

            {

                if (value != _range)

                {

                    _range = value;

                    OnPropertyChanged("range");

                }

            }

        }

        public patternedRecurrence(): base()

        {

        }

    }

    public partial class recurrencePattern:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private global::Microsoft.Graph.recurrencePatternType _type;

        private System.Int32 _interval;

        private System.Int32 _month;

        private System.Int32 _dayOfMonth;

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.dayOfWeek> _daysOfWeek;

        private global::Microsoft.Graph.dayOfWeek _firstDayOfWeek;

        private global::Microsoft.Graph.weekIndex _index;

        public global::Microsoft.Graph.recurrencePatternType type

        {

            get

            {

                return _type;

            }

            set

            {

                if (value != _type)

                {

                    _type = value;

                    OnPropertyChanged("type");

                }

            }

        }

        public System.Int32 interval

        {

            get

            {

                return _interval;

            }

            set

            {

                if (value != _interval)

                {

                    _interval = value;

                    OnPropertyChanged("interval");

                }

            }

        }

        public System.Int32 month

        {

            get

            {

                return _month;

            }

            set

            {

                if (value != _month)

                {

                    _month = value;

                    OnPropertyChanged("month");

                }

            }

        }

        public System.Int32 dayOfMonth

        {

            get

            {

                return _dayOfMonth;

            }

            set

            {

                if (value != _dayOfMonth)

                {

                    _dayOfMonth = value;

                    OnPropertyChanged("dayOfMonth");

                }

            }

        }

        public System.Collections.Generic.IList<global::Microsoft.Graph.dayOfWeek> daysOfWeek

        {

            get

            {

                if (this._daysOfWeek == default(System.Collections.Generic.IList<global::Microsoft.Graph.dayOfWeek>))

                {

                    this._daysOfWeek = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.dayOfWeek>();

                    this._daysOfWeek.SetContainer(() => GetContainingEntity("daysOfWeek"));

                }

                return this._daysOfWeek;

            }

            set

            {

                daysOfWeek.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        daysOfWeek.Add(i);

                    }

                }

            }

        }

        public global::Microsoft.Graph.dayOfWeek firstDayOfWeek

        {

            get

            {

                return _firstDayOfWeek;

            }

            set

            {

                if (value != _firstDayOfWeek)

                {

                    _firstDayOfWeek = value;

                    OnPropertyChanged("firstDayOfWeek");

                }

            }

        }

        public global::Microsoft.Graph.weekIndex index

        {

            get

            {

                return _index;

            }

            set

            {

                if (value != _index)

                {

                    _index = value;

                    OnPropertyChanged("index");

                }

            }

        }

        public recurrencePattern(): base()

        {

        }

    }

    public partial class recurrenceRange:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private global::Microsoft.Graph.recurrenceRangeType _type;

        private System.Nullable<System.DateTimeOffset> _startDate;

        private System.Nullable<System.DateTimeOffset> _endDate;

        private System.String _recurrenceTimeZone;

        private System.Int32 _numberOfOccurrences;

        public global::Microsoft.Graph.recurrenceRangeType type

        {

            get

            {

                return _type;

            }

            set

            {

                if (value != _type)

                {

                    _type = value;

                    OnPropertyChanged("type");

                }

            }

        }

        public System.Nullable<System.DateTimeOffset> startDate

        {

            get

            {

                return _startDate;

            }

            set

            {

                if (value != _startDate)

                {

                    _startDate = value;

                    OnPropertyChanged("startDate");

                }

            }

        }

        public System.Nullable<System.DateTimeOffset> endDate

        {

            get

            {

                return _endDate;

            }

            set

            {

                if (value != _endDate)

                {

                    _endDate = value;

                    OnPropertyChanged("endDate");

                }

            }

        }

        public System.String recurrenceTimeZone

        {

            get

            {

                return _recurrenceTimeZone;

            }

            set

            {

                if (value != _recurrenceTimeZone)

                {

                    _recurrenceTimeZone = value;

                    OnPropertyChanged("recurrenceTimeZone");

                }

            }

        }

        public System.Int32 numberOfOccurrences

        {

            get

            {

                return _numberOfOccurrences;

            }

            set

            {

                if (value != _numberOfOccurrences)

                {

                    _numberOfOccurrences = value;

                    OnPropertyChanged("numberOfOccurrences");

                }

            }

        }

        public recurrenceRange(): base()

        {

        }

    }

    public partial class attendee:global::Microsoft.Graph.attendeeBase

    {

        private global::Microsoft.Graph.responseStatus _status;

        public global::Microsoft.Graph.responseStatus status

        {

            get

            {

                return _status;

            }

            set

            {

                if (value != _status)

                {

                    _status = value;

                    OnPropertyChanged("status");

                }

            }

        }

        public attendee()

        {

        }

    }

    public partial class personDataSource:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private System.String _type;

        public System.String type

        {

            get

            {

                return _type;

            }

            set

            {

                if (value != _type)

                {

                    _type = value;

                    OnPropertyChanged("type");

                }

            }

        }

        public personDataSource(): base()

        {

        }

    }

    public partial class email:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private System.String _address;

        public System.String address

        {

            get

            {

                return _address;

            }

            set

            {

                if (value != _address)

                {

                    _address = value;

                    OnPropertyChanged("address");

                }

            }

        }

        public email(): base()

        {

        }

    }

    public partial class identitySet:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private global::Microsoft.Graph.identity _application;

        private global::Microsoft.Graph.identity _device;

        private global::Microsoft.Graph.identity _user;

        public global::Microsoft.Graph.identity application

        {

            get

            {

                return _application;

            }

            set

            {

                if (value != _application)

                {

                    _application = value;

                    OnPropertyChanged("application");

                }

            }

        }

        public global::Microsoft.Graph.identity device

        {

            get

            {

                return _device;

            }

            set

            {

                if (value != _device)

                {

                    _device = value;

                    OnPropertyChanged("device");

                }

            }

        }

        public global::Microsoft.Graph.identity user

        {

            get

            {

                return _user;

            }

            set

            {

                if (value != _user)

                {

                    _user = value;

                    OnPropertyChanged("user");

                }

            }

        }

        public identitySet(): base()

        {

        }

    }

    public partial class identity:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private System.String _displayName;

        private System.String _id;

        public System.String displayName

        {

            get

            {

                return _displayName;

            }

            set

            {

                if (value != _displayName)

                {

                    _displayName = value;

                    OnPropertyChanged("displayName");

                }

            }

        }

        public System.String id

        {

            get

            {

                return _id;

            }

            set

            {

                if (value != _id)

                {

                    _id = value;

                    OnPropertyChanged("id");

                }

            }

        }

        public identity(): base()

        {

        }

    }

    public partial class quota:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private System.Nullable<System.Int64> _deleted;

        private System.Nullable<System.Int64> _remaining;

        private System.String _state;

        private System.Nullable<System.Int64> _total;

        private System.Nullable<System.Int64> _used;

        public System.Nullable<System.Int64> deleted

        {

            get

            {

                return _deleted;

            }

            set

            {

                if (value != _deleted)

                {

                    _deleted = value;

                    OnPropertyChanged("deleted");

                }

            }

        }

        public System.Nullable<System.Int64> remaining

        {

            get

            {

                return _remaining;

            }

            set

            {

                if (value != _remaining)

                {

                    _remaining = value;

                    OnPropertyChanged("remaining");

                }

            }

        }

        public System.String state

        {

            get

            {

                return _state;

            }

            set

            {

                if (value != _state)

                {

                    _state = value;

                    OnPropertyChanged("state");

                }

            }

        }

        public System.Nullable<System.Int64> total

        {

            get

            {

                return _total;

            }

            set

            {

                if (value != _total)

                {

                    _total = value;

                    OnPropertyChanged("total");

                }

            }

        }

        public System.Nullable<System.Int64> used

        {

            get

            {

                return _used;

            }

            set

            {

                if (value != _used)

                {

                    _used = value;

                    OnPropertyChanged("used");

                }

            }

        }

        public quota(): base()

        {

        }

    }

    public partial class itemReference:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private System.String _driveId;

        private System.String _id;

        private System.String _path;

        public System.String driveId

        {

            get

            {

                return _driveId;

            }

            set

            {

                if (value != _driveId)

                {

                    _driveId = value;

                    OnPropertyChanged("driveId");

                }

            }

        }

        public System.String id

        {

            get

            {

                return _id;

            }

            set

            {

                if (value != _id)

                {

                    _id = value;

                    OnPropertyChanged("id");

                }

            }

        }

        public System.String path

        {

            get

            {

                return _path;

            }

            set

            {

                if (value != _path)

                {

                    _path = value;

                    OnPropertyChanged("path");

                }

            }

        }

        public itemReference(): base()

        {

        }

    }

    public partial class audio:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private System.String _album;

        private System.String _albumArtist;

        private System.String _artist;

        private System.Nullable<System.Int64> _bitrate;

        private System.String _composers;

        private System.String _copyright;

        private System.Nullable<System.Int16> _disc;

        private System.Nullable<System.Int16> _discCount;

        private System.Nullable<System.Int64> _duration;

        private System.String _genre;

        private System.Nullable<System.Boolean> _hasDrm;

        private System.Nullable<System.Boolean> _isVariableBitrate;

        private System.String _title;

        private System.Nullable<System.Int32> _track;

        private System.Nullable<System.Int32> _trackCount;

        private System.Nullable<System.Int32> _year;

        public System.String album

        {

            get

            {

                return _album;

            }

            set

            {

                if (value != _album)

                {

                    _album = value;

                    OnPropertyChanged("album");

                }

            }

        }

        public System.String albumArtist

        {

            get

            {

                return _albumArtist;

            }

            set

            {

                if (value != _albumArtist)

                {

                    _albumArtist = value;

                    OnPropertyChanged("albumArtist");

                }

            }

        }

        public System.String artist

        {

            get

            {

                return _artist;

            }

            set

            {

                if (value != _artist)

                {

                    _artist = value;

                    OnPropertyChanged("artist");

                }

            }

        }

        public System.Nullable<System.Int64> bitrate

        {

            get

            {

                return _bitrate;

            }

            set

            {

                if (value != _bitrate)

                {

                    _bitrate = value;

                    OnPropertyChanged("bitrate");

                }

            }

        }

        public System.String composers

        {

            get

            {

                return _composers;

            }

            set

            {

                if (value != _composers)

                {

                    _composers = value;

                    OnPropertyChanged("composers");

                }

            }

        }

        public System.String copyright

        {

            get

            {

                return _copyright;

            }

            set

            {

                if (value != _copyright)

                {

                    _copyright = value;

                    OnPropertyChanged("copyright");

                }

            }

        }

        public System.Nullable<System.Int16> disc

        {

            get

            {

                return _disc;

            }

            set

            {

                if (value != _disc)

                {

                    _disc = value;

                    OnPropertyChanged("disc");

                }

            }

        }

        public System.Nullable<System.Int16> discCount

        {

            get

            {

                return _discCount;

            }

            set

            {

                if (value != _discCount)

                {

                    _discCount = value;

                    OnPropertyChanged("discCount");

                }

            }

        }

        public System.Nullable<System.Int64> duration

        {

            get

            {

                return _duration;

            }

            set

            {

                if (value != _duration)

                {

                    _duration = value;

                    OnPropertyChanged("duration");

                }

            }

        }

        public System.String genre

        {

            get

            {

                return _genre;

            }

            set

            {

                if (value != _genre)

                {

                    _genre = value;

                    OnPropertyChanged("genre");

                }

            }

        }

        public System.Nullable<System.Boolean> hasDrm

        {

            get

            {

                return _hasDrm;

            }

            set

            {

                if (value != _hasDrm)

                {

                    _hasDrm = value;

                    OnPropertyChanged("hasDrm");

                }

            }

        }

        public System.Nullable<System.Boolean> isVariableBitrate

        {

            get

            {

                return _isVariableBitrate;

            }

            set

            {

                if (value != _isVariableBitrate)

                {

                    _isVariableBitrate = value;

                    OnPropertyChanged("isVariableBitrate");

                }

            }

        }

        public System.String title

        {

            get

            {

                return _title;

            }

            set

            {

                if (value != _title)

                {

                    _title = value;

                    OnPropertyChanged("title");

                }

            }

        }

        public System.Nullable<System.Int32> track

        {

            get

            {

                return _track;

            }

            set

            {

                if (value != _track)

                {

                    _track = value;

                    OnPropertyChanged("track");

                }

            }

        }

        public System.Nullable<System.Int32> trackCount

        {

            get

            {

                return _trackCount;

            }

            set

            {

                if (value != _trackCount)

                {

                    _trackCount = value;

                    OnPropertyChanged("trackCount");

                }

            }

        }

        public System.Nullable<System.Int32> year

        {

            get

            {

                return _year;

            }

            set

            {

                if (value != _year)

                {

                    _year = value;

                    OnPropertyChanged("year");

                }

            }

        }

        public audio(): base()

        {

        }

    }

    public partial class deleted:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private System.String _state;

        public System.String state

        {

            get

            {

                return _state;

            }

            set

            {

                if (value != _state)

                {

                    _state = value;

                    OnPropertyChanged("state");

                }

            }

        }

        public deleted(): base()

        {

        }

    }

    public partial class file:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private global::Microsoft.Graph.hashes _hashes;

        private System.String _mimeType;

        public global::Microsoft.Graph.hashes hashes

        {

            get

            {

                return _hashes;

            }

            set

            {

                if (value != _hashes)

                {

                    _hashes = value;

                    OnPropertyChanged("hashes");

                }

            }

        }

        public System.String mimeType

        {

            get

            {

                return _mimeType;

            }

            set

            {

                if (value != _mimeType)

                {

                    _mimeType = value;

                    OnPropertyChanged("mimeType");

                }

            }

        }

        public file(): base()

        {

        }

    }

    public partial class hashes:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private System.String _crc32Hash;

        private System.String _sha1Hash;

        public System.String crc32Hash

        {

            get

            {

                return _crc32Hash;

            }

            set

            {

                if (value != _crc32Hash)

                {

                    _crc32Hash = value;

                    OnPropertyChanged("crc32Hash");

                }

            }

        }

        public System.String sha1Hash

        {

            get

            {

                return _sha1Hash;

            }

            set

            {

                if (value != _sha1Hash)

                {

                    _sha1Hash = value;

                    OnPropertyChanged("sha1Hash");

                }

            }

        }

        public hashes(): base()

        {

        }

    }

    public partial class fileSystemInfo:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private System.Nullable<System.DateTimeOffset> _createdDateTime;

        private System.Nullable<System.DateTimeOffset> _lastModifiedDateTime;

        public System.Nullable<System.DateTimeOffset> createdDateTime

        {

            get

            {

                return _createdDateTime;

            }

            set

            {

                if (value != _createdDateTime)

                {

                    _createdDateTime = value;

                    OnPropertyChanged("createdDateTime");

                }

            }

        }

        public System.Nullable<System.DateTimeOffset> lastModifiedDateTime

        {

            get

            {

                return _lastModifiedDateTime;

            }

            set

            {

                if (value != _lastModifiedDateTime)

                {

                    _lastModifiedDateTime = value;

                    OnPropertyChanged("lastModifiedDateTime");

                }

            }

        }

        public fileSystemInfo(): base()

        {

        }

    }

    public partial class folder:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private System.Nullable<System.Int32> _childCount;

        public System.Nullable<System.Int32> childCount

        {

            get

            {

                return _childCount;

            }

            set

            {

                if (value != _childCount)

                {

                    _childCount = value;

                    OnPropertyChanged("childCount");

                }

            }

        }

        public folder(): base()

        {

        }

    }

    public partial class image:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private System.Nullable<System.Int32> _height;

        private System.Nullable<System.Int32> _width;

        public System.Nullable<System.Int32> height

        {

            get

            {

                return _height;

            }

            set

            {

                if (value != _height)

                {

                    _height = value;

                    OnPropertyChanged("height");

                }

            }

        }

        public System.Nullable<System.Int32> width

        {

            get

            {

                return _width;

            }

            set

            {

                if (value != _width)

                {

                    _width = value;

                    OnPropertyChanged("width");

                }

            }

        }

        public image(): base()

        {

        }

    }

    public partial class geoCoordinates:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private System.Nullable<System.Double> _altitude;

        private System.Nullable<System.Double> _latitude;

        private System.Nullable<System.Double> _longitude;

        public System.Nullable<System.Double> altitude

        {

            get

            {

                return _altitude;

            }

            set

            {

                if (value != _altitude)

                {

                    _altitude = value;

                    OnPropertyChanged("altitude");

                }

            }

        }

        public System.Nullable<System.Double> latitude

        {

            get

            {

                return _latitude;

            }

            set

            {

                if (value != _latitude)

                {

                    _latitude = value;

                    OnPropertyChanged("latitude");

                }

            }

        }

        public System.Nullable<System.Double> longitude

        {

            get

            {

                return _longitude;

            }

            set

            {

                if (value != _longitude)

                {

                    _longitude = value;

                    OnPropertyChanged("longitude");

                }

            }

        }

        public geoCoordinates(): base()

        {

        }

    }

    public partial class openWithSet:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private global::Microsoft.Graph.openWithApp _web;

        private global::Microsoft.Graph.openWithApp _webEmbedded;

        public global::Microsoft.Graph.openWithApp web

        {

            get

            {

                return _web;

            }

            set

            {

                if (value != _web)

                {

                    _web = value;

                    OnPropertyChanged("web");

                }

            }

        }

        public global::Microsoft.Graph.openWithApp webEmbedded

        {

            get

            {

                return _webEmbedded;

            }

            set

            {

                if (value != _webEmbedded)

                {

                    _webEmbedded = value;

                    OnPropertyChanged("webEmbedded");

                }

            }

        }

        public openWithSet(): base()

        {

        }

    }

    public partial class openWithApp:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private global::Microsoft.Graph.identity _app;

        private System.String _viewUrl;

        private System.String _editUrl;

        private System.String _viewPostParameters;

        private System.String _editPostParameters;

        public global::Microsoft.Graph.identity app

        {

            get

            {

                return _app;

            }

            set

            {

                if (value != _app)

                {

                    _app = value;

                    OnPropertyChanged("app");

                }

            }

        }

        public System.String viewUrl

        {

            get

            {

                return _viewUrl;

            }

            set

            {

                if (value != _viewUrl)

                {

                    _viewUrl = value;

                    OnPropertyChanged("viewUrl");

                }

            }

        }

        public System.String editUrl

        {

            get

            {

                return _editUrl;

            }

            set

            {

                if (value != _editUrl)

                {

                    _editUrl = value;

                    OnPropertyChanged("editUrl");

                }

            }

        }

        public System.String viewPostParameters

        {

            get

            {

                return _viewPostParameters;

            }

            set

            {

                if (value != _viewPostParameters)

                {

                    _viewPostParameters = value;

                    OnPropertyChanged("viewPostParameters");

                }

            }

        }

        public System.String editPostParameters

        {

            get

            {

                return _editPostParameters;

            }

            set

            {

                if (value != _editPostParameters)

                {

                    _editPostParameters = value;

                    OnPropertyChanged("editPostParameters");

                }

            }

        }

        public openWithApp(): base()

        {

        }

    }

    public partial class photo:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private System.String _cameraMake;

        private System.String _cameraModel;

        private System.Nullable<System.Double> _exposureDenominator;

        private System.Nullable<System.Double> _exposureNumerator;

        private System.Nullable<System.Double> _focalLength;

        private System.Nullable<System.Double> _fNumber;

        private System.Nullable<System.DateTimeOffset> _takenDateTime;

        private System.Nullable<System.Int32> _iso;

        public System.String cameraMake

        {

            get

            {

                return _cameraMake;

            }

            set

            {

                if (value != _cameraMake)

                {

                    _cameraMake = value;

                    OnPropertyChanged("cameraMake");

                }

            }

        }

        public System.String cameraModel

        {

            get

            {

                return _cameraModel;

            }

            set

            {

                if (value != _cameraModel)

                {

                    _cameraModel = value;

                    OnPropertyChanged("cameraModel");

                }

            }

        }

        public System.Nullable<System.Double> exposureDenominator

        {

            get

            {

                return _exposureDenominator;

            }

            set

            {

                if (value != _exposureDenominator)

                {

                    _exposureDenominator = value;

                    OnPropertyChanged("exposureDenominator");

                }

            }

        }

        public System.Nullable<System.Double> exposureNumerator

        {

            get

            {

                return _exposureNumerator;

            }

            set

            {

                if (value != _exposureNumerator)

                {

                    _exposureNumerator = value;

                    OnPropertyChanged("exposureNumerator");

                }

            }

        }

        public System.Nullable<System.Double> focalLength

        {

            get

            {

                return _focalLength;

            }

            set

            {

                if (value != _focalLength)

                {

                    _focalLength = value;

                    OnPropertyChanged("focalLength");

                }

            }

        }

        public System.Nullable<System.Double> fNumber

        {

            get

            {

                return _fNumber;

            }

            set

            {

                if (value != _fNumber)

                {

                    _fNumber = value;

                    OnPropertyChanged("fNumber");

                }

            }

        }

        public System.Nullable<System.DateTimeOffset> takenDateTime

        {

            get

            {

                return _takenDateTime;

            }

            set

            {

                if (value != _takenDateTime)

                {

                    _takenDateTime = value;

                    OnPropertyChanged("takenDateTime");

                }

            }

        }

        public System.Nullable<System.Int32> iso

        {

            get

            {

                return _iso;

            }

            set

            {

                if (value != _iso)

                {

                    _iso = value;

                    OnPropertyChanged("iso");

                }

            }

        }

        public photo(): base()

        {

        }

    }

    public partial class searchResult:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private System.String _onClickTelemetryUrl;

        public System.String onClickTelemetryUrl

        {

            get

            {

                return _onClickTelemetryUrl;

            }

            set

            {

                if (value != _onClickTelemetryUrl)

                {

                    _onClickTelemetryUrl = value;

                    OnPropertyChanged("onClickTelemetryUrl");

                }

            }

        }

        public searchResult(): base()

        {

        }

    }

    public partial class shared:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private global::Microsoft.Graph.identitySet _owner;

        private System.String _scope;

        public global::Microsoft.Graph.identitySet owner

        {

            get

            {

                return _owner;

            }

            set

            {

                if (value != _owner)

                {

                    _owner = value;

                    OnPropertyChanged("owner");

                }

            }

        }

        public System.String scope

        {

            get

            {

                return _scope;

            }

            set

            {

                if (value != _scope)

                {

                    _scope = value;

                    OnPropertyChanged("scope");

                }

            }

        }

        public shared(): base()

        {

        }

    }

    public partial class specialFolder:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private System.String _name;

        public System.String name

        {

            get

            {

                return _name;

            }

            set

            {

                if (value != _name)

                {

                    _name = value;

                    OnPropertyChanged("name");

                }

            }

        }

        public specialFolder(): base()

        {

        }

    }

    public partial class video:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private System.Nullable<System.Int32> _bitrate;

        private System.Nullable<System.Int64> _duration;

        private System.Nullable<System.Int32> _height;

        private System.Nullable<System.Int32> _width;

        public System.Nullable<System.Int32> bitrate

        {

            get

            {

                return _bitrate;

            }

            set

            {

                if (value != _bitrate)

                {

                    _bitrate = value;

                    OnPropertyChanged("bitrate");

                }

            }

        }

        public System.Nullable<System.Int64> duration

        {

            get

            {

                return _duration;

            }

            set

            {

                if (value != _duration)

                {

                    _duration = value;

                    OnPropertyChanged("duration");

                }

            }

        }

        public System.Nullable<System.Int32> height

        {

            get

            {

                return _height;

            }

            set

            {

                if (value != _height)

                {

                    _height = value;

                    OnPropertyChanged("height");

                }

            }

        }

        public System.Nullable<System.Int32> width

        {

            get

            {

                return _width;

            }

            set

            {

                if (value != _width)

                {

                    _width = value;

                    OnPropertyChanged("width");

                }

            }

        }

        public video(): base()

        {

        }

    }

    public partial class sharingInvitation:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private System.String _email;

        private System.String _redeemedBy;

        private System.Nullable<System.Boolean> _signInRequired;

        public System.String email

        {

            get

            {

                return _email;

            }

            set

            {

                if (value != _email)

                {

                    _email = value;

                    OnPropertyChanged("email");

                }

            }

        }

        public System.String redeemedBy

        {

            get

            {

                return _redeemedBy;

            }

            set

            {

                if (value != _redeemedBy)

                {

                    _redeemedBy = value;

                    OnPropertyChanged("redeemedBy");

                }

            }

        }

        public System.Nullable<System.Boolean> signInRequired

        {

            get

            {

                return _signInRequired;

            }

            set

            {

                if (value != _signInRequired)

                {

                    _signInRequired = value;

                    OnPropertyChanged("signInRequired");

                }

            }

        }

        public sharingInvitation(): base()

        {

        }

    }

    public partial class sharingLink:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private global::Microsoft.Graph.identity _application;

        private System.String _type;

        private System.String _webUrl;

        public global::Microsoft.Graph.identity application

        {

            get

            {

                return _application;

            }

            set

            {

                if (value != _application)

                {

                    _application = value;

                    OnPropertyChanged("application");

                }

            }

        }

        public System.String type

        {

            get

            {

                return _type;

            }

            set

            {

                if (value != _type)

                {

                    _type = value;

                    OnPropertyChanged("type");

                }

            }

        }

        public System.String webUrl

        {

            get

            {

                return _webUrl;

            }

            set

            {

                if (value != _webUrl)

                {

                    _webUrl = value;

                    OnPropertyChanged("webUrl");

                }

            }

        }

        public sharingLink(): base()

        {

        }

    }

    public partial class chunkedUploadSessionDescriptor:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private System.String _name;

        public System.String name

        {

            get

            {

                return _name;

            }

            set

            {

                if (value != _name)

                {

                    _name = value;

                    OnPropertyChanged("name");

                }

            }

        }

        public chunkedUploadSessionDescriptor(): base()

        {

        }

    }

    public partial class recipients:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private System.String _email;

        private System.String _alias;

        private System.String _objectId;

        private System.String _permissionIdentityType;

        public System.String email

        {

            get

            {

                return _email;

            }

            set

            {

                if (value != _email)

                {

                    _email = value;

                    OnPropertyChanged("email");

                }

            }

        }

        public System.String alias

        {

            get

            {

                return _alias;

            }

            set

            {

                if (value != _alias)

                {

                    _alias = value;

                    OnPropertyChanged("alias");

                }

            }

        }

        public System.String objectId

        {

            get

            {

                return _objectId;

            }

            set

            {

                if (value != _objectId)

                {

                    _objectId = value;

                    OnPropertyChanged("objectId");

                }

            }

        }

        public System.String permissionIdentityType

        {

            get

            {

                return _permissionIdentityType;

            }

            set

            {

                if (value != _permissionIdentityType)

                {

                    _permissionIdentityType = value;

                    OnPropertyChanged("permissionIdentityType");

                }

            }

        }

        public recipients(): base()

        {

        }

    }

    public partial class uploadSession:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private System.String _uploadUrl;

        private System.Nullable<System.DateTimeOffset> _expirationDateTime;

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.String> _nextExpectedRanges;

        public System.String uploadUrl

        {

            get

            {

                return _uploadUrl;

            }

            set

            {

                if (value != _uploadUrl)

                {

                    _uploadUrl = value;

                    OnPropertyChanged("uploadUrl");

                }

            }

        }

        public System.Nullable<System.DateTimeOffset> expirationDateTime

        {

            get

            {

                return _expirationDateTime;

            }

            set

            {

                if (value != _expirationDateTime)

                {

                    _expirationDateTime = value;

                    OnPropertyChanged("expirationDateTime");

                }

            }

        }

        public System.Collections.Generic.IList<System.String> nextExpectedRanges

        {

            get

            {

                if (this._nextExpectedRanges == default(System.Collections.Generic.IList<System.String>))

                {

                    this._nextExpectedRanges = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.String>();

                    this._nextExpectedRanges.SetContainer(() => GetContainingEntity("nextExpectedRanges"));

                }

                return this._nextExpectedRanges;

            }

            set

            {

                nextExpectedRanges.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        nextExpectedRanges.Add(i);

                    }

                }

            }

        }

        public uploadSession(): base()

        {

        }

    }

    public partial class thumbnail:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private Microsoft.OData.Client.DataServiceStreamLink _content;

        private System.Nullable<System.Int32> _height;

        private System.String _url;

        private System.Nullable<System.Int32> _width;

        public Microsoft.OData.Client.DataServiceStreamLink content

        {

            get

            {

                return _content;

            }

            set

            {

                if (value != _content)

                {

                    _content = value;

                    OnPropertyChanged("content");

                }

            }

        }

        public System.Nullable<System.Int32> height

        {

            get

            {

                return _height;

            }

            set

            {

                if (value != _height)

                {

                    _height = value;

                    OnPropertyChanged("height");

                }

            }

        }

        public System.String url

        {

            get

            {

                return _url;

            }

            set

            {

                if (value != _url)

                {

                    _url = value;

                    OnPropertyChanged("url");

                }

            }

        }

        public System.Nullable<System.Int32> width

        {

            get

            {

                return _width;

            }

            set

            {

                if (value != _width)

                {

                    _width = value;

                    OnPropertyChanged("width");

                }

            }

        }

        public thumbnail(): base()

        {

        }

    }

    public partial class notebookLinks:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private global::Microsoft.Graph.externalLink _oneNoteClientUrl;

        private global::Microsoft.Graph.externalLink _oneNoteWebUrl;

        /// <summary>
        /// The value of oneNoteClientURL can be used to open the notebook using the OneNote native client app if it's installed.
        /// </summary>
        public global::Microsoft.Graph.externalLink oneNoteClientUrl

        {

            get

            {

                return _oneNoteClientUrl;

            }

            set

            {

                if (value != _oneNoteClientUrl)

                {

                    _oneNoteClientUrl = value;

                    OnPropertyChanged("oneNoteClientUrl");

                }

            }

        }

        /// <summary>
        /// The value of oneNoteWebURL can be used to open the web-browser based OneNote Online client.
        /// </summary>
        public global::Microsoft.Graph.externalLink oneNoteWebUrl

        {

            get

            {

                return _oneNoteWebUrl;

            }

            set

            {

                if (value != _oneNoteWebUrl)

                {

                    _oneNoteWebUrl = value;

                    OnPropertyChanged("oneNoteWebUrl");

                }

            }

        }

        public notebookLinks(): base()

        {

        }

    }

    public partial class externalLink:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private System.String _href;

        public System.String href

        {

            get

            {

                return _href;

            }

            set

            {

                if (value != _href)

                {

                    _href = value;

                    OnPropertyChanged("href");

                }

            }

        }

        public externalLink(): base()

        {

        }

    }

    public partial class oneNoteIdentitySet:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private global::Microsoft.Graph.oneNoteIdentity _user;

        public global::Microsoft.Graph.oneNoteIdentity user

        {

            get

            {

                return _user;

            }

            set

            {

                if (value != _user)

                {

                    _user = value;

                    OnPropertyChanged("user");

                }

            }

        }

        public oneNoteIdentitySet(): base()

        {

        }

    }

    public partial class oneNoteIdentity:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private System.String _id;

        private System.String _displayName;

        public System.String id

        {

            get

            {

                return _id;

            }

            set

            {

                if (value != _id)

                {

                    _id = value;

                    OnPropertyChanged("id");

                }

            }

        }

        public System.String displayName

        {

            get

            {

                return _displayName;

            }

            set

            {

                if (value != _displayName)

                {

                    _displayName = value;

                    OnPropertyChanged("displayName");

                }

            }

        }

        public oneNoteIdentity(): base()

        {

        }

    }

    public partial class pageLinks:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private global::Microsoft.Graph.externalLink _oneNoteClientUrl;

        private global::Microsoft.Graph.externalLink _oneNoteWebUrl;

        /// <summary>
        /// The value of oneNoteClientURL can be used to open the notebook using the OneNote native client app if it's installed.
        /// </summary>
        public global::Microsoft.Graph.externalLink oneNoteClientUrl

        {

            get

            {

                return _oneNoteClientUrl;

            }

            set

            {

                if (value != _oneNoteClientUrl)

                {

                    _oneNoteClientUrl = value;

                    OnPropertyChanged("oneNoteClientUrl");

                }

            }

        }

        /// <summary>
        /// The value of oneNoteWebURL can be used to open the web-browser based OneNote Online client.
        /// </summary>
        public global::Microsoft.Graph.externalLink oneNoteWebUrl

        {

            get

            {

                return _oneNoteWebUrl;

            }

            set

            {

                if (value != _oneNoteWebUrl)

                {

                    _oneNoteWebUrl = value;

                    OnPropertyChanged("oneNoteWebUrl");

                }

            }

        }

        public pageLinks(): base()

        {

        }

    }

    public partial class notesOperationError:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private System.String _code;

        private System.String _message;

        public System.String code

        {

            get

            {

                return _code;

            }

            set

            {

                if (value != _code)

                {

                    _code = value;

                    OnPropertyChanged("code");

                }

            }

        }

        public System.String message

        {

            get

            {

                return _message;

            }

            set

            {

                if (value != _message)

                {

                    _message = value;

                    OnPropertyChanged("message");

                }

            }

        }

        public notesOperationError(): base()

        {

        }

    }

    public partial class diagnostic:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private System.String _message;

        private System.String _url;

        public System.String message

        {

            get

            {

                return _message;

            }

            set

            {

                if (value != _message)

                {

                    _message = value;

                    OnPropertyChanged("message");

                }

            }

        }

        public System.String url

        {

            get

            {

                return _url;

            }

            set

            {

                if (value != _url)

                {

                    _url = value;

                    OnPropertyChanged("url");

                }

            }

        }

        public diagnostic(): base()

        {

        }

    }

    public partial class patchContentCommand:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private global::Microsoft.Graph.PatchActionType _action;

        private System.String _target;

        private System.String _content;

        private global::Microsoft.Graph.PatchInsertPosition _position;

        public global::Microsoft.Graph.PatchActionType action

        {

            get

            {

                return _action;

            }

            set

            {

                if (value != _action)

                {

                    _action = value;

                    OnPropertyChanged("action");

                }

            }

        }

        public System.String target

        {

            get

            {

                return _target;

            }

            set

            {

                if (value != _target)

                {

                    _target = value;

                    OnPropertyChanged("target");

                }

            }

        }

        public System.String content

        {

            get

            {

                return _content;

            }

            set

            {

                if (value != _content)

                {

                    _content = value;

                    OnPropertyChanged("content");

                }

            }

        }

        public global::Microsoft.Graph.PatchInsertPosition position

        {

            get

            {

                return _position;

            }

            set

            {

                if (value != _position)

                {

                    _position = value;

                    OnPropertyChanged("position");

                }

            }

        }

        public patchContentCommand(): base()

        {

        }

    }

    public partial class copyStatusModel:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private System.String _id;

        private System.String _status;

        private System.Nullable<System.DateTimeOffset> _createdDateTime;

        public System.String id

        {

            get

            {

                return _id;

            }

            set

            {

                if (value != _id)

                {

                    _id = value;

                    OnPropertyChanged("id");

                }

            }

        }

        public System.String status

        {

            get

            {

                return _status;

            }

            set

            {

                if (value != _status)

                {

                    _status = value;

                    OnPropertyChanged("status");

                }

            }

        }

        public System.Nullable<System.DateTimeOffset> createdDateTime

        {

            get

            {

                return _createdDateTime;

            }

            set

            {

                if (value != _createdDateTime)

                {

                    _createdDateTime = value;

                    OnPropertyChanged("createdDateTime");

                }

            }

        }

        public copyStatusModel(): base()

        {

        }

    }

    public partial class importStatusModel:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private System.String _id;

        private System.String _status;

        private System.Nullable<System.DateTimeOffset> _createdDateTime;

        public System.String id

        {

            get

            {

                return _id;

            }

            set

            {

                if (value != _id)

                {

                    _id = value;

                    OnPropertyChanged("id");

                }

            }

        }

        public System.String status

        {

            get

            {

                return _status;

            }

            set

            {

                if (value != _status)

                {

                    _status = value;

                    OnPropertyChanged("status");

                }

            }

        }

        public System.Nullable<System.DateTimeOffset> createdDateTime

        {

            get

            {

                return _createdDateTime;

            }

            set

            {

                if (value != _createdDateTime)

                {

                    _createdDateTime = value;

                    OnPropertyChanged("createdDateTime");

                }

            }

        }

        public importStatusModel(): base()

        {

        }

    }

    public partial class appliedCategoriesCollection:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        public appliedCategoriesCollection(): base()

        {

        }

    }

    public partial class externalReference:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private System.String _alias;

        private System.String _type;

        private System.String _previewPriority;

        private System.String _lastModifiedBy;

        private System.Nullable<System.DateTimeOffset> _lastModifiedDateTime;

        public System.String alias

        {

            get

            {

                return _alias;

            }

            set

            {

                if (value != _alias)

                {

                    _alias = value;

                    OnPropertyChanged("alias");

                }

            }

        }

        public System.String type

        {

            get

            {

                return _type;

            }

            set

            {

                if (value != _type)

                {

                    _type = value;

                    OnPropertyChanged("type");

                }

            }

        }

        public System.String previewPriority

        {

            get

            {

                return _previewPriority;

            }

            set

            {

                if (value != _previewPriority)

                {

                    _previewPriority = value;

                    OnPropertyChanged("previewPriority");

                }

            }

        }

        public System.String lastModifiedBy

        {

            get

            {

                return _lastModifiedBy;

            }

            set

            {

                if (value != _lastModifiedBy)

                {

                    _lastModifiedBy = value;

                    OnPropertyChanged("lastModifiedBy");

                }

            }

        }

        public System.Nullable<System.DateTimeOffset> lastModifiedDateTime

        {

            get

            {

                return _lastModifiedDateTime;

            }

            set

            {

                if (value != _lastModifiedDateTime)

                {

                    _lastModifiedDateTime = value;

                    OnPropertyChanged("lastModifiedDateTime");

                }

            }

        }

        public externalReference(): base()

        {

        }

    }

    public partial class checklistItem:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private System.Nullable<System.Boolean> _isChecked;

        private System.String _title;

        private System.String _orderHint;

        private System.String _lastModifiedBy;

        private System.Nullable<System.DateTimeOffset> _lastModifiedDateTime;

        public System.Nullable<System.Boolean> isChecked

        {

            get

            {

                return _isChecked;

            }

            set

            {

                if (value != _isChecked)

                {

                    _isChecked = value;

                    OnPropertyChanged("isChecked");

                }

            }

        }

        public System.String title

        {

            get

            {

                return _title;

            }

            set

            {

                if (value != _title)

                {

                    _title = value;

                    OnPropertyChanged("title");

                }

            }

        }

        public System.String orderHint

        {

            get

            {

                return _orderHint;

            }

            set

            {

                if (value != _orderHint)

                {

                    _orderHint = value;

                    OnPropertyChanged("orderHint");

                }

            }

        }

        public System.String lastModifiedBy

        {

            get

            {

                return _lastModifiedBy;

            }

            set

            {

                if (value != _lastModifiedBy)

                {

                    _lastModifiedBy = value;

                    OnPropertyChanged("lastModifiedBy");

                }

            }

        }

        public System.Nullable<System.DateTimeOffset> lastModifiedDateTime

        {

            get

            {

                return _lastModifiedDateTime;

            }

            set

            {

                if (value != _lastModifiedDateTime)

                {

                    _lastModifiedDateTime = value;

                    OnPropertyChanged("lastModifiedDateTime");

                }

            }

        }

        public checklistItem(): base()

        {

        }

    }

    public partial class externalReferenceCollection:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        public externalReferenceCollection(): base()

        {

        }

    }

    public partial class checklistItemCollection:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        public checklistItemCollection(): base()

        {

        }

    }

    public partial class userIdCollection:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        public userIdCollection(): base()

        {

        }

    }

    [global::Microsoft.OData.Client.Key("id")]

    public partial class directoryObject:Microsoft.OData.ProxyExtensions.EntityBase, global::Microsoft.Graph.IdirectoryObject, global::Microsoft.Graph.IdirectoryObjectFetcher

    {

        private System.String _id;

        public System.String id

        {

            get

            {

                return _id;

            }

            set

            {

                if (value != _id)

                {

                    _id = value;

                    OnPropertyChanged("id");

                }

            }

        }

        public directoryObject(): base()

        {

        }

        public async System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<System.String>> checkMemberGroupsAsync(System.Collections.Generic.ICollection<System.String> groupIds)

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.checkMemberGroups");

            return (await this.Context.ExecuteAsync<System.String>(requestUri, "POST", false, new OperationParameter[]

            {

                new BodyOperationParameter("groupIds", (object) groupIds),

            }

            ));

        }

        public async System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<System.String>> getMemberGroupsAsync(System.Nullable<System.Boolean> securityEnabledOnly)

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.getMemberGroups");

            return (await this.Context.ExecuteAsync<System.String>(requestUri, "POST", false, new OperationParameter[]

            {

                new BodyOperationParameter("securityEnabledOnly", (object) securityEnabledOnly),

            }

            ));

        }

        public async System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<System.String>> getMemberObjectsAsync(System.Nullable<System.Boolean> securityEnabledOnly)

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.getMemberObjects");

            return (await this.Context.ExecuteAsync<System.String>(requestUri, "POST", false, new OperationParameter[]

            {

                new BodyOperationParameter("securityEnabledOnly", (object) securityEnabledOnly),

            }

            ));

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IdirectoryObject> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.directoryObject, global::Microsoft.Graph.IdirectoryObject>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IdirectoryObject> _query;

        global::System.Threading.Tasks.Task<global::Microsoft.Graph.IdirectoryObject> global::Microsoft.Graph.IdirectoryObjectFetcher.ExecuteAsync()

        {

            var tsc = new global::System.Threading.Tasks.TaskCompletionSource<global::Microsoft.Graph.IdirectoryObject>();

            tsc.SetResult(this);

            return tsc.Task;

        }

        global::Microsoft.Graph.IdirectoryObjectFetcher global::Microsoft.Graph.IdirectoryObjectFetcher.Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.IdirectoryObject, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IdirectoryObjectFetcher) this;

        }

    }

    internal partial class directoryObjectFetcher:Microsoft.OData.ProxyExtensions.RestShallowObjectFetcher, global::Microsoft.Graph.IdirectoryObjectFetcher

    {

        public directoryObjectFetcher(): base()

        {

        }

        public async System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<System.String>> checkMemberGroupsAsync(System.Collections.Generic.ICollection<System.String> groupIds)

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.checkMemberGroups");

            return (await this.Context.ExecuteAsync<System.String>(requestUri, "POST", false, new OperationParameter[]

            {

                new BodyOperationParameter("groupIds", (object) groupIds),

            }

            ));

        }

        public async System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<System.String>> getMemberGroupsAsync(System.Nullable<System.Boolean> securityEnabledOnly)

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.getMemberGroups");

            return (await this.Context.ExecuteAsync<System.String>(requestUri, "POST", false, new OperationParameter[]

            {

                new BodyOperationParameter("securityEnabledOnly", (object) securityEnabledOnly),

            }

            ));

        }

        public async System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<System.String>> getMemberObjectsAsync(System.Nullable<System.Boolean> securityEnabledOnly)

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.getMemberObjects");

            return (await this.Context.ExecuteAsync<System.String>(requestUri, "POST", false, new OperationParameter[]

            {

                new BodyOperationParameter("securityEnabledOnly", (object) securityEnabledOnly),

            }

            ));

        }

        public async global::System.Threading.Tasks.Task<global::Microsoft.Graph.IdirectoryObject> ExecuteAsync()

        {

            return await EnsureQuery().ExecuteSingleAsync();

        }

        public global::Microsoft.Graph.IdirectoryObjectFetcher Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.IdirectoryObject, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IdirectoryObjectFetcher) new global::Microsoft.Graph.directoryObjectFetcher()

            {

                _query = this.EnsureQuery().Expand<TTarget>(navigationPropertyAccessor)

            }

            ;

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IdirectoryObject> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.directoryObject, global::Microsoft.Graph.IdirectoryObject>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IdirectoryObject> _query;

    }

    internal partial class directoryObjectCollection:Microsoft.OData.ProxyExtensions.QueryableSet<global::Microsoft.Graph.IdirectoryObject>, global::Microsoft.Graph.IdirectoryObjectCollection

    {

        internal directoryObjectCollection(global::Microsoft.OData.Client.DataServiceQuery inner,Microsoft.OData.ProxyExtensions.DataServiceContextWrapper context,object entity,string path): base(inner, context, entity as Microsoft.OData.ProxyExtensions.EntityBase, path)

        {

        }

        public global::Microsoft.Graph.IdirectoryObjectFetcher GetById(System.String id)

        {

            return this[id];

        }

        public global::System.Threading.Tasks.Task<Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.IdirectoryObject>> ExecuteAsync()

        {

            return ExecuteAsyncInternal();

        }

        public global::System.Threading.Tasks.Task AdddirectoryObjectAsync(global::Microsoft.Graph.IdirectoryObject item, System.Boolean deferSaveChanges = false)

        {

            if (Entity == null)

            {

                Context.AddObject(Path, item);

            }

            else

            {

                var lastSlash = Path.LastIndexOf('/');

                var shortPath = (lastSlash >= 0 && lastSlash < Path.Length - 1) ? Path.Substring(lastSlash + 1) : Path;

                Context.AddRelatedObject(Entity, shortPath, item);

            }

            if (!deferSaveChanges)

            {

                return Context.SaveChangesAsync();

            }

            else

            {

                var retVal = new global::System.Threading.Tasks.TaskCompletionSource<object>();

                retVal.SetResult(null);

                return retVal.Task;

            }

        }

        public global::Microsoft.Graph.IdirectoryObjectFetcher this[System.String id]

        {

            get

            {

                var path = GetPath<global::Microsoft.Graph.directoryObject>((i) => i.id == id);

                var fetcher = new global::Microsoft.Graph.directoryObjectFetcher();

                fetcher.Initialize(Context, path);

                

                return fetcher;

            }

        }

    }

    internal partial class directoryObjectCollection

    {

        public global::System.Threading.Tasks.Task<System.Int64> CountAsync()

        {

            return new DataServiceQuerySingle<long>(Context, Path + "/$count").GetValueAsync();

        }

    }

    internal partial class directoryObjectFetcher

    {

        public global::Microsoft.Graph.IextensionPropertyFetcher ToextensionProperty()

        {

            var derivedFetcher = new global::Microsoft.Graph.extensionPropertyFetcher();

            derivedFetcher.Initialize(this.Context, this.GetPath((string) null));

            return (global::Microsoft.Graph.IextensionPropertyFetcher) derivedFetcher;

        }

        public global::Microsoft.Graph.IapplicationFetcher Toapplication()

        {

            var derivedFetcher = new global::Microsoft.Graph.applicationFetcher();

            derivedFetcher.Initialize(this.Context, this.GetPath((string) null));

            return (global::Microsoft.Graph.IapplicationFetcher) derivedFetcher;

        }

        public global::Microsoft.Graph.IorgContactFetcher ToorgContact()

        {

            var derivedFetcher = new global::Microsoft.Graph.orgContactFetcher();

            derivedFetcher.Initialize(this.Context, this.GetPath((string) null));

            return (global::Microsoft.Graph.IorgContactFetcher) derivedFetcher;

        }

        public global::Microsoft.Graph.IdeviceFetcher Todevice()

        {

            var derivedFetcher = new global::Microsoft.Graph.deviceFetcher();

            derivedFetcher.Initialize(this.Context, this.GetPath((string) null));

            return (global::Microsoft.Graph.IdeviceFetcher) derivedFetcher;

        }

        public global::Microsoft.Graph.IdirectoryRoleFetcher TodirectoryRole()

        {

            var derivedFetcher = new global::Microsoft.Graph.directoryRoleFetcher();

            derivedFetcher.Initialize(this.Context, this.GetPath((string) null));

            return (global::Microsoft.Graph.IdirectoryRoleFetcher) derivedFetcher;

        }

        public global::Microsoft.Graph.IdirectoryRoleTemplateFetcher TodirectoryRoleTemplate()

        {

            var derivedFetcher = new global::Microsoft.Graph.directoryRoleTemplateFetcher();

            derivedFetcher.Initialize(this.Context, this.GetPath((string) null));

            return (global::Microsoft.Graph.IdirectoryRoleTemplateFetcher) derivedFetcher;

        }

        public global::Microsoft.Graph.IgroupFetcher Togroup()

        {

            var derivedFetcher = new global::Microsoft.Graph.groupFetcher();

            derivedFetcher.Initialize(this.Context, this.GetPath((string) null));

            return (global::Microsoft.Graph.IgroupFetcher) derivedFetcher;

        }

        public global::Microsoft.Graph.IservicePrincipalFetcher ToservicePrincipal()

        {

            var derivedFetcher = new global::Microsoft.Graph.servicePrincipalFetcher();

            derivedFetcher.Initialize(this.Context, this.GetPath((string) null));

            return (global::Microsoft.Graph.IservicePrincipalFetcher) derivedFetcher;

        }

        public global::Microsoft.Graph.IorganizationFetcher Toorganization()

        {

            var derivedFetcher = new global::Microsoft.Graph.organizationFetcher();

            derivedFetcher.Initialize(this.Context, this.GetPath((string) null));

            return (global::Microsoft.Graph.IorganizationFetcher) derivedFetcher;

        }

        public global::Microsoft.Graph.IuserFetcher Touser()

        {

            var derivedFetcher = new global::Microsoft.Graph.userFetcher();

            derivedFetcher.Initialize(this.Context, this.GetPath((string) null));

            return (global::Microsoft.Graph.IuserFetcher) derivedFetcher;

        }

    }

    public partial class directoryObject

    {

        global::Microsoft.Graph.IextensionPropertyFetcher global::Microsoft.Graph.IdirectoryObjectFetcher.ToextensionProperty()

        {

            return (global::Microsoft.Graph.IextensionPropertyFetcher) this;

        }

        global::Microsoft.Graph.IapplicationFetcher global::Microsoft.Graph.IdirectoryObjectFetcher.Toapplication()

        {

            return (global::Microsoft.Graph.IapplicationFetcher) this;

        }

        global::Microsoft.Graph.IorgContactFetcher global::Microsoft.Graph.IdirectoryObjectFetcher.ToorgContact()

        {

            return (global::Microsoft.Graph.IorgContactFetcher) this;

        }

        global::Microsoft.Graph.IdeviceFetcher global::Microsoft.Graph.IdirectoryObjectFetcher.Todevice()

        {

            return (global::Microsoft.Graph.IdeviceFetcher) this;

        }

        global::Microsoft.Graph.IdirectoryRoleFetcher global::Microsoft.Graph.IdirectoryObjectFetcher.TodirectoryRole()

        {

            return (global::Microsoft.Graph.IdirectoryRoleFetcher) this;

        }

        global::Microsoft.Graph.IdirectoryRoleTemplateFetcher global::Microsoft.Graph.IdirectoryObjectFetcher.TodirectoryRoleTemplate()

        {

            return (global::Microsoft.Graph.IdirectoryRoleTemplateFetcher) this;

        }

        global::Microsoft.Graph.IgroupFetcher global::Microsoft.Graph.IdirectoryObjectFetcher.Togroup()

        {

            return (global::Microsoft.Graph.IgroupFetcher) this;

        }

        global::Microsoft.Graph.IservicePrincipalFetcher global::Microsoft.Graph.IdirectoryObjectFetcher.ToservicePrincipal()

        {

            return (global::Microsoft.Graph.IservicePrincipalFetcher) this;

        }

        global::Microsoft.Graph.IorganizationFetcher global::Microsoft.Graph.IdirectoryObjectFetcher.Toorganization()

        {

            return (global::Microsoft.Graph.IorganizationFetcher) this;

        }

        global::Microsoft.Graph.IuserFetcher global::Microsoft.Graph.IdirectoryObjectFetcher.Touser()

        {

            return (global::Microsoft.Graph.IuserFetcher) this;

        }

    }

    [global::Microsoft.OData.Client.Key("id")]

    public partial class extensionProperty:global::Microsoft.Graph.directoryObject, global::Microsoft.Graph.IextensionProperty, global::Microsoft.Graph.IextensionPropertyFetcher

    {

        private System.String _appDisplayName;

        private System.String _name;

        private System.String _dataType;

        private System.Nullable<System.Boolean> _isSyncedFromOnPremises;

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.String> _targetObjects;

        public System.String appDisplayName

        {

            get

            {

                return _appDisplayName;

            }

            set

            {

                if (value != _appDisplayName)

                {

                    _appDisplayName = value;

                    OnPropertyChanged("appDisplayName");

                }

            }

        }

        public System.String name

        {

            get

            {

                return _name;

            }

            set

            {

                if (value != _name)

                {

                    _name = value;

                    OnPropertyChanged("name");

                }

            }

        }

        public System.String dataType

        {

            get

            {

                return _dataType;

            }

            set

            {

                if (value != _dataType)

                {

                    _dataType = value;

                    OnPropertyChanged("dataType");

                }

            }

        }

        public System.Nullable<System.Boolean> isSyncedFromOnPremises

        {

            get

            {

                return _isSyncedFromOnPremises;

            }

            set

            {

                if (value != _isSyncedFromOnPremises)

                {

                    _isSyncedFromOnPremises = value;

                    OnPropertyChanged("isSyncedFromOnPremises");

                }

            }

        }

        public System.Collections.Generic.IList<System.String> targetObjects

        {

            get

            {

                if (this._targetObjects == default(System.Collections.Generic.IList<System.String>))

                {

                    this._targetObjects = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.String>();

                    this._targetObjects.SetContainer(() => GetContainingEntity("targetObjects"));

                }

                return this._targetObjects;

            }

            set

            {

                targetObjects.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        targetObjects.Add(i);

                    }

                }

            }

        }

        public extensionProperty()

        {

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IextensionProperty> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.extensionProperty, global::Microsoft.Graph.IextensionProperty>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IextensionProperty> _query;

        global::System.Threading.Tasks.Task<global::Microsoft.Graph.IextensionProperty> global::Microsoft.Graph.IextensionPropertyFetcher.ExecuteAsync()

        {

            var tsc = new global::System.Threading.Tasks.TaskCompletionSource<global::Microsoft.Graph.IextensionProperty>();

            tsc.SetResult(this);

            return tsc.Task;

        }

        global::Microsoft.Graph.IextensionPropertyFetcher global::Microsoft.Graph.IextensionPropertyFetcher.Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.IextensionProperty, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IextensionPropertyFetcher) this;

        }

    }

    internal partial class extensionPropertyFetcher:global::Microsoft.Graph.directoryObjectFetcher, global::Microsoft.Graph.IextensionPropertyFetcher

    {

        public extensionPropertyFetcher()

        {

        }

        public async new global::System.Threading.Tasks.Task<global::Microsoft.Graph.IextensionProperty> ExecuteAsync()

        {

            return await EnsureQuery().ExecuteSingleAsync();

        }

        public global::Microsoft.Graph.IextensionPropertyFetcher Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.IextensionProperty, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IextensionPropertyFetcher) new global::Microsoft.Graph.extensionPropertyFetcher()

            {

                _query = this.EnsureQuery().Expand<TTarget>(navigationPropertyAccessor)

            }

            ;

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IextensionProperty> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.extensionProperty, global::Microsoft.Graph.IextensionProperty>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IextensionProperty> _query;

    }

    internal partial class extensionPropertyCollection:Microsoft.OData.ProxyExtensions.QueryableSet<global::Microsoft.Graph.IextensionProperty>, global::Microsoft.Graph.IextensionPropertyCollection

    {

        internal extensionPropertyCollection(global::Microsoft.OData.Client.DataServiceQuery inner,Microsoft.OData.ProxyExtensions.DataServiceContextWrapper context,object entity,string path): base(inner, context, entity as Microsoft.OData.ProxyExtensions.EntityBase, path)

        {

        }

        public global::Microsoft.Graph.IextensionPropertyFetcher GetById(System.String id)

        {

            return this[id];

        }

        public global::System.Threading.Tasks.Task<Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.IextensionProperty>> ExecuteAsync()

        {

            return ExecuteAsyncInternal();

        }

        public global::System.Threading.Tasks.Task AddextensionPropertyAsync(global::Microsoft.Graph.IextensionProperty item, System.Boolean deferSaveChanges = false)

        {

            if (Entity == null)

            {

                Context.AddObject(Path, item);

            }

            else

            {

                var lastSlash = Path.LastIndexOf('/');

                var shortPath = (lastSlash >= 0 && lastSlash < Path.Length - 1) ? Path.Substring(lastSlash + 1) : Path;

                Context.AddRelatedObject(Entity, shortPath, item);

            }

            if (!deferSaveChanges)

            {

                return Context.SaveChangesAsync();

            }

            else

            {

                var retVal = new global::System.Threading.Tasks.TaskCompletionSource<object>();

                retVal.SetResult(null);

                return retVal.Task;

            }

        }

        public global::Microsoft.Graph.IextensionPropertyFetcher this[System.String id]

        {

            get

            {

                var path = GetPath<global::Microsoft.Graph.extensionProperty>((i) => i.id == id);

                var fetcher = new global::Microsoft.Graph.extensionPropertyFetcher();

                fetcher.Initialize(Context, path);

                

                return fetcher;

            }

        }

    }

    internal partial class extensionPropertyCollection

    {

        public global::System.Threading.Tasks.Task<System.Int64> CountAsync()

        {

            return new DataServiceQuerySingle<long>(Context, Path + "/$count").GetValueAsync();

        }

    }

    [global::Microsoft.OData.Client.Key("id")]

    public partial class application:global::Microsoft.Graph.directoryObject, global::Microsoft.Graph.Iapplication, global::Microsoft.Graph.IapplicationFetcher

    {

        private global::Microsoft.Graph.directoryObject _createdOnBehalfOf;

        private global::Microsoft.Graph.directoryObjectFetcher _createdOnBehalfOfFetcher;

        private global::Microsoft.Graph.extensionPropertyCollection _extensionPropertiesCollection;

        private global::Microsoft.Graph.directoryObjectCollection _ownersCollection;

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.addIn> _addIns;

        private System.String _appId;

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.appRole> _appRoles;

        private System.Nullable<System.Boolean> _availableToOtherOrganizations;

        private System.String _displayName;

        private System.String _errorUrl;

        private System.String _groupMembershipClaims;

        private System.String _homepage;

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.String> _identifierUris;

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.keyCredential> _keyCredentials;

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.Guid> _knownClientApplications;

        private Microsoft.OData.Client.DataServiceStreamLink _mainLogo;

        private System.String _logoutUrl;

        private System.Boolean _oauth2AllowImplicitFlow;

        private System.Boolean _oauth2AllowUrlPathMatching;

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.oAuth2Permission> _oauth2Permissions;

        private System.Boolean _oauth2RequirePostResponse;

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.passwordCredential> _passwordCredentials;

        private System.Nullable<System.Boolean> _publicClient;

        private System.String _recordConsentConditions;

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.String> _replyUrls;

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.requiredResourceAccess> _requiredResourceAccess;

        private System.String _samlMetadataUrl;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.extensionProperty> _extensionPropertiesConcrete;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.directoryObject> _ownersConcrete;

        public System.Collections.Generic.IList<global::Microsoft.Graph.addIn> addIns

        {

            get

            {

                if (this._addIns == default(System.Collections.Generic.IList<global::Microsoft.Graph.addIn>))

                {

                    this._addIns = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.addIn>();

                    this._addIns.SetContainer(() => GetContainingEntity("addIns"));

                }

                return this._addIns;

            }

            set

            {

                addIns.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        addIns.Add(i);

                    }

                }

            }

        }

        public System.String appId

        {

            get

            {

                return _appId;

            }

            set

            {

                if (value != _appId)

                {

                    _appId = value;

                    OnPropertyChanged("appId");

                }

            }

        }

        public System.Collections.Generic.IList<global::Microsoft.Graph.appRole> appRoles

        {

            get

            {

                if (this._appRoles == default(System.Collections.Generic.IList<global::Microsoft.Graph.appRole>))

                {

                    this._appRoles = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.appRole>();

                    this._appRoles.SetContainer(() => GetContainingEntity("appRoles"));

                }

                return this._appRoles;

            }

            set

            {

                appRoles.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        appRoles.Add(i);

                    }

                }

            }

        }

        public System.Nullable<System.Boolean> availableToOtherOrganizations

        {

            get

            {

                return _availableToOtherOrganizations;

            }

            set

            {

                if (value != _availableToOtherOrganizations)

                {

                    _availableToOtherOrganizations = value;

                    OnPropertyChanged("availableToOtherOrganizations");

                }

            }

        }

        public System.String displayName

        {

            get

            {

                return _displayName;

            }

            set

            {

                if (value != _displayName)

                {

                    _displayName = value;

                    OnPropertyChanged("displayName");

                }

            }

        }

        public System.String errorUrl

        {

            get

            {

                return _errorUrl;

            }

            set

            {

                if (value != _errorUrl)

                {

                    _errorUrl = value;

                    OnPropertyChanged("errorUrl");

                }

            }

        }

        public System.String groupMembershipClaims

        {

            get

            {

                return _groupMembershipClaims;

            }

            set

            {

                if (value != _groupMembershipClaims)

                {

                    _groupMembershipClaims = value;

                    OnPropertyChanged("groupMembershipClaims");

                }

            }

        }

        public System.String homepage

        {

            get

            {

                return _homepage;

            }

            set

            {

                if (value != _homepage)

                {

                    _homepage = value;

                    OnPropertyChanged("homepage");

                }

            }

        }

        public System.Collections.Generic.IList<System.String> identifierUris

        {

            get

            {

                if (this._identifierUris == default(System.Collections.Generic.IList<System.String>))

                {

                    this._identifierUris = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.String>();

                    this._identifierUris.SetContainer(() => GetContainingEntity("identifierUris"));

                }

                return this._identifierUris;

            }

            set

            {

                identifierUris.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        identifierUris.Add(i);

                    }

                }

            }

        }

        public System.Collections.Generic.IList<global::Microsoft.Graph.keyCredential> keyCredentials

        {

            get

            {

                if (this._keyCredentials == default(System.Collections.Generic.IList<global::Microsoft.Graph.keyCredential>))

                {

                    this._keyCredentials = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.keyCredential>();

                    this._keyCredentials.SetContainer(() => GetContainingEntity("keyCredentials"));

                }

                return this._keyCredentials;

            }

            set

            {

                keyCredentials.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        keyCredentials.Add(i);

                    }

                }

            }

        }

        public System.Collections.Generic.IList<System.Guid> knownClientApplications

        {

            get

            {

                if (this._knownClientApplications == default(System.Collections.Generic.IList<System.Guid>))

                {

                    this._knownClientApplications = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.Guid>();

                    this._knownClientApplications.SetContainer(() => GetContainingEntity("knownClientApplications"));

                }

                return this._knownClientApplications;

            }

            set

            {

                knownClientApplications.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        knownClientApplications.Add(i);

                    }

                }

            }

        }

        public Microsoft.OData.Client.DataServiceStreamLink mainLogo

        {

            get

            {

                return _mainLogo;

            }

            set

            {

                if (value != _mainLogo)

                {

                    _mainLogo = value;

                    OnPropertyChanged("mainLogo");

                }

            }

        }

        public System.String logoutUrl

        {

            get

            {

                return _logoutUrl;

            }

            set

            {

                if (value != _logoutUrl)

                {

                    _logoutUrl = value;

                    OnPropertyChanged("logoutUrl");

                }

            }

        }

        public System.Boolean oauth2AllowImplicitFlow

        {

            get

            {

                return _oauth2AllowImplicitFlow;

            }

            set

            {

                if (value != _oauth2AllowImplicitFlow)

                {

                    _oauth2AllowImplicitFlow = value;

                    OnPropertyChanged("oauth2AllowImplicitFlow");

                }

            }

        }

        public System.Boolean oauth2AllowUrlPathMatching

        {

            get

            {

                return _oauth2AllowUrlPathMatching;

            }

            set

            {

                if (value != _oauth2AllowUrlPathMatching)

                {

                    _oauth2AllowUrlPathMatching = value;

                    OnPropertyChanged("oauth2AllowUrlPathMatching");

                }

            }

        }

        public System.Collections.Generic.IList<global::Microsoft.Graph.oAuth2Permission> oauth2Permissions

        {

            get

            {

                if (this._oauth2Permissions == default(System.Collections.Generic.IList<global::Microsoft.Graph.oAuth2Permission>))

                {

                    this._oauth2Permissions = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.oAuth2Permission>();

                    this._oauth2Permissions.SetContainer(() => GetContainingEntity("oauth2Permissions"));

                }

                return this._oauth2Permissions;

            }

            set

            {

                oauth2Permissions.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        oauth2Permissions.Add(i);

                    }

                }

            }

        }

        public System.Boolean oauth2RequirePostResponse

        {

            get

            {

                return _oauth2RequirePostResponse;

            }

            set

            {

                if (value != _oauth2RequirePostResponse)

                {

                    _oauth2RequirePostResponse = value;

                    OnPropertyChanged("oauth2RequirePostResponse");

                }

            }

        }

        public System.Collections.Generic.IList<global::Microsoft.Graph.passwordCredential> passwordCredentials

        {

            get

            {

                if (this._passwordCredentials == default(System.Collections.Generic.IList<global::Microsoft.Graph.passwordCredential>))

                {

                    this._passwordCredentials = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.passwordCredential>();

                    this._passwordCredentials.SetContainer(() => GetContainingEntity("passwordCredentials"));

                }

                return this._passwordCredentials;

            }

            set

            {

                passwordCredentials.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        passwordCredentials.Add(i);

                    }

                }

            }

        }

        public System.Nullable<System.Boolean> publicClient

        {

            get

            {

                return _publicClient;

            }

            set

            {

                if (value != _publicClient)

                {

                    _publicClient = value;

                    OnPropertyChanged("publicClient");

                }

            }

        }

        public System.String recordConsentConditions

        {

            get

            {

                return _recordConsentConditions;

            }

            set

            {

                if (value != _recordConsentConditions)

                {

                    _recordConsentConditions = value;

                    OnPropertyChanged("recordConsentConditions");

                }

            }

        }

        public System.Collections.Generic.IList<System.String> replyUrls

        {

            get

            {

                if (this._replyUrls == default(System.Collections.Generic.IList<System.String>))

                {

                    this._replyUrls = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.String>();

                    this._replyUrls.SetContainer(() => GetContainingEntity("replyUrls"));

                }

                return this._replyUrls;

            }

            set

            {

                replyUrls.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        replyUrls.Add(i);

                    }

                }

            }

        }

        public System.Collections.Generic.IList<global::Microsoft.Graph.requiredResourceAccess> requiredResourceAccess

        {

            get

            {

                if (this._requiredResourceAccess == default(System.Collections.Generic.IList<global::Microsoft.Graph.requiredResourceAccess>))

                {

                    this._requiredResourceAccess = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.requiredResourceAccess>();

                    this._requiredResourceAccess.SetContainer(() => GetContainingEntity("requiredResourceAccess"));

                }

                return this._requiredResourceAccess;

            }

            set

            {

                requiredResourceAccess.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        requiredResourceAccess.Add(i);

                    }

                }

            }

        }

        public System.String samlMetadataUrl

        {

            get

            {

                return _samlMetadataUrl;

            }

            set

            {

                if (value != _samlMetadataUrl)

                {

                    _samlMetadataUrl = value;

                    OnPropertyChanged("samlMetadataUrl");

                }

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.IextensionProperty> global::Microsoft.Graph.Iapplication.extensionProperties

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.IextensionProperty, global::Microsoft.Graph.extensionProperty>(Context, (DataServiceCollection<global::Microsoft.Graph.extensionProperty>) extensionProperties);

            }

        }

        global::Microsoft.Graph.IdirectoryObject global::Microsoft.Graph.Iapplication.createdOnBehalfOf

        {

            get

            {

                return this._createdOnBehalfOf;

            }

            set

            {

                if (this.createdOnBehalfOf != value)

                {

                    this.createdOnBehalfOf = (global::Microsoft.Graph.directoryObject)value;

                }

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.IdirectoryObject> global::Microsoft.Graph.Iapplication.owners

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.IdirectoryObject, global::Microsoft.Graph.directoryObject>(Context, (DataServiceCollection<global::Microsoft.Graph.directoryObject>) owners);

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.extensionProperty> extensionProperties

        {

            get

            {

                if (this._extensionPropertiesConcrete == null)

                {

                    this._extensionPropertiesConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.extensionProperty>();

                    this._extensionPropertiesConcrete.SetContainer(() => GetContainingEntity("extensionProperties"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.extensionProperty>)this._extensionPropertiesConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                extensionProperties.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        extensionProperties.Add(i);

                    }

                }

            }

        }

        public global::Microsoft.Graph.directoryObject createdOnBehalfOf

        {

            get

            {

                return this._createdOnBehalfOf;

            }

            set

            {

                if (this._createdOnBehalfOf != value)

                {

                    this._createdOnBehalfOf = value;

                    if (Context != null && Context.GetEntityDescriptor(this) != null && (value == null || Context.GetEntityDescriptor(value) != null))

                    {

                        Context.SetLink(this, "createdOnBehalfOf", value);

                    }

                }

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.directoryObject> owners

        {

            get

            {

                if (this._ownersConcrete == null)

                {

                    this._ownersConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.directoryObject>();

                    this._ownersConcrete.SetContainer(() => GetContainingEntity("owners"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.directoryObject>)this._ownersConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                owners.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        owners.Add(i);

                    }

                }

            }

        }

        global::Microsoft.Graph.IextensionPropertyCollection global::Microsoft.Graph.IapplicationFetcher.extensionProperties

        {

            get

            {

                if (this._extensionPropertiesCollection == null)

                {

                    this._extensionPropertiesCollection = new global::Microsoft.Graph.extensionPropertyCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.extensionProperty>(GetPath("extensionProperties")) : null,
                       Context,
                       this,
                       GetPath("extensionProperties"));

                }

                

                return this._extensionPropertiesCollection;

            }

        }

        global::Microsoft.Graph.IdirectoryObjectFetcher global::Microsoft.Graph.IapplicationFetcher.createdOnBehalfOf

        {

            get

            {

                if (this._createdOnBehalfOfFetcher == null)

                {

                    this._createdOnBehalfOfFetcher = new global::Microsoft.Graph.directoryObjectFetcher();

                    this._createdOnBehalfOfFetcher.Initialize(this.Context, GetPath("createdOnBehalfOf"));

                }

                

                return this._createdOnBehalfOfFetcher;

            }

        }

        global::Microsoft.Graph.IdirectoryObjectCollection global::Microsoft.Graph.IapplicationFetcher.owners

        {

            get

            {

                if (this._ownersCollection == null)

                {

                    this._ownersCollection = new global::Microsoft.Graph.directoryObjectCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.directoryObject>(GetPath("owners")) : null,
                       Context,
                       this,
                       GetPath("owners"));

                }

                

                return this._ownersCollection;

            }

        }

        public application()

        {

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Iapplication> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.application, global::Microsoft.Graph.Iapplication>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Iapplication> _query;

        global::System.Threading.Tasks.Task<global::Microsoft.Graph.Iapplication> global::Microsoft.Graph.IapplicationFetcher.ExecuteAsync()

        {

            var tsc = new global::System.Threading.Tasks.TaskCompletionSource<global::Microsoft.Graph.Iapplication>();

            tsc.SetResult(this);

            return tsc.Task;

        }

        global::Microsoft.Graph.IapplicationFetcher global::Microsoft.Graph.IapplicationFetcher.Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.Iapplication, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IapplicationFetcher) this;

        }

    }

    internal partial class applicationFetcher:global::Microsoft.Graph.directoryObjectFetcher, global::Microsoft.Graph.IapplicationFetcher

    {

        private global::Microsoft.Graph.directoryObjectFetcher _createdOnBehalfOfFetcher;

        private global::Microsoft.Graph.extensionPropertyCollection _extensionPropertiesCollection;

        private global::Microsoft.Graph.directoryObjectCollection _ownersCollection;

        public global::Microsoft.Graph.IextensionPropertyCollection extensionProperties

        {

            get

            {

                if (this._extensionPropertiesCollection == null)

                {

                    this._extensionPropertiesCollection = new global::Microsoft.Graph.extensionPropertyCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.extensionProperty>(GetPath("extensionProperties")) : null,
                       Context,
                       this,
                       GetPath("extensionProperties"));

                }

                

                return this._extensionPropertiesCollection;

            }

        }

        public global::Microsoft.Graph.IdirectoryObjectFetcher createdOnBehalfOf

        {

            get

            {

                if (this._createdOnBehalfOfFetcher == null)

                {

                    this._createdOnBehalfOfFetcher = new global::Microsoft.Graph.directoryObjectFetcher();

                    this._createdOnBehalfOfFetcher.Initialize(this.Context, GetPath("createdOnBehalfOf"));

                }

                

                return this._createdOnBehalfOfFetcher;

            }

        }

        public global::Microsoft.Graph.IdirectoryObjectCollection owners

        {

            get

            {

                if (this._ownersCollection == null)

                {

                    this._ownersCollection = new global::Microsoft.Graph.directoryObjectCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.directoryObject>(GetPath("owners")) : null,
                       Context,
                       this,
                       GetPath("owners"));

                }

                

                return this._ownersCollection;

            }

        }

        public applicationFetcher()

        {

        }

        public async new global::System.Threading.Tasks.Task<global::Microsoft.Graph.Iapplication> ExecuteAsync()

        {

            return await EnsureQuery().ExecuteSingleAsync();

        }

        public global::Microsoft.Graph.IapplicationFetcher Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.Iapplication, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IapplicationFetcher) new global::Microsoft.Graph.applicationFetcher()

            {

                _query = this.EnsureQuery().Expand<TTarget>(navigationPropertyAccessor)

            }

            ;

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Iapplication> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.application, global::Microsoft.Graph.Iapplication>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Iapplication> _query;

    }

    internal partial class applicationCollection:Microsoft.OData.ProxyExtensions.QueryableSet<global::Microsoft.Graph.Iapplication>, global::Microsoft.Graph.IapplicationCollection

    {

        internal applicationCollection(global::Microsoft.OData.Client.DataServiceQuery inner,Microsoft.OData.ProxyExtensions.DataServiceContextWrapper context,object entity,string path): base(inner, context, entity as Microsoft.OData.ProxyExtensions.EntityBase, path)

        {

        }

        public global::Microsoft.Graph.IapplicationFetcher GetById(System.String id)

        {

            return this[id];

        }

        public global::System.Threading.Tasks.Task<Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.Iapplication>> ExecuteAsync()

        {

            return ExecuteAsyncInternal();

        }

        public global::System.Threading.Tasks.Task AddapplicationAsync(global::Microsoft.Graph.Iapplication item, System.Boolean deferSaveChanges = false)

        {

            if (Entity == null)

            {

                Context.AddObject(Path, item);

            }

            else

            {

                var lastSlash = Path.LastIndexOf('/');

                var shortPath = (lastSlash >= 0 && lastSlash < Path.Length - 1) ? Path.Substring(lastSlash + 1) : Path;

                Context.AddRelatedObject(Entity, shortPath, item);

            }

            if (!deferSaveChanges)

            {

                return Context.SaveChangesAsync();

            }

            else

            {

                var retVal = new global::System.Threading.Tasks.TaskCompletionSource<object>();

                retVal.SetResult(null);

                return retVal.Task;

            }

        }

        public global::Microsoft.Graph.IapplicationFetcher this[System.String id]

        {

            get

            {

                var path = GetPath<global::Microsoft.Graph.application>((i) => i.id == id);

                var fetcher = new global::Microsoft.Graph.applicationFetcher();

                fetcher.Initialize(Context, path);

                

                return fetcher;

            }

        }

    }

    internal partial class applicationCollection

    {

        public global::System.Threading.Tasks.Task<System.Int64> CountAsync()

        {

            return new DataServiceQuerySingle<long>(Context, Path + "/$count").GetValueAsync();

        }

    }

    [global::Microsoft.OData.Client.Key("id")]

    public partial class appRoleAssignment:Microsoft.OData.ProxyExtensions.EntityBase, global::Microsoft.Graph.IappRoleAssignment, global::Microsoft.Graph.IappRoleAssignmentFetcher

    {

        private System.Nullable<System.DateTimeOffset> _creationTimestamp;

        private System.Guid _id;

        private System.String _principalDisplayName;

        private System.Nullable<System.Guid> _principalId;

        private System.String _principalType;

        private System.String _resourceDisplayName;

        private System.Nullable<System.Guid> _resourceId;

        public System.Nullable<System.DateTimeOffset> creationTimestamp

        {

            get

            {

                return _creationTimestamp;

            }

            set

            {

                if (value != _creationTimestamp)

                {

                    _creationTimestamp = value;

                    OnPropertyChanged("creationTimestamp");

                }

            }

        }

        public System.Guid id

        {

            get

            {

                return _id;

            }

            set

            {

                if (value != _id)

                {

                    _id = value;

                    OnPropertyChanged("id");

                }

            }

        }

        public System.String principalDisplayName

        {

            get

            {

                return _principalDisplayName;

            }

            set

            {

                if (value != _principalDisplayName)

                {

                    _principalDisplayName = value;

                    OnPropertyChanged("principalDisplayName");

                }

            }

        }

        public System.Nullable<System.Guid> principalId

        {

            get

            {

                return _principalId;

            }

            set

            {

                if (value != _principalId)

                {

                    _principalId = value;

                    OnPropertyChanged("principalId");

                }

            }

        }

        public System.String principalType

        {

            get

            {

                return _principalType;

            }

            set

            {

                if (value != _principalType)

                {

                    _principalType = value;

                    OnPropertyChanged("principalType");

                }

            }

        }

        public System.String resourceDisplayName

        {

            get

            {

                return _resourceDisplayName;

            }

            set

            {

                if (value != _resourceDisplayName)

                {

                    _resourceDisplayName = value;

                    OnPropertyChanged("resourceDisplayName");

                }

            }

        }

        public System.Nullable<System.Guid> resourceId

        {

            get

            {

                return _resourceId;

            }

            set

            {

                if (value != _resourceId)

                {

                    _resourceId = value;

                    OnPropertyChanged("resourceId");

                }

            }

        }

        public appRoleAssignment(): base()

        {

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IappRoleAssignment> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.appRoleAssignment, global::Microsoft.Graph.IappRoleAssignment>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IappRoleAssignment> _query;

        global::System.Threading.Tasks.Task<global::Microsoft.Graph.IappRoleAssignment> global::Microsoft.Graph.IappRoleAssignmentFetcher.ExecuteAsync()

        {

            var tsc = new global::System.Threading.Tasks.TaskCompletionSource<global::Microsoft.Graph.IappRoleAssignment>();

            tsc.SetResult(this);

            return tsc.Task;

        }

        global::Microsoft.Graph.IappRoleAssignmentFetcher global::Microsoft.Graph.IappRoleAssignmentFetcher.Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.IappRoleAssignment, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IappRoleAssignmentFetcher) this;

        }

    }

    internal partial class appRoleAssignmentFetcher:Microsoft.OData.ProxyExtensions.RestShallowObjectFetcher, global::Microsoft.Graph.IappRoleAssignmentFetcher

    {

        public appRoleAssignmentFetcher(): base()

        {

        }

        public async global::System.Threading.Tasks.Task<global::Microsoft.Graph.IappRoleAssignment> ExecuteAsync()

        {

            return await EnsureQuery().ExecuteSingleAsync();

        }

        public global::Microsoft.Graph.IappRoleAssignmentFetcher Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.IappRoleAssignment, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IappRoleAssignmentFetcher) new global::Microsoft.Graph.appRoleAssignmentFetcher()

            {

                _query = this.EnsureQuery().Expand<TTarget>(navigationPropertyAccessor)

            }

            ;

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IappRoleAssignment> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.appRoleAssignment, global::Microsoft.Graph.IappRoleAssignment>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IappRoleAssignment> _query;

    }

    internal partial class appRoleAssignmentCollection:Microsoft.OData.ProxyExtensions.QueryableSet<global::Microsoft.Graph.IappRoleAssignment>, global::Microsoft.Graph.IappRoleAssignmentCollection

    {

        internal appRoleAssignmentCollection(global::Microsoft.OData.Client.DataServiceQuery inner,Microsoft.OData.ProxyExtensions.DataServiceContextWrapper context,object entity,string path): base(inner, context, entity as Microsoft.OData.ProxyExtensions.EntityBase, path)

        {

        }

        public global::Microsoft.Graph.IappRoleAssignmentFetcher GetById(System.Guid id)

        {

            return this[id];

        }

        public global::System.Threading.Tasks.Task<Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.IappRoleAssignment>> ExecuteAsync()

        {

            return ExecuteAsyncInternal();

        }

        public global::System.Threading.Tasks.Task AddappRoleAssignmentAsync(global::Microsoft.Graph.IappRoleAssignment item, System.Boolean deferSaveChanges = false)

        {

            if (Entity == null)

            {

                Context.AddObject(Path, item);

            }

            else

            {

                var lastSlash = Path.LastIndexOf('/');

                var shortPath = (lastSlash >= 0 && lastSlash < Path.Length - 1) ? Path.Substring(lastSlash + 1) : Path;

                Context.AddRelatedObject(Entity, shortPath, item);

            }

            if (!deferSaveChanges)

            {

                return Context.SaveChangesAsync();

            }

            else

            {

                var retVal = new global::System.Threading.Tasks.TaskCompletionSource<object>();

                retVal.SetResult(null);

                return retVal.Task;

            }

        }

        public global::Microsoft.Graph.IappRoleAssignmentFetcher this[System.Guid id]

        {

            get

            {

                var path = GetPath<global::Microsoft.Graph.appRoleAssignment>((i) => i.id == id);

                var fetcher = new global::Microsoft.Graph.appRoleAssignmentFetcher();

                fetcher.Initialize(Context, path);

                

                return fetcher;

            }

        }

    }

    internal partial class appRoleAssignmentCollection

    {

        public global::System.Threading.Tasks.Task<System.Int64> CountAsync()

        {

            return new DataServiceQuerySingle<long>(Context, Path + "/$count").GetValueAsync();

        }

    }

    internal partial class appRoleAssignmentFetcher

    {

    }

    public partial class appRoleAssignment

    {

    }

    [global::Microsoft.OData.Client.Key("id")]

    public partial class orgContact:global::Microsoft.Graph.directoryObject, global::Microsoft.Graph.IorgContact, global::Microsoft.Graph.IorgContactFetcher

    {

        private global::Microsoft.Graph.directoryObject _manager;

        private global::Microsoft.Graph.directoryObjectFetcher _managerFetcher;

        private global::Microsoft.Graph.directoryObjectCollection _directReportsCollection;

        private global::Microsoft.Graph.directoryObjectCollection _memberOfCollection;

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.String> _businessPhones;

        private System.String _city;

        private System.String _companyName;

        private System.String _country;

        private System.String _department;

        private System.String _displayName;

        private System.String _givenName;

        private System.String _jobTitle;

        private System.String _mail;

        private System.String _mailNickname;

        private System.String _mobilePhone;

        private System.Nullable<System.Boolean> _onPremisesSyncEnabled;

        private System.Nullable<System.DateTimeOffset> _onPremisesLastSyncDateTime;

        private System.String _officeLocation;

        private System.String _postalCode;

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.String> _proxyAddresses;

        private System.String _state;

        private System.String _streetAddress;

        private System.String _surname;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.directoryObject> _directReportsConcrete;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.directoryObject> _memberOfConcrete;

        public System.Collections.Generic.IList<System.String> businessPhones

        {

            get

            {

                if (this._businessPhones == default(System.Collections.Generic.IList<System.String>))

                {

                    this._businessPhones = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.String>();

                    this._businessPhones.SetContainer(() => GetContainingEntity("businessPhones"));

                }

                return this._businessPhones;

            }

            set

            {

                businessPhones.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        businessPhones.Add(i);

                    }

                }

            }

        }

        public System.String city

        {

            get

            {

                return _city;

            }

            set

            {

                if (value != _city)

                {

                    _city = value;

                    OnPropertyChanged("city");

                }

            }

        }

        public System.String companyName

        {

            get

            {

                return _companyName;

            }

            set

            {

                if (value != _companyName)

                {

                    _companyName = value;

                    OnPropertyChanged("companyName");

                }

            }

        }

        public System.String country

        {

            get

            {

                return _country;

            }

            set

            {

                if (value != _country)

                {

                    _country = value;

                    OnPropertyChanged("country");

                }

            }

        }

        public System.String department

        {

            get

            {

                return _department;

            }

            set

            {

                if (value != _department)

                {

                    _department = value;

                    OnPropertyChanged("department");

                }

            }

        }

        public System.String displayName

        {

            get

            {

                return _displayName;

            }

            set

            {

                if (value != _displayName)

                {

                    _displayName = value;

                    OnPropertyChanged("displayName");

                }

            }

        }

        public System.String givenName

        {

            get

            {

                return _givenName;

            }

            set

            {

                if (value != _givenName)

                {

                    _givenName = value;

                    OnPropertyChanged("givenName");

                }

            }

        }

        public System.String jobTitle

        {

            get

            {

                return _jobTitle;

            }

            set

            {

                if (value != _jobTitle)

                {

                    _jobTitle = value;

                    OnPropertyChanged("jobTitle");

                }

            }

        }

        public System.String mail

        {

            get

            {

                return _mail;

            }

            set

            {

                if (value != _mail)

                {

                    _mail = value;

                    OnPropertyChanged("mail");

                }

            }

        }

        public System.String mailNickname

        {

            get

            {

                return _mailNickname;

            }

            set

            {

                if (value != _mailNickname)

                {

                    _mailNickname = value;

                    OnPropertyChanged("mailNickname");

                }

            }

        }

        public System.String mobilePhone

        {

            get

            {

                return _mobilePhone;

            }

            set

            {

                if (value != _mobilePhone)

                {

                    _mobilePhone = value;

                    OnPropertyChanged("mobilePhone");

                }

            }

        }

        public System.Nullable<System.Boolean> onPremisesSyncEnabled

        {

            get

            {

                return _onPremisesSyncEnabled;

            }

            set

            {

                if (value != _onPremisesSyncEnabled)

                {

                    _onPremisesSyncEnabled = value;

                    OnPropertyChanged("onPremisesSyncEnabled");

                }

            }

        }

        public System.Nullable<System.DateTimeOffset> onPremisesLastSyncDateTime

        {

            get

            {

                return _onPremisesLastSyncDateTime;

            }

            set

            {

                if (value != _onPremisesLastSyncDateTime)

                {

                    _onPremisesLastSyncDateTime = value;

                    OnPropertyChanged("onPremisesLastSyncDateTime");

                }

            }

        }

        public System.String officeLocation

        {

            get

            {

                return _officeLocation;

            }

            set

            {

                if (value != _officeLocation)

                {

                    _officeLocation = value;

                    OnPropertyChanged("officeLocation");

                }

            }

        }

        public System.String postalCode

        {

            get

            {

                return _postalCode;

            }

            set

            {

                if (value != _postalCode)

                {

                    _postalCode = value;

                    OnPropertyChanged("postalCode");

                }

            }

        }

        public System.Collections.Generic.IList<System.String> proxyAddresses

        {

            get

            {

                if (this._proxyAddresses == default(System.Collections.Generic.IList<System.String>))

                {

                    this._proxyAddresses = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.String>();

                    this._proxyAddresses.SetContainer(() => GetContainingEntity("proxyAddresses"));

                }

                return this._proxyAddresses;

            }

            set

            {

                proxyAddresses.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        proxyAddresses.Add(i);

                    }

                }

            }

        }

        public System.String state

        {

            get

            {

                return _state;

            }

            set

            {

                if (value != _state)

                {

                    _state = value;

                    OnPropertyChanged("state");

                }

            }

        }

        public System.String streetAddress

        {

            get

            {

                return _streetAddress;

            }

            set

            {

                if (value != _streetAddress)

                {

                    _streetAddress = value;

                    OnPropertyChanged("streetAddress");

                }

            }

        }

        public System.String surname

        {

            get

            {

                return _surname;

            }

            set

            {

                if (value != _surname)

                {

                    _surname = value;

                    OnPropertyChanged("surname");

                }

            }

        }

        global::Microsoft.Graph.IdirectoryObject global::Microsoft.Graph.IorgContact.manager

        {

            get

            {

                return this._manager;

            }

            set

            {

                if (this.manager != value)

                {

                    this.manager = (global::Microsoft.Graph.directoryObject)value;

                }

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.IdirectoryObject> global::Microsoft.Graph.IorgContact.directReports

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.IdirectoryObject, global::Microsoft.Graph.directoryObject>(Context, (DataServiceCollection<global::Microsoft.Graph.directoryObject>) directReports);

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.IdirectoryObject> global::Microsoft.Graph.IorgContact.memberOf

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.IdirectoryObject, global::Microsoft.Graph.directoryObject>(Context, (DataServiceCollection<global::Microsoft.Graph.directoryObject>) memberOf);

            }

        }

        public global::Microsoft.Graph.directoryObject manager

        {

            get

            {

                return this._manager;

            }

            set

            {

                if (this._manager != value)

                {

                    this._manager = value;

                    if (Context != null && Context.GetEntityDescriptor(this) != null && (value == null || Context.GetEntityDescriptor(value) != null))

                    {

                        Context.SetLink(this, "manager", value);

                    }

                }

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.directoryObject> directReports

        {

            get

            {

                if (this._directReportsConcrete == null)

                {

                    this._directReportsConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.directoryObject>();

                    this._directReportsConcrete.SetContainer(() => GetContainingEntity("directReports"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.directoryObject>)this._directReportsConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                directReports.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        directReports.Add(i);

                    }

                }

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.directoryObject> memberOf

        {

            get

            {

                if (this._memberOfConcrete == null)

                {

                    this._memberOfConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.directoryObject>();

                    this._memberOfConcrete.SetContainer(() => GetContainingEntity("memberOf"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.directoryObject>)this._memberOfConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                memberOf.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        memberOf.Add(i);

                    }

                }

            }

        }

        global::Microsoft.Graph.IdirectoryObjectFetcher global::Microsoft.Graph.IorgContactFetcher.manager

        {

            get

            {

                if (this._managerFetcher == null)

                {

                    this._managerFetcher = new global::Microsoft.Graph.directoryObjectFetcher();

                    this._managerFetcher.Initialize(this.Context, GetPath("manager"));

                }

                

                return this._managerFetcher;

            }

        }

        global::Microsoft.Graph.IdirectoryObjectCollection global::Microsoft.Graph.IorgContactFetcher.directReports

        {

            get

            {

                if (this._directReportsCollection == null)

                {

                    this._directReportsCollection = new global::Microsoft.Graph.directoryObjectCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.directoryObject>(GetPath("directReports")) : null,
                       Context,
                       this,
                       GetPath("directReports"));

                }

                

                return this._directReportsCollection;

            }

        }

        global::Microsoft.Graph.IdirectoryObjectCollection global::Microsoft.Graph.IorgContactFetcher.memberOf

        {

            get

            {

                if (this._memberOfCollection == null)

                {

                    this._memberOfCollection = new global::Microsoft.Graph.directoryObjectCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.directoryObject>(GetPath("memberOf")) : null,
                       Context,
                       this,
                       GetPath("memberOf"));

                }

                

                return this._memberOfCollection;

            }

        }

        public orgContact()

        {

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IorgContact> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.orgContact, global::Microsoft.Graph.IorgContact>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IorgContact> _query;

        global::System.Threading.Tasks.Task<global::Microsoft.Graph.IorgContact> global::Microsoft.Graph.IorgContactFetcher.ExecuteAsync()

        {

            var tsc = new global::System.Threading.Tasks.TaskCompletionSource<global::Microsoft.Graph.IorgContact>();

            tsc.SetResult(this);

            return tsc.Task;

        }

        global::Microsoft.Graph.IorgContactFetcher global::Microsoft.Graph.IorgContactFetcher.Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.IorgContact, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IorgContactFetcher) this;

        }

    }

    internal partial class orgContactFetcher:global::Microsoft.Graph.directoryObjectFetcher, global::Microsoft.Graph.IorgContactFetcher

    {

        private global::Microsoft.Graph.directoryObjectFetcher _managerFetcher;

        private global::Microsoft.Graph.directoryObjectCollection _directReportsCollection;

        private global::Microsoft.Graph.directoryObjectCollection _memberOfCollection;

        public global::Microsoft.Graph.IdirectoryObjectFetcher manager

        {

            get

            {

                if (this._managerFetcher == null)

                {

                    this._managerFetcher = new global::Microsoft.Graph.directoryObjectFetcher();

                    this._managerFetcher.Initialize(this.Context, GetPath("manager"));

                }

                

                return this._managerFetcher;

            }

        }

        public global::Microsoft.Graph.IdirectoryObjectCollection directReports

        {

            get

            {

                if (this._directReportsCollection == null)

                {

                    this._directReportsCollection = new global::Microsoft.Graph.directoryObjectCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.directoryObject>(GetPath("directReports")) : null,
                       Context,
                       this,
                       GetPath("directReports"));

                }

                

                return this._directReportsCollection;

            }

        }

        public global::Microsoft.Graph.IdirectoryObjectCollection memberOf

        {

            get

            {

                if (this._memberOfCollection == null)

                {

                    this._memberOfCollection = new global::Microsoft.Graph.directoryObjectCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.directoryObject>(GetPath("memberOf")) : null,
                       Context,
                       this,
                       GetPath("memberOf"));

                }

                

                return this._memberOfCollection;

            }

        }

        public orgContactFetcher()

        {

        }

        public async new global::System.Threading.Tasks.Task<global::Microsoft.Graph.IorgContact> ExecuteAsync()

        {

            return await EnsureQuery().ExecuteSingleAsync();

        }

        public global::Microsoft.Graph.IorgContactFetcher Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.IorgContact, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IorgContactFetcher) new global::Microsoft.Graph.orgContactFetcher()

            {

                _query = this.EnsureQuery().Expand<TTarget>(navigationPropertyAccessor)

            }

            ;

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IorgContact> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.orgContact, global::Microsoft.Graph.IorgContact>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IorgContact> _query;

    }

    internal partial class orgContactCollection:Microsoft.OData.ProxyExtensions.QueryableSet<global::Microsoft.Graph.IorgContact>, global::Microsoft.Graph.IorgContactCollection

    {

        internal orgContactCollection(global::Microsoft.OData.Client.DataServiceQuery inner,Microsoft.OData.ProxyExtensions.DataServiceContextWrapper context,object entity,string path): base(inner, context, entity as Microsoft.OData.ProxyExtensions.EntityBase, path)

        {

        }

        public global::Microsoft.Graph.IorgContactFetcher GetById(System.String id)

        {

            return this[id];

        }

        public global::System.Threading.Tasks.Task<Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.IorgContact>> ExecuteAsync()

        {

            return ExecuteAsyncInternal();

        }

        public global::System.Threading.Tasks.Task AddorgContactAsync(global::Microsoft.Graph.IorgContact item, System.Boolean deferSaveChanges = false)

        {

            if (Entity == null)

            {

                Context.AddObject(Path, item);

            }

            else

            {

                var lastSlash = Path.LastIndexOf('/');

                var shortPath = (lastSlash >= 0 && lastSlash < Path.Length - 1) ? Path.Substring(lastSlash + 1) : Path;

                Context.AddRelatedObject(Entity, shortPath, item);

            }

            if (!deferSaveChanges)

            {

                return Context.SaveChangesAsync();

            }

            else

            {

                var retVal = new global::System.Threading.Tasks.TaskCompletionSource<object>();

                retVal.SetResult(null);

                return retVal.Task;

            }

        }

        public global::Microsoft.Graph.IorgContactFetcher this[System.String id]

        {

            get

            {

                var path = GetPath<global::Microsoft.Graph.orgContact>((i) => i.id == id);

                var fetcher = new global::Microsoft.Graph.orgContactFetcher();

                fetcher.Initialize(Context, path);

                

                return fetcher;

            }

        }

    }

    internal partial class orgContactCollection

    {

        public global::System.Threading.Tasks.Task<System.Int64> CountAsync()

        {

            return new DataServiceQuerySingle<long>(Context, Path + "/$count").GetValueAsync();

        }

    }

    [global::Microsoft.OData.Client.Key("id")]

    public partial class device:global::Microsoft.Graph.directoryObject, global::Microsoft.Graph.Idevice, global::Microsoft.Graph.IdeviceFetcher

    {

        private global::Microsoft.Graph.directoryObjectCollection _registeredOwnersCollection;

        private global::Microsoft.Graph.directoryObjectCollection _registeredUsersCollection;

        private System.Nullable<System.Boolean> _accountEnabled;

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.alternativeSecurityId> _alternativeSecurityIds;

        private System.Nullable<System.DateTimeOffset> _approximateLastSignInDateTime;

        private System.String _deviceId;

        private System.String _deviceMetadata;

        private System.Nullable<System.Int32> _deviceVersion;

        private System.String _displayName;

        private System.Nullable<System.Boolean> _isCompliant;

        private System.Nullable<System.Boolean> _isManaged;

        private System.Nullable<System.DateTimeOffset> _onPremisesLastSyncDateTime;

        private System.Nullable<System.Boolean> _onPremisesSyncEnabled;

        private System.String _operatingSystem;

        private System.String _operatingSystemVersion;

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.String> _physicalIds;

        private System.String _trustType;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.directoryObject> _registeredOwnersConcrete;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.directoryObject> _registeredUsersConcrete;

        public System.Nullable<System.Boolean> accountEnabled

        {

            get

            {

                return _accountEnabled;

            }

            set

            {

                if (value != _accountEnabled)

                {

                    _accountEnabled = value;

                    OnPropertyChanged("accountEnabled");

                }

            }

        }

        public System.Collections.Generic.IList<global::Microsoft.Graph.alternativeSecurityId> alternativeSecurityIds

        {

            get

            {

                if (this._alternativeSecurityIds == default(System.Collections.Generic.IList<global::Microsoft.Graph.alternativeSecurityId>))

                {

                    this._alternativeSecurityIds = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.alternativeSecurityId>();

                    this._alternativeSecurityIds.SetContainer(() => GetContainingEntity("alternativeSecurityIds"));

                }

                return this._alternativeSecurityIds;

            }

            set

            {

                alternativeSecurityIds.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        alternativeSecurityIds.Add(i);

                    }

                }

            }

        }

        public System.Nullable<System.DateTimeOffset> approximateLastSignInDateTime

        {

            get

            {

                return _approximateLastSignInDateTime;

            }

            set

            {

                if (value != _approximateLastSignInDateTime)

                {

                    _approximateLastSignInDateTime = value;

                    OnPropertyChanged("approximateLastSignInDateTime");

                }

            }

        }

        public System.String deviceId

        {

            get

            {

                return _deviceId;

            }

            set

            {

                if (value != _deviceId)

                {

                    _deviceId = value;

                    OnPropertyChanged("deviceId");

                }

            }

        }

        public System.String deviceMetadata

        {

            get

            {

                return _deviceMetadata;

            }

            set

            {

                if (value != _deviceMetadata)

                {

                    _deviceMetadata = value;

                    OnPropertyChanged("deviceMetadata");

                }

            }

        }

        public System.Nullable<System.Int32> deviceVersion

        {

            get

            {

                return _deviceVersion;

            }

            set

            {

                if (value != _deviceVersion)

                {

                    _deviceVersion = value;

                    OnPropertyChanged("deviceVersion");

                }

            }

        }

        public System.String displayName

        {

            get

            {

                return _displayName;

            }

            set

            {

                if (value != _displayName)

                {

                    _displayName = value;

                    OnPropertyChanged("displayName");

                }

            }

        }

        public System.Nullable<System.Boolean> isCompliant

        {

            get

            {

                return _isCompliant;

            }

            set

            {

                if (value != _isCompliant)

                {

                    _isCompliant = value;

                    OnPropertyChanged("isCompliant");

                }

            }

        }

        public System.Nullable<System.Boolean> isManaged

        {

            get

            {

                return _isManaged;

            }

            set

            {

                if (value != _isManaged)

                {

                    _isManaged = value;

                    OnPropertyChanged("isManaged");

                }

            }

        }

        public System.Nullable<System.DateTimeOffset> onPremisesLastSyncDateTime

        {

            get

            {

                return _onPremisesLastSyncDateTime;

            }

            set

            {

                if (value != _onPremisesLastSyncDateTime)

                {

                    _onPremisesLastSyncDateTime = value;

                    OnPropertyChanged("onPremisesLastSyncDateTime");

                }

            }

        }

        public System.Nullable<System.Boolean> onPremisesSyncEnabled

        {

            get

            {

                return _onPremisesSyncEnabled;

            }

            set

            {

                if (value != _onPremisesSyncEnabled)

                {

                    _onPremisesSyncEnabled = value;

                    OnPropertyChanged("onPremisesSyncEnabled");

                }

            }

        }

        public System.String operatingSystem

        {

            get

            {

                return _operatingSystem;

            }

            set

            {

                if (value != _operatingSystem)

                {

                    _operatingSystem = value;

                    OnPropertyChanged("operatingSystem");

                }

            }

        }

        public System.String operatingSystemVersion

        {

            get

            {

                return _operatingSystemVersion;

            }

            set

            {

                if (value != _operatingSystemVersion)

                {

                    _operatingSystemVersion = value;

                    OnPropertyChanged("operatingSystemVersion");

                }

            }

        }

        public System.Collections.Generic.IList<System.String> physicalIds

        {

            get

            {

                if (this._physicalIds == default(System.Collections.Generic.IList<System.String>))

                {

                    this._physicalIds = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.String>();

                    this._physicalIds.SetContainer(() => GetContainingEntity("physicalIds"));

                }

                return this._physicalIds;

            }

            set

            {

                physicalIds.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        physicalIds.Add(i);

                    }

                }

            }

        }

        public System.String trustType

        {

            get

            {

                return _trustType;

            }

            set

            {

                if (value != _trustType)

                {

                    _trustType = value;

                    OnPropertyChanged("trustType");

                }

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.IdirectoryObject> global::Microsoft.Graph.Idevice.registeredOwners

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.IdirectoryObject, global::Microsoft.Graph.directoryObject>(Context, (DataServiceCollection<global::Microsoft.Graph.directoryObject>) registeredOwners);

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.IdirectoryObject> global::Microsoft.Graph.Idevice.registeredUsers

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.IdirectoryObject, global::Microsoft.Graph.directoryObject>(Context, (DataServiceCollection<global::Microsoft.Graph.directoryObject>) registeredUsers);

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.directoryObject> registeredOwners

        {

            get

            {

                if (this._registeredOwnersConcrete == null)

                {

                    this._registeredOwnersConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.directoryObject>();

                    this._registeredOwnersConcrete.SetContainer(() => GetContainingEntity("registeredOwners"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.directoryObject>)this._registeredOwnersConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                registeredOwners.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        registeredOwners.Add(i);

                    }

                }

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.directoryObject> registeredUsers

        {

            get

            {

                if (this._registeredUsersConcrete == null)

                {

                    this._registeredUsersConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.directoryObject>();

                    this._registeredUsersConcrete.SetContainer(() => GetContainingEntity("registeredUsers"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.directoryObject>)this._registeredUsersConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                registeredUsers.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        registeredUsers.Add(i);

                    }

                }

            }

        }

        global::Microsoft.Graph.IdirectoryObjectCollection global::Microsoft.Graph.IdeviceFetcher.registeredOwners

        {

            get

            {

                if (this._registeredOwnersCollection == null)

                {

                    this._registeredOwnersCollection = new global::Microsoft.Graph.directoryObjectCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.directoryObject>(GetPath("registeredOwners")) : null,
                       Context,
                       this,
                       GetPath("registeredOwners"));

                }

                

                return this._registeredOwnersCollection;

            }

        }

        global::Microsoft.Graph.IdirectoryObjectCollection global::Microsoft.Graph.IdeviceFetcher.registeredUsers

        {

            get

            {

                if (this._registeredUsersCollection == null)

                {

                    this._registeredUsersCollection = new global::Microsoft.Graph.directoryObjectCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.directoryObject>(GetPath("registeredUsers")) : null,
                       Context,
                       this,
                       GetPath("registeredUsers"));

                }

                

                return this._registeredUsersCollection;

            }

        }

        public device()

        {

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Idevice> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.device, global::Microsoft.Graph.Idevice>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Idevice> _query;

        global::System.Threading.Tasks.Task<global::Microsoft.Graph.Idevice> global::Microsoft.Graph.IdeviceFetcher.ExecuteAsync()

        {

            var tsc = new global::System.Threading.Tasks.TaskCompletionSource<global::Microsoft.Graph.Idevice>();

            tsc.SetResult(this);

            return tsc.Task;

        }

        global::Microsoft.Graph.IdeviceFetcher global::Microsoft.Graph.IdeviceFetcher.Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.Idevice, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IdeviceFetcher) this;

        }

    }

    internal partial class deviceFetcher:global::Microsoft.Graph.directoryObjectFetcher, global::Microsoft.Graph.IdeviceFetcher

    {

        private global::Microsoft.Graph.directoryObjectCollection _registeredOwnersCollection;

        private global::Microsoft.Graph.directoryObjectCollection _registeredUsersCollection;

        public global::Microsoft.Graph.IdirectoryObjectCollection registeredOwners

        {

            get

            {

                if (this._registeredOwnersCollection == null)

                {

                    this._registeredOwnersCollection = new global::Microsoft.Graph.directoryObjectCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.directoryObject>(GetPath("registeredOwners")) : null,
                       Context,
                       this,
                       GetPath("registeredOwners"));

                }

                

                return this._registeredOwnersCollection;

            }

        }

        public global::Microsoft.Graph.IdirectoryObjectCollection registeredUsers

        {

            get

            {

                if (this._registeredUsersCollection == null)

                {

                    this._registeredUsersCollection = new global::Microsoft.Graph.directoryObjectCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.directoryObject>(GetPath("registeredUsers")) : null,
                       Context,
                       this,
                       GetPath("registeredUsers"));

                }

                

                return this._registeredUsersCollection;

            }

        }

        public deviceFetcher()

        {

        }

        public async new global::System.Threading.Tasks.Task<global::Microsoft.Graph.Idevice> ExecuteAsync()

        {

            return await EnsureQuery().ExecuteSingleAsync();

        }

        public global::Microsoft.Graph.IdeviceFetcher Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.Idevice, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IdeviceFetcher) new global::Microsoft.Graph.deviceFetcher()

            {

                _query = this.EnsureQuery().Expand<TTarget>(navigationPropertyAccessor)

            }

            ;

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Idevice> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.device, global::Microsoft.Graph.Idevice>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Idevice> _query;

    }

    internal partial class deviceCollection:Microsoft.OData.ProxyExtensions.QueryableSet<global::Microsoft.Graph.Idevice>, global::Microsoft.Graph.IdeviceCollection

    {

        internal deviceCollection(global::Microsoft.OData.Client.DataServiceQuery inner,Microsoft.OData.ProxyExtensions.DataServiceContextWrapper context,object entity,string path): base(inner, context, entity as Microsoft.OData.ProxyExtensions.EntityBase, path)

        {

        }

        public global::Microsoft.Graph.IdeviceFetcher GetById(System.String id)

        {

            return this[id];

        }

        public global::System.Threading.Tasks.Task<Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.Idevice>> ExecuteAsync()

        {

            return ExecuteAsyncInternal();

        }

        public global::System.Threading.Tasks.Task AdddeviceAsync(global::Microsoft.Graph.Idevice item, System.Boolean deferSaveChanges = false)

        {

            if (Entity == null)

            {

                Context.AddObject(Path, item);

            }

            else

            {

                var lastSlash = Path.LastIndexOf('/');

                var shortPath = (lastSlash >= 0 && lastSlash < Path.Length - 1) ? Path.Substring(lastSlash + 1) : Path;

                Context.AddRelatedObject(Entity, shortPath, item);

            }

            if (!deferSaveChanges)

            {

                return Context.SaveChangesAsync();

            }

            else

            {

                var retVal = new global::System.Threading.Tasks.TaskCompletionSource<object>();

                retVal.SetResult(null);

                return retVal.Task;

            }

        }

        public global::Microsoft.Graph.IdeviceFetcher this[System.String id]

        {

            get

            {

                var path = GetPath<global::Microsoft.Graph.device>((i) => i.id == id);

                var fetcher = new global::Microsoft.Graph.deviceFetcher();

                fetcher.Initialize(Context, path);

                

                return fetcher;

            }

        }

    }

    internal partial class deviceCollection

    {

        public global::System.Threading.Tasks.Task<System.Int64> CountAsync()

        {

            return new DataServiceQuerySingle<long>(Context, Path + "/$count").GetValueAsync();

        }

    }

    [global::Microsoft.OData.Client.Key("id")]

    public partial class directoryRole:global::Microsoft.Graph.directoryObject, global::Microsoft.Graph.IdirectoryRole, global::Microsoft.Graph.IdirectoryRoleFetcher

    {

        private global::Microsoft.Graph.directoryObjectCollection _membersCollection;

        private System.String _description;

        private System.String _displayName;

        private System.String _roleTemplateId;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.directoryObject> _membersConcrete;

        public System.String description

        {

            get

            {

                return _description;

            }

            set

            {

                if (value != _description)

                {

                    _description = value;

                    OnPropertyChanged("description");

                }

            }

        }

        public System.String displayName

        {

            get

            {

                return _displayName;

            }

            set

            {

                if (value != _displayName)

                {

                    _displayName = value;

                    OnPropertyChanged("displayName");

                }

            }

        }

        public System.String roleTemplateId

        {

            get

            {

                return _roleTemplateId;

            }

            set

            {

                if (value != _roleTemplateId)

                {

                    _roleTemplateId = value;

                    OnPropertyChanged("roleTemplateId");

                }

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.IdirectoryObject> global::Microsoft.Graph.IdirectoryRole.members

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.IdirectoryObject, global::Microsoft.Graph.directoryObject>(Context, (DataServiceCollection<global::Microsoft.Graph.directoryObject>) members);

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.directoryObject> members

        {

            get

            {

                if (this._membersConcrete == null)

                {

                    this._membersConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.directoryObject>();

                    this._membersConcrete.SetContainer(() => GetContainingEntity("members"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.directoryObject>)this._membersConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                members.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        members.Add(i);

                    }

                }

            }

        }

        global::Microsoft.Graph.IdirectoryObjectCollection global::Microsoft.Graph.IdirectoryRoleFetcher.members

        {

            get

            {

                if (this._membersCollection == null)

                {

                    this._membersCollection = new global::Microsoft.Graph.directoryObjectCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.directoryObject>(GetPath("members")) : null,
                       Context,
                       this,
                       GetPath("members"));

                }

                

                return this._membersCollection;

            }

        }

        public directoryRole()

        {

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IdirectoryRole> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.directoryRole, global::Microsoft.Graph.IdirectoryRole>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IdirectoryRole> _query;

        global::System.Threading.Tasks.Task<global::Microsoft.Graph.IdirectoryRole> global::Microsoft.Graph.IdirectoryRoleFetcher.ExecuteAsync()

        {

            var tsc = new global::System.Threading.Tasks.TaskCompletionSource<global::Microsoft.Graph.IdirectoryRole>();

            tsc.SetResult(this);

            return tsc.Task;

        }

        global::Microsoft.Graph.IdirectoryRoleFetcher global::Microsoft.Graph.IdirectoryRoleFetcher.Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.IdirectoryRole, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IdirectoryRoleFetcher) this;

        }

    }

    internal partial class directoryRoleFetcher:global::Microsoft.Graph.directoryObjectFetcher, global::Microsoft.Graph.IdirectoryRoleFetcher

    {

        private global::Microsoft.Graph.directoryObjectCollection _membersCollection;

        public global::Microsoft.Graph.IdirectoryObjectCollection members

        {

            get

            {

                if (this._membersCollection == null)

                {

                    this._membersCollection = new global::Microsoft.Graph.directoryObjectCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.directoryObject>(GetPath("members")) : null,
                       Context,
                       this,
                       GetPath("members"));

                }

                

                return this._membersCollection;

            }

        }

        public directoryRoleFetcher()

        {

        }

        public async new global::System.Threading.Tasks.Task<global::Microsoft.Graph.IdirectoryRole> ExecuteAsync()

        {

            return await EnsureQuery().ExecuteSingleAsync();

        }

        public global::Microsoft.Graph.IdirectoryRoleFetcher Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.IdirectoryRole, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IdirectoryRoleFetcher) new global::Microsoft.Graph.directoryRoleFetcher()

            {

                _query = this.EnsureQuery().Expand<TTarget>(navigationPropertyAccessor)

            }

            ;

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IdirectoryRole> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.directoryRole, global::Microsoft.Graph.IdirectoryRole>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IdirectoryRole> _query;

    }

    internal partial class directoryRoleCollection:Microsoft.OData.ProxyExtensions.QueryableSet<global::Microsoft.Graph.IdirectoryRole>, global::Microsoft.Graph.IdirectoryRoleCollection

    {

        internal directoryRoleCollection(global::Microsoft.OData.Client.DataServiceQuery inner,Microsoft.OData.ProxyExtensions.DataServiceContextWrapper context,object entity,string path): base(inner, context, entity as Microsoft.OData.ProxyExtensions.EntityBase, path)

        {

        }

        public global::Microsoft.Graph.IdirectoryRoleFetcher GetById(System.String id)

        {

            return this[id];

        }

        public global::System.Threading.Tasks.Task<Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.IdirectoryRole>> ExecuteAsync()

        {

            return ExecuteAsyncInternal();

        }

        public global::System.Threading.Tasks.Task AdddirectoryRoleAsync(global::Microsoft.Graph.IdirectoryRole item, System.Boolean deferSaveChanges = false)

        {

            if (Entity == null)

            {

                Context.AddObject(Path, item);

            }

            else

            {

                var lastSlash = Path.LastIndexOf('/');

                var shortPath = (lastSlash >= 0 && lastSlash < Path.Length - 1) ? Path.Substring(lastSlash + 1) : Path;

                Context.AddRelatedObject(Entity, shortPath, item);

            }

            if (!deferSaveChanges)

            {

                return Context.SaveChangesAsync();

            }

            else

            {

                var retVal = new global::System.Threading.Tasks.TaskCompletionSource<object>();

                retVal.SetResult(null);

                return retVal.Task;

            }

        }

        public global::Microsoft.Graph.IdirectoryRoleFetcher this[System.String id]

        {

            get

            {

                var path = GetPath<global::Microsoft.Graph.directoryRole>((i) => i.id == id);

                var fetcher = new global::Microsoft.Graph.directoryRoleFetcher();

                fetcher.Initialize(Context, path);

                

                return fetcher;

            }

        }

    }

    internal partial class directoryRoleCollection

    {

        public global::System.Threading.Tasks.Task<System.Int64> CountAsync()

        {

            return new DataServiceQuerySingle<long>(Context, Path + "/$count").GetValueAsync();

        }

    }

    [global::Microsoft.OData.Client.Key("id")]

    public partial class directoryRoleTemplate:global::Microsoft.Graph.directoryObject, global::Microsoft.Graph.IdirectoryRoleTemplate, global::Microsoft.Graph.IdirectoryRoleTemplateFetcher

    {

        private System.String _description;

        private System.String _displayName;

        public System.String description

        {

            get

            {

                return _description;

            }

            set

            {

                if (value != _description)

                {

                    _description = value;

                    OnPropertyChanged("description");

                }

            }

        }

        public System.String displayName

        {

            get

            {

                return _displayName;

            }

            set

            {

                if (value != _displayName)

                {

                    _displayName = value;

                    OnPropertyChanged("displayName");

                }

            }

        }

        public directoryRoleTemplate()

        {

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IdirectoryRoleTemplate> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.directoryRoleTemplate, global::Microsoft.Graph.IdirectoryRoleTemplate>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IdirectoryRoleTemplate> _query;

        global::System.Threading.Tasks.Task<global::Microsoft.Graph.IdirectoryRoleTemplate> global::Microsoft.Graph.IdirectoryRoleTemplateFetcher.ExecuteAsync()

        {

            var tsc = new global::System.Threading.Tasks.TaskCompletionSource<global::Microsoft.Graph.IdirectoryRoleTemplate>();

            tsc.SetResult(this);

            return tsc.Task;

        }

        global::Microsoft.Graph.IdirectoryRoleTemplateFetcher global::Microsoft.Graph.IdirectoryRoleTemplateFetcher.Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.IdirectoryRoleTemplate, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IdirectoryRoleTemplateFetcher) this;

        }

    }

    internal partial class directoryRoleTemplateFetcher:global::Microsoft.Graph.directoryObjectFetcher, global::Microsoft.Graph.IdirectoryRoleTemplateFetcher

    {

        public directoryRoleTemplateFetcher()

        {

        }

        public async new global::System.Threading.Tasks.Task<global::Microsoft.Graph.IdirectoryRoleTemplate> ExecuteAsync()

        {

            return await EnsureQuery().ExecuteSingleAsync();

        }

        public global::Microsoft.Graph.IdirectoryRoleTemplateFetcher Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.IdirectoryRoleTemplate, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IdirectoryRoleTemplateFetcher) new global::Microsoft.Graph.directoryRoleTemplateFetcher()

            {

                _query = this.EnsureQuery().Expand<TTarget>(navigationPropertyAccessor)

            }

            ;

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IdirectoryRoleTemplate> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.directoryRoleTemplate, global::Microsoft.Graph.IdirectoryRoleTemplate>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IdirectoryRoleTemplate> _query;

    }

    internal partial class directoryRoleTemplateCollection:Microsoft.OData.ProxyExtensions.QueryableSet<global::Microsoft.Graph.IdirectoryRoleTemplate>, global::Microsoft.Graph.IdirectoryRoleTemplateCollection

    {

        internal directoryRoleTemplateCollection(global::Microsoft.OData.Client.DataServiceQuery inner,Microsoft.OData.ProxyExtensions.DataServiceContextWrapper context,object entity,string path): base(inner, context, entity as Microsoft.OData.ProxyExtensions.EntityBase, path)

        {

        }

        public global::Microsoft.Graph.IdirectoryRoleTemplateFetcher GetById(System.String id)

        {

            return this[id];

        }

        public global::System.Threading.Tasks.Task<Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.IdirectoryRoleTemplate>> ExecuteAsync()

        {

            return ExecuteAsyncInternal();

        }

        public global::System.Threading.Tasks.Task AdddirectoryRoleTemplateAsync(global::Microsoft.Graph.IdirectoryRoleTemplate item, System.Boolean deferSaveChanges = false)

        {

            if (Entity == null)

            {

                Context.AddObject(Path, item);

            }

            else

            {

                var lastSlash = Path.LastIndexOf('/');

                var shortPath = (lastSlash >= 0 && lastSlash < Path.Length - 1) ? Path.Substring(lastSlash + 1) : Path;

                Context.AddRelatedObject(Entity, shortPath, item);

            }

            if (!deferSaveChanges)

            {

                return Context.SaveChangesAsync();

            }

            else

            {

                var retVal = new global::System.Threading.Tasks.TaskCompletionSource<object>();

                retVal.SetResult(null);

                return retVal.Task;

            }

        }

        public global::Microsoft.Graph.IdirectoryRoleTemplateFetcher this[System.String id]

        {

            get

            {

                var path = GetPath<global::Microsoft.Graph.directoryRoleTemplate>((i) => i.id == id);

                var fetcher = new global::Microsoft.Graph.directoryRoleTemplateFetcher();

                fetcher.Initialize(Context, path);

                

                return fetcher;

            }

        }

    }

    internal partial class directoryRoleTemplateCollection

    {

        public global::System.Threading.Tasks.Task<System.Int64> CountAsync()

        {

            return new DataServiceQuerySingle<long>(Context, Path + "/$count").GetValueAsync();

        }

    }

    [global::Microsoft.OData.Client.Key("id")]

    public partial class group:global::Microsoft.Graph.directoryObject, global::Microsoft.Graph.Igroup, global::Microsoft.Graph.IgroupFetcher

    {

        private global::Microsoft.Graph.directoryObject _createdOnBehalfOf;

        private global::Microsoft.Graph.calendar _calendar;

        private global::Microsoft.Graph.profilePhoto _photo;

        private global::Microsoft.Graph.drive _drive;

        private global::Microsoft.Graph.notes _notes;

        private global::Microsoft.Graph.directoryObjectFetcher _createdOnBehalfOfFetcher;

        private global::Microsoft.Graph.calendarFetcher _calendarFetcher;

        private global::Microsoft.Graph.profilePhotoFetcher _photoFetcher;

        private global::Microsoft.Graph.driveFetcher _driveFetcher;

        private global::Microsoft.Graph.notesFetcher _notesFetcher;

        private global::Microsoft.Graph.directoryObjectCollection _membersCollection;

        private global::Microsoft.Graph.directoryObjectCollection _memberOfCollection;

        private global::Microsoft.Graph.directoryObjectCollection _ownersCollection;

        private global::Microsoft.Graph.conversationThreadCollection _threadsCollection;

        private global::Microsoft.Graph.eventCollection _calendarViewCollection;

        private global::Microsoft.Graph.eventCollection _eventsCollection;

        private global::Microsoft.Graph.conversationCollection _conversationsCollection;

        private global::Microsoft.Graph.profilePhotoCollection _photosCollection;

        private global::Microsoft.Graph.directoryObjectCollection _acceptedSendersCollection;

        private global::Microsoft.Graph.directoryObjectCollection _rejectedSendersCollection;

        private global::Microsoft.Graph.planCollection _plansCollection;

        private System.String _description;

        private System.String _displayName;

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.String> _groupTypes;

        private System.String _mail;

        private System.Nullable<System.Boolean> _mailEnabled;

        private System.String _mailNickname;

        private System.Nullable<System.DateTimeOffset> _onPremisesLastSyncDateTime;

        private System.String _onPremisesSecurityIdentifier;

        private System.Nullable<System.Boolean> _onPremisesSyncEnabled;

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.String> _proxyAddresses;

        private System.Nullable<System.Boolean> _securityEnabled;

        private System.String _visibility;

        private global::Microsoft.Graph.groupAccessType _accessType;

        private System.Nullable<System.Boolean> _allowExternalSenders;

        private System.Nullable<System.Boolean> _autoSubscribeNewMembers;

        private System.Nullable<System.Boolean> _isFavorite;

        private System.Nullable<System.Boolean> _isSubscribedByMail;

        private System.Nullable<System.Int32> _unseenCount;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.directoryObject> _membersConcrete;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.directoryObject> _memberOfConcrete;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.directoryObject> _ownersConcrete;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.conversationThread> _threadsConcrete;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.Event> _calendarViewConcrete;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.Event> _eventsConcrete;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.conversation> _conversationsConcrete;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.profilePhoto> _photosConcrete;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.directoryObject> _acceptedSendersConcrete;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.directoryObject> _rejectedSendersConcrete;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.plan> _plansConcrete;

        public System.String description

        {

            get

            {

                return _description;

            }

            set

            {

                if (value != _description)

                {

                    _description = value;

                    OnPropertyChanged("description");

                }

            }

        }

        public System.String displayName

        {

            get

            {

                return _displayName;

            }

            set

            {

                if (value != _displayName)

                {

                    _displayName = value;

                    OnPropertyChanged("displayName");

                }

            }

        }

        public System.Collections.Generic.IList<System.String> groupTypes

        {

            get

            {

                if (this._groupTypes == default(System.Collections.Generic.IList<System.String>))

                {

                    this._groupTypes = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.String>();

                    this._groupTypes.SetContainer(() => GetContainingEntity("groupTypes"));

                }

                return this._groupTypes;

            }

            set

            {

                groupTypes.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        groupTypes.Add(i);

                    }

                }

            }

        }

        public System.String mail

        {

            get

            {

                return _mail;

            }

            set

            {

                if (value != _mail)

                {

                    _mail = value;

                    OnPropertyChanged("mail");

                }

            }

        }

        public System.Nullable<System.Boolean> mailEnabled

        {

            get

            {

                return _mailEnabled;

            }

            set

            {

                if (value != _mailEnabled)

                {

                    _mailEnabled = value;

                    OnPropertyChanged("mailEnabled");

                }

            }

        }

        public System.String mailNickname

        {

            get

            {

                return _mailNickname;

            }

            set

            {

                if (value != _mailNickname)

                {

                    _mailNickname = value;

                    OnPropertyChanged("mailNickname");

                }

            }

        }

        public System.Nullable<System.DateTimeOffset> onPremisesLastSyncDateTime

        {

            get

            {

                return _onPremisesLastSyncDateTime;

            }

            set

            {

                if (value != _onPremisesLastSyncDateTime)

                {

                    _onPremisesLastSyncDateTime = value;

                    OnPropertyChanged("onPremisesLastSyncDateTime");

                }

            }

        }

        public System.String onPremisesSecurityIdentifier

        {

            get

            {

                return _onPremisesSecurityIdentifier;

            }

            set

            {

                if (value != _onPremisesSecurityIdentifier)

                {

                    _onPremisesSecurityIdentifier = value;

                    OnPropertyChanged("onPremisesSecurityIdentifier");

                }

            }

        }

        public System.Nullable<System.Boolean> onPremisesSyncEnabled

        {

            get

            {

                return _onPremisesSyncEnabled;

            }

            set

            {

                if (value != _onPremisesSyncEnabled)

                {

                    _onPremisesSyncEnabled = value;

                    OnPropertyChanged("onPremisesSyncEnabled");

                }

            }

        }

        public System.Collections.Generic.IList<System.String> proxyAddresses

        {

            get

            {

                if (this._proxyAddresses == default(System.Collections.Generic.IList<System.String>))

                {

                    this._proxyAddresses = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.String>();

                    this._proxyAddresses.SetContainer(() => GetContainingEntity("proxyAddresses"));

                }

                return this._proxyAddresses;

            }

            set

            {

                proxyAddresses.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        proxyAddresses.Add(i);

                    }

                }

            }

        }

        public System.Nullable<System.Boolean> securityEnabled

        {

            get

            {

                return _securityEnabled;

            }

            set

            {

                if (value != _securityEnabled)

                {

                    _securityEnabled = value;

                    OnPropertyChanged("securityEnabled");

                }

            }

        }

        public System.String visibility

        {

            get

            {

                return _visibility;

            }

            set

            {

                if (value != _visibility)

                {

                    _visibility = value;

                    OnPropertyChanged("visibility");

                }

            }

        }

        public global::Microsoft.Graph.groupAccessType accessType

        {

            get

            {

                return _accessType;

            }

            set

            {

                if (value != _accessType)

                {

                    _accessType = value;

                    OnPropertyChanged("accessType");

                }

            }

        }

        public System.Nullable<System.Boolean> allowExternalSenders

        {

            get

            {

                return _allowExternalSenders;

            }

            set

            {

                if (value != _allowExternalSenders)

                {

                    _allowExternalSenders = value;

                    OnPropertyChanged("allowExternalSenders");

                }

            }

        }

        public System.Nullable<System.Boolean> autoSubscribeNewMembers

        {

            get

            {

                return _autoSubscribeNewMembers;

            }

            set

            {

                if (value != _autoSubscribeNewMembers)

                {

                    _autoSubscribeNewMembers = value;

                    OnPropertyChanged("autoSubscribeNewMembers");

                }

            }

        }

        public System.Nullable<System.Boolean> isFavorite

        {

            get

            {

                return _isFavorite;

            }

            set

            {

                if (value != _isFavorite)

                {

                    _isFavorite = value;

                    OnPropertyChanged("isFavorite");

                }

            }

        }

        public System.Nullable<System.Boolean> isSubscribedByMail

        {

            get

            {

                return _isSubscribedByMail;

            }

            set

            {

                if (value != _isSubscribedByMail)

                {

                    _isSubscribedByMail = value;

                    OnPropertyChanged("isSubscribedByMail");

                }

            }

        }

        public System.Nullable<System.Int32> unseenCount

        {

            get

            {

                return _unseenCount;

            }

            set

            {

                if (value != _unseenCount)

                {

                    _unseenCount = value;

                    OnPropertyChanged("unseenCount");

                }

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.IdirectoryObject> global::Microsoft.Graph.Igroup.members

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.IdirectoryObject, global::Microsoft.Graph.directoryObject>(Context, (DataServiceCollection<global::Microsoft.Graph.directoryObject>) members);

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.IdirectoryObject> global::Microsoft.Graph.Igroup.memberOf

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.IdirectoryObject, global::Microsoft.Graph.directoryObject>(Context, (DataServiceCollection<global::Microsoft.Graph.directoryObject>) memberOf);

            }

        }

        global::Microsoft.Graph.IdirectoryObject global::Microsoft.Graph.Igroup.createdOnBehalfOf

        {

            get

            {

                return this._createdOnBehalfOf;

            }

            set

            {

                if (this.createdOnBehalfOf != value)

                {

                    this.createdOnBehalfOf = (global::Microsoft.Graph.directoryObject)value;

                }

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.IdirectoryObject> global::Microsoft.Graph.Igroup.owners

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.IdirectoryObject, global::Microsoft.Graph.directoryObject>(Context, (DataServiceCollection<global::Microsoft.Graph.directoryObject>) owners);

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.IconversationThread> global::Microsoft.Graph.Igroup.threads

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.IconversationThread, global::Microsoft.Graph.conversationThread>(Context, (DataServiceCollection<global::Microsoft.Graph.conversationThread>) threads);

            }

        }

        global::Microsoft.Graph.Icalendar global::Microsoft.Graph.Igroup.calendar

        {

            get

            {

                return this._calendar;

            }

            set

            {

                if (this.calendar != value)

                {

                    this.calendar = (global::Microsoft.Graph.calendar)value;

                }

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.Ievent> global::Microsoft.Graph.Igroup.calendarView

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.Ievent, global::Microsoft.Graph.Event>(Context, (DataServiceCollection<global::Microsoft.Graph.Event>) calendarView);

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.Ievent> global::Microsoft.Graph.Igroup.events

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.Ievent, global::Microsoft.Graph.Event>(Context, (DataServiceCollection<global::Microsoft.Graph.Event>) events);

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.Iconversation> global::Microsoft.Graph.Igroup.conversations

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.Iconversation, global::Microsoft.Graph.conversation>(Context, (DataServiceCollection<global::Microsoft.Graph.conversation>) conversations);

            }

        }

        global::Microsoft.Graph.IprofilePhoto global::Microsoft.Graph.Igroup.photo

        {

            get

            {

                return this._photo;

            }

            set

            {

                if (this.photo != value)

                {

                    this.photo = (global::Microsoft.Graph.profilePhoto)value;

                }

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.IprofilePhoto> global::Microsoft.Graph.Igroup.photos

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.IprofilePhoto, global::Microsoft.Graph.profilePhoto>(Context, (DataServiceCollection<global::Microsoft.Graph.profilePhoto>) photos);

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.IdirectoryObject> global::Microsoft.Graph.Igroup.acceptedSenders

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.IdirectoryObject, global::Microsoft.Graph.directoryObject>(Context, (DataServiceCollection<global::Microsoft.Graph.directoryObject>) acceptedSenders);

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.IdirectoryObject> global::Microsoft.Graph.Igroup.rejectedSenders

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.IdirectoryObject, global::Microsoft.Graph.directoryObject>(Context, (DataServiceCollection<global::Microsoft.Graph.directoryObject>) rejectedSenders);

            }

        }

        global::Microsoft.Graph.Idrive global::Microsoft.Graph.Igroup.drive

        {

            get

            {

                return this._drive;

            }

            set

            {

                if (this.drive != value)

                {

                    this.drive = (global::Microsoft.Graph.drive)value;

                }

            }

        }

        global::Microsoft.Graph.Inotes global::Microsoft.Graph.Igroup.notes

        {

            get

            {

                return this._notes;

            }

            set

            {

                if (this.notes != value)

                {

                    this.notes = (global::Microsoft.Graph.notes)value;

                }

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.Iplan> global::Microsoft.Graph.Igroup.plans

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.Iplan, global::Microsoft.Graph.plan>(Context, (DataServiceCollection<global::Microsoft.Graph.plan>) plans);

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.directoryObject> members

        {

            get

            {

                if (this._membersConcrete == null)

                {

                    this._membersConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.directoryObject>();

                    this._membersConcrete.SetContainer(() => GetContainingEntity("members"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.directoryObject>)this._membersConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                members.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        members.Add(i);

                    }

                }

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.directoryObject> memberOf

        {

            get

            {

                if (this._memberOfConcrete == null)

                {

                    this._memberOfConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.directoryObject>();

                    this._memberOfConcrete.SetContainer(() => GetContainingEntity("memberOf"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.directoryObject>)this._memberOfConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                memberOf.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        memberOf.Add(i);

                    }

                }

            }

        }

        public global::Microsoft.Graph.directoryObject createdOnBehalfOf

        {

            get

            {

                return this._createdOnBehalfOf;

            }

            set

            {

                if (this._createdOnBehalfOf != value)

                {

                    this._createdOnBehalfOf = value;

                    if (Context != null && Context.GetEntityDescriptor(this) != null && (value == null || Context.GetEntityDescriptor(value) != null))

                    {

                        Context.SetLink(this, "createdOnBehalfOf", value);

                    }

                }

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.directoryObject> owners

        {

            get

            {

                if (this._ownersConcrete == null)

                {

                    this._ownersConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.directoryObject>();

                    this._ownersConcrete.SetContainer(() => GetContainingEntity("owners"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.directoryObject>)this._ownersConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                owners.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        owners.Add(i);

                    }

                }

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.conversationThread> threads

        {

            get

            {

                if (this._threadsConcrete == null)

                {

                    this._threadsConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.conversationThread>();

                    this._threadsConcrete.SetContainer(() => GetContainingEntity("threads"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.conversationThread>)this._threadsConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                threads.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        threads.Add(i);

                    }

                }

            }

        }

        public global::Microsoft.Graph.calendar calendar

        {

            get

            {

                return this._calendar;

            }

            set

            {

                if (this._calendar != value)

                {

                    this._calendar = value;

                    if (Context != null && Context.GetEntityDescriptor(this) != null && (value == null || Context.GetEntityDescriptor(value) != null))

                    {

                        Context.SetLink(this, "calendar", value);

                    }

                }

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.Event> calendarView

        {

            get

            {

                if (this._calendarViewConcrete == null)

                {

                    this._calendarViewConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.Event>();

                    this._calendarViewConcrete.SetContainer(() => GetContainingEntity("calendarView"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.Event>)this._calendarViewConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                calendarView.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        calendarView.Add(i);

                    }

                }

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.Event> events

        {

            get

            {

                if (this._eventsConcrete == null)

                {

                    this._eventsConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.Event>();

                    this._eventsConcrete.SetContainer(() => GetContainingEntity("events"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.Event>)this._eventsConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                events.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        events.Add(i);

                    }

                }

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.conversation> conversations

        {

            get

            {

                if (this._conversationsConcrete == null)

                {

                    this._conversationsConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.conversation>();

                    this._conversationsConcrete.SetContainer(() => GetContainingEntity("conversations"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.conversation>)this._conversationsConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                conversations.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        conversations.Add(i);

                    }

                }

            }

        }

        public global::Microsoft.Graph.profilePhoto photo

        {

            get

            {

                return this._photo;

            }

            set

            {

                if (this._photo != value)

                {

                    this._photo = value;

                    if (Context != null && Context.GetEntityDescriptor(this) != null && (value == null || Context.GetEntityDescriptor(value) != null))

                    {

                        Context.SetLink(this, "photo", value);

                    }

                }

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.profilePhoto> photos

        {

            get

            {

                if (this._photosConcrete == null)

                {

                    this._photosConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.profilePhoto>();

                    this._photosConcrete.SetContainer(() => GetContainingEntity("photos"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.profilePhoto>)this._photosConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                photos.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        photos.Add(i);

                    }

                }

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.directoryObject> acceptedSenders

        {

            get

            {

                if (this._acceptedSendersConcrete == null)

                {

                    this._acceptedSendersConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.directoryObject>();

                    this._acceptedSendersConcrete.SetContainer(() => GetContainingEntity("acceptedSenders"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.directoryObject>)this._acceptedSendersConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                acceptedSenders.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        acceptedSenders.Add(i);

                    }

                }

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.directoryObject> rejectedSenders

        {

            get

            {

                if (this._rejectedSendersConcrete == null)

                {

                    this._rejectedSendersConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.directoryObject>();

                    this._rejectedSendersConcrete.SetContainer(() => GetContainingEntity("rejectedSenders"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.directoryObject>)this._rejectedSendersConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                rejectedSenders.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        rejectedSenders.Add(i);

                    }

                }

            }

        }

        public global::Microsoft.Graph.drive drive

        {

            get

            {

                return this._drive;

            }

            set

            {

                if (this._drive != value)

                {

                    this._drive = value;

                    if (Context != null && Context.GetEntityDescriptor(this) != null && (value == null || Context.GetEntityDescriptor(value) != null))

                    {

                        Context.SetLink(this, "drive", value);

                    }

                }

            }

        }

        public global::Microsoft.Graph.notes notes

        {

            get

            {

                return this._notes;

            }

            set

            {

                if (this._notes != value)

                {

                    this._notes = value;

                    if (Context != null && Context.GetEntityDescriptor(this) != null && (value == null || Context.GetEntityDescriptor(value) != null))

                    {

                        Context.SetLink(this, "notes", value);

                    }

                }

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.plan> plans

        {

            get

            {

                if (this._plansConcrete == null)

                {

                    this._plansConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.plan>();

                    this._plansConcrete.SetContainer(() => GetContainingEntity("plans"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.plan>)this._plansConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                plans.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        plans.Add(i);

                    }

                }

            }

        }

        global::Microsoft.Graph.IdirectoryObjectCollection global::Microsoft.Graph.IgroupFetcher.members

        {

            get

            {

                if (this._membersCollection == null)

                {

                    this._membersCollection = new global::Microsoft.Graph.directoryObjectCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.directoryObject>(GetPath("members")) : null,
                       Context,
                       this,
                       GetPath("members"));

                }

                

                return this._membersCollection;

            }

        }

        global::Microsoft.Graph.IdirectoryObjectCollection global::Microsoft.Graph.IgroupFetcher.memberOf

        {

            get

            {

                if (this._memberOfCollection == null)

                {

                    this._memberOfCollection = new global::Microsoft.Graph.directoryObjectCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.directoryObject>(GetPath("memberOf")) : null,
                       Context,
                       this,
                       GetPath("memberOf"));

                }

                

                return this._memberOfCollection;

            }

        }

        global::Microsoft.Graph.IdirectoryObjectFetcher global::Microsoft.Graph.IgroupFetcher.createdOnBehalfOf

        {

            get

            {

                if (this._createdOnBehalfOfFetcher == null)

                {

                    this._createdOnBehalfOfFetcher = new global::Microsoft.Graph.directoryObjectFetcher();

                    this._createdOnBehalfOfFetcher.Initialize(this.Context, GetPath("createdOnBehalfOf"));

                }

                

                return this._createdOnBehalfOfFetcher;

            }

        }

        global::Microsoft.Graph.IdirectoryObjectCollection global::Microsoft.Graph.IgroupFetcher.owners

        {

            get

            {

                if (this._ownersCollection == null)

                {

                    this._ownersCollection = new global::Microsoft.Graph.directoryObjectCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.directoryObject>(GetPath("owners")) : null,
                       Context,
                       this,
                       GetPath("owners"));

                }

                

                return this._ownersCollection;

            }

        }

        global::Microsoft.Graph.IconversationThreadCollection global::Microsoft.Graph.IgroupFetcher.threads

        {

            get

            {

                if (this._threadsCollection == null)

                {

                    this._threadsCollection = new global::Microsoft.Graph.conversationThreadCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.conversationThread>(GetPath("threads")) : null,
                       Context,
                       this,
                       GetPath("threads"));

                }

                

                return this._threadsCollection;

            }

        }

        global::Microsoft.Graph.IcalendarFetcher global::Microsoft.Graph.IgroupFetcher.calendar

        {

            get

            {

                if (this._calendarFetcher == null)

                {

                    this._calendarFetcher = new global::Microsoft.Graph.calendarFetcher();

                    this._calendarFetcher.Initialize(this.Context, GetPath("calendar"));

                }

                

                return this._calendarFetcher;

            }

        }

        global::Microsoft.Graph.IeventCollection global::Microsoft.Graph.IgroupFetcher.calendarView

        {

            get

            {

                if (this._calendarViewCollection == null)

                {

                    this._calendarViewCollection = new global::Microsoft.Graph.eventCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.Event>(GetPath("calendarView")) : null,
                       Context,
                       this,
                       GetPath("calendarView"));

                }

                

                return this._calendarViewCollection;

            }

        }

        global::Microsoft.Graph.IeventCollection global::Microsoft.Graph.IgroupFetcher.events

        {

            get

            {

                if (this._eventsCollection == null)

                {

                    this._eventsCollection = new global::Microsoft.Graph.eventCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.Event>(GetPath("events")) : null,
                       Context,
                       this,
                       GetPath("events"));

                }

                

                return this._eventsCollection;

            }

        }

        global::Microsoft.Graph.IconversationCollection global::Microsoft.Graph.IgroupFetcher.conversations

        {

            get

            {

                if (this._conversationsCollection == null)

                {

                    this._conversationsCollection = new global::Microsoft.Graph.conversationCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.conversation>(GetPath("conversations")) : null,
                       Context,
                       this,
                       GetPath("conversations"));

                }

                

                return this._conversationsCollection;

            }

        }

        global::Microsoft.Graph.IprofilePhotoFetcher global::Microsoft.Graph.IgroupFetcher.photo

        {

            get

            {

                if (this._photoFetcher == null)

                {

                    this._photoFetcher = new global::Microsoft.Graph.profilePhotoFetcher();

                    this._photoFetcher.Initialize(this.Context, GetPath("photo"));

                }

                

                return this._photoFetcher;

            }

        }

        global::Microsoft.Graph.IprofilePhotoCollection global::Microsoft.Graph.IgroupFetcher.photos

        {

            get

            {

                if (this._photosCollection == null)

                {

                    this._photosCollection = new global::Microsoft.Graph.profilePhotoCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.profilePhoto>(GetPath("photos")) : null,
                       Context,
                       this,
                       GetPath("photos"));

                }

                

                return this._photosCollection;

            }

        }

        global::Microsoft.Graph.IdirectoryObjectCollection global::Microsoft.Graph.IgroupFetcher.acceptedSenders

        {

            get

            {

                if (this._acceptedSendersCollection == null)

                {

                    this._acceptedSendersCollection = new global::Microsoft.Graph.directoryObjectCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.directoryObject>(GetPath("acceptedSenders")) : null,
                       Context,
                       this,
                       GetPath("acceptedSenders"));

                }

                

                return this._acceptedSendersCollection;

            }

        }

        global::Microsoft.Graph.IdirectoryObjectCollection global::Microsoft.Graph.IgroupFetcher.rejectedSenders

        {

            get

            {

                if (this._rejectedSendersCollection == null)

                {

                    this._rejectedSendersCollection = new global::Microsoft.Graph.directoryObjectCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.directoryObject>(GetPath("rejectedSenders")) : null,
                       Context,
                       this,
                       GetPath("rejectedSenders"));

                }

                

                return this._rejectedSendersCollection;

            }

        }

        global::Microsoft.Graph.IdriveFetcher global::Microsoft.Graph.IgroupFetcher.drive

        {

            get

            {

                if (this._driveFetcher == null)

                {

                    this._driveFetcher = new global::Microsoft.Graph.driveFetcher();

                    this._driveFetcher.Initialize(this.Context, GetPath("drive"));

                }

                

                return this._driveFetcher;

            }

        }

        global::Microsoft.Graph.InotesFetcher global::Microsoft.Graph.IgroupFetcher.notes

        {

            get

            {

                if (this._notesFetcher == null)

                {

                    this._notesFetcher = new global::Microsoft.Graph.notesFetcher();

                    this._notesFetcher.Initialize(this.Context, GetPath("notes"));

                }

                

                return this._notesFetcher;

            }

        }

        global::Microsoft.Graph.IplanCollection global::Microsoft.Graph.IgroupFetcher.plans

        {

            get

            {

                if (this._plansCollection == null)

                {

                    this._plansCollection = new global::Microsoft.Graph.planCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.plan>(GetPath("plans")) : null,
                       Context,
                       this,
                       GetPath("plans"));

                }

                

                return this._plansCollection;

            }

        }

        public group()

        {

        }

        public async System.Threading.Tasks.Task subscribeByMailAsync()

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.subscribeByMail");

            await this.Context.ExecuteAsync(requestUri, "POST", new OperationParameter[0]

            {

            }

            );

        }

        public async System.Threading.Tasks.Task unsubscribeByMailAsync()

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.unsubscribeByMail");

            await this.Context.ExecuteAsync(requestUri, "POST", new OperationParameter[0]

            {

            }

            );

        }

        public async System.Threading.Tasks.Task addFavoriteAsync()

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.addFavorite");

            await this.Context.ExecuteAsync(requestUri, "POST", new OperationParameter[0]

            {

            }

            );

        }

        public async System.Threading.Tasks.Task removeFavoriteAsync()

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.removeFavorite");

            await this.Context.ExecuteAsync(requestUri, "POST", new OperationParameter[0]

            {

            }

            );

        }

        public async System.Threading.Tasks.Task resetUnseenCountAsync()

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.resetUnseenCount");

            await this.Context.ExecuteAsync(requestUri, "POST", new OperationParameter[0]

            {

            }

            );

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Igroup> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.group, global::Microsoft.Graph.Igroup>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Igroup> _query;

        global::System.Threading.Tasks.Task<global::Microsoft.Graph.Igroup> global::Microsoft.Graph.IgroupFetcher.ExecuteAsync()

        {

            var tsc = new global::System.Threading.Tasks.TaskCompletionSource<global::Microsoft.Graph.Igroup>();

            tsc.SetResult(this);

            return tsc.Task;

        }

        global::Microsoft.Graph.IgroupFetcher global::Microsoft.Graph.IgroupFetcher.Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.Igroup, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IgroupFetcher) this;

        }

    }

    internal partial class groupFetcher:global::Microsoft.Graph.directoryObjectFetcher, global::Microsoft.Graph.IgroupFetcher

    {

        private global::Microsoft.Graph.directoryObjectFetcher _createdOnBehalfOfFetcher;

        private global::Microsoft.Graph.calendarFetcher _calendarFetcher;

        private global::Microsoft.Graph.profilePhotoFetcher _photoFetcher;

        private global::Microsoft.Graph.driveFetcher _driveFetcher;

        private global::Microsoft.Graph.notesFetcher _notesFetcher;

        private global::Microsoft.Graph.directoryObjectCollection _membersCollection;

        private global::Microsoft.Graph.directoryObjectCollection _memberOfCollection;

        private global::Microsoft.Graph.directoryObjectCollection _ownersCollection;

        private global::Microsoft.Graph.conversationThreadCollection _threadsCollection;

        private global::Microsoft.Graph.eventCollection _calendarViewCollection;

        private global::Microsoft.Graph.eventCollection _eventsCollection;

        private global::Microsoft.Graph.conversationCollection _conversationsCollection;

        private global::Microsoft.Graph.profilePhotoCollection _photosCollection;

        private global::Microsoft.Graph.directoryObjectCollection _acceptedSendersCollection;

        private global::Microsoft.Graph.directoryObjectCollection _rejectedSendersCollection;

        private global::Microsoft.Graph.planCollection _plansCollection;

        public global::Microsoft.Graph.IdirectoryObjectCollection members

        {

            get

            {

                if (this._membersCollection == null)

                {

                    this._membersCollection = new global::Microsoft.Graph.directoryObjectCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.directoryObject>(GetPath("members")) : null,
                       Context,
                       this,
                       GetPath("members"));

                }

                

                return this._membersCollection;

            }

        }

        public global::Microsoft.Graph.IdirectoryObjectCollection memberOf

        {

            get

            {

                if (this._memberOfCollection == null)

                {

                    this._memberOfCollection = new global::Microsoft.Graph.directoryObjectCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.directoryObject>(GetPath("memberOf")) : null,
                       Context,
                       this,
                       GetPath("memberOf"));

                }

                

                return this._memberOfCollection;

            }

        }

        public global::Microsoft.Graph.IdirectoryObjectFetcher createdOnBehalfOf

        {

            get

            {

                if (this._createdOnBehalfOfFetcher == null)

                {

                    this._createdOnBehalfOfFetcher = new global::Microsoft.Graph.directoryObjectFetcher();

                    this._createdOnBehalfOfFetcher.Initialize(this.Context, GetPath("createdOnBehalfOf"));

                }

                

                return this._createdOnBehalfOfFetcher;

            }

        }

        public global::Microsoft.Graph.IdirectoryObjectCollection owners

        {

            get

            {

                if (this._ownersCollection == null)

                {

                    this._ownersCollection = new global::Microsoft.Graph.directoryObjectCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.directoryObject>(GetPath("owners")) : null,
                       Context,
                       this,
                       GetPath("owners"));

                }

                

                return this._ownersCollection;

            }

        }

        public global::Microsoft.Graph.IconversationThreadCollection threads

        {

            get

            {

                if (this._threadsCollection == null)

                {

                    this._threadsCollection = new global::Microsoft.Graph.conversationThreadCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.conversationThread>(GetPath("threads")) : null,
                       Context,
                       this,
                       GetPath("threads"));

                }

                

                return this._threadsCollection;

            }

        }

        public global::Microsoft.Graph.IcalendarFetcher calendar

        {

            get

            {

                if (this._calendarFetcher == null)

                {

                    this._calendarFetcher = new global::Microsoft.Graph.calendarFetcher();

                    this._calendarFetcher.Initialize(this.Context, GetPath("calendar"));

                }

                

                return this._calendarFetcher;

            }

        }

        public global::Microsoft.Graph.IeventCollection calendarView

        {

            get

            {

                if (this._calendarViewCollection == null)

                {

                    this._calendarViewCollection = new global::Microsoft.Graph.eventCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.Event>(GetPath("calendarView")) : null,
                       Context,
                       this,
                       GetPath("calendarView"));

                }

                

                return this._calendarViewCollection;

            }

        }

        public global::Microsoft.Graph.IeventCollection events

        {

            get

            {

                if (this._eventsCollection == null)

                {

                    this._eventsCollection = new global::Microsoft.Graph.eventCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.Event>(GetPath("events")) : null,
                       Context,
                       this,
                       GetPath("events"));

                }

                

                return this._eventsCollection;

            }

        }

        public global::Microsoft.Graph.IconversationCollection conversations

        {

            get

            {

                if (this._conversationsCollection == null)

                {

                    this._conversationsCollection = new global::Microsoft.Graph.conversationCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.conversation>(GetPath("conversations")) : null,
                       Context,
                       this,
                       GetPath("conversations"));

                }

                

                return this._conversationsCollection;

            }

        }

        public global::Microsoft.Graph.IprofilePhotoFetcher photo

        {

            get

            {

                if (this._photoFetcher == null)

                {

                    this._photoFetcher = new global::Microsoft.Graph.profilePhotoFetcher();

                    this._photoFetcher.Initialize(this.Context, GetPath("photo"));

                }

                

                return this._photoFetcher;

            }

        }

        public global::Microsoft.Graph.IprofilePhotoCollection photos

        {

            get

            {

                if (this._photosCollection == null)

                {

                    this._photosCollection = new global::Microsoft.Graph.profilePhotoCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.profilePhoto>(GetPath("photos")) : null,
                       Context,
                       this,
                       GetPath("photos"));

                }

                

                return this._photosCollection;

            }

        }

        public global::Microsoft.Graph.IdirectoryObjectCollection acceptedSenders

        {

            get

            {

                if (this._acceptedSendersCollection == null)

                {

                    this._acceptedSendersCollection = new global::Microsoft.Graph.directoryObjectCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.directoryObject>(GetPath("acceptedSenders")) : null,
                       Context,
                       this,
                       GetPath("acceptedSenders"));

                }

                

                return this._acceptedSendersCollection;

            }

        }

        public global::Microsoft.Graph.IdirectoryObjectCollection rejectedSenders

        {

            get

            {

                if (this._rejectedSendersCollection == null)

                {

                    this._rejectedSendersCollection = new global::Microsoft.Graph.directoryObjectCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.directoryObject>(GetPath("rejectedSenders")) : null,
                       Context,
                       this,
                       GetPath("rejectedSenders"));

                }

                

                return this._rejectedSendersCollection;

            }

        }

        public global::Microsoft.Graph.IdriveFetcher drive

        {

            get

            {

                if (this._driveFetcher == null)

                {

                    this._driveFetcher = new global::Microsoft.Graph.driveFetcher();

                    this._driveFetcher.Initialize(this.Context, GetPath("drive"));

                }

                

                return this._driveFetcher;

            }

        }

        public global::Microsoft.Graph.InotesFetcher notes

        {

            get

            {

                if (this._notesFetcher == null)

                {

                    this._notesFetcher = new global::Microsoft.Graph.notesFetcher();

                    this._notesFetcher.Initialize(this.Context, GetPath("notes"));

                }

                

                return this._notesFetcher;

            }

        }

        public global::Microsoft.Graph.IplanCollection plans

        {

            get

            {

                if (this._plansCollection == null)

                {

                    this._plansCollection = new global::Microsoft.Graph.planCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.plan>(GetPath("plans")) : null,
                       Context,
                       this,
                       GetPath("plans"));

                }

                

                return this._plansCollection;

            }

        }

        public groupFetcher()

        {

        }

        public async System.Threading.Tasks.Task subscribeByMailAsync()

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.subscribeByMail");

            await this.Context.ExecuteAsync(requestUri, "POST", new OperationParameter[0]

            {

            }

            );

        }

        public async System.Threading.Tasks.Task unsubscribeByMailAsync()

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.unsubscribeByMail");

            await this.Context.ExecuteAsync(requestUri, "POST", new OperationParameter[0]

            {

            }

            );

        }

        public async System.Threading.Tasks.Task addFavoriteAsync()

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.addFavorite");

            await this.Context.ExecuteAsync(requestUri, "POST", new OperationParameter[0]

            {

            }

            );

        }

        public async System.Threading.Tasks.Task removeFavoriteAsync()

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.removeFavorite");

            await this.Context.ExecuteAsync(requestUri, "POST", new OperationParameter[0]

            {

            }

            );

        }

        public async System.Threading.Tasks.Task resetUnseenCountAsync()

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.resetUnseenCount");

            await this.Context.ExecuteAsync(requestUri, "POST", new OperationParameter[0]

            {

            }

            );

        }

        public async new global::System.Threading.Tasks.Task<global::Microsoft.Graph.Igroup> ExecuteAsync()

        {

            return await EnsureQuery().ExecuteSingleAsync();

        }

        public global::Microsoft.Graph.IgroupFetcher Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.Igroup, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IgroupFetcher) new global::Microsoft.Graph.groupFetcher()

            {

                _query = this.EnsureQuery().Expand<TTarget>(navigationPropertyAccessor)

            }

            ;

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Igroup> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.group, global::Microsoft.Graph.Igroup>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Igroup> _query;

    }

    internal partial class groupCollection:Microsoft.OData.ProxyExtensions.QueryableSet<global::Microsoft.Graph.Igroup>, global::Microsoft.Graph.IgroupCollection

    {

        internal groupCollection(global::Microsoft.OData.Client.DataServiceQuery inner,Microsoft.OData.ProxyExtensions.DataServiceContextWrapper context,object entity,string path): base(inner, context, entity as Microsoft.OData.ProxyExtensions.EntityBase, path)

        {

        }

        public global::Microsoft.Graph.IgroupFetcher GetById(System.String id)

        {

            return this[id];

        }

        public global::System.Threading.Tasks.Task<Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.Igroup>> ExecuteAsync()

        {

            return ExecuteAsyncInternal();

        }

        public global::System.Threading.Tasks.Task AddgroupAsync(global::Microsoft.Graph.Igroup item, System.Boolean deferSaveChanges = false)

        {

            if (Entity == null)

            {

                Context.AddObject(Path, item);

            }

            else

            {

                var lastSlash = Path.LastIndexOf('/');

                var shortPath = (lastSlash >= 0 && lastSlash < Path.Length - 1) ? Path.Substring(lastSlash + 1) : Path;

                Context.AddRelatedObject(Entity, shortPath, item);

            }

            if (!deferSaveChanges)

            {

                return Context.SaveChangesAsync();

            }

            else

            {

                var retVal = new global::System.Threading.Tasks.TaskCompletionSource<object>();

                retVal.SetResult(null);

                return retVal.Task;

            }

        }

        public global::Microsoft.Graph.IgroupFetcher this[System.String id]

        {

            get

            {

                var path = GetPath<global::Microsoft.Graph.group>((i) => i.id == id);

                var fetcher = new global::Microsoft.Graph.groupFetcher();

                fetcher.Initialize(Context, path);

                

                return fetcher;

            }

        }

    }

    internal partial class groupCollection

    {

        public global::System.Threading.Tasks.Task<System.Int64> CountAsync()

        {

            return new DataServiceQuerySingle<long>(Context, Path + "/$count").GetValueAsync();

        }

    }

    [global::Microsoft.OData.Client.Key("id")]

    public partial class conversationThread:Microsoft.OData.ProxyExtensions.EntityBase, global::Microsoft.Graph.IconversationThread, global::Microsoft.Graph.IconversationThreadFetcher

    {

        private global::Microsoft.Graph.postCollection _postsCollection;

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.recipient> _toRecipients;

        private System.String _topic;

        private System.Boolean _hasAttachments;

        private System.DateTimeOffset _lastDeliveredDateTime;

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.String> _uniqueSenders;

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.recipient> _ccRecipients;

        private System.String _preview;

        private System.Boolean _isLocked;

        private System.String _id;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.post> _postsConcrete;

        public System.Collections.Generic.IList<global::Microsoft.Graph.recipient> toRecipients

        {

            get

            {

                if (this._toRecipients == default(System.Collections.Generic.IList<global::Microsoft.Graph.recipient>))

                {

                    this._toRecipients = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.recipient>();

                    this._toRecipients.SetContainer(() => GetContainingEntity("toRecipients"));

                }

                return this._toRecipients;

            }

            set

            {

                toRecipients.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        toRecipients.Add(i);

                    }

                }

            }

        }

        public System.String topic

        {

            get

            {

                return _topic;

            }

            set

            {

                if (value != _topic)

                {

                    _topic = value;

                    OnPropertyChanged("topic");

                }

            }

        }

        public System.Boolean hasAttachments

        {

            get

            {

                return _hasAttachments;

            }

            set

            {

                if (value != _hasAttachments)

                {

                    _hasAttachments = value;

                    OnPropertyChanged("hasAttachments");

                }

            }

        }

        public System.DateTimeOffset lastDeliveredDateTime

        {

            get

            {

                return _lastDeliveredDateTime;

            }

            set

            {

                if (value != _lastDeliveredDateTime)

                {

                    _lastDeliveredDateTime = value;

                    OnPropertyChanged("lastDeliveredDateTime");

                }

            }

        }

        public System.Collections.Generic.IList<System.String> uniqueSenders

        {

            get

            {

                if (this._uniqueSenders == default(System.Collections.Generic.IList<System.String>))

                {

                    this._uniqueSenders = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.String>();

                    this._uniqueSenders.SetContainer(() => GetContainingEntity("uniqueSenders"));

                }

                return this._uniqueSenders;

            }

            set

            {

                uniqueSenders.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        uniqueSenders.Add(i);

                    }

                }

            }

        }

        public System.Collections.Generic.IList<global::Microsoft.Graph.recipient> ccRecipients

        {

            get

            {

                if (this._ccRecipients == default(System.Collections.Generic.IList<global::Microsoft.Graph.recipient>))

                {

                    this._ccRecipients = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.recipient>();

                    this._ccRecipients.SetContainer(() => GetContainingEntity("ccRecipients"));

                }

                return this._ccRecipients;

            }

            set

            {

                ccRecipients.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        ccRecipients.Add(i);

                    }

                }

            }

        }

        public System.String preview

        {

            get

            {

                return _preview;

            }

            set

            {

                if (value != _preview)

                {

                    _preview = value;

                    OnPropertyChanged("preview");

                }

            }

        }

        public System.Boolean isLocked

        {

            get

            {

                return _isLocked;

            }

            set

            {

                if (value != _isLocked)

                {

                    _isLocked = value;

                    OnPropertyChanged("isLocked");

                }

            }

        }

        public System.String id

        {

            get

            {

                return _id;

            }

            set

            {

                if (value != _id)

                {

                    _id = value;

                    OnPropertyChanged("id");

                }

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.Ipost> global::Microsoft.Graph.IconversationThread.posts

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.Ipost, global::Microsoft.Graph.post>(Context, (DataServiceCollection<global::Microsoft.Graph.post>) posts);

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.post> posts

        {

            get

            {

                if (this._postsConcrete == null)

                {

                    this._postsConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.post>();

                    this._postsConcrete.SetContainer(() => GetContainingEntity("posts"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.post>)this._postsConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                posts.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        posts.Add(i);

                    }

                }

            }

        }

        global::Microsoft.Graph.IpostCollection global::Microsoft.Graph.IconversationThreadFetcher.posts

        {

            get

            {

                if (this._postsCollection == null)

                {

                    this._postsCollection = new global::Microsoft.Graph.postCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.post>(GetPath("posts")) : null,
                       Context,
                       this,
                       GetPath("posts"));

                }

                

                return this._postsCollection;

            }

        }

        public conversationThread(): base()

        {

        }

        public async System.Threading.Tasks.Task replyAsync(global::Microsoft.Graph.Ipost Post)

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.reply");

            await this.Context.ExecuteAsync(requestUri, "POST", new OperationParameter[1]

            {

                new BodyOperationParameter("Post", (object) Post),

            }

            );

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IconversationThread> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.conversationThread, global::Microsoft.Graph.IconversationThread>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IconversationThread> _query;

        global::System.Threading.Tasks.Task<global::Microsoft.Graph.IconversationThread> global::Microsoft.Graph.IconversationThreadFetcher.ExecuteAsync()

        {

            var tsc = new global::System.Threading.Tasks.TaskCompletionSource<global::Microsoft.Graph.IconversationThread>();

            tsc.SetResult(this);

            return tsc.Task;

        }

        global::Microsoft.Graph.IconversationThreadFetcher global::Microsoft.Graph.IconversationThreadFetcher.Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.IconversationThread, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IconversationThreadFetcher) this;

        }

    }

    internal partial class conversationThreadFetcher:Microsoft.OData.ProxyExtensions.RestShallowObjectFetcher, global::Microsoft.Graph.IconversationThreadFetcher

    {

        private global::Microsoft.Graph.postCollection _postsCollection;

        public global::Microsoft.Graph.IpostCollection posts

        {

            get

            {

                if (this._postsCollection == null)

                {

                    this._postsCollection = new global::Microsoft.Graph.postCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.post>(GetPath("posts")) : null,
                       Context,
                       this,
                       GetPath("posts"));

                }

                

                return this._postsCollection;

            }

        }

        public conversationThreadFetcher(): base()

        {

        }

        public async System.Threading.Tasks.Task replyAsync(global::Microsoft.Graph.Ipost Post)

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.reply");

            await this.Context.ExecuteAsync(requestUri, "POST", new OperationParameter[1]

            {

                new BodyOperationParameter("Post", (object) Post),

            }

            );

        }

        public async global::System.Threading.Tasks.Task<global::Microsoft.Graph.IconversationThread> ExecuteAsync()

        {

            return await EnsureQuery().ExecuteSingleAsync();

        }

        public global::Microsoft.Graph.IconversationThreadFetcher Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.IconversationThread, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IconversationThreadFetcher) new global::Microsoft.Graph.conversationThreadFetcher()

            {

                _query = this.EnsureQuery().Expand<TTarget>(navigationPropertyAccessor)

            }

            ;

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IconversationThread> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.conversationThread, global::Microsoft.Graph.IconversationThread>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IconversationThread> _query;

    }

    internal partial class conversationThreadCollection:Microsoft.OData.ProxyExtensions.QueryableSet<global::Microsoft.Graph.IconversationThread>, global::Microsoft.Graph.IconversationThreadCollection

    {

        internal conversationThreadCollection(global::Microsoft.OData.Client.DataServiceQuery inner,Microsoft.OData.ProxyExtensions.DataServiceContextWrapper context,object entity,string path): base(inner, context, entity as Microsoft.OData.ProxyExtensions.EntityBase, path)

        {

        }

        public global::Microsoft.Graph.IconversationThreadFetcher GetById(System.String id)

        {

            return this[id];

        }

        public global::System.Threading.Tasks.Task<Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.IconversationThread>> ExecuteAsync()

        {

            return ExecuteAsyncInternal();

        }

        public global::System.Threading.Tasks.Task AddconversationThreadAsync(global::Microsoft.Graph.IconversationThread item, System.Boolean deferSaveChanges = false)

        {

            if (Entity == null)

            {

                Context.AddObject(Path, item);

            }

            else

            {

                var lastSlash = Path.LastIndexOf('/');

                var shortPath = (lastSlash >= 0 && lastSlash < Path.Length - 1) ? Path.Substring(lastSlash + 1) : Path;

                Context.AddRelatedObject(Entity, shortPath, item);

            }

            if (!deferSaveChanges)

            {

                return Context.SaveChangesAsync();

            }

            else

            {

                var retVal = new global::System.Threading.Tasks.TaskCompletionSource<object>();

                retVal.SetResult(null);

                return retVal.Task;

            }

        }

        public global::Microsoft.Graph.IconversationThreadFetcher this[System.String id]

        {

            get

            {

                var path = GetPath<global::Microsoft.Graph.conversationThread>((i) => i.id == id);

                var fetcher = new global::Microsoft.Graph.conversationThreadFetcher();

                fetcher.Initialize(Context, path);

                

                return fetcher;

            }

        }

    }

    internal partial class conversationThreadCollection

    {

        public global::System.Threading.Tasks.Task<System.Int64> CountAsync()

        {

            return new DataServiceQuerySingle<long>(Context, Path + "/$count").GetValueAsync();

        }

    }

    internal partial class conversationThreadFetcher

    {

    }

    public partial class conversationThread

    {

    }

    [global::Microsoft.OData.Client.Key("id")]

    public partial class calendar:Microsoft.OData.ProxyExtensions.EntityBase, global::Microsoft.Graph.Icalendar, global::Microsoft.Graph.IcalendarFetcher

    {

        private global::Microsoft.Graph.eventCollection _eventsCollection;

        private global::Microsoft.Graph.eventCollection _calendarViewCollection;

        private System.String _name;

        private global::Microsoft.Graph.calendarColor _color;

        private System.String _changeKey;

        private System.String _id;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.Event> _eventsConcrete;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.Event> _calendarViewConcrete;

        public System.String name

        {

            get

            {

                return _name;

            }

            set

            {

                if (value != _name)

                {

                    _name = value;

                    OnPropertyChanged("name");

                }

            }

        }

        public global::Microsoft.Graph.calendarColor color

        {

            get

            {

                return _color;

            }

            set

            {

                if (value != _color)

                {

                    _color = value;

                    OnPropertyChanged("color");

                }

            }

        }

        public System.String changeKey

        {

            get

            {

                return _changeKey;

            }

            set

            {

                if (value != _changeKey)

                {

                    _changeKey = value;

                    OnPropertyChanged("changeKey");

                }

            }

        }

        public System.String id

        {

            get

            {

                return _id;

            }

            set

            {

                if (value != _id)

                {

                    _id = value;

                    OnPropertyChanged("id");

                }

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.Ievent> global::Microsoft.Graph.Icalendar.events

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.Ievent, global::Microsoft.Graph.Event>(Context, (DataServiceCollection<global::Microsoft.Graph.Event>) events);

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.Ievent> global::Microsoft.Graph.Icalendar.calendarView

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.Ievent, global::Microsoft.Graph.Event>(Context, (DataServiceCollection<global::Microsoft.Graph.Event>) calendarView);

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.Event> events

        {

            get

            {

                if (this._eventsConcrete == null)

                {

                    this._eventsConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.Event>();

                    this._eventsConcrete.SetContainer(() => GetContainingEntity("events"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.Event>)this._eventsConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                events.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        events.Add(i);

                    }

                }

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.Event> calendarView

        {

            get

            {

                if (this._calendarViewConcrete == null)

                {

                    this._calendarViewConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.Event>();

                    this._calendarViewConcrete.SetContainer(() => GetContainingEntity("calendarView"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.Event>)this._calendarViewConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                calendarView.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        calendarView.Add(i);

                    }

                }

            }

        }

        global::Microsoft.Graph.IeventCollection global::Microsoft.Graph.IcalendarFetcher.events

        {

            get

            {

                if (this._eventsCollection == null)

                {

                    this._eventsCollection = new global::Microsoft.Graph.eventCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.Event>(GetPath("events")) : null,
                       Context,
                       this,
                       GetPath("events"));

                }

                

                return this._eventsCollection;

            }

        }

        global::Microsoft.Graph.IeventCollection global::Microsoft.Graph.IcalendarFetcher.calendarView

        {

            get

            {

                if (this._calendarViewCollection == null)

                {

                    this._calendarViewCollection = new global::Microsoft.Graph.eventCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.Event>(GetPath("calendarView")) : null,
                       Context,
                       this,
                       GetPath("calendarView"));

                }

                

                return this._calendarViewCollection;

            }

        }

        public calendar(): base()

        {

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Icalendar> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.calendar, global::Microsoft.Graph.Icalendar>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Icalendar> _query;

        global::System.Threading.Tasks.Task<global::Microsoft.Graph.Icalendar> global::Microsoft.Graph.IcalendarFetcher.ExecuteAsync()

        {

            var tsc = new global::System.Threading.Tasks.TaskCompletionSource<global::Microsoft.Graph.Icalendar>();

            tsc.SetResult(this);

            return tsc.Task;

        }

        global::Microsoft.Graph.IcalendarFetcher global::Microsoft.Graph.IcalendarFetcher.Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.Icalendar, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IcalendarFetcher) this;

        }

    }

    internal partial class calendarFetcher:Microsoft.OData.ProxyExtensions.RestShallowObjectFetcher, global::Microsoft.Graph.IcalendarFetcher

    {

        private global::Microsoft.Graph.eventCollection _eventsCollection;

        private global::Microsoft.Graph.eventCollection _calendarViewCollection;

        public global::Microsoft.Graph.IeventCollection events

        {

            get

            {

                if (this._eventsCollection == null)

                {

                    this._eventsCollection = new global::Microsoft.Graph.eventCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.Event>(GetPath("events")) : null,
                       Context,
                       this,
                       GetPath("events"));

                }

                

                return this._eventsCollection;

            }

        }

        public global::Microsoft.Graph.IeventCollection calendarView

        {

            get

            {

                if (this._calendarViewCollection == null)

                {

                    this._calendarViewCollection = new global::Microsoft.Graph.eventCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.Event>(GetPath("calendarView")) : null,
                       Context,
                       this,
                       GetPath("calendarView"));

                }

                

                return this._calendarViewCollection;

            }

        }

        public calendarFetcher(): base()

        {

        }

        public async global::System.Threading.Tasks.Task<global::Microsoft.Graph.Icalendar> ExecuteAsync()

        {

            return await EnsureQuery().ExecuteSingleAsync();

        }

        public global::Microsoft.Graph.IcalendarFetcher Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.Icalendar, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IcalendarFetcher) new global::Microsoft.Graph.calendarFetcher()

            {

                _query = this.EnsureQuery().Expand<TTarget>(navigationPropertyAccessor)

            }

            ;

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Icalendar> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.calendar, global::Microsoft.Graph.Icalendar>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Icalendar> _query;

    }

    internal partial class calendarCollection:Microsoft.OData.ProxyExtensions.QueryableSet<global::Microsoft.Graph.Icalendar>, global::Microsoft.Graph.IcalendarCollection

    {

        internal calendarCollection(global::Microsoft.OData.Client.DataServiceQuery inner,Microsoft.OData.ProxyExtensions.DataServiceContextWrapper context,object entity,string path): base(inner, context, entity as Microsoft.OData.ProxyExtensions.EntityBase, path)

        {

        }

        public global::Microsoft.Graph.IcalendarFetcher GetById(System.String id)

        {

            return this[id];

        }

        public global::System.Threading.Tasks.Task<Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.Icalendar>> ExecuteAsync()

        {

            return ExecuteAsyncInternal();

        }

        public global::System.Threading.Tasks.Task AddcalendarAsync(global::Microsoft.Graph.Icalendar item, System.Boolean deferSaveChanges = false)

        {

            if (Entity == null)

            {

                Context.AddObject(Path, item);

            }

            else

            {

                var lastSlash = Path.LastIndexOf('/');

                var shortPath = (lastSlash >= 0 && lastSlash < Path.Length - 1) ? Path.Substring(lastSlash + 1) : Path;

                Context.AddRelatedObject(Entity, shortPath, item);

            }

            if (!deferSaveChanges)

            {

                return Context.SaveChangesAsync();

            }

            else

            {

                var retVal = new global::System.Threading.Tasks.TaskCompletionSource<object>();

                retVal.SetResult(null);

                return retVal.Task;

            }

        }

        public global::Microsoft.Graph.IcalendarFetcher this[System.String id]

        {

            get

            {

                var path = GetPath<global::Microsoft.Graph.calendar>((i) => i.id == id);

                var fetcher = new global::Microsoft.Graph.calendarFetcher();

                fetcher.Initialize(Context, path);

                

                return fetcher;

            }

        }

    }

    internal partial class calendarCollection

    {

        public global::System.Threading.Tasks.Task<System.Int64> CountAsync()

        {

            return new DataServiceQuerySingle<long>(Context, Path + "/$count").GetValueAsync();

        }

    }

    internal partial class calendarFetcher

    {

    }

    public partial class calendar

    {

    }

    [global::Microsoft.OData.Client.Key("id")]

    public abstract partial class outlookItem:Microsoft.OData.ProxyExtensions.EntityBase, global::Microsoft.Graph.IoutlookItem, global::Microsoft.Graph.IoutlookItemFetcher

    {

        private System.Nullable<System.DateTimeOffset> _createdDateTime;

        private System.Nullable<System.DateTimeOffset> _lastModifiedDateTime;

        private System.String _changeKey;

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.String> _categories;

        private System.String _id;

        public System.Nullable<System.DateTimeOffset> createdDateTime

        {

            get

            {

                return _createdDateTime;

            }

            set

            {

                if (value != _createdDateTime)

                {

                    _createdDateTime = value;

                    OnPropertyChanged("createdDateTime");

                }

            }

        }

        public System.Nullable<System.DateTimeOffset> lastModifiedDateTime

        {

            get

            {

                return _lastModifiedDateTime;

            }

            set

            {

                if (value != _lastModifiedDateTime)

                {

                    _lastModifiedDateTime = value;

                    OnPropertyChanged("lastModifiedDateTime");

                }

            }

        }

        public System.String changeKey

        {

            get

            {

                return _changeKey;

            }

            set

            {

                if (value != _changeKey)

                {

                    _changeKey = value;

                    OnPropertyChanged("changeKey");

                }

            }

        }

        public System.Collections.Generic.IList<System.String> categories

        {

            get

            {

                if (this._categories == default(System.Collections.Generic.IList<System.String>))

                {

                    this._categories = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.String>();

                    this._categories.SetContainer(() => GetContainingEntity("categories"));

                }

                return this._categories;

            }

            set

            {

                categories.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        categories.Add(i);

                    }

                }

            }

        }

        public System.String id

        {

            get

            {

                return _id;

            }

            set

            {

                if (value != _id)

                {

                    _id = value;

                    OnPropertyChanged("id");

                }

            }

        }

        public outlookItem(): base()

        {

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IoutlookItem> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.outlookItem, global::Microsoft.Graph.IoutlookItem>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IoutlookItem> _query;

    }

    internal partial class outlookItemFetcher:Microsoft.OData.ProxyExtensions.RestShallowObjectFetcher, global::Microsoft.Graph.IoutlookItemFetcher

    {

        public outlookItemFetcher(): base()

        {

        }

    }

    internal partial class outlookItemCollection:Microsoft.OData.ProxyExtensions.QueryableSet<global::Microsoft.Graph.IoutlookItem>, global::Microsoft.Graph.IoutlookItemCollection

    {

        internal outlookItemCollection(global::Microsoft.OData.Client.DataServiceQuery inner,Microsoft.OData.ProxyExtensions.DataServiceContextWrapper context,object entity,string path): base(inner, context, entity as Microsoft.OData.ProxyExtensions.EntityBase, path)

        {

        }

        public global::Microsoft.Graph.IoutlookItemFetcher GetById(System.String id)

        {

            return this[id];

        }

        public global::System.Threading.Tasks.Task<Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.IoutlookItem>> ExecuteAsync()

        {

            return ExecuteAsyncInternal();

        }

        public global::System.Threading.Tasks.Task AddoutlookItemAsync(global::Microsoft.Graph.IoutlookItem item, System.Boolean deferSaveChanges = false)

        {

            if (Entity == null)

            {

                Context.AddObject(Path, item);

            }

            else

            {

                var lastSlash = Path.LastIndexOf('/');

                var shortPath = (lastSlash >= 0 && lastSlash < Path.Length - 1) ? Path.Substring(lastSlash + 1) : Path;

                Context.AddRelatedObject(Entity, shortPath, item);

            }

            if (!deferSaveChanges)

            {

                return Context.SaveChangesAsync();

            }

            else

            {

                var retVal = new global::System.Threading.Tasks.TaskCompletionSource<object>();

                retVal.SetResult(null);

                return retVal.Task;

            }

        }

        public global::Microsoft.Graph.IoutlookItemFetcher this[System.String id]

        {

            get

            {

                var path = GetPath<global::Microsoft.Graph.outlookItem>((i) => i.id == id);

                var fetcher = new global::Microsoft.Graph.outlookItemFetcher();

                fetcher.Initialize(Context, path);

                

                return fetcher;

            }

        }

    }

    internal partial class outlookItemCollection

    {

        public global::System.Threading.Tasks.Task<System.Int64> CountAsync()

        {

            return new DataServiceQuerySingle<long>(Context, Path + "/$count").GetValueAsync();

        }

    }

    internal partial class outlookItemFetcher

    {

        public global::Microsoft.Graph.IeventFetcher Toevent()

        {

            var derivedFetcher = new global::Microsoft.Graph.eventFetcher();

            derivedFetcher.Initialize(this.Context, this.GetPath((string) null));

            return (global::Microsoft.Graph.IeventFetcher) derivedFetcher;

        }

        public global::Microsoft.Graph.ImessageFetcher Tomessage()

        {

            var derivedFetcher = new global::Microsoft.Graph.messageFetcher();

            derivedFetcher.Initialize(this.Context, this.GetPath((string) null));

            return (global::Microsoft.Graph.ImessageFetcher) derivedFetcher;

        }

        public global::Microsoft.Graph.IcontactFetcher Tocontact()

        {

            var derivedFetcher = new global::Microsoft.Graph.contactFetcher();

            derivedFetcher.Initialize(this.Context, this.GetPath((string) null));

            return (global::Microsoft.Graph.IcontactFetcher) derivedFetcher;

        }

        public global::Microsoft.Graph.IpostFetcher Topost()

        {

            var derivedFetcher = new global::Microsoft.Graph.postFetcher();

            derivedFetcher.Initialize(this.Context, this.GetPath((string) null));

            return (global::Microsoft.Graph.IpostFetcher) derivedFetcher;

        }

        public global::Microsoft.Graph.IeventMessageFetcher ToeventMessage()

        {

            var derivedFetcher = new global::Microsoft.Graph.eventMessageFetcher();

            derivedFetcher.Initialize(this.Context, this.GetPath((string) null));

            return (global::Microsoft.Graph.IeventMessageFetcher) derivedFetcher;

        }

    }

    public partial class outlookItem

    {

        global::Microsoft.Graph.IeventFetcher global::Microsoft.Graph.IoutlookItemFetcher.Toevent()

        {

            return (global::Microsoft.Graph.IeventFetcher) this;

        }

        global::Microsoft.Graph.ImessageFetcher global::Microsoft.Graph.IoutlookItemFetcher.Tomessage()

        {

            return (global::Microsoft.Graph.ImessageFetcher) this;

        }

        global::Microsoft.Graph.IcontactFetcher global::Microsoft.Graph.IoutlookItemFetcher.Tocontact()

        {

            return (global::Microsoft.Graph.IcontactFetcher) this;

        }

        global::Microsoft.Graph.IpostFetcher global::Microsoft.Graph.IoutlookItemFetcher.Topost()

        {

            return (global::Microsoft.Graph.IpostFetcher) this;

        }

        global::Microsoft.Graph.IeventMessageFetcher global::Microsoft.Graph.IoutlookItemFetcher.ToeventMessage()

        {

            return (global::Microsoft.Graph.IeventMessageFetcher) this;

        }

    }

    [global::Microsoft.OData.Client.Key("id")]

    public partial class Event:global::Microsoft.Graph.outlookItem, global::Microsoft.Graph.Ievent, global::Microsoft.Graph.IeventFetcher

    {

        private global::Microsoft.Graph.calendar _calendar;

        private global::Microsoft.Graph.calendarFetcher _calendarFetcher;

        private global::Microsoft.Graph.eventCollection _instancesCollection;

        private global::Microsoft.Graph.extensionCollection _extensionsCollection;

        private global::Microsoft.Graph.attachmentCollection _attachmentsCollection;

        private System.String _originalStartTimeZone;

        private System.String _originalEndTimeZone;

        private global::Microsoft.Graph.responseStatus _responseStatus;

        private System.String _iCalUId;

        private System.Nullable<System.Int32> _reminderMinutesBeforeStart;

        private System.Nullable<System.Boolean> _isReminderOn;

        private System.Nullable<System.Boolean> _hasAttachments;

        private System.String _subject;

        private global::Microsoft.Graph.itemBody _body;

        private System.String _bodyPreview;

        private global::Microsoft.Graph.importance _importance;

        private global::Microsoft.Graph.sensitivity _sensitivity;

        private global::Microsoft.Graph.dateTimeTimeZone _start;

        private System.Nullable<System.DateTimeOffset> _originalStart;

        private global::Microsoft.Graph.dateTimeTimeZone _end;

        private global::Microsoft.Graph.location _location;

        private System.Nullable<System.Boolean> _isAllDay;

        private System.Nullable<System.Boolean> _isCancelled;

        private System.Nullable<System.Boolean> _isOrganizer;

        private global::Microsoft.Graph.patternedRecurrence _recurrence;

        private System.Nullable<System.Boolean> _responseRequested;

        private System.String _seriesMasterId;

        private global::Microsoft.Graph.freeBusyStatus _showAs;

        private global::Microsoft.Graph.eventType _type;

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.attendee> _attendees;

        private global::Microsoft.Graph.recipient _organizer;

        private System.String _webLink;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.Event> _instancesConcrete;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.extension> _extensionsConcrete;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.attachment> _attachmentsConcrete;

        public System.String originalStartTimeZone

        {

            get

            {

                return _originalStartTimeZone;

            }

            set

            {

                if (value != _originalStartTimeZone)

                {

                    _originalStartTimeZone = value;

                    OnPropertyChanged("originalStartTimeZone");

                }

            }

        }

        public System.String originalEndTimeZone

        {

            get

            {

                return _originalEndTimeZone;

            }

            set

            {

                if (value != _originalEndTimeZone)

                {

                    _originalEndTimeZone = value;

                    OnPropertyChanged("originalEndTimeZone");

                }

            }

        }

        public global::Microsoft.Graph.responseStatus responseStatus

        {

            get

            {

                return _responseStatus;

            }

            set

            {

                if (value != _responseStatus)

                {

                    _responseStatus = value;

                    OnPropertyChanged("responseStatus");

                }

            }

        }

        public System.String iCalUId

        {

            get

            {

                return _iCalUId;

            }

            set

            {

                if (value != _iCalUId)

                {

                    _iCalUId = value;

                    OnPropertyChanged("iCalUId");

                }

            }

        }

        public System.Nullable<System.Int32> reminderMinutesBeforeStart

        {

            get

            {

                return _reminderMinutesBeforeStart;

            }

            set

            {

                if (value != _reminderMinutesBeforeStart)

                {

                    _reminderMinutesBeforeStart = value;

                    OnPropertyChanged("reminderMinutesBeforeStart");

                }

            }

        }

        public System.Nullable<System.Boolean> isReminderOn

        {

            get

            {

                return _isReminderOn;

            }

            set

            {

                if (value != _isReminderOn)

                {

                    _isReminderOn = value;

                    OnPropertyChanged("isReminderOn");

                }

            }

        }

        public System.Nullable<System.Boolean> hasAttachments

        {

            get

            {

                return _hasAttachments;

            }

            set

            {

                if (value != _hasAttachments)

                {

                    _hasAttachments = value;

                    OnPropertyChanged("hasAttachments");

                }

            }

        }

        public System.String subject

        {

            get

            {

                return _subject;

            }

            set

            {

                if (value != _subject)

                {

                    _subject = value;

                    OnPropertyChanged("subject");

                }

            }

        }

        public global::Microsoft.Graph.itemBody body

        {

            get

            {

                return _body;

            }

            set

            {

                if (value != _body)

                {

                    _body = value;

                    OnPropertyChanged("body");

                }

            }

        }

        public System.String bodyPreview

        {

            get

            {

                return _bodyPreview;

            }

            set

            {

                if (value != _bodyPreview)

                {

                    _bodyPreview = value;

                    OnPropertyChanged("bodyPreview");

                }

            }

        }

        public global::Microsoft.Graph.importance importance

        {

            get

            {

                return _importance;

            }

            set

            {

                if (value != _importance)

                {

                    _importance = value;

                    OnPropertyChanged("importance");

                }

            }

        }

        public global::Microsoft.Graph.sensitivity sensitivity

        {

            get

            {

                return _sensitivity;

            }

            set

            {

                if (value != _sensitivity)

                {

                    _sensitivity = value;

                    OnPropertyChanged("sensitivity");

                }

            }

        }

        public global::Microsoft.Graph.dateTimeTimeZone start

        {

            get

            {

                return _start;

            }

            set

            {

                if (value != _start)

                {

                    _start = value;

                    OnPropertyChanged("start");

                }

            }

        }

        public System.Nullable<System.DateTimeOffset> originalStart

        {

            get

            {

                return _originalStart;

            }

            set

            {

                if (value != _originalStart)

                {

                    _originalStart = value;

                    OnPropertyChanged("originalStart");

                }

            }

        }

        public global::Microsoft.Graph.dateTimeTimeZone end

        {

            get

            {

                return _end;

            }

            set

            {

                if (value != _end)

                {

                    _end = value;

                    OnPropertyChanged("end");

                }

            }

        }

        public global::Microsoft.Graph.location location

        {

            get

            {

                return _location;

            }

            set

            {

                if (value != _location)

                {

                    _location = value;

                    OnPropertyChanged("location");

                }

            }

        }

        public System.Nullable<System.Boolean> isAllDay

        {

            get

            {

                return _isAllDay;

            }

            set

            {

                if (value != _isAllDay)

                {

                    _isAllDay = value;

                    OnPropertyChanged("isAllDay");

                }

            }

        }

        public System.Nullable<System.Boolean> isCancelled

        {

            get

            {

                return _isCancelled;

            }

            set

            {

                if (value != _isCancelled)

                {

                    _isCancelled = value;

                    OnPropertyChanged("isCancelled");

                }

            }

        }

        public System.Nullable<System.Boolean> isOrganizer

        {

            get

            {

                return _isOrganizer;

            }

            set

            {

                if (value != _isOrganizer)

                {

                    _isOrganizer = value;

                    OnPropertyChanged("isOrganizer");

                }

            }

        }

        public global::Microsoft.Graph.patternedRecurrence recurrence

        {

            get

            {

                return _recurrence;

            }

            set

            {

                if (value != _recurrence)

                {

                    _recurrence = value;

                    OnPropertyChanged("recurrence");

                }

            }

        }

        public System.Nullable<System.Boolean> responseRequested

        {

            get

            {

                return _responseRequested;

            }

            set

            {

                if (value != _responseRequested)

                {

                    _responseRequested = value;

                    OnPropertyChanged("responseRequested");

                }

            }

        }

        public System.String seriesMasterId

        {

            get

            {

                return _seriesMasterId;

            }

            set

            {

                if (value != _seriesMasterId)

                {

                    _seriesMasterId = value;

                    OnPropertyChanged("seriesMasterId");

                }

            }

        }

        public global::Microsoft.Graph.freeBusyStatus showAs

        {

            get

            {

                return _showAs;

            }

            set

            {

                if (value != _showAs)

                {

                    _showAs = value;

                    OnPropertyChanged("showAs");

                }

            }

        }

        public global::Microsoft.Graph.eventType type

        {

            get

            {

                return _type;

            }

            set

            {

                if (value != _type)

                {

                    _type = value;

                    OnPropertyChanged("type");

                }

            }

        }

        public System.Collections.Generic.IList<global::Microsoft.Graph.attendee> attendees

        {

            get

            {

                if (this._attendees == default(System.Collections.Generic.IList<global::Microsoft.Graph.attendee>))

                {

                    this._attendees = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.attendee>();

                    this._attendees.SetContainer(() => GetContainingEntity("attendees"));

                }

                return this._attendees;

            }

            set

            {

                attendees.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        attendees.Add(i);

                    }

                }

            }

        }

        public global::Microsoft.Graph.recipient organizer

        {

            get

            {

                return _organizer;

            }

            set

            {

                if (value != _organizer)

                {

                    _organizer = value;

                    OnPropertyChanged("organizer");

                }

            }

        }

        public System.String webLink

        {

            get

            {

                return _webLink;

            }

            set

            {

                if (value != _webLink)

                {

                    _webLink = value;

                    OnPropertyChanged("webLink");

                }

            }

        }

        global::Microsoft.Graph.Icalendar global::Microsoft.Graph.Ievent.calendar

        {

            get

            {

                return this._calendar;

            }

            set

            {

                if (this.calendar != value)

                {

                    this.calendar = (global::Microsoft.Graph.calendar)value;

                }

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.Ievent> global::Microsoft.Graph.Ievent.instances

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.Ievent, global::Microsoft.Graph.Event>(Context, (DataServiceCollection<global::Microsoft.Graph.Event>) instances);

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.Iextension> global::Microsoft.Graph.Ievent.extensions

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.Iextension, global::Microsoft.Graph.extension>(Context, (DataServiceCollection<global::Microsoft.Graph.extension>) extensions);

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.Iattachment> global::Microsoft.Graph.Ievent.attachments

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.Iattachment, global::Microsoft.Graph.attachment>(Context, (DataServiceCollection<global::Microsoft.Graph.attachment>) attachments);

            }

        }

        public global::Microsoft.Graph.calendar calendar

        {

            get

            {

                return this._calendar;

            }

            set

            {

                if (this._calendar != value)

                {

                    this._calendar = value;

                    if (Context != null && Context.GetEntityDescriptor(this) != null && (value == null || Context.GetEntityDescriptor(value) != null))

                    {

                        Context.SetLink(this, "calendar", value);

                    }

                }

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.Event> instances

        {

            get

            {

                if (this._instancesConcrete == null)

                {

                    this._instancesConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.Event>();

                    this._instancesConcrete.SetContainer(() => GetContainingEntity("instances"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.Event>)this._instancesConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                instances.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        instances.Add(i);

                    }

                }

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.extension> extensions

        {

            get

            {

                if (this._extensionsConcrete == null)

                {

                    this._extensionsConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.extension>();

                    this._extensionsConcrete.SetContainer(() => GetContainingEntity("extensions"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.extension>)this._extensionsConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                extensions.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        extensions.Add(i);

                    }

                }

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.attachment> attachments

        {

            get

            {

                if (this._attachmentsConcrete == null)

                {

                    this._attachmentsConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.attachment>();

                    this._attachmentsConcrete.SetContainer(() => GetContainingEntity("attachments"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.attachment>)this._attachmentsConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                attachments.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        attachments.Add(i);

                    }

                }

            }

        }

        global::Microsoft.Graph.IcalendarFetcher global::Microsoft.Graph.IeventFetcher.calendar

        {

            get

            {

                if (this._calendarFetcher == null)

                {

                    this._calendarFetcher = new global::Microsoft.Graph.calendarFetcher();

                    this._calendarFetcher.Initialize(this.Context, GetPath("calendar"));

                }

                

                return this._calendarFetcher;

            }

        }

        global::Microsoft.Graph.IeventCollection global::Microsoft.Graph.IeventFetcher.instances

        {

            get

            {

                if (this._instancesCollection == null)

                {

                    this._instancesCollection = new global::Microsoft.Graph.eventCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.Event>(GetPath("instances")) : null,
                       Context,
                       this,
                       GetPath("instances"));

                }

                

                return this._instancesCollection;

            }

        }

        global::Microsoft.Graph.IextensionCollection global::Microsoft.Graph.IeventFetcher.extensions

        {

            get

            {

                if (this._extensionsCollection == null)

                {

                    this._extensionsCollection = new global::Microsoft.Graph.extensionCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.extension>(GetPath("extensions")) : null,
                       Context,
                       this,
                       GetPath("extensions"));

                }

                

                return this._extensionsCollection;

            }

        }

        global::Microsoft.Graph.IattachmentCollection global::Microsoft.Graph.IeventFetcher.attachments

        {

            get

            {

                if (this._attachmentsCollection == null)

                {

                    this._attachmentsCollection = new global::Microsoft.Graph.attachmentCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.attachment>(GetPath("attachments")) : null,
                       Context,
                       this,
                       GetPath("attachments"));

                }

                

                return this._attachmentsCollection;

            }

        }

        public Event()

        {

        }

        public async System.Threading.Tasks.Task acceptAsync(System.String Comment, System.Nullable<System.Boolean> SendResponse)

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.accept");

            await this.Context.ExecuteAsync(requestUri, "POST", new OperationParameter[2]

            {

                new BodyOperationParameter("Comment", (object) Comment),

                new BodyOperationParameter("SendResponse", (object) SendResponse),

            }

            );

        }

        public async System.Threading.Tasks.Task declineAsync(System.String Comment, System.Nullable<System.Boolean> SendResponse)

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.decline");

            await this.Context.ExecuteAsync(requestUri, "POST", new OperationParameter[2]

            {

                new BodyOperationParameter("Comment", (object) Comment),

                new BodyOperationParameter("SendResponse", (object) SendResponse),

            }

            );

        }

        public async System.Threading.Tasks.Task tentativelyAcceptAsync(System.String Comment, System.Nullable<System.Boolean> SendResponse)

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.tentativelyAccept");

            await this.Context.ExecuteAsync(requestUri, "POST", new OperationParameter[2]

            {

                new BodyOperationParameter("Comment", (object) Comment),

                new BodyOperationParameter("SendResponse", (object) SendResponse),

            }

            );

        }

        public async System.Threading.Tasks.Task snoozeReminderAsync(global::Microsoft.Graph.dateTimeTimeZone NewReminderTime)

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.snoozeReminder");

            await this.Context.ExecuteAsync(requestUri, "POST", new OperationParameter[1]

            {

                new BodyOperationParameter("NewReminderTime", (object) NewReminderTime),

            }

            );

        }

        public async System.Threading.Tasks.Task dismissReminderAsync()

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.dismissReminder");

            await this.Context.ExecuteAsync(requestUri, "POST", new OperationParameter[0]

            {

            }

            );

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Ievent> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.Event, global::Microsoft.Graph.Ievent>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Ievent> _query;

        global::System.Threading.Tasks.Task<global::Microsoft.Graph.Ievent> global::Microsoft.Graph.IeventFetcher.ExecuteAsync()

        {

            var tsc = new global::System.Threading.Tasks.TaskCompletionSource<global::Microsoft.Graph.Ievent>();

            tsc.SetResult(this);

            return tsc.Task;

        }

        global::Microsoft.Graph.IeventFetcher global::Microsoft.Graph.IeventFetcher.Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.Ievent, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IeventFetcher) this;

        }

    }

    internal partial class eventFetcher:global::Microsoft.Graph.outlookItemFetcher, global::Microsoft.Graph.IeventFetcher

    {

        private global::Microsoft.Graph.calendarFetcher _calendarFetcher;

        private global::Microsoft.Graph.eventCollection _instancesCollection;

        private global::Microsoft.Graph.extensionCollection _extensionsCollection;

        private global::Microsoft.Graph.attachmentCollection _attachmentsCollection;

        public global::Microsoft.Graph.IcalendarFetcher calendar

        {

            get

            {

                if (this._calendarFetcher == null)

                {

                    this._calendarFetcher = new global::Microsoft.Graph.calendarFetcher();

                    this._calendarFetcher.Initialize(this.Context, GetPath("calendar"));

                }

                

                return this._calendarFetcher;

            }

        }

        public global::Microsoft.Graph.IeventCollection instances

        {

            get

            {

                if (this._instancesCollection == null)

                {

                    this._instancesCollection = new global::Microsoft.Graph.eventCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.Event>(GetPath("instances")) : null,
                       Context,
                       this,
                       GetPath("instances"));

                }

                

                return this._instancesCollection;

            }

        }

        public global::Microsoft.Graph.IextensionCollection extensions

        {

            get

            {

                if (this._extensionsCollection == null)

                {

                    this._extensionsCollection = new global::Microsoft.Graph.extensionCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.extension>(GetPath("extensions")) : null,
                       Context,
                       this,
                       GetPath("extensions"));

                }

                

                return this._extensionsCollection;

            }

        }

        public global::Microsoft.Graph.IattachmentCollection attachments

        {

            get

            {

                if (this._attachmentsCollection == null)

                {

                    this._attachmentsCollection = new global::Microsoft.Graph.attachmentCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.attachment>(GetPath("attachments")) : null,
                       Context,
                       this,
                       GetPath("attachments"));

                }

                

                return this._attachmentsCollection;

            }

        }

        public eventFetcher()

        {

        }

        public async System.Threading.Tasks.Task acceptAsync(System.String Comment, System.Nullable<System.Boolean> SendResponse)

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.accept");

            await this.Context.ExecuteAsync(requestUri, "POST", new OperationParameter[2]

            {

                new BodyOperationParameter("Comment", (object) Comment),

                new BodyOperationParameter("SendResponse", (object) SendResponse),

            }

            );

        }

        public async System.Threading.Tasks.Task declineAsync(System.String Comment, System.Nullable<System.Boolean> SendResponse)

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.decline");

            await this.Context.ExecuteAsync(requestUri, "POST", new OperationParameter[2]

            {

                new BodyOperationParameter("Comment", (object) Comment),

                new BodyOperationParameter("SendResponse", (object) SendResponse),

            }

            );

        }

        public async System.Threading.Tasks.Task tentativelyAcceptAsync(System.String Comment, System.Nullable<System.Boolean> SendResponse)

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.tentativelyAccept");

            await this.Context.ExecuteAsync(requestUri, "POST", new OperationParameter[2]

            {

                new BodyOperationParameter("Comment", (object) Comment),

                new BodyOperationParameter("SendResponse", (object) SendResponse),

            }

            );

        }

        public async System.Threading.Tasks.Task snoozeReminderAsync(global::Microsoft.Graph.dateTimeTimeZone NewReminderTime)

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.snoozeReminder");

            await this.Context.ExecuteAsync(requestUri, "POST", new OperationParameter[1]

            {

                new BodyOperationParameter("NewReminderTime", (object) NewReminderTime),

            }

            );

        }

        public async System.Threading.Tasks.Task dismissReminderAsync()

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.dismissReminder");

            await this.Context.ExecuteAsync(requestUri, "POST", new OperationParameter[0]

            {

            }

            );

        }

        public async global::System.Threading.Tasks.Task<global::Microsoft.Graph.Ievent> ExecuteAsync()

        {

            return await EnsureQuery().ExecuteSingleAsync();

        }

        public global::Microsoft.Graph.IeventFetcher Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.Ievent, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IeventFetcher) new global::Microsoft.Graph.eventFetcher()

            {

                _query = this.EnsureQuery().Expand<TTarget>(navigationPropertyAccessor)

            }

            ;

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Ievent> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.Event, global::Microsoft.Graph.Ievent>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Ievent> _query;

    }

    internal partial class eventCollection:Microsoft.OData.ProxyExtensions.QueryableSet<global::Microsoft.Graph.Ievent>, global::Microsoft.Graph.IeventCollection

    {

        internal eventCollection(global::Microsoft.OData.Client.DataServiceQuery inner,Microsoft.OData.ProxyExtensions.DataServiceContextWrapper context,object entity,string path): base(inner, context, entity as Microsoft.OData.ProxyExtensions.EntityBase, path)

        {

        }

        public global::Microsoft.Graph.IeventFetcher GetById(System.String id)

        {

            return this[id];

        }

        public global::System.Threading.Tasks.Task<Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.Ievent>> ExecuteAsync()

        {

            return ExecuteAsyncInternal();

        }

        public global::System.Threading.Tasks.Task AddeventAsync(global::Microsoft.Graph.Ievent item, System.Boolean deferSaveChanges = false)

        {

            if (Entity == null)

            {

                Context.AddObject(Path, item);

            }

            else

            {

                var lastSlash = Path.LastIndexOf('/');

                var shortPath = (lastSlash >= 0 && lastSlash < Path.Length - 1) ? Path.Substring(lastSlash + 1) : Path;

                Context.AddRelatedObject(Entity, shortPath, item);

            }

            if (!deferSaveChanges)

            {

                return Context.SaveChangesAsync();

            }

            else

            {

                var retVal = new global::System.Threading.Tasks.TaskCompletionSource<object>();

                retVal.SetResult(null);

                return retVal.Task;

            }

        }

        public global::Microsoft.Graph.IeventFetcher this[System.String id]

        {

            get

            {

                var path = GetPath<global::Microsoft.Graph.Event>((i) => i.id == id);

                var fetcher = new global::Microsoft.Graph.eventFetcher();

                fetcher.Initialize(Context, path);

                

                return fetcher;

            }

        }

    }

    internal partial class eventCollection

    {

        public global::System.Threading.Tasks.Task<System.Int64> CountAsync()

        {

            return new DataServiceQuerySingle<long>(Context, Path + "/$count").GetValueAsync();

        }

    }

    [global::Microsoft.OData.Client.Key("id")]

    public partial class conversation:Microsoft.OData.ProxyExtensions.EntityBase, global::Microsoft.Graph.Iconversation, global::Microsoft.Graph.IconversationFetcher

    {

        private global::Microsoft.Graph.conversationThreadCollection _threadsCollection;

        private System.String _topic;

        private System.Boolean _hasAttachments;

        private System.DateTimeOffset _lastDeliveredDateTime;

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.String> _uniqueSenders;

        private System.String _preview;

        private System.String _id;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.conversationThread> _threadsConcrete;

        public System.String topic

        {

            get

            {

                return _topic;

            }

            set

            {

                if (value != _topic)

                {

                    _topic = value;

                    OnPropertyChanged("topic");

                }

            }

        }

        public System.Boolean hasAttachments

        {

            get

            {

                return _hasAttachments;

            }

            set

            {

                if (value != _hasAttachments)

                {

                    _hasAttachments = value;

                    OnPropertyChanged("hasAttachments");

                }

            }

        }

        public System.DateTimeOffset lastDeliveredDateTime

        {

            get

            {

                return _lastDeliveredDateTime;

            }

            set

            {

                if (value != _lastDeliveredDateTime)

                {

                    _lastDeliveredDateTime = value;

                    OnPropertyChanged("lastDeliveredDateTime");

                }

            }

        }

        public System.Collections.Generic.IList<System.String> uniqueSenders

        {

            get

            {

                if (this._uniqueSenders == default(System.Collections.Generic.IList<System.String>))

                {

                    this._uniqueSenders = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.String>();

                    this._uniqueSenders.SetContainer(() => GetContainingEntity("uniqueSenders"));

                }

                return this._uniqueSenders;

            }

            set

            {

                uniqueSenders.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        uniqueSenders.Add(i);

                    }

                }

            }

        }

        public System.String preview

        {

            get

            {

                return _preview;

            }

            set

            {

                if (value != _preview)

                {

                    _preview = value;

                    OnPropertyChanged("preview");

                }

            }

        }

        public System.String id

        {

            get

            {

                return _id;

            }

            set

            {

                if (value != _id)

                {

                    _id = value;

                    OnPropertyChanged("id");

                }

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.IconversationThread> global::Microsoft.Graph.Iconversation.threads

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.IconversationThread, global::Microsoft.Graph.conversationThread>(Context, (DataServiceCollection<global::Microsoft.Graph.conversationThread>) threads);

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.conversationThread> threads

        {

            get

            {

                if (this._threadsConcrete == null)

                {

                    this._threadsConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.conversationThread>();

                    this._threadsConcrete.SetContainer(() => GetContainingEntity("threads"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.conversationThread>)this._threadsConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                threads.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        threads.Add(i);

                    }

                }

            }

        }

        global::Microsoft.Graph.IconversationThreadCollection global::Microsoft.Graph.IconversationFetcher.threads

        {

            get

            {

                if (this._threadsCollection == null)

                {

                    this._threadsCollection = new global::Microsoft.Graph.conversationThreadCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.conversationThread>(GetPath("threads")) : null,
                       Context,
                       this,
                       GetPath("threads"));

                }

                

                return this._threadsCollection;

            }

        }

        public conversation(): base()

        {

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Iconversation> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.conversation, global::Microsoft.Graph.Iconversation>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Iconversation> _query;

        global::System.Threading.Tasks.Task<global::Microsoft.Graph.Iconversation> global::Microsoft.Graph.IconversationFetcher.ExecuteAsync()

        {

            var tsc = new global::System.Threading.Tasks.TaskCompletionSource<global::Microsoft.Graph.Iconversation>();

            tsc.SetResult(this);

            return tsc.Task;

        }

        global::Microsoft.Graph.IconversationFetcher global::Microsoft.Graph.IconversationFetcher.Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.Iconversation, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IconversationFetcher) this;

        }

    }

    internal partial class conversationFetcher:Microsoft.OData.ProxyExtensions.RestShallowObjectFetcher, global::Microsoft.Graph.IconversationFetcher

    {

        private global::Microsoft.Graph.conversationThreadCollection _threadsCollection;

        public global::Microsoft.Graph.IconversationThreadCollection threads

        {

            get

            {

                if (this._threadsCollection == null)

                {

                    this._threadsCollection = new global::Microsoft.Graph.conversationThreadCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.conversationThread>(GetPath("threads")) : null,
                       Context,
                       this,
                       GetPath("threads"));

                }

                

                return this._threadsCollection;

            }

        }

        public conversationFetcher(): base()

        {

        }

        public async global::System.Threading.Tasks.Task<global::Microsoft.Graph.Iconversation> ExecuteAsync()

        {

            return await EnsureQuery().ExecuteSingleAsync();

        }

        public global::Microsoft.Graph.IconversationFetcher Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.Iconversation, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IconversationFetcher) new global::Microsoft.Graph.conversationFetcher()

            {

                _query = this.EnsureQuery().Expand<TTarget>(navigationPropertyAccessor)

            }

            ;

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Iconversation> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.conversation, global::Microsoft.Graph.Iconversation>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Iconversation> _query;

    }

    internal partial class conversationCollection:Microsoft.OData.ProxyExtensions.QueryableSet<global::Microsoft.Graph.Iconversation>, global::Microsoft.Graph.IconversationCollection

    {

        internal conversationCollection(global::Microsoft.OData.Client.DataServiceQuery inner,Microsoft.OData.ProxyExtensions.DataServiceContextWrapper context,object entity,string path): base(inner, context, entity as Microsoft.OData.ProxyExtensions.EntityBase, path)

        {

        }

        public global::Microsoft.Graph.IconversationFetcher GetById(System.String id)

        {

            return this[id];

        }

        public global::System.Threading.Tasks.Task<Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.Iconversation>> ExecuteAsync()

        {

            return ExecuteAsyncInternal();

        }

        public global::System.Threading.Tasks.Task AddconversationAsync(global::Microsoft.Graph.Iconversation item, System.Boolean deferSaveChanges = false)

        {

            if (Entity == null)

            {

                Context.AddObject(Path, item);

            }

            else

            {

                var lastSlash = Path.LastIndexOf('/');

                var shortPath = (lastSlash >= 0 && lastSlash < Path.Length - 1) ? Path.Substring(lastSlash + 1) : Path;

                Context.AddRelatedObject(Entity, shortPath, item);

            }

            if (!deferSaveChanges)

            {

                return Context.SaveChangesAsync();

            }

            else

            {

                var retVal = new global::System.Threading.Tasks.TaskCompletionSource<object>();

                retVal.SetResult(null);

                return retVal.Task;

            }

        }

        public global::Microsoft.Graph.IconversationFetcher this[System.String id]

        {

            get

            {

                var path = GetPath<global::Microsoft.Graph.conversation>((i) => i.id == id);

                var fetcher = new global::Microsoft.Graph.conversationFetcher();

                fetcher.Initialize(Context, path);

                

                return fetcher;

            }

        }

    }

    internal partial class conversationCollection

    {

        public global::System.Threading.Tasks.Task<System.Int64> CountAsync()

        {

            return new DataServiceQuerySingle<long>(Context, Path + "/$count").GetValueAsync();

        }

    }

    internal partial class conversationFetcher

    {

    }

    public partial class conversation

    {

    }

    [global::Microsoft.OData.Client.Key("id")]

    public partial class profilePhoto:Microsoft.OData.ProxyExtensions.EntityBase, global::Microsoft.Graph.IprofilePhoto, global::Microsoft.Graph.IprofilePhotoFetcher

    {

        private System.Nullable<System.Int32> _height;

        private System.Nullable<System.Int32> _width;

        private System.String _id;

        public System.Nullable<System.Int32> height

        {

            get

            {

                return _height;

            }

            set

            {

                if (value != _height)

                {

                    _height = value;

                    OnPropertyChanged("height");

                }

            }

        }

        public System.Nullable<System.Int32> width

        {

            get

            {

                return _width;

            }

            set

            {

                if (value != _width)

                {

                    _width = value;

                    OnPropertyChanged("width");

                }

            }

        }

        public System.String id

        {

            get

            {

                return _id;

            }

            set

            {

                if (value != _id)

                {

                    _id = value;

                    OnPropertyChanged("id");

                }

            }

        }

        public profilePhoto(): base()

        {

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IprofilePhoto> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.profilePhoto, global::Microsoft.Graph.IprofilePhoto>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IprofilePhoto> _query;

        global::System.Threading.Tasks.Task<global::Microsoft.Graph.IprofilePhoto> global::Microsoft.Graph.IprofilePhotoFetcher.ExecuteAsync()

        {

            var tsc = new global::System.Threading.Tasks.TaskCompletionSource<global::Microsoft.Graph.IprofilePhoto>();

            tsc.SetResult(this);

            return tsc.Task;

        }

        global::Microsoft.Graph.IprofilePhotoFetcher global::Microsoft.Graph.IprofilePhotoFetcher.Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.IprofilePhoto, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IprofilePhotoFetcher) this;

        }

    }

    internal partial class profilePhotoFetcher:Microsoft.OData.ProxyExtensions.RestShallowObjectFetcher, global::Microsoft.Graph.IprofilePhotoFetcher

    {

        public profilePhotoFetcher(): base()

        {

        }

        public async global::System.Threading.Tasks.Task<global::Microsoft.Graph.IprofilePhoto> ExecuteAsync()

        {

            return await EnsureQuery().ExecuteSingleAsync();

        }

        public global::Microsoft.Graph.IprofilePhotoFetcher Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.IprofilePhoto, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IprofilePhotoFetcher) new global::Microsoft.Graph.profilePhotoFetcher()

            {

                _query = this.EnsureQuery().Expand<TTarget>(navigationPropertyAccessor)

            }

            ;

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IprofilePhoto> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.profilePhoto, global::Microsoft.Graph.IprofilePhoto>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IprofilePhoto> _query;

    }

    internal partial class profilePhotoCollection:Microsoft.OData.ProxyExtensions.QueryableSet<global::Microsoft.Graph.IprofilePhoto>, global::Microsoft.Graph.IprofilePhotoCollection

    {

        internal profilePhotoCollection(global::Microsoft.OData.Client.DataServiceQuery inner,Microsoft.OData.ProxyExtensions.DataServiceContextWrapper context,object entity,string path): base(inner, context, entity as Microsoft.OData.ProxyExtensions.EntityBase, path)

        {

        }

        public global::Microsoft.Graph.IprofilePhotoFetcher GetById(System.String id)

        {

            return this[id];

        }

        public global::System.Threading.Tasks.Task<Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.IprofilePhoto>> ExecuteAsync()

        {

            return ExecuteAsyncInternal();

        }

        public global::System.Threading.Tasks.Task AddprofilePhotoAsync(global::Microsoft.Graph.IprofilePhoto item, System.IO.Stream stream, System.String contentType, System.Boolean deferSaveChanges = false, System.Boolean closeStream = false)

        {

            if (Entity == null)

            {

                Context.AddObject(Path, item);

            }

            else

            {

                var lastSlash = Path.LastIndexOf('/');

                var shortPath = (lastSlash >= 0 && lastSlash < Path.Length - 1) ? Path.Substring(lastSlash + 1) : Path;

                Context.AddRelatedObject(Entity, shortPath, item);

            }

            Context.SetSaveStream(item, stream, closeStream, new DataServiceRequestArgs()

            {

                ContentType = contentType

            });

            if (!deferSaveChanges)

            {

                return Context.SaveChangesAsync();

            }

            else

            {

                var retVal = new global::System.Threading.Tasks.TaskCompletionSource<object>();

                retVal.SetResult(null);

                return retVal.Task;

            }

        }

        public global::Microsoft.Graph.IprofilePhotoFetcher this[System.String id]

        {

            get

            {

                var path = GetPath<global::Microsoft.Graph.profilePhoto>((i) => i.id == id);

                var fetcher = new global::Microsoft.Graph.profilePhotoFetcher();

                fetcher.Initialize(Context, path);

                

                return fetcher;

            }

        }

    }

    internal partial class profilePhotoCollection

    {

        public global::System.Threading.Tasks.Task<System.Int64> CountAsync()

        {

            return new DataServiceQuerySingle<long>(Context, Path + "/$count").GetValueAsync();

        }

    }

    internal partial class profilePhotoFetcher

    {

    }

    public partial class profilePhoto

    {

    }

    [global::Microsoft.OData.Client.Key("id")]

    public partial class drive:Microsoft.OData.ProxyExtensions.EntityBase, global::Microsoft.Graph.Idrive, global::Microsoft.Graph.IdriveFetcher

    {

        private global::Microsoft.Graph.driveItem _root;

        private global::Microsoft.Graph.driveItemFetcher _rootFetcher;

        private global::Microsoft.Graph.driveItemCollection _itemsCollection;

        private global::Microsoft.Graph.driveItemCollection _sharedCollection;

        private global::Microsoft.Graph.driveItemCollection _specialCollection;

        private System.String _id;

        private System.String _driveType;

        private global::Microsoft.Graph.identitySet _owner;

        private global::Microsoft.Graph.quota _quota;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.driveItem> _itemsConcrete;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.driveItem> _sharedConcrete;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.driveItem> _specialConcrete;

        public System.String id

        {

            get

            {

                return _id;

            }

            set

            {

                if (value != _id)

                {

                    _id = value;

                    OnPropertyChanged("id");

                }

            }

        }

        public System.String driveType

        {

            get

            {

                return _driveType;

            }

            set

            {

                if (value != _driveType)

                {

                    _driveType = value;

                    OnPropertyChanged("driveType");

                }

            }

        }

        public global::Microsoft.Graph.identitySet owner

        {

            get

            {

                return _owner;

            }

            set

            {

                if (value != _owner)

                {

                    _owner = value;

                    OnPropertyChanged("owner");

                }

            }

        }

        public global::Microsoft.Graph.quota quota

        {

            get

            {

                return _quota;

            }

            set

            {

                if (value != _quota)

                {

                    _quota = value;

                    OnPropertyChanged("quota");

                }

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.IdriveItem> global::Microsoft.Graph.Idrive.items

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.IdriveItem, global::Microsoft.Graph.driveItem>(Context, (DataServiceCollection<global::Microsoft.Graph.driveItem>) items);

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.IdriveItem> global::Microsoft.Graph.Idrive.shared

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.IdriveItem, global::Microsoft.Graph.driveItem>(Context, (DataServiceCollection<global::Microsoft.Graph.driveItem>) shared);

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.IdriveItem> global::Microsoft.Graph.Idrive.special

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.IdriveItem, global::Microsoft.Graph.driveItem>(Context, (DataServiceCollection<global::Microsoft.Graph.driveItem>) special);

            }

        }

        global::Microsoft.Graph.IdriveItem global::Microsoft.Graph.Idrive.root

        {

            get

            {

                return this._root;

            }

            set

            {

                if (this.root != value)

                {

                    this.root = (global::Microsoft.Graph.driveItem)value;

                }

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.driveItem> items

        {

            get

            {

                if (this._itemsConcrete == null)

                {

                    this._itemsConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.driveItem>();

                    this._itemsConcrete.SetContainer(() => GetContainingEntity("items"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.driveItem>)this._itemsConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                items.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        items.Add(i);

                    }

                }

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.driveItem> shared

        {

            get

            {

                if (this._sharedConcrete == null)

                {

                    this._sharedConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.driveItem>();

                    this._sharedConcrete.SetContainer(() => GetContainingEntity("shared"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.driveItem>)this._sharedConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                shared.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        shared.Add(i);

                    }

                }

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.driveItem> special

        {

            get

            {

                if (this._specialConcrete == null)

                {

                    this._specialConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.driveItem>();

                    this._specialConcrete.SetContainer(() => GetContainingEntity("special"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.driveItem>)this._specialConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                special.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        special.Add(i);

                    }

                }

            }

        }

        public global::Microsoft.Graph.driveItem root

        {

            get

            {

                return this._root;

            }

            set

            {

                if (this._root != value)

                {

                    this._root = value;

                    if (Context != null && Context.GetEntityDescriptor(this) != null && (value == null || Context.GetEntityDescriptor(value) != null))

                    {

                        Context.SetLink(this, "root", value);

                    }

                }

            }

        }

        global::Microsoft.Graph.IdriveItemCollection global::Microsoft.Graph.IdriveFetcher.items

        {

            get

            {

                if (this._itemsCollection == null)

                {

                    this._itemsCollection = new global::Microsoft.Graph.driveItemCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.driveItem>(GetPath("items")) : null,
                       Context,
                       this,
                       GetPath("items"));

                }

                

                return this._itemsCollection;

            }

        }

        global::Microsoft.Graph.IdriveItemCollection global::Microsoft.Graph.IdriveFetcher.shared

        {

            get

            {

                if (this._sharedCollection == null)

                {

                    this._sharedCollection = new global::Microsoft.Graph.driveItemCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.driveItem>(GetPath("shared")) : null,
                       Context,
                       this,
                       GetPath("shared"));

                }

                

                return this._sharedCollection;

            }

        }

        global::Microsoft.Graph.IdriveItemCollection global::Microsoft.Graph.IdriveFetcher.special

        {

            get

            {

                if (this._specialCollection == null)

                {

                    this._specialCollection = new global::Microsoft.Graph.driveItemCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.driveItem>(GetPath("special")) : null,
                       Context,
                       this,
                       GetPath("special"));

                }

                

                return this._specialCollection;

            }

        }

        global::Microsoft.Graph.IdriveItemFetcher global::Microsoft.Graph.IdriveFetcher.root

        {

            get

            {

                if (this._rootFetcher == null)

                {

                    this._rootFetcher = new global::Microsoft.Graph.driveItemFetcher();

                    this._rootFetcher.Initialize(this.Context, GetPath("root"));

                }

                

                return this._rootFetcher;

            }

        }

        public drive(): base()

        {

        }

        public async System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<global::Microsoft.Graph.IdriveItem>> allPhotosAsync()

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.allPhotos");

            return (await this.Context.ExecuteAsync<global::Microsoft.Graph.driveItem>(requestUri, "GET", false, new OperationParameter[]

            {

            }

            ));

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Idrive> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.drive, global::Microsoft.Graph.Idrive>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Idrive> _query;

        global::System.Threading.Tasks.Task<global::Microsoft.Graph.Idrive> global::Microsoft.Graph.IdriveFetcher.ExecuteAsync()

        {

            var tsc = new global::System.Threading.Tasks.TaskCompletionSource<global::Microsoft.Graph.Idrive>();

            tsc.SetResult(this);

            return tsc.Task;

        }

        global::Microsoft.Graph.IdriveFetcher global::Microsoft.Graph.IdriveFetcher.Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.Idrive, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IdriveFetcher) this;

        }

    }

    internal partial class driveFetcher:Microsoft.OData.ProxyExtensions.RestShallowObjectFetcher, global::Microsoft.Graph.IdriveFetcher

    {

        private global::Microsoft.Graph.driveItemFetcher _rootFetcher;

        private global::Microsoft.Graph.driveItemCollection _itemsCollection;

        private global::Microsoft.Graph.driveItemCollection _sharedCollection;

        private global::Microsoft.Graph.driveItemCollection _specialCollection;

        public global::Microsoft.Graph.IdriveItemCollection items

        {

            get

            {

                if (this._itemsCollection == null)

                {

                    this._itemsCollection = new global::Microsoft.Graph.driveItemCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.driveItem>(GetPath("items")) : null,
                       Context,
                       this,
                       GetPath("items"));

                }

                

                return this._itemsCollection;

            }

        }

        public global::Microsoft.Graph.IdriveItemCollection shared

        {

            get

            {

                if (this._sharedCollection == null)

                {

                    this._sharedCollection = new global::Microsoft.Graph.driveItemCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.driveItem>(GetPath("shared")) : null,
                       Context,
                       this,
                       GetPath("shared"));

                }

                

                return this._sharedCollection;

            }

        }

        public global::Microsoft.Graph.IdriveItemCollection special

        {

            get

            {

                if (this._specialCollection == null)

                {

                    this._specialCollection = new global::Microsoft.Graph.driveItemCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.driveItem>(GetPath("special")) : null,
                       Context,
                       this,
                       GetPath("special"));

                }

                

                return this._specialCollection;

            }

        }

        public global::Microsoft.Graph.IdriveItemFetcher root

        {

            get

            {

                if (this._rootFetcher == null)

                {

                    this._rootFetcher = new global::Microsoft.Graph.driveItemFetcher();

                    this._rootFetcher.Initialize(this.Context, GetPath("root"));

                }

                

                return this._rootFetcher;

            }

        }

        public driveFetcher(): base()

        {

        }

        public async System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<global::Microsoft.Graph.IdriveItem>> allPhotosAsync()

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.allPhotos");

            return (await this.Context.ExecuteAsync<global::Microsoft.Graph.driveItem>(requestUri, "GET", false, new OperationParameter[]

            {

            }

            ));

        }

        public async global::System.Threading.Tasks.Task<global::Microsoft.Graph.Idrive> ExecuteAsync()

        {

            return await EnsureQuery().ExecuteSingleAsync();

        }

        public global::Microsoft.Graph.IdriveFetcher Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.Idrive, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IdriveFetcher) new global::Microsoft.Graph.driveFetcher()

            {

                _query = this.EnsureQuery().Expand<TTarget>(navigationPropertyAccessor)

            }

            ;

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Idrive> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.drive, global::Microsoft.Graph.Idrive>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Idrive> _query;

    }

    internal partial class driveCollection:Microsoft.OData.ProxyExtensions.QueryableSet<global::Microsoft.Graph.Idrive>, global::Microsoft.Graph.IdriveCollection

    {

        internal driveCollection(global::Microsoft.OData.Client.DataServiceQuery inner,Microsoft.OData.ProxyExtensions.DataServiceContextWrapper context,object entity,string path): base(inner, context, entity as Microsoft.OData.ProxyExtensions.EntityBase, path)

        {

        }

        public global::Microsoft.Graph.IdriveFetcher GetById(System.String id)

        {

            return this[id];

        }

        public global::System.Threading.Tasks.Task<Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.Idrive>> ExecuteAsync()

        {

            return ExecuteAsyncInternal();

        }

        public global::System.Threading.Tasks.Task AdddriveAsync(global::Microsoft.Graph.Idrive item, System.Boolean deferSaveChanges = false)

        {

            if (Entity == null)

            {

                Context.AddObject(Path, item);

            }

            else

            {

                var lastSlash = Path.LastIndexOf('/');

                var shortPath = (lastSlash >= 0 && lastSlash < Path.Length - 1) ? Path.Substring(lastSlash + 1) : Path;

                Context.AddRelatedObject(Entity, shortPath, item);

            }

            if (!deferSaveChanges)

            {

                return Context.SaveChangesAsync();

            }

            else

            {

                var retVal = new global::System.Threading.Tasks.TaskCompletionSource<object>();

                retVal.SetResult(null);

                return retVal.Task;

            }

        }

        public global::Microsoft.Graph.IdriveFetcher this[System.String id]

        {

            get

            {

                var path = GetPath<global::Microsoft.Graph.drive>((i) => i.id == id);

                var fetcher = new global::Microsoft.Graph.driveFetcher();

                fetcher.Initialize(Context, path);

                

                return fetcher;

            }

        }

    }

    internal partial class driveCollection

    {

        public global::System.Threading.Tasks.Task<System.Int64> CountAsync()

        {

            return new DataServiceQuerySingle<long>(Context, Path + "/$count").GetValueAsync();

        }

    }

    internal partial class driveFetcher

    {

    }

    public partial class drive

    {

    }

    [global::Microsoft.OData.Client.Key("id")]

    public partial class notes:Microsoft.OData.ProxyExtensions.EntityBase, global::Microsoft.Graph.Inotes, global::Microsoft.Graph.InotesFetcher

    {

        private global::Microsoft.Graph.notebookCollection _notebooksCollection;

        private global::Microsoft.Graph.sectionCollection _sectionsCollection;

        private global::Microsoft.Graph.sectionGroupCollection _sectionGroupsCollection;

        private global::Microsoft.Graph.pageCollection _pagesCollection;

        private global::Microsoft.Graph.resourceCollection _resourcesCollection;

        private global::Microsoft.Graph.notesOperationCollection _operationsCollection;

        private System.String _id;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.notebook> _notebooksConcrete;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.section> _sectionsConcrete;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.sectionGroup> _sectionGroupsConcrete;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.page> _pagesConcrete;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.resource> _resourcesConcrete;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.notesOperation> _operationsConcrete;

        public System.String id

        {

            get

            {

                return _id;

            }

            set

            {

                if (value != _id)

                {

                    _id = value;

                    OnPropertyChanged("id");

                }

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.Inotebook> global::Microsoft.Graph.Inotes.notebooks

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.Inotebook, global::Microsoft.Graph.notebook>(Context, (DataServiceCollection<global::Microsoft.Graph.notebook>) notebooks);

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.Isection> global::Microsoft.Graph.Inotes.sections

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.Isection, global::Microsoft.Graph.section>(Context, (DataServiceCollection<global::Microsoft.Graph.section>) sections);

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.IsectionGroup> global::Microsoft.Graph.Inotes.sectionGroups

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.IsectionGroup, global::Microsoft.Graph.sectionGroup>(Context, (DataServiceCollection<global::Microsoft.Graph.sectionGroup>) sectionGroups);

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.Ipage> global::Microsoft.Graph.Inotes.pages

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.Ipage, global::Microsoft.Graph.page>(Context, (DataServiceCollection<global::Microsoft.Graph.page>) pages);

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.Iresource> global::Microsoft.Graph.Inotes.resources

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.Iresource, global::Microsoft.Graph.resource>(Context, (DataServiceCollection<global::Microsoft.Graph.resource>) resources);

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.InotesOperation> global::Microsoft.Graph.Inotes.operations

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.InotesOperation, global::Microsoft.Graph.notesOperation>(Context, (DataServiceCollection<global::Microsoft.Graph.notesOperation>) operations);

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.notebook> notebooks

        {

            get

            {

                if (this._notebooksConcrete == null)

                {

                    this._notebooksConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.notebook>();

                    this._notebooksConcrete.SetContainer(() => GetContainingEntity("notebooks"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.notebook>)this._notebooksConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                notebooks.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        notebooks.Add(i);

                    }

                }

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.section> sections

        {

            get

            {

                if (this._sectionsConcrete == null)

                {

                    this._sectionsConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.section>();

                    this._sectionsConcrete.SetContainer(() => GetContainingEntity("sections"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.section>)this._sectionsConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                sections.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        sections.Add(i);

                    }

                }

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.sectionGroup> sectionGroups

        {

            get

            {

                if (this._sectionGroupsConcrete == null)

                {

                    this._sectionGroupsConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.sectionGroup>();

                    this._sectionGroupsConcrete.SetContainer(() => GetContainingEntity("sectionGroups"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.sectionGroup>)this._sectionGroupsConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                sectionGroups.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        sectionGroups.Add(i);

                    }

                }

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.page> pages

        {

            get

            {

                if (this._pagesConcrete == null)

                {

                    this._pagesConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.page>();

                    this._pagesConcrete.SetContainer(() => GetContainingEntity("pages"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.page>)this._pagesConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                pages.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        pages.Add(i);

                    }

                }

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.resource> resources

        {

            get

            {

                if (this._resourcesConcrete == null)

                {

                    this._resourcesConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.resource>();

                    this._resourcesConcrete.SetContainer(() => GetContainingEntity("resources"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.resource>)this._resourcesConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                resources.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        resources.Add(i);

                    }

                }

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.notesOperation> operations

        {

            get

            {

                if (this._operationsConcrete == null)

                {

                    this._operationsConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.notesOperation>();

                    this._operationsConcrete.SetContainer(() => GetContainingEntity("operations"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.notesOperation>)this._operationsConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                operations.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        operations.Add(i);

                    }

                }

            }

        }

        global::Microsoft.Graph.InotebookCollection global::Microsoft.Graph.InotesFetcher.notebooks

        {

            get

            {

                if (this._notebooksCollection == null)

                {

                    this._notebooksCollection = new global::Microsoft.Graph.notebookCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.notebook>(GetPath("notebooks")) : null,
                       Context,
                       this,
                       GetPath("notebooks"));

                }

                

                return this._notebooksCollection;

            }

        }

        global::Microsoft.Graph.IsectionCollection global::Microsoft.Graph.InotesFetcher.sections

        {

            get

            {

                if (this._sectionsCollection == null)

                {

                    this._sectionsCollection = new global::Microsoft.Graph.sectionCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.section>(GetPath("sections")) : null,
                       Context,
                       this,
                       GetPath("sections"));

                }

                

                return this._sectionsCollection;

            }

        }

        global::Microsoft.Graph.IsectionGroupCollection global::Microsoft.Graph.InotesFetcher.sectionGroups

        {

            get

            {

                if (this._sectionGroupsCollection == null)

                {

                    this._sectionGroupsCollection = new global::Microsoft.Graph.sectionGroupCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.sectionGroup>(GetPath("sectionGroups")) : null,
                       Context,
                       this,
                       GetPath("sectionGroups"));

                }

                

                return this._sectionGroupsCollection;

            }

        }

        global::Microsoft.Graph.IpageCollection global::Microsoft.Graph.InotesFetcher.pages

        {

            get

            {

                if (this._pagesCollection == null)

                {

                    this._pagesCollection = new global::Microsoft.Graph.pageCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.page>(GetPath("pages")) : null,
                       Context,
                       this,
                       GetPath("pages"));

                }

                

                return this._pagesCollection;

            }

        }

        global::Microsoft.Graph.IresourceCollection global::Microsoft.Graph.InotesFetcher.resources

        {

            get

            {

                if (this._resourcesCollection == null)

                {

                    this._resourcesCollection = new global::Microsoft.Graph.resourceCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.resource>(GetPath("resources")) : null,
                       Context,
                       this,
                       GetPath("resources"));

                }

                

                return this._resourcesCollection;

            }

        }

        global::Microsoft.Graph.InotesOperationCollection global::Microsoft.Graph.InotesFetcher.operations

        {

            get

            {

                if (this._operationsCollection == null)

                {

                    this._operationsCollection = new global::Microsoft.Graph.notesOperationCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.notesOperation>(GetPath("operations")) : null,
                       Context,
                       this,
                       GetPath("operations"));

                }

                

                return this._operationsCollection;

            }

        }

        public notes(): base()

        {

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Inotes> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.notes, global::Microsoft.Graph.Inotes>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Inotes> _query;

        global::System.Threading.Tasks.Task<global::Microsoft.Graph.Inotes> global::Microsoft.Graph.InotesFetcher.ExecuteAsync()

        {

            var tsc = new global::System.Threading.Tasks.TaskCompletionSource<global::Microsoft.Graph.Inotes>();

            tsc.SetResult(this);

            return tsc.Task;

        }

        global::Microsoft.Graph.InotesFetcher global::Microsoft.Graph.InotesFetcher.Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.Inotes, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.InotesFetcher) this;

        }

    }

    internal partial class notesFetcher:Microsoft.OData.ProxyExtensions.RestShallowObjectFetcher, global::Microsoft.Graph.InotesFetcher

    {

        private global::Microsoft.Graph.notebookCollection _notebooksCollection;

        private global::Microsoft.Graph.sectionCollection _sectionsCollection;

        private global::Microsoft.Graph.sectionGroupCollection _sectionGroupsCollection;

        private global::Microsoft.Graph.pageCollection _pagesCollection;

        private global::Microsoft.Graph.resourceCollection _resourcesCollection;

        private global::Microsoft.Graph.notesOperationCollection _operationsCollection;

        public global::Microsoft.Graph.InotebookCollection notebooks

        {

            get

            {

                if (this._notebooksCollection == null)

                {

                    this._notebooksCollection = new global::Microsoft.Graph.notebookCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.notebook>(GetPath("notebooks")) : null,
                       Context,
                       this,
                       GetPath("notebooks"));

                }

                

                return this._notebooksCollection;

            }

        }

        public global::Microsoft.Graph.IsectionCollection sections

        {

            get

            {

                if (this._sectionsCollection == null)

                {

                    this._sectionsCollection = new global::Microsoft.Graph.sectionCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.section>(GetPath("sections")) : null,
                       Context,
                       this,
                       GetPath("sections"));

                }

                

                return this._sectionsCollection;

            }

        }

        public global::Microsoft.Graph.IsectionGroupCollection sectionGroups

        {

            get

            {

                if (this._sectionGroupsCollection == null)

                {

                    this._sectionGroupsCollection = new global::Microsoft.Graph.sectionGroupCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.sectionGroup>(GetPath("sectionGroups")) : null,
                       Context,
                       this,
                       GetPath("sectionGroups"));

                }

                

                return this._sectionGroupsCollection;

            }

        }

        public global::Microsoft.Graph.IpageCollection pages

        {

            get

            {

                if (this._pagesCollection == null)

                {

                    this._pagesCollection = new global::Microsoft.Graph.pageCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.page>(GetPath("pages")) : null,
                       Context,
                       this,
                       GetPath("pages"));

                }

                

                return this._pagesCollection;

            }

        }

        public global::Microsoft.Graph.IresourceCollection resources

        {

            get

            {

                if (this._resourcesCollection == null)

                {

                    this._resourcesCollection = new global::Microsoft.Graph.resourceCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.resource>(GetPath("resources")) : null,
                       Context,
                       this,
                       GetPath("resources"));

                }

                

                return this._resourcesCollection;

            }

        }

        public global::Microsoft.Graph.InotesOperationCollection operations

        {

            get

            {

                if (this._operationsCollection == null)

                {

                    this._operationsCollection = new global::Microsoft.Graph.notesOperationCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.notesOperation>(GetPath("operations")) : null,
                       Context,
                       this,
                       GetPath("operations"));

                }

                

                return this._operationsCollection;

            }

        }

        public notesFetcher(): base()

        {

        }

        public async global::System.Threading.Tasks.Task<global::Microsoft.Graph.Inotes> ExecuteAsync()

        {

            return await EnsureQuery().ExecuteSingleAsync();

        }

        public global::Microsoft.Graph.InotesFetcher Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.Inotes, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.InotesFetcher) new global::Microsoft.Graph.notesFetcher()

            {

                _query = this.EnsureQuery().Expand<TTarget>(navigationPropertyAccessor)

            }

            ;

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Inotes> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.notes, global::Microsoft.Graph.Inotes>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Inotes> _query;

    }

    internal partial class notesCollection:Microsoft.OData.ProxyExtensions.QueryableSet<global::Microsoft.Graph.Inotes>, global::Microsoft.Graph.InotesCollection

    {

        internal notesCollection(global::Microsoft.OData.Client.DataServiceQuery inner,Microsoft.OData.ProxyExtensions.DataServiceContextWrapper context,object entity,string path): base(inner, context, entity as Microsoft.OData.ProxyExtensions.EntityBase, path)

        {

        }

        public global::Microsoft.Graph.InotesFetcher GetById(System.String id)

        {

            return this[id];

        }

        public global::System.Threading.Tasks.Task<Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.Inotes>> ExecuteAsync()

        {

            return ExecuteAsyncInternal();

        }

        public global::System.Threading.Tasks.Task AddnotesAsync(global::Microsoft.Graph.Inotes item, System.Boolean deferSaveChanges = false)

        {

            if (Entity == null)

            {

                Context.AddObject(Path, item);

            }

            else

            {

                var lastSlash = Path.LastIndexOf('/');

                var shortPath = (lastSlash >= 0 && lastSlash < Path.Length - 1) ? Path.Substring(lastSlash + 1) : Path;

                Context.AddRelatedObject(Entity, shortPath, item);

            }

            if (!deferSaveChanges)

            {

                return Context.SaveChangesAsync();

            }

            else

            {

                var retVal = new global::System.Threading.Tasks.TaskCompletionSource<object>();

                retVal.SetResult(null);

                return retVal.Task;

            }

        }

        public global::Microsoft.Graph.InotesFetcher this[System.String id]

        {

            get

            {

                var path = GetPath<global::Microsoft.Graph.notes>((i) => i.id == id);

                var fetcher = new global::Microsoft.Graph.notesFetcher();

                fetcher.Initialize(Context, path);

                

                return fetcher;

            }

        }

    }

    internal partial class notesCollection

    {

        public global::System.Threading.Tasks.Task<System.Int64> CountAsync()

        {

            return new DataServiceQuerySingle<long>(Context, Path + "/$count").GetValueAsync();

        }

    }

    internal partial class notesFetcher

    {

    }

    public partial class notes

    {

    }

    [global::Microsoft.OData.Client.Key("id")]

    public partial class plan:Microsoft.OData.ProxyExtensions.EntityBase, global::Microsoft.Graph.Iplan, global::Microsoft.Graph.IplanFetcher

    {

        private global::Microsoft.Graph.planDetails _details;

        private global::Microsoft.Graph.planTaskBoard _assignedToTaskBoard;

        private global::Microsoft.Graph.planTaskBoard _progressTaskBoard;

        private global::Microsoft.Graph.planTaskBoard _bucketTaskBoard;

        private global::Microsoft.Graph.planDetailsFetcher _detailsFetcher;

        private global::Microsoft.Graph.planTaskBoardFetcher _assignedToTaskBoardFetcher;

        private global::Microsoft.Graph.planTaskBoardFetcher _progressTaskBoardFetcher;

        private global::Microsoft.Graph.planTaskBoardFetcher _bucketTaskBoardFetcher;

        private global::Microsoft.Graph.taskCollection _tasksCollection;

        private global::Microsoft.Graph.bucketCollection _bucketsCollection;

        private System.String _createdBy;

        private System.String _owner;

        private System.String _title;

        private System.String _id;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.task> _tasksConcrete;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.bucket> _bucketsConcrete;

        public System.String createdBy

        {

            get

            {

                return _createdBy;

            }

            set

            {

                if (value != _createdBy)

                {

                    _createdBy = value;

                    OnPropertyChanged("createdBy");

                }

            }

        }

        public System.String owner

        {

            get

            {

                return _owner;

            }

            set

            {

                if (value != _owner)

                {

                    _owner = value;

                    OnPropertyChanged("owner");

                }

            }

        }

        public System.String title

        {

            get

            {

                return _title;

            }

            set

            {

                if (value != _title)

                {

                    _title = value;

                    OnPropertyChanged("title");

                }

            }

        }

        public System.String id

        {

            get

            {

                return _id;

            }

            set

            {

                if (value != _id)

                {

                    _id = value;

                    OnPropertyChanged("id");

                }

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.Itask> global::Microsoft.Graph.Iplan.tasks

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.Itask, global::Microsoft.Graph.task>(Context, (DataServiceCollection<global::Microsoft.Graph.task>) tasks);

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.Ibucket> global::Microsoft.Graph.Iplan.buckets

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.Ibucket, global::Microsoft.Graph.bucket>(Context, (DataServiceCollection<global::Microsoft.Graph.bucket>) buckets);

            }

        }

        global::Microsoft.Graph.IplanDetails global::Microsoft.Graph.Iplan.details

        {

            get

            {

                return this._details;

            }

            set

            {

                if (this.details != value)

                {

                    this.details = (global::Microsoft.Graph.planDetails)value;

                }

            }

        }

        global::Microsoft.Graph.IplanTaskBoard global::Microsoft.Graph.Iplan.assignedToTaskBoard

        {

            get

            {

                return this._assignedToTaskBoard;

            }

            set

            {

                if (this.assignedToTaskBoard != value)

                {

                    this.assignedToTaskBoard = (global::Microsoft.Graph.planTaskBoard)value;

                }

            }

        }

        global::Microsoft.Graph.IplanTaskBoard global::Microsoft.Graph.Iplan.progressTaskBoard

        {

            get

            {

                return this._progressTaskBoard;

            }

            set

            {

                if (this.progressTaskBoard != value)

                {

                    this.progressTaskBoard = (global::Microsoft.Graph.planTaskBoard)value;

                }

            }

        }

        global::Microsoft.Graph.IplanTaskBoard global::Microsoft.Graph.Iplan.bucketTaskBoard

        {

            get

            {

                return this._bucketTaskBoard;

            }

            set

            {

                if (this.bucketTaskBoard != value)

                {

                    this.bucketTaskBoard = (global::Microsoft.Graph.planTaskBoard)value;

                }

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.task> tasks

        {

            get

            {

                if (this._tasksConcrete == null)

                {

                    this._tasksConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.task>();

                    this._tasksConcrete.SetContainer(() => GetContainingEntity("tasks"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.task>)this._tasksConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                tasks.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        tasks.Add(i);

                    }

                }

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.bucket> buckets

        {

            get

            {

                if (this._bucketsConcrete == null)

                {

                    this._bucketsConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.bucket>();

                    this._bucketsConcrete.SetContainer(() => GetContainingEntity("buckets"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.bucket>)this._bucketsConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                buckets.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        buckets.Add(i);

                    }

                }

            }

        }

        public global::Microsoft.Graph.planDetails details

        {

            get

            {

                return this._details;

            }

            set

            {

                if (this._details != value)

                {

                    this._details = value;

                    if (Context != null && Context.GetEntityDescriptor(this) != null && (value == null || Context.GetEntityDescriptor(value) != null))

                    {

                        Context.SetLink(this, "details", value);

                    }

                }

            }

        }

        public global::Microsoft.Graph.planTaskBoard assignedToTaskBoard

        {

            get

            {

                return this._assignedToTaskBoard;

            }

            set

            {

                if (this._assignedToTaskBoard != value)

                {

                    this._assignedToTaskBoard = value;

                    if (Context != null && Context.GetEntityDescriptor(this) != null && (value == null || Context.GetEntityDescriptor(value) != null))

                    {

                        Context.SetLink(this, "assignedToTaskBoard", value);

                    }

                }

            }

        }

        public global::Microsoft.Graph.planTaskBoard progressTaskBoard

        {

            get

            {

                return this._progressTaskBoard;

            }

            set

            {

                if (this._progressTaskBoard != value)

                {

                    this._progressTaskBoard = value;

                    if (Context != null && Context.GetEntityDescriptor(this) != null && (value == null || Context.GetEntityDescriptor(value) != null))

                    {

                        Context.SetLink(this, "progressTaskBoard", value);

                    }

                }

            }

        }

        public global::Microsoft.Graph.planTaskBoard bucketTaskBoard

        {

            get

            {

                return this._bucketTaskBoard;

            }

            set

            {

                if (this._bucketTaskBoard != value)

                {

                    this._bucketTaskBoard = value;

                    if (Context != null && Context.GetEntityDescriptor(this) != null && (value == null || Context.GetEntityDescriptor(value) != null))

                    {

                        Context.SetLink(this, "bucketTaskBoard", value);

                    }

                }

            }

        }

        global::Microsoft.Graph.ItaskCollection global::Microsoft.Graph.IplanFetcher.tasks

        {

            get

            {

                if (this._tasksCollection == null)

                {

                    this._tasksCollection = new global::Microsoft.Graph.taskCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.task>(GetPath("tasks")) : null,
                       Context,
                       this,
                       GetPath("tasks"));

                }

                

                return this._tasksCollection;

            }

        }

        global::Microsoft.Graph.IbucketCollection global::Microsoft.Graph.IplanFetcher.buckets

        {

            get

            {

                if (this._bucketsCollection == null)

                {

                    this._bucketsCollection = new global::Microsoft.Graph.bucketCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.bucket>(GetPath("buckets")) : null,
                       Context,
                       this,
                       GetPath("buckets"));

                }

                

                return this._bucketsCollection;

            }

        }

        global::Microsoft.Graph.IplanDetailsFetcher global::Microsoft.Graph.IplanFetcher.details

        {

            get

            {

                if (this._detailsFetcher == null)

                {

                    this._detailsFetcher = new global::Microsoft.Graph.planDetailsFetcher();

                    this._detailsFetcher.Initialize(this.Context, GetPath("details"));

                }

                

                return this._detailsFetcher;

            }

        }

        global::Microsoft.Graph.IplanTaskBoardFetcher global::Microsoft.Graph.IplanFetcher.assignedToTaskBoard

        {

            get

            {

                if (this._assignedToTaskBoardFetcher == null)

                {

                    this._assignedToTaskBoardFetcher = new global::Microsoft.Graph.planTaskBoardFetcher();

                    this._assignedToTaskBoardFetcher.Initialize(this.Context, GetPath("assignedToTaskBoard"));

                }

                

                return this._assignedToTaskBoardFetcher;

            }

        }

        global::Microsoft.Graph.IplanTaskBoardFetcher global::Microsoft.Graph.IplanFetcher.progressTaskBoard

        {

            get

            {

                if (this._progressTaskBoardFetcher == null)

                {

                    this._progressTaskBoardFetcher = new global::Microsoft.Graph.planTaskBoardFetcher();

                    this._progressTaskBoardFetcher.Initialize(this.Context, GetPath("progressTaskBoard"));

                }

                

                return this._progressTaskBoardFetcher;

            }

        }

        global::Microsoft.Graph.IplanTaskBoardFetcher global::Microsoft.Graph.IplanFetcher.bucketTaskBoard

        {

            get

            {

                if (this._bucketTaskBoardFetcher == null)

                {

                    this._bucketTaskBoardFetcher = new global::Microsoft.Graph.planTaskBoardFetcher();

                    this._bucketTaskBoardFetcher.Initialize(this.Context, GetPath("bucketTaskBoard"));

                }

                

                return this._bucketTaskBoardFetcher;

            }

        }

        public plan(): base()

        {

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Iplan> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.plan, global::Microsoft.Graph.Iplan>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Iplan> _query;

        global::System.Threading.Tasks.Task<global::Microsoft.Graph.Iplan> global::Microsoft.Graph.IplanFetcher.ExecuteAsync()

        {

            var tsc = new global::System.Threading.Tasks.TaskCompletionSource<global::Microsoft.Graph.Iplan>();

            tsc.SetResult(this);

            return tsc.Task;

        }

        global::Microsoft.Graph.IplanFetcher global::Microsoft.Graph.IplanFetcher.Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.Iplan, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IplanFetcher) this;

        }

    }

    internal partial class planFetcher:Microsoft.OData.ProxyExtensions.RestShallowObjectFetcher, global::Microsoft.Graph.IplanFetcher

    {

        private global::Microsoft.Graph.planDetailsFetcher _detailsFetcher;

        private global::Microsoft.Graph.planTaskBoardFetcher _assignedToTaskBoardFetcher;

        private global::Microsoft.Graph.planTaskBoardFetcher _progressTaskBoardFetcher;

        private global::Microsoft.Graph.planTaskBoardFetcher _bucketTaskBoardFetcher;

        private global::Microsoft.Graph.taskCollection _tasksCollection;

        private global::Microsoft.Graph.bucketCollection _bucketsCollection;

        public global::Microsoft.Graph.ItaskCollection tasks

        {

            get

            {

                if (this._tasksCollection == null)

                {

                    this._tasksCollection = new global::Microsoft.Graph.taskCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.task>(GetPath("tasks")) : null,
                       Context,
                       this,
                       GetPath("tasks"));

                }

                

                return this._tasksCollection;

            }

        }

        public global::Microsoft.Graph.IbucketCollection buckets

        {

            get

            {

                if (this._bucketsCollection == null)

                {

                    this._bucketsCollection = new global::Microsoft.Graph.bucketCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.bucket>(GetPath("buckets")) : null,
                       Context,
                       this,
                       GetPath("buckets"));

                }

                

                return this._bucketsCollection;

            }

        }

        public global::Microsoft.Graph.IplanDetailsFetcher details

        {

            get

            {

                if (this._detailsFetcher == null)

                {

                    this._detailsFetcher = new global::Microsoft.Graph.planDetailsFetcher();

                    this._detailsFetcher.Initialize(this.Context, GetPath("details"));

                }

                

                return this._detailsFetcher;

            }

        }

        public global::Microsoft.Graph.IplanTaskBoardFetcher assignedToTaskBoard

        {

            get

            {

                if (this._assignedToTaskBoardFetcher == null)

                {

                    this._assignedToTaskBoardFetcher = new global::Microsoft.Graph.planTaskBoardFetcher();

                    this._assignedToTaskBoardFetcher.Initialize(this.Context, GetPath("assignedToTaskBoard"));

                }

                

                return this._assignedToTaskBoardFetcher;

            }

        }

        public global::Microsoft.Graph.IplanTaskBoardFetcher progressTaskBoard

        {

            get

            {

                if (this._progressTaskBoardFetcher == null)

                {

                    this._progressTaskBoardFetcher = new global::Microsoft.Graph.planTaskBoardFetcher();

                    this._progressTaskBoardFetcher.Initialize(this.Context, GetPath("progressTaskBoard"));

                }

                

                return this._progressTaskBoardFetcher;

            }

        }

        public global::Microsoft.Graph.IplanTaskBoardFetcher bucketTaskBoard

        {

            get

            {

                if (this._bucketTaskBoardFetcher == null)

                {

                    this._bucketTaskBoardFetcher = new global::Microsoft.Graph.planTaskBoardFetcher();

                    this._bucketTaskBoardFetcher.Initialize(this.Context, GetPath("bucketTaskBoard"));

                }

                

                return this._bucketTaskBoardFetcher;

            }

        }

        public planFetcher(): base()

        {

        }

        public async global::System.Threading.Tasks.Task<global::Microsoft.Graph.Iplan> ExecuteAsync()

        {

            return await EnsureQuery().ExecuteSingleAsync();

        }

        public global::Microsoft.Graph.IplanFetcher Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.Iplan, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IplanFetcher) new global::Microsoft.Graph.planFetcher()

            {

                _query = this.EnsureQuery().Expand<TTarget>(navigationPropertyAccessor)

            }

            ;

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Iplan> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.plan, global::Microsoft.Graph.Iplan>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Iplan> _query;

    }

    internal partial class planCollection:Microsoft.OData.ProxyExtensions.QueryableSet<global::Microsoft.Graph.Iplan>, global::Microsoft.Graph.IplanCollection

    {

        internal planCollection(global::Microsoft.OData.Client.DataServiceQuery inner,Microsoft.OData.ProxyExtensions.DataServiceContextWrapper context,object entity,string path): base(inner, context, entity as Microsoft.OData.ProxyExtensions.EntityBase, path)

        {

        }

        public global::Microsoft.Graph.IplanFetcher GetById(System.String id)

        {

            return this[id];

        }

        public global::System.Threading.Tasks.Task<Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.Iplan>> ExecuteAsync()

        {

            return ExecuteAsyncInternal();

        }

        public global::System.Threading.Tasks.Task AddplanAsync(global::Microsoft.Graph.Iplan item, System.Boolean deferSaveChanges = false)

        {

            if (Entity == null)

            {

                Context.AddObject(Path, item);

            }

            else

            {

                var lastSlash = Path.LastIndexOf('/');

                var shortPath = (lastSlash >= 0 && lastSlash < Path.Length - 1) ? Path.Substring(lastSlash + 1) : Path;

                Context.AddRelatedObject(Entity, shortPath, item);

            }

            if (!deferSaveChanges)

            {

                return Context.SaveChangesAsync();

            }

            else

            {

                var retVal = new global::System.Threading.Tasks.TaskCompletionSource<object>();

                retVal.SetResult(null);

                return retVal.Task;

            }

        }

        public global::Microsoft.Graph.IplanFetcher this[System.String id]

        {

            get

            {

                var path = GetPath<global::Microsoft.Graph.plan>((i) => i.id == id);

                var fetcher = new global::Microsoft.Graph.planFetcher();

                fetcher.Initialize(Context, path);

                

                return fetcher;

            }

        }

    }

    internal partial class planCollection

    {

        public global::System.Threading.Tasks.Task<System.Int64> CountAsync()

        {

            return new DataServiceQuerySingle<long>(Context, Path + "/$count").GetValueAsync();

        }

    }

    internal partial class planFetcher

    {

    }

    public partial class plan

    {

    }

    [global::Microsoft.OData.Client.Key("id")]

    public partial class oAuth2PermissionGrant:Microsoft.OData.ProxyExtensions.EntityBase, global::Microsoft.Graph.IoAuth2PermissionGrant, global::Microsoft.Graph.IoAuth2PermissionGrantFetcher

    {

        private System.String _clientId;

        private System.String _consentType;

        private System.Nullable<System.DateTimeOffset> _expiryTime;

        private System.String _id;

        private System.String _principalId;

        private System.String _resourceId;

        private System.String _scope;

        private System.Nullable<System.DateTimeOffset> _startTime;

        public System.String clientId

        {

            get

            {

                return _clientId;

            }

            set

            {

                if (value != _clientId)

                {

                    _clientId = value;

                    OnPropertyChanged("clientId");

                }

            }

        }

        public System.String consentType

        {

            get

            {

                return _consentType;

            }

            set

            {

                if (value != _consentType)

                {

                    _consentType = value;

                    OnPropertyChanged("consentType");

                }

            }

        }

        public System.Nullable<System.DateTimeOffset> expiryTime

        {

            get

            {

                return _expiryTime;

            }

            set

            {

                if (value != _expiryTime)

                {

                    _expiryTime = value;

                    OnPropertyChanged("expiryTime");

                }

            }

        }

        public System.String id

        {

            get

            {

                return _id;

            }

            set

            {

                if (value != _id)

                {

                    _id = value;

                    OnPropertyChanged("id");

                }

            }

        }

        public System.String principalId

        {

            get

            {

                return _principalId;

            }

            set

            {

                if (value != _principalId)

                {

                    _principalId = value;

                    OnPropertyChanged("principalId");

                }

            }

        }

        public System.String resourceId

        {

            get

            {

                return _resourceId;

            }

            set

            {

                if (value != _resourceId)

                {

                    _resourceId = value;

                    OnPropertyChanged("resourceId");

                }

            }

        }

        public System.String scope

        {

            get

            {

                return _scope;

            }

            set

            {

                if (value != _scope)

                {

                    _scope = value;

                    OnPropertyChanged("scope");

                }

            }

        }

        public System.Nullable<System.DateTimeOffset> startTime

        {

            get

            {

                return _startTime;

            }

            set

            {

                if (value != _startTime)

                {

                    _startTime = value;

                    OnPropertyChanged("startTime");

                }

            }

        }

        public oAuth2PermissionGrant(): base()

        {

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IoAuth2PermissionGrant> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.oAuth2PermissionGrant, global::Microsoft.Graph.IoAuth2PermissionGrant>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IoAuth2PermissionGrant> _query;

        global::System.Threading.Tasks.Task<global::Microsoft.Graph.IoAuth2PermissionGrant> global::Microsoft.Graph.IoAuth2PermissionGrantFetcher.ExecuteAsync()

        {

            var tsc = new global::System.Threading.Tasks.TaskCompletionSource<global::Microsoft.Graph.IoAuth2PermissionGrant>();

            tsc.SetResult(this);

            return tsc.Task;

        }

        global::Microsoft.Graph.IoAuth2PermissionGrantFetcher global::Microsoft.Graph.IoAuth2PermissionGrantFetcher.Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.IoAuth2PermissionGrant, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IoAuth2PermissionGrantFetcher) this;

        }

    }

    internal partial class oAuth2PermissionGrantFetcher:Microsoft.OData.ProxyExtensions.RestShallowObjectFetcher, global::Microsoft.Graph.IoAuth2PermissionGrantFetcher

    {

        public oAuth2PermissionGrantFetcher(): base()

        {

        }

        public async global::System.Threading.Tasks.Task<global::Microsoft.Graph.IoAuth2PermissionGrant> ExecuteAsync()

        {

            return await EnsureQuery().ExecuteSingleAsync();

        }

        public global::Microsoft.Graph.IoAuth2PermissionGrantFetcher Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.IoAuth2PermissionGrant, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IoAuth2PermissionGrantFetcher) new global::Microsoft.Graph.oAuth2PermissionGrantFetcher()

            {

                _query = this.EnsureQuery().Expand<TTarget>(navigationPropertyAccessor)

            }

            ;

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IoAuth2PermissionGrant> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.oAuth2PermissionGrant, global::Microsoft.Graph.IoAuth2PermissionGrant>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IoAuth2PermissionGrant> _query;

    }

    internal partial class oAuth2PermissionGrantCollection:Microsoft.OData.ProxyExtensions.QueryableSet<global::Microsoft.Graph.IoAuth2PermissionGrant>, global::Microsoft.Graph.IoAuth2PermissionGrantCollection

    {

        internal oAuth2PermissionGrantCollection(global::Microsoft.OData.Client.DataServiceQuery inner,Microsoft.OData.ProxyExtensions.DataServiceContextWrapper context,object entity,string path): base(inner, context, entity as Microsoft.OData.ProxyExtensions.EntityBase, path)

        {

        }

        public global::Microsoft.Graph.IoAuth2PermissionGrantFetcher GetById(System.String id)

        {

            return this[id];

        }

        public global::System.Threading.Tasks.Task<Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.IoAuth2PermissionGrant>> ExecuteAsync()

        {

            return ExecuteAsyncInternal();

        }

        public global::System.Threading.Tasks.Task AddoAuth2PermissionGrantAsync(global::Microsoft.Graph.IoAuth2PermissionGrant item, System.Boolean deferSaveChanges = false)

        {

            if (Entity == null)

            {

                Context.AddObject(Path, item);

            }

            else

            {

                var lastSlash = Path.LastIndexOf('/');

                var shortPath = (lastSlash >= 0 && lastSlash < Path.Length - 1) ? Path.Substring(lastSlash + 1) : Path;

                Context.AddRelatedObject(Entity, shortPath, item);

            }

            if (!deferSaveChanges)

            {

                return Context.SaveChangesAsync();

            }

            else

            {

                var retVal = new global::System.Threading.Tasks.TaskCompletionSource<object>();

                retVal.SetResult(null);

                return retVal.Task;

            }

        }

        public global::Microsoft.Graph.IoAuth2PermissionGrantFetcher this[System.String id]

        {

            get

            {

                var path = GetPath<global::Microsoft.Graph.oAuth2PermissionGrant>((i) => i.id == id);

                var fetcher = new global::Microsoft.Graph.oAuth2PermissionGrantFetcher();

                fetcher.Initialize(Context, path);

                

                return fetcher;

            }

        }

    }

    internal partial class oAuth2PermissionGrantCollection

    {

        public global::System.Threading.Tasks.Task<System.Int64> CountAsync()

        {

            return new DataServiceQuerySingle<long>(Context, Path + "/$count").GetValueAsync();

        }

    }

    internal partial class oAuth2PermissionGrantFetcher

    {

    }

    public partial class oAuth2PermissionGrant

    {

    }

    [global::Microsoft.OData.Client.Key("id")]

    public partial class servicePrincipal:global::Microsoft.Graph.directoryObject, global::Microsoft.Graph.IservicePrincipal, global::Microsoft.Graph.IservicePrincipalFetcher

    {

        private global::Microsoft.Graph.appRoleAssignmentCollection _appRoleAssignedToCollection;

        private global::Microsoft.Graph.appRoleAssignmentCollection _appRoleAssignmentsCollection;

        private global::Microsoft.Graph.oAuth2PermissionGrantCollection _oauth2PermissionGrantsCollection;

        private global::Microsoft.Graph.directoryObjectCollection _memberOfCollection;

        private global::Microsoft.Graph.directoryObjectCollection _createdObjectsCollection;

        private global::Microsoft.Graph.directoryObjectCollection _ownersCollection;

        private global::Microsoft.Graph.directoryObjectCollection _ownedObjectsCollection;

        private System.Nullable<System.Boolean> _accountEnabled;

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.addIn> _addIns;

        private System.String _appDisplayName;

        private System.String _appId;

        private System.Nullable<System.Guid> _appOwnerOrganizationId;

        private System.Boolean _appRoleAssignmentRequired;

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.appRole> _appRoles;

        private System.String _displayName;

        private System.String _errorUrl;

        private System.String _homepage;

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.keyCredential> _keyCredentials;

        private System.String _logoutUrl;

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.oAuth2Permission> _oauth2Permissions;

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.passwordCredential> _passwordCredentials;

        private System.String _preferredTokenSigningKeyThumbprint;

        private System.String _publisherName;

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.String> _replyUrls;

        private System.String _samlMetadataUrl;

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.String> _servicePrincipalNames;

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.String> _tags;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.appRoleAssignment> _appRoleAssignedToConcrete;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.appRoleAssignment> _appRoleAssignmentsConcrete;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.oAuth2PermissionGrant> _oauth2PermissionGrantsConcrete;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.directoryObject> _memberOfConcrete;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.directoryObject> _createdObjectsConcrete;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.directoryObject> _ownersConcrete;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.directoryObject> _ownedObjectsConcrete;

        public System.Nullable<System.Boolean> accountEnabled

        {

            get

            {

                return _accountEnabled;

            }

            set

            {

                if (value != _accountEnabled)

                {

                    _accountEnabled = value;

                    OnPropertyChanged("accountEnabled");

                }

            }

        }

        public System.Collections.Generic.IList<global::Microsoft.Graph.addIn> addIns

        {

            get

            {

                if (this._addIns == default(System.Collections.Generic.IList<global::Microsoft.Graph.addIn>))

                {

                    this._addIns = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.addIn>();

                    this._addIns.SetContainer(() => GetContainingEntity("addIns"));

                }

                return this._addIns;

            }

            set

            {

                addIns.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        addIns.Add(i);

                    }

                }

            }

        }

        public System.String appDisplayName

        {

            get

            {

                return _appDisplayName;

            }

            set

            {

                if (value != _appDisplayName)

                {

                    _appDisplayName = value;

                    OnPropertyChanged("appDisplayName");

                }

            }

        }

        public System.String appId

        {

            get

            {

                return _appId;

            }

            set

            {

                if (value != _appId)

                {

                    _appId = value;

                    OnPropertyChanged("appId");

                }

            }

        }

        public System.Nullable<System.Guid> appOwnerOrganizationId

        {

            get

            {

                return _appOwnerOrganizationId;

            }

            set

            {

                if (value != _appOwnerOrganizationId)

                {

                    _appOwnerOrganizationId = value;

                    OnPropertyChanged("appOwnerOrganizationId");

                }

            }

        }

        public System.Boolean appRoleAssignmentRequired

        {

            get

            {

                return _appRoleAssignmentRequired;

            }

            set

            {

                if (value != _appRoleAssignmentRequired)

                {

                    _appRoleAssignmentRequired = value;

                    OnPropertyChanged("appRoleAssignmentRequired");

                }

            }

        }

        public System.Collections.Generic.IList<global::Microsoft.Graph.appRole> appRoles

        {

            get

            {

                if (this._appRoles == default(System.Collections.Generic.IList<global::Microsoft.Graph.appRole>))

                {

                    this._appRoles = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.appRole>();

                    this._appRoles.SetContainer(() => GetContainingEntity("appRoles"));

                }

                return this._appRoles;

            }

            set

            {

                appRoles.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        appRoles.Add(i);

                    }

                }

            }

        }

        public System.String displayName

        {

            get

            {

                return _displayName;

            }

            set

            {

                if (value != _displayName)

                {

                    _displayName = value;

                    OnPropertyChanged("displayName");

                }

            }

        }

        public System.String errorUrl

        {

            get

            {

                return _errorUrl;

            }

            set

            {

                if (value != _errorUrl)

                {

                    _errorUrl = value;

                    OnPropertyChanged("errorUrl");

                }

            }

        }

        public System.String homepage

        {

            get

            {

                return _homepage;

            }

            set

            {

                if (value != _homepage)

                {

                    _homepage = value;

                    OnPropertyChanged("homepage");

                }

            }

        }

        public System.Collections.Generic.IList<global::Microsoft.Graph.keyCredential> keyCredentials

        {

            get

            {

                if (this._keyCredentials == default(System.Collections.Generic.IList<global::Microsoft.Graph.keyCredential>))

                {

                    this._keyCredentials = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.keyCredential>();

                    this._keyCredentials.SetContainer(() => GetContainingEntity("keyCredentials"));

                }

                return this._keyCredentials;

            }

            set

            {

                keyCredentials.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        keyCredentials.Add(i);

                    }

                }

            }

        }

        public System.String logoutUrl

        {

            get

            {

                return _logoutUrl;

            }

            set

            {

                if (value != _logoutUrl)

                {

                    _logoutUrl = value;

                    OnPropertyChanged("logoutUrl");

                }

            }

        }

        public System.Collections.Generic.IList<global::Microsoft.Graph.oAuth2Permission> oauth2Permissions

        {

            get

            {

                if (this._oauth2Permissions == default(System.Collections.Generic.IList<global::Microsoft.Graph.oAuth2Permission>))

                {

                    this._oauth2Permissions = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.oAuth2Permission>();

                    this._oauth2Permissions.SetContainer(() => GetContainingEntity("oauth2Permissions"));

                }

                return this._oauth2Permissions;

            }

            set

            {

                oauth2Permissions.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        oauth2Permissions.Add(i);

                    }

                }

            }

        }

        public System.Collections.Generic.IList<global::Microsoft.Graph.passwordCredential> passwordCredentials

        {

            get

            {

                if (this._passwordCredentials == default(System.Collections.Generic.IList<global::Microsoft.Graph.passwordCredential>))

                {

                    this._passwordCredentials = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.passwordCredential>();

                    this._passwordCredentials.SetContainer(() => GetContainingEntity("passwordCredentials"));

                }

                return this._passwordCredentials;

            }

            set

            {

                passwordCredentials.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        passwordCredentials.Add(i);

                    }

                }

            }

        }

        public System.String preferredTokenSigningKeyThumbprint

        {

            get

            {

                return _preferredTokenSigningKeyThumbprint;

            }

            set

            {

                if (value != _preferredTokenSigningKeyThumbprint)

                {

                    _preferredTokenSigningKeyThumbprint = value;

                    OnPropertyChanged("preferredTokenSigningKeyThumbprint");

                }

            }

        }

        public System.String publisherName

        {

            get

            {

                return _publisherName;

            }

            set

            {

                if (value != _publisherName)

                {

                    _publisherName = value;

                    OnPropertyChanged("publisherName");

                }

            }

        }

        public System.Collections.Generic.IList<System.String> replyUrls

        {

            get

            {

                if (this._replyUrls == default(System.Collections.Generic.IList<System.String>))

                {

                    this._replyUrls = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.String>();

                    this._replyUrls.SetContainer(() => GetContainingEntity("replyUrls"));

                }

                return this._replyUrls;

            }

            set

            {

                replyUrls.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        replyUrls.Add(i);

                    }

                }

            }

        }

        public System.String samlMetadataUrl

        {

            get

            {

                return _samlMetadataUrl;

            }

            set

            {

                if (value != _samlMetadataUrl)

                {

                    _samlMetadataUrl = value;

                    OnPropertyChanged("samlMetadataUrl");

                }

            }

        }

        public System.Collections.Generic.IList<System.String> servicePrincipalNames

        {

            get

            {

                if (this._servicePrincipalNames == default(System.Collections.Generic.IList<System.String>))

                {

                    this._servicePrincipalNames = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.String>();

                    this._servicePrincipalNames.SetContainer(() => GetContainingEntity("servicePrincipalNames"));

                }

                return this._servicePrincipalNames;

            }

            set

            {

                servicePrincipalNames.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        servicePrincipalNames.Add(i);

                    }

                }

            }

        }

        public System.Collections.Generic.IList<System.String> tags

        {

            get

            {

                if (this._tags == default(System.Collections.Generic.IList<System.String>))

                {

                    this._tags = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.String>();

                    this._tags.SetContainer(() => GetContainingEntity("tags"));

                }

                return this._tags;

            }

            set

            {

                tags.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        tags.Add(i);

                    }

                }

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.IappRoleAssignment> global::Microsoft.Graph.IservicePrincipal.appRoleAssignedTo

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.IappRoleAssignment, global::Microsoft.Graph.appRoleAssignment>(Context, (DataServiceCollection<global::Microsoft.Graph.appRoleAssignment>) appRoleAssignedTo);

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.IappRoleAssignment> global::Microsoft.Graph.IservicePrincipal.appRoleAssignments

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.IappRoleAssignment, global::Microsoft.Graph.appRoleAssignment>(Context, (DataServiceCollection<global::Microsoft.Graph.appRoleAssignment>) appRoleAssignments);

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.IoAuth2PermissionGrant> global::Microsoft.Graph.IservicePrincipal.oauth2PermissionGrants

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.IoAuth2PermissionGrant, global::Microsoft.Graph.oAuth2PermissionGrant>(Context, (DataServiceCollection<global::Microsoft.Graph.oAuth2PermissionGrant>) oauth2PermissionGrants);

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.IdirectoryObject> global::Microsoft.Graph.IservicePrincipal.memberOf

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.IdirectoryObject, global::Microsoft.Graph.directoryObject>(Context, (DataServiceCollection<global::Microsoft.Graph.directoryObject>) memberOf);

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.IdirectoryObject> global::Microsoft.Graph.IservicePrincipal.createdObjects

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.IdirectoryObject, global::Microsoft.Graph.directoryObject>(Context, (DataServiceCollection<global::Microsoft.Graph.directoryObject>) createdObjects);

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.IdirectoryObject> global::Microsoft.Graph.IservicePrincipal.owners

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.IdirectoryObject, global::Microsoft.Graph.directoryObject>(Context, (DataServiceCollection<global::Microsoft.Graph.directoryObject>) owners);

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.IdirectoryObject> global::Microsoft.Graph.IservicePrincipal.ownedObjects

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.IdirectoryObject, global::Microsoft.Graph.directoryObject>(Context, (DataServiceCollection<global::Microsoft.Graph.directoryObject>) ownedObjects);

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.appRoleAssignment> appRoleAssignedTo

        {

            get

            {

                if (this._appRoleAssignedToConcrete == null)

                {

                    this._appRoleAssignedToConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.appRoleAssignment>();

                    this._appRoleAssignedToConcrete.SetContainer(() => GetContainingEntity("appRoleAssignedTo"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.appRoleAssignment>)this._appRoleAssignedToConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                appRoleAssignedTo.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        appRoleAssignedTo.Add(i);

                    }

                }

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.appRoleAssignment> appRoleAssignments

        {

            get

            {

                if (this._appRoleAssignmentsConcrete == null)

                {

                    this._appRoleAssignmentsConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.appRoleAssignment>();

                    this._appRoleAssignmentsConcrete.SetContainer(() => GetContainingEntity("appRoleAssignments"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.appRoleAssignment>)this._appRoleAssignmentsConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                appRoleAssignments.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        appRoleAssignments.Add(i);

                    }

                }

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.oAuth2PermissionGrant> oauth2PermissionGrants

        {

            get

            {

                if (this._oauth2PermissionGrantsConcrete == null)

                {

                    this._oauth2PermissionGrantsConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.oAuth2PermissionGrant>();

                    this._oauth2PermissionGrantsConcrete.SetContainer(() => GetContainingEntity("oauth2PermissionGrants"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.oAuth2PermissionGrant>)this._oauth2PermissionGrantsConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                oauth2PermissionGrants.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        oauth2PermissionGrants.Add(i);

                    }

                }

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.directoryObject> memberOf

        {

            get

            {

                if (this._memberOfConcrete == null)

                {

                    this._memberOfConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.directoryObject>();

                    this._memberOfConcrete.SetContainer(() => GetContainingEntity("memberOf"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.directoryObject>)this._memberOfConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                memberOf.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        memberOf.Add(i);

                    }

                }

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.directoryObject> createdObjects

        {

            get

            {

                if (this._createdObjectsConcrete == null)

                {

                    this._createdObjectsConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.directoryObject>();

                    this._createdObjectsConcrete.SetContainer(() => GetContainingEntity("createdObjects"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.directoryObject>)this._createdObjectsConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                createdObjects.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        createdObjects.Add(i);

                    }

                }

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.directoryObject> owners

        {

            get

            {

                if (this._ownersConcrete == null)

                {

                    this._ownersConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.directoryObject>();

                    this._ownersConcrete.SetContainer(() => GetContainingEntity("owners"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.directoryObject>)this._ownersConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                owners.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        owners.Add(i);

                    }

                }

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.directoryObject> ownedObjects

        {

            get

            {

                if (this._ownedObjectsConcrete == null)

                {

                    this._ownedObjectsConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.directoryObject>();

                    this._ownedObjectsConcrete.SetContainer(() => GetContainingEntity("ownedObjects"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.directoryObject>)this._ownedObjectsConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                ownedObjects.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        ownedObjects.Add(i);

                    }

                }

            }

        }

        global::Microsoft.Graph.IappRoleAssignmentCollection global::Microsoft.Graph.IservicePrincipalFetcher.appRoleAssignedTo

        {

            get

            {

                if (this._appRoleAssignedToCollection == null)

                {

                    this._appRoleAssignedToCollection = new global::Microsoft.Graph.appRoleAssignmentCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.appRoleAssignment>(GetPath("appRoleAssignedTo")) : null,
                       Context,
                       this,
                       GetPath("appRoleAssignedTo"));

                }

                

                return this._appRoleAssignedToCollection;

            }

        }

        global::Microsoft.Graph.IappRoleAssignmentCollection global::Microsoft.Graph.IservicePrincipalFetcher.appRoleAssignments

        {

            get

            {

                if (this._appRoleAssignmentsCollection == null)

                {

                    this._appRoleAssignmentsCollection = new global::Microsoft.Graph.appRoleAssignmentCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.appRoleAssignment>(GetPath("appRoleAssignments")) : null,
                       Context,
                       this,
                       GetPath("appRoleAssignments"));

                }

                

                return this._appRoleAssignmentsCollection;

            }

        }

        global::Microsoft.Graph.IoAuth2PermissionGrantCollection global::Microsoft.Graph.IservicePrincipalFetcher.oauth2PermissionGrants

        {

            get

            {

                if (this._oauth2PermissionGrantsCollection == null)

                {

                    this._oauth2PermissionGrantsCollection = new global::Microsoft.Graph.oAuth2PermissionGrantCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.oAuth2PermissionGrant>(GetPath("oauth2PermissionGrants")) : null,
                       Context,
                       this,
                       GetPath("oauth2PermissionGrants"));

                }

                

                return this._oauth2PermissionGrantsCollection;

            }

        }

        global::Microsoft.Graph.IdirectoryObjectCollection global::Microsoft.Graph.IservicePrincipalFetcher.memberOf

        {

            get

            {

                if (this._memberOfCollection == null)

                {

                    this._memberOfCollection = new global::Microsoft.Graph.directoryObjectCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.directoryObject>(GetPath("memberOf")) : null,
                       Context,
                       this,
                       GetPath("memberOf"));

                }

                

                return this._memberOfCollection;

            }

        }

        global::Microsoft.Graph.IdirectoryObjectCollection global::Microsoft.Graph.IservicePrincipalFetcher.createdObjects

        {

            get

            {

                if (this._createdObjectsCollection == null)

                {

                    this._createdObjectsCollection = new global::Microsoft.Graph.directoryObjectCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.directoryObject>(GetPath("createdObjects")) : null,
                       Context,
                       this,
                       GetPath("createdObjects"));

                }

                

                return this._createdObjectsCollection;

            }

        }

        global::Microsoft.Graph.IdirectoryObjectCollection global::Microsoft.Graph.IservicePrincipalFetcher.owners

        {

            get

            {

                if (this._ownersCollection == null)

                {

                    this._ownersCollection = new global::Microsoft.Graph.directoryObjectCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.directoryObject>(GetPath("owners")) : null,
                       Context,
                       this,
                       GetPath("owners"));

                }

                

                return this._ownersCollection;

            }

        }

        global::Microsoft.Graph.IdirectoryObjectCollection global::Microsoft.Graph.IservicePrincipalFetcher.ownedObjects

        {

            get

            {

                if (this._ownedObjectsCollection == null)

                {

                    this._ownedObjectsCollection = new global::Microsoft.Graph.directoryObjectCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.directoryObject>(GetPath("ownedObjects")) : null,
                       Context,
                       this,
                       GetPath("ownedObjects"));

                }

                

                return this._ownedObjectsCollection;

            }

        }

        public servicePrincipal()

        {

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IservicePrincipal> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.servicePrincipal, global::Microsoft.Graph.IservicePrincipal>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IservicePrincipal> _query;

        global::System.Threading.Tasks.Task<global::Microsoft.Graph.IservicePrincipal> global::Microsoft.Graph.IservicePrincipalFetcher.ExecuteAsync()

        {

            var tsc = new global::System.Threading.Tasks.TaskCompletionSource<global::Microsoft.Graph.IservicePrincipal>();

            tsc.SetResult(this);

            return tsc.Task;

        }

        global::Microsoft.Graph.IservicePrincipalFetcher global::Microsoft.Graph.IservicePrincipalFetcher.Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.IservicePrincipal, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IservicePrincipalFetcher) this;

        }

    }

    internal partial class servicePrincipalFetcher:global::Microsoft.Graph.directoryObjectFetcher, global::Microsoft.Graph.IservicePrincipalFetcher

    {

        private global::Microsoft.Graph.appRoleAssignmentCollection _appRoleAssignedToCollection;

        private global::Microsoft.Graph.appRoleAssignmentCollection _appRoleAssignmentsCollection;

        private global::Microsoft.Graph.oAuth2PermissionGrantCollection _oauth2PermissionGrantsCollection;

        private global::Microsoft.Graph.directoryObjectCollection _memberOfCollection;

        private global::Microsoft.Graph.directoryObjectCollection _createdObjectsCollection;

        private global::Microsoft.Graph.directoryObjectCollection _ownersCollection;

        private global::Microsoft.Graph.directoryObjectCollection _ownedObjectsCollection;

        public global::Microsoft.Graph.IappRoleAssignmentCollection appRoleAssignedTo

        {

            get

            {

                if (this._appRoleAssignedToCollection == null)

                {

                    this._appRoleAssignedToCollection = new global::Microsoft.Graph.appRoleAssignmentCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.appRoleAssignment>(GetPath("appRoleAssignedTo")) : null,
                       Context,
                       this,
                       GetPath("appRoleAssignedTo"));

                }

                

                return this._appRoleAssignedToCollection;

            }

        }

        public global::Microsoft.Graph.IappRoleAssignmentCollection appRoleAssignments

        {

            get

            {

                if (this._appRoleAssignmentsCollection == null)

                {

                    this._appRoleAssignmentsCollection = new global::Microsoft.Graph.appRoleAssignmentCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.appRoleAssignment>(GetPath("appRoleAssignments")) : null,
                       Context,
                       this,
                       GetPath("appRoleAssignments"));

                }

                

                return this._appRoleAssignmentsCollection;

            }

        }

        public global::Microsoft.Graph.IoAuth2PermissionGrantCollection oauth2PermissionGrants

        {

            get

            {

                if (this._oauth2PermissionGrantsCollection == null)

                {

                    this._oauth2PermissionGrantsCollection = new global::Microsoft.Graph.oAuth2PermissionGrantCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.oAuth2PermissionGrant>(GetPath("oauth2PermissionGrants")) : null,
                       Context,
                       this,
                       GetPath("oauth2PermissionGrants"));

                }

                

                return this._oauth2PermissionGrantsCollection;

            }

        }

        public global::Microsoft.Graph.IdirectoryObjectCollection memberOf

        {

            get

            {

                if (this._memberOfCollection == null)

                {

                    this._memberOfCollection = new global::Microsoft.Graph.directoryObjectCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.directoryObject>(GetPath("memberOf")) : null,
                       Context,
                       this,
                       GetPath("memberOf"));

                }

                

                return this._memberOfCollection;

            }

        }

        public global::Microsoft.Graph.IdirectoryObjectCollection createdObjects

        {

            get

            {

                if (this._createdObjectsCollection == null)

                {

                    this._createdObjectsCollection = new global::Microsoft.Graph.directoryObjectCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.directoryObject>(GetPath("createdObjects")) : null,
                       Context,
                       this,
                       GetPath("createdObjects"));

                }

                

                return this._createdObjectsCollection;

            }

        }

        public global::Microsoft.Graph.IdirectoryObjectCollection owners

        {

            get

            {

                if (this._ownersCollection == null)

                {

                    this._ownersCollection = new global::Microsoft.Graph.directoryObjectCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.directoryObject>(GetPath("owners")) : null,
                       Context,
                       this,
                       GetPath("owners"));

                }

                

                return this._ownersCollection;

            }

        }

        public global::Microsoft.Graph.IdirectoryObjectCollection ownedObjects

        {

            get

            {

                if (this._ownedObjectsCollection == null)

                {

                    this._ownedObjectsCollection = new global::Microsoft.Graph.directoryObjectCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.directoryObject>(GetPath("ownedObjects")) : null,
                       Context,
                       this,
                       GetPath("ownedObjects"));

                }

                

                return this._ownedObjectsCollection;

            }

        }

        public servicePrincipalFetcher()

        {

        }

        public async new global::System.Threading.Tasks.Task<global::Microsoft.Graph.IservicePrincipal> ExecuteAsync()

        {

            return await EnsureQuery().ExecuteSingleAsync();

        }

        public global::Microsoft.Graph.IservicePrincipalFetcher Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.IservicePrincipal, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IservicePrincipalFetcher) new global::Microsoft.Graph.servicePrincipalFetcher()

            {

                _query = this.EnsureQuery().Expand<TTarget>(navigationPropertyAccessor)

            }

            ;

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IservicePrincipal> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.servicePrincipal, global::Microsoft.Graph.IservicePrincipal>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IservicePrincipal> _query;

    }

    internal partial class servicePrincipalCollection:Microsoft.OData.ProxyExtensions.QueryableSet<global::Microsoft.Graph.IservicePrincipal>, global::Microsoft.Graph.IservicePrincipalCollection

    {

        internal servicePrincipalCollection(global::Microsoft.OData.Client.DataServiceQuery inner,Microsoft.OData.ProxyExtensions.DataServiceContextWrapper context,object entity,string path): base(inner, context, entity as Microsoft.OData.ProxyExtensions.EntityBase, path)

        {

        }

        public global::Microsoft.Graph.IservicePrincipalFetcher GetById(System.String id)

        {

            return this[id];

        }

        public global::System.Threading.Tasks.Task<Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.IservicePrincipal>> ExecuteAsync()

        {

            return ExecuteAsyncInternal();

        }

        public global::System.Threading.Tasks.Task AddservicePrincipalAsync(global::Microsoft.Graph.IservicePrincipal item, System.Boolean deferSaveChanges = false)

        {

            if (Entity == null)

            {

                Context.AddObject(Path, item);

            }

            else

            {

                var lastSlash = Path.LastIndexOf('/');

                var shortPath = (lastSlash >= 0 && lastSlash < Path.Length - 1) ? Path.Substring(lastSlash + 1) : Path;

                Context.AddRelatedObject(Entity, shortPath, item);

            }

            if (!deferSaveChanges)

            {

                return Context.SaveChangesAsync();

            }

            else

            {

                var retVal = new global::System.Threading.Tasks.TaskCompletionSource<object>();

                retVal.SetResult(null);

                return retVal.Task;

            }

        }

        public global::Microsoft.Graph.IservicePrincipalFetcher this[System.String id]

        {

            get

            {

                var path = GetPath<global::Microsoft.Graph.servicePrincipal>((i) => i.id == id);

                var fetcher = new global::Microsoft.Graph.servicePrincipalFetcher();

                fetcher.Initialize(Context, path);

                

                return fetcher;

            }

        }

    }

    internal partial class servicePrincipalCollection

    {

        public global::System.Threading.Tasks.Task<System.Int64> CountAsync()

        {

            return new DataServiceQuerySingle<long>(Context, Path + "/$count").GetValueAsync();

        }

    }

    [global::Microsoft.OData.Client.Key("id")]

    public partial class subscribedSku:Microsoft.OData.ProxyExtensions.EntityBase, global::Microsoft.Graph.IsubscribedSku, global::Microsoft.Graph.IsubscribedSkuFetcher

    {

        private System.String _capabilityStatus;

        private System.Nullable<System.Int32> _consumedUnits;

        private System.String _id;

        private global::Microsoft.Graph.licenseUnitsDetail _prepaidUnits;

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.servicePlanInfo> _servicePlans;

        private System.Nullable<System.Guid> _skuId;

        private System.String _skuPartNumber;

        private System.String _appliesTo;

        public System.String capabilityStatus

        {

            get

            {

                return _capabilityStatus;

            }

            set

            {

                if (value != _capabilityStatus)

                {

                    _capabilityStatus = value;

                    OnPropertyChanged("capabilityStatus");

                }

            }

        }

        public System.Nullable<System.Int32> consumedUnits

        {

            get

            {

                return _consumedUnits;

            }

            set

            {

                if (value != _consumedUnits)

                {

                    _consumedUnits = value;

                    OnPropertyChanged("consumedUnits");

                }

            }

        }

        public System.String id

        {

            get

            {

                return _id;

            }

            set

            {

                if (value != _id)

                {

                    _id = value;

                    OnPropertyChanged("id");

                }

            }

        }

        public global::Microsoft.Graph.licenseUnitsDetail prepaidUnits

        {

            get

            {

                return _prepaidUnits;

            }

            set

            {

                if (value != _prepaidUnits)

                {

                    _prepaidUnits = value;

                    OnPropertyChanged("prepaidUnits");

                }

            }

        }

        public System.Collections.Generic.IList<global::Microsoft.Graph.servicePlanInfo> servicePlans

        {

            get

            {

                if (this._servicePlans == default(System.Collections.Generic.IList<global::Microsoft.Graph.servicePlanInfo>))

                {

                    this._servicePlans = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.servicePlanInfo>();

                    this._servicePlans.SetContainer(() => GetContainingEntity("servicePlans"));

                }

                return this._servicePlans;

            }

            set

            {

                servicePlans.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        servicePlans.Add(i);

                    }

                }

            }

        }

        public System.Nullable<System.Guid> skuId

        {

            get

            {

                return _skuId;

            }

            set

            {

                if (value != _skuId)

                {

                    _skuId = value;

                    OnPropertyChanged("skuId");

                }

            }

        }

        public System.String skuPartNumber

        {

            get

            {

                return _skuPartNumber;

            }

            set

            {

                if (value != _skuPartNumber)

                {

                    _skuPartNumber = value;

                    OnPropertyChanged("skuPartNumber");

                }

            }

        }

        public System.String appliesTo

        {

            get

            {

                return _appliesTo;

            }

            set

            {

                if (value != _appliesTo)

                {

                    _appliesTo = value;

                    OnPropertyChanged("appliesTo");

                }

            }

        }

        public subscribedSku(): base()

        {

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IsubscribedSku> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.subscribedSku, global::Microsoft.Graph.IsubscribedSku>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IsubscribedSku> _query;

        global::System.Threading.Tasks.Task<global::Microsoft.Graph.IsubscribedSku> global::Microsoft.Graph.IsubscribedSkuFetcher.ExecuteAsync()

        {

            var tsc = new global::System.Threading.Tasks.TaskCompletionSource<global::Microsoft.Graph.IsubscribedSku>();

            tsc.SetResult(this);

            return tsc.Task;

        }

        global::Microsoft.Graph.IsubscribedSkuFetcher global::Microsoft.Graph.IsubscribedSkuFetcher.Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.IsubscribedSku, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IsubscribedSkuFetcher) this;

        }

    }

    internal partial class subscribedSkuFetcher:Microsoft.OData.ProxyExtensions.RestShallowObjectFetcher, global::Microsoft.Graph.IsubscribedSkuFetcher

    {

        public subscribedSkuFetcher(): base()

        {

        }

        public async global::System.Threading.Tasks.Task<global::Microsoft.Graph.IsubscribedSku> ExecuteAsync()

        {

            return await EnsureQuery().ExecuteSingleAsync();

        }

        public global::Microsoft.Graph.IsubscribedSkuFetcher Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.IsubscribedSku, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IsubscribedSkuFetcher) new global::Microsoft.Graph.subscribedSkuFetcher()

            {

                _query = this.EnsureQuery().Expand<TTarget>(navigationPropertyAccessor)

            }

            ;

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IsubscribedSku> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.subscribedSku, global::Microsoft.Graph.IsubscribedSku>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IsubscribedSku> _query;

    }

    internal partial class subscribedSkuCollection:Microsoft.OData.ProxyExtensions.QueryableSet<global::Microsoft.Graph.IsubscribedSku>, global::Microsoft.Graph.IsubscribedSkuCollection

    {

        internal subscribedSkuCollection(global::Microsoft.OData.Client.DataServiceQuery inner,Microsoft.OData.ProxyExtensions.DataServiceContextWrapper context,object entity,string path): base(inner, context, entity as Microsoft.OData.ProxyExtensions.EntityBase, path)

        {

        }

        public global::Microsoft.Graph.IsubscribedSkuFetcher GetById(System.String id)

        {

            return this[id];

        }

        public global::System.Threading.Tasks.Task<Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.IsubscribedSku>> ExecuteAsync()

        {

            return ExecuteAsyncInternal();

        }

        public global::System.Threading.Tasks.Task AddsubscribedSkuAsync(global::Microsoft.Graph.IsubscribedSku item, System.Boolean deferSaveChanges = false)

        {

            if (Entity == null)

            {

                Context.AddObject(Path, item);

            }

            else

            {

                var lastSlash = Path.LastIndexOf('/');

                var shortPath = (lastSlash >= 0 && lastSlash < Path.Length - 1) ? Path.Substring(lastSlash + 1) : Path;

                Context.AddRelatedObject(Entity, shortPath, item);

            }

            if (!deferSaveChanges)

            {

                return Context.SaveChangesAsync();

            }

            else

            {

                var retVal = new global::System.Threading.Tasks.TaskCompletionSource<object>();

                retVal.SetResult(null);

                return retVal.Task;

            }

        }

        public global::Microsoft.Graph.IsubscribedSkuFetcher this[System.String id]

        {

            get

            {

                var path = GetPath<global::Microsoft.Graph.subscribedSku>((i) => i.id == id);

                var fetcher = new global::Microsoft.Graph.subscribedSkuFetcher();

                fetcher.Initialize(Context, path);

                

                return fetcher;

            }

        }

    }

    internal partial class subscribedSkuCollection

    {

        public global::System.Threading.Tasks.Task<System.Int64> CountAsync()

        {

            return new DataServiceQuerySingle<long>(Context, Path + "/$count").GetValueAsync();

        }

    }

    internal partial class subscribedSkuFetcher

    {

    }

    public partial class subscribedSku

    {

    }

    [global::Microsoft.OData.Client.Key("id")]

    public partial class organization:global::Microsoft.Graph.directoryObject, global::Microsoft.Graph.Iorganization, global::Microsoft.Graph.IorganizationFetcher

    {

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.assignedPlan> _assignedPlans;

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.String> _businessPhones;

        private System.String _city;

        private System.String _country;

        private System.String _countryLetterCode;

        private System.String _displayName;

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.String> _marketingNotificationEmails;

        private System.Nullable<System.DateTimeOffset> _onPremisesLastSyncDateTime;

        private System.Nullable<System.Boolean> _onPremisesSyncEnabled;

        private System.String _postalCode;

        private System.String _preferredLanguage;

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.provisionedPlan> _provisionedPlans;

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.String> _securityComplianceNotificationMails;

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.String> _securityComplianceNotificationPhones;

        private System.String _state;

        private System.String _street;

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.String> _technicalNotificationMails;

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.verifiedDomain> _verifiedDomains;

        public System.Collections.Generic.IList<global::Microsoft.Graph.assignedPlan> assignedPlans

        {

            get

            {

                if (this._assignedPlans == default(System.Collections.Generic.IList<global::Microsoft.Graph.assignedPlan>))

                {

                    this._assignedPlans = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.assignedPlan>();

                    this._assignedPlans.SetContainer(() => GetContainingEntity("assignedPlans"));

                }

                return this._assignedPlans;

            }

            set

            {

                assignedPlans.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        assignedPlans.Add(i);

                    }

                }

            }

        }

        public System.Collections.Generic.IList<System.String> businessPhones

        {

            get

            {

                if (this._businessPhones == default(System.Collections.Generic.IList<System.String>))

                {

                    this._businessPhones = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.String>();

                    this._businessPhones.SetContainer(() => GetContainingEntity("businessPhones"));

                }

                return this._businessPhones;

            }

            set

            {

                businessPhones.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        businessPhones.Add(i);

                    }

                }

            }

        }

        public System.String city

        {

            get

            {

                return _city;

            }

            set

            {

                if (value != _city)

                {

                    _city = value;

                    OnPropertyChanged("city");

                }

            }

        }

        public System.String country

        {

            get

            {

                return _country;

            }

            set

            {

                if (value != _country)

                {

                    _country = value;

                    OnPropertyChanged("country");

                }

            }

        }

        public System.String countryLetterCode

        {

            get

            {

                return _countryLetterCode;

            }

            set

            {

                if (value != _countryLetterCode)

                {

                    _countryLetterCode = value;

                    OnPropertyChanged("countryLetterCode");

                }

            }

        }

        public System.String displayName

        {

            get

            {

                return _displayName;

            }

            set

            {

                if (value != _displayName)

                {

                    _displayName = value;

                    OnPropertyChanged("displayName");

                }

            }

        }

        public System.Collections.Generic.IList<System.String> marketingNotificationEmails

        {

            get

            {

                if (this._marketingNotificationEmails == default(System.Collections.Generic.IList<System.String>))

                {

                    this._marketingNotificationEmails = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.String>();

                    this._marketingNotificationEmails.SetContainer(() => GetContainingEntity("marketingNotificationEmails"));

                }

                return this._marketingNotificationEmails;

            }

            set

            {

                marketingNotificationEmails.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        marketingNotificationEmails.Add(i);

                    }

                }

            }

        }

        public System.Nullable<System.DateTimeOffset> onPremisesLastSyncDateTime

        {

            get

            {

                return _onPremisesLastSyncDateTime;

            }

            set

            {

                if (value != _onPremisesLastSyncDateTime)

                {

                    _onPremisesLastSyncDateTime = value;

                    OnPropertyChanged("onPremisesLastSyncDateTime");

                }

            }

        }

        public System.Nullable<System.Boolean> onPremisesSyncEnabled

        {

            get

            {

                return _onPremisesSyncEnabled;

            }

            set

            {

                if (value != _onPremisesSyncEnabled)

                {

                    _onPremisesSyncEnabled = value;

                    OnPropertyChanged("onPremisesSyncEnabled");

                }

            }

        }

        public System.String postalCode

        {

            get

            {

                return _postalCode;

            }

            set

            {

                if (value != _postalCode)

                {

                    _postalCode = value;

                    OnPropertyChanged("postalCode");

                }

            }

        }

        public System.String preferredLanguage

        {

            get

            {

                return _preferredLanguage;

            }

            set

            {

                if (value != _preferredLanguage)

                {

                    _preferredLanguage = value;

                    OnPropertyChanged("preferredLanguage");

                }

            }

        }

        public System.Collections.Generic.IList<global::Microsoft.Graph.provisionedPlan> provisionedPlans

        {

            get

            {

                if (this._provisionedPlans == default(System.Collections.Generic.IList<global::Microsoft.Graph.provisionedPlan>))

                {

                    this._provisionedPlans = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.provisionedPlan>();

                    this._provisionedPlans.SetContainer(() => GetContainingEntity("provisionedPlans"));

                }

                return this._provisionedPlans;

            }

            set

            {

                provisionedPlans.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        provisionedPlans.Add(i);

                    }

                }

            }

        }

        public System.Collections.Generic.IList<System.String> securityComplianceNotificationMails

        {

            get

            {

                if (this._securityComplianceNotificationMails == default(System.Collections.Generic.IList<System.String>))

                {

                    this._securityComplianceNotificationMails = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.String>();

                    this._securityComplianceNotificationMails.SetContainer(() => GetContainingEntity("securityComplianceNotificationMails"));

                }

                return this._securityComplianceNotificationMails;

            }

            set

            {

                securityComplianceNotificationMails.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        securityComplianceNotificationMails.Add(i);

                    }

                }

            }

        }

        public System.Collections.Generic.IList<System.String> securityComplianceNotificationPhones

        {

            get

            {

                if (this._securityComplianceNotificationPhones == default(System.Collections.Generic.IList<System.String>))

                {

                    this._securityComplianceNotificationPhones = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.String>();

                    this._securityComplianceNotificationPhones.SetContainer(() => GetContainingEntity("securityComplianceNotificationPhones"));

                }

                return this._securityComplianceNotificationPhones;

            }

            set

            {

                securityComplianceNotificationPhones.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        securityComplianceNotificationPhones.Add(i);

                    }

                }

            }

        }

        public System.String state

        {

            get

            {

                return _state;

            }

            set

            {

                if (value != _state)

                {

                    _state = value;

                    OnPropertyChanged("state");

                }

            }

        }

        public System.String street

        {

            get

            {

                return _street;

            }

            set

            {

                if (value != _street)

                {

                    _street = value;

                    OnPropertyChanged("street");

                }

            }

        }

        public System.Collections.Generic.IList<System.String> technicalNotificationMails

        {

            get

            {

                if (this._technicalNotificationMails == default(System.Collections.Generic.IList<System.String>))

                {

                    this._technicalNotificationMails = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.String>();

                    this._technicalNotificationMails.SetContainer(() => GetContainingEntity("technicalNotificationMails"));

                }

                return this._technicalNotificationMails;

            }

            set

            {

                technicalNotificationMails.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        technicalNotificationMails.Add(i);

                    }

                }

            }

        }

        public System.Collections.Generic.IList<global::Microsoft.Graph.verifiedDomain> verifiedDomains

        {

            get

            {

                if (this._verifiedDomains == default(System.Collections.Generic.IList<global::Microsoft.Graph.verifiedDomain>))

                {

                    this._verifiedDomains = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.verifiedDomain>();

                    this._verifiedDomains.SetContainer(() => GetContainingEntity("verifiedDomains"));

                }

                return this._verifiedDomains;

            }

            set

            {

                verifiedDomains.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        verifiedDomains.Add(i);

                    }

                }

            }

        }

        public organization()

        {

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Iorganization> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.organization, global::Microsoft.Graph.Iorganization>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Iorganization> _query;

        global::System.Threading.Tasks.Task<global::Microsoft.Graph.Iorganization> global::Microsoft.Graph.IorganizationFetcher.ExecuteAsync()

        {

            var tsc = new global::System.Threading.Tasks.TaskCompletionSource<global::Microsoft.Graph.Iorganization>();

            tsc.SetResult(this);

            return tsc.Task;

        }

        global::Microsoft.Graph.IorganizationFetcher global::Microsoft.Graph.IorganizationFetcher.Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.Iorganization, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IorganizationFetcher) this;

        }

    }

    internal partial class organizationFetcher:global::Microsoft.Graph.directoryObjectFetcher, global::Microsoft.Graph.IorganizationFetcher

    {

        public organizationFetcher()

        {

        }

        public async new global::System.Threading.Tasks.Task<global::Microsoft.Graph.Iorganization> ExecuteAsync()

        {

            return await EnsureQuery().ExecuteSingleAsync();

        }

        public global::Microsoft.Graph.IorganizationFetcher Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.Iorganization, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IorganizationFetcher) new global::Microsoft.Graph.organizationFetcher()

            {

                _query = this.EnsureQuery().Expand<TTarget>(navigationPropertyAccessor)

            }

            ;

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Iorganization> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.organization, global::Microsoft.Graph.Iorganization>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Iorganization> _query;

    }

    internal partial class organizationCollection:Microsoft.OData.ProxyExtensions.QueryableSet<global::Microsoft.Graph.Iorganization>, global::Microsoft.Graph.IorganizationCollection

    {

        internal organizationCollection(global::Microsoft.OData.Client.DataServiceQuery inner,Microsoft.OData.ProxyExtensions.DataServiceContextWrapper context,object entity,string path): base(inner, context, entity as Microsoft.OData.ProxyExtensions.EntityBase, path)

        {

        }

        public global::Microsoft.Graph.IorganizationFetcher GetById(System.String id)

        {

            return this[id];

        }

        public global::System.Threading.Tasks.Task<Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.Iorganization>> ExecuteAsync()

        {

            return ExecuteAsyncInternal();

        }

        public global::System.Threading.Tasks.Task AddorganizationAsync(global::Microsoft.Graph.Iorganization item, System.Boolean deferSaveChanges = false)

        {

            if (Entity == null)

            {

                Context.AddObject(Path, item);

            }

            else

            {

                var lastSlash = Path.LastIndexOf('/');

                var shortPath = (lastSlash >= 0 && lastSlash < Path.Length - 1) ? Path.Substring(lastSlash + 1) : Path;

                Context.AddRelatedObject(Entity, shortPath, item);

            }

            if (!deferSaveChanges)

            {

                return Context.SaveChangesAsync();

            }

            else

            {

                var retVal = new global::System.Threading.Tasks.TaskCompletionSource<object>();

                retVal.SetResult(null);

                return retVal.Task;

            }

        }

        public global::Microsoft.Graph.IorganizationFetcher this[System.String id]

        {

            get

            {

                var path = GetPath<global::Microsoft.Graph.organization>((i) => i.id == id);

                var fetcher = new global::Microsoft.Graph.organizationFetcher();

                fetcher.Initialize(Context, path);

                

                return fetcher;

            }

        }

    }

    internal partial class organizationCollection

    {

        public global::System.Threading.Tasks.Task<System.Int64> CountAsync()

        {

            return new DataServiceQuerySingle<long>(Context, Path + "/$count").GetValueAsync();

        }

    }

    [global::Microsoft.OData.Client.Key("id")]

    public partial class user:global::Microsoft.Graph.directoryObject, global::Microsoft.Graph.Iuser, global::Microsoft.Graph.IuserFetcher

    {

        private global::Microsoft.Graph.directoryObject _manager;

        private global::Microsoft.Graph.calendar _calendar;

        private global::Microsoft.Graph.inferenceClassification _inferenceClassification;

        private global::Microsoft.Graph.profilePhoto _photo;

        private global::Microsoft.Graph.drive _drive;

        private global::Microsoft.Graph.notes _notes;

        private global::Microsoft.Graph.directoryObjectFetcher _managerFetcher;

        private global::Microsoft.Graph.calendarFetcher _calendarFetcher;

        private global::Microsoft.Graph.inferenceClassificationFetcher _inferenceClassificationFetcher;

        private global::Microsoft.Graph.profilePhotoFetcher _photoFetcher;

        private global::Microsoft.Graph.driveFetcher _driveFetcher;

        private global::Microsoft.Graph.notesFetcher _notesFetcher;

        private global::Microsoft.Graph.directoryObjectCollection _ownedDevicesCollection;

        private global::Microsoft.Graph.directoryObjectCollection _registeredDevicesCollection;

        private global::Microsoft.Graph.directoryObjectCollection _directReportsCollection;

        private global::Microsoft.Graph.directoryObjectCollection _memberOfCollection;

        private global::Microsoft.Graph.directoryObjectCollection _createdObjectsCollection;

        private global::Microsoft.Graph.directoryObjectCollection _ownedObjectsCollection;

        private global::Microsoft.Graph.messageCollection _messagesCollection;

        private global::Microsoft.Graph.groupCollection _joinedGroupsCollection;

        private global::Microsoft.Graph.mailFolderCollection _mailFoldersCollection;

        private global::Microsoft.Graph.calendarCollection _calendarsCollection;

        private global::Microsoft.Graph.calendarGroupCollection _calendarGroupsCollection;

        private global::Microsoft.Graph.eventCollection _calendarViewCollection;

        private global::Microsoft.Graph.eventCollection _eventsCollection;

        private global::Microsoft.Graph.personCollection _peopleCollection;

        private global::Microsoft.Graph.contactCollection _contactsCollection;

        private global::Microsoft.Graph.contactFolderCollection _contactFoldersCollection;

        private global::Microsoft.Graph.profilePhotoCollection _photosCollection;

        private global::Microsoft.Graph.driveItemCollection _TrendingAroundCollection;

        private global::Microsoft.Graph.userCollection _WorkingWithCollection;

        private global::Microsoft.Graph.taskCollection _tasksCollection;

        private global::Microsoft.Graph.planCollection _plansCollection;

        private System.Nullable<System.Boolean> _accountEnabled;

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.assignedLicense> _assignedLicenses;

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.assignedPlan> _assignedPlans;

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.String> _businessPhones;

        private System.String _city;

        private System.String _companyName;

        private System.String _country;

        private System.String _department;

        private System.String _displayName;

        private System.String _givenName;

        private System.String _jobTitle;

        private System.String _mail;

        private System.String _mailNickname;

        private System.String _mobilePhone;

        private System.String _onPremisesImmutableId;

        private System.Nullable<System.DateTimeOffset> _onPremisesLastSyncDateTime;

        private System.String _onPremisesSecurityIdentifier;

        private System.Nullable<System.Boolean> _onPremisesSyncEnabled;

        private System.String _passwordPolicies;

        private global::Microsoft.Graph.passwordProfile _passwordProfile;

        private System.String _officeLocation;

        private System.String _postalCode;

        private System.String _preferredLanguage;

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.provisionedPlan> _provisionedPlans;

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.String> _proxyAddresses;

        private System.String _state;

        private System.String _streetAddress;

        private System.String _surname;

        private System.String _usageLocation;

        private System.String _userPrincipalName;

        private System.String _userType;

        private System.String _aboutMe;

        private System.DateTimeOffset _birthday;

        private System.DateTimeOffset _hireDate;

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.String> _interests;

        private System.String _mySite;

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.String> _pastProjects;

        private System.String _preferredName;

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.String> _responsibilities;

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.String> _schools;

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.String> _skills;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.directoryObject> _ownedDevicesConcrete;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.directoryObject> _registeredDevicesConcrete;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.directoryObject> _directReportsConcrete;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.directoryObject> _memberOfConcrete;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.directoryObject> _createdObjectsConcrete;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.directoryObject> _ownedObjectsConcrete;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.message> _messagesConcrete;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.group> _joinedGroupsConcrete;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.mailFolder> _mailFoldersConcrete;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.calendar> _calendarsConcrete;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.calendarGroup> _calendarGroupsConcrete;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.Event> _calendarViewConcrete;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.Event> _eventsConcrete;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.person> _peopleConcrete;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.contact> _contactsConcrete;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.contactFolder> _contactFoldersConcrete;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.profilePhoto> _photosConcrete;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.driveItem> _TrendingAroundConcrete;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.user> _WorkingWithConcrete;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.task> _tasksConcrete;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.plan> _plansConcrete;

        public System.Nullable<System.Boolean> accountEnabled

        {

            get

            {

                return _accountEnabled;

            }

            set

            {

                if (value != _accountEnabled)

                {

                    _accountEnabled = value;

                    OnPropertyChanged("accountEnabled");

                }

            }

        }

        public System.Collections.Generic.IList<global::Microsoft.Graph.assignedLicense> assignedLicenses

        {

            get

            {

                if (this._assignedLicenses == default(System.Collections.Generic.IList<global::Microsoft.Graph.assignedLicense>))

                {

                    this._assignedLicenses = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.assignedLicense>();

                    this._assignedLicenses.SetContainer(() => GetContainingEntity("assignedLicenses"));

                }

                return this._assignedLicenses;

            }

            set

            {

                assignedLicenses.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        assignedLicenses.Add(i);

                    }

                }

            }

        }

        public System.Collections.Generic.IList<global::Microsoft.Graph.assignedPlan> assignedPlans

        {

            get

            {

                if (this._assignedPlans == default(System.Collections.Generic.IList<global::Microsoft.Graph.assignedPlan>))

                {

                    this._assignedPlans = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.assignedPlan>();

                    this._assignedPlans.SetContainer(() => GetContainingEntity("assignedPlans"));

                }

                return this._assignedPlans;

            }

            set

            {

                assignedPlans.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        assignedPlans.Add(i);

                    }

                }

            }

        }

        public System.Collections.Generic.IList<System.String> businessPhones

        {

            get

            {

                if (this._businessPhones == default(System.Collections.Generic.IList<System.String>))

                {

                    this._businessPhones = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.String>();

                    this._businessPhones.SetContainer(() => GetContainingEntity("businessPhones"));

                }

                return this._businessPhones;

            }

            set

            {

                businessPhones.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        businessPhones.Add(i);

                    }

                }

            }

        }

        public System.String city

        {

            get

            {

                return _city;

            }

            set

            {

                if (value != _city)

                {

                    _city = value;

                    OnPropertyChanged("city");

                }

            }

        }

        public System.String companyName

        {

            get

            {

                return _companyName;

            }

            set

            {

                if (value != _companyName)

                {

                    _companyName = value;

                    OnPropertyChanged("companyName");

                }

            }

        }

        public System.String country

        {

            get

            {

                return _country;

            }

            set

            {

                if (value != _country)

                {

                    _country = value;

                    OnPropertyChanged("country");

                }

            }

        }

        public System.String department

        {

            get

            {

                return _department;

            }

            set

            {

                if (value != _department)

                {

                    _department = value;

                    OnPropertyChanged("department");

                }

            }

        }

        public System.String displayName

        {

            get

            {

                return _displayName;

            }

            set

            {

                if (value != _displayName)

                {

                    _displayName = value;

                    OnPropertyChanged("displayName");

                }

            }

        }

        public System.String givenName

        {

            get

            {

                return _givenName;

            }

            set

            {

                if (value != _givenName)

                {

                    _givenName = value;

                    OnPropertyChanged("givenName");

                }

            }

        }

        public System.String jobTitle

        {

            get

            {

                return _jobTitle;

            }

            set

            {

                if (value != _jobTitle)

                {

                    _jobTitle = value;

                    OnPropertyChanged("jobTitle");

                }

            }

        }

        public System.String mail

        {

            get

            {

                return _mail;

            }

            set

            {

                if (value != _mail)

                {

                    _mail = value;

                    OnPropertyChanged("mail");

                }

            }

        }

        public System.String mailNickname

        {

            get

            {

                return _mailNickname;

            }

            set

            {

                if (value != _mailNickname)

                {

                    _mailNickname = value;

                    OnPropertyChanged("mailNickname");

                }

            }

        }

        public System.String mobilePhone

        {

            get

            {

                return _mobilePhone;

            }

            set

            {

                if (value != _mobilePhone)

                {

                    _mobilePhone = value;

                    OnPropertyChanged("mobilePhone");

                }

            }

        }

        public System.String onPremisesImmutableId

        {

            get

            {

                return _onPremisesImmutableId;

            }

            set

            {

                if (value != _onPremisesImmutableId)

                {

                    _onPremisesImmutableId = value;

                    OnPropertyChanged("onPremisesImmutableId");

                }

            }

        }

        public System.Nullable<System.DateTimeOffset> onPremisesLastSyncDateTime

        {

            get

            {

                return _onPremisesLastSyncDateTime;

            }

            set

            {

                if (value != _onPremisesLastSyncDateTime)

                {

                    _onPremisesLastSyncDateTime = value;

                    OnPropertyChanged("onPremisesLastSyncDateTime");

                }

            }

        }

        public System.String onPremisesSecurityIdentifier

        {

            get

            {

                return _onPremisesSecurityIdentifier;

            }

            set

            {

                if (value != _onPremisesSecurityIdentifier)

                {

                    _onPremisesSecurityIdentifier = value;

                    OnPropertyChanged("onPremisesSecurityIdentifier");

                }

            }

        }

        public System.Nullable<System.Boolean> onPremisesSyncEnabled

        {

            get

            {

                return _onPremisesSyncEnabled;

            }

            set

            {

                if (value != _onPremisesSyncEnabled)

                {

                    _onPremisesSyncEnabled = value;

                    OnPropertyChanged("onPremisesSyncEnabled");

                }

            }

        }

        public System.String passwordPolicies

        {

            get

            {

                return _passwordPolicies;

            }

            set

            {

                if (value != _passwordPolicies)

                {

                    _passwordPolicies = value;

                    OnPropertyChanged("passwordPolicies");

                }

            }

        }

        public global::Microsoft.Graph.passwordProfile passwordProfile

        {

            get

            {

                return _passwordProfile;

            }

            set

            {

                if (value != _passwordProfile)

                {

                    _passwordProfile = value;

                    OnPropertyChanged("passwordProfile");

                }

            }

        }

        public System.String officeLocation

        {

            get

            {

                return _officeLocation;

            }

            set

            {

                if (value != _officeLocation)

                {

                    _officeLocation = value;

                    OnPropertyChanged("officeLocation");

                }

            }

        }

        public System.String postalCode

        {

            get

            {

                return _postalCode;

            }

            set

            {

                if (value != _postalCode)

                {

                    _postalCode = value;

                    OnPropertyChanged("postalCode");

                }

            }

        }

        public System.String preferredLanguage

        {

            get

            {

                return _preferredLanguage;

            }

            set

            {

                if (value != _preferredLanguage)

                {

                    _preferredLanguage = value;

                    OnPropertyChanged("preferredLanguage");

                }

            }

        }

        public System.Collections.Generic.IList<global::Microsoft.Graph.provisionedPlan> provisionedPlans

        {

            get

            {

                if (this._provisionedPlans == default(System.Collections.Generic.IList<global::Microsoft.Graph.provisionedPlan>))

                {

                    this._provisionedPlans = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.provisionedPlan>();

                    this._provisionedPlans.SetContainer(() => GetContainingEntity("provisionedPlans"));

                }

                return this._provisionedPlans;

            }

            set

            {

                provisionedPlans.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        provisionedPlans.Add(i);

                    }

                }

            }

        }

        public System.Collections.Generic.IList<System.String> proxyAddresses

        {

            get

            {

                if (this._proxyAddresses == default(System.Collections.Generic.IList<System.String>))

                {

                    this._proxyAddresses = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.String>();

                    this._proxyAddresses.SetContainer(() => GetContainingEntity("proxyAddresses"));

                }

                return this._proxyAddresses;

            }

            set

            {

                proxyAddresses.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        proxyAddresses.Add(i);

                    }

                }

            }

        }

        public System.String state

        {

            get

            {

                return _state;

            }

            set

            {

                if (value != _state)

                {

                    _state = value;

                    OnPropertyChanged("state");

                }

            }

        }

        public System.String streetAddress

        {

            get

            {

                return _streetAddress;

            }

            set

            {

                if (value != _streetAddress)

                {

                    _streetAddress = value;

                    OnPropertyChanged("streetAddress");

                }

            }

        }

        public System.String surname

        {

            get

            {

                return _surname;

            }

            set

            {

                if (value != _surname)

                {

                    _surname = value;

                    OnPropertyChanged("surname");

                }

            }

        }

        public System.String usageLocation

        {

            get

            {

                return _usageLocation;

            }

            set

            {

                if (value != _usageLocation)

                {

                    _usageLocation = value;

                    OnPropertyChanged("usageLocation");

                }

            }

        }

        public System.String userPrincipalName

        {

            get

            {

                return _userPrincipalName;

            }

            set

            {

                if (value != _userPrincipalName)

                {

                    _userPrincipalName = value;

                    OnPropertyChanged("userPrincipalName");

                }

            }

        }

        public System.String userType

        {

            get

            {

                return _userType;

            }

            set

            {

                if (value != _userType)

                {

                    _userType = value;

                    OnPropertyChanged("userType");

                }

            }

        }

        public System.String aboutMe

        {

            get

            {

                return _aboutMe;

            }

            set

            {

                if (value != _aboutMe)

                {

                    _aboutMe = value;

                    OnPropertyChanged("aboutMe");

                }

            }

        }

        public System.DateTimeOffset birthday

        {

            get

            {

                return _birthday;

            }

            set

            {

                if (value != _birthday)

                {

                    _birthday = value;

                    OnPropertyChanged("birthday");

                }

            }

        }

        public System.DateTimeOffset hireDate

        {

            get

            {

                return _hireDate;

            }

            set

            {

                if (value != _hireDate)

                {

                    _hireDate = value;

                    OnPropertyChanged("hireDate");

                }

            }

        }

        public System.Collections.Generic.IList<System.String> interests

        {

            get

            {

                if (this._interests == default(System.Collections.Generic.IList<System.String>))

                {

                    this._interests = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.String>();

                    this._interests.SetContainer(() => GetContainingEntity("interests"));

                }

                return this._interests;

            }

            set

            {

                interests.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        interests.Add(i);

                    }

                }

            }

        }

        public System.String mySite

        {

            get

            {

                return _mySite;

            }

            set

            {

                if (value != _mySite)

                {

                    _mySite = value;

                    OnPropertyChanged("mySite");

                }

            }

        }

        public System.Collections.Generic.IList<System.String> pastProjects

        {

            get

            {

                if (this._pastProjects == default(System.Collections.Generic.IList<System.String>))

                {

                    this._pastProjects = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.String>();

                    this._pastProjects.SetContainer(() => GetContainingEntity("pastProjects"));

                }

                return this._pastProjects;

            }

            set

            {

                pastProjects.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        pastProjects.Add(i);

                    }

                }

            }

        }

        public System.String preferredName

        {

            get

            {

                return _preferredName;

            }

            set

            {

                if (value != _preferredName)

                {

                    _preferredName = value;

                    OnPropertyChanged("preferredName");

                }

            }

        }

        public System.Collections.Generic.IList<System.String> responsibilities

        {

            get

            {

                if (this._responsibilities == default(System.Collections.Generic.IList<System.String>))

                {

                    this._responsibilities = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.String>();

                    this._responsibilities.SetContainer(() => GetContainingEntity("responsibilities"));

                }

                return this._responsibilities;

            }

            set

            {

                responsibilities.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        responsibilities.Add(i);

                    }

                }

            }

        }

        public System.Collections.Generic.IList<System.String> schools

        {

            get

            {

                if (this._schools == default(System.Collections.Generic.IList<System.String>))

                {

                    this._schools = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.String>();

                    this._schools.SetContainer(() => GetContainingEntity("schools"));

                }

                return this._schools;

            }

            set

            {

                schools.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        schools.Add(i);

                    }

                }

            }

        }

        public System.Collections.Generic.IList<System.String> skills

        {

            get

            {

                if (this._skills == default(System.Collections.Generic.IList<System.String>))

                {

                    this._skills = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.String>();

                    this._skills.SetContainer(() => GetContainingEntity("skills"));

                }

                return this._skills;

            }

            set

            {

                skills.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        skills.Add(i);

                    }

                }

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.IdirectoryObject> global::Microsoft.Graph.Iuser.ownedDevices

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.IdirectoryObject, global::Microsoft.Graph.directoryObject>(Context, (DataServiceCollection<global::Microsoft.Graph.directoryObject>) ownedDevices);

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.IdirectoryObject> global::Microsoft.Graph.Iuser.registeredDevices

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.IdirectoryObject, global::Microsoft.Graph.directoryObject>(Context, (DataServiceCollection<global::Microsoft.Graph.directoryObject>) registeredDevices);

            }

        }

        global::Microsoft.Graph.IdirectoryObject global::Microsoft.Graph.Iuser.manager

        {

            get

            {

                return this._manager;

            }

            set

            {

                if (this.manager != value)

                {

                    this.manager = (global::Microsoft.Graph.directoryObject)value;

                }

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.IdirectoryObject> global::Microsoft.Graph.Iuser.directReports

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.IdirectoryObject, global::Microsoft.Graph.directoryObject>(Context, (DataServiceCollection<global::Microsoft.Graph.directoryObject>) directReports);

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.IdirectoryObject> global::Microsoft.Graph.Iuser.memberOf

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.IdirectoryObject, global::Microsoft.Graph.directoryObject>(Context, (DataServiceCollection<global::Microsoft.Graph.directoryObject>) memberOf);

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.IdirectoryObject> global::Microsoft.Graph.Iuser.createdObjects

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.IdirectoryObject, global::Microsoft.Graph.directoryObject>(Context, (DataServiceCollection<global::Microsoft.Graph.directoryObject>) createdObjects);

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.IdirectoryObject> global::Microsoft.Graph.Iuser.ownedObjects

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.IdirectoryObject, global::Microsoft.Graph.directoryObject>(Context, (DataServiceCollection<global::Microsoft.Graph.directoryObject>) ownedObjects);

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.Imessage> global::Microsoft.Graph.Iuser.messages

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.Imessage, global::Microsoft.Graph.message>(Context, (DataServiceCollection<global::Microsoft.Graph.message>) messages);

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.Igroup> global::Microsoft.Graph.Iuser.joinedGroups

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.Igroup, global::Microsoft.Graph.group>(Context, (DataServiceCollection<global::Microsoft.Graph.group>) joinedGroups);

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.ImailFolder> global::Microsoft.Graph.Iuser.mailFolders

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.ImailFolder, global::Microsoft.Graph.mailFolder>(Context, (DataServiceCollection<global::Microsoft.Graph.mailFolder>) mailFolders);

            }

        }

        global::Microsoft.Graph.Icalendar global::Microsoft.Graph.Iuser.calendar

        {

            get

            {

                return this._calendar;

            }

            set

            {

                if (this.calendar != value)

                {

                    this.calendar = (global::Microsoft.Graph.calendar)value;

                }

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.Icalendar> global::Microsoft.Graph.Iuser.calendars

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.Icalendar, global::Microsoft.Graph.calendar>(Context, (DataServiceCollection<global::Microsoft.Graph.calendar>) calendars);

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.IcalendarGroup> global::Microsoft.Graph.Iuser.calendarGroups

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.IcalendarGroup, global::Microsoft.Graph.calendarGroup>(Context, (DataServiceCollection<global::Microsoft.Graph.calendarGroup>) calendarGroups);

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.Ievent> global::Microsoft.Graph.Iuser.calendarView

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.Ievent, global::Microsoft.Graph.Event>(Context, (DataServiceCollection<global::Microsoft.Graph.Event>) calendarView);

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.Ievent> global::Microsoft.Graph.Iuser.events

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.Ievent, global::Microsoft.Graph.Event>(Context, (DataServiceCollection<global::Microsoft.Graph.Event>) events);

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.Iperson> global::Microsoft.Graph.Iuser.people

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.Iperson, global::Microsoft.Graph.person>(Context, (DataServiceCollection<global::Microsoft.Graph.person>) people);

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.Icontact> global::Microsoft.Graph.Iuser.contacts

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.Icontact, global::Microsoft.Graph.contact>(Context, (DataServiceCollection<global::Microsoft.Graph.contact>) contacts);

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.IcontactFolder> global::Microsoft.Graph.Iuser.contactFolders

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.IcontactFolder, global::Microsoft.Graph.contactFolder>(Context, (DataServiceCollection<global::Microsoft.Graph.contactFolder>) contactFolders);

            }

        }

        global::Microsoft.Graph.IinferenceClassification global::Microsoft.Graph.Iuser.inferenceClassification

        {

            get

            {

                return this._inferenceClassification;

            }

            set

            {

                if (this.inferenceClassification != value)

                {

                    this.inferenceClassification = (global::Microsoft.Graph.inferenceClassification)value;

                }

            }

        }

        global::Microsoft.Graph.IprofilePhoto global::Microsoft.Graph.Iuser.photo

        {

            get

            {

                return this._photo;

            }

            set

            {

                if (this.photo != value)

                {

                    this.photo = (global::Microsoft.Graph.profilePhoto)value;

                }

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.IprofilePhoto> global::Microsoft.Graph.Iuser.photos

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.IprofilePhoto, global::Microsoft.Graph.profilePhoto>(Context, (DataServiceCollection<global::Microsoft.Graph.profilePhoto>) photos);

            }

        }

        global::Microsoft.Graph.Idrive global::Microsoft.Graph.Iuser.drive

        {

            get

            {

                return this._drive;

            }

            set

            {

                if (this.drive != value)

                {

                    this.drive = (global::Microsoft.Graph.drive)value;

                }

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.IdriveItem> global::Microsoft.Graph.Iuser.TrendingAround

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.IdriveItem, global::Microsoft.Graph.driveItem>(Context, (DataServiceCollection<global::Microsoft.Graph.driveItem>) TrendingAround);

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.Iuser> global::Microsoft.Graph.Iuser.WorkingWith

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.Iuser, global::Microsoft.Graph.user>(Context, (DataServiceCollection<global::Microsoft.Graph.user>) WorkingWith);

            }

        }

        global::Microsoft.Graph.Inotes global::Microsoft.Graph.Iuser.notes

        {

            get

            {

                return this._notes;

            }

            set

            {

                if (this.notes != value)

                {

                    this.notes = (global::Microsoft.Graph.notes)value;

                }

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.Itask> global::Microsoft.Graph.Iuser.tasks

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.Itask, global::Microsoft.Graph.task>(Context, (DataServiceCollection<global::Microsoft.Graph.task>) tasks);

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.Iplan> global::Microsoft.Graph.Iuser.plans

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.Iplan, global::Microsoft.Graph.plan>(Context, (DataServiceCollection<global::Microsoft.Graph.plan>) plans);

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.directoryObject> ownedDevices

        {

            get

            {

                if (this._ownedDevicesConcrete == null)

                {

                    this._ownedDevicesConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.directoryObject>();

                    this._ownedDevicesConcrete.SetContainer(() => GetContainingEntity("ownedDevices"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.directoryObject>)this._ownedDevicesConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                ownedDevices.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        ownedDevices.Add(i);

                    }

                }

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.directoryObject> registeredDevices

        {

            get

            {

                if (this._registeredDevicesConcrete == null)

                {

                    this._registeredDevicesConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.directoryObject>();

                    this._registeredDevicesConcrete.SetContainer(() => GetContainingEntity("registeredDevices"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.directoryObject>)this._registeredDevicesConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                registeredDevices.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        registeredDevices.Add(i);

                    }

                }

            }

        }

        public global::Microsoft.Graph.directoryObject manager

        {

            get

            {

                return this._manager;

            }

            set

            {

                if (this._manager != value)

                {

                    this._manager = value;

                    if (Context != null && Context.GetEntityDescriptor(this) != null && (value == null || Context.GetEntityDescriptor(value) != null))

                    {

                        Context.SetLink(this, "manager", value);

                    }

                }

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.directoryObject> directReports

        {

            get

            {

                if (this._directReportsConcrete == null)

                {

                    this._directReportsConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.directoryObject>();

                    this._directReportsConcrete.SetContainer(() => GetContainingEntity("directReports"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.directoryObject>)this._directReportsConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                directReports.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        directReports.Add(i);

                    }

                }

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.directoryObject> memberOf

        {

            get

            {

                if (this._memberOfConcrete == null)

                {

                    this._memberOfConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.directoryObject>();

                    this._memberOfConcrete.SetContainer(() => GetContainingEntity("memberOf"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.directoryObject>)this._memberOfConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                memberOf.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        memberOf.Add(i);

                    }

                }

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.directoryObject> createdObjects

        {

            get

            {

                if (this._createdObjectsConcrete == null)

                {

                    this._createdObjectsConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.directoryObject>();

                    this._createdObjectsConcrete.SetContainer(() => GetContainingEntity("createdObjects"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.directoryObject>)this._createdObjectsConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                createdObjects.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        createdObjects.Add(i);

                    }

                }

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.directoryObject> ownedObjects

        {

            get

            {

                if (this._ownedObjectsConcrete == null)

                {

                    this._ownedObjectsConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.directoryObject>();

                    this._ownedObjectsConcrete.SetContainer(() => GetContainingEntity("ownedObjects"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.directoryObject>)this._ownedObjectsConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                ownedObjects.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        ownedObjects.Add(i);

                    }

                }

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.message> messages

        {

            get

            {

                if (this._messagesConcrete == null)

                {

                    this._messagesConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.message>();

                    this._messagesConcrete.SetContainer(() => GetContainingEntity("messages"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.message>)this._messagesConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                messages.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        messages.Add(i);

                    }

                }

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.group> joinedGroups

        {

            get

            {

                if (this._joinedGroupsConcrete == null)

                {

                    this._joinedGroupsConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.group>();

                    this._joinedGroupsConcrete.SetContainer(() => GetContainingEntity("joinedGroups"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.group>)this._joinedGroupsConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                joinedGroups.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        joinedGroups.Add(i);

                    }

                }

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.mailFolder> mailFolders

        {

            get

            {

                if (this._mailFoldersConcrete == null)

                {

                    this._mailFoldersConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.mailFolder>();

                    this._mailFoldersConcrete.SetContainer(() => GetContainingEntity("mailFolders"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.mailFolder>)this._mailFoldersConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                mailFolders.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        mailFolders.Add(i);

                    }

                }

            }

        }

        public global::Microsoft.Graph.calendar calendar

        {

            get

            {

                return this._calendar;

            }

            set

            {

                if (this._calendar != value)

                {

                    this._calendar = value;

                    if (Context != null && Context.GetEntityDescriptor(this) != null && (value == null || Context.GetEntityDescriptor(value) != null))

                    {

                        Context.SetLink(this, "calendar", value);

                    }

                }

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.calendar> calendars

        {

            get

            {

                if (this._calendarsConcrete == null)

                {

                    this._calendarsConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.calendar>();

                    this._calendarsConcrete.SetContainer(() => GetContainingEntity("calendars"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.calendar>)this._calendarsConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                calendars.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        calendars.Add(i);

                    }

                }

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.calendarGroup> calendarGroups

        {

            get

            {

                if (this._calendarGroupsConcrete == null)

                {

                    this._calendarGroupsConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.calendarGroup>();

                    this._calendarGroupsConcrete.SetContainer(() => GetContainingEntity("calendarGroups"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.calendarGroup>)this._calendarGroupsConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                calendarGroups.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        calendarGroups.Add(i);

                    }

                }

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.Event> calendarView

        {

            get

            {

                if (this._calendarViewConcrete == null)

                {

                    this._calendarViewConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.Event>();

                    this._calendarViewConcrete.SetContainer(() => GetContainingEntity("calendarView"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.Event>)this._calendarViewConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                calendarView.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        calendarView.Add(i);

                    }

                }

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.Event> events

        {

            get

            {

                if (this._eventsConcrete == null)

                {

                    this._eventsConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.Event>();

                    this._eventsConcrete.SetContainer(() => GetContainingEntity("events"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.Event>)this._eventsConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                events.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        events.Add(i);

                    }

                }

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.person> people

        {

            get

            {

                if (this._peopleConcrete == null)

                {

                    this._peopleConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.person>();

                    this._peopleConcrete.SetContainer(() => GetContainingEntity("people"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.person>)this._peopleConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                people.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        people.Add(i);

                    }

                }

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.contact> contacts

        {

            get

            {

                if (this._contactsConcrete == null)

                {

                    this._contactsConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.contact>();

                    this._contactsConcrete.SetContainer(() => GetContainingEntity("contacts"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.contact>)this._contactsConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                contacts.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        contacts.Add(i);

                    }

                }

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.contactFolder> contactFolders

        {

            get

            {

                if (this._contactFoldersConcrete == null)

                {

                    this._contactFoldersConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.contactFolder>();

                    this._contactFoldersConcrete.SetContainer(() => GetContainingEntity("contactFolders"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.contactFolder>)this._contactFoldersConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                contactFolders.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        contactFolders.Add(i);

                    }

                }

            }

        }

        public global::Microsoft.Graph.inferenceClassification inferenceClassification

        {

            get

            {

                return this._inferenceClassification;

            }

            set

            {

                if (this._inferenceClassification != value)

                {

                    this._inferenceClassification = value;

                    if (Context != null && Context.GetEntityDescriptor(this) != null && (value == null || Context.GetEntityDescriptor(value) != null))

                    {

                        Context.SetLink(this, "inferenceClassification", value);

                    }

                }

            }

        }

        public global::Microsoft.Graph.profilePhoto photo

        {

            get

            {

                return this._photo;

            }

            set

            {

                if (this._photo != value)

                {

                    this._photo = value;

                    if (Context != null && Context.GetEntityDescriptor(this) != null && (value == null || Context.GetEntityDescriptor(value) != null))

                    {

                        Context.SetLink(this, "photo", value);

                    }

                }

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.profilePhoto> photos

        {

            get

            {

                if (this._photosConcrete == null)

                {

                    this._photosConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.profilePhoto>();

                    this._photosConcrete.SetContainer(() => GetContainingEntity("photos"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.profilePhoto>)this._photosConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                photos.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        photos.Add(i);

                    }

                }

            }

        }

        public global::Microsoft.Graph.drive drive

        {

            get

            {

                return this._drive;

            }

            set

            {

                if (this._drive != value)

                {

                    this._drive = value;

                    if (Context != null && Context.GetEntityDescriptor(this) != null && (value == null || Context.GetEntityDescriptor(value) != null))

                    {

                        Context.SetLink(this, "drive", value);

                    }

                }

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.driveItem> TrendingAround

        {

            get

            {

                if (this._TrendingAroundConcrete == null)

                {

                    this._TrendingAroundConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.driveItem>();

                    this._TrendingAroundConcrete.SetContainer(() => GetContainingEntity("TrendingAround"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.driveItem>)this._TrendingAroundConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                TrendingAround.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        TrendingAround.Add(i);

                    }

                }

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.user> WorkingWith

        {

            get

            {

                if (this._WorkingWithConcrete == null)

                {

                    this._WorkingWithConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.user>();

                    this._WorkingWithConcrete.SetContainer(() => GetContainingEntity("WorkingWith"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.user>)this._WorkingWithConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                WorkingWith.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        WorkingWith.Add(i);

                    }

                }

            }

        }

        public global::Microsoft.Graph.notes notes

        {

            get

            {

                return this._notes;

            }

            set

            {

                if (this._notes != value)

                {

                    this._notes = value;

                    if (Context != null && Context.GetEntityDescriptor(this) != null && (value == null || Context.GetEntityDescriptor(value) != null))

                    {

                        Context.SetLink(this, "notes", value);

                    }

                }

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.task> tasks

        {

            get

            {

                if (this._tasksConcrete == null)

                {

                    this._tasksConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.task>();

                    this._tasksConcrete.SetContainer(() => GetContainingEntity("tasks"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.task>)this._tasksConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                tasks.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        tasks.Add(i);

                    }

                }

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.plan> plans

        {

            get

            {

                if (this._plansConcrete == null)

                {

                    this._plansConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.plan>();

                    this._plansConcrete.SetContainer(() => GetContainingEntity("plans"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.plan>)this._plansConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                plans.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        plans.Add(i);

                    }

                }

            }

        }

        global::Microsoft.Graph.IdirectoryObjectCollection global::Microsoft.Graph.IuserFetcher.ownedDevices

        {

            get

            {

                if (this._ownedDevicesCollection == null)

                {

                    this._ownedDevicesCollection = new global::Microsoft.Graph.directoryObjectCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.directoryObject>(GetPath("ownedDevices")) : null,
                       Context,
                       this,
                       GetPath("ownedDevices"));

                }

                

                return this._ownedDevicesCollection;

            }

        }

        global::Microsoft.Graph.IdirectoryObjectCollection global::Microsoft.Graph.IuserFetcher.registeredDevices

        {

            get

            {

                if (this._registeredDevicesCollection == null)

                {

                    this._registeredDevicesCollection = new global::Microsoft.Graph.directoryObjectCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.directoryObject>(GetPath("registeredDevices")) : null,
                       Context,
                       this,
                       GetPath("registeredDevices"));

                }

                

                return this._registeredDevicesCollection;

            }

        }

        global::Microsoft.Graph.IdirectoryObjectFetcher global::Microsoft.Graph.IuserFetcher.manager

        {

            get

            {

                if (this._managerFetcher == null)

                {

                    this._managerFetcher = new global::Microsoft.Graph.directoryObjectFetcher();

                    this._managerFetcher.Initialize(this.Context, GetPath("manager"));

                }

                

                return this._managerFetcher;

            }

        }

        global::Microsoft.Graph.IdirectoryObjectCollection global::Microsoft.Graph.IuserFetcher.directReports

        {

            get

            {

                if (this._directReportsCollection == null)

                {

                    this._directReportsCollection = new global::Microsoft.Graph.directoryObjectCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.directoryObject>(GetPath("directReports")) : null,
                       Context,
                       this,
                       GetPath("directReports"));

                }

                

                return this._directReportsCollection;

            }

        }

        global::Microsoft.Graph.IdirectoryObjectCollection global::Microsoft.Graph.IuserFetcher.memberOf

        {

            get

            {

                if (this._memberOfCollection == null)

                {

                    this._memberOfCollection = new global::Microsoft.Graph.directoryObjectCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.directoryObject>(GetPath("memberOf")) : null,
                       Context,
                       this,
                       GetPath("memberOf"));

                }

                

                return this._memberOfCollection;

            }

        }

        global::Microsoft.Graph.IdirectoryObjectCollection global::Microsoft.Graph.IuserFetcher.createdObjects

        {

            get

            {

                if (this._createdObjectsCollection == null)

                {

                    this._createdObjectsCollection = new global::Microsoft.Graph.directoryObjectCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.directoryObject>(GetPath("createdObjects")) : null,
                       Context,
                       this,
                       GetPath("createdObjects"));

                }

                

                return this._createdObjectsCollection;

            }

        }

        global::Microsoft.Graph.IdirectoryObjectCollection global::Microsoft.Graph.IuserFetcher.ownedObjects

        {

            get

            {

                if (this._ownedObjectsCollection == null)

                {

                    this._ownedObjectsCollection = new global::Microsoft.Graph.directoryObjectCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.directoryObject>(GetPath("ownedObjects")) : null,
                       Context,
                       this,
                       GetPath("ownedObjects"));

                }

                

                return this._ownedObjectsCollection;

            }

        }

        global::Microsoft.Graph.ImessageCollection global::Microsoft.Graph.IuserFetcher.messages

        {

            get

            {

                if (this._messagesCollection == null)

                {

                    this._messagesCollection = new global::Microsoft.Graph.messageCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.message>(GetPath("messages")) : null,
                       Context,
                       this,
                       GetPath("messages"));

                }

                

                return this._messagesCollection;

            }

        }

        global::Microsoft.Graph.IgroupCollection global::Microsoft.Graph.IuserFetcher.joinedGroups

        {

            get

            {

                if (this._joinedGroupsCollection == null)

                {

                    this._joinedGroupsCollection = new global::Microsoft.Graph.groupCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.group>(GetPath("joinedGroups")) : null,
                       Context,
                       this,
                       GetPath("joinedGroups"));

                }

                

                return this._joinedGroupsCollection;

            }

        }

        global::Microsoft.Graph.ImailFolderCollection global::Microsoft.Graph.IuserFetcher.mailFolders

        {

            get

            {

                if (this._mailFoldersCollection == null)

                {

                    this._mailFoldersCollection = new global::Microsoft.Graph.mailFolderCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.mailFolder>(GetPath("mailFolders")) : null,
                       Context,
                       this,
                       GetPath("mailFolders"));

                }

                

                return this._mailFoldersCollection;

            }

        }

        global::Microsoft.Graph.IcalendarFetcher global::Microsoft.Graph.IuserFetcher.calendar

        {

            get

            {

                if (this._calendarFetcher == null)

                {

                    this._calendarFetcher = new global::Microsoft.Graph.calendarFetcher();

                    this._calendarFetcher.Initialize(this.Context, GetPath("calendar"));

                }

                

                return this._calendarFetcher;

            }

        }

        global::Microsoft.Graph.IcalendarCollection global::Microsoft.Graph.IuserFetcher.calendars

        {

            get

            {

                if (this._calendarsCollection == null)

                {

                    this._calendarsCollection = new global::Microsoft.Graph.calendarCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.calendar>(GetPath("calendars")) : null,
                       Context,
                       this,
                       GetPath("calendars"));

                }

                

                return this._calendarsCollection;

            }

        }

        global::Microsoft.Graph.IcalendarGroupCollection global::Microsoft.Graph.IuserFetcher.calendarGroups

        {

            get

            {

                if (this._calendarGroupsCollection == null)

                {

                    this._calendarGroupsCollection = new global::Microsoft.Graph.calendarGroupCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.calendarGroup>(GetPath("calendarGroups")) : null,
                       Context,
                       this,
                       GetPath("calendarGroups"));

                }

                

                return this._calendarGroupsCollection;

            }

        }

        global::Microsoft.Graph.IeventCollection global::Microsoft.Graph.IuserFetcher.calendarView

        {

            get

            {

                if (this._calendarViewCollection == null)

                {

                    this._calendarViewCollection = new global::Microsoft.Graph.eventCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.Event>(GetPath("calendarView")) : null,
                       Context,
                       this,
                       GetPath("calendarView"));

                }

                

                return this._calendarViewCollection;

            }

        }

        global::Microsoft.Graph.IeventCollection global::Microsoft.Graph.IuserFetcher.events

        {

            get

            {

                if (this._eventsCollection == null)

                {

                    this._eventsCollection = new global::Microsoft.Graph.eventCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.Event>(GetPath("events")) : null,
                       Context,
                       this,
                       GetPath("events"));

                }

                

                return this._eventsCollection;

            }

        }

        global::Microsoft.Graph.IpersonCollection global::Microsoft.Graph.IuserFetcher.people

        {

            get

            {

                if (this._peopleCollection == null)

                {

                    this._peopleCollection = new global::Microsoft.Graph.personCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.person>(GetPath("people")) : null,
                       Context,
                       this,
                       GetPath("people"));

                }

                

                return this._peopleCollection;

            }

        }

        global::Microsoft.Graph.IcontactCollection global::Microsoft.Graph.IuserFetcher.contacts

        {

            get

            {

                if (this._contactsCollection == null)

                {

                    this._contactsCollection = new global::Microsoft.Graph.contactCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.contact>(GetPath("contacts")) : null,
                       Context,
                       this,
                       GetPath("contacts"));

                }

                

                return this._contactsCollection;

            }

        }

        global::Microsoft.Graph.IcontactFolderCollection global::Microsoft.Graph.IuserFetcher.contactFolders

        {

            get

            {

                if (this._contactFoldersCollection == null)

                {

                    this._contactFoldersCollection = new global::Microsoft.Graph.contactFolderCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.contactFolder>(GetPath("contactFolders")) : null,
                       Context,
                       this,
                       GetPath("contactFolders"));

                }

                

                return this._contactFoldersCollection;

            }

        }

        global::Microsoft.Graph.IinferenceClassificationFetcher global::Microsoft.Graph.IuserFetcher.inferenceClassification

        {

            get

            {

                if (this._inferenceClassificationFetcher == null)

                {

                    this._inferenceClassificationFetcher = new global::Microsoft.Graph.inferenceClassificationFetcher();

                    this._inferenceClassificationFetcher.Initialize(this.Context, GetPath("inferenceClassification"));

                }

                

                return this._inferenceClassificationFetcher;

            }

        }

        global::Microsoft.Graph.IprofilePhotoFetcher global::Microsoft.Graph.IuserFetcher.photo

        {

            get

            {

                if (this._photoFetcher == null)

                {

                    this._photoFetcher = new global::Microsoft.Graph.profilePhotoFetcher();

                    this._photoFetcher.Initialize(this.Context, GetPath("photo"));

                }

                

                return this._photoFetcher;

            }

        }

        global::Microsoft.Graph.IprofilePhotoCollection global::Microsoft.Graph.IuserFetcher.photos

        {

            get

            {

                if (this._photosCollection == null)

                {

                    this._photosCollection = new global::Microsoft.Graph.profilePhotoCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.profilePhoto>(GetPath("photos")) : null,
                       Context,
                       this,
                       GetPath("photos"));

                }

                

                return this._photosCollection;

            }

        }

        global::Microsoft.Graph.IdriveFetcher global::Microsoft.Graph.IuserFetcher.drive

        {

            get

            {

                if (this._driveFetcher == null)

                {

                    this._driveFetcher = new global::Microsoft.Graph.driveFetcher();

                    this._driveFetcher.Initialize(this.Context, GetPath("drive"));

                }

                

                return this._driveFetcher;

            }

        }

        global::Microsoft.Graph.IdriveItemCollection global::Microsoft.Graph.IuserFetcher.TrendingAround

        {

            get

            {

                if (this._TrendingAroundCollection == null)

                {

                    this._TrendingAroundCollection = new global::Microsoft.Graph.driveItemCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.driveItem>(GetPath("TrendingAround")) : null,
                       Context,
                       this,
                       GetPath("TrendingAround"));

                }

                

                return this._TrendingAroundCollection;

            }

        }

        global::Microsoft.Graph.IuserCollection global::Microsoft.Graph.IuserFetcher.WorkingWith

        {

            get

            {

                if (this._WorkingWithCollection == null)

                {

                    this._WorkingWithCollection = new global::Microsoft.Graph.userCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.user>(GetPath("WorkingWith")) : null,
                       Context,
                       this,
                       GetPath("WorkingWith"));

                }

                

                return this._WorkingWithCollection;

            }

        }

        global::Microsoft.Graph.InotesFetcher global::Microsoft.Graph.IuserFetcher.notes

        {

            get

            {

                if (this._notesFetcher == null)

                {

                    this._notesFetcher = new global::Microsoft.Graph.notesFetcher();

                    this._notesFetcher.Initialize(this.Context, GetPath("notes"));

                }

                

                return this._notesFetcher;

            }

        }

        global::Microsoft.Graph.ItaskCollection global::Microsoft.Graph.IuserFetcher.tasks

        {

            get

            {

                if (this._tasksCollection == null)

                {

                    this._tasksCollection = new global::Microsoft.Graph.taskCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.task>(GetPath("tasks")) : null,
                       Context,
                       this,
                       GetPath("tasks"));

                }

                

                return this._tasksCollection;

            }

        }

        global::Microsoft.Graph.IplanCollection global::Microsoft.Graph.IuserFetcher.plans

        {

            get

            {

                if (this._plansCollection == null)

                {

                    this._plansCollection = new global::Microsoft.Graph.planCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.plan>(GetPath("plans")) : null,
                       Context,
                       this,
                       GetPath("plans"));

                }

                

                return this._plansCollection;

            }

        }

        public user()

        {

        }

        public async System.Threading.Tasks.Task<global::Microsoft.Graph.Iuser> assignLicenseAsync(System.Collections.Generic.ICollection<global::Microsoft.Graph.assignedLicense> addLicenses, System.Collections.Generic.ICollection<System.Guid> removeLicenses)

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.assignLicense");

            return (global::Microsoft.Graph.Iuser) Enumerable.Single<global::Microsoft.Graph.user>(await this.Context.ExecuteAsync<global::Microsoft.Graph.user>(requestUri, "POST", true, new OperationParameter[]

            {

                new BodyOperationParameter("addLicenses", (object) addLicenses),

                new BodyOperationParameter("removeLicenses", (object) removeLicenses),

            }

            ));

        }

        public async System.Threading.Tasks.Task changePasswordAsync(System.String currentPassword, System.String newPassword)

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.changePassword");

            await this.Context.ExecuteAsync(requestUri, "POST", new OperationParameter[2]

            {

                new BodyOperationParameter("currentPassword", (object) currentPassword),

                new BodyOperationParameter("newPassword", (object) newPassword),

            }

            );

        }

        public async System.Threading.Tasks.Task sendMailAsync(global::Microsoft.Graph.Imessage Message, System.Nullable<System.Boolean> SaveToSentItems)

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.sendMail");

            await this.Context.ExecuteAsync(requestUri, "POST", new OperationParameter[2]

            {

                new BodyOperationParameter("Message", (object) Message),

                new BodyOperationParameter("SaveToSentItems", (object) SaveToSentItems),

            }

            );

        }

        public async System.Threading.Tasks.Task<global::Microsoft.Graph.meetingTimeCandidate> findMeetingTimesAsync(System.Collections.Generic.ICollection<global::Microsoft.Graph.attendeeBase> Attendees, global::Microsoft.Graph.locationConstraint LocationConstraint, global::Microsoft.Graph.timeConstraint TimeConstraint, System.Nullable<System.TimeSpan> MeetingDuration, System.Nullable<System.Int32> MaxCandidates, System.Nullable<System.Boolean> IsOrganizerOptional)

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.findMeetingTimes");

            return (global::Microsoft.Graph.meetingTimeCandidate) Enumerable.Single<global::Microsoft.Graph.meetingTimeCandidate>(await this.Context.ExecuteAsync<global::Microsoft.Graph.meetingTimeCandidate>(requestUri, "POST", true, new OperationParameter[]

            {

                new BodyOperationParameter("Attendees", (object) Attendees),

                new BodyOperationParameter("LocationConstraint", (object) LocationConstraint),

                new BodyOperationParameter("TimeConstraint", (object) TimeConstraint),

                new BodyOperationParameter("MeetingDuration", (object) MeetingDuration),

                new BodyOperationParameter("MaxCandidates", (object) MaxCandidates),

                new BodyOperationParameter("IsOrganizerOptional", (object) IsOrganizerOptional),

            }

            ));

        }

        public async System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<global::Microsoft.Graph.reminder>> reminderViewAsync(System.String StartDateTime, System.String EndDateTime)

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.reminderView");

            return (await this.Context.ExecuteAsync<global::Microsoft.Graph.reminder>(requestUri, "GET", false, new OperationParameter[]

            {

                new UriOperationParameter("StartDateTime", (object) StartDateTime),

                new UriOperationParameter("EndDateTime", (object) EndDateTime),

            }

            ));

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Iuser> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.user, global::Microsoft.Graph.Iuser>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Iuser> _query;

        global::System.Threading.Tasks.Task<global::Microsoft.Graph.Iuser> global::Microsoft.Graph.IuserFetcher.ExecuteAsync()

        {

            var tsc = new global::System.Threading.Tasks.TaskCompletionSource<global::Microsoft.Graph.Iuser>();

            tsc.SetResult(this);

            return tsc.Task;

        }

        global::Microsoft.Graph.IuserFetcher global::Microsoft.Graph.IuserFetcher.Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.Iuser, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IuserFetcher) this;

        }

    }

    internal partial class userFetcher:global::Microsoft.Graph.directoryObjectFetcher, global::Microsoft.Graph.IuserFetcher

    {

        private global::Microsoft.Graph.directoryObjectFetcher _managerFetcher;

        private global::Microsoft.Graph.calendarFetcher _calendarFetcher;

        private global::Microsoft.Graph.inferenceClassificationFetcher _inferenceClassificationFetcher;

        private global::Microsoft.Graph.profilePhotoFetcher _photoFetcher;

        private global::Microsoft.Graph.driveFetcher _driveFetcher;

        private global::Microsoft.Graph.notesFetcher _notesFetcher;

        private global::Microsoft.Graph.directoryObjectCollection _ownedDevicesCollection;

        private global::Microsoft.Graph.directoryObjectCollection _registeredDevicesCollection;

        private global::Microsoft.Graph.directoryObjectCollection _directReportsCollection;

        private global::Microsoft.Graph.directoryObjectCollection _memberOfCollection;

        private global::Microsoft.Graph.directoryObjectCollection _createdObjectsCollection;

        private global::Microsoft.Graph.directoryObjectCollection _ownedObjectsCollection;

        private global::Microsoft.Graph.messageCollection _messagesCollection;

        private global::Microsoft.Graph.groupCollection _joinedGroupsCollection;

        private global::Microsoft.Graph.mailFolderCollection _mailFoldersCollection;

        private global::Microsoft.Graph.calendarCollection _calendarsCollection;

        private global::Microsoft.Graph.calendarGroupCollection _calendarGroupsCollection;

        private global::Microsoft.Graph.eventCollection _calendarViewCollection;

        private global::Microsoft.Graph.eventCollection _eventsCollection;

        private global::Microsoft.Graph.personCollection _peopleCollection;

        private global::Microsoft.Graph.contactCollection _contactsCollection;

        private global::Microsoft.Graph.contactFolderCollection _contactFoldersCollection;

        private global::Microsoft.Graph.profilePhotoCollection _photosCollection;

        private global::Microsoft.Graph.driveItemCollection _TrendingAroundCollection;

        private global::Microsoft.Graph.userCollection _WorkingWithCollection;

        private global::Microsoft.Graph.taskCollection _tasksCollection;

        private global::Microsoft.Graph.planCollection _plansCollection;

        public global::Microsoft.Graph.IdirectoryObjectCollection ownedDevices

        {

            get

            {

                if (this._ownedDevicesCollection == null)

                {

                    this._ownedDevicesCollection = new global::Microsoft.Graph.directoryObjectCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.directoryObject>(GetPath("ownedDevices")) : null,
                       Context,
                       this,
                       GetPath("ownedDevices"));

                }

                

                return this._ownedDevicesCollection;

            }

        }

        public global::Microsoft.Graph.IdirectoryObjectCollection registeredDevices

        {

            get

            {

                if (this._registeredDevicesCollection == null)

                {

                    this._registeredDevicesCollection = new global::Microsoft.Graph.directoryObjectCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.directoryObject>(GetPath("registeredDevices")) : null,
                       Context,
                       this,
                       GetPath("registeredDevices"));

                }

                

                return this._registeredDevicesCollection;

            }

        }

        public global::Microsoft.Graph.IdirectoryObjectFetcher manager

        {

            get

            {

                if (this._managerFetcher == null)

                {

                    this._managerFetcher = new global::Microsoft.Graph.directoryObjectFetcher();

                    this._managerFetcher.Initialize(this.Context, GetPath("manager"));

                }

                

                return this._managerFetcher;

            }

        }

        public global::Microsoft.Graph.IdirectoryObjectCollection directReports

        {

            get

            {

                if (this._directReportsCollection == null)

                {

                    this._directReportsCollection = new global::Microsoft.Graph.directoryObjectCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.directoryObject>(GetPath("directReports")) : null,
                       Context,
                       this,
                       GetPath("directReports"));

                }

                

                return this._directReportsCollection;

            }

        }

        public global::Microsoft.Graph.IdirectoryObjectCollection memberOf

        {

            get

            {

                if (this._memberOfCollection == null)

                {

                    this._memberOfCollection = new global::Microsoft.Graph.directoryObjectCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.directoryObject>(GetPath("memberOf")) : null,
                       Context,
                       this,
                       GetPath("memberOf"));

                }

                

                return this._memberOfCollection;

            }

        }

        public global::Microsoft.Graph.IdirectoryObjectCollection createdObjects

        {

            get

            {

                if (this._createdObjectsCollection == null)

                {

                    this._createdObjectsCollection = new global::Microsoft.Graph.directoryObjectCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.directoryObject>(GetPath("createdObjects")) : null,
                       Context,
                       this,
                       GetPath("createdObjects"));

                }

                

                return this._createdObjectsCollection;

            }

        }

        public global::Microsoft.Graph.IdirectoryObjectCollection ownedObjects

        {

            get

            {

                if (this._ownedObjectsCollection == null)

                {

                    this._ownedObjectsCollection = new global::Microsoft.Graph.directoryObjectCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.directoryObject>(GetPath("ownedObjects")) : null,
                       Context,
                       this,
                       GetPath("ownedObjects"));

                }

                

                return this._ownedObjectsCollection;

            }

        }

        public global::Microsoft.Graph.ImessageCollection messages

        {

            get

            {

                if (this._messagesCollection == null)

                {

                    this._messagesCollection = new global::Microsoft.Graph.messageCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.message>(GetPath("messages")) : null,
                       Context,
                       this,
                       GetPath("messages"));

                }

                

                return this._messagesCollection;

            }

        }

        public global::Microsoft.Graph.IgroupCollection joinedGroups

        {

            get

            {

                if (this._joinedGroupsCollection == null)

                {

                    this._joinedGroupsCollection = new global::Microsoft.Graph.groupCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.group>(GetPath("joinedGroups")) : null,
                       Context,
                       this,
                       GetPath("joinedGroups"));

                }

                

                return this._joinedGroupsCollection;

            }

        }

        public global::Microsoft.Graph.ImailFolderCollection mailFolders

        {

            get

            {

                if (this._mailFoldersCollection == null)

                {

                    this._mailFoldersCollection = new global::Microsoft.Graph.mailFolderCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.mailFolder>(GetPath("mailFolders")) : null,
                       Context,
                       this,
                       GetPath("mailFolders"));

                }

                

                return this._mailFoldersCollection;

            }

        }

        public global::Microsoft.Graph.IcalendarFetcher calendar

        {

            get

            {

                if (this._calendarFetcher == null)

                {

                    this._calendarFetcher = new global::Microsoft.Graph.calendarFetcher();

                    this._calendarFetcher.Initialize(this.Context, GetPath("calendar"));

                }

                

                return this._calendarFetcher;

            }

        }

        public global::Microsoft.Graph.IcalendarCollection calendars

        {

            get

            {

                if (this._calendarsCollection == null)

                {

                    this._calendarsCollection = new global::Microsoft.Graph.calendarCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.calendar>(GetPath("calendars")) : null,
                       Context,
                       this,
                       GetPath("calendars"));

                }

                

                return this._calendarsCollection;

            }

        }

        public global::Microsoft.Graph.IcalendarGroupCollection calendarGroups

        {

            get

            {

                if (this._calendarGroupsCollection == null)

                {

                    this._calendarGroupsCollection = new global::Microsoft.Graph.calendarGroupCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.calendarGroup>(GetPath("calendarGroups")) : null,
                       Context,
                       this,
                       GetPath("calendarGroups"));

                }

                

                return this._calendarGroupsCollection;

            }

        }

        public global::Microsoft.Graph.IeventCollection calendarView

        {

            get

            {

                if (this._calendarViewCollection == null)

                {

                    this._calendarViewCollection = new global::Microsoft.Graph.eventCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.Event>(GetPath("calendarView")) : null,
                       Context,
                       this,
                       GetPath("calendarView"));

                }

                

                return this._calendarViewCollection;

            }

        }

        public global::Microsoft.Graph.IeventCollection events

        {

            get

            {

                if (this._eventsCollection == null)

                {

                    this._eventsCollection = new global::Microsoft.Graph.eventCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.Event>(GetPath("events")) : null,
                       Context,
                       this,
                       GetPath("events"));

                }

                

                return this._eventsCollection;

            }

        }

        public global::Microsoft.Graph.IpersonCollection people

        {

            get

            {

                if (this._peopleCollection == null)

                {

                    this._peopleCollection = new global::Microsoft.Graph.personCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.person>(GetPath("people")) : null,
                       Context,
                       this,
                       GetPath("people"));

                }

                

                return this._peopleCollection;

            }

        }

        public global::Microsoft.Graph.IcontactCollection contacts

        {

            get

            {

                if (this._contactsCollection == null)

                {

                    this._contactsCollection = new global::Microsoft.Graph.contactCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.contact>(GetPath("contacts")) : null,
                       Context,
                       this,
                       GetPath("contacts"));

                }

                

                return this._contactsCollection;

            }

        }

        public global::Microsoft.Graph.IcontactFolderCollection contactFolders

        {

            get

            {

                if (this._contactFoldersCollection == null)

                {

                    this._contactFoldersCollection = new global::Microsoft.Graph.contactFolderCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.contactFolder>(GetPath("contactFolders")) : null,
                       Context,
                       this,
                       GetPath("contactFolders"));

                }

                

                return this._contactFoldersCollection;

            }

        }

        public global::Microsoft.Graph.IinferenceClassificationFetcher inferenceClassification

        {

            get

            {

                if (this._inferenceClassificationFetcher == null)

                {

                    this._inferenceClassificationFetcher = new global::Microsoft.Graph.inferenceClassificationFetcher();

                    this._inferenceClassificationFetcher.Initialize(this.Context, GetPath("inferenceClassification"));

                }

                

                return this._inferenceClassificationFetcher;

            }

        }

        public global::Microsoft.Graph.IprofilePhotoFetcher photo

        {

            get

            {

                if (this._photoFetcher == null)

                {

                    this._photoFetcher = new global::Microsoft.Graph.profilePhotoFetcher();

                    this._photoFetcher.Initialize(this.Context, GetPath("photo"));

                }

                

                return this._photoFetcher;

            }

        }

        public global::Microsoft.Graph.IprofilePhotoCollection photos

        {

            get

            {

                if (this._photosCollection == null)

                {

                    this._photosCollection = new global::Microsoft.Graph.profilePhotoCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.profilePhoto>(GetPath("photos")) : null,
                       Context,
                       this,
                       GetPath("photos"));

                }

                

                return this._photosCollection;

            }

        }

        public global::Microsoft.Graph.IdriveFetcher drive

        {

            get

            {

                if (this._driveFetcher == null)

                {

                    this._driveFetcher = new global::Microsoft.Graph.driveFetcher();

                    this._driveFetcher.Initialize(this.Context, GetPath("drive"));

                }

                

                return this._driveFetcher;

            }

        }

        public global::Microsoft.Graph.IdriveItemCollection TrendingAround

        {

            get

            {

                if (this._TrendingAroundCollection == null)

                {

                    this._TrendingAroundCollection = new global::Microsoft.Graph.driveItemCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.driveItem>(GetPath("TrendingAround")) : null,
                       Context,
                       this,
                       GetPath("TrendingAround"));

                }

                

                return this._TrendingAroundCollection;

            }

        }

        public global::Microsoft.Graph.IuserCollection WorkingWith

        {

            get

            {

                if (this._WorkingWithCollection == null)

                {

                    this._WorkingWithCollection = new global::Microsoft.Graph.userCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.user>(GetPath("WorkingWith")) : null,
                       Context,
                       this,
                       GetPath("WorkingWith"));

                }

                

                return this._WorkingWithCollection;

            }

        }

        public global::Microsoft.Graph.InotesFetcher notes

        {

            get

            {

                if (this._notesFetcher == null)

                {

                    this._notesFetcher = new global::Microsoft.Graph.notesFetcher();

                    this._notesFetcher.Initialize(this.Context, GetPath("notes"));

                }

                

                return this._notesFetcher;

            }

        }

        public global::Microsoft.Graph.ItaskCollection tasks

        {

            get

            {

                if (this._tasksCollection == null)

                {

                    this._tasksCollection = new global::Microsoft.Graph.taskCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.task>(GetPath("tasks")) : null,
                       Context,
                       this,
                       GetPath("tasks"));

                }

                

                return this._tasksCollection;

            }

        }

        public global::Microsoft.Graph.IplanCollection plans

        {

            get

            {

                if (this._plansCollection == null)

                {

                    this._plansCollection = new global::Microsoft.Graph.planCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.plan>(GetPath("plans")) : null,
                       Context,
                       this,
                       GetPath("plans"));

                }

                

                return this._plansCollection;

            }

        }

        public userFetcher()

        {

        }

        public async System.Threading.Tasks.Task<global::Microsoft.Graph.Iuser> assignLicenseAsync(System.Collections.Generic.ICollection<global::Microsoft.Graph.assignedLicense> addLicenses, System.Collections.Generic.ICollection<System.Guid> removeLicenses)

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.assignLicense");

            return (global::Microsoft.Graph.Iuser) Enumerable.Single<global::Microsoft.Graph.user>(await this.Context.ExecuteAsync<global::Microsoft.Graph.user>(requestUri, "POST", true, new OperationParameter[]

            {

                new BodyOperationParameter("addLicenses", (object) addLicenses),

                new BodyOperationParameter("removeLicenses", (object) removeLicenses),

            }

            ));

        }

        public async System.Threading.Tasks.Task changePasswordAsync(System.String currentPassword, System.String newPassword)

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.changePassword");

            await this.Context.ExecuteAsync(requestUri, "POST", new OperationParameter[2]

            {

                new BodyOperationParameter("currentPassword", (object) currentPassword),

                new BodyOperationParameter("newPassword", (object) newPassword),

            }

            );

        }

        public async System.Threading.Tasks.Task sendMailAsync(global::Microsoft.Graph.Imessage Message, System.Nullable<System.Boolean> SaveToSentItems)

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.sendMail");

            await this.Context.ExecuteAsync(requestUri, "POST", new OperationParameter[2]

            {

                new BodyOperationParameter("Message", (object) Message),

                new BodyOperationParameter("SaveToSentItems", (object) SaveToSentItems),

            }

            );

        }

        public async System.Threading.Tasks.Task<global::Microsoft.Graph.meetingTimeCandidate> findMeetingTimesAsync(System.Collections.Generic.ICollection<global::Microsoft.Graph.attendeeBase> Attendees, global::Microsoft.Graph.locationConstraint LocationConstraint, global::Microsoft.Graph.timeConstraint TimeConstraint, System.Nullable<System.TimeSpan> MeetingDuration, System.Nullable<System.Int32> MaxCandidates, System.Nullable<System.Boolean> IsOrganizerOptional)

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.findMeetingTimes");

            return (global::Microsoft.Graph.meetingTimeCandidate) Enumerable.Single<global::Microsoft.Graph.meetingTimeCandidate>(await this.Context.ExecuteAsync<global::Microsoft.Graph.meetingTimeCandidate>(requestUri, "POST", true, new OperationParameter[]

            {

                new BodyOperationParameter("Attendees", (object) Attendees),

                new BodyOperationParameter("LocationConstraint", (object) LocationConstraint),

                new BodyOperationParameter("TimeConstraint", (object) TimeConstraint),

                new BodyOperationParameter("MeetingDuration", (object) MeetingDuration),

                new BodyOperationParameter("MaxCandidates", (object) MaxCandidates),

                new BodyOperationParameter("IsOrganizerOptional", (object) IsOrganizerOptional),

            }

            ));

        }

        public async System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<global::Microsoft.Graph.reminder>> reminderViewAsync(System.String StartDateTime, System.String EndDateTime)

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.reminderView");

            return (await this.Context.ExecuteAsync<global::Microsoft.Graph.reminder>(requestUri, "GET", false, new OperationParameter[]

            {

                new UriOperationParameter("StartDateTime", (object) StartDateTime),

                new UriOperationParameter("EndDateTime", (object) EndDateTime),

            }

            ));

        }

        public async new global::System.Threading.Tasks.Task<global::Microsoft.Graph.Iuser> ExecuteAsync()

        {

            return await EnsureQuery().ExecuteSingleAsync();

        }

        public global::Microsoft.Graph.IuserFetcher Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.Iuser, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IuserFetcher) new global::Microsoft.Graph.userFetcher()

            {

                _query = this.EnsureQuery().Expand<TTarget>(navigationPropertyAccessor)

            }

            ;

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Iuser> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.user, global::Microsoft.Graph.Iuser>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Iuser> _query;

    }

    internal partial class userCollection:Microsoft.OData.ProxyExtensions.QueryableSet<global::Microsoft.Graph.Iuser>, global::Microsoft.Graph.IuserCollection

    {

        internal userCollection(global::Microsoft.OData.Client.DataServiceQuery inner,Microsoft.OData.ProxyExtensions.DataServiceContextWrapper context,object entity,string path): base(inner, context, entity as Microsoft.OData.ProxyExtensions.EntityBase, path)

        {

        }

        public global::Microsoft.Graph.IuserFetcher GetById(System.String id)

        {

            return this[id];

        }

        public global::System.Threading.Tasks.Task<Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.Iuser>> ExecuteAsync()

        {

            return ExecuteAsyncInternal();

        }

        public global::System.Threading.Tasks.Task AdduserAsync(global::Microsoft.Graph.Iuser item, System.Boolean deferSaveChanges = false)

        {

            if (Entity == null)

            {

                Context.AddObject(Path, item);

            }

            else

            {

                var lastSlash = Path.LastIndexOf('/');

                var shortPath = (lastSlash >= 0 && lastSlash < Path.Length - 1) ? Path.Substring(lastSlash + 1) : Path;

                Context.AddRelatedObject(Entity, shortPath, item);

            }

            if (!deferSaveChanges)

            {

                return Context.SaveChangesAsync();

            }

            else

            {

                var retVal = new global::System.Threading.Tasks.TaskCompletionSource<object>();

                retVal.SetResult(null);

                return retVal.Task;

            }

        }

        public global::Microsoft.Graph.IuserFetcher this[System.String id]

        {

            get

            {

                var path = GetPath<global::Microsoft.Graph.user>((i) => i.id == id);

                var fetcher = new global::Microsoft.Graph.userFetcher();

                fetcher.Initialize(Context, path);

                

                return fetcher;

            }

        }

    }

    internal partial class userCollection

    {

        public global::System.Threading.Tasks.Task<System.Int64> CountAsync()

        {

            return new DataServiceQuerySingle<long>(Context, Path + "/$count").GetValueAsync();

        }

    }

    [global::Microsoft.OData.Client.Key("id")]

    public partial class message:global::Microsoft.Graph.outlookItem, global::Microsoft.Graph.Imessage, global::Microsoft.Graph.ImessageFetcher

    {

        private global::Microsoft.Graph.extensionCollection _extensionsCollection;

        private global::Microsoft.Graph.attachmentCollection _attachmentsCollection;

        private System.Nullable<System.DateTimeOffset> _receivedDateTime;

        private System.Nullable<System.DateTimeOffset> _sentDateTime;

        private System.Nullable<System.Boolean> _hasAttachments;

        private System.String _subject;

        private global::Microsoft.Graph.itemBody _body;

        private System.String _bodyPreview;

        private global::Microsoft.Graph.importance _importance;

        private System.String _parentFolderId;

        private global::Microsoft.Graph.recipient _sender;

        private global::Microsoft.Graph.recipient _from;

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.recipient> _toRecipients;

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.recipient> _ccRecipients;

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.recipient> _bccRecipients;

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.recipient> _replyTo;

        private System.String _conversationId;

        private global::Microsoft.Graph.itemBody _uniqueBody;

        private System.Nullable<System.Boolean> _isDeliveryReceiptRequested;

        private System.Nullable<System.Boolean> _isReadReceiptRequested;

        private System.Nullable<System.Boolean> _isRead;

        private System.Nullable<System.Boolean> _isDraft;

        private System.String _webLink;

        private global::Microsoft.Graph.inferenceClassificationType _inferenceClassification;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.extension> _extensionsConcrete;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.attachment> _attachmentsConcrete;

        public System.Nullable<System.DateTimeOffset> receivedDateTime

        {

            get

            {

                return _receivedDateTime;

            }

            set

            {

                if (value != _receivedDateTime)

                {

                    _receivedDateTime = value;

                    OnPropertyChanged("receivedDateTime");

                }

            }

        }

        public System.Nullable<System.DateTimeOffset> sentDateTime

        {

            get

            {

                return _sentDateTime;

            }

            set

            {

                if (value != _sentDateTime)

                {

                    _sentDateTime = value;

                    OnPropertyChanged("sentDateTime");

                }

            }

        }

        public System.Nullable<System.Boolean> hasAttachments

        {

            get

            {

                return _hasAttachments;

            }

            set

            {

                if (value != _hasAttachments)

                {

                    _hasAttachments = value;

                    OnPropertyChanged("hasAttachments");

                }

            }

        }

        public System.String subject

        {

            get

            {

                return _subject;

            }

            set

            {

                if (value != _subject)

                {

                    _subject = value;

                    OnPropertyChanged("subject");

                }

            }

        }

        public global::Microsoft.Graph.itemBody body

        {

            get

            {

                return _body;

            }

            set

            {

                if (value != _body)

                {

                    _body = value;

                    OnPropertyChanged("body");

                }

            }

        }

        public System.String bodyPreview

        {

            get

            {

                return _bodyPreview;

            }

            set

            {

                if (value != _bodyPreview)

                {

                    _bodyPreview = value;

                    OnPropertyChanged("bodyPreview");

                }

            }

        }

        public global::Microsoft.Graph.importance importance

        {

            get

            {

                return _importance;

            }

            set

            {

                if (value != _importance)

                {

                    _importance = value;

                    OnPropertyChanged("importance");

                }

            }

        }

        public System.String parentFolderId

        {

            get

            {

                return _parentFolderId;

            }

            set

            {

                if (value != _parentFolderId)

                {

                    _parentFolderId = value;

                    OnPropertyChanged("parentFolderId");

                }

            }

        }

        public global::Microsoft.Graph.recipient sender

        {

            get

            {

                return _sender;

            }

            set

            {

                if (value != _sender)

                {

                    _sender = value;

                    OnPropertyChanged("sender");

                }

            }

        }

        public global::Microsoft.Graph.recipient from

        {

            get

            {

                return _from;

            }

            set

            {

                if (value != _from)

                {

                    _from = value;

                    OnPropertyChanged("from");

                }

            }

        }

        public System.Collections.Generic.IList<global::Microsoft.Graph.recipient> toRecipients

        {

            get

            {

                if (this._toRecipients == default(System.Collections.Generic.IList<global::Microsoft.Graph.recipient>))

                {

                    this._toRecipients = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.recipient>();

                    this._toRecipients.SetContainer(() => GetContainingEntity("toRecipients"));

                }

                return this._toRecipients;

            }

            set

            {

                toRecipients.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        toRecipients.Add(i);

                    }

                }

            }

        }

        public System.Collections.Generic.IList<global::Microsoft.Graph.recipient> ccRecipients

        {

            get

            {

                if (this._ccRecipients == default(System.Collections.Generic.IList<global::Microsoft.Graph.recipient>))

                {

                    this._ccRecipients = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.recipient>();

                    this._ccRecipients.SetContainer(() => GetContainingEntity("ccRecipients"));

                }

                return this._ccRecipients;

            }

            set

            {

                ccRecipients.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        ccRecipients.Add(i);

                    }

                }

            }

        }

        public System.Collections.Generic.IList<global::Microsoft.Graph.recipient> bccRecipients

        {

            get

            {

                if (this._bccRecipients == default(System.Collections.Generic.IList<global::Microsoft.Graph.recipient>))

                {

                    this._bccRecipients = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.recipient>();

                    this._bccRecipients.SetContainer(() => GetContainingEntity("bccRecipients"));

                }

                return this._bccRecipients;

            }

            set

            {

                bccRecipients.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        bccRecipients.Add(i);

                    }

                }

            }

        }

        public System.Collections.Generic.IList<global::Microsoft.Graph.recipient> replyTo

        {

            get

            {

                if (this._replyTo == default(System.Collections.Generic.IList<global::Microsoft.Graph.recipient>))

                {

                    this._replyTo = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.recipient>();

                    this._replyTo.SetContainer(() => GetContainingEntity("replyTo"));

                }

                return this._replyTo;

            }

            set

            {

                replyTo.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        replyTo.Add(i);

                    }

                }

            }

        }

        public System.String conversationId

        {

            get

            {

                return _conversationId;

            }

            set

            {

                if (value != _conversationId)

                {

                    _conversationId = value;

                    OnPropertyChanged("conversationId");

                }

            }

        }

        public global::Microsoft.Graph.itemBody uniqueBody

        {

            get

            {

                return _uniqueBody;

            }

            set

            {

                if (value != _uniqueBody)

                {

                    _uniqueBody = value;

                    OnPropertyChanged("uniqueBody");

                }

            }

        }

        public System.Nullable<System.Boolean> isDeliveryReceiptRequested

        {

            get

            {

                return _isDeliveryReceiptRequested;

            }

            set

            {

                if (value != _isDeliveryReceiptRequested)

                {

                    _isDeliveryReceiptRequested = value;

                    OnPropertyChanged("isDeliveryReceiptRequested");

                }

            }

        }

        public System.Nullable<System.Boolean> isReadReceiptRequested

        {

            get

            {

                return _isReadReceiptRequested;

            }

            set

            {

                if (value != _isReadReceiptRequested)

                {

                    _isReadReceiptRequested = value;

                    OnPropertyChanged("isReadReceiptRequested");

                }

            }

        }

        public System.Nullable<System.Boolean> isRead

        {

            get

            {

                return _isRead;

            }

            set

            {

                if (value != _isRead)

                {

                    _isRead = value;

                    OnPropertyChanged("isRead");

                }

            }

        }

        public System.Nullable<System.Boolean> isDraft

        {

            get

            {

                return _isDraft;

            }

            set

            {

                if (value != _isDraft)

                {

                    _isDraft = value;

                    OnPropertyChanged("isDraft");

                }

            }

        }

        public System.String webLink

        {

            get

            {

                return _webLink;

            }

            set

            {

                if (value != _webLink)

                {

                    _webLink = value;

                    OnPropertyChanged("webLink");

                }

            }

        }

        public global::Microsoft.Graph.inferenceClassificationType inferenceClassification

        {

            get

            {

                return _inferenceClassification;

            }

            set

            {

                if (value != _inferenceClassification)

                {

                    _inferenceClassification = value;

                    OnPropertyChanged("inferenceClassification");

                }

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.Iextension> global::Microsoft.Graph.Imessage.extensions

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.Iextension, global::Microsoft.Graph.extension>(Context, (DataServiceCollection<global::Microsoft.Graph.extension>) extensions);

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.Iattachment> global::Microsoft.Graph.Imessage.attachments

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.Iattachment, global::Microsoft.Graph.attachment>(Context, (DataServiceCollection<global::Microsoft.Graph.attachment>) attachments);

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.extension> extensions

        {

            get

            {

                if (this._extensionsConcrete == null)

                {

                    this._extensionsConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.extension>();

                    this._extensionsConcrete.SetContainer(() => GetContainingEntity("extensions"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.extension>)this._extensionsConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                extensions.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        extensions.Add(i);

                    }

                }

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.attachment> attachments

        {

            get

            {

                if (this._attachmentsConcrete == null)

                {

                    this._attachmentsConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.attachment>();

                    this._attachmentsConcrete.SetContainer(() => GetContainingEntity("attachments"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.attachment>)this._attachmentsConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                attachments.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        attachments.Add(i);

                    }

                }

            }

        }

        global::Microsoft.Graph.IextensionCollection global::Microsoft.Graph.ImessageFetcher.extensions

        {

            get

            {

                if (this._extensionsCollection == null)

                {

                    this._extensionsCollection = new global::Microsoft.Graph.extensionCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.extension>(GetPath("extensions")) : null,
                       Context,
                       this,
                       GetPath("extensions"));

                }

                

                return this._extensionsCollection;

            }

        }

        global::Microsoft.Graph.IattachmentCollection global::Microsoft.Graph.ImessageFetcher.attachments

        {

            get

            {

                if (this._attachmentsCollection == null)

                {

                    this._attachmentsCollection = new global::Microsoft.Graph.attachmentCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.attachment>(GetPath("attachments")) : null,
                       Context,
                       this,
                       GetPath("attachments"));

                }

                

                return this._attachmentsCollection;

            }

        }

        public message()

        {

        }

        public async System.Threading.Tasks.Task<global::Microsoft.Graph.Imessage> copyAsync(System.String DestinationId)

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.copy");

            return (global::Microsoft.Graph.Imessage) Enumerable.Single<global::Microsoft.Graph.message>(await this.Context.ExecuteAsync<global::Microsoft.Graph.message>(requestUri, "POST", true, new OperationParameter[]

            {

                new BodyOperationParameter("DestinationId", (object) DestinationId),

            }

            ));

        }

        public async System.Threading.Tasks.Task<global::Microsoft.Graph.Imessage> moveAsync(System.String DestinationId)

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.move");

            return (global::Microsoft.Graph.Imessage) Enumerable.Single<global::Microsoft.Graph.message>(await this.Context.ExecuteAsync<global::Microsoft.Graph.message>(requestUri, "POST", true, new OperationParameter[]

            {

                new BodyOperationParameter("DestinationId", (object) DestinationId),

            }

            ));

        }

        public async System.Threading.Tasks.Task<global::Microsoft.Graph.Imessage> createReplyAsync()

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.createReply");

            return (global::Microsoft.Graph.Imessage) Enumerable.Single<global::Microsoft.Graph.message>(await this.Context.ExecuteAsync<global::Microsoft.Graph.message>(requestUri, "POST", true, new OperationParameter[]

            {

            }

            ));

        }

        public async System.Threading.Tasks.Task<global::Microsoft.Graph.Imessage> createReplyAllAsync()

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.createReplyAll");

            return (global::Microsoft.Graph.Imessage) Enumerable.Single<global::Microsoft.Graph.message>(await this.Context.ExecuteAsync<global::Microsoft.Graph.message>(requestUri, "POST", true, new OperationParameter[]

            {

            }

            ));

        }

        public async System.Threading.Tasks.Task<global::Microsoft.Graph.Imessage> createForwardAsync()

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.createForward");

            return (global::Microsoft.Graph.Imessage) Enumerable.Single<global::Microsoft.Graph.message>(await this.Context.ExecuteAsync<global::Microsoft.Graph.message>(requestUri, "POST", true, new OperationParameter[]

            {

            }

            ));

        }

        public async System.Threading.Tasks.Task replyAsync(System.String Comment)

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.reply");

            await this.Context.ExecuteAsync(requestUri, "POST", new OperationParameter[1]

            {

                new BodyOperationParameter("Comment", (object) Comment),

            }

            );

        }

        public async System.Threading.Tasks.Task replyAllAsync(System.String Comment)

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.replyAll");

            await this.Context.ExecuteAsync(requestUri, "POST", new OperationParameter[1]

            {

                new BodyOperationParameter("Comment", (object) Comment),

            }

            );

        }

        public async System.Threading.Tasks.Task forwardAsync(System.String Comment, System.Collections.Generic.ICollection<global::Microsoft.Graph.recipient> ToRecipients)

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.forward");

            await this.Context.ExecuteAsync(requestUri, "POST", new OperationParameter[2]

            {

                new BodyOperationParameter("Comment", (object) Comment),

                new BodyOperationParameter("ToRecipients", (object) ToRecipients),

            }

            );

        }

        public async System.Threading.Tasks.Task sendAsync()

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.send");

            await this.Context.ExecuteAsync(requestUri, "POST", new OperationParameter[0]

            {

            }

            );

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Imessage> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.message, global::Microsoft.Graph.Imessage>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Imessage> _query;

        global::System.Threading.Tasks.Task<global::Microsoft.Graph.Imessage> global::Microsoft.Graph.ImessageFetcher.ExecuteAsync()

        {

            var tsc = new global::System.Threading.Tasks.TaskCompletionSource<global::Microsoft.Graph.Imessage>();

            tsc.SetResult(this);

            return tsc.Task;

        }

        global::Microsoft.Graph.ImessageFetcher global::Microsoft.Graph.ImessageFetcher.Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.Imessage, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.ImessageFetcher) this;

        }

    }

    internal partial class messageFetcher:global::Microsoft.Graph.outlookItemFetcher, global::Microsoft.Graph.ImessageFetcher

    {

        private global::Microsoft.Graph.extensionCollection _extensionsCollection;

        private global::Microsoft.Graph.attachmentCollection _attachmentsCollection;

        public global::Microsoft.Graph.IextensionCollection extensions

        {

            get

            {

                if (this._extensionsCollection == null)

                {

                    this._extensionsCollection = new global::Microsoft.Graph.extensionCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.extension>(GetPath("extensions")) : null,
                       Context,
                       this,
                       GetPath("extensions"));

                }

                

                return this._extensionsCollection;

            }

        }

        public global::Microsoft.Graph.IattachmentCollection attachments

        {

            get

            {

                if (this._attachmentsCollection == null)

                {

                    this._attachmentsCollection = new global::Microsoft.Graph.attachmentCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.attachment>(GetPath("attachments")) : null,
                       Context,
                       this,
                       GetPath("attachments"));

                }

                

                return this._attachmentsCollection;

            }

        }

        public messageFetcher()

        {

        }

        public async System.Threading.Tasks.Task<global::Microsoft.Graph.Imessage> copyAsync(System.String DestinationId)

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.copy");

            return (global::Microsoft.Graph.Imessage) Enumerable.Single<global::Microsoft.Graph.message>(await this.Context.ExecuteAsync<global::Microsoft.Graph.message>(requestUri, "POST", true, new OperationParameter[]

            {

                new BodyOperationParameter("DestinationId", (object) DestinationId),

            }

            ));

        }

        public async System.Threading.Tasks.Task<global::Microsoft.Graph.Imessage> moveAsync(System.String DestinationId)

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.move");

            return (global::Microsoft.Graph.Imessage) Enumerable.Single<global::Microsoft.Graph.message>(await this.Context.ExecuteAsync<global::Microsoft.Graph.message>(requestUri, "POST", true, new OperationParameter[]

            {

                new BodyOperationParameter("DestinationId", (object) DestinationId),

            }

            ));

        }

        public async System.Threading.Tasks.Task<global::Microsoft.Graph.Imessage> createReplyAsync()

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.createReply");

            return (global::Microsoft.Graph.Imessage) Enumerable.Single<global::Microsoft.Graph.message>(await this.Context.ExecuteAsync<global::Microsoft.Graph.message>(requestUri, "POST", true, new OperationParameter[]

            {

            }

            ));

        }

        public async System.Threading.Tasks.Task<global::Microsoft.Graph.Imessage> createReplyAllAsync()

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.createReplyAll");

            return (global::Microsoft.Graph.Imessage) Enumerable.Single<global::Microsoft.Graph.message>(await this.Context.ExecuteAsync<global::Microsoft.Graph.message>(requestUri, "POST", true, new OperationParameter[]

            {

            }

            ));

        }

        public async System.Threading.Tasks.Task<global::Microsoft.Graph.Imessage> createForwardAsync()

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.createForward");

            return (global::Microsoft.Graph.Imessage) Enumerable.Single<global::Microsoft.Graph.message>(await this.Context.ExecuteAsync<global::Microsoft.Graph.message>(requestUri, "POST", true, new OperationParameter[]

            {

            }

            ));

        }

        public async System.Threading.Tasks.Task replyAsync(System.String Comment)

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.reply");

            await this.Context.ExecuteAsync(requestUri, "POST", new OperationParameter[1]

            {

                new BodyOperationParameter("Comment", (object) Comment),

            }

            );

        }

        public async System.Threading.Tasks.Task replyAllAsync(System.String Comment)

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.replyAll");

            await this.Context.ExecuteAsync(requestUri, "POST", new OperationParameter[1]

            {

                new BodyOperationParameter("Comment", (object) Comment),

            }

            );

        }

        public async System.Threading.Tasks.Task forwardAsync(System.String Comment, System.Collections.Generic.ICollection<global::Microsoft.Graph.recipient> ToRecipients)

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.forward");

            await this.Context.ExecuteAsync(requestUri, "POST", new OperationParameter[2]

            {

                new BodyOperationParameter("Comment", (object) Comment),

                new BodyOperationParameter("ToRecipients", (object) ToRecipients),

            }

            );

        }

        public async System.Threading.Tasks.Task sendAsync()

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.send");

            await this.Context.ExecuteAsync(requestUri, "POST", new OperationParameter[0]

            {

            }

            );

        }

        public async global::System.Threading.Tasks.Task<global::Microsoft.Graph.Imessage> ExecuteAsync()

        {

            return await EnsureQuery().ExecuteSingleAsync();

        }

        public global::Microsoft.Graph.ImessageFetcher Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.Imessage, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.ImessageFetcher) new global::Microsoft.Graph.messageFetcher()

            {

                _query = this.EnsureQuery().Expand<TTarget>(navigationPropertyAccessor)

            }

            ;

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Imessage> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.message, global::Microsoft.Graph.Imessage>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Imessage> _query;

    }

    internal partial class messageCollection:Microsoft.OData.ProxyExtensions.QueryableSet<global::Microsoft.Graph.Imessage>, global::Microsoft.Graph.ImessageCollection

    {

        internal messageCollection(global::Microsoft.OData.Client.DataServiceQuery inner,Microsoft.OData.ProxyExtensions.DataServiceContextWrapper context,object entity,string path): base(inner, context, entity as Microsoft.OData.ProxyExtensions.EntityBase, path)

        {

        }

        public global::Microsoft.Graph.ImessageFetcher GetById(System.String id)

        {

            return this[id];

        }

        public global::System.Threading.Tasks.Task<Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.Imessage>> ExecuteAsync()

        {

            return ExecuteAsyncInternal();

        }

        public global::System.Threading.Tasks.Task AddmessageAsync(global::Microsoft.Graph.Imessage item, System.Boolean deferSaveChanges = false)

        {

            if (Entity == null)

            {

                Context.AddObject(Path, item);

            }

            else

            {

                var lastSlash = Path.LastIndexOf('/');

                var shortPath = (lastSlash >= 0 && lastSlash < Path.Length - 1) ? Path.Substring(lastSlash + 1) : Path;

                Context.AddRelatedObject(Entity, shortPath, item);

            }

            if (!deferSaveChanges)

            {

                return Context.SaveChangesAsync();

            }

            else

            {

                var retVal = new global::System.Threading.Tasks.TaskCompletionSource<object>();

                retVal.SetResult(null);

                return retVal.Task;

            }

        }

        public global::Microsoft.Graph.ImessageFetcher this[System.String id]

        {

            get

            {

                var path = GetPath<global::Microsoft.Graph.message>((i) => i.id == id);

                var fetcher = new global::Microsoft.Graph.messageFetcher();

                fetcher.Initialize(Context, path);

                

                return fetcher;

            }

        }

    }

    internal partial class messageCollection

    {

        public global::System.Threading.Tasks.Task<System.Int64> CountAsync()

        {

            return new DataServiceQuerySingle<long>(Context, Path + "/$count").GetValueAsync();

        }

    }

    [global::Microsoft.OData.Client.Key("id")]

    public partial class mailFolder:Microsoft.OData.ProxyExtensions.EntityBase, global::Microsoft.Graph.ImailFolder, global::Microsoft.Graph.ImailFolderFetcher

    {

        private global::Microsoft.Graph.messageCollection _messagesCollection;

        private global::Microsoft.Graph.mailFolderCollection _childFoldersCollection;

        private System.String _displayName;

        private System.String _parentFolderId;

        private System.Nullable<System.Int32> _childFolderCount;

        private System.Nullable<System.Int32> _unreadItemCount;

        private System.Nullable<System.Int32> _totalItemCount;

        private System.String _id;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.message> _messagesConcrete;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.mailFolder> _childFoldersConcrete;

        public System.String displayName

        {

            get

            {

                return _displayName;

            }

            set

            {

                if (value != _displayName)

                {

                    _displayName = value;

                    OnPropertyChanged("displayName");

                }

            }

        }

        public System.String parentFolderId

        {

            get

            {

                return _parentFolderId;

            }

            set

            {

                if (value != _parentFolderId)

                {

                    _parentFolderId = value;

                    OnPropertyChanged("parentFolderId");

                }

            }

        }

        public System.Nullable<System.Int32> childFolderCount

        {

            get

            {

                return _childFolderCount;

            }

            set

            {

                if (value != _childFolderCount)

                {

                    _childFolderCount = value;

                    OnPropertyChanged("childFolderCount");

                }

            }

        }

        public System.Nullable<System.Int32> unreadItemCount

        {

            get

            {

                return _unreadItemCount;

            }

            set

            {

                if (value != _unreadItemCount)

                {

                    _unreadItemCount = value;

                    OnPropertyChanged("unreadItemCount");

                }

            }

        }

        public System.Nullable<System.Int32> totalItemCount

        {

            get

            {

                return _totalItemCount;

            }

            set

            {

                if (value != _totalItemCount)

                {

                    _totalItemCount = value;

                    OnPropertyChanged("totalItemCount");

                }

            }

        }

        public System.String id

        {

            get

            {

                return _id;

            }

            set

            {

                if (value != _id)

                {

                    _id = value;

                    OnPropertyChanged("id");

                }

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.Imessage> global::Microsoft.Graph.ImailFolder.messages

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.Imessage, global::Microsoft.Graph.message>(Context, (DataServiceCollection<global::Microsoft.Graph.message>) messages);

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.ImailFolder> global::Microsoft.Graph.ImailFolder.childFolders

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.ImailFolder, global::Microsoft.Graph.mailFolder>(Context, (DataServiceCollection<global::Microsoft.Graph.mailFolder>) childFolders);

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.message> messages

        {

            get

            {

                if (this._messagesConcrete == null)

                {

                    this._messagesConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.message>();

                    this._messagesConcrete.SetContainer(() => GetContainingEntity("messages"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.message>)this._messagesConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                messages.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        messages.Add(i);

                    }

                }

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.mailFolder> childFolders

        {

            get

            {

                if (this._childFoldersConcrete == null)

                {

                    this._childFoldersConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.mailFolder>();

                    this._childFoldersConcrete.SetContainer(() => GetContainingEntity("childFolders"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.mailFolder>)this._childFoldersConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                childFolders.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        childFolders.Add(i);

                    }

                }

            }

        }

        global::Microsoft.Graph.ImessageCollection global::Microsoft.Graph.ImailFolderFetcher.messages

        {

            get

            {

                if (this._messagesCollection == null)

                {

                    this._messagesCollection = new global::Microsoft.Graph.messageCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.message>(GetPath("messages")) : null,
                       Context,
                       this,
                       GetPath("messages"));

                }

                

                return this._messagesCollection;

            }

        }

        global::Microsoft.Graph.ImailFolderCollection global::Microsoft.Graph.ImailFolderFetcher.childFolders

        {

            get

            {

                if (this._childFoldersCollection == null)

                {

                    this._childFoldersCollection = new global::Microsoft.Graph.mailFolderCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.mailFolder>(GetPath("childFolders")) : null,
                       Context,
                       this,
                       GetPath("childFolders"));

                }

                

                return this._childFoldersCollection;

            }

        }

        public mailFolder(): base()

        {

        }

        public async System.Threading.Tasks.Task<global::Microsoft.Graph.ImailFolder> copyAsync(System.String DestinationId)

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.copy");

            return (global::Microsoft.Graph.ImailFolder) Enumerable.Single<global::Microsoft.Graph.mailFolder>(await this.Context.ExecuteAsync<global::Microsoft.Graph.mailFolder>(requestUri, "POST", true, new OperationParameter[]

            {

                new BodyOperationParameter("DestinationId", (object) DestinationId),

            }

            ));

        }

        public async System.Threading.Tasks.Task<global::Microsoft.Graph.ImailFolder> moveAsync(System.String DestinationId)

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.move");

            return (global::Microsoft.Graph.ImailFolder) Enumerable.Single<global::Microsoft.Graph.mailFolder>(await this.Context.ExecuteAsync<global::Microsoft.Graph.mailFolder>(requestUri, "POST", true, new OperationParameter[]

            {

                new BodyOperationParameter("DestinationId", (object) DestinationId),

            }

            ));

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.ImailFolder> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.mailFolder, global::Microsoft.Graph.ImailFolder>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.ImailFolder> _query;

        global::System.Threading.Tasks.Task<global::Microsoft.Graph.ImailFolder> global::Microsoft.Graph.ImailFolderFetcher.ExecuteAsync()

        {

            var tsc = new global::System.Threading.Tasks.TaskCompletionSource<global::Microsoft.Graph.ImailFolder>();

            tsc.SetResult(this);

            return tsc.Task;

        }

        global::Microsoft.Graph.ImailFolderFetcher global::Microsoft.Graph.ImailFolderFetcher.Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.ImailFolder, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.ImailFolderFetcher) this;

        }

    }

    internal partial class mailFolderFetcher:Microsoft.OData.ProxyExtensions.RestShallowObjectFetcher, global::Microsoft.Graph.ImailFolderFetcher

    {

        private global::Microsoft.Graph.messageCollection _messagesCollection;

        private global::Microsoft.Graph.mailFolderCollection _childFoldersCollection;

        public global::Microsoft.Graph.ImessageCollection messages

        {

            get

            {

                if (this._messagesCollection == null)

                {

                    this._messagesCollection = new global::Microsoft.Graph.messageCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.message>(GetPath("messages")) : null,
                       Context,
                       this,
                       GetPath("messages"));

                }

                

                return this._messagesCollection;

            }

        }

        public global::Microsoft.Graph.ImailFolderCollection childFolders

        {

            get

            {

                if (this._childFoldersCollection == null)

                {

                    this._childFoldersCollection = new global::Microsoft.Graph.mailFolderCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.mailFolder>(GetPath("childFolders")) : null,
                       Context,
                       this,
                       GetPath("childFolders"));

                }

                

                return this._childFoldersCollection;

            }

        }

        public mailFolderFetcher(): base()

        {

        }

        public async System.Threading.Tasks.Task<global::Microsoft.Graph.ImailFolder> copyAsync(System.String DestinationId)

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.copy");

            return (global::Microsoft.Graph.ImailFolder) Enumerable.Single<global::Microsoft.Graph.mailFolder>(await this.Context.ExecuteAsync<global::Microsoft.Graph.mailFolder>(requestUri, "POST", true, new OperationParameter[]

            {

                new BodyOperationParameter("DestinationId", (object) DestinationId),

            }

            ));

        }

        public async System.Threading.Tasks.Task<global::Microsoft.Graph.ImailFolder> moveAsync(System.String DestinationId)

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.move");

            return (global::Microsoft.Graph.ImailFolder) Enumerable.Single<global::Microsoft.Graph.mailFolder>(await this.Context.ExecuteAsync<global::Microsoft.Graph.mailFolder>(requestUri, "POST", true, new OperationParameter[]

            {

                new BodyOperationParameter("DestinationId", (object) DestinationId),

            }

            ));

        }

        public async global::System.Threading.Tasks.Task<global::Microsoft.Graph.ImailFolder> ExecuteAsync()

        {

            return await EnsureQuery().ExecuteSingleAsync();

        }

        public global::Microsoft.Graph.ImailFolderFetcher Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.ImailFolder, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.ImailFolderFetcher) new global::Microsoft.Graph.mailFolderFetcher()

            {

                _query = this.EnsureQuery().Expand<TTarget>(navigationPropertyAccessor)

            }

            ;

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.ImailFolder> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.mailFolder, global::Microsoft.Graph.ImailFolder>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.ImailFolder> _query;

    }

    internal partial class mailFolderCollection:Microsoft.OData.ProxyExtensions.QueryableSet<global::Microsoft.Graph.ImailFolder>, global::Microsoft.Graph.ImailFolderCollection

    {

        internal mailFolderCollection(global::Microsoft.OData.Client.DataServiceQuery inner,Microsoft.OData.ProxyExtensions.DataServiceContextWrapper context,object entity,string path): base(inner, context, entity as Microsoft.OData.ProxyExtensions.EntityBase, path)

        {

        }

        public global::Microsoft.Graph.ImailFolderFetcher GetById(System.String id)

        {

            return this[id];

        }

        public global::System.Threading.Tasks.Task<Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.ImailFolder>> ExecuteAsync()

        {

            return ExecuteAsyncInternal();

        }

        public global::System.Threading.Tasks.Task AddmailFolderAsync(global::Microsoft.Graph.ImailFolder item, System.Boolean deferSaveChanges = false)

        {

            if (Entity == null)

            {

                Context.AddObject(Path, item);

            }

            else

            {

                var lastSlash = Path.LastIndexOf('/');

                var shortPath = (lastSlash >= 0 && lastSlash < Path.Length - 1) ? Path.Substring(lastSlash + 1) : Path;

                Context.AddRelatedObject(Entity, shortPath, item);

            }

            if (!deferSaveChanges)

            {

                return Context.SaveChangesAsync();

            }

            else

            {

                var retVal = new global::System.Threading.Tasks.TaskCompletionSource<object>();

                retVal.SetResult(null);

                return retVal.Task;

            }

        }

        public global::Microsoft.Graph.ImailFolderFetcher this[System.String id]

        {

            get

            {

                var path = GetPath<global::Microsoft.Graph.mailFolder>((i) => i.id == id);

                var fetcher = new global::Microsoft.Graph.mailFolderFetcher();

                fetcher.Initialize(Context, path);

                

                return fetcher;

            }

        }

    }

    internal partial class mailFolderCollection

    {

        public global::System.Threading.Tasks.Task<System.Int64> CountAsync()

        {

            return new DataServiceQuerySingle<long>(Context, Path + "/$count").GetValueAsync();

        }

    }

    internal partial class mailFolderFetcher

    {

    }

    public partial class mailFolder

    {

    }

    [global::Microsoft.OData.Client.Key("id")]

    public partial class calendarGroup:Microsoft.OData.ProxyExtensions.EntityBase, global::Microsoft.Graph.IcalendarGroup, global::Microsoft.Graph.IcalendarGroupFetcher

    {

        private global::Microsoft.Graph.calendarCollection _calendarsCollection;

        private System.String _name;

        private System.Nullable<System.Guid> _classId;

        private System.String _changeKey;

        private System.String _id;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.calendar> _calendarsConcrete;

        public System.String name

        {

            get

            {

                return _name;

            }

            set

            {

                if (value != _name)

                {

                    _name = value;

                    OnPropertyChanged("name");

                }

            }

        }

        public System.Nullable<System.Guid> classId

        {

            get

            {

                return _classId;

            }

            set

            {

                if (value != _classId)

                {

                    _classId = value;

                    OnPropertyChanged("classId");

                }

            }

        }

        public System.String changeKey

        {

            get

            {

                return _changeKey;

            }

            set

            {

                if (value != _changeKey)

                {

                    _changeKey = value;

                    OnPropertyChanged("changeKey");

                }

            }

        }

        public System.String id

        {

            get

            {

                return _id;

            }

            set

            {

                if (value != _id)

                {

                    _id = value;

                    OnPropertyChanged("id");

                }

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.Icalendar> global::Microsoft.Graph.IcalendarGroup.calendars

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.Icalendar, global::Microsoft.Graph.calendar>(Context, (DataServiceCollection<global::Microsoft.Graph.calendar>) calendars);

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.calendar> calendars

        {

            get

            {

                if (this._calendarsConcrete == null)

                {

                    this._calendarsConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.calendar>();

                    this._calendarsConcrete.SetContainer(() => GetContainingEntity("calendars"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.calendar>)this._calendarsConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                calendars.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        calendars.Add(i);

                    }

                }

            }

        }

        global::Microsoft.Graph.IcalendarCollection global::Microsoft.Graph.IcalendarGroupFetcher.calendars

        {

            get

            {

                if (this._calendarsCollection == null)

                {

                    this._calendarsCollection = new global::Microsoft.Graph.calendarCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.calendar>(GetPath("calendars")) : null,
                       Context,
                       this,
                       GetPath("calendars"));

                }

                

                return this._calendarsCollection;

            }

        }

        public calendarGroup(): base()

        {

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IcalendarGroup> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.calendarGroup, global::Microsoft.Graph.IcalendarGroup>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IcalendarGroup> _query;

        global::System.Threading.Tasks.Task<global::Microsoft.Graph.IcalendarGroup> global::Microsoft.Graph.IcalendarGroupFetcher.ExecuteAsync()

        {

            var tsc = new global::System.Threading.Tasks.TaskCompletionSource<global::Microsoft.Graph.IcalendarGroup>();

            tsc.SetResult(this);

            return tsc.Task;

        }

        global::Microsoft.Graph.IcalendarGroupFetcher global::Microsoft.Graph.IcalendarGroupFetcher.Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.IcalendarGroup, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IcalendarGroupFetcher) this;

        }

    }

    internal partial class calendarGroupFetcher:Microsoft.OData.ProxyExtensions.RestShallowObjectFetcher, global::Microsoft.Graph.IcalendarGroupFetcher

    {

        private global::Microsoft.Graph.calendarCollection _calendarsCollection;

        public global::Microsoft.Graph.IcalendarCollection calendars

        {

            get

            {

                if (this._calendarsCollection == null)

                {

                    this._calendarsCollection = new global::Microsoft.Graph.calendarCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.calendar>(GetPath("calendars")) : null,
                       Context,
                       this,
                       GetPath("calendars"));

                }

                

                return this._calendarsCollection;

            }

        }

        public calendarGroupFetcher(): base()

        {

        }

        public async global::System.Threading.Tasks.Task<global::Microsoft.Graph.IcalendarGroup> ExecuteAsync()

        {

            return await EnsureQuery().ExecuteSingleAsync();

        }

        public global::Microsoft.Graph.IcalendarGroupFetcher Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.IcalendarGroup, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IcalendarGroupFetcher) new global::Microsoft.Graph.calendarGroupFetcher()

            {

                _query = this.EnsureQuery().Expand<TTarget>(navigationPropertyAccessor)

            }

            ;

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IcalendarGroup> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.calendarGroup, global::Microsoft.Graph.IcalendarGroup>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IcalendarGroup> _query;

    }

    internal partial class calendarGroupCollection:Microsoft.OData.ProxyExtensions.QueryableSet<global::Microsoft.Graph.IcalendarGroup>, global::Microsoft.Graph.IcalendarGroupCollection

    {

        internal calendarGroupCollection(global::Microsoft.OData.Client.DataServiceQuery inner,Microsoft.OData.ProxyExtensions.DataServiceContextWrapper context,object entity,string path): base(inner, context, entity as Microsoft.OData.ProxyExtensions.EntityBase, path)

        {

        }

        public global::Microsoft.Graph.IcalendarGroupFetcher GetById(System.String id)

        {

            return this[id];

        }

        public global::System.Threading.Tasks.Task<Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.IcalendarGroup>> ExecuteAsync()

        {

            return ExecuteAsyncInternal();

        }

        public global::System.Threading.Tasks.Task AddcalendarGroupAsync(global::Microsoft.Graph.IcalendarGroup item, System.Boolean deferSaveChanges = false)

        {

            if (Entity == null)

            {

                Context.AddObject(Path, item);

            }

            else

            {

                var lastSlash = Path.LastIndexOf('/');

                var shortPath = (lastSlash >= 0 && lastSlash < Path.Length - 1) ? Path.Substring(lastSlash + 1) : Path;

                Context.AddRelatedObject(Entity, shortPath, item);

            }

            if (!deferSaveChanges)

            {

                return Context.SaveChangesAsync();

            }

            else

            {

                var retVal = new global::System.Threading.Tasks.TaskCompletionSource<object>();

                retVal.SetResult(null);

                return retVal.Task;

            }

        }

        public global::Microsoft.Graph.IcalendarGroupFetcher this[System.String id]

        {

            get

            {

                var path = GetPath<global::Microsoft.Graph.calendarGroup>((i) => i.id == id);

                var fetcher = new global::Microsoft.Graph.calendarGroupFetcher();

                fetcher.Initialize(Context, path);

                

                return fetcher;

            }

        }

    }

    internal partial class calendarGroupCollection

    {

        public global::System.Threading.Tasks.Task<System.Int64> CountAsync()

        {

            return new DataServiceQuerySingle<long>(Context, Path + "/$count").GetValueAsync();

        }

    }

    internal partial class calendarGroupFetcher

    {

    }

    public partial class calendarGroup

    {

    }

    [global::Microsoft.OData.Client.Key("id")]

    public partial class person:Microsoft.OData.ProxyExtensions.EntityBase, global::Microsoft.Graph.Iperson, global::Microsoft.Graph.IpersonFetcher

    {

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.personDataSource> _sources;

        private System.String _displayName;

        private System.String _givenName;

        private System.String _surname;

        private System.String _title;

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.email> _emailAddresses;

        private System.String _companyName;

        private System.String _officeLocation;

        private System.String _id;

        public System.Collections.Generic.IList<global::Microsoft.Graph.personDataSource> sources

        {

            get

            {

                if (this._sources == default(System.Collections.Generic.IList<global::Microsoft.Graph.personDataSource>))

                {

                    this._sources = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.personDataSource>();

                    this._sources.SetContainer(() => GetContainingEntity("sources"));

                }

                return this._sources;

            }

            set

            {

                sources.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        sources.Add(i);

                    }

                }

            }

        }

        public System.String displayName

        {

            get

            {

                return _displayName;

            }

            set

            {

                if (value != _displayName)

                {

                    _displayName = value;

                    OnPropertyChanged("displayName");

                }

            }

        }

        public System.String givenName

        {

            get

            {

                return _givenName;

            }

            set

            {

                if (value != _givenName)

                {

                    _givenName = value;

                    OnPropertyChanged("givenName");

                }

            }

        }

        public System.String surname

        {

            get

            {

                return _surname;

            }

            set

            {

                if (value != _surname)

                {

                    _surname = value;

                    OnPropertyChanged("surname");

                }

            }

        }

        public System.String title

        {

            get

            {

                return _title;

            }

            set

            {

                if (value != _title)

                {

                    _title = value;

                    OnPropertyChanged("title");

                }

            }

        }

        public System.Collections.Generic.IList<global::Microsoft.Graph.email> emailAddresses

        {

            get

            {

                if (this._emailAddresses == default(System.Collections.Generic.IList<global::Microsoft.Graph.email>))

                {

                    this._emailAddresses = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.email>();

                    this._emailAddresses.SetContainer(() => GetContainingEntity("emailAddresses"));

                }

                return this._emailAddresses;

            }

            set

            {

                emailAddresses.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        emailAddresses.Add(i);

                    }

                }

            }

        }

        public System.String companyName

        {

            get

            {

                return _companyName;

            }

            set

            {

                if (value != _companyName)

                {

                    _companyName = value;

                    OnPropertyChanged("companyName");

                }

            }

        }

        public System.String officeLocation

        {

            get

            {

                return _officeLocation;

            }

            set

            {

                if (value != _officeLocation)

                {

                    _officeLocation = value;

                    OnPropertyChanged("officeLocation");

                }

            }

        }

        public System.String id

        {

            get

            {

                return _id;

            }

            set

            {

                if (value != _id)

                {

                    _id = value;

                    OnPropertyChanged("id");

                }

            }

        }

        public person(): base()

        {

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Iperson> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.person, global::Microsoft.Graph.Iperson>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Iperson> _query;

        global::System.Threading.Tasks.Task<global::Microsoft.Graph.Iperson> global::Microsoft.Graph.IpersonFetcher.ExecuteAsync()

        {

            var tsc = new global::System.Threading.Tasks.TaskCompletionSource<global::Microsoft.Graph.Iperson>();

            tsc.SetResult(this);

            return tsc.Task;

        }

        global::Microsoft.Graph.IpersonFetcher global::Microsoft.Graph.IpersonFetcher.Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.Iperson, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IpersonFetcher) this;

        }

    }

    internal partial class personFetcher:Microsoft.OData.ProxyExtensions.RestShallowObjectFetcher, global::Microsoft.Graph.IpersonFetcher

    {

        public personFetcher(): base()

        {

        }

        public async global::System.Threading.Tasks.Task<global::Microsoft.Graph.Iperson> ExecuteAsync()

        {

            return await EnsureQuery().ExecuteSingleAsync();

        }

        public global::Microsoft.Graph.IpersonFetcher Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.Iperson, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IpersonFetcher) new global::Microsoft.Graph.personFetcher()

            {

                _query = this.EnsureQuery().Expand<TTarget>(navigationPropertyAccessor)

            }

            ;

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Iperson> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.person, global::Microsoft.Graph.Iperson>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Iperson> _query;

    }

    internal partial class personCollection:Microsoft.OData.ProxyExtensions.QueryableSet<global::Microsoft.Graph.Iperson>, global::Microsoft.Graph.IpersonCollection

    {

        internal personCollection(global::Microsoft.OData.Client.DataServiceQuery inner,Microsoft.OData.ProxyExtensions.DataServiceContextWrapper context,object entity,string path): base(inner, context, entity as Microsoft.OData.ProxyExtensions.EntityBase, path)

        {

        }

        public global::Microsoft.Graph.IpersonFetcher GetById(System.String id)

        {

            return this[id];

        }

        public global::System.Threading.Tasks.Task<Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.Iperson>> ExecuteAsync()

        {

            return ExecuteAsyncInternal();

        }

        public global::System.Threading.Tasks.Task AddpersonAsync(global::Microsoft.Graph.Iperson item, System.Boolean deferSaveChanges = false)

        {

            if (Entity == null)

            {

                Context.AddObject(Path, item);

            }

            else

            {

                var lastSlash = Path.LastIndexOf('/');

                var shortPath = (lastSlash >= 0 && lastSlash < Path.Length - 1) ? Path.Substring(lastSlash + 1) : Path;

                Context.AddRelatedObject(Entity, shortPath, item);

            }

            if (!deferSaveChanges)

            {

                return Context.SaveChangesAsync();

            }

            else

            {

                var retVal = new global::System.Threading.Tasks.TaskCompletionSource<object>();

                retVal.SetResult(null);

                return retVal.Task;

            }

        }

        public global::Microsoft.Graph.IpersonFetcher this[System.String id]

        {

            get

            {

                var path = GetPath<global::Microsoft.Graph.person>((i) => i.id == id);

                var fetcher = new global::Microsoft.Graph.personFetcher();

                fetcher.Initialize(Context, path);

                

                return fetcher;

            }

        }

    }

    internal partial class personCollection

    {

        public global::System.Threading.Tasks.Task<System.Int64> CountAsync()

        {

            return new DataServiceQuerySingle<long>(Context, Path + "/$count").GetValueAsync();

        }

    }

    internal partial class personFetcher

    {

    }

    public partial class person

    {

    }

    [global::Microsoft.OData.Client.Key("id")]

    public partial class contact:global::Microsoft.Graph.outlookItem, global::Microsoft.Graph.Icontact, global::Microsoft.Graph.IcontactFetcher

    {

        private global::Microsoft.Graph.profilePhoto _photo;

        private global::Microsoft.Graph.profilePhotoFetcher _photoFetcher;

        private global::Microsoft.Graph.extensionCollection _extensionsCollection;

        private System.String _parentFolderId;

        private System.Nullable<System.DateTimeOffset> _birthday;

        private System.String _fileAs;

        private System.String _displayName;

        private System.String _givenName;

        private System.String _initials;

        private System.String _middleName;

        private System.String _nickName;

        private System.String _surname;

        private System.String _title;

        private System.String _yomiGivenName;

        private System.String _yomiSurname;

        private System.String _yomiCompanyName;

        private System.String _generation;

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.emailAddress> _emailAddresses;

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.String> _imAddresses;

        private System.String _jobTitle;

        private System.String _companyName;

        private System.String _department;

        private System.String _officeLocation;

        private System.String _profession;

        private System.String _businessHomePage;

        private System.String _assistantName;

        private System.String _manager;

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.String> _homePhones;

        private System.String _mobilePhone1;

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.String> _businessPhones;

        private global::Microsoft.Graph.physicalAddress _homeAddress;

        private global::Microsoft.Graph.physicalAddress _businessAddress;

        private global::Microsoft.Graph.physicalAddress _otherAddress;

        private System.String _spouseName;

        private System.String _personalNotes;

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.String> _children;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.extension> _extensionsConcrete;

        public System.String parentFolderId

        {

            get

            {

                return _parentFolderId;

            }

            set

            {

                if (value != _parentFolderId)

                {

                    _parentFolderId = value;

                    OnPropertyChanged("parentFolderId");

                }

            }

        }

        public System.Nullable<System.DateTimeOffset> birthday

        {

            get

            {

                return _birthday;

            }

            set

            {

                if (value != _birthday)

                {

                    _birthday = value;

                    OnPropertyChanged("birthday");

                }

            }

        }

        public System.String fileAs

        {

            get

            {

                return _fileAs;

            }

            set

            {

                if (value != _fileAs)

                {

                    _fileAs = value;

                    OnPropertyChanged("fileAs");

                }

            }

        }

        public System.String displayName

        {

            get

            {

                return _displayName;

            }

            set

            {

                if (value != _displayName)

                {

                    _displayName = value;

                    OnPropertyChanged("displayName");

                }

            }

        }

        public System.String givenName

        {

            get

            {

                return _givenName;

            }

            set

            {

                if (value != _givenName)

                {

                    _givenName = value;

                    OnPropertyChanged("givenName");

                }

            }

        }

        public System.String initials

        {

            get

            {

                return _initials;

            }

            set

            {

                if (value != _initials)

                {

                    _initials = value;

                    OnPropertyChanged("initials");

                }

            }

        }

        public System.String middleName

        {

            get

            {

                return _middleName;

            }

            set

            {

                if (value != _middleName)

                {

                    _middleName = value;

                    OnPropertyChanged("middleName");

                }

            }

        }

        public System.String nickName

        {

            get

            {

                return _nickName;

            }

            set

            {

                if (value != _nickName)

                {

                    _nickName = value;

                    OnPropertyChanged("nickName");

                }

            }

        }

        public System.String surname

        {

            get

            {

                return _surname;

            }

            set

            {

                if (value != _surname)

                {

                    _surname = value;

                    OnPropertyChanged("surname");

                }

            }

        }

        public System.String title

        {

            get

            {

                return _title;

            }

            set

            {

                if (value != _title)

                {

                    _title = value;

                    OnPropertyChanged("title");

                }

            }

        }

        public System.String yomiGivenName

        {

            get

            {

                return _yomiGivenName;

            }

            set

            {

                if (value != _yomiGivenName)

                {

                    _yomiGivenName = value;

                    OnPropertyChanged("yomiGivenName");

                }

            }

        }

        public System.String yomiSurname

        {

            get

            {

                return _yomiSurname;

            }

            set

            {

                if (value != _yomiSurname)

                {

                    _yomiSurname = value;

                    OnPropertyChanged("yomiSurname");

                }

            }

        }

        public System.String yomiCompanyName

        {

            get

            {

                return _yomiCompanyName;

            }

            set

            {

                if (value != _yomiCompanyName)

                {

                    _yomiCompanyName = value;

                    OnPropertyChanged("yomiCompanyName");

                }

            }

        }

        public System.String generation

        {

            get

            {

                return _generation;

            }

            set

            {

                if (value != _generation)

                {

                    _generation = value;

                    OnPropertyChanged("generation");

                }

            }

        }

        public System.Collections.Generic.IList<global::Microsoft.Graph.emailAddress> emailAddresses

        {

            get

            {

                if (this._emailAddresses == default(System.Collections.Generic.IList<global::Microsoft.Graph.emailAddress>))

                {

                    this._emailAddresses = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.emailAddress>();

                    this._emailAddresses.SetContainer(() => GetContainingEntity("emailAddresses"));

                }

                return this._emailAddresses;

            }

            set

            {

                emailAddresses.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        emailAddresses.Add(i);

                    }

                }

            }

        }

        public System.Collections.Generic.IList<System.String> imAddresses

        {

            get

            {

                if (this._imAddresses == default(System.Collections.Generic.IList<System.String>))

                {

                    this._imAddresses = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.String>();

                    this._imAddresses.SetContainer(() => GetContainingEntity("imAddresses"));

                }

                return this._imAddresses;

            }

            set

            {

                imAddresses.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        imAddresses.Add(i);

                    }

                }

            }

        }

        public System.String jobTitle

        {

            get

            {

                return _jobTitle;

            }

            set

            {

                if (value != _jobTitle)

                {

                    _jobTitle = value;

                    OnPropertyChanged("jobTitle");

                }

            }

        }

        public System.String companyName

        {

            get

            {

                return _companyName;

            }

            set

            {

                if (value != _companyName)

                {

                    _companyName = value;

                    OnPropertyChanged("companyName");

                }

            }

        }

        public System.String department

        {

            get

            {

                return _department;

            }

            set

            {

                if (value != _department)

                {

                    _department = value;

                    OnPropertyChanged("department");

                }

            }

        }

        public System.String officeLocation

        {

            get

            {

                return _officeLocation;

            }

            set

            {

                if (value != _officeLocation)

                {

                    _officeLocation = value;

                    OnPropertyChanged("officeLocation");

                }

            }

        }

        public System.String profession

        {

            get

            {

                return _profession;

            }

            set

            {

                if (value != _profession)

                {

                    _profession = value;

                    OnPropertyChanged("profession");

                }

            }

        }

        public System.String businessHomePage

        {

            get

            {

                return _businessHomePage;

            }

            set

            {

                if (value != _businessHomePage)

                {

                    _businessHomePage = value;

                    OnPropertyChanged("businessHomePage");

                }

            }

        }

        public System.String assistantName

        {

            get

            {

                return _assistantName;

            }

            set

            {

                if (value != _assistantName)

                {

                    _assistantName = value;

                    OnPropertyChanged("assistantName");

                }

            }

        }

        public System.String manager

        {

            get

            {

                return _manager;

            }

            set

            {

                if (value != _manager)

                {

                    _manager = value;

                    OnPropertyChanged("manager");

                }

            }

        }

        public System.Collections.Generic.IList<System.String> homePhones

        {

            get

            {

                if (this._homePhones == default(System.Collections.Generic.IList<System.String>))

                {

                    this._homePhones = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.String>();

                    this._homePhones.SetContainer(() => GetContainingEntity("homePhones"));

                }

                return this._homePhones;

            }

            set

            {

                homePhones.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        homePhones.Add(i);

                    }

                }

            }

        }

        public System.String mobilePhone1

        {

            get

            {

                return _mobilePhone1;

            }

            set

            {

                if (value != _mobilePhone1)

                {

                    _mobilePhone1 = value;

                    OnPropertyChanged("mobilePhone1");

                }

            }

        }

        public System.Collections.Generic.IList<System.String> businessPhones

        {

            get

            {

                if (this._businessPhones == default(System.Collections.Generic.IList<System.String>))

                {

                    this._businessPhones = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.String>();

                    this._businessPhones.SetContainer(() => GetContainingEntity("businessPhones"));

                }

                return this._businessPhones;

            }

            set

            {

                businessPhones.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        businessPhones.Add(i);

                    }

                }

            }

        }

        public global::Microsoft.Graph.physicalAddress homeAddress

        {

            get

            {

                return _homeAddress;

            }

            set

            {

                if (value != _homeAddress)

                {

                    _homeAddress = value;

                    OnPropertyChanged("homeAddress");

                }

            }

        }

        public global::Microsoft.Graph.physicalAddress businessAddress

        {

            get

            {

                return _businessAddress;

            }

            set

            {

                if (value != _businessAddress)

                {

                    _businessAddress = value;

                    OnPropertyChanged("businessAddress");

                }

            }

        }

        public global::Microsoft.Graph.physicalAddress otherAddress

        {

            get

            {

                return _otherAddress;

            }

            set

            {

                if (value != _otherAddress)

                {

                    _otherAddress = value;

                    OnPropertyChanged("otherAddress");

                }

            }

        }

        public System.String spouseName

        {

            get

            {

                return _spouseName;

            }

            set

            {

                if (value != _spouseName)

                {

                    _spouseName = value;

                    OnPropertyChanged("spouseName");

                }

            }

        }

        public System.String personalNotes

        {

            get

            {

                return _personalNotes;

            }

            set

            {

                if (value != _personalNotes)

                {

                    _personalNotes = value;

                    OnPropertyChanged("personalNotes");

                }

            }

        }

        public System.Collections.Generic.IList<System.String> children

        {

            get

            {

                if (this._children == default(System.Collections.Generic.IList<System.String>))

                {

                    this._children = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.String>();

                    this._children.SetContainer(() => GetContainingEntity("children"));

                }

                return this._children;

            }

            set

            {

                children.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        children.Add(i);

                    }

                }

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.Iextension> global::Microsoft.Graph.Icontact.extensions

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.Iextension, global::Microsoft.Graph.extension>(Context, (DataServiceCollection<global::Microsoft.Graph.extension>) extensions);

            }

        }

        global::Microsoft.Graph.IprofilePhoto global::Microsoft.Graph.Icontact.photo

        {

            get

            {

                return this._photo;

            }

            set

            {

                if (this.photo != value)

                {

                    this.photo = (global::Microsoft.Graph.profilePhoto)value;

                }

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.extension> extensions

        {

            get

            {

                if (this._extensionsConcrete == null)

                {

                    this._extensionsConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.extension>();

                    this._extensionsConcrete.SetContainer(() => GetContainingEntity("extensions"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.extension>)this._extensionsConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                extensions.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        extensions.Add(i);

                    }

                }

            }

        }

        public global::Microsoft.Graph.profilePhoto photo

        {

            get

            {

                return this._photo;

            }

            set

            {

                if (this._photo != value)

                {

                    this._photo = value;

                    if (Context != null && Context.GetEntityDescriptor(this) != null && (value == null || Context.GetEntityDescriptor(value) != null))

                    {

                        Context.SetLink(this, "photo", value);

                    }

                }

            }

        }

        global::Microsoft.Graph.IextensionCollection global::Microsoft.Graph.IcontactFetcher.extensions

        {

            get

            {

                if (this._extensionsCollection == null)

                {

                    this._extensionsCollection = new global::Microsoft.Graph.extensionCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.extension>(GetPath("extensions")) : null,
                       Context,
                       this,
                       GetPath("extensions"));

                }

                

                return this._extensionsCollection;

            }

        }

        global::Microsoft.Graph.IprofilePhotoFetcher global::Microsoft.Graph.IcontactFetcher.photo

        {

            get

            {

                if (this._photoFetcher == null)

                {

                    this._photoFetcher = new global::Microsoft.Graph.profilePhotoFetcher();

                    this._photoFetcher.Initialize(this.Context, GetPath("photo"));

                }

                

                return this._photoFetcher;

            }

        }

        public contact()

        {

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Icontact> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.contact, global::Microsoft.Graph.Icontact>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Icontact> _query;

        global::System.Threading.Tasks.Task<global::Microsoft.Graph.Icontact> global::Microsoft.Graph.IcontactFetcher.ExecuteAsync()

        {

            var tsc = new global::System.Threading.Tasks.TaskCompletionSource<global::Microsoft.Graph.Icontact>();

            tsc.SetResult(this);

            return tsc.Task;

        }

        global::Microsoft.Graph.IcontactFetcher global::Microsoft.Graph.IcontactFetcher.Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.Icontact, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IcontactFetcher) this;

        }

    }

    internal partial class contactFetcher:global::Microsoft.Graph.outlookItemFetcher, global::Microsoft.Graph.IcontactFetcher

    {

        private global::Microsoft.Graph.profilePhotoFetcher _photoFetcher;

        private global::Microsoft.Graph.extensionCollection _extensionsCollection;

        public global::Microsoft.Graph.IextensionCollection extensions

        {

            get

            {

                if (this._extensionsCollection == null)

                {

                    this._extensionsCollection = new global::Microsoft.Graph.extensionCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.extension>(GetPath("extensions")) : null,
                       Context,
                       this,
                       GetPath("extensions"));

                }

                

                return this._extensionsCollection;

            }

        }

        public global::Microsoft.Graph.IprofilePhotoFetcher photo

        {

            get

            {

                if (this._photoFetcher == null)

                {

                    this._photoFetcher = new global::Microsoft.Graph.profilePhotoFetcher();

                    this._photoFetcher.Initialize(this.Context, GetPath("photo"));

                }

                

                return this._photoFetcher;

            }

        }

        public contactFetcher()

        {

        }

        public async global::System.Threading.Tasks.Task<global::Microsoft.Graph.Icontact> ExecuteAsync()

        {

            return await EnsureQuery().ExecuteSingleAsync();

        }

        public global::Microsoft.Graph.IcontactFetcher Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.Icontact, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IcontactFetcher) new global::Microsoft.Graph.contactFetcher()

            {

                _query = this.EnsureQuery().Expand<TTarget>(navigationPropertyAccessor)

            }

            ;

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Icontact> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.contact, global::Microsoft.Graph.Icontact>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Icontact> _query;

    }

    internal partial class contactCollection:Microsoft.OData.ProxyExtensions.QueryableSet<global::Microsoft.Graph.Icontact>, global::Microsoft.Graph.IcontactCollection

    {

        internal contactCollection(global::Microsoft.OData.Client.DataServiceQuery inner,Microsoft.OData.ProxyExtensions.DataServiceContextWrapper context,object entity,string path): base(inner, context, entity as Microsoft.OData.ProxyExtensions.EntityBase, path)

        {

        }

        public global::Microsoft.Graph.IcontactFetcher GetById(System.String id)

        {

            return this[id];

        }

        public global::System.Threading.Tasks.Task<Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.Icontact>> ExecuteAsync()

        {

            return ExecuteAsyncInternal();

        }

        public global::System.Threading.Tasks.Task AddcontactAsync(global::Microsoft.Graph.Icontact item, System.Boolean deferSaveChanges = false)

        {

            if (Entity == null)

            {

                Context.AddObject(Path, item);

            }

            else

            {

                var lastSlash = Path.LastIndexOf('/');

                var shortPath = (lastSlash >= 0 && lastSlash < Path.Length - 1) ? Path.Substring(lastSlash + 1) : Path;

                Context.AddRelatedObject(Entity, shortPath, item);

            }

            if (!deferSaveChanges)

            {

                return Context.SaveChangesAsync();

            }

            else

            {

                var retVal = new global::System.Threading.Tasks.TaskCompletionSource<object>();

                retVal.SetResult(null);

                return retVal.Task;

            }

        }

        public global::Microsoft.Graph.IcontactFetcher this[System.String id]

        {

            get

            {

                var path = GetPath<global::Microsoft.Graph.contact>((i) => i.id == id);

                var fetcher = new global::Microsoft.Graph.contactFetcher();

                fetcher.Initialize(Context, path);

                

                return fetcher;

            }

        }

    }

    internal partial class contactCollection

    {

        public global::System.Threading.Tasks.Task<System.Int64> CountAsync()

        {

            return new DataServiceQuerySingle<long>(Context, Path + "/$count").GetValueAsync();

        }

    }

    [global::Microsoft.OData.Client.Key("id")]

    public partial class contactFolder:Microsoft.OData.ProxyExtensions.EntityBase, global::Microsoft.Graph.IcontactFolder, global::Microsoft.Graph.IcontactFolderFetcher

    {

        private global::Microsoft.Graph.contactCollection _contactsCollection;

        private global::Microsoft.Graph.contactFolderCollection _childFoldersCollection;

        private System.String _parentFolderId;

        private System.String _displayName;

        private System.String _id;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.contact> _contactsConcrete;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.contactFolder> _childFoldersConcrete;

        public System.String parentFolderId

        {

            get

            {

                return _parentFolderId;

            }

            set

            {

                if (value != _parentFolderId)

                {

                    _parentFolderId = value;

                    OnPropertyChanged("parentFolderId");

                }

            }

        }

        public System.String displayName

        {

            get

            {

                return _displayName;

            }

            set

            {

                if (value != _displayName)

                {

                    _displayName = value;

                    OnPropertyChanged("displayName");

                }

            }

        }

        public System.String id

        {

            get

            {

                return _id;

            }

            set

            {

                if (value != _id)

                {

                    _id = value;

                    OnPropertyChanged("id");

                }

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.Icontact> global::Microsoft.Graph.IcontactFolder.contacts

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.Icontact, global::Microsoft.Graph.contact>(Context, (DataServiceCollection<global::Microsoft.Graph.contact>) contacts);

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.IcontactFolder> global::Microsoft.Graph.IcontactFolder.childFolders

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.IcontactFolder, global::Microsoft.Graph.contactFolder>(Context, (DataServiceCollection<global::Microsoft.Graph.contactFolder>) childFolders);

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.contact> contacts

        {

            get

            {

                if (this._contactsConcrete == null)

                {

                    this._contactsConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.contact>();

                    this._contactsConcrete.SetContainer(() => GetContainingEntity("contacts"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.contact>)this._contactsConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                contacts.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        contacts.Add(i);

                    }

                }

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.contactFolder> childFolders

        {

            get

            {

                if (this._childFoldersConcrete == null)

                {

                    this._childFoldersConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.contactFolder>();

                    this._childFoldersConcrete.SetContainer(() => GetContainingEntity("childFolders"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.contactFolder>)this._childFoldersConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                childFolders.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        childFolders.Add(i);

                    }

                }

            }

        }

        global::Microsoft.Graph.IcontactCollection global::Microsoft.Graph.IcontactFolderFetcher.contacts

        {

            get

            {

                if (this._contactsCollection == null)

                {

                    this._contactsCollection = new global::Microsoft.Graph.contactCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.contact>(GetPath("contacts")) : null,
                       Context,
                       this,
                       GetPath("contacts"));

                }

                

                return this._contactsCollection;

            }

        }

        global::Microsoft.Graph.IcontactFolderCollection global::Microsoft.Graph.IcontactFolderFetcher.childFolders

        {

            get

            {

                if (this._childFoldersCollection == null)

                {

                    this._childFoldersCollection = new global::Microsoft.Graph.contactFolderCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.contactFolder>(GetPath("childFolders")) : null,
                       Context,
                       this,
                       GetPath("childFolders"));

                }

                

                return this._childFoldersCollection;

            }

        }

        public contactFolder(): base()

        {

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IcontactFolder> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.contactFolder, global::Microsoft.Graph.IcontactFolder>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IcontactFolder> _query;

        global::System.Threading.Tasks.Task<global::Microsoft.Graph.IcontactFolder> global::Microsoft.Graph.IcontactFolderFetcher.ExecuteAsync()

        {

            var tsc = new global::System.Threading.Tasks.TaskCompletionSource<global::Microsoft.Graph.IcontactFolder>();

            tsc.SetResult(this);

            return tsc.Task;

        }

        global::Microsoft.Graph.IcontactFolderFetcher global::Microsoft.Graph.IcontactFolderFetcher.Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.IcontactFolder, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IcontactFolderFetcher) this;

        }

    }

    internal partial class contactFolderFetcher:Microsoft.OData.ProxyExtensions.RestShallowObjectFetcher, global::Microsoft.Graph.IcontactFolderFetcher

    {

        private global::Microsoft.Graph.contactCollection _contactsCollection;

        private global::Microsoft.Graph.contactFolderCollection _childFoldersCollection;

        public global::Microsoft.Graph.IcontactCollection contacts

        {

            get

            {

                if (this._contactsCollection == null)

                {

                    this._contactsCollection = new global::Microsoft.Graph.contactCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.contact>(GetPath("contacts")) : null,
                       Context,
                       this,
                       GetPath("contacts"));

                }

                

                return this._contactsCollection;

            }

        }

        public global::Microsoft.Graph.IcontactFolderCollection childFolders

        {

            get

            {

                if (this._childFoldersCollection == null)

                {

                    this._childFoldersCollection = new global::Microsoft.Graph.contactFolderCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.contactFolder>(GetPath("childFolders")) : null,
                       Context,
                       this,
                       GetPath("childFolders"));

                }

                

                return this._childFoldersCollection;

            }

        }

        public contactFolderFetcher(): base()

        {

        }

        public async global::System.Threading.Tasks.Task<global::Microsoft.Graph.IcontactFolder> ExecuteAsync()

        {

            return await EnsureQuery().ExecuteSingleAsync();

        }

        public global::Microsoft.Graph.IcontactFolderFetcher Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.IcontactFolder, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IcontactFolderFetcher) new global::Microsoft.Graph.contactFolderFetcher()

            {

                _query = this.EnsureQuery().Expand<TTarget>(navigationPropertyAccessor)

            }

            ;

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IcontactFolder> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.contactFolder, global::Microsoft.Graph.IcontactFolder>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IcontactFolder> _query;

    }

    internal partial class contactFolderCollection:Microsoft.OData.ProxyExtensions.QueryableSet<global::Microsoft.Graph.IcontactFolder>, global::Microsoft.Graph.IcontactFolderCollection

    {

        internal contactFolderCollection(global::Microsoft.OData.Client.DataServiceQuery inner,Microsoft.OData.ProxyExtensions.DataServiceContextWrapper context,object entity,string path): base(inner, context, entity as Microsoft.OData.ProxyExtensions.EntityBase, path)

        {

        }

        public global::Microsoft.Graph.IcontactFolderFetcher GetById(System.String id)

        {

            return this[id];

        }

        public global::System.Threading.Tasks.Task<Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.IcontactFolder>> ExecuteAsync()

        {

            return ExecuteAsyncInternal();

        }

        public global::System.Threading.Tasks.Task AddcontactFolderAsync(global::Microsoft.Graph.IcontactFolder item, System.Boolean deferSaveChanges = false)

        {

            if (Entity == null)

            {

                Context.AddObject(Path, item);

            }

            else

            {

                var lastSlash = Path.LastIndexOf('/');

                var shortPath = (lastSlash >= 0 && lastSlash < Path.Length - 1) ? Path.Substring(lastSlash + 1) : Path;

                Context.AddRelatedObject(Entity, shortPath, item);

            }

            if (!deferSaveChanges)

            {

                return Context.SaveChangesAsync();

            }

            else

            {

                var retVal = new global::System.Threading.Tasks.TaskCompletionSource<object>();

                retVal.SetResult(null);

                return retVal.Task;

            }

        }

        public global::Microsoft.Graph.IcontactFolderFetcher this[System.String id]

        {

            get

            {

                var path = GetPath<global::Microsoft.Graph.contactFolder>((i) => i.id == id);

                var fetcher = new global::Microsoft.Graph.contactFolderFetcher();

                fetcher.Initialize(Context, path);

                

                return fetcher;

            }

        }

    }

    internal partial class contactFolderCollection

    {

        public global::System.Threading.Tasks.Task<System.Int64> CountAsync()

        {

            return new DataServiceQuerySingle<long>(Context, Path + "/$count").GetValueAsync();

        }

    }

    internal partial class contactFolderFetcher

    {

    }

    public partial class contactFolder

    {

    }

    [global::Microsoft.OData.Client.Key("id")]

    public partial class inferenceClassification:Microsoft.OData.ProxyExtensions.EntityBase, global::Microsoft.Graph.IinferenceClassification, global::Microsoft.Graph.IinferenceClassificationFetcher

    {

        private global::Microsoft.Graph.inferenceClassificationOverrideCollection _overridesCollection;

        private System.String _id;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.inferenceClassificationOverride> _overridesConcrete;

        public System.String id

        {

            get

            {

                return _id;

            }

            set

            {

                if (value != _id)

                {

                    _id = value;

                    OnPropertyChanged("id");

                }

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.IinferenceClassificationOverride> global::Microsoft.Graph.IinferenceClassification.overrides

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.IinferenceClassificationOverride, global::Microsoft.Graph.inferenceClassificationOverride>(Context, (DataServiceCollection<global::Microsoft.Graph.inferenceClassificationOverride>) overrides);

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.inferenceClassificationOverride> overrides

        {

            get

            {

                if (this._overridesConcrete == null)

                {

                    this._overridesConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.inferenceClassificationOverride>();

                    this._overridesConcrete.SetContainer(() => GetContainingEntity("overrides"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.inferenceClassificationOverride>)this._overridesConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                overrides.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        overrides.Add(i);

                    }

                }

            }

        }

        global::Microsoft.Graph.IinferenceClassificationOverrideCollection global::Microsoft.Graph.IinferenceClassificationFetcher.overrides

        {

            get

            {

                if (this._overridesCollection == null)

                {

                    this._overridesCollection = new global::Microsoft.Graph.inferenceClassificationOverrideCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.inferenceClassificationOverride>(GetPath("overrides")) : null,
                       Context,
                       this,
                       GetPath("overrides"));

                }

                

                return this._overridesCollection;

            }

        }

        public inferenceClassification(): base()

        {

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IinferenceClassification> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.inferenceClassification, global::Microsoft.Graph.IinferenceClassification>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IinferenceClassification> _query;

        global::System.Threading.Tasks.Task<global::Microsoft.Graph.IinferenceClassification> global::Microsoft.Graph.IinferenceClassificationFetcher.ExecuteAsync()

        {

            var tsc = new global::System.Threading.Tasks.TaskCompletionSource<global::Microsoft.Graph.IinferenceClassification>();

            tsc.SetResult(this);

            return tsc.Task;

        }

        global::Microsoft.Graph.IinferenceClassificationFetcher global::Microsoft.Graph.IinferenceClassificationFetcher.Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.IinferenceClassification, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IinferenceClassificationFetcher) this;

        }

    }

    internal partial class inferenceClassificationFetcher:Microsoft.OData.ProxyExtensions.RestShallowObjectFetcher, global::Microsoft.Graph.IinferenceClassificationFetcher

    {

        private global::Microsoft.Graph.inferenceClassificationOverrideCollection _overridesCollection;

        public global::Microsoft.Graph.IinferenceClassificationOverrideCollection overrides

        {

            get

            {

                if (this._overridesCollection == null)

                {

                    this._overridesCollection = new global::Microsoft.Graph.inferenceClassificationOverrideCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.inferenceClassificationOverride>(GetPath("overrides")) : null,
                       Context,
                       this,
                       GetPath("overrides"));

                }

                

                return this._overridesCollection;

            }

        }

        public inferenceClassificationFetcher(): base()

        {

        }

        public async global::System.Threading.Tasks.Task<global::Microsoft.Graph.IinferenceClassification> ExecuteAsync()

        {

            return await EnsureQuery().ExecuteSingleAsync();

        }

        public global::Microsoft.Graph.IinferenceClassificationFetcher Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.IinferenceClassification, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IinferenceClassificationFetcher) new global::Microsoft.Graph.inferenceClassificationFetcher()

            {

                _query = this.EnsureQuery().Expand<TTarget>(navigationPropertyAccessor)

            }

            ;

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IinferenceClassification> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.inferenceClassification, global::Microsoft.Graph.IinferenceClassification>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IinferenceClassification> _query;

    }

    internal partial class inferenceClassificationCollection:Microsoft.OData.ProxyExtensions.QueryableSet<global::Microsoft.Graph.IinferenceClassification>, global::Microsoft.Graph.IinferenceClassificationCollection

    {

        internal inferenceClassificationCollection(global::Microsoft.OData.Client.DataServiceQuery inner,Microsoft.OData.ProxyExtensions.DataServiceContextWrapper context,object entity,string path): base(inner, context, entity as Microsoft.OData.ProxyExtensions.EntityBase, path)

        {

        }

        public global::Microsoft.Graph.IinferenceClassificationFetcher GetById(System.String id)

        {

            return this[id];

        }

        public global::System.Threading.Tasks.Task<Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.IinferenceClassification>> ExecuteAsync()

        {

            return ExecuteAsyncInternal();

        }

        public global::System.Threading.Tasks.Task AddinferenceClassificationAsync(global::Microsoft.Graph.IinferenceClassification item, System.Boolean deferSaveChanges = false)

        {

            if (Entity == null)

            {

                Context.AddObject(Path, item);

            }

            else

            {

                var lastSlash = Path.LastIndexOf('/');

                var shortPath = (lastSlash >= 0 && lastSlash < Path.Length - 1) ? Path.Substring(lastSlash + 1) : Path;

                Context.AddRelatedObject(Entity, shortPath, item);

            }

            if (!deferSaveChanges)

            {

                return Context.SaveChangesAsync();

            }

            else

            {

                var retVal = new global::System.Threading.Tasks.TaskCompletionSource<object>();

                retVal.SetResult(null);

                return retVal.Task;

            }

        }

        public global::Microsoft.Graph.IinferenceClassificationFetcher this[System.String id]

        {

            get

            {

                var path = GetPath<global::Microsoft.Graph.inferenceClassification>((i) => i.id == id);

                var fetcher = new global::Microsoft.Graph.inferenceClassificationFetcher();

                fetcher.Initialize(Context, path);

                

                return fetcher;

            }

        }

    }

    internal partial class inferenceClassificationCollection

    {

        public global::System.Threading.Tasks.Task<System.Int64> CountAsync()

        {

            return new DataServiceQuerySingle<long>(Context, Path + "/$count").GetValueAsync();

        }

    }

    internal partial class inferenceClassificationFetcher

    {

    }

    public partial class inferenceClassification

    {

    }

    [global::Microsoft.OData.Client.Key("id")]

    public partial class driveItem:Microsoft.OData.ProxyExtensions.EntityBase, global::Microsoft.Graph.IdriveItem, global::Microsoft.Graph.IdriveItemFetcher

    {

        private global::Microsoft.Graph.user _createdByUser;

        private global::Microsoft.Graph.user _lastModifiedByUser;

        private global::Microsoft.Graph.userFetcher _createdByUserFetcher;

        private global::Microsoft.Graph.userFetcher _lastModifiedByUserFetcher;

        private global::Microsoft.Graph.permissionCollection _permissionsCollection;

        private global::Microsoft.Graph.driveItemCollection _versionsCollection;

        private global::Microsoft.Graph.driveItemCollection _childrenCollection;

        private global::Microsoft.Graph.thumbnailSetCollection _thumbnailsCollection;

        private Microsoft.OData.Client.DataServiceStreamLink _content;

        private global::Microsoft.Graph.identitySet _createdBy;

        private System.Nullable<System.DateTimeOffset> _createdDateTime;

        private System.String _cTag;

        private System.String _description;

        private System.String _eTag;

        private System.String _id;

        private global::Microsoft.Graph.identitySet _lastModifiedBy;

        private System.Nullable<System.DateTimeOffset> _lastModifiedDateTime;

        private System.String _name;

        private global::Microsoft.Graph.itemReference _parentReference;

        private System.Nullable<System.Int64> _size;

        private System.String _webDavUrl;

        private System.String _webUrl;

        private global::Microsoft.Graph.audio _audio;

        private global::Microsoft.Graph.deleted _deleted;

        private global::Microsoft.Graph.file _file;

        private global::Microsoft.Graph.fileSystemInfo _fileSystemInfo;

        private global::Microsoft.Graph.folder _folder;

        private global::Microsoft.Graph.image _image;

        private global::Microsoft.Graph.geoCoordinates _location;

        private global::Microsoft.Graph.openWithSet _openWith;

        private global::Microsoft.Graph.photo _photo;

        private global::Microsoft.Graph.searchResult _searchResult;

        private global::Microsoft.Graph.shared _shared;

        private global::Microsoft.Graph.specialFolder _specialFolder;

        private global::Microsoft.Graph.video _video;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.permission> _permissionsConcrete;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.driveItem> _versionsConcrete;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.driveItem> _childrenConcrete;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.thumbnailSet> _thumbnailsConcrete;

        public Microsoft.OData.Client.DataServiceStreamLink content

        {

            get

            {

                return _content;

            }

            set

            {

                if (value != _content)

                {

                    _content = value;

                    OnPropertyChanged("content");

                }

            }

        }

        public global::Microsoft.Graph.identitySet createdBy

        {

            get

            {

                return _createdBy;

            }

            set

            {

                if (value != _createdBy)

                {

                    _createdBy = value;

                    OnPropertyChanged("createdBy");

                }

            }

        }

        public System.Nullable<System.DateTimeOffset> createdDateTime

        {

            get

            {

                return _createdDateTime;

            }

            set

            {

                if (value != _createdDateTime)

                {

                    _createdDateTime = value;

                    OnPropertyChanged("createdDateTime");

                }

            }

        }

        public System.String cTag

        {

            get

            {

                return _cTag;

            }

            set

            {

                if (value != _cTag)

                {

                    _cTag = value;

                    OnPropertyChanged("cTag");

                }

            }

        }

        public System.String description

        {

            get

            {

                return _description;

            }

            set

            {

                if (value != _description)

                {

                    _description = value;

                    OnPropertyChanged("description");

                }

            }

        }

        public System.String eTag

        {

            get

            {

                return _eTag;

            }

            set

            {

                if (value != _eTag)

                {

                    _eTag = value;

                    OnPropertyChanged("eTag");

                }

            }

        }

        public System.String id

        {

            get

            {

                return _id;

            }

            set

            {

                if (value != _id)

                {

                    _id = value;

                    OnPropertyChanged("id");

                }

            }

        }

        public global::Microsoft.Graph.identitySet lastModifiedBy

        {

            get

            {

                return _lastModifiedBy;

            }

            set

            {

                if (value != _lastModifiedBy)

                {

                    _lastModifiedBy = value;

                    OnPropertyChanged("lastModifiedBy");

                }

            }

        }

        public System.Nullable<System.DateTimeOffset> lastModifiedDateTime

        {

            get

            {

                return _lastModifiedDateTime;

            }

            set

            {

                if (value != _lastModifiedDateTime)

                {

                    _lastModifiedDateTime = value;

                    OnPropertyChanged("lastModifiedDateTime");

                }

            }

        }

        public System.String name

        {

            get

            {

                return _name;

            }

            set

            {

                if (value != _name)

                {

                    _name = value;

                    OnPropertyChanged("name");

                }

            }

        }

        public global::Microsoft.Graph.itemReference parentReference

        {

            get

            {

                return _parentReference;

            }

            set

            {

                if (value != _parentReference)

                {

                    _parentReference = value;

                    OnPropertyChanged("parentReference");

                }

            }

        }

        public System.Nullable<System.Int64> size

        {

            get

            {

                return _size;

            }

            set

            {

                if (value != _size)

                {

                    _size = value;

                    OnPropertyChanged("size");

                }

            }

        }

        public System.String webDavUrl

        {

            get

            {

                return _webDavUrl;

            }

            set

            {

                if (value != _webDavUrl)

                {

                    _webDavUrl = value;

                    OnPropertyChanged("webDavUrl");

                }

            }

        }

        public System.String webUrl

        {

            get

            {

                return _webUrl;

            }

            set

            {

                if (value != _webUrl)

                {

                    _webUrl = value;

                    OnPropertyChanged("webUrl");

                }

            }

        }

        public global::Microsoft.Graph.audio audio

        {

            get

            {

                return _audio;

            }

            set

            {

                if (value != _audio)

                {

                    _audio = value;

                    OnPropertyChanged("audio");

                }

            }

        }

        public global::Microsoft.Graph.deleted deleted

        {

            get

            {

                return _deleted;

            }

            set

            {

                if (value != _deleted)

                {

                    _deleted = value;

                    OnPropertyChanged("deleted");

                }

            }

        }

        public global::Microsoft.Graph.file file

        {

            get

            {

                return _file;

            }

            set

            {

                if (value != _file)

                {

                    _file = value;

                    OnPropertyChanged("file");

                }

            }

        }

        public global::Microsoft.Graph.fileSystemInfo fileSystemInfo

        {

            get

            {

                return _fileSystemInfo;

            }

            set

            {

                if (value != _fileSystemInfo)

                {

                    _fileSystemInfo = value;

                    OnPropertyChanged("fileSystemInfo");

                }

            }

        }

        public global::Microsoft.Graph.folder folder

        {

            get

            {

                return _folder;

            }

            set

            {

                if (value != _folder)

                {

                    _folder = value;

                    OnPropertyChanged("folder");

                }

            }

        }

        public global::Microsoft.Graph.image image

        {

            get

            {

                return _image;

            }

            set

            {

                if (value != _image)

                {

                    _image = value;

                    OnPropertyChanged("image");

                }

            }

        }

        public global::Microsoft.Graph.geoCoordinates location

        {

            get

            {

                return _location;

            }

            set

            {

                if (value != _location)

                {

                    _location = value;

                    OnPropertyChanged("location");

                }

            }

        }

        public global::Microsoft.Graph.openWithSet openWith

        {

            get

            {

                return _openWith;

            }

            set

            {

                if (value != _openWith)

                {

                    _openWith = value;

                    OnPropertyChanged("openWith");

                }

            }

        }

        public global::Microsoft.Graph.photo photo

        {

            get

            {

                return _photo;

            }

            set

            {

                if (value != _photo)

                {

                    _photo = value;

                    OnPropertyChanged("photo");

                }

            }

        }

        public global::Microsoft.Graph.searchResult searchResult

        {

            get

            {

                return _searchResult;

            }

            set

            {

                if (value != _searchResult)

                {

                    _searchResult = value;

                    OnPropertyChanged("searchResult");

                }

            }

        }

        public global::Microsoft.Graph.shared shared

        {

            get

            {

                return _shared;

            }

            set

            {

                if (value != _shared)

                {

                    _shared = value;

                    OnPropertyChanged("shared");

                }

            }

        }

        public global::Microsoft.Graph.specialFolder specialFolder

        {

            get

            {

                return _specialFolder;

            }

            set

            {

                if (value != _specialFolder)

                {

                    _specialFolder = value;

                    OnPropertyChanged("specialFolder");

                }

            }

        }

        public global::Microsoft.Graph.video video

        {

            get

            {

                return _video;

            }

            set

            {

                if (value != _video)

                {

                    _video = value;

                    OnPropertyChanged("video");

                }

            }

        }

        global::Microsoft.Graph.Iuser global::Microsoft.Graph.IdriveItem.createdByUser

        {

            get

            {

                return this._createdByUser;

            }

            set

            {

                if (this.createdByUser != value)

                {

                    this.createdByUser = (global::Microsoft.Graph.user)value;

                }

            }

        }

        global::Microsoft.Graph.Iuser global::Microsoft.Graph.IdriveItem.lastModifiedByUser

        {

            get

            {

                return this._lastModifiedByUser;

            }

            set

            {

                if (this.lastModifiedByUser != value)

                {

                    this.lastModifiedByUser = (global::Microsoft.Graph.user)value;

                }

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.Ipermission> global::Microsoft.Graph.IdriveItem.permissions

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.Ipermission, global::Microsoft.Graph.permission>(Context, (DataServiceCollection<global::Microsoft.Graph.permission>) permissions);

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.IdriveItem> global::Microsoft.Graph.IdriveItem.versions

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.IdriveItem, global::Microsoft.Graph.driveItem>(Context, (DataServiceCollection<global::Microsoft.Graph.driveItem>) versions);

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.IdriveItem> global::Microsoft.Graph.IdriveItem.children

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.IdriveItem, global::Microsoft.Graph.driveItem>(Context, (DataServiceCollection<global::Microsoft.Graph.driveItem>) children);

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.IthumbnailSet> global::Microsoft.Graph.IdriveItem.thumbnails

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.IthumbnailSet, global::Microsoft.Graph.thumbnailSet>(Context, (DataServiceCollection<global::Microsoft.Graph.thumbnailSet>) thumbnails);

            }

        }

        public global::Microsoft.Graph.user createdByUser

        {

            get

            {

                return this._createdByUser;

            }

            set

            {

                if (this._createdByUser != value)

                {

                    this._createdByUser = value;

                    if (Context != null && Context.GetEntityDescriptor(this) != null && (value == null || Context.GetEntityDescriptor(value) != null))

                    {

                        Context.SetLink(this, "createdByUser", value);

                    }

                }

            }

        }

        public global::Microsoft.Graph.user lastModifiedByUser

        {

            get

            {

                return this._lastModifiedByUser;

            }

            set

            {

                if (this._lastModifiedByUser != value)

                {

                    this._lastModifiedByUser = value;

                    if (Context != null && Context.GetEntityDescriptor(this) != null && (value == null || Context.GetEntityDescriptor(value) != null))

                    {

                        Context.SetLink(this, "lastModifiedByUser", value);

                    }

                }

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.permission> permissions

        {

            get

            {

                if (this._permissionsConcrete == null)

                {

                    this._permissionsConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.permission>();

                    this._permissionsConcrete.SetContainer(() => GetContainingEntity("permissions"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.permission>)this._permissionsConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                permissions.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        permissions.Add(i);

                    }

                }

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.driveItem> versions

        {

            get

            {

                if (this._versionsConcrete == null)

                {

                    this._versionsConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.driveItem>();

                    this._versionsConcrete.SetContainer(() => GetContainingEntity("versions"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.driveItem>)this._versionsConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                versions.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        versions.Add(i);

                    }

                }

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.driveItem> children

        {

            get

            {

                if (this._childrenConcrete == null)

                {

                    this._childrenConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.driveItem>();

                    this._childrenConcrete.SetContainer(() => GetContainingEntity("children"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.driveItem>)this._childrenConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                children.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        children.Add(i);

                    }

                }

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.thumbnailSet> thumbnails

        {

            get

            {

                if (this._thumbnailsConcrete == null)

                {

                    this._thumbnailsConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.thumbnailSet>();

                    this._thumbnailsConcrete.SetContainer(() => GetContainingEntity("thumbnails"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.thumbnailSet>)this._thumbnailsConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                thumbnails.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        thumbnails.Add(i);

                    }

                }

            }

        }

        global::Microsoft.Graph.IuserFetcher global::Microsoft.Graph.IdriveItemFetcher.createdByUser

        {

            get

            {

                if (this._createdByUserFetcher == null)

                {

                    this._createdByUserFetcher = new global::Microsoft.Graph.userFetcher();

                    this._createdByUserFetcher.Initialize(this.Context, GetPath("createdByUser"));

                }

                

                return this._createdByUserFetcher;

            }

        }

        global::Microsoft.Graph.IuserFetcher global::Microsoft.Graph.IdriveItemFetcher.lastModifiedByUser

        {

            get

            {

                if (this._lastModifiedByUserFetcher == null)

                {

                    this._lastModifiedByUserFetcher = new global::Microsoft.Graph.userFetcher();

                    this._lastModifiedByUserFetcher.Initialize(this.Context, GetPath("lastModifiedByUser"));

                }

                

                return this._lastModifiedByUserFetcher;

            }

        }

        global::Microsoft.Graph.IpermissionCollection global::Microsoft.Graph.IdriveItemFetcher.permissions

        {

            get

            {

                if (this._permissionsCollection == null)

                {

                    this._permissionsCollection = new global::Microsoft.Graph.permissionCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.permission>(GetPath("permissions")) : null,
                       Context,
                       this,
                       GetPath("permissions"));

                }

                

                return this._permissionsCollection;

            }

        }

        global::Microsoft.Graph.IdriveItemCollection global::Microsoft.Graph.IdriveItemFetcher.versions

        {

            get

            {

                if (this._versionsCollection == null)

                {

                    this._versionsCollection = new global::Microsoft.Graph.driveItemCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.driveItem>(GetPath("versions")) : null,
                       Context,
                       this,
                       GetPath("versions"));

                }

                

                return this._versionsCollection;

            }

        }

        global::Microsoft.Graph.IdriveItemCollection global::Microsoft.Graph.IdriveItemFetcher.children

        {

            get

            {

                if (this._childrenCollection == null)

                {

                    this._childrenCollection = new global::Microsoft.Graph.driveItemCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.driveItem>(GetPath("children")) : null,
                       Context,
                       this,
                       GetPath("children"));

                }

                

                return this._childrenCollection;

            }

        }

        global::Microsoft.Graph.IthumbnailSetCollection global::Microsoft.Graph.IdriveItemFetcher.thumbnails

        {

            get

            {

                if (this._thumbnailsCollection == null)

                {

                    this._thumbnailsCollection = new global::Microsoft.Graph.thumbnailSetCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.thumbnailSet>(GetPath("thumbnails")) : null,
                       Context,
                       this,
                       GetPath("thumbnails"));

                }

                

                return this._thumbnailsCollection;

            }

        }

        public driveItem(): base()

        {

        }

        public async System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<global::Microsoft.Graph.Ipermission>> inviteAsync(System.Collections.Generic.ICollection<global::Microsoft.Graph.recipients> recipients, System.String message, System.Nullable<System.Boolean> requireSignIn, System.Nullable<System.Boolean> sendInvitation, System.Collections.Generic.ICollection<System.String> roles)

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.invite");

            return (await this.Context.ExecuteAsync<global::Microsoft.Graph.permission>(requestUri, "POST", false, new OperationParameter[]

            {

                new BodyOperationParameter("recipients", (object) recipients),

                new BodyOperationParameter("message", (object) message),

                new BodyOperationParameter("requireSignIn", (object) requireSignIn),

                new BodyOperationParameter("sendInvitation", (object) sendInvitation),

                new BodyOperationParameter("roles", (object) roles),

            }

            ));

        }

        public async System.Threading.Tasks.Task<global::Microsoft.Graph.IdriveItem> copyAsync(global::Microsoft.Graph.itemReference parentReference, System.String name)

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.copy");

            return (global::Microsoft.Graph.IdriveItem) Enumerable.Single<global::Microsoft.Graph.driveItem>(await this.Context.ExecuteAsync<global::Microsoft.Graph.driveItem>(requestUri, "POST", true, new OperationParameter[]

            {

                new BodyOperationParameter("parentReference", (object) parentReference),

                new BodyOperationParameter("name", (object) name),

            }

            ));

        }

        public async System.Threading.Tasks.Task<global::Microsoft.Graph.Ipermission> createLinkAsync(System.String type)

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.createLink");

            return (global::Microsoft.Graph.Ipermission) Enumerable.Single<global::Microsoft.Graph.permission>(await this.Context.ExecuteAsync<global::Microsoft.Graph.permission>(requestUri, "POST", true, new OperationParameter[]

            {

                new BodyOperationParameter("type", (object) type),

            }

            ));

        }

        public async System.Threading.Tasks.Task<global::Microsoft.Graph.uploadSession> createSessionAsync(global::Microsoft.Graph.chunkedUploadSessionDescriptor item)

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.createSession");

            return (global::Microsoft.Graph.uploadSession) Enumerable.Single<global::Microsoft.Graph.uploadSession>(await this.Context.ExecuteAsync<global::Microsoft.Graph.uploadSession>(requestUri, "POST", true, new OperationParameter[]

            {

                new BodyOperationParameter("item", (object) item),

            }

            ));

        }

        public async System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<global::Microsoft.Graph.IdriveItem>> allPhotosAsync()

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.allPhotos");

            return (await this.Context.ExecuteAsync<global::Microsoft.Graph.driveItem>(requestUri, "GET", false, new OperationParameter[]

            {

            }

            ));

        }

        public async System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<global::Microsoft.Graph.IdriveItem>> searchAsync(System.String q)

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.search");

            return (await this.Context.ExecuteAsync<global::Microsoft.Graph.driveItem>(requestUri, "GET", false, new OperationParameter[]

            {

                new UriOperationParameter("q", (object) q),

            }

            ));

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IdriveItem> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.driveItem, global::Microsoft.Graph.IdriveItem>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IdriveItem> _query;

        global::System.Threading.Tasks.Task<global::Microsoft.Graph.IdriveItem> global::Microsoft.Graph.IdriveItemFetcher.ExecuteAsync()

        {

            var tsc = new global::System.Threading.Tasks.TaskCompletionSource<global::Microsoft.Graph.IdriveItem>();

            tsc.SetResult(this);

            return tsc.Task;

        }

        global::Microsoft.Graph.IdriveItemFetcher global::Microsoft.Graph.IdriveItemFetcher.Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.IdriveItem, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IdriveItemFetcher) this;

        }

    }

    internal partial class driveItemFetcher:Microsoft.OData.ProxyExtensions.RestShallowObjectFetcher, global::Microsoft.Graph.IdriveItemFetcher

    {

        private global::Microsoft.Graph.userFetcher _createdByUserFetcher;

        private global::Microsoft.Graph.userFetcher _lastModifiedByUserFetcher;

        private global::Microsoft.Graph.permissionCollection _permissionsCollection;

        private global::Microsoft.Graph.driveItemCollection _versionsCollection;

        private global::Microsoft.Graph.driveItemCollection _childrenCollection;

        private global::Microsoft.Graph.thumbnailSetCollection _thumbnailsCollection;

        public global::Microsoft.Graph.IuserFetcher createdByUser

        {

            get

            {

                if (this._createdByUserFetcher == null)

                {

                    this._createdByUserFetcher = new global::Microsoft.Graph.userFetcher();

                    this._createdByUserFetcher.Initialize(this.Context, GetPath("createdByUser"));

                }

                

                return this._createdByUserFetcher;

            }

        }

        public global::Microsoft.Graph.IuserFetcher lastModifiedByUser

        {

            get

            {

                if (this._lastModifiedByUserFetcher == null)

                {

                    this._lastModifiedByUserFetcher = new global::Microsoft.Graph.userFetcher();

                    this._lastModifiedByUserFetcher.Initialize(this.Context, GetPath("lastModifiedByUser"));

                }

                

                return this._lastModifiedByUserFetcher;

            }

        }

        public global::Microsoft.Graph.IpermissionCollection permissions

        {

            get

            {

                if (this._permissionsCollection == null)

                {

                    this._permissionsCollection = new global::Microsoft.Graph.permissionCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.permission>(GetPath("permissions")) : null,
                       Context,
                       this,
                       GetPath("permissions"));

                }

                

                return this._permissionsCollection;

            }

        }

        public global::Microsoft.Graph.IdriveItemCollection versions

        {

            get

            {

                if (this._versionsCollection == null)

                {

                    this._versionsCollection = new global::Microsoft.Graph.driveItemCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.driveItem>(GetPath("versions")) : null,
                       Context,
                       this,
                       GetPath("versions"));

                }

                

                return this._versionsCollection;

            }

        }

        public global::Microsoft.Graph.IdriveItemCollection children

        {

            get

            {

                if (this._childrenCollection == null)

                {

                    this._childrenCollection = new global::Microsoft.Graph.driveItemCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.driveItem>(GetPath("children")) : null,
                       Context,
                       this,
                       GetPath("children"));

                }

                

                return this._childrenCollection;

            }

        }

        public global::Microsoft.Graph.IthumbnailSetCollection thumbnails

        {

            get

            {

                if (this._thumbnailsCollection == null)

                {

                    this._thumbnailsCollection = new global::Microsoft.Graph.thumbnailSetCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.thumbnailSet>(GetPath("thumbnails")) : null,
                       Context,
                       this,
                       GetPath("thumbnails"));

                }

                

                return this._thumbnailsCollection;

            }

        }

        public driveItemFetcher(): base()

        {

        }

        public async System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<global::Microsoft.Graph.Ipermission>> inviteAsync(System.Collections.Generic.ICollection<global::Microsoft.Graph.recipients> recipients, System.String message, System.Nullable<System.Boolean> requireSignIn, System.Nullable<System.Boolean> sendInvitation, System.Collections.Generic.ICollection<System.String> roles)

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.invite");

            return (await this.Context.ExecuteAsync<global::Microsoft.Graph.permission>(requestUri, "POST", false, new OperationParameter[]

            {

                new BodyOperationParameter("recipients", (object) recipients),

                new BodyOperationParameter("message", (object) message),

                new BodyOperationParameter("requireSignIn", (object) requireSignIn),

                new BodyOperationParameter("sendInvitation", (object) sendInvitation),

                new BodyOperationParameter("roles", (object) roles),

            }

            ));

        }

        public async System.Threading.Tasks.Task<global::Microsoft.Graph.IdriveItem> copyAsync(global::Microsoft.Graph.itemReference parentReference, System.String name)

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.copy");

            return (global::Microsoft.Graph.IdriveItem) Enumerable.Single<global::Microsoft.Graph.driveItem>(await this.Context.ExecuteAsync<global::Microsoft.Graph.driveItem>(requestUri, "POST", true, new OperationParameter[]

            {

                new BodyOperationParameter("parentReference", (object) parentReference),

                new BodyOperationParameter("name", (object) name),

            }

            ));

        }

        public async System.Threading.Tasks.Task<global::Microsoft.Graph.Ipermission> createLinkAsync(System.String type)

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.createLink");

            return (global::Microsoft.Graph.Ipermission) Enumerable.Single<global::Microsoft.Graph.permission>(await this.Context.ExecuteAsync<global::Microsoft.Graph.permission>(requestUri, "POST", true, new OperationParameter[]

            {

                new BodyOperationParameter("type", (object) type),

            }

            ));

        }

        public async System.Threading.Tasks.Task<global::Microsoft.Graph.uploadSession> createSessionAsync(global::Microsoft.Graph.chunkedUploadSessionDescriptor item)

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.createSession");

            return (global::Microsoft.Graph.uploadSession) Enumerable.Single<global::Microsoft.Graph.uploadSession>(await this.Context.ExecuteAsync<global::Microsoft.Graph.uploadSession>(requestUri, "POST", true, new OperationParameter[]

            {

                new BodyOperationParameter("item", (object) item),

            }

            ));

        }

        public async System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<global::Microsoft.Graph.IdriveItem>> allPhotosAsync()

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.allPhotos");

            return (await this.Context.ExecuteAsync<global::Microsoft.Graph.driveItem>(requestUri, "GET", false, new OperationParameter[]

            {

            }

            ));

        }

        public async System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<global::Microsoft.Graph.IdriveItem>> searchAsync(System.String q)

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.search");

            return (await this.Context.ExecuteAsync<global::Microsoft.Graph.driveItem>(requestUri, "GET", false, new OperationParameter[]

            {

                new UriOperationParameter("q", (object) q),

            }

            ));

        }

        public async global::System.Threading.Tasks.Task<global::Microsoft.Graph.IdriveItem> ExecuteAsync()

        {

            return await EnsureQuery().ExecuteSingleAsync();

        }

        public global::Microsoft.Graph.IdriveItemFetcher Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.IdriveItem, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IdriveItemFetcher) new global::Microsoft.Graph.driveItemFetcher()

            {

                _query = this.EnsureQuery().Expand<TTarget>(navigationPropertyAccessor)

            }

            ;

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IdriveItem> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.driveItem, global::Microsoft.Graph.IdriveItem>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IdriveItem> _query;

    }

    internal partial class driveItemCollection:Microsoft.OData.ProxyExtensions.QueryableSet<global::Microsoft.Graph.IdriveItem>, global::Microsoft.Graph.IdriveItemCollection

    {

        internal driveItemCollection(global::Microsoft.OData.Client.DataServiceQuery inner,Microsoft.OData.ProxyExtensions.DataServiceContextWrapper context,object entity,string path): base(inner, context, entity as Microsoft.OData.ProxyExtensions.EntityBase, path)

        {

        }

        public global::Microsoft.Graph.IdriveItemFetcher GetById(System.String id)

        {

            return this[id];

        }

        public global::System.Threading.Tasks.Task<Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.IdriveItem>> ExecuteAsync()

        {

            return ExecuteAsyncInternal();

        }

        public global::System.Threading.Tasks.Task AdddriveItemAsync(global::Microsoft.Graph.IdriveItem item, System.Boolean deferSaveChanges = false)

        {

            if (Entity == null)

            {

                Context.AddObject(Path, item);

            }

            else

            {

                var lastSlash = Path.LastIndexOf('/');

                var shortPath = (lastSlash >= 0 && lastSlash < Path.Length - 1) ? Path.Substring(lastSlash + 1) : Path;

                Context.AddRelatedObject(Entity, shortPath, item);

            }

            if (!deferSaveChanges)

            {

                return Context.SaveChangesAsync();

            }

            else

            {

                var retVal = new global::System.Threading.Tasks.TaskCompletionSource<object>();

                retVal.SetResult(null);

                return retVal.Task;

            }

        }

        public global::Microsoft.Graph.IdriveItemFetcher this[System.String id]

        {

            get

            {

                var path = GetPath<global::Microsoft.Graph.driveItem>((i) => i.id == id);

                var fetcher = new global::Microsoft.Graph.driveItemFetcher();

                fetcher.Initialize(Context, path);

                

                return fetcher;

            }

        }

    }

    internal partial class driveItemCollection

    {

        public global::System.Threading.Tasks.Task<System.Int64> CountAsync()

        {

            return new DataServiceQuerySingle<long>(Context, Path + "/$count").GetValueAsync();

        }

    }

    internal partial class driveItemFetcher

    {

    }

    public partial class driveItem

    {

    }

    [global::Microsoft.OData.Client.Key("id")]

    public partial class task:Microsoft.OData.ProxyExtensions.EntityBase, global::Microsoft.Graph.Itask, global::Microsoft.Graph.ItaskFetcher

    {

        private global::Microsoft.Graph.taskDetails _details;

        private global::Microsoft.Graph.taskBoardTaskFormat _assignedToTaskBoardFormat;

        private global::Microsoft.Graph.taskBoardTaskFormat _progressTaskBoardFormat;

        private global::Microsoft.Graph.taskBoardTaskFormat _bucketTaskBoardFormat;

        private global::Microsoft.Graph.taskDetailsFetcher _detailsFetcher;

        private global::Microsoft.Graph.taskBoardTaskFormatFetcher _assignedToTaskBoardFormatFetcher;

        private global::Microsoft.Graph.taskBoardTaskFormatFetcher _progressTaskBoardFormatFetcher;

        private global::Microsoft.Graph.taskBoardTaskFormatFetcher _bucketTaskBoardFormatFetcher;

        private System.String _createdBy;

        private System.String _assignedTo;

        private System.String _planId;

        private System.String _bucketId;

        private System.String _title;

        private System.String _orderHint;

        private System.String _assigneePriority;

        private System.Nullable<System.Int32> _percentComplete;

        private System.Nullable<System.DateTimeOffset> _startDateTime;

        private System.Nullable<System.DateTimeOffset> _assignedDateTime;

        private System.Nullable<System.DateTimeOffset> _createdDateTime;

        private System.String _assignedBy;

        private System.Nullable<System.DateTimeOffset> _dueDateTime;

        private System.Nullable<System.Boolean> _hasDescription;

        private global::Microsoft.Graph.previewType _previewType;

        private System.Nullable<System.DateTimeOffset> _completedDateTime;

        private global::Microsoft.Graph.appliedCategoriesCollection _appliedCategories;

        private System.String _conversationThreadId;

        private System.String _id;

        public System.String createdBy

        {

            get

            {

                return _createdBy;

            }

            set

            {

                if (value != _createdBy)

                {

                    _createdBy = value;

                    OnPropertyChanged("createdBy");

                }

            }

        }

        public System.String assignedTo

        {

            get

            {

                return _assignedTo;

            }

            set

            {

                if (value != _assignedTo)

                {

                    _assignedTo = value;

                    OnPropertyChanged("assignedTo");

                }

            }

        }

        public System.String planId

        {

            get

            {

                return _planId;

            }

            set

            {

                if (value != _planId)

                {

                    _planId = value;

                    OnPropertyChanged("planId");

                }

            }

        }

        public System.String bucketId

        {

            get

            {

                return _bucketId;

            }

            set

            {

                if (value != _bucketId)

                {

                    _bucketId = value;

                    OnPropertyChanged("bucketId");

                }

            }

        }

        public System.String title

        {

            get

            {

                return _title;

            }

            set

            {

                if (value != _title)

                {

                    _title = value;

                    OnPropertyChanged("title");

                }

            }

        }

        public System.String orderHint

        {

            get

            {

                return _orderHint;

            }

            set

            {

                if (value != _orderHint)

                {

                    _orderHint = value;

                    OnPropertyChanged("orderHint");

                }

            }

        }

        public System.String assigneePriority

        {

            get

            {

                return _assigneePriority;

            }

            set

            {

                if (value != _assigneePriority)

                {

                    _assigneePriority = value;

                    OnPropertyChanged("assigneePriority");

                }

            }

        }

        public System.Nullable<System.Int32> percentComplete

        {

            get

            {

                return _percentComplete;

            }

            set

            {

                if (value != _percentComplete)

                {

                    _percentComplete = value;

                    OnPropertyChanged("percentComplete");

                }

            }

        }

        public System.Nullable<System.DateTimeOffset> startDateTime

        {

            get

            {

                return _startDateTime;

            }

            set

            {

                if (value != _startDateTime)

                {

                    _startDateTime = value;

                    OnPropertyChanged("startDateTime");

                }

            }

        }

        public System.Nullable<System.DateTimeOffset> assignedDateTime

        {

            get

            {

                return _assignedDateTime;

            }

            set

            {

                if (value != _assignedDateTime)

                {

                    _assignedDateTime = value;

                    OnPropertyChanged("assignedDateTime");

                }

            }

        }

        public System.Nullable<System.DateTimeOffset> createdDateTime

        {

            get

            {

                return _createdDateTime;

            }

            set

            {

                if (value != _createdDateTime)

                {

                    _createdDateTime = value;

                    OnPropertyChanged("createdDateTime");

                }

            }

        }

        public System.String assignedBy

        {

            get

            {

                return _assignedBy;

            }

            set

            {

                if (value != _assignedBy)

                {

                    _assignedBy = value;

                    OnPropertyChanged("assignedBy");

                }

            }

        }

        public System.Nullable<System.DateTimeOffset> dueDateTime

        {

            get

            {

                return _dueDateTime;

            }

            set

            {

                if (value != _dueDateTime)

                {

                    _dueDateTime = value;

                    OnPropertyChanged("dueDateTime");

                }

            }

        }

        public System.Nullable<System.Boolean> hasDescription

        {

            get

            {

                return _hasDescription;

            }

            set

            {

                if (value != _hasDescription)

                {

                    _hasDescription = value;

                    OnPropertyChanged("hasDescription");

                }

            }

        }

        public global::Microsoft.Graph.previewType previewType

        {

            get

            {

                return _previewType;

            }

            set

            {

                if (value != _previewType)

                {

                    _previewType = value;

                    OnPropertyChanged("previewType");

                }

            }

        }

        public System.Nullable<System.DateTimeOffset> completedDateTime

        {

            get

            {

                return _completedDateTime;

            }

            set

            {

                if (value != _completedDateTime)

                {

                    _completedDateTime = value;

                    OnPropertyChanged("completedDateTime");

                }

            }

        }

        public global::Microsoft.Graph.appliedCategoriesCollection appliedCategories

        {

            get

            {

                return _appliedCategories;

            }

            set

            {

                if (value != _appliedCategories)

                {

                    _appliedCategories = value;

                    OnPropertyChanged("appliedCategories");

                }

            }

        }

        public System.String conversationThreadId

        {

            get

            {

                return _conversationThreadId;

            }

            set

            {

                if (value != _conversationThreadId)

                {

                    _conversationThreadId = value;

                    OnPropertyChanged("conversationThreadId");

                }

            }

        }

        public System.String id

        {

            get

            {

                return _id;

            }

            set

            {

                if (value != _id)

                {

                    _id = value;

                    OnPropertyChanged("id");

                }

            }

        }

        global::Microsoft.Graph.ItaskDetails global::Microsoft.Graph.Itask.details

        {

            get

            {

                return this._details;

            }

            set

            {

                if (this.details != value)

                {

                    this.details = (global::Microsoft.Graph.taskDetails)value;

                }

            }

        }

        global::Microsoft.Graph.ItaskBoardTaskFormat global::Microsoft.Graph.Itask.assignedToTaskBoardFormat

        {

            get

            {

                return this._assignedToTaskBoardFormat;

            }

            set

            {

                if (this.assignedToTaskBoardFormat != value)

                {

                    this.assignedToTaskBoardFormat = (global::Microsoft.Graph.taskBoardTaskFormat)value;

                }

            }

        }

        global::Microsoft.Graph.ItaskBoardTaskFormat global::Microsoft.Graph.Itask.progressTaskBoardFormat

        {

            get

            {

                return this._progressTaskBoardFormat;

            }

            set

            {

                if (this.progressTaskBoardFormat != value)

                {

                    this.progressTaskBoardFormat = (global::Microsoft.Graph.taskBoardTaskFormat)value;

                }

            }

        }

        global::Microsoft.Graph.ItaskBoardTaskFormat global::Microsoft.Graph.Itask.bucketTaskBoardFormat

        {

            get

            {

                return this._bucketTaskBoardFormat;

            }

            set

            {

                if (this.bucketTaskBoardFormat != value)

                {

                    this.bucketTaskBoardFormat = (global::Microsoft.Graph.taskBoardTaskFormat)value;

                }

            }

        }

        public global::Microsoft.Graph.taskDetails details

        {

            get

            {

                return this._details;

            }

            set

            {

                if (this._details != value)

                {

                    this._details = value;

                    if (Context != null && Context.GetEntityDescriptor(this) != null && (value == null || Context.GetEntityDescriptor(value) != null))

                    {

                        Context.SetLink(this, "details", value);

                    }

                }

            }

        }

        public global::Microsoft.Graph.taskBoardTaskFormat assignedToTaskBoardFormat

        {

            get

            {

                return this._assignedToTaskBoardFormat;

            }

            set

            {

                if (this._assignedToTaskBoardFormat != value)

                {

                    this._assignedToTaskBoardFormat = value;

                    if (Context != null && Context.GetEntityDescriptor(this) != null && (value == null || Context.GetEntityDescriptor(value) != null))

                    {

                        Context.SetLink(this, "assignedToTaskBoardFormat", value);

                    }

                }

            }

        }

        public global::Microsoft.Graph.taskBoardTaskFormat progressTaskBoardFormat

        {

            get

            {

                return this._progressTaskBoardFormat;

            }

            set

            {

                if (this._progressTaskBoardFormat != value)

                {

                    this._progressTaskBoardFormat = value;

                    if (Context != null && Context.GetEntityDescriptor(this) != null && (value == null || Context.GetEntityDescriptor(value) != null))

                    {

                        Context.SetLink(this, "progressTaskBoardFormat", value);

                    }

                }

            }

        }

        public global::Microsoft.Graph.taskBoardTaskFormat bucketTaskBoardFormat

        {

            get

            {

                return this._bucketTaskBoardFormat;

            }

            set

            {

                if (this._bucketTaskBoardFormat != value)

                {

                    this._bucketTaskBoardFormat = value;

                    if (Context != null && Context.GetEntityDescriptor(this) != null && (value == null || Context.GetEntityDescriptor(value) != null))

                    {

                        Context.SetLink(this, "bucketTaskBoardFormat", value);

                    }

                }

            }

        }

        global::Microsoft.Graph.ItaskDetailsFetcher global::Microsoft.Graph.ItaskFetcher.details

        {

            get

            {

                if (this._detailsFetcher == null)

                {

                    this._detailsFetcher = new global::Microsoft.Graph.taskDetailsFetcher();

                    this._detailsFetcher.Initialize(this.Context, GetPath("details"));

                }

                

                return this._detailsFetcher;

            }

        }

        global::Microsoft.Graph.ItaskBoardTaskFormatFetcher global::Microsoft.Graph.ItaskFetcher.assignedToTaskBoardFormat

        {

            get

            {

                if (this._assignedToTaskBoardFormatFetcher == null)

                {

                    this._assignedToTaskBoardFormatFetcher = new global::Microsoft.Graph.taskBoardTaskFormatFetcher();

                    this._assignedToTaskBoardFormatFetcher.Initialize(this.Context, GetPath("assignedToTaskBoardFormat"));

                }

                

                return this._assignedToTaskBoardFormatFetcher;

            }

        }

        global::Microsoft.Graph.ItaskBoardTaskFormatFetcher global::Microsoft.Graph.ItaskFetcher.progressTaskBoardFormat

        {

            get

            {

                if (this._progressTaskBoardFormatFetcher == null)

                {

                    this._progressTaskBoardFormatFetcher = new global::Microsoft.Graph.taskBoardTaskFormatFetcher();

                    this._progressTaskBoardFormatFetcher.Initialize(this.Context, GetPath("progressTaskBoardFormat"));

                }

                

                return this._progressTaskBoardFormatFetcher;

            }

        }

        global::Microsoft.Graph.ItaskBoardTaskFormatFetcher global::Microsoft.Graph.ItaskFetcher.bucketTaskBoardFormat

        {

            get

            {

                if (this._bucketTaskBoardFormatFetcher == null)

                {

                    this._bucketTaskBoardFormatFetcher = new global::Microsoft.Graph.taskBoardTaskFormatFetcher();

                    this._bucketTaskBoardFormatFetcher.Initialize(this.Context, GetPath("bucketTaskBoardFormat"));

                }

                

                return this._bucketTaskBoardFormatFetcher;

            }

        }

        public task(): base()

        {

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Itask> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.task, global::Microsoft.Graph.Itask>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Itask> _query;

        global::System.Threading.Tasks.Task<global::Microsoft.Graph.Itask> global::Microsoft.Graph.ItaskFetcher.ExecuteAsync()

        {

            var tsc = new global::System.Threading.Tasks.TaskCompletionSource<global::Microsoft.Graph.Itask>();

            tsc.SetResult(this);

            return tsc.Task;

        }

        global::Microsoft.Graph.ItaskFetcher global::Microsoft.Graph.ItaskFetcher.Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.Itask, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.ItaskFetcher) this;

        }

    }

    internal partial class taskFetcher:Microsoft.OData.ProxyExtensions.RestShallowObjectFetcher, global::Microsoft.Graph.ItaskFetcher

    {

        private global::Microsoft.Graph.taskDetailsFetcher _detailsFetcher;

        private global::Microsoft.Graph.taskBoardTaskFormatFetcher _assignedToTaskBoardFormatFetcher;

        private global::Microsoft.Graph.taskBoardTaskFormatFetcher _progressTaskBoardFormatFetcher;

        private global::Microsoft.Graph.taskBoardTaskFormatFetcher _bucketTaskBoardFormatFetcher;

        public global::Microsoft.Graph.ItaskDetailsFetcher details

        {

            get

            {

                if (this._detailsFetcher == null)

                {

                    this._detailsFetcher = new global::Microsoft.Graph.taskDetailsFetcher();

                    this._detailsFetcher.Initialize(this.Context, GetPath("details"));

                }

                

                return this._detailsFetcher;

            }

        }

        public global::Microsoft.Graph.ItaskBoardTaskFormatFetcher assignedToTaskBoardFormat

        {

            get

            {

                if (this._assignedToTaskBoardFormatFetcher == null)

                {

                    this._assignedToTaskBoardFormatFetcher = new global::Microsoft.Graph.taskBoardTaskFormatFetcher();

                    this._assignedToTaskBoardFormatFetcher.Initialize(this.Context, GetPath("assignedToTaskBoardFormat"));

                }

                

                return this._assignedToTaskBoardFormatFetcher;

            }

        }

        public global::Microsoft.Graph.ItaskBoardTaskFormatFetcher progressTaskBoardFormat

        {

            get

            {

                if (this._progressTaskBoardFormatFetcher == null)

                {

                    this._progressTaskBoardFormatFetcher = new global::Microsoft.Graph.taskBoardTaskFormatFetcher();

                    this._progressTaskBoardFormatFetcher.Initialize(this.Context, GetPath("progressTaskBoardFormat"));

                }

                

                return this._progressTaskBoardFormatFetcher;

            }

        }

        public global::Microsoft.Graph.ItaskBoardTaskFormatFetcher bucketTaskBoardFormat

        {

            get

            {

                if (this._bucketTaskBoardFormatFetcher == null)

                {

                    this._bucketTaskBoardFormatFetcher = new global::Microsoft.Graph.taskBoardTaskFormatFetcher();

                    this._bucketTaskBoardFormatFetcher.Initialize(this.Context, GetPath("bucketTaskBoardFormat"));

                }

                

                return this._bucketTaskBoardFormatFetcher;

            }

        }

        public taskFetcher(): base()

        {

        }

        public async global::System.Threading.Tasks.Task<global::Microsoft.Graph.Itask> ExecuteAsync()

        {

            return await EnsureQuery().ExecuteSingleAsync();

        }

        public global::Microsoft.Graph.ItaskFetcher Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.Itask, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.ItaskFetcher) new global::Microsoft.Graph.taskFetcher()

            {

                _query = this.EnsureQuery().Expand<TTarget>(navigationPropertyAccessor)

            }

            ;

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Itask> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.task, global::Microsoft.Graph.Itask>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Itask> _query;

    }

    internal partial class taskCollection:Microsoft.OData.ProxyExtensions.QueryableSet<global::Microsoft.Graph.Itask>, global::Microsoft.Graph.ItaskCollection

    {

        internal taskCollection(global::Microsoft.OData.Client.DataServiceQuery inner,Microsoft.OData.ProxyExtensions.DataServiceContextWrapper context,object entity,string path): base(inner, context, entity as Microsoft.OData.ProxyExtensions.EntityBase, path)

        {

        }

        public global::Microsoft.Graph.ItaskFetcher GetById(System.String id)

        {

            return this[id];

        }

        public global::System.Threading.Tasks.Task<Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.Itask>> ExecuteAsync()

        {

            return ExecuteAsyncInternal();

        }

        public global::System.Threading.Tasks.Task AddtaskAsync(global::Microsoft.Graph.Itask item, System.Boolean deferSaveChanges = false)

        {

            if (Entity == null)

            {

                Context.AddObject(Path, item);

            }

            else

            {

                var lastSlash = Path.LastIndexOf('/');

                var shortPath = (lastSlash >= 0 && lastSlash < Path.Length - 1) ? Path.Substring(lastSlash + 1) : Path;

                Context.AddRelatedObject(Entity, shortPath, item);

            }

            if (!deferSaveChanges)

            {

                return Context.SaveChangesAsync();

            }

            else

            {

                var retVal = new global::System.Threading.Tasks.TaskCompletionSource<object>();

                retVal.SetResult(null);

                return retVal.Task;

            }

        }

        public global::Microsoft.Graph.ItaskFetcher this[System.String id]

        {

            get

            {

                var path = GetPath<global::Microsoft.Graph.task>((i) => i.id == id);

                var fetcher = new global::Microsoft.Graph.taskFetcher();

                fetcher.Initialize(Context, path);

                

                return fetcher;

            }

        }

    }

    internal partial class taskCollection

    {

        public global::System.Threading.Tasks.Task<System.Int64> CountAsync()

        {

            return new DataServiceQuerySingle<long>(Context, Path + "/$count").GetValueAsync();

        }

    }

    internal partial class taskFetcher

    {

    }

    public partial class task

    {

    }

    [global::Microsoft.OData.Client.Key("id")]

    public abstract partial class attachment:Microsoft.OData.ProxyExtensions.EntityBase, global::Microsoft.Graph.Iattachment, global::Microsoft.Graph.IattachmentFetcher

    {

        private System.Nullable<System.DateTimeOffset> _lastModifiedDateTime;

        private System.String _name;

        private System.String _contentType;

        private System.Int32 _size;

        private System.Boolean _isInline;

        private System.String _id;

        public System.Nullable<System.DateTimeOffset> lastModifiedDateTime

        {

            get

            {

                return _lastModifiedDateTime;

            }

            set

            {

                if (value != _lastModifiedDateTime)

                {

                    _lastModifiedDateTime = value;

                    OnPropertyChanged("lastModifiedDateTime");

                }

            }

        }

        public System.String name

        {

            get

            {

                return _name;

            }

            set

            {

                if (value != _name)

                {

                    _name = value;

                    OnPropertyChanged("name");

                }

            }

        }

        public System.String contentType

        {

            get

            {

                return _contentType;

            }

            set

            {

                if (value != _contentType)

                {

                    _contentType = value;

                    OnPropertyChanged("contentType");

                }

            }

        }

        public System.Int32 size

        {

            get

            {

                return _size;

            }

            set

            {

                if (value != _size)

                {

                    _size = value;

                    OnPropertyChanged("size");

                }

            }

        }

        public System.Boolean isInline

        {

            get

            {

                return _isInline;

            }

            set

            {

                if (value != _isInline)

                {

                    _isInline = value;

                    OnPropertyChanged("isInline");

                }

            }

        }

        public System.String id

        {

            get

            {

                return _id;

            }

            set

            {

                if (value != _id)

                {

                    _id = value;

                    OnPropertyChanged("id");

                }

            }

        }

        public attachment(): base()

        {

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Iattachment> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.attachment, global::Microsoft.Graph.Iattachment>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Iattachment> _query;

    }

    internal partial class attachmentFetcher:Microsoft.OData.ProxyExtensions.RestShallowObjectFetcher, global::Microsoft.Graph.IattachmentFetcher

    {

        public attachmentFetcher(): base()

        {

        }

    }

    internal partial class attachmentCollection:Microsoft.OData.ProxyExtensions.QueryableSet<global::Microsoft.Graph.Iattachment>, global::Microsoft.Graph.IattachmentCollection

    {

        internal attachmentCollection(global::Microsoft.OData.Client.DataServiceQuery inner,Microsoft.OData.ProxyExtensions.DataServiceContextWrapper context,object entity,string path): base(inner, context, entity as Microsoft.OData.ProxyExtensions.EntityBase, path)

        {

        }

        public global::Microsoft.Graph.IattachmentFetcher GetById(System.String id)

        {

            return this[id];

        }

        public global::System.Threading.Tasks.Task<Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.Iattachment>> ExecuteAsync()

        {

            return ExecuteAsyncInternal();

        }

        public global::System.Threading.Tasks.Task AddattachmentAsync(global::Microsoft.Graph.Iattachment item, System.Boolean deferSaveChanges = false)

        {

            if (Entity == null)

            {

                Context.AddObject(Path, item);

            }

            else

            {

                var lastSlash = Path.LastIndexOf('/');

                var shortPath = (lastSlash >= 0 && lastSlash < Path.Length - 1) ? Path.Substring(lastSlash + 1) : Path;

                Context.AddRelatedObject(Entity, shortPath, item);

            }

            if (!deferSaveChanges)

            {

                return Context.SaveChangesAsync();

            }

            else

            {

                var retVal = new global::System.Threading.Tasks.TaskCompletionSource<object>();

                retVal.SetResult(null);

                return retVal.Task;

            }

        }

        public global::Microsoft.Graph.IattachmentFetcher this[System.String id]

        {

            get

            {

                var path = GetPath<global::Microsoft.Graph.attachment>((i) => i.id == id);

                var fetcher = new global::Microsoft.Graph.attachmentFetcher();

                fetcher.Initialize(Context, path);

                

                return fetcher;

            }

        }

    }

    internal partial class attachmentCollection

    {

        public global::System.Threading.Tasks.Task<System.Int64> CountAsync()

        {

            return new DataServiceQuerySingle<long>(Context, Path + "/$count").GetValueAsync();

        }

    }

    internal partial class attachmentFetcher

    {

        public global::Microsoft.Graph.IfileAttachmentFetcher TofileAttachment()

        {

            var derivedFetcher = new global::Microsoft.Graph.fileAttachmentFetcher();

            derivedFetcher.Initialize(this.Context, this.GetPath((string) null));

            return (global::Microsoft.Graph.IfileAttachmentFetcher) derivedFetcher;

        }

        public global::Microsoft.Graph.IitemAttachmentFetcher ToitemAttachment()

        {

            var derivedFetcher = new global::Microsoft.Graph.itemAttachmentFetcher();

            derivedFetcher.Initialize(this.Context, this.GetPath((string) null));

            return (global::Microsoft.Graph.IitemAttachmentFetcher) derivedFetcher;

        }

        public global::Microsoft.Graph.IreferenceAttachmentFetcher ToreferenceAttachment()

        {

            var derivedFetcher = new global::Microsoft.Graph.referenceAttachmentFetcher();

            derivedFetcher.Initialize(this.Context, this.GetPath((string) null));

            return (global::Microsoft.Graph.IreferenceAttachmentFetcher) derivedFetcher;

        }

    }

    public partial class attachment

    {

        global::Microsoft.Graph.IfileAttachmentFetcher global::Microsoft.Graph.IattachmentFetcher.TofileAttachment()

        {

            return (global::Microsoft.Graph.IfileAttachmentFetcher) this;

        }

        global::Microsoft.Graph.IitemAttachmentFetcher global::Microsoft.Graph.IattachmentFetcher.ToitemAttachment()

        {

            return (global::Microsoft.Graph.IitemAttachmentFetcher) this;

        }

        global::Microsoft.Graph.IreferenceAttachmentFetcher global::Microsoft.Graph.IattachmentFetcher.ToreferenceAttachment()

        {

            return (global::Microsoft.Graph.IreferenceAttachmentFetcher) this;

        }

    }

    [global::Microsoft.OData.Client.Key("id")]

    public abstract partial class extension:Microsoft.OData.ProxyExtensions.EntityBase, global::Microsoft.Graph.Iextension, global::Microsoft.Graph.IextensionFetcher

    {

        private System.String _id;

        public System.String id

        {

            get

            {

                return _id;

            }

            set

            {

                if (value != _id)

                {

                    _id = value;

                    OnPropertyChanged("id");

                }

            }

        }

        public extension(): base()

        {

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Iextension> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.extension, global::Microsoft.Graph.Iextension>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Iextension> _query;

    }

    internal partial class extensionFetcher:Microsoft.OData.ProxyExtensions.RestShallowObjectFetcher, global::Microsoft.Graph.IextensionFetcher

    {

        public extensionFetcher(): base()

        {

        }

    }

    internal partial class extensionCollection:Microsoft.OData.ProxyExtensions.QueryableSet<global::Microsoft.Graph.Iextension>, global::Microsoft.Graph.IextensionCollection

    {

        internal extensionCollection(global::Microsoft.OData.Client.DataServiceQuery inner,Microsoft.OData.ProxyExtensions.DataServiceContextWrapper context,object entity,string path): base(inner, context, entity as Microsoft.OData.ProxyExtensions.EntityBase, path)

        {

        }

        public global::Microsoft.Graph.IextensionFetcher GetById(System.String id)

        {

            return this[id];

        }

        public global::System.Threading.Tasks.Task<Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.Iextension>> ExecuteAsync()

        {

            return ExecuteAsyncInternal();

        }

        public global::System.Threading.Tasks.Task AddextensionAsync(global::Microsoft.Graph.Iextension item, System.Boolean deferSaveChanges = false)

        {

            if (Entity == null)

            {

                Context.AddObject(Path, item);

            }

            else

            {

                var lastSlash = Path.LastIndexOf('/');

                var shortPath = (lastSlash >= 0 && lastSlash < Path.Length - 1) ? Path.Substring(lastSlash + 1) : Path;

                Context.AddRelatedObject(Entity, shortPath, item);

            }

            if (!deferSaveChanges)

            {

                return Context.SaveChangesAsync();

            }

            else

            {

                var retVal = new global::System.Threading.Tasks.TaskCompletionSource<object>();

                retVal.SetResult(null);

                return retVal.Task;

            }

        }

        public global::Microsoft.Graph.IextensionFetcher this[System.String id]

        {

            get

            {

                var path = GetPath<global::Microsoft.Graph.extension>((i) => i.id == id);

                var fetcher = new global::Microsoft.Graph.extensionFetcher();

                fetcher.Initialize(Context, path);

                

                return fetcher;

            }

        }

    }

    internal partial class extensionCollection

    {

        public global::System.Threading.Tasks.Task<System.Int64> CountAsync()

        {

            return new DataServiceQuerySingle<long>(Context, Path + "/$count").GetValueAsync();

        }

    }

    internal partial class extensionFetcher

    {

        public global::Microsoft.Graph.IopenTypeExtensionFetcher ToopenTypeExtension()

        {

            var derivedFetcher = new global::Microsoft.Graph.openTypeExtensionFetcher();

            derivedFetcher.Initialize(this.Context, this.GetPath((string) null));

            return (global::Microsoft.Graph.IopenTypeExtensionFetcher) derivedFetcher;

        }

    }

    public partial class extension

    {

        global::Microsoft.Graph.IopenTypeExtensionFetcher global::Microsoft.Graph.IextensionFetcher.ToopenTypeExtension()

        {

            return (global::Microsoft.Graph.IopenTypeExtensionFetcher) this;

        }

    }

    [global::Microsoft.OData.Client.Key("id")]

    public partial class fileAttachment:global::Microsoft.Graph.attachment, global::Microsoft.Graph.IfileAttachment, global::Microsoft.Graph.IfileAttachmentFetcher

    {

        private System.String _contentId;

        private System.String _contentLocation;

        private System.Byte[] _contentBytes;

        public System.String contentId

        {

            get

            {

                return _contentId;

            }

            set

            {

                if (value != _contentId)

                {

                    _contentId = value;

                    OnPropertyChanged("contentId");

                }

            }

        }

        public System.String contentLocation

        {

            get

            {

                return _contentLocation;

            }

            set

            {

                if (value != _contentLocation)

                {

                    _contentLocation = value;

                    OnPropertyChanged("contentLocation");

                }

            }

        }

        public System.Byte[] contentBytes

        {

            get

            {

                return _contentBytes;

            }

            set

            {

                if (value != _contentBytes)

                {

                    _contentBytes = value;

                    OnPropertyChanged("contentBytes");

                }

            }

        }

        public fileAttachment()

        {

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IfileAttachment> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.fileAttachment, global::Microsoft.Graph.IfileAttachment>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IfileAttachment> _query;

        global::System.Threading.Tasks.Task<global::Microsoft.Graph.IfileAttachment> global::Microsoft.Graph.IfileAttachmentFetcher.ExecuteAsync()

        {

            var tsc = new global::System.Threading.Tasks.TaskCompletionSource<global::Microsoft.Graph.IfileAttachment>();

            tsc.SetResult(this);

            return tsc.Task;

        }

        global::Microsoft.Graph.IfileAttachmentFetcher global::Microsoft.Graph.IfileAttachmentFetcher.Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.IfileAttachment, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IfileAttachmentFetcher) this;

        }

    }

    internal partial class fileAttachmentFetcher:global::Microsoft.Graph.attachmentFetcher, global::Microsoft.Graph.IfileAttachmentFetcher

    {

        public fileAttachmentFetcher()

        {

        }

        public async global::System.Threading.Tasks.Task<global::Microsoft.Graph.IfileAttachment> ExecuteAsync()

        {

            return await EnsureQuery().ExecuteSingleAsync();

        }

        public global::Microsoft.Graph.IfileAttachmentFetcher Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.IfileAttachment, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IfileAttachmentFetcher) new global::Microsoft.Graph.fileAttachmentFetcher()

            {

                _query = this.EnsureQuery().Expand<TTarget>(navigationPropertyAccessor)

            }

            ;

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IfileAttachment> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.fileAttachment, global::Microsoft.Graph.IfileAttachment>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IfileAttachment> _query;

    }

    internal partial class fileAttachmentCollection:Microsoft.OData.ProxyExtensions.QueryableSet<global::Microsoft.Graph.IfileAttachment>, global::Microsoft.Graph.IfileAttachmentCollection

    {

        internal fileAttachmentCollection(global::Microsoft.OData.Client.DataServiceQuery inner,Microsoft.OData.ProxyExtensions.DataServiceContextWrapper context,object entity,string path): base(inner, context, entity as Microsoft.OData.ProxyExtensions.EntityBase, path)

        {

        }

        public global::Microsoft.Graph.IfileAttachmentFetcher GetById(System.String id)

        {

            return this[id];

        }

        public global::System.Threading.Tasks.Task<Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.IfileAttachment>> ExecuteAsync()

        {

            return ExecuteAsyncInternal();

        }

        public global::System.Threading.Tasks.Task AddfileAttachmentAsync(global::Microsoft.Graph.IfileAttachment item, System.Boolean deferSaveChanges = false)

        {

            if (Entity == null)

            {

                Context.AddObject(Path, item);

            }

            else

            {

                var lastSlash = Path.LastIndexOf('/');

                var shortPath = (lastSlash >= 0 && lastSlash < Path.Length - 1) ? Path.Substring(lastSlash + 1) : Path;

                Context.AddRelatedObject(Entity, shortPath, item);

            }

            if (!deferSaveChanges)

            {

                return Context.SaveChangesAsync();

            }

            else

            {

                var retVal = new global::System.Threading.Tasks.TaskCompletionSource<object>();

                retVal.SetResult(null);

                return retVal.Task;

            }

        }

        public global::Microsoft.Graph.IfileAttachmentFetcher this[System.String id]

        {

            get

            {

                var path = GetPath<global::Microsoft.Graph.fileAttachment>((i) => i.id == id);

                var fetcher = new global::Microsoft.Graph.fileAttachmentFetcher();

                fetcher.Initialize(Context, path);

                

                return fetcher;

            }

        }

    }

    internal partial class fileAttachmentCollection

    {

        public global::System.Threading.Tasks.Task<System.Int64> CountAsync()

        {

            return new DataServiceQuerySingle<long>(Context, Path + "/$count").GetValueAsync();

        }

    }

    [global::Microsoft.OData.Client.Key("id")]

    public partial class itemAttachment:global::Microsoft.Graph.attachment, global::Microsoft.Graph.IitemAttachment, global::Microsoft.Graph.IitemAttachmentFetcher

    {

        private global::Microsoft.Graph.outlookItem _item;

        private global::Microsoft.Graph.outlookItemFetcher _itemFetcher;

        global::Microsoft.Graph.IoutlookItem global::Microsoft.Graph.IitemAttachment.item

        {

            get

            {

                return this._item;

            }

            set

            {

                if (this.item != value)

                {

                    this.item = (global::Microsoft.Graph.outlookItem)value;

                }

            }

        }

        public global::Microsoft.Graph.outlookItem item

        {

            get

            {

                return this._item;

            }

            set

            {

                if (this._item != value)

                {

                    this._item = value;

                    if (Context != null && Context.GetEntityDescriptor(this) != null && (value == null || Context.GetEntityDescriptor(value) != null))

                    {

                        Context.SetLink(this, "item", value);

                    }

                }

            }

        }

        global::Microsoft.Graph.IoutlookItemFetcher global::Microsoft.Graph.IitemAttachmentFetcher.item

        {

            get

            {

                if (this._itemFetcher == null)

                {

                    this._itemFetcher = new global::Microsoft.Graph.outlookItemFetcher();

                    this._itemFetcher.Initialize(this.Context, GetPath("item"));

                }

                

                return this._itemFetcher;

            }

        }

        public itemAttachment()

        {

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IitemAttachment> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.itemAttachment, global::Microsoft.Graph.IitemAttachment>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IitemAttachment> _query;

        global::System.Threading.Tasks.Task<global::Microsoft.Graph.IitemAttachment> global::Microsoft.Graph.IitemAttachmentFetcher.ExecuteAsync()

        {

            var tsc = new global::System.Threading.Tasks.TaskCompletionSource<global::Microsoft.Graph.IitemAttachment>();

            tsc.SetResult(this);

            return tsc.Task;

        }

        global::Microsoft.Graph.IitemAttachmentFetcher global::Microsoft.Graph.IitemAttachmentFetcher.Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.IitemAttachment, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IitemAttachmentFetcher) this;

        }

    }

    internal partial class itemAttachmentFetcher:global::Microsoft.Graph.attachmentFetcher, global::Microsoft.Graph.IitemAttachmentFetcher

    {

        private global::Microsoft.Graph.outlookItemFetcher _itemFetcher;

        public global::Microsoft.Graph.IoutlookItemFetcher item

        {

            get

            {

                if (this._itemFetcher == null)

                {

                    this._itemFetcher = new global::Microsoft.Graph.outlookItemFetcher();

                    this._itemFetcher.Initialize(this.Context, GetPath("item"));

                }

                

                return this._itemFetcher;

            }

        }

        public itemAttachmentFetcher()

        {

        }

        public async global::System.Threading.Tasks.Task<global::Microsoft.Graph.IitemAttachment> ExecuteAsync()

        {

            return await EnsureQuery().ExecuteSingleAsync();

        }

        public global::Microsoft.Graph.IitemAttachmentFetcher Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.IitemAttachment, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IitemAttachmentFetcher) new global::Microsoft.Graph.itemAttachmentFetcher()

            {

                _query = this.EnsureQuery().Expand<TTarget>(navigationPropertyAccessor)

            }

            ;

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IitemAttachment> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.itemAttachment, global::Microsoft.Graph.IitemAttachment>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IitemAttachment> _query;

    }

    internal partial class itemAttachmentCollection:Microsoft.OData.ProxyExtensions.QueryableSet<global::Microsoft.Graph.IitemAttachment>, global::Microsoft.Graph.IitemAttachmentCollection

    {

        internal itemAttachmentCollection(global::Microsoft.OData.Client.DataServiceQuery inner,Microsoft.OData.ProxyExtensions.DataServiceContextWrapper context,object entity,string path): base(inner, context, entity as Microsoft.OData.ProxyExtensions.EntityBase, path)

        {

        }

        public global::Microsoft.Graph.IitemAttachmentFetcher GetById(System.String id)

        {

            return this[id];

        }

        public global::System.Threading.Tasks.Task<Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.IitemAttachment>> ExecuteAsync()

        {

            return ExecuteAsyncInternal();

        }

        public global::System.Threading.Tasks.Task AdditemAttachmentAsync(global::Microsoft.Graph.IitemAttachment item, System.Boolean deferSaveChanges = false)

        {

            if (Entity == null)

            {

                Context.AddObject(Path, item);

            }

            else

            {

                var lastSlash = Path.LastIndexOf('/');

                var shortPath = (lastSlash >= 0 && lastSlash < Path.Length - 1) ? Path.Substring(lastSlash + 1) : Path;

                Context.AddRelatedObject(Entity, shortPath, item);

            }

            if (!deferSaveChanges)

            {

                return Context.SaveChangesAsync();

            }

            else

            {

                var retVal = new global::System.Threading.Tasks.TaskCompletionSource<object>();

                retVal.SetResult(null);

                return retVal.Task;

            }

        }

        public global::Microsoft.Graph.IitemAttachmentFetcher this[System.String id]

        {

            get

            {

                var path = GetPath<global::Microsoft.Graph.itemAttachment>((i) => i.id == id);

                var fetcher = new global::Microsoft.Graph.itemAttachmentFetcher();

                fetcher.Initialize(Context, path);

                

                return fetcher;

            }

        }

    }

    internal partial class itemAttachmentCollection

    {

        public global::System.Threading.Tasks.Task<System.Int64> CountAsync()

        {

            return new DataServiceQuerySingle<long>(Context, Path + "/$count").GetValueAsync();

        }

    }

    [global::Microsoft.OData.Client.Key("id")]

    public partial class eventMessage:global::Microsoft.Graph.message, global::Microsoft.Graph.IeventMessage, global::Microsoft.Graph.IeventMessageFetcher

    {

        private global::Microsoft.Graph.Event _event;

        private global::Microsoft.Graph.eventFetcher _eventFetcher;

        private global::Microsoft.Graph.meetingMessageType _meetingMessageType;

        public global::Microsoft.Graph.meetingMessageType meetingMessageType

        {

            get

            {

                return _meetingMessageType;

            }

            set

            {

                if (value != _meetingMessageType)

                {

                    _meetingMessageType = value;

                    OnPropertyChanged("meetingMessageType");

                }

            }

        }

        global::Microsoft.Graph.Ievent global::Microsoft.Graph.IeventMessage.Event

        {

            get

            {

                return this._event;

            }

            set

            {

                if (this.Event != value)

                {

                    this.Event = (global::Microsoft.Graph.Event)value;

                }

            }

        }

        public global::Microsoft.Graph.Event Event

        {

            get

            {

                return this._event;

            }

            set

            {

                if (this._event != value)

                {

                    this._event = value;

                    if (Context != null && Context.GetEntityDescriptor(this) != null && (value == null || Context.GetEntityDescriptor(value) != null))

                    {

                        Context.SetLink(this, "event", value);

                    }

                }

            }

        }

        global::Microsoft.Graph.IeventFetcher global::Microsoft.Graph.IeventMessageFetcher.Event

        {

            get

            {

                if (this._eventFetcher == null)

                {

                    this._eventFetcher = new global::Microsoft.Graph.eventFetcher();

                    this._eventFetcher.Initialize(this.Context, GetPath("event"));

                }

                

                return this._eventFetcher;

            }

        }

        public eventMessage()

        {

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IeventMessage> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.eventMessage, global::Microsoft.Graph.IeventMessage>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IeventMessage> _query;

        global::System.Threading.Tasks.Task<global::Microsoft.Graph.IeventMessage> global::Microsoft.Graph.IeventMessageFetcher.ExecuteAsync()

        {

            var tsc = new global::System.Threading.Tasks.TaskCompletionSource<global::Microsoft.Graph.IeventMessage>();

            tsc.SetResult(this);

            return tsc.Task;

        }

        global::Microsoft.Graph.IeventMessageFetcher global::Microsoft.Graph.IeventMessageFetcher.Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.IeventMessage, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IeventMessageFetcher) this;

        }

    }

    internal partial class eventMessageFetcher:global::Microsoft.Graph.messageFetcher, global::Microsoft.Graph.IeventMessageFetcher

    {

        private global::Microsoft.Graph.eventFetcher _eventFetcher;

        public global::Microsoft.Graph.IeventFetcher Event

        {

            get

            {

                if (this._eventFetcher == null)

                {

                    this._eventFetcher = new global::Microsoft.Graph.eventFetcher();

                    this._eventFetcher.Initialize(this.Context, GetPath("event"));

                }

                

                return this._eventFetcher;

            }

        }

        public eventMessageFetcher()

        {

        }

        public async new global::System.Threading.Tasks.Task<global::Microsoft.Graph.IeventMessage> ExecuteAsync()

        {

            return await EnsureQuery().ExecuteSingleAsync();

        }

        public global::Microsoft.Graph.IeventMessageFetcher Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.IeventMessage, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IeventMessageFetcher) new global::Microsoft.Graph.eventMessageFetcher()

            {

                _query = this.EnsureQuery().Expand<TTarget>(navigationPropertyAccessor)

            }

            ;

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IeventMessage> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.eventMessage, global::Microsoft.Graph.IeventMessage>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IeventMessage> _query;

    }

    internal partial class eventMessageCollection:Microsoft.OData.ProxyExtensions.QueryableSet<global::Microsoft.Graph.IeventMessage>, global::Microsoft.Graph.IeventMessageCollection

    {

        internal eventMessageCollection(global::Microsoft.OData.Client.DataServiceQuery inner,Microsoft.OData.ProxyExtensions.DataServiceContextWrapper context,object entity,string path): base(inner, context, entity as Microsoft.OData.ProxyExtensions.EntityBase, path)

        {

        }

        public global::Microsoft.Graph.IeventMessageFetcher GetById(System.String id)

        {

            return this[id];

        }

        public global::System.Threading.Tasks.Task<Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.IeventMessage>> ExecuteAsync()

        {

            return ExecuteAsyncInternal();

        }

        public global::System.Threading.Tasks.Task AddeventMessageAsync(global::Microsoft.Graph.IeventMessage item, System.Boolean deferSaveChanges = false)

        {

            if (Entity == null)

            {

                Context.AddObject(Path, item);

            }

            else

            {

                var lastSlash = Path.LastIndexOf('/');

                var shortPath = (lastSlash >= 0 && lastSlash < Path.Length - 1) ? Path.Substring(lastSlash + 1) : Path;

                Context.AddRelatedObject(Entity, shortPath, item);

            }

            if (!deferSaveChanges)

            {

                return Context.SaveChangesAsync();

            }

            else

            {

                var retVal = new global::System.Threading.Tasks.TaskCompletionSource<object>();

                retVal.SetResult(null);

                return retVal.Task;

            }

        }

        public global::Microsoft.Graph.IeventMessageFetcher this[System.String id]

        {

            get

            {

                var path = GetPath<global::Microsoft.Graph.eventMessage>((i) => i.id == id);

                var fetcher = new global::Microsoft.Graph.eventMessageFetcher();

                fetcher.Initialize(Context, path);

                

                return fetcher;

            }

        }

    }

    internal partial class eventMessageCollection

    {

        public global::System.Threading.Tasks.Task<System.Int64> CountAsync()

        {

            return new DataServiceQuerySingle<long>(Context, Path + "/$count").GetValueAsync();

        }

    }

    [global::Microsoft.OData.Client.Key("id")]

    public partial class referenceAttachment:global::Microsoft.Graph.attachment, global::Microsoft.Graph.IreferenceAttachment, global::Microsoft.Graph.IreferenceAttachmentFetcher

    {

        public referenceAttachment()

        {

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IreferenceAttachment> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.referenceAttachment, global::Microsoft.Graph.IreferenceAttachment>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IreferenceAttachment> _query;

        global::System.Threading.Tasks.Task<global::Microsoft.Graph.IreferenceAttachment> global::Microsoft.Graph.IreferenceAttachmentFetcher.ExecuteAsync()

        {

            var tsc = new global::System.Threading.Tasks.TaskCompletionSource<global::Microsoft.Graph.IreferenceAttachment>();

            tsc.SetResult(this);

            return tsc.Task;

        }

        global::Microsoft.Graph.IreferenceAttachmentFetcher global::Microsoft.Graph.IreferenceAttachmentFetcher.Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.IreferenceAttachment, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IreferenceAttachmentFetcher) this;

        }

    }

    internal partial class referenceAttachmentFetcher:global::Microsoft.Graph.attachmentFetcher, global::Microsoft.Graph.IreferenceAttachmentFetcher

    {

        public referenceAttachmentFetcher()

        {

        }

        public async global::System.Threading.Tasks.Task<global::Microsoft.Graph.IreferenceAttachment> ExecuteAsync()

        {

            return await EnsureQuery().ExecuteSingleAsync();

        }

        public global::Microsoft.Graph.IreferenceAttachmentFetcher Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.IreferenceAttachment, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IreferenceAttachmentFetcher) new global::Microsoft.Graph.referenceAttachmentFetcher()

            {

                _query = this.EnsureQuery().Expand<TTarget>(navigationPropertyAccessor)

            }

            ;

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IreferenceAttachment> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.referenceAttachment, global::Microsoft.Graph.IreferenceAttachment>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IreferenceAttachment> _query;

    }

    internal partial class referenceAttachmentCollection:Microsoft.OData.ProxyExtensions.QueryableSet<global::Microsoft.Graph.IreferenceAttachment>, global::Microsoft.Graph.IreferenceAttachmentCollection

    {

        internal referenceAttachmentCollection(global::Microsoft.OData.Client.DataServiceQuery inner,Microsoft.OData.ProxyExtensions.DataServiceContextWrapper context,object entity,string path): base(inner, context, entity as Microsoft.OData.ProxyExtensions.EntityBase, path)

        {

        }

        public global::Microsoft.Graph.IreferenceAttachmentFetcher GetById(System.String id)

        {

            return this[id];

        }

        public global::System.Threading.Tasks.Task<Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.IreferenceAttachment>> ExecuteAsync()

        {

            return ExecuteAsyncInternal();

        }

        public global::System.Threading.Tasks.Task AddreferenceAttachmentAsync(global::Microsoft.Graph.IreferenceAttachment item, System.Boolean deferSaveChanges = false)

        {

            if (Entity == null)

            {

                Context.AddObject(Path, item);

            }

            else

            {

                var lastSlash = Path.LastIndexOf('/');

                var shortPath = (lastSlash >= 0 && lastSlash < Path.Length - 1) ? Path.Substring(lastSlash + 1) : Path;

                Context.AddRelatedObject(Entity, shortPath, item);

            }

            if (!deferSaveChanges)

            {

                return Context.SaveChangesAsync();

            }

            else

            {

                var retVal = new global::System.Threading.Tasks.TaskCompletionSource<object>();

                retVal.SetResult(null);

                return retVal.Task;

            }

        }

        public global::Microsoft.Graph.IreferenceAttachmentFetcher this[System.String id]

        {

            get

            {

                var path = GetPath<global::Microsoft.Graph.referenceAttachment>((i) => i.id == id);

                var fetcher = new global::Microsoft.Graph.referenceAttachmentFetcher();

                fetcher.Initialize(Context, path);

                

                return fetcher;

            }

        }

    }

    internal partial class referenceAttachmentCollection

    {

        public global::System.Threading.Tasks.Task<System.Int64> CountAsync()

        {

            return new DataServiceQuerySingle<long>(Context, Path + "/$count").GetValueAsync();

        }

    }

    [global::Microsoft.OData.Client.Key("id")]

    public partial class openTypeExtension:global::Microsoft.Graph.extension, global::Microsoft.Graph.IopenTypeExtension, global::Microsoft.Graph.IopenTypeExtensionFetcher

    {

        private System.String _extensionName;

        public System.String extensionName

        {

            get

            {

                return _extensionName;

            }

            set

            {

                if (value != _extensionName)

                {

                    _extensionName = value;

                    OnPropertyChanged("extensionName");

                }

            }

        }

        public openTypeExtension()

        {

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IopenTypeExtension> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.openTypeExtension, global::Microsoft.Graph.IopenTypeExtension>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IopenTypeExtension> _query;

        global::System.Threading.Tasks.Task<global::Microsoft.Graph.IopenTypeExtension> global::Microsoft.Graph.IopenTypeExtensionFetcher.ExecuteAsync()

        {

            var tsc = new global::System.Threading.Tasks.TaskCompletionSource<global::Microsoft.Graph.IopenTypeExtension>();

            tsc.SetResult(this);

            return tsc.Task;

        }

        global::Microsoft.Graph.IopenTypeExtensionFetcher global::Microsoft.Graph.IopenTypeExtensionFetcher.Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.IopenTypeExtension, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IopenTypeExtensionFetcher) this;

        }

    }

    internal partial class openTypeExtensionFetcher:global::Microsoft.Graph.extensionFetcher, global::Microsoft.Graph.IopenTypeExtensionFetcher

    {

        public openTypeExtensionFetcher()

        {

        }

        public async global::System.Threading.Tasks.Task<global::Microsoft.Graph.IopenTypeExtension> ExecuteAsync()

        {

            return await EnsureQuery().ExecuteSingleAsync();

        }

        public global::Microsoft.Graph.IopenTypeExtensionFetcher Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.IopenTypeExtension, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IopenTypeExtensionFetcher) new global::Microsoft.Graph.openTypeExtensionFetcher()

            {

                _query = this.EnsureQuery().Expand<TTarget>(navigationPropertyAccessor)

            }

            ;

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IopenTypeExtension> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.openTypeExtension, global::Microsoft.Graph.IopenTypeExtension>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IopenTypeExtension> _query;

    }

    internal partial class openTypeExtensionCollection:Microsoft.OData.ProxyExtensions.QueryableSet<global::Microsoft.Graph.IopenTypeExtension>, global::Microsoft.Graph.IopenTypeExtensionCollection

    {

        internal openTypeExtensionCollection(global::Microsoft.OData.Client.DataServiceQuery inner,Microsoft.OData.ProxyExtensions.DataServiceContextWrapper context,object entity,string path): base(inner, context, entity as Microsoft.OData.ProxyExtensions.EntityBase, path)

        {

        }

        public global::Microsoft.Graph.IopenTypeExtensionFetcher GetById(System.String id)

        {

            return this[id];

        }

        public global::System.Threading.Tasks.Task<Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.IopenTypeExtension>> ExecuteAsync()

        {

            return ExecuteAsyncInternal();

        }

        public global::System.Threading.Tasks.Task AddopenTypeExtensionAsync(global::Microsoft.Graph.IopenTypeExtension item, System.Boolean deferSaveChanges = false)

        {

            if (Entity == null)

            {

                Context.AddObject(Path, item);

            }

            else

            {

                var lastSlash = Path.LastIndexOf('/');

                var shortPath = (lastSlash >= 0 && lastSlash < Path.Length - 1) ? Path.Substring(lastSlash + 1) : Path;

                Context.AddRelatedObject(Entity, shortPath, item);

            }

            if (!deferSaveChanges)

            {

                return Context.SaveChangesAsync();

            }

            else

            {

                var retVal = new global::System.Threading.Tasks.TaskCompletionSource<object>();

                retVal.SetResult(null);

                return retVal.Task;

            }

        }

        public global::Microsoft.Graph.IopenTypeExtensionFetcher this[System.String id]

        {

            get

            {

                var path = GetPath<global::Microsoft.Graph.openTypeExtension>((i) => i.id == id);

                var fetcher = new global::Microsoft.Graph.openTypeExtensionFetcher();

                fetcher.Initialize(Context, path);

                

                return fetcher;

            }

        }

    }

    internal partial class openTypeExtensionCollection

    {

        public global::System.Threading.Tasks.Task<System.Int64> CountAsync()

        {

            return new DataServiceQuerySingle<long>(Context, Path + "/$count").GetValueAsync();

        }

    }

    [global::Microsoft.OData.Client.Key("id")]

    public partial class post:global::Microsoft.Graph.outlookItem, global::Microsoft.Graph.Ipost, global::Microsoft.Graph.IpostFetcher

    {

        private global::Microsoft.Graph.post _inReplyTo;

        private global::Microsoft.Graph.postFetcher _inReplyToFetcher;

        private global::Microsoft.Graph.extensionCollection _extensionsCollection;

        private global::Microsoft.Graph.attachmentCollection _attachmentsCollection;

        private global::Microsoft.Graph.itemBody _body;

        private System.DateTimeOffset _receivedDateTime;

        private System.Boolean _hasAttachments;

        private global::Microsoft.Graph.recipient _from;

        private global::Microsoft.Graph.recipient _sender;

        private System.String _conversationThreadId;

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.recipient> _newParticipants;

        private System.String _conversationId;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.extension> _extensionsConcrete;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.attachment> _attachmentsConcrete;

        public global::Microsoft.Graph.itemBody body

        {

            get

            {

                return _body;

            }

            set

            {

                if (value != _body)

                {

                    _body = value;

                    OnPropertyChanged("body");

                }

            }

        }

        public System.DateTimeOffset receivedDateTime

        {

            get

            {

                return _receivedDateTime;

            }

            set

            {

                if (value != _receivedDateTime)

                {

                    _receivedDateTime = value;

                    OnPropertyChanged("receivedDateTime");

                }

            }

        }

        public System.Boolean hasAttachments

        {

            get

            {

                return _hasAttachments;

            }

            set

            {

                if (value != _hasAttachments)

                {

                    _hasAttachments = value;

                    OnPropertyChanged("hasAttachments");

                }

            }

        }

        public global::Microsoft.Graph.recipient from

        {

            get

            {

                return _from;

            }

            set

            {

                if (value != _from)

                {

                    _from = value;

                    OnPropertyChanged("from");

                }

            }

        }

        public global::Microsoft.Graph.recipient sender

        {

            get

            {

                return _sender;

            }

            set

            {

                if (value != _sender)

                {

                    _sender = value;

                    OnPropertyChanged("sender");

                }

            }

        }

        public System.String conversationThreadId

        {

            get

            {

                return _conversationThreadId;

            }

            set

            {

                if (value != _conversationThreadId)

                {

                    _conversationThreadId = value;

                    OnPropertyChanged("conversationThreadId");

                }

            }

        }

        public System.Collections.Generic.IList<global::Microsoft.Graph.recipient> newParticipants

        {

            get

            {

                if (this._newParticipants == default(System.Collections.Generic.IList<global::Microsoft.Graph.recipient>))

                {

                    this._newParticipants = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<global::Microsoft.Graph.recipient>();

                    this._newParticipants.SetContainer(() => GetContainingEntity("newParticipants"));

                }

                return this._newParticipants;

            }

            set

            {

                newParticipants.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        newParticipants.Add(i);

                    }

                }

            }

        }

        public System.String conversationId

        {

            get

            {

                return _conversationId;

            }

            set

            {

                if (value != _conversationId)

                {

                    _conversationId = value;

                    OnPropertyChanged("conversationId");

                }

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.Iextension> global::Microsoft.Graph.Ipost.extensions

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.Iextension, global::Microsoft.Graph.extension>(Context, (DataServiceCollection<global::Microsoft.Graph.extension>) extensions);

            }

        }

        global::Microsoft.Graph.Ipost global::Microsoft.Graph.Ipost.inReplyTo

        {

            get

            {

                return this._inReplyTo;

            }

            set

            {

                if (this.inReplyTo != value)

                {

                    this.inReplyTo = (global::Microsoft.Graph.post)value;

                }

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.Iattachment> global::Microsoft.Graph.Ipost.attachments

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.Iattachment, global::Microsoft.Graph.attachment>(Context, (DataServiceCollection<global::Microsoft.Graph.attachment>) attachments);

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.extension> extensions

        {

            get

            {

                if (this._extensionsConcrete == null)

                {

                    this._extensionsConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.extension>();

                    this._extensionsConcrete.SetContainer(() => GetContainingEntity("extensions"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.extension>)this._extensionsConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                extensions.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        extensions.Add(i);

                    }

                }

            }

        }

        public global::Microsoft.Graph.post inReplyTo

        {

            get

            {

                return this._inReplyTo;

            }

            set

            {

                if (this._inReplyTo != value)

                {

                    this._inReplyTo = value;

                    if (Context != null && Context.GetEntityDescriptor(this) != null && (value == null || Context.GetEntityDescriptor(value) != null))

                    {

                        Context.SetLink(this, "inReplyTo", value);

                    }

                }

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.attachment> attachments

        {

            get

            {

                if (this._attachmentsConcrete == null)

                {

                    this._attachmentsConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.attachment>();

                    this._attachmentsConcrete.SetContainer(() => GetContainingEntity("attachments"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.attachment>)this._attachmentsConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                attachments.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        attachments.Add(i);

                    }

                }

            }

        }

        global::Microsoft.Graph.IextensionCollection global::Microsoft.Graph.IpostFetcher.extensions

        {

            get

            {

                if (this._extensionsCollection == null)

                {

                    this._extensionsCollection = new global::Microsoft.Graph.extensionCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.extension>(GetPath("extensions")) : null,
                       Context,
                       this,
                       GetPath("extensions"));

                }

                

                return this._extensionsCollection;

            }

        }

        global::Microsoft.Graph.IpostFetcher global::Microsoft.Graph.IpostFetcher.inReplyTo

        {

            get

            {

                if (this._inReplyToFetcher == null)

                {

                    this._inReplyToFetcher = new global::Microsoft.Graph.postFetcher();

                    this._inReplyToFetcher.Initialize(this.Context, GetPath("inReplyTo"));

                }

                

                return this._inReplyToFetcher;

            }

        }

        global::Microsoft.Graph.IattachmentCollection global::Microsoft.Graph.IpostFetcher.attachments

        {

            get

            {

                if (this._attachmentsCollection == null)

                {

                    this._attachmentsCollection = new global::Microsoft.Graph.attachmentCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.attachment>(GetPath("attachments")) : null,
                       Context,
                       this,
                       GetPath("attachments"));

                }

                

                return this._attachmentsCollection;

            }

        }

        public post()

        {

        }

        public async System.Threading.Tasks.Task forwardAsync(System.String Comment, System.Collections.Generic.ICollection<global::Microsoft.Graph.recipient> ToRecipients)

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.forward");

            await this.Context.ExecuteAsync(requestUri, "POST", new OperationParameter[2]

            {

                new BodyOperationParameter("Comment", (object) Comment),

                new BodyOperationParameter("ToRecipients", (object) ToRecipients),

            }

            );

        }

        public async System.Threading.Tasks.Task replyAsync(global::Microsoft.Graph.Ipost Post)

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.reply");

            await this.Context.ExecuteAsync(requestUri, "POST", new OperationParameter[1]

            {

                new BodyOperationParameter("Post", (object) Post),

            }

            );

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Ipost> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.post, global::Microsoft.Graph.Ipost>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Ipost> _query;

        global::System.Threading.Tasks.Task<global::Microsoft.Graph.Ipost> global::Microsoft.Graph.IpostFetcher.ExecuteAsync()

        {

            var tsc = new global::System.Threading.Tasks.TaskCompletionSource<global::Microsoft.Graph.Ipost>();

            tsc.SetResult(this);

            return tsc.Task;

        }

        global::Microsoft.Graph.IpostFetcher global::Microsoft.Graph.IpostFetcher.Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.Ipost, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IpostFetcher) this;

        }

    }

    internal partial class postFetcher:global::Microsoft.Graph.outlookItemFetcher, global::Microsoft.Graph.IpostFetcher

    {

        private global::Microsoft.Graph.postFetcher _inReplyToFetcher;

        private global::Microsoft.Graph.extensionCollection _extensionsCollection;

        private global::Microsoft.Graph.attachmentCollection _attachmentsCollection;

        public global::Microsoft.Graph.IextensionCollection extensions

        {

            get

            {

                if (this._extensionsCollection == null)

                {

                    this._extensionsCollection = new global::Microsoft.Graph.extensionCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.extension>(GetPath("extensions")) : null,
                       Context,
                       this,
                       GetPath("extensions"));

                }

                

                return this._extensionsCollection;

            }

        }

        public global::Microsoft.Graph.IpostFetcher inReplyTo

        {

            get

            {

                if (this._inReplyToFetcher == null)

                {

                    this._inReplyToFetcher = new global::Microsoft.Graph.postFetcher();

                    this._inReplyToFetcher.Initialize(this.Context, GetPath("inReplyTo"));

                }

                

                return this._inReplyToFetcher;

            }

        }

        public global::Microsoft.Graph.IattachmentCollection attachments

        {

            get

            {

                if (this._attachmentsCollection == null)

                {

                    this._attachmentsCollection = new global::Microsoft.Graph.attachmentCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.attachment>(GetPath("attachments")) : null,
                       Context,
                       this,
                       GetPath("attachments"));

                }

                

                return this._attachmentsCollection;

            }

        }

        public postFetcher()

        {

        }

        public async System.Threading.Tasks.Task forwardAsync(System.String Comment, System.Collections.Generic.ICollection<global::Microsoft.Graph.recipient> ToRecipients)

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.forward");

            await this.Context.ExecuteAsync(requestUri, "POST", new OperationParameter[2]

            {

                new BodyOperationParameter("Comment", (object) Comment),

                new BodyOperationParameter("ToRecipients", (object) ToRecipients),

            }

            );

        }

        public async System.Threading.Tasks.Task replyAsync(global::Microsoft.Graph.Ipost Post)

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.reply");

            await this.Context.ExecuteAsync(requestUri, "POST", new OperationParameter[1]

            {

                new BodyOperationParameter("Post", (object) Post),

            }

            );

        }

        public async global::System.Threading.Tasks.Task<global::Microsoft.Graph.Ipost> ExecuteAsync()

        {

            return await EnsureQuery().ExecuteSingleAsync();

        }

        public global::Microsoft.Graph.IpostFetcher Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.Ipost, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IpostFetcher) new global::Microsoft.Graph.postFetcher()

            {

                _query = this.EnsureQuery().Expand<TTarget>(navigationPropertyAccessor)

            }

            ;

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Ipost> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.post, global::Microsoft.Graph.Ipost>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Ipost> _query;

    }

    internal partial class postCollection:Microsoft.OData.ProxyExtensions.QueryableSet<global::Microsoft.Graph.Ipost>, global::Microsoft.Graph.IpostCollection

    {

        internal postCollection(global::Microsoft.OData.Client.DataServiceQuery inner,Microsoft.OData.ProxyExtensions.DataServiceContextWrapper context,object entity,string path): base(inner, context, entity as Microsoft.OData.ProxyExtensions.EntityBase, path)

        {

        }

        public global::Microsoft.Graph.IpostFetcher GetById(System.String id)

        {

            return this[id];

        }

        public global::System.Threading.Tasks.Task<Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.Ipost>> ExecuteAsync()

        {

            return ExecuteAsyncInternal();

        }

        public global::System.Threading.Tasks.Task AddpostAsync(global::Microsoft.Graph.Ipost item, System.Boolean deferSaveChanges = false)

        {

            if (Entity == null)

            {

                Context.AddObject(Path, item);

            }

            else

            {

                var lastSlash = Path.LastIndexOf('/');

                var shortPath = (lastSlash >= 0 && lastSlash < Path.Length - 1) ? Path.Substring(lastSlash + 1) : Path;

                Context.AddRelatedObject(Entity, shortPath, item);

            }

            if (!deferSaveChanges)

            {

                return Context.SaveChangesAsync();

            }

            else

            {

                var retVal = new global::System.Threading.Tasks.TaskCompletionSource<object>();

                retVal.SetResult(null);

                return retVal.Task;

            }

        }

        public global::Microsoft.Graph.IpostFetcher this[System.String id]

        {

            get

            {

                var path = GetPath<global::Microsoft.Graph.post>((i) => i.id == id);

                var fetcher = new global::Microsoft.Graph.postFetcher();

                fetcher.Initialize(Context, path);

                

                return fetcher;

            }

        }

    }

    internal partial class postCollection

    {

        public global::System.Threading.Tasks.Task<System.Int64> CountAsync()

        {

            return new DataServiceQuerySingle<long>(Context, Path + "/$count").GetValueAsync();

        }

    }

    [global::Microsoft.OData.Client.Key("id")]

    public partial class inferenceClassificationOverride:Microsoft.OData.ProxyExtensions.EntityBase, global::Microsoft.Graph.IinferenceClassificationOverride, global::Microsoft.Graph.IinferenceClassificationOverrideFetcher

    {

        private global::Microsoft.Graph.inferenceClassificationType _classifyAs;

        private global::Microsoft.Graph.emailAddress _senderEmailAddress;

        private System.String _id;

        public global::Microsoft.Graph.inferenceClassificationType classifyAs

        {

            get

            {

                return _classifyAs;

            }

            set

            {

                if (value != _classifyAs)

                {

                    _classifyAs = value;

                    OnPropertyChanged("classifyAs");

                }

            }

        }

        public global::Microsoft.Graph.emailAddress senderEmailAddress

        {

            get

            {

                return _senderEmailAddress;

            }

            set

            {

                if (value != _senderEmailAddress)

                {

                    _senderEmailAddress = value;

                    OnPropertyChanged("senderEmailAddress");

                }

            }

        }

        public System.String id

        {

            get

            {

                return _id;

            }

            set

            {

                if (value != _id)

                {

                    _id = value;

                    OnPropertyChanged("id");

                }

            }

        }

        public inferenceClassificationOverride(): base()

        {

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IinferenceClassificationOverride> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.inferenceClassificationOverride, global::Microsoft.Graph.IinferenceClassificationOverride>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IinferenceClassificationOverride> _query;

        global::System.Threading.Tasks.Task<global::Microsoft.Graph.IinferenceClassificationOverride> global::Microsoft.Graph.IinferenceClassificationOverrideFetcher.ExecuteAsync()

        {

            var tsc = new global::System.Threading.Tasks.TaskCompletionSource<global::Microsoft.Graph.IinferenceClassificationOverride>();

            tsc.SetResult(this);

            return tsc.Task;

        }

        global::Microsoft.Graph.IinferenceClassificationOverrideFetcher global::Microsoft.Graph.IinferenceClassificationOverrideFetcher.Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.IinferenceClassificationOverride, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IinferenceClassificationOverrideFetcher) this;

        }

    }

    internal partial class inferenceClassificationOverrideFetcher:Microsoft.OData.ProxyExtensions.RestShallowObjectFetcher, global::Microsoft.Graph.IinferenceClassificationOverrideFetcher

    {

        public inferenceClassificationOverrideFetcher(): base()

        {

        }

        public async global::System.Threading.Tasks.Task<global::Microsoft.Graph.IinferenceClassificationOverride> ExecuteAsync()

        {

            return await EnsureQuery().ExecuteSingleAsync();

        }

        public global::Microsoft.Graph.IinferenceClassificationOverrideFetcher Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.IinferenceClassificationOverride, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IinferenceClassificationOverrideFetcher) new global::Microsoft.Graph.inferenceClassificationOverrideFetcher()

            {

                _query = this.EnsureQuery().Expand<TTarget>(navigationPropertyAccessor)

            }

            ;

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IinferenceClassificationOverride> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.inferenceClassificationOverride, global::Microsoft.Graph.IinferenceClassificationOverride>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IinferenceClassificationOverride> _query;

    }

    internal partial class inferenceClassificationOverrideCollection:Microsoft.OData.ProxyExtensions.QueryableSet<global::Microsoft.Graph.IinferenceClassificationOverride>, global::Microsoft.Graph.IinferenceClassificationOverrideCollection

    {

        internal inferenceClassificationOverrideCollection(global::Microsoft.OData.Client.DataServiceQuery inner,Microsoft.OData.ProxyExtensions.DataServiceContextWrapper context,object entity,string path): base(inner, context, entity as Microsoft.OData.ProxyExtensions.EntityBase, path)

        {

        }

        public global::Microsoft.Graph.IinferenceClassificationOverrideFetcher GetById(System.String id)

        {

            return this[id];

        }

        public global::System.Threading.Tasks.Task<Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.IinferenceClassificationOverride>> ExecuteAsync()

        {

            return ExecuteAsyncInternal();

        }

        public global::System.Threading.Tasks.Task AddinferenceClassificationOverrideAsync(global::Microsoft.Graph.IinferenceClassificationOverride item, System.Boolean deferSaveChanges = false)

        {

            if (Entity == null)

            {

                Context.AddObject(Path, item);

            }

            else

            {

                var lastSlash = Path.LastIndexOf('/');

                var shortPath = (lastSlash >= 0 && lastSlash < Path.Length - 1) ? Path.Substring(lastSlash + 1) : Path;

                Context.AddRelatedObject(Entity, shortPath, item);

            }

            if (!deferSaveChanges)

            {

                return Context.SaveChangesAsync();

            }

            else

            {

                var retVal = new global::System.Threading.Tasks.TaskCompletionSource<object>();

                retVal.SetResult(null);

                return retVal.Task;

            }

        }

        public global::Microsoft.Graph.IinferenceClassificationOverrideFetcher this[System.String id]

        {

            get

            {

                var path = GetPath<global::Microsoft.Graph.inferenceClassificationOverride>((i) => i.id == id);

                var fetcher = new global::Microsoft.Graph.inferenceClassificationOverrideFetcher();

                fetcher.Initialize(Context, path);

                

                return fetcher;

            }

        }

    }

    internal partial class inferenceClassificationOverrideCollection

    {

        public global::System.Threading.Tasks.Task<System.Int64> CountAsync()

        {

            return new DataServiceQuerySingle<long>(Context, Path + "/$count").GetValueAsync();

        }

    }

    internal partial class inferenceClassificationOverrideFetcher

    {

    }

    public partial class inferenceClassificationOverride

    {

    }

    [global::Microsoft.OData.Client.Key("id")]

    public partial class share:Microsoft.OData.ProxyExtensions.EntityBase, global::Microsoft.Graph.Ishare, global::Microsoft.Graph.IshareFetcher

    {

        private global::Microsoft.Graph.driveItemCollection _itemsCollection;

        private System.String _id;

        private System.String _name;

        private global::Microsoft.Graph.identitySet _owner;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.driveItem> _itemsConcrete;

        public System.String id

        {

            get

            {

                return _id;

            }

            set

            {

                if (value != _id)

                {

                    _id = value;

                    OnPropertyChanged("id");

                }

            }

        }

        public System.String name

        {

            get

            {

                return _name;

            }

            set

            {

                if (value != _name)

                {

                    _name = value;

                    OnPropertyChanged("name");

                }

            }

        }

        public global::Microsoft.Graph.identitySet owner

        {

            get

            {

                return _owner;

            }

            set

            {

                if (value != _owner)

                {

                    _owner = value;

                    OnPropertyChanged("owner");

                }

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.IdriveItem> global::Microsoft.Graph.Ishare.items

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.IdriveItem, global::Microsoft.Graph.driveItem>(Context, (DataServiceCollection<global::Microsoft.Graph.driveItem>) items);

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.driveItem> items

        {

            get

            {

                if (this._itemsConcrete == null)

                {

                    this._itemsConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.driveItem>();

                    this._itemsConcrete.SetContainer(() => GetContainingEntity("items"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.driveItem>)this._itemsConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                items.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        items.Add(i);

                    }

                }

            }

        }

        global::Microsoft.Graph.IdriveItemCollection global::Microsoft.Graph.IshareFetcher.items

        {

            get

            {

                if (this._itemsCollection == null)

                {

                    this._itemsCollection = new global::Microsoft.Graph.driveItemCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.driveItem>(GetPath("items")) : null,
                       Context,
                       this,
                       GetPath("items"));

                }

                

                return this._itemsCollection;

            }

        }

        public share(): base()

        {

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Ishare> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.share, global::Microsoft.Graph.Ishare>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Ishare> _query;

        global::System.Threading.Tasks.Task<global::Microsoft.Graph.Ishare> global::Microsoft.Graph.IshareFetcher.ExecuteAsync()

        {

            var tsc = new global::System.Threading.Tasks.TaskCompletionSource<global::Microsoft.Graph.Ishare>();

            tsc.SetResult(this);

            return tsc.Task;

        }

        global::Microsoft.Graph.IshareFetcher global::Microsoft.Graph.IshareFetcher.Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.Ishare, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IshareFetcher) this;

        }

    }

    internal partial class shareFetcher:Microsoft.OData.ProxyExtensions.RestShallowObjectFetcher, global::Microsoft.Graph.IshareFetcher

    {

        private global::Microsoft.Graph.driveItemCollection _itemsCollection;

        public global::Microsoft.Graph.IdriveItemCollection items

        {

            get

            {

                if (this._itemsCollection == null)

                {

                    this._itemsCollection = new global::Microsoft.Graph.driveItemCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.driveItem>(GetPath("items")) : null,
                       Context,
                       this,
                       GetPath("items"));

                }

                

                return this._itemsCollection;

            }

        }

        public shareFetcher(): base()

        {

        }

        public async global::System.Threading.Tasks.Task<global::Microsoft.Graph.Ishare> ExecuteAsync()

        {

            return await EnsureQuery().ExecuteSingleAsync();

        }

        public global::Microsoft.Graph.IshareFetcher Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.Ishare, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IshareFetcher) new global::Microsoft.Graph.shareFetcher()

            {

                _query = this.EnsureQuery().Expand<TTarget>(navigationPropertyAccessor)

            }

            ;

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Ishare> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.share, global::Microsoft.Graph.Ishare>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Ishare> _query;

    }

    internal partial class shareCollection:Microsoft.OData.ProxyExtensions.QueryableSet<global::Microsoft.Graph.Ishare>, global::Microsoft.Graph.IshareCollection

    {

        internal shareCollection(global::Microsoft.OData.Client.DataServiceQuery inner,Microsoft.OData.ProxyExtensions.DataServiceContextWrapper context,object entity,string path): base(inner, context, entity as Microsoft.OData.ProxyExtensions.EntityBase, path)

        {

        }

        public global::Microsoft.Graph.IshareFetcher GetById(System.String id)

        {

            return this[id];

        }

        public global::System.Threading.Tasks.Task<Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.Ishare>> ExecuteAsync()

        {

            return ExecuteAsyncInternal();

        }

        public global::System.Threading.Tasks.Task AddshareAsync(global::Microsoft.Graph.Ishare item, System.Boolean deferSaveChanges = false)

        {

            if (Entity == null)

            {

                Context.AddObject(Path, item);

            }

            else

            {

                var lastSlash = Path.LastIndexOf('/');

                var shortPath = (lastSlash >= 0 && lastSlash < Path.Length - 1) ? Path.Substring(lastSlash + 1) : Path;

                Context.AddRelatedObject(Entity, shortPath, item);

            }

            if (!deferSaveChanges)

            {

                return Context.SaveChangesAsync();

            }

            else

            {

                var retVal = new global::System.Threading.Tasks.TaskCompletionSource<object>();

                retVal.SetResult(null);

                return retVal.Task;

            }

        }

        public global::Microsoft.Graph.IshareFetcher this[System.String id]

        {

            get

            {

                var path = GetPath<global::Microsoft.Graph.share>((i) => i.id == id);

                var fetcher = new global::Microsoft.Graph.shareFetcher();

                fetcher.Initialize(Context, path);

                

                return fetcher;

            }

        }

    }

    internal partial class shareCollection

    {

        public global::System.Threading.Tasks.Task<System.Int64> CountAsync()

        {

            return new DataServiceQuerySingle<long>(Context, Path + "/$count").GetValueAsync();

        }

    }

    internal partial class shareFetcher

    {

    }

    public partial class share

    {

    }

    [global::Microsoft.OData.Client.Key("id")]

    public partial class permission:Microsoft.OData.ProxyExtensions.EntityBase, global::Microsoft.Graph.Ipermission, global::Microsoft.Graph.IpermissionFetcher

    {

        private global::Microsoft.Graph.identitySet _grantedTo;

        private System.String _id;

        private global::Microsoft.Graph.sharingInvitation _invitation;

        private global::Microsoft.Graph.itemReference _inheritedFrom;

        private global::Microsoft.Graph.sharingLink _link;

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.String> _roles;

        private System.String _shareId;

        public global::Microsoft.Graph.identitySet grantedTo

        {

            get

            {

                return _grantedTo;

            }

            set

            {

                if (value != _grantedTo)

                {

                    _grantedTo = value;

                    OnPropertyChanged("grantedTo");

                }

            }

        }

        public System.String id

        {

            get

            {

                return _id;

            }

            set

            {

                if (value != _id)

                {

                    _id = value;

                    OnPropertyChanged("id");

                }

            }

        }

        public global::Microsoft.Graph.sharingInvitation invitation

        {

            get

            {

                return _invitation;

            }

            set

            {

                if (value != _invitation)

                {

                    _invitation = value;

                    OnPropertyChanged("invitation");

                }

            }

        }

        public global::Microsoft.Graph.itemReference inheritedFrom

        {

            get

            {

                return _inheritedFrom;

            }

            set

            {

                if (value != _inheritedFrom)

                {

                    _inheritedFrom = value;

                    OnPropertyChanged("inheritedFrom");

                }

            }

        }

        public global::Microsoft.Graph.sharingLink link

        {

            get

            {

                return _link;

            }

            set

            {

                if (value != _link)

                {

                    _link = value;

                    OnPropertyChanged("link");

                }

            }

        }

        public System.Collections.Generic.IList<System.String> roles

        {

            get

            {

                if (this._roles == default(System.Collections.Generic.IList<System.String>))

                {

                    this._roles = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.String>();

                    this._roles.SetContainer(() => GetContainingEntity("roles"));

                }

                return this._roles;

            }

            set

            {

                roles.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        roles.Add(i);

                    }

                }

            }

        }

        public System.String shareId

        {

            get

            {

                return _shareId;

            }

            set

            {

                if (value != _shareId)

                {

                    _shareId = value;

                    OnPropertyChanged("shareId");

                }

            }

        }

        public permission(): base()

        {

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Ipermission> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.permission, global::Microsoft.Graph.Ipermission>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Ipermission> _query;

        global::System.Threading.Tasks.Task<global::Microsoft.Graph.Ipermission> global::Microsoft.Graph.IpermissionFetcher.ExecuteAsync()

        {

            var tsc = new global::System.Threading.Tasks.TaskCompletionSource<global::Microsoft.Graph.Ipermission>();

            tsc.SetResult(this);

            return tsc.Task;

        }

        global::Microsoft.Graph.IpermissionFetcher global::Microsoft.Graph.IpermissionFetcher.Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.Ipermission, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IpermissionFetcher) this;

        }

    }

    internal partial class permissionFetcher:Microsoft.OData.ProxyExtensions.RestShallowObjectFetcher, global::Microsoft.Graph.IpermissionFetcher

    {

        public permissionFetcher(): base()

        {

        }

        public async global::System.Threading.Tasks.Task<global::Microsoft.Graph.Ipermission> ExecuteAsync()

        {

            return await EnsureQuery().ExecuteSingleAsync();

        }

        public global::Microsoft.Graph.IpermissionFetcher Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.Ipermission, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IpermissionFetcher) new global::Microsoft.Graph.permissionFetcher()

            {

                _query = this.EnsureQuery().Expand<TTarget>(navigationPropertyAccessor)

            }

            ;

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Ipermission> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.permission, global::Microsoft.Graph.Ipermission>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Ipermission> _query;

    }

    internal partial class permissionCollection:Microsoft.OData.ProxyExtensions.QueryableSet<global::Microsoft.Graph.Ipermission>, global::Microsoft.Graph.IpermissionCollection

    {

        internal permissionCollection(global::Microsoft.OData.Client.DataServiceQuery inner,Microsoft.OData.ProxyExtensions.DataServiceContextWrapper context,object entity,string path): base(inner, context, entity as Microsoft.OData.ProxyExtensions.EntityBase, path)

        {

        }

        public global::Microsoft.Graph.IpermissionFetcher GetById(System.String id)

        {

            return this[id];

        }

        public global::System.Threading.Tasks.Task<Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.Ipermission>> ExecuteAsync()

        {

            return ExecuteAsyncInternal();

        }

        public global::System.Threading.Tasks.Task AddpermissionAsync(global::Microsoft.Graph.Ipermission item, System.Boolean deferSaveChanges = false)

        {

            if (Entity == null)

            {

                Context.AddObject(Path, item);

            }

            else

            {

                var lastSlash = Path.LastIndexOf('/');

                var shortPath = (lastSlash >= 0 && lastSlash < Path.Length - 1) ? Path.Substring(lastSlash + 1) : Path;

                Context.AddRelatedObject(Entity, shortPath, item);

            }

            if (!deferSaveChanges)

            {

                return Context.SaveChangesAsync();

            }

            else

            {

                var retVal = new global::System.Threading.Tasks.TaskCompletionSource<object>();

                retVal.SetResult(null);

                return retVal.Task;

            }

        }

        public global::Microsoft.Graph.IpermissionFetcher this[System.String id]

        {

            get

            {

                var path = GetPath<global::Microsoft.Graph.permission>((i) => i.id == id);

                var fetcher = new global::Microsoft.Graph.permissionFetcher();

                fetcher.Initialize(Context, path);

                

                return fetcher;

            }

        }

    }

    internal partial class permissionCollection

    {

        public global::System.Threading.Tasks.Task<System.Int64> CountAsync()

        {

            return new DataServiceQuerySingle<long>(Context, Path + "/$count").GetValueAsync();

        }

    }

    internal partial class permissionFetcher

    {

    }

    public partial class permission

    {

    }

    [global::Microsoft.OData.Client.Key("id")]

    public partial class thumbnailSet:Microsoft.OData.ProxyExtensions.EntityBase, global::Microsoft.Graph.IthumbnailSet, global::Microsoft.Graph.IthumbnailSetFetcher

    {

        private System.String _id;

        private global::Microsoft.Graph.thumbnail _large;

        private global::Microsoft.Graph.thumbnail _medium;

        private global::Microsoft.Graph.thumbnail _small;

        private global::Microsoft.Graph.thumbnail _source;

        public System.String id

        {

            get

            {

                return _id;

            }

            set

            {

                if (value != _id)

                {

                    _id = value;

                    OnPropertyChanged("id");

                }

            }

        }

        public global::Microsoft.Graph.thumbnail large

        {

            get

            {

                return _large;

            }

            set

            {

                if (value != _large)

                {

                    _large = value;

                    OnPropertyChanged("large");

                }

            }

        }

        public global::Microsoft.Graph.thumbnail medium

        {

            get

            {

                return _medium;

            }

            set

            {

                if (value != _medium)

                {

                    _medium = value;

                    OnPropertyChanged("medium");

                }

            }

        }

        public global::Microsoft.Graph.thumbnail small

        {

            get

            {

                return _small;

            }

            set

            {

                if (value != _small)

                {

                    _small = value;

                    OnPropertyChanged("small");

                }

            }

        }

        public global::Microsoft.Graph.thumbnail source

        {

            get

            {

                return _source;

            }

            set

            {

                if (value != _source)

                {

                    _source = value;

                    OnPropertyChanged("source");

                }

            }

        }

        public thumbnailSet(): base()

        {

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IthumbnailSet> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.thumbnailSet, global::Microsoft.Graph.IthumbnailSet>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IthumbnailSet> _query;

        global::System.Threading.Tasks.Task<global::Microsoft.Graph.IthumbnailSet> global::Microsoft.Graph.IthumbnailSetFetcher.ExecuteAsync()

        {

            var tsc = new global::System.Threading.Tasks.TaskCompletionSource<global::Microsoft.Graph.IthumbnailSet>();

            tsc.SetResult(this);

            return tsc.Task;

        }

        global::Microsoft.Graph.IthumbnailSetFetcher global::Microsoft.Graph.IthumbnailSetFetcher.Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.IthumbnailSet, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IthumbnailSetFetcher) this;

        }

    }

    internal partial class thumbnailSetFetcher:Microsoft.OData.ProxyExtensions.RestShallowObjectFetcher, global::Microsoft.Graph.IthumbnailSetFetcher

    {

        public thumbnailSetFetcher(): base()

        {

        }

        public async global::System.Threading.Tasks.Task<global::Microsoft.Graph.IthumbnailSet> ExecuteAsync()

        {

            return await EnsureQuery().ExecuteSingleAsync();

        }

        public global::Microsoft.Graph.IthumbnailSetFetcher Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.IthumbnailSet, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.IthumbnailSetFetcher) new global::Microsoft.Graph.thumbnailSetFetcher()

            {

                _query = this.EnsureQuery().Expand<TTarget>(navigationPropertyAccessor)

            }

            ;

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IthumbnailSet> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.thumbnailSet, global::Microsoft.Graph.IthumbnailSet>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.IthumbnailSet> _query;

    }

    internal partial class thumbnailSetCollection:Microsoft.OData.ProxyExtensions.QueryableSet<global::Microsoft.Graph.IthumbnailSet>, global::Microsoft.Graph.IthumbnailSetCollection

    {

        internal thumbnailSetCollection(global::Microsoft.OData.Client.DataServiceQuery inner,Microsoft.OData.ProxyExtensions.DataServiceContextWrapper context,object entity,string path): base(inner, context, entity as Microsoft.OData.ProxyExtensions.EntityBase, path)

        {

        }

        public global::Microsoft.Graph.IthumbnailSetFetcher GetById(System.String id)

        {

            return this[id];

        }

        public global::System.Threading.Tasks.Task<Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.IthumbnailSet>> ExecuteAsync()

        {

            return ExecuteAsyncInternal();

        }

        public global::System.Threading.Tasks.Task AddthumbnailSetAsync(global::Microsoft.Graph.IthumbnailSet item, System.Boolean deferSaveChanges = false)

        {

            if (Entity == null)

            {

                Context.AddObject(Path, item);

            }

            else

            {

                var lastSlash = Path.LastIndexOf('/');

                var shortPath = (lastSlash >= 0 && lastSlash < Path.Length - 1) ? Path.Substring(lastSlash + 1) : Path;

                Context.AddRelatedObject(Entity, shortPath, item);

            }

            if (!deferSaveChanges)

            {

                return Context.SaveChangesAsync();

            }

            else

            {

                var retVal = new global::System.Threading.Tasks.TaskCompletionSource<object>();

                retVal.SetResult(null);

                return retVal.Task;

            }

        }

        public global::Microsoft.Graph.IthumbnailSetFetcher this[System.String id]

        {

            get

            {

                var path = GetPath<global::Microsoft.Graph.thumbnailSet>((i) => i.id == id);

                var fetcher = new global::Microsoft.Graph.thumbnailSetFetcher();

                fetcher.Initialize(Context, path);

                

                return fetcher;

            }

        }

    }

    internal partial class thumbnailSetCollection

    {

        public global::System.Threading.Tasks.Task<System.Int64> CountAsync()

        {

            return new DataServiceQuerySingle<long>(Context, Path + "/$count").GetValueAsync();

        }

    }

    internal partial class thumbnailSetFetcher

    {

    }

    public partial class thumbnailSet

    {

    }

    /// <summary>
    /// A OneNote notebook
    /// </summary>
    [global::Microsoft.OData.Client.Key("id")]

    public partial class notebook:Microsoft.OData.ProxyExtensions.EntityBase, global::Microsoft.Graph.Inotebook, global::Microsoft.Graph.InotebookFetcher

    {

        private global::Microsoft.Graph.sectionCollection _sectionsCollection;

        private global::Microsoft.Graph.sectionGroupCollection _sectionGroupsCollection;

        private System.Nullable<System.Boolean> _isDefault;

        private global::Microsoft.Graph.UserRole _userRole;

        private System.Nullable<System.Boolean> _isShared;

        private System.String _sectionsUrl;

        private System.String _sectionGroupsUrl;

        private global::Microsoft.Graph.notebookLinks _links;

        private System.String _name;

        private System.String _createdBy;

        private global::Microsoft.Graph.oneNoteIdentitySet _createdByIdentity;

        private System.String _lastModifiedBy;

        private global::Microsoft.Graph.oneNoteIdentitySet _lastModifiedByIdentity;

        private System.Nullable<System.DateTimeOffset> _lastModifiedTime;

        private System.String _id;

        private System.String _self;

        private System.Nullable<System.DateTimeOffset> _createdTime;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.section> _sectionsConcrete;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.sectionGroup> _sectionGroupsConcrete;

        /// <summary>
        /// Indicates whether this is the user's default notebook.
        /// </summary>
        public System.Nullable<System.Boolean> isDefault

        {

            get

            {

                return _isDefault;

            }

            set

            {

                if (value != _isDefault)

                {

                    _isDefault = value;

                    OnPropertyChanged("isDefault");

                }

            }

        }

        /// <summary>
        /// One of three values: Owner, Contributor, or Reader. Owner represents owner-level access to the notebook. Contributor represents read/write access to the notebook. Reader represents read-only access to the notebook.
        /// </summary>
        public global::Microsoft.Graph.UserRole userRole

        {

            get

            {

                return _userRole;

            }

            set

            {

                if (value != _userRole)

                {

                    _userRole = value;

                    OnPropertyChanged("userRole");

                }

            }

        }

        /// <summary>
        /// Indicates whether the notebook is shared. If true, the contents of the notebook can be seen by people other than the owner.
        /// </summary>
        public System.Nullable<System.Boolean> isShared

        {

            get

            {

                return _isShared;

            }

            set

            {

                if (value != _isShared)

                {

                    _isShared = value;

                    OnPropertyChanged("isShared");

                }

            }

        }

        /// <summary>
        /// The URL for the sections navigation property, which returns all the sections in the notebook.
        /// </summary>
        public System.String sectionsUrl

        {

            get

            {

                return _sectionsUrl;

            }

            set

            {

                if (value != _sectionsUrl)

                {

                    _sectionsUrl = value;

                    OnPropertyChanged("sectionsUrl");

                }

            }

        }

        /// <summary>
        /// The URL for the sectionGroups navigation property, which returns all the section groups in the notebook.
        /// </summary>
        public System.String sectionGroupsUrl

        {

            get

            {

                return _sectionGroupsUrl;

            }

            set

            {

                if (value != _sectionGroupsUrl)

                {

                    _sectionGroupsUrl = value;

                    OnPropertyChanged("sectionGroupsUrl");

                }

            }

        }

        /// <summary>
        /// The value of oneNoteClientURL can be used to open the notebook using the OneNote native client app if it's installed. The value of oneNoteWebURL can be used to open the web-browser based OneNote Online client.
        /// </summary>
        public global::Microsoft.Graph.notebookLinks links

        {

            get

            {

                return _links;

            }

            set

            {

                if (value != _links)

                {

                    _links = value;

                    OnPropertyChanged("links");

                }

            }

        }

        /// <summary>
        /// The name of the notebook.
        /// </summary>
        public System.String name

        {

            get

            {

                return _name;

            }

            set

            {

                if (value != _name)

                {

                    _name = value;

                    OnPropertyChanged("name");

                }

            }

        }

        /// <summary>
        /// The user who created the notebook.
        /// </summary>
        public System.String createdBy

        {

            get

            {

                return _createdBy;

            }

            set

            {

                if (value != _createdBy)

                {

                    _createdBy = value;

                    OnPropertyChanged("createdBy");

                }

            }

        }

        /// <summary>
        /// The user who created the notebook.
        /// </summary>
        public global::Microsoft.Graph.oneNoteIdentitySet createdByIdentity

        {

            get

            {

                return _createdByIdentity;

            }

            set

            {

                if (value != _createdByIdentity)

                {

                    _createdByIdentity = value;

                    OnPropertyChanged("createdByIdentity");

                }

            }

        }

        /// <summary>
        /// The user who last modified the notebook.
        /// </summary>
        public System.String lastModifiedBy

        {

            get

            {

                return _lastModifiedBy;

            }

            set

            {

                if (value != _lastModifiedBy)

                {

                    _lastModifiedBy = value;

                    OnPropertyChanged("lastModifiedBy");

                }

            }

        }

        /// <summary>
        /// The user who last modified the notebook.
        /// </summary>
        public global::Microsoft.Graph.oneNoteIdentitySet lastModifiedByIdentity

        {

            get

            {

                return _lastModifiedByIdentity;

            }

            set

            {

                if (value != _lastModifiedByIdentity)

                {

                    _lastModifiedByIdentity = value;

                    OnPropertyChanged("lastModifiedByIdentity");

                }

            }

        }

        /// <summary>
        /// The date and time when the notebook was last modified.
        /// </summary>
        public System.Nullable<System.DateTimeOffset> lastModifiedTime

        {

            get

            {

                return _lastModifiedTime;

            }

            set

            {

                if (value != _lastModifiedTime)

                {

                    _lastModifiedTime = value;

                    OnPropertyChanged("lastModifiedTime");

                }

            }

        }

        /// <summary>
        /// The unique identifier of the notebook.
        /// </summary>
        public System.String id

        {

            get

            {

                return _id;

            }

            set

            {

                if (value != _id)

                {

                    _id = value;

                    OnPropertyChanged("id");

                }

            }

        }

        /// <summary>
        /// The endpoint where you can get details about the notebook.
        /// </summary>
        public System.String self

        {

            get

            {

                return _self;

            }

            set

            {

                if (value != _self)

                {

                    _self = value;

                    OnPropertyChanged("self");

                }

            }

        }

        /// <summary>
        /// The date and time when the notebook was created.
        /// </summary>
        public System.Nullable<System.DateTimeOffset> createdTime

        {

            get

            {

                return _createdTime;

            }

            set

            {

                if (value != _createdTime)

                {

                    _createdTime = value;

                    OnPropertyChanged("createdTime");

                }

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.Isection> global::Microsoft.Graph.Inotebook.sections

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.Isection, global::Microsoft.Graph.section>(Context, (DataServiceCollection<global::Microsoft.Graph.section>) sections);

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.IsectionGroup> global::Microsoft.Graph.Inotebook.sectionGroups

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::Microsoft.Graph.IsectionGroup, global::Microsoft.Graph.sectionGroup>(Context, (DataServiceCollection<global::Microsoft.Graph.sectionGroup>) sectionGroups);

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.section> sections

        {

            get

            {

                if (this._sectionsConcrete == null)

                {

                    this._sectionsConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.section>();

                    this._sectionsConcrete.SetContainer(() => GetContainingEntity("sections"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.section>)this._sectionsConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                sections.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        sections.Add(i);

                    }

                }

            }

        }

        public global::System.Collections.Generic.IList<global::Microsoft.Graph.sectionGroup> sectionGroups

        {

            get

            {

                if (this._sectionGroupsConcrete == null)

                {

                    this._sectionGroupsConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.sectionGroup>();

                    this._sectionGroupsConcrete.SetContainer(() => GetContainingEntity("sectionGroups"));

                }

                

                return (global::System.Collections.Generic.IList<global::Microsoft.Graph.sectionGroup>)this._sectionGroupsConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                sectionGroups.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        sectionGroups.Add(i);

                    }

                }

            }

        }

        global::Microsoft.Graph.IsectionCollection global::Microsoft.Graph.InotebookFetcher.sections

        {

            get

            {

                if (this._sectionsCollection == null)

                {

                    this._sectionsCollection = new global::Microsoft.Graph.sectionCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.section>(GetPath("sections")) : null,
                       Context,
                       this,
                       GetPath("sections"));

                }

                

                return this._sectionsCollection;

            }

        }

        global::Microsoft.Graph.IsectionGroupCollection global::Microsoft.Graph.InotebookFetcher.sectionGroups

        {

            get

            {

                if (this._sectionGroupsCollection == null)

                {

                    this._sectionGroupsCollection = new global::Microsoft.Graph.sectionGroupCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.sectionGroup>(GetPath("sectionGroups")) : null,
                       Context,
                       this,
                       GetPath("sectionGroups"));

                }

                

                return this._sectionGroupsCollection;

            }

        }

        public notebook(): base()

        {

        }

        public async System.Threading.Tasks.Task<global::Microsoft.Graph.copyStatusModel> CopyNotebookAsync(System.String groupId, System.String renameAs, System.String notebookFolder)

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.CopyNotebook");

            return (global::Microsoft.Graph.copyStatusModel) Enumerable.Single<global::Microsoft.Graph.copyStatusModel>(await this.Context.ExecuteAsync<global::Microsoft.Graph.copyStatusModel>(requestUri, "POST", true, new OperationParameter[]

            {

                new BodyOperationParameter("groupId", (object) groupId),

                new BodyOperationParameter("renameAs", (object) renameAs),

                new BodyOperationParameter("notebookFolder", (object) notebookFolder),

            }

            ));

        }

        public async System.Threading.Tasks.Task ExportNotebookAsync()

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.ExportNotebook");

            await this.Context.ExecuteAsync(requestUri, "POST", new OperationParameter[0]

            {

            }

            );

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Inotebook> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.notebook, global::Microsoft.Graph.Inotebook>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Inotebook> _query;

        global::System.Threading.Tasks.Task<global::Microsoft.Graph.Inotebook> global::Microsoft.Graph.InotebookFetcher.ExecuteAsync()

        {

            var tsc = new global::System.Threading.Tasks.TaskCompletionSource<global::Microsoft.Graph.Inotebook>();

            tsc.SetResult(this);

            return tsc.Task;

        }

        global::Microsoft.Graph.InotebookFetcher global::Microsoft.Graph.InotebookFetcher.Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.Inotebook, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.InotebookFetcher) this;

        }

    }

    internal partial class notebookFetcher:Microsoft.OData.ProxyExtensions.RestShallowObjectFetcher, global::Microsoft.Graph.InotebookFetcher

    {

        private global::Microsoft.Graph.sectionCollection _sectionsCollection;

        private global::Microsoft.Graph.sectionGroupCollection _sectionGroupsCollection;

        public global::Microsoft.Graph.IsectionCollection sections

        {

            get

            {

                if (this._sectionsCollection == null)

                {

                    this._sectionsCollection = new global::Microsoft.Graph.sectionCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.section>(GetPath("sections")) : null,
                       Context,
                       this,
                       GetPath("sections"));

                }

                

                return this._sectionsCollection;

            }

        }

        public global::Microsoft.Graph.IsectionGroupCollection sectionGroups

        {

            get

            {

                if (this._sectionGroupsCollection == null)

                {

                    this._sectionGroupsCollection = new global::Microsoft.Graph.sectionGroupCollection(
                       Context != null ? Context.CreateQuery<global::Microsoft.Graph.sectionGroup>(GetPath("sectionGroups")) : null,
                       Context,
                       this,
                       GetPath("sectionGroups"));

                }

                

                return this._sectionGroupsCollection;

            }

        }

        public notebookFetcher(): base()

        {

        }

        public async System.Threading.Tasks.Task<global::Microsoft.Graph.copyStatusModel> CopyNotebookAsync(System.String groupId, System.String renameAs, System.String notebookFolder)

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.CopyNotebook");

            return (global::Microsoft.Graph.copyStatusModel) Enumerable.Single<global::Microsoft.Graph.copyStatusModel>(await this.Context.ExecuteAsync<global::Microsoft.Graph.copyStatusModel>(requestUri, "POST", true, new OperationParameter[]

            {

                new BodyOperationParameter("groupId", (object) groupId),

                new BodyOperationParameter("renameAs", (object) renameAs),

                new BodyOperationParameter("notebookFolder", (object) notebookFolder),

            }

            ));

        }

        public async System.Threading.Tasks.Task ExportNotebookAsync()

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.ExportNotebook");

            await this.Context.ExecuteAsync(requestUri, "POST", new OperationParameter[0]

            {

            }

            );

        }

        public async global::System.Threading.Tasks.Task<global::Microsoft.Graph.Inotebook> ExecuteAsync()

        {

            return await EnsureQuery().ExecuteSingleAsync();

        }

        public global::Microsoft.Graph.InotebookFetcher Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::Microsoft.Graph.Inotebook, TTarget>> navigationPropertyAccessor)

        {

            return (global::Microsoft.Graph.InotebookFetcher) new global::Microsoft.Graph.notebookFetcher()

            {

                _query = this.EnsureQuery().Expand<TTarget>(navigationPropertyAccessor)

            }

            ;

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Inotebook> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::Microsoft.Graph.notebook, global::Microsoft.Graph.Inotebook>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::Microsoft.Graph.Inotebook> _query;

    }

    internal partial class notebookCollection:Microsoft.OData.ProxyExtensions.QueryableSet<global::Microsoft.Graph.Inotebook>, global::Microsoft.Graph.InotebookCollection

    {

        internal notebookCollection(global::Microsoft.OData.Client.DataServiceQuery inner,Microsoft.OData.ProxyExtensions.DataServiceContextWrapper context,object entity,string path): base(inner, context, entity as Microsoft.OData.ProxyExtensions.EntityBase, path)

        {

        }

        public async System.Threading.Tasks.Task<global::Microsoft.Graph.importStatusModel> ImportNotebookAsync()

        {

            if (this.Context == null)

                throw new InvalidOperationException("Not Initialized");

            Uri myUri = this.GetUrl();

            if (myUri == (Uri) null)

             throw new Exception("cannot find entity");

            Uri requestUri = new Uri(myUri.ToString().TrimEnd('/') + "/Microsoft.Graph.ImportNotebook");

            return (global::Microsoft.Graph.importStatusModel) Enumerable.Single<global::Microsoft.Graph.importStatusModel>(await this.Context.ExecuteAsync<global::Microsoft.Graph.importStatusModel>(requestUri, "POST", true, new OperationParameter[]

            {

            }

            ));

        }

        public global::Microsoft.Graph.InotebookFetcher GetById(System.String id)

        {

            return this[id];

        }

        public global::System.Threading.Tasks.Task<Microsoft.OData.ProxyExtensions.IPagedCollection<global::Microsoft.Graph.Inotebook>> ExecuteAsync()

        {

            return ExecuteAsyncInternal();

        }

        public global::System.Threading.Tasks.Task AddnotebookAsync(global::Microsoft.Graph.Inotebook item, System.Boolean deferSaveChanges = false)

        {

            if (Entity == null)

            {

                Context.AddObject(Path, item);

            }

            else

            {

                var lastSlash = Path.LastIndexOf('/');

                var shortPath = (lastSlash >= 0 && lastSlash < Path.Length - 1) ? Path.Substring(lastSlash + 1) : Path;

                Context.AddRelatedObject(Entity, shortPath, item);

            }

            if (!deferSaveChanges)

            {

                return Context.SaveChangesAsync();

            }

            else

            {

                var retVal = new global::System.Threading.Tasks.TaskCompletionSource<object>();

                retVal.SetResult(null);

                return retVal.Task;

            }

        }

        public global::Microsoft.Graph.InotebookFetcher this[System.String id]

        {

            get

            {

                var path = GetPath<global::Microsoft.Graph.notebook>((i) => i.id == id);

                var fetcher = new global::Microsoft.Graph.notebookFetcher();

                fetcher.Initialize(Context, path);

                

                return fetcher;

            }

        }

    }

    internal partial class notebookCollection

    {

        public global::System.Threading.Tasks.Task<System.Int64> CountAsync()

        {

            return new DataServiceQuerySingle<long>(Context, Path + "/$count").GetValueAsync();

        }

    }

    internal partial class notebookFetcher

    {

    }

    public partial class notebook

    {

    }

    /// <summary>
    /// A section in a OneNote notebook
    /// </summary>
    [global::Microsoft.OData.Client.Key("id")]

    public partial class section:Microsoft.OData.ProxyExtensions.EntityBase, global::Microsoft.Graph.Isection, global::Microsoft.Graph.IsectionFetcher

    {

        private global::Microsoft.Graph.notebook _parentNotebook;

        private global::Microsoft.Graph.sectionGroup _parentSectionGroup;

        private global::Microsoft.Graph.notebookFetcher _parentNotebookFetcher;

        private global::Microsoft.Graph.sectionGroupFetcher _parentSectionGroupFetcher;

        private global::Microsoft.Graph.pageCollection _pagesCollection;

        private System.Nullable<System.Boolean> _isDefault;

        private System.String _pagesUrl;

        private System.String _name;

        private System.String _createdBy;

        private global::Microsoft.Graph.oneNoteIdentitySet _createdByIdentity;

        private System.String _lastModifiedBy;

        private global::Microsoft.Graph.oneNoteIdentitySet _lastModifiedByIdentity;

        private System.Nullable<System.DateTimeOffset> _lastModifiedTime;

        private System.String _id;

        private System.String _self;

        private System.Nullable<System.DateTimeOffset> _createdTime;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::Microsoft.Graph.page> _pagesConcrete;

        /// <summary>
        /// Indicates whether this is the user's default section.
        /// </summary>
        public System.Nullable<System.Boolean> isDefault

        {

            get

            {

                return _isDefault;

            }

            set

            {

                if (value != _isDefault)

                {

                    _isDefault = value;

                    OnPropertyChanged("isDefault");

                }

            }

        }

        /// <summary>
        /// The /pages endpoint where you can get details for all the pages in the section."
        /// </summary>
        public System.String pagesUrl

        {

            get

            {

                return _pagesUrl;

            }

            set

            {

                if (value != _pagesUrl)

                {

                    _pagesUrl = value;

                    OnPropertyChanged("pagesUrl");

                }

            }

        }

        /// <summary>
        /// The name of the section.
        /// </summary>
        public System.String name

        {

            get

            {

                return _name;

            }

            set

            {

                if (value != _name)

                {

                    _name = value;

                    OnPropertyChanged("name");

                }

            }

        }

        /// <summary>
        /// The user who created the section.
        /// </summary>
        public System.String createdBy

        {

            get

            {

                return _createdBy;

            }

            set

            {

                if (value != _createdBy)

                {

                    _createdBy = value;

                    OnPropertyChanged("createdBy");

                }

            }

        }

        /// <summary>
        /// The user who created the section.
        /// </summary>
        public global::Microsoft.Graph.oneNoteIdentitySet createdByIdentity

        {

            get

            {

                return _createdByIdentity;

            }

            set

            {

                if (value != _createdByIdentity)

                {

                    _createdByIdentity = value;

                    OnPropertyChanged("createdByIdentity");

                }

            }

        }

        /// <summary>
        /// The user who last modified the section.
        /// </summary>
        public System.String lastModifiedBy

        {

            get

            {

                return _lastModifiedBy;

            }

            set

            {

                if (value != _lastModifiedBy)

                {

                    _lastModifiedBy = value;

                    OnPropertyChanged("lastModifiedBy");

                }

            }

        }

        /// <summary>
        /// The user who last modified the section.
        /// </summary>
        public global::Microsoft.Graph.oneNoteIdentitySet lastModifiedByIdentity

        {

            get

            {


            }

            set
