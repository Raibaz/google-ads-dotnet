// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/enums/call_placeholder_field.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V0.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v0/enums/call_placeholder_field.proto</summary>
  public static partial class CallPlaceholderFieldReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v0/enums/call_placeholder_field.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CallPlaceholderFieldReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjpnb29nbGUvYWRzL2dvb2dsZWFkcy92MC9lbnVtcy9jYWxsX3BsYWNlaG9s",
            "ZGVyX2ZpZWxkLnByb3RvEh1nb29nbGUuYWRzLmdvb2dsZWFkcy52MC5lbnVt",
            "cyK6AQoYQ2FsbFBsYWNlaG9sZGVyRmllbGRFbnVtIp0BChRDYWxsUGxhY2Vo",
            "b2xkZXJGaWVsZBIPCgtVTlNQRUNJRklFRBAAEgsKB1VOS05PV04QARIQCgxQ",
            "SE9ORV9OVU1CRVIQAhIQCgxDT1VOVFJZX0NPREUQAxILCgdUUkFDS0VEEAQS",
            "FgoSQ09OVkVSU0lPTl9UWVBFX0lEEAUSHgoaQ09OVkVSU0lPTl9SRVBPUlRJ",
            "TkdfU1RBVEUQBkLKAQohY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYwLmVu",
            "dW1zQhlDYWxsUGxhY2Vob2xkZXJGaWVsZFByb3RvUAFaQmdvb2dsZS5nb2xh",
            "bmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92MC9l",
            "bnVtcztlbnVtc6ICA0dBQaoCHUdvb2dsZS5BZHMuR29vZ2xlQWRzLlYwLkVu",
            "dW1zygIdR29vZ2xlXEFkc1xHb29nbGVBZHNcVjBcRW51bXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Enums.CallPlaceholderFieldEnum), global::Google.Ads.GoogleAds.V0.Enums.CallPlaceholderFieldEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V0.Enums.CallPlaceholderFieldEnum.Types.CallPlaceholderField) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Values for Call placeholder fields.
  /// </summary>
  public sealed partial class CallPlaceholderFieldEnum : pb::IMessage<CallPlaceholderFieldEnum> {
    private static readonly pb::MessageParser<CallPlaceholderFieldEnum> _parser = new pb::MessageParser<CallPlaceholderFieldEnum>(() => new CallPlaceholderFieldEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CallPlaceholderFieldEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Enums.CallPlaceholderFieldReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CallPlaceholderFieldEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CallPlaceholderFieldEnum(CallPlaceholderFieldEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CallPlaceholderFieldEnum Clone() {
      return new CallPlaceholderFieldEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CallPlaceholderFieldEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CallPlaceholderFieldEnum other) {
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
    public void MergeFrom(CallPlaceholderFieldEnum other) {
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
    /// <summary>Container for nested types declared in the CallPlaceholderFieldEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Possible values for Call placeholder fields.
      /// </summary>
      public enum CallPlaceholderField {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Data Type: STRING. The advertiser's phone number to append to the ad.
        /// </summary>
        [pbr::OriginalName("PHONE_NUMBER")] PhoneNumber = 2,
        /// <summary>
        /// Data Type: STRING. Uppercase two-letter country code of the advertiser's
        /// phone number.
        /// </summary>
        [pbr::OriginalName("COUNTRY_CODE")] CountryCode = 3,
        /// <summary>
        /// Data Type: BOOLEAN. Indicates whether call tracking is enabled. Default:
        /// true.
        /// </summary>
        [pbr::OriginalName("TRACKED")] Tracked = 4,
        /// <summary>
        /// Data Type: INT64. The ID of an AdCallMetricsConversion object. This
        /// object contains the phoneCallDurationfield which is the minimum duration
        /// (in seconds) of a call to be considered a conversion.
        /// </summary>
        [pbr::OriginalName("CONVERSION_TYPE_ID")] ConversionTypeId = 5,
        /// <summary>
        /// Data Type: STRING. Indicates whether this call extension uses its own
        /// call conversion setting or follows the account level setting.
        /// Valid values are: USE_ACCOUNT_LEVEL_CALL_CONVERSION_ACTION and
        /// USE_RESOURCE_LEVEL_CALL_CONVERSION_ACTION.
        /// </summary>
        [pbr::OriginalName("CONVERSION_REPORTING_STATE")] ConversionReportingState = 6,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
