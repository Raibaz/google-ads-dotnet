// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v11/resources/campaign_conversion_goal.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V11.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v11/resources/campaign_conversion_goal.proto</summary>
  public static partial class CampaignConversionGoalReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v11/resources/campaign_conversion_goal.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CampaignConversionGoalReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkFnb29nbGUvYWRzL2dvb2dsZWFkcy92MTEvcmVzb3VyY2VzL2NhbXBhaWdu",
            "X2NvbnZlcnNpb25fZ29hbC5wcm90bxIiZ29vZ2xlLmFkcy5nb29nbGVhZHMu",
            "djExLnJlc291cmNlcxo/Z29vZ2xlL2Fkcy9nb29nbGVhZHMvdjExL2VudW1z",
            "L2NvbnZlcnNpb25fYWN0aW9uX2NhdGVnb3J5LnByb3RvGjZnb29nbGUvYWRz",
            "L2dvb2dsZWFkcy92MTEvZW51bXMvY29udmVyc2lvbl9vcmlnaW4ucHJvdG8a",
            "H2dvb2dsZS9hcGkvZmllbGRfYmVoYXZpb3IucHJvdG8aGWdvb2dsZS9hcGkv",
            "cmVzb3VyY2UucHJvdG8iggQKFkNhbXBhaWduQ29udmVyc2lvbkdvYWwSTgoN",
            "cmVzb3VyY2VfbmFtZRgBIAEoCUI34EEF+kExCi9nb29nbGVhZHMuZ29vZ2xl",
            "YXBpcy5jb20vQ2FtcGFpZ25Db252ZXJzaW9uR29hbBI7CghjYW1wYWlnbhgC",
            "IAEoCUIp4EEF+kEjCiFnb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20vQ2FtcGFp",
            "Z24SZwoIY2F0ZWdvcnkYAyABKA4yVS5nb29nbGUuYWRzLmdvb2dsZWFkcy52",
            "MTEuZW51bXMuQ29udmVyc2lvbkFjdGlvbkNhdGVnb3J5RW51bS5Db252ZXJz",
            "aW9uQWN0aW9uQ2F0ZWdvcnkSVQoGb3JpZ2luGAQgASgOMkUuZ29vZ2xlLmFk",
            "cy5nb29nbGVhZHMudjExLmVudW1zLkNvbnZlcnNpb25PcmlnaW5FbnVtLkNv",
            "bnZlcnNpb25PcmlnaW4SEAoIYmlkZGFibGUYBSABKAg6iAHqQYQBCi9nb29n",
            "bGVhZHMuZ29vZ2xlYXBpcy5jb20vQ2FtcGFpZ25Db252ZXJzaW9uR29hbBJR",
            "Y3VzdG9tZXJzL3tjdXN0b21lcl9pZH0vY2FtcGFpZ25Db252ZXJzaW9uR29h",
            "bHMve2NhbXBhaWduX2lkfX57Y2F0ZWdvcnl9fntzb3VyY2V9Qo0CCiZjb20u",
            "Z29vZ2xlLmFkcy5nb29nbGVhZHMudjExLnJlc291cmNlc0IbQ2FtcGFpZ25D",
            "b252ZXJzaW9uR29hbFByb3RvUAFaS2dvb2dsZS5nb2xhbmcub3JnL2dlbnBy",
            "b3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92MTEvcmVzb3VyY2VzO3Jl",
            "c291cmNlc6ICA0dBQaoCIkdvb2dsZS5BZHMuR29vZ2xlQWRzLlYxMS5SZXNv",
            "dXJjZXPKAiJHb29nbGVcQWRzXEdvb2dsZUFkc1xWMTFcUmVzb3VyY2Vz6gIm",
            "R29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjExOjpSZXNvdXJjZXNiBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V11.Enums.ConversionActionCategoryReflection.Descriptor, global::Google.Ads.GoogleAds.V11.Enums.ConversionOriginReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V11.Resources.CampaignConversionGoal), global::Google.Ads.GoogleAds.V11.Resources.CampaignConversionGoal.Parser, new[]{ "ResourceName", "Campaign", "Category", "Origin", "Biddable" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// The biddability setting for the specified campaign only for all
  /// conversion actions with a matching category and origin.
  /// </summary>
  public sealed partial class CampaignConversionGoal : pb::IMessage<CampaignConversionGoal>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CampaignConversionGoal> _parser = new pb::MessageParser<CampaignConversionGoal>(() => new CampaignConversionGoal());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CampaignConversionGoal> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V11.Resources.CampaignConversionGoalReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignConversionGoal() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignConversionGoal(CampaignConversionGoal other) : this() {
      resourceName_ = other.resourceName_;
      campaign_ = other.campaign_;
      category_ = other.category_;
      origin_ = other.origin_;
      biddable_ = other.biddable_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignConversionGoal Clone() {
      return new CampaignConversionGoal(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. The resource name of the campaign conversion goal.
    /// Campaign conversion goal resource names have the form:
    ///
    /// `customers/{customer_id}/campaignConversionGoals/{campaign_id}~{category}~{origin}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "campaign" field.</summary>
    public const int CampaignFieldNumber = 2;
    private string campaign_ = "";
    /// <summary>
    /// Immutable. The campaign with which this campaign conversion goal is associated.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Campaign {
      get { return campaign_; }
      set {
        campaign_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "category" field.</summary>
    public const int CategoryFieldNumber = 3;
    private global::Google.Ads.GoogleAds.V11.Enums.ConversionActionCategoryEnum.Types.ConversionActionCategory category_ = global::Google.Ads.GoogleAds.V11.Enums.ConversionActionCategoryEnum.Types.ConversionActionCategory.Unspecified;
    /// <summary>
    /// The conversion category of this campaign conversion goal.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V11.Enums.ConversionActionCategoryEnum.Types.ConversionActionCategory Category {
      get { return category_; }
      set {
        category_ = value;
      }
    }

    /// <summary>Field number for the "origin" field.</summary>
    public const int OriginFieldNumber = 4;
    private global::Google.Ads.GoogleAds.V11.Enums.ConversionOriginEnum.Types.ConversionOrigin origin_ = global::Google.Ads.GoogleAds.V11.Enums.ConversionOriginEnum.Types.ConversionOrigin.Unspecified;
    /// <summary>
    /// The conversion origin of this campaign conversion goal.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V11.Enums.ConversionOriginEnum.Types.ConversionOrigin Origin {
      get { return origin_; }
      set {
        origin_ = value;
      }
    }

    /// <summary>Field number for the "biddable" field.</summary>
    public const int BiddableFieldNumber = 5;
    private bool biddable_;
    /// <summary>
    /// The biddability of the campaign conversion goal.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Biddable {
      get { return biddable_; }
      set {
        biddable_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CampaignConversionGoal);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CampaignConversionGoal other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (Campaign != other.Campaign) return false;
      if (Category != other.Category) return false;
      if (Origin != other.Origin) return false;
      if (Biddable != other.Biddable) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (Campaign.Length != 0) hash ^= Campaign.GetHashCode();
      if (Category != global::Google.Ads.GoogleAds.V11.Enums.ConversionActionCategoryEnum.Types.ConversionActionCategory.Unspecified) hash ^= Category.GetHashCode();
      if (Origin != global::Google.Ads.GoogleAds.V11.Enums.ConversionOriginEnum.Types.ConversionOrigin.Unspecified) hash ^= Origin.GetHashCode();
      if (Biddable != false) hash ^= Biddable.GetHashCode();
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
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (Campaign.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Campaign);
      }
      if (Category != global::Google.Ads.GoogleAds.V11.Enums.ConversionActionCategoryEnum.Types.ConversionActionCategory.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Category);
      }
      if (Origin != global::Google.Ads.GoogleAds.V11.Enums.ConversionOriginEnum.Types.ConversionOrigin.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Origin);
      }
      if (Biddable != false) {
        output.WriteRawTag(40);
        output.WriteBool(Biddable);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (Campaign.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Campaign);
      }
      if (Category != global::Google.Ads.GoogleAds.V11.Enums.ConversionActionCategoryEnum.Types.ConversionActionCategory.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Category);
      }
      if (Origin != global::Google.Ads.GoogleAds.V11.Enums.ConversionOriginEnum.Types.ConversionOrigin.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Origin);
      }
      if (Biddable != false) {
        output.WriteRawTag(40);
        output.WriteBool(Biddable);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (ResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
      }
      if (Campaign.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Campaign);
      }
      if (Category != global::Google.Ads.GoogleAds.V11.Enums.ConversionActionCategoryEnum.Types.ConversionActionCategory.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Category);
      }
      if (Origin != global::Google.Ads.GoogleAds.V11.Enums.ConversionOriginEnum.Types.ConversionOrigin.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Origin);
      }
      if (Biddable != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CampaignConversionGoal other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.Campaign.Length != 0) {
        Campaign = other.Campaign;
      }
      if (other.Category != global::Google.Ads.GoogleAds.V11.Enums.ConversionActionCategoryEnum.Types.ConversionActionCategory.Unspecified) {
        Category = other.Category;
      }
      if (other.Origin != global::Google.Ads.GoogleAds.V11.Enums.ConversionOriginEnum.Types.ConversionOrigin.Unspecified) {
        Origin = other.Origin;
      }
      if (other.Biddable != false) {
        Biddable = other.Biddable;
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
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
          case 18: {
            Campaign = input.ReadString();
            break;
          }
          case 24: {
            Category = (global::Google.Ads.GoogleAds.V11.Enums.ConversionActionCategoryEnum.Types.ConversionActionCategory) input.ReadEnum();
            break;
          }
          case 32: {
            Origin = (global::Google.Ads.GoogleAds.V11.Enums.ConversionOriginEnum.Types.ConversionOrigin) input.ReadEnum();
            break;
          }
          case 40: {
            Biddable = input.ReadBool();
            break;
          }
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
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
          case 18: {
            Campaign = input.ReadString();
            break;
          }
          case 24: {
            Category = (global::Google.Ads.GoogleAds.V11.Enums.ConversionActionCategoryEnum.Types.ConversionActionCategory) input.ReadEnum();
            break;
          }
          case 32: {
            Origin = (global::Google.Ads.GoogleAds.V11.Enums.ConversionOriginEnum.Types.ConversionOrigin) input.ReadEnum();
            break;
          }
          case 40: {
            Biddable = input.ReadBool();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code