// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/errors/user_list_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V0.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v0/errors/user_list_error.proto</summary>
  public static partial class UserListErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v0/errors/user_list_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UserListErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjRnb29nbGUvYWRzL2dvb2dsZWFkcy92MC9lcnJvcnMvdXNlcl9saXN0X2Vy",
            "cm9yLnByb3RvEh5nb29nbGUuYWRzLmdvb2dsZWFkcy52MC5lcnJvcnMi1AYK",
            "EVVzZXJMaXN0RXJyb3JFbnVtIr4GCg1Vc2VyTGlzdEVycm9yEg8KC1VOU1BF",
            "Q0lGSUVEEAASCwoHVU5LTk9XThABEjcKM0VYVEVSTkFMX1JFTUFSS0VUSU5H",
            "X1VTRVJfTElTVF9NVVRBVEVfTk9UX1NVUFBPUlRFRBACEhoKFkNPTkNSRVRF",
            "X1RZUEVfUkVRVUlSRUQQAxIfChtDT05WRVJTSU9OX1RZUEVfSURfUkVRVUlS",
            "RUQQBBIeChpEVVBMSUNBVEVfQ09OVkVSU0lPTl9UWVBFUxAFEhsKF0lOVkFM",
            "SURfQ09OVkVSU0lPTl9UWVBFEAYSFwoTSU5WQUxJRF9ERVNDUklQVElPThAH",
            "EhAKDElOVkFMSURfTkFNRRAIEhAKDElOVkFMSURfVFlQRRAJEjQKMENBTl9O",
            "T1RfQUREX0xPR0lDQUxfTElTVF9BU19MT0dJQ0FMX0xJU1RfT1BFUkFORBAK",
            "EioKJklOVkFMSURfVVNFUl9MSVNUX0xPR0lDQUxfUlVMRV9PUEVSQU5EEAsS",
            "FQoRTkFNRV9BTFJFQURZX1VTRUQQDBIlCiFORVdfQ09OVkVSU0lPTl9UWVBF",
            "X05BTUVfUkVRVUlSRUQQDRIlCiFDT05WRVJTSU9OX1RZUEVfTkFNRV9BTFJF",
            "QURZX1VTRUQQDhIeChpPV05FUlNISVBfUkVRVUlSRURfRk9SX1NFVBAPEiIK",
            "HlVTRVJfTElTVF9NVVRBVEVfTk9UX1NVUFBPUlRFRBAQEhAKDElOVkFMSURf",
            "UlVMRRAREhYKEklOVkFMSURfREFURV9SQU5HRRAbEiUKIUNBTl9OT1RfTVVU",
            "QVRFX1NFTlNJVElWRV9VU0VSTElTVBAcEh8KG01BWF9OVU1fUlVMRUJBU0VE",
            "X1VTRVJMSVNUUxAdEicKI0NBTk5PVF9NT0RJRllfQklMTEFCTEVfUkVDT1JE",
            "X0NPVU5UEB4SEgoOQVBQX0lEX05PVF9TRVQQHxItCilVU0VSTElTVF9OQU1F",
            "X0lTX1JFU0VSVkVEX0ZPUl9TWVNURU1fTElTVBAgEjYKMkFEVkVSVElTRVJf",
            "Tk9UX1dISVRFTElTVEVEX0ZPUl9VU0lOR19VUExPQURFRF9EQVRBECFCyAEK",
            "ImNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52MC5lcnJvcnNCElVzZXJMaXN0",
            "RXJyb3JQcm90b1ABWkRnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29n",
            "bGVhcGlzL2Fkcy9nb29nbGVhZHMvdjAvZXJyb3JzO2Vycm9yc6ICA0dBQaoC",
            "Hkdvb2dsZS5BZHMuR29vZ2xlQWRzLlYwLkVycm9yc8oCHkdvb2dsZVxBZHNc",
            "R29vZ2xlQWRzXFYwXEVycm9yc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Errors.UserListErrorEnum), global::Google.Ads.GoogleAds.V0.Errors.UserListErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V0.Errors.UserListErrorEnum.Types.UserListError) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible user list errors.
  /// </summary>
  public sealed partial class UserListErrorEnum : pb::IMessage<UserListErrorEnum> {
    private static readonly pb::MessageParser<UserListErrorEnum> _parser = new pb::MessageParser<UserListErrorEnum>(() => new UserListErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UserListErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Errors.UserListErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserListErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserListErrorEnum(UserListErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserListErrorEnum Clone() {
      return new UserListErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UserListErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UserListErrorEnum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(UserListErrorEnum other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the UserListErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible user list errors.
      /// </summary>
      public enum UserListError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Creating and updating external remarketing user lists is not supported.
        /// </summary>
        [pbr::OriginalName("EXTERNAL_REMARKETING_USER_LIST_MUTATE_NOT_SUPPORTED")] ExternalRemarketingUserListMutateNotSupported = 2,
        /// <summary>
        /// Concrete type of user list is required.
        /// </summary>
        [pbr::OriginalName("CONCRETE_TYPE_REQUIRED")] ConcreteTypeRequired = 3,
        /// <summary>
        /// Creating/updating user list conversion types requires specifying the
        /// conversion type Id.
        /// </summary>
        [pbr::OriginalName("CONVERSION_TYPE_ID_REQUIRED")] ConversionTypeIdRequired = 4,
        /// <summary>
        /// Remarketing user list cannot have duplicate conversion types.
        /// </summary>
        [pbr::OriginalName("DUPLICATE_CONVERSION_TYPES")] DuplicateConversionTypes = 5,
        /// <summary>
        /// Conversion type is invalid/unknown.
        /// </summary>
        [pbr::OriginalName("INVALID_CONVERSION_TYPE")] InvalidConversionType = 6,
        /// <summary>
        /// User list description is empty or invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_DESCRIPTION")] InvalidDescription = 7,
        /// <summary>
        /// User list name is empty or invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_NAME")] InvalidName = 8,
        /// <summary>
        /// Type of the UserList does not match.
        /// </summary>
        [pbr::OriginalName("INVALID_TYPE")] InvalidType = 9,
        /// <summary>
        /// Embedded logical user lists are not allowed.
        /// </summary>
        [pbr::OriginalName("CAN_NOT_ADD_LOGICAL_LIST_AS_LOGICAL_LIST_OPERAND")] CanNotAddLogicalListAsLogicalListOperand = 10,
        /// <summary>
        /// User list rule operand is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_USER_LIST_LOGICAL_RULE_OPERAND")] InvalidUserListLogicalRuleOperand = 11,
        /// <summary>
        /// Name is already being used for another user list for the account.
        /// </summary>
        [pbr::OriginalName("NAME_ALREADY_USED")] NameAlreadyUsed = 12,
        /// <summary>
        /// Name is required when creating a new conversion type.
        /// </summary>
        [pbr::OriginalName("NEW_CONVERSION_TYPE_NAME_REQUIRED")] NewConversionTypeNameRequired = 13,
        /// <summary>
        /// The given conversion type name has been used.
        /// </summary>
        [pbr::OriginalName("CONVERSION_TYPE_NAME_ALREADY_USED")] ConversionTypeNameAlreadyUsed = 14,
        /// <summary>
        /// Only an owner account may edit a user list.
        /// </summary>
        [pbr::OriginalName("OWNERSHIP_REQUIRED_FOR_SET")] OwnershipRequiredForSet = 15,
        /// <summary>
        /// The user list of the type is not mutable.
        /// </summary>
        [pbr::OriginalName("USER_LIST_MUTATE_NOT_SUPPORTED")] UserListMutateNotSupported = 16,
        /// <summary>
        /// Rule is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_RULE")] InvalidRule = 17,
        /// <summary>
        /// The specified date range is empty.
        /// </summary>
        [pbr::OriginalName("INVALID_DATE_RANGE")] InvalidDateRange = 27,
        /// <summary>
        /// A UserList which is privacy sensitive or legal rejected cannot be mutated
        /// by external users.
        /// </summary>
        [pbr::OriginalName("CAN_NOT_MUTATE_SENSITIVE_USERLIST")] CanNotMutateSensitiveUserlist = 28,
        /// <summary>
        /// Maximum number of rulebased user lists a customer can have.
        /// </summary>
        [pbr::OriginalName("MAX_NUM_RULEBASED_USERLISTS")] MaxNumRulebasedUserlists = 29,
        /// <summary>
        /// BasicUserList's billable record field cannot be modified once it is set.
        /// </summary>
        [pbr::OriginalName("CANNOT_MODIFY_BILLABLE_RECORD_COUNT")] CannotModifyBillableRecordCount = 30,
        /// <summary>
        /// crm_based_user_list.app_id field must be set when upload_key_type is
        /// MOBILE_ADVERTISING_ID.
        /// </summary>
        [pbr::OriginalName("APP_ID_NOT_SET")] AppIdNotSet = 31,
        /// <summary>
        /// Name of the user list is reserved for system generated lists and cannot
        /// be used.
        /// </summary>
        [pbr::OriginalName("USERLIST_NAME_IS_RESERVED_FOR_SYSTEM_LIST")] UserlistNameIsReservedForSystemList = 32,
        /// <summary>
        /// Advertiser needs to be whitelisted to use remarketing lists created from
        /// advertiser uploaded data (e.g., Customer Match lists).
        /// </summary>
        [pbr::OriginalName("ADVERTISER_NOT_WHITELISTED_FOR_USING_UPLOADED_DATA")] AdvertiserNotWhitelistedForUsingUploadedData = 33,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
