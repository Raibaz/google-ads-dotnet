// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v9/errors/ad_group_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V9.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v9/errors/ad_group_error.proto</summary>
  public static partial class AdGroupErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v9/errors/ad_group_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AdGroupErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjNnb29nbGUvYWRzL2dvb2dsZWFkcy92OS9lcnJvcnMvYWRfZ3JvdXBfZXJy",
            "b3IucHJvdG8SHmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY5LmVycm9ycyKHBQoQ",
            "QWRHcm91cEVycm9yRW51bSLyBAoMQWRHcm91cEVycm9yEg8KC1VOU1BFQ0lG",
            "SUVEEAASCwoHVU5LTk9XThABEhoKFkRVUExJQ0FURV9BREdST1VQX05BTUUQ",
            "AhIYChRJTlZBTElEX0FER1JPVVBfTkFNRRADEiUKIUFEVkVSVElTRVJfTk9U",
            "X09OX0NPTlRFTlRfTkVUV09SSxAFEg8KC0JJRF9UT09fQklHEAYSKgomQklE",
            "X1RZUEVfQU5EX0JJRERJTkdfU1RSQVRFR1lfTUlTTUFUQ0gQBxIYChRNSVNT",
            "SU5HX0FER1JPVVBfTkFNRRAIEiAKHEFER1JPVVBfTEFCRUxfRE9FU19OT1Rf",
            "RVhJU1QQCRIgChxBREdST1VQX0xBQkVMX0FMUkVBRFlfRVhJU1RTEAoSLAoo",
            "SU5WQUxJRF9DT05URU5UX0JJRF9DUklURVJJT05fVFlQRV9HUk9VUBALEjgK",
            "NEFEX0dST1VQX1RZUEVfTk9UX1ZBTElEX0ZPUl9BRFZFUlRJU0lOR19DSEFO",
            "TkVMX1RZUEUQDBI5CjVBREdST1VQX1RZUEVfTk9UX1NVUFBPUlRFRF9GT1Jf",
            "Q0FNUEFJR05fU0FMRVNfQ09VTlRSWRANEkIKPkNBTk5PVF9BRERfQURHUk9V",
            "UF9PRl9UWVBFX0RTQV9UT19DQU1QQUlHTl9XSVRIT1VUX0RTQV9TRVRUSU5H",
            "EA4SNwozUFJPTU9URURfSE9URUxfQURfR1JPVVBTX05PVF9BVkFJTEFCTEVf",
            "Rk9SX0NVU1RPTUVSEA8SLAooSU5WQUxJRF9FWENMVURFRF9QQVJFTlRfQVNT",
            "RVRfRklFTERfVFlQRRAQQuwBCiJjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMu",
            "djkuZXJyb3JzQhFBZEdyb3VwRXJyb3JQcm90b1ABWkRnb29nbGUuZ29sYW5n",
            "Lm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjkvZXJy",
            "b3JzO2Vycm9yc6ICA0dBQaoCHkdvb2dsZS5BZHMuR29vZ2xlQWRzLlY5LkVy",
            "cm9yc8oCHkdvb2dsZVxBZHNcR29vZ2xlQWRzXFY5XEVycm9yc+oCIkdvb2ds",
            "ZTo6QWRzOjpHb29nbGVBZHM6OlY5OjpFcnJvcnNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V9.Errors.AdGroupErrorEnum), global::Google.Ads.GoogleAds.V9.Errors.AdGroupErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V9.Errors.AdGroupErrorEnum.Types.AdGroupError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible ad group errors.
  /// </summary>
  public sealed partial class AdGroupErrorEnum : pb::IMessage<AdGroupErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AdGroupErrorEnum> _parser = new pb::MessageParser<AdGroupErrorEnum>(() => new AdGroupErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AdGroupErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V9.Errors.AdGroupErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdGroupErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdGroupErrorEnum(AdGroupErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdGroupErrorEnum Clone() {
      return new AdGroupErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AdGroupErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AdGroupErrorEnum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AdGroupErrorEnum other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the AdGroupErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible ad group errors.
      /// </summary>
      public enum AdGroupError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// AdGroup with the same name already exists for the campaign.
        /// </summary>
        [pbr::OriginalName("DUPLICATE_ADGROUP_NAME")] DuplicateAdgroupName = 2,
        /// <summary>
        /// AdGroup name is not valid.
        /// </summary>
        [pbr::OriginalName("INVALID_ADGROUP_NAME")] InvalidAdgroupName = 3,
        /// <summary>
        /// Advertiser is not allowed to target sites or set site bids that are not
        /// on the Google Search Network.
        /// </summary>
        [pbr::OriginalName("ADVERTISER_NOT_ON_CONTENT_NETWORK")] AdvertiserNotOnContentNetwork = 5,
        /// <summary>
        /// Bid amount is too big.
        /// </summary>
        [pbr::OriginalName("BID_TOO_BIG")] BidTooBig = 6,
        /// <summary>
        /// AdGroup bid does not match the campaign's bidding strategy.
        /// </summary>
        [pbr::OriginalName("BID_TYPE_AND_BIDDING_STRATEGY_MISMATCH")] BidTypeAndBiddingStrategyMismatch = 7,
        /// <summary>
        /// AdGroup name is required for Add.
        /// </summary>
        [pbr::OriginalName("MISSING_ADGROUP_NAME")] MissingAdgroupName = 8,
        /// <summary>
        /// No link found between the ad group and the label.
        /// </summary>
        [pbr::OriginalName("ADGROUP_LABEL_DOES_NOT_EXIST")] AdgroupLabelDoesNotExist = 9,
        /// <summary>
        /// The label has already been attached to the ad group.
        /// </summary>
        [pbr::OriginalName("ADGROUP_LABEL_ALREADY_EXISTS")] AdgroupLabelAlreadyExists = 10,
        /// <summary>
        /// The CriterionTypeGroup is not supported for the content bid dimension.
        /// </summary>
        [pbr::OriginalName("INVALID_CONTENT_BID_CRITERION_TYPE_GROUP")] InvalidContentBidCriterionTypeGroup = 11,
        /// <summary>
        /// The ad group type is not compatible with the campaign channel type.
        /// </summary>
        [pbr::OriginalName("AD_GROUP_TYPE_NOT_VALID_FOR_ADVERTISING_CHANNEL_TYPE")] AdGroupTypeNotValidForAdvertisingChannelType = 12,
        /// <summary>
        /// The ad group type is not supported in the country of sale of the
        /// campaign.
        /// </summary>
        [pbr::OriginalName("ADGROUP_TYPE_NOT_SUPPORTED_FOR_CAMPAIGN_SALES_COUNTRY")] AdgroupTypeNotSupportedForCampaignSalesCountry = 13,
        /// <summary>
        /// Ad groups of AdGroupType.SEARCH_DYNAMIC_ADS can only be added to
        /// campaigns that have DynamicSearchAdsSetting attached.
        /// </summary>
        [pbr::OriginalName("CANNOT_ADD_ADGROUP_OF_TYPE_DSA_TO_CAMPAIGN_WITHOUT_DSA_SETTING")] CannotAddAdgroupOfTypeDsaToCampaignWithoutDsaSetting = 14,
        /// <summary>
        /// Promoted hotels ad groups are only available to customers on the
        /// allow-list.
        /// </summary>
        [pbr::OriginalName("PROMOTED_HOTEL_AD_GROUPS_NOT_AVAILABLE_FOR_CUSTOMER")] PromotedHotelAdGroupsNotAvailableForCustomer = 15,
        /// <summary>
        /// The field type cannot be excluded because an active ad group-asset link
        /// of this type exists.
        /// </summary>
        [pbr::OriginalName("INVALID_EXCLUDED_PARENT_ASSET_FIELD_TYPE")] InvalidExcludedParentAssetFieldType = 16,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code