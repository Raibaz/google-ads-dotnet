// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v9/errors/campaign_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V9.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v9/errors/campaign_error.proto</summary>
  public static partial class CampaignErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v9/errors/campaign_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CampaignErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjNnb29nbGUvYWRzL2dvb2dsZWFkcy92OS9lcnJvcnMvY2FtcGFpZ25fZXJy",
            "b3IucHJvdG8SHmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY5LmVycm9ycyLPDwoR",
            "Q2FtcGFpZ25FcnJvckVudW0iuQ8KDUNhbXBhaWduRXJyb3ISDwoLVU5TUEVD",
            "SUZJRUQQABILCgdVTktOT1dOEAESIQodQ0FOTk9UX1RBUkdFVF9DT05URU5U",
            "X05FVFdPUksQAxIgChxDQU5OT1RfVEFSR0VUX1NFQVJDSF9ORVRXT1JLEAQS",
            "NgoyQ0FOTk9UX1RBUkdFVF9TRUFSQ0hfTkVUV09SS19XSVRIT1VUX0dPT0dM",
            "RV9TRUFSQ0gQBRIwCixDQU5OT1RfVEFSR0VUX0dPT0dMRV9TRUFSQ0hfRk9S",
            "X0NQTV9DQU1QQUlHThAGEi0KKUNBTVBBSUdOX01VU1RfVEFSR0VUX0FUX0xF",
            "QVNUX09ORV9ORVRXT1JLEAcSKAokQ0FOTk9UX1RBUkdFVF9QQVJUTkVSX1NF",
            "QVJDSF9ORVRXT1JLEAgSSwpHQ0FOTk9UX1RBUkdFVF9DT05URU5UX05FVFdP",
            "UktfT05MWV9XSVRIX0NSSVRFUklBX0xFVkVMX0JJRERJTkdfU1RSQVRFR1kQ",
            "CRI2CjJDQU1QQUlHTl9EVVJBVElPTl9NVVNUX0NPTlRBSU5fQUxMX1JVTk5B",
            "QkxFX1RSSUFMUxAKEiQKIENBTk5PVF9NT0RJRllfRk9SX1RSSUFMX0NBTVBB",
            "SUdOEAsSGwoXRFVQTElDQVRFX0NBTVBBSUdOX05BTUUQDBIfChtJTkNPTVBB",
            "VElCTEVfQ0FNUEFJR05fRklFTEQQDRIZChVJTlZBTElEX0NBTVBBSUdOX05B",
            "TUUQDhIqCiZJTlZBTElEX0FEX1NFUlZJTkdfT1BUSU1JWkFUSU9OX1NUQVRV",
            "UxAPEhgKFElOVkFMSURfVFJBQ0tJTkdfVVJMEBASPgo6Q0FOTk9UX1NFVF9C",
            "T1RIX1RSQUNLSU5HX1VSTF9URU1QTEFURV9BTkRfVFJBQ0tJTkdfU0VUVElO",
            "RxAREiAKHE1BWF9JTVBSRVNTSU9OU19OT1RfSU5fUkFOR0UQEhIbChdUSU1F",
            "X1VOSVRfTk9UX1NVUFBPUlRFRBATEjEKLUlOVkFMSURfT1BFUkFUSU9OX0lG",
            "X1NFUlZJTkdfU1RBVFVTX0hBU19FTkRFRBAUEhsKF0JVREdFVF9DQU5OT1Rf",
            "QkVfU0hBUkVEEBUSJQohQ0FNUEFJR05fQ0FOTk9UX1VTRV9TSEFSRURfQlVE",
            "R0VUEBYSMAosQ0FOTk9UX0NIQU5HRV9CVURHRVRfT05fQ0FNUEFJR05fV0lU",
            "SF9UUklBTFMQFxIhCh1DQU1QQUlHTl9MQUJFTF9ET0VTX05PVF9FWElTVBAY",
            "EiEKHUNBTVBBSUdOX0xBQkVMX0FMUkVBRFlfRVhJU1RTEBkSHAoYTUlTU0lO",
            "R19TSE9QUElOR19TRVRUSU5HEBoSIgoeSU5WQUxJRF9TSE9QUElOR19TQUxF",
            "U19DT1VOVFJZEBsSOwo3QURWRVJUSVNJTkdfQ0hBTk5FTF9UWVBFX05PVF9B",
            "VkFJTEFCTEVfRk9SX0FDQ09VTlRfVFlQRRAfEigKJElOVkFMSURfQURWRVJU",
            "SVNJTkdfQ0hBTk5FTF9TVUJfVFlQRRAgEiwKKEFUX0xFQVNUX09ORV9DT05W",
            "RVJTSU9OX01VU1RfQkVfU0VMRUNURUQQIRIfChtDQU5OT1RfU0VUX0FEX1JP",
            "VEFUSU9OX01PREUQIhIvCitDQU5OT1RfTU9ESUZZX1NUQVJUX0RBVEVfSUZf",
            "QUxSRUFEWV9TVEFSVEVEECMSGwoXQ0FOTk9UX1NFVF9EQVRFX1RPX1BBU1QQ",
            "JBIfChtNSVNTSU5HX0hPVEVMX0NVU1RPTUVSX0xJTksQJRIfChtJTlZBTElE",
            "X0hPVEVMX0NVU1RPTUVSX0xJTksQJhIZChVNSVNTSU5HX0hPVEVMX1NFVFRJ",
            "TkcQJxJCCj5DQU5OT1RfVVNFX1NIQVJFRF9DQU1QQUlHTl9CVURHRVRfV0hJ",
            "TEVfUEFSVF9PRl9DQU1QQUlHTl9HUk9VUBAoEhEKDUFQUF9OT1RfRk9VTkQQ",
            "KRI5CjVTSE9QUElOR19FTkFCTEVfTE9DQUxfTk9UX1NVUFBPUlRFRF9GT1Jf",
            "Q0FNUEFJR05fVFlQRRAqEjMKL01FUkNIQU5UX05PVF9BTExPV0VEX0ZPUl9D",
            "T01QQVJJU09OX0xJU1RJTkdfQURTECsSIwofSU5TVUZGSUNJRU5UX0FQUF9J",
            "TlNUQUxMU19DT1VOVBAsEhoKFlNFTlNJVElWRV9DQVRFR09SWV9BUFAQLRIa",
            "ChZIRUNfQUdSRUVNRU5UX1JFUVVJUkVEEC4SPAo4Tk9UX0NPTVBBVElCTEVf",
            "V0lUSF9WSUVXX1RIUk9VR0hfQ09OVkVSU0lPTl9PUFRJTUlaQVRJT04QMRIs",
            "CihJTlZBTElEX0VYQ0xVREVEX1BBUkVOVF9BU1NFVF9GSUVMRF9UWVBFEDAS",
            "Ogo2Q0FOTk9UX0NSRUFURV9BUFBfUFJFX1JFR0lTVFJBVElPTl9GT1JfTk9O",
            "X0FORFJPSURfQVBQEDISPQo5QVBQX05PVF9BVkFJTEFCTEVfVE9fQ1JFQVRF",
            "X0FQUF9QUkVfUkVHSVNUUkFUSU9OX0NBTVBBSUdOEDMSHAoYSU5DT01QQVRJ",
            "QkxFX0JVREdFVF9UWVBFEDRC7QEKImNvbS5nb29nbGUuYWRzLmdvb2dsZWFk",
            "cy52OS5lcnJvcnNCEkNhbXBhaWduRXJyb3JQcm90b1ABWkRnb29nbGUuZ29s",
            "YW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjkv",
            "ZXJyb3JzO2Vycm9yc6ICA0dBQaoCHkdvb2dsZS5BZHMuR29vZ2xlQWRzLlY5",
            "LkVycm9yc8oCHkdvb2dsZVxBZHNcR29vZ2xlQWRzXFY5XEVycm9yc+oCIkdv",
            "b2dsZTo6QWRzOjpHb29nbGVBZHM6OlY5OjpFcnJvcnNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V9.Errors.CampaignErrorEnum), global::Google.Ads.GoogleAds.V9.Errors.CampaignErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V9.Errors.CampaignErrorEnum.Types.CampaignError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible campaign errors.
  /// </summary>
  public sealed partial class CampaignErrorEnum : pb::IMessage<CampaignErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CampaignErrorEnum> _parser = new pb::MessageParser<CampaignErrorEnum>(() => new CampaignErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CampaignErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V9.Errors.CampaignErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignErrorEnum(CampaignErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignErrorEnum Clone() {
      return new CampaignErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CampaignErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CampaignErrorEnum other) {
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
    public void MergeFrom(CampaignErrorEnum other) {
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
    /// <summary>Container for nested types declared in the CampaignErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible campaign errors.
      /// </summary>
      public enum CampaignError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Cannot target content network.
        /// </summary>
        [pbr::OriginalName("CANNOT_TARGET_CONTENT_NETWORK")] CannotTargetContentNetwork = 3,
        /// <summary>
        /// Cannot target search network.
        /// </summary>
        [pbr::OriginalName("CANNOT_TARGET_SEARCH_NETWORK")] CannotTargetSearchNetwork = 4,
        /// <summary>
        /// Cannot cover search network without google search network.
        /// </summary>
        [pbr::OriginalName("CANNOT_TARGET_SEARCH_NETWORK_WITHOUT_GOOGLE_SEARCH")] CannotTargetSearchNetworkWithoutGoogleSearch = 5,
        /// <summary>
        /// Cannot target Google Search network for a CPM campaign.
        /// </summary>
        [pbr::OriginalName("CANNOT_TARGET_GOOGLE_SEARCH_FOR_CPM_CAMPAIGN")] CannotTargetGoogleSearchForCpmCampaign = 6,
        /// <summary>
        /// Must target at least one network.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN_MUST_TARGET_AT_LEAST_ONE_NETWORK")] CampaignMustTargetAtLeastOneNetwork = 7,
        /// <summary>
        /// Only some Google partners are allowed to target partner search network.
        /// </summary>
        [pbr::OriginalName("CANNOT_TARGET_PARTNER_SEARCH_NETWORK")] CannotTargetPartnerSearchNetwork = 8,
        /// <summary>
        /// Cannot target content network only as campaign has criteria-level bidding
        /// strategy.
        /// </summary>
        [pbr::OriginalName("CANNOT_TARGET_CONTENT_NETWORK_ONLY_WITH_CRITERIA_LEVEL_BIDDING_STRATEGY")] CannotTargetContentNetworkOnlyWithCriteriaLevelBiddingStrategy = 9,
        /// <summary>
        /// Cannot modify the start or end date such that the campaign duration would
        /// not contain the durations of all runnable trials.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN_DURATION_MUST_CONTAIN_ALL_RUNNABLE_TRIALS")] CampaignDurationMustContainAllRunnableTrials = 10,
        /// <summary>
        /// Cannot modify dates, budget or status of a trial campaign.
        /// </summary>
        [pbr::OriginalName("CANNOT_MODIFY_FOR_TRIAL_CAMPAIGN")] CannotModifyForTrialCampaign = 11,
        /// <summary>
        /// Trying to modify the name of an active or paused campaign, where the name
        /// is already assigned to another active or paused campaign.
        /// </summary>
        [pbr::OriginalName("DUPLICATE_CAMPAIGN_NAME")] DuplicateCampaignName = 12,
        /// <summary>
        /// Two fields are in conflicting modes.
        /// </summary>
        [pbr::OriginalName("INCOMPATIBLE_CAMPAIGN_FIELD")] IncompatibleCampaignField = 13,
        /// <summary>
        /// Campaign name cannot be used.
        /// </summary>
        [pbr::OriginalName("INVALID_CAMPAIGN_NAME")] InvalidCampaignName = 14,
        /// <summary>
        /// Given status is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_AD_SERVING_OPTIMIZATION_STATUS")] InvalidAdServingOptimizationStatus = 15,
        /// <summary>
        /// Error in the campaign level tracking URL.
        /// </summary>
        [pbr::OriginalName("INVALID_TRACKING_URL")] InvalidTrackingUrl = 16,
        /// <summary>
        /// Cannot set both tracking URL template and tracking setting. A user has
        /// to clear legacy tracking setting in order to add tracking URL template.
        /// </summary>
        [pbr::OriginalName("CANNOT_SET_BOTH_TRACKING_URL_TEMPLATE_AND_TRACKING_SETTING")] CannotSetBothTrackingUrlTemplateAndTrackingSetting = 17,
        /// <summary>
        /// The maximum number of impressions for Frequency Cap should be an integer
        /// greater than 0.
        /// </summary>
        [pbr::OriginalName("MAX_IMPRESSIONS_NOT_IN_RANGE")] MaxImpressionsNotInRange = 18,
        /// <summary>
        /// Only the Day, Week and Month time units are supported.
        /// </summary>
        [pbr::OriginalName("TIME_UNIT_NOT_SUPPORTED")] TimeUnitNotSupported = 19,
        /// <summary>
        /// Operation not allowed on a campaign whose serving status has ended
        /// </summary>
        [pbr::OriginalName("INVALID_OPERATION_IF_SERVING_STATUS_HAS_ENDED")] InvalidOperationIfServingStatusHasEnded = 20,
        /// <summary>
        /// This budget is exclusively linked to a Campaign that is using experiments
        /// so it cannot be shared.
        /// </summary>
        [pbr::OriginalName("BUDGET_CANNOT_BE_SHARED")] BudgetCannotBeShared = 21,
        /// <summary>
        /// Campaigns using experiments cannot use a shared budget.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN_CANNOT_USE_SHARED_BUDGET")] CampaignCannotUseSharedBudget = 22,
        /// <summary>
        /// A different budget cannot be assigned to a campaign when there are
        /// running or scheduled trials.
        /// </summary>
        [pbr::OriginalName("CANNOT_CHANGE_BUDGET_ON_CAMPAIGN_WITH_TRIALS")] CannotChangeBudgetOnCampaignWithTrials = 23,
        /// <summary>
        /// No link found between the campaign and the label.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN_LABEL_DOES_NOT_EXIST")] CampaignLabelDoesNotExist = 24,
        /// <summary>
        /// The label has already been attached to the campaign.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN_LABEL_ALREADY_EXISTS")] CampaignLabelAlreadyExists = 25,
        /// <summary>
        /// A ShoppingSetting was not found when creating a shopping campaign.
        /// </summary>
        [pbr::OriginalName("MISSING_SHOPPING_SETTING")] MissingShoppingSetting = 26,
        /// <summary>
        /// The country in shopping setting is not an allowed country.
        /// </summary>
        [pbr::OriginalName("INVALID_SHOPPING_SALES_COUNTRY")] InvalidShoppingSalesCountry = 27,
        /// <summary>
        /// The requested channel type is not available according to the customer's
        /// account setting.
        /// </summary>
        [pbr::OriginalName("ADVERTISING_CHANNEL_TYPE_NOT_AVAILABLE_FOR_ACCOUNT_TYPE")] AdvertisingChannelTypeNotAvailableForAccountType = 31,
        /// <summary>
        /// The AdvertisingChannelSubType is not a valid subtype of the primary
        /// channel type.
        /// </summary>
        [pbr::OriginalName("INVALID_ADVERTISING_CHANNEL_SUB_TYPE")] InvalidAdvertisingChannelSubType = 32,
        /// <summary>
        /// At least one conversion must be selected.
        /// </summary>
        [pbr::OriginalName("AT_LEAST_ONE_CONVERSION_MUST_BE_SELECTED")] AtLeastOneConversionMustBeSelected = 33,
        /// <summary>
        /// Setting ad rotation mode for a campaign is not allowed. Ad rotation mode
        /// at campaign is deprecated.
        /// </summary>
        [pbr::OriginalName("CANNOT_SET_AD_ROTATION_MODE")] CannotSetAdRotationMode = 34,
        /// <summary>
        /// Trying to change start date on a campaign that has started.
        /// </summary>
        [pbr::OriginalName("CANNOT_MODIFY_START_DATE_IF_ALREADY_STARTED")] CannotModifyStartDateIfAlreadyStarted = 35,
        /// <summary>
        /// Trying to modify a date into the past.
        /// </summary>
        [pbr::OriginalName("CANNOT_SET_DATE_TO_PAST")] CannotSetDateToPast = 36,
        /// <summary>
        /// Hotel center id in the hotel setting does not match any customer links.
        /// </summary>
        [pbr::OriginalName("MISSING_HOTEL_CUSTOMER_LINK")] MissingHotelCustomerLink = 37,
        /// <summary>
        /// Hotel center id in the hotel setting must match an active customer link.
        /// </summary>
        [pbr::OriginalName("INVALID_HOTEL_CUSTOMER_LINK")] InvalidHotelCustomerLink = 38,
        /// <summary>
        /// Hotel setting was not found when creating a hotel ads campaign.
        /// </summary>
        [pbr::OriginalName("MISSING_HOTEL_SETTING")] MissingHotelSetting = 39,
        /// <summary>
        /// A Campaign cannot use shared campaign budgets and be part of a campaign
        /// group.
        /// </summary>
        [pbr::OriginalName("CANNOT_USE_SHARED_CAMPAIGN_BUDGET_WHILE_PART_OF_CAMPAIGN_GROUP")] CannotUseSharedCampaignBudgetWhilePartOfCampaignGroup = 40,
        /// <summary>
        /// The app ID was not found.
        /// </summary>
        [pbr::OriginalName("APP_NOT_FOUND")] AppNotFound = 41,
        /// <summary>
        /// Campaign.shopping_setting.enable_local is not supported for the specified
        /// campaign type.
        /// </summary>
        [pbr::OriginalName("SHOPPING_ENABLE_LOCAL_NOT_SUPPORTED_FOR_CAMPAIGN_TYPE")] ShoppingEnableLocalNotSupportedForCampaignType = 42,
        /// <summary>
        /// The merchant does not support the creation of campaigns for Shopping
        /// Comparison Listing Ads.
        /// </summary>
        [pbr::OriginalName("MERCHANT_NOT_ALLOWED_FOR_COMPARISON_LISTING_ADS")] MerchantNotAllowedForComparisonListingAds = 43,
        /// <summary>
        /// The App campaign for engagement cannot be created because there aren't
        /// enough installs.
        /// </summary>
        [pbr::OriginalName("INSUFFICIENT_APP_INSTALLS_COUNT")] InsufficientAppInstallsCount = 44,
        /// <summary>
        /// The App campaign for engagement cannot be created because the app is
        /// sensitive.
        /// </summary>
        [pbr::OriginalName("SENSITIVE_CATEGORY_APP")] SensitiveCategoryApp = 45,
        /// <summary>
        /// Customers with Housing, Employment, or Credit ads must accept updated
        /// personalized ads policy to continue creating campaigns.
        /// </summary>
        [pbr::OriginalName("HEC_AGREEMENT_REQUIRED")] HecAgreementRequired = 46,
        /// <summary>
        /// The field is not compatible with view through conversion optimization.
        /// </summary>
        [pbr::OriginalName("NOT_COMPATIBLE_WITH_VIEW_THROUGH_CONVERSION_OPTIMIZATION")] NotCompatibleWithViewThroughConversionOptimization = 49,
        /// <summary>
        /// The field type cannot be excluded because an active campaign-asset link
        /// of this type exists.
        /// </summary>
        [pbr::OriginalName("INVALID_EXCLUDED_PARENT_ASSET_FIELD_TYPE")] InvalidExcludedParentAssetFieldType = 48,
        /// <summary>
        /// The app pre-registration campaign cannot be created for non-Android
        /// applications.
        /// </summary>
        [pbr::OriginalName("CANNOT_CREATE_APP_PRE_REGISTRATION_FOR_NON_ANDROID_APP")] CannotCreateAppPreRegistrationForNonAndroidApp = 50,
        /// <summary>
        /// The campaign cannot be created since the app is not available for
        /// pre-registration in any country.
        /// </summary>
        [pbr::OriginalName("APP_NOT_AVAILABLE_TO_CREATE_APP_PRE_REGISTRATION_CAMPAIGN")] AppNotAvailableToCreateAppPreRegistrationCampaign = 51,
        /// <summary>
        /// The type of the Budget is not compatible with this Campaign.
        /// </summary>
        [pbr::OriginalName("INCOMPATIBLE_BUDGET_TYPE")] IncompatibleBudgetType = 52,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code