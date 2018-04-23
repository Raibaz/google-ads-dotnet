// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/resources/campaign_criterion.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V0.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v0/resources/campaign_criterion.proto</summary>
  public static partial class CampaignCriterionReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v0/resources/campaign_criterion.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CampaignCriterionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjpnb29nbGUvYWRzL2dvb2dsZWFkcy92MC9yZXNvdXJjZXMvY2FtcGFpZ25f",
            "Y3JpdGVyaW9uLnByb3RvEiFnb29nbGUuYWRzLmdvb2dsZWFkcy52MC5yZXNv",
            "dXJjZXMaLWdvb2dsZS9hZHMvZ29vZ2xlYWRzL3YwL2NvbW1vbi9jcml0ZXJp",
            "YS5wcm90bxoyZ29vZ2xlL2Fkcy9nb29nbGVhZHMvdjAvZW51bXMvY3JpdGVy",
            "aW9uX3R5cGUucHJvdG8aHmdvb2dsZS9wcm90b2J1Zi93cmFwcGVycy5wcm90",
            "byLWAgoRQ2FtcGFpZ25Dcml0ZXJpb24SFQoNcmVzb3VyY2VfbmFtZRgBIAEo",
            "CRIuCghjYW1wYWlnbhgEIAEoCzIcLmdvb2dsZS5wcm90b2J1Zi5TdHJpbmdW",
            "YWx1ZRIxCgxjcml0ZXJpb25faWQYBSABKAsyGy5nb29nbGUucHJvdG9idWYu",
            "SW50NjRWYWx1ZRIsCghuZWdhdGl2ZRgHIAEoCzIaLmdvb2dsZS5wcm90b2J1",
            "Zi5Cb29sVmFsdWUSTAoEdHlwZRgGIAEoDjI+Lmdvb2dsZS5hZHMuZ29vZ2xl",
            "YWRzLnYwLmVudW1zLkNyaXRlcmlvblR5cGVFbnVtLkNyaXRlcmlvblR5cGUS",
            "PgoHa2V5d29yZBgIIAEoCzIrLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYwLmNv",
            "bW1vbi5LZXl3b3JkSW5mb0gAQgsKCWNyaXRlcmlvbkLbAQolY29tLmdvb2ds",
            "ZS5hZHMuZ29vZ2xlYWRzLnYwLnJlc291cmNlc0IWQ2FtcGFpZ25Dcml0ZXJp",
            "b25Qcm90b1ABWkpnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVh",
            "cGlzL2Fkcy9nb29nbGVhZHMvdjAvcmVzb3VyY2VzO3Jlc291cmNlc6ICA0dB",
            "QaoCIUdvb2dsZS5BZHMuR29vZ2xlQWRzLlYwLlJlc291cmNlc8oCIUdvb2ds",
            "ZVxBZHNcR29vZ2xlQWRzXFYwXFJlc291cmNlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V0.Common.CriteriaReflection.Descriptor, global::Google.Ads.GoogleAds.V0.Enums.CriterionTypeReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Resources.CampaignCriterion), global::Google.Ads.GoogleAds.V0.Resources.CampaignCriterion.Parser, new[]{ "ResourceName", "Campaign", "CriterionId", "Negative", "Type", "Keyword" }, new[]{ "Criterion" }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A campaign criterion.
  /// </summary>
  public sealed partial class CampaignCriterion : pb::IMessage<CampaignCriterion> {
    private static readonly pb::MessageParser<CampaignCriterion> _parser = new pb::MessageParser<CampaignCriterion>(() => new CampaignCriterion());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CampaignCriterion> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Resources.CampaignCriterionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CampaignCriterion() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CampaignCriterion(CampaignCriterion other) : this() {
      resourceName_ = other.resourceName_;
      Campaign = other.Campaign;
      CriterionId = other.CriterionId;
      Negative = other.Negative;
      type_ = other.type_;
      switch (other.CriterionCase) {
        case CriterionOneofCase.Keyword:
          Keyword = other.Keyword.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CampaignCriterion Clone() {
      return new CampaignCriterion(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// The resource name of the campaign criterion.
    /// Campaign criterion resource names have the form:
    ///
    /// `customers/{customer_id}/campaignCriteria/{campaign_id}_{criterion_id}
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "campaign" field.</summary>
    public const int CampaignFieldNumber = 4;
    private static readonly pb::FieldCodec<string> _single_campaign_codec = pb::FieldCodec.ForClassWrapper<string>(34);
    private string campaign_;
    /// <summary>
    /// The campaign to which the criterion belongs.
    ///
    /// This field must not be used in WHERE clauses.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Campaign {
      get { return campaign_; }
      set {
        campaign_ = value;
      }
    }

    /// <summary>Field number for the "criterion_id" field.</summary>
    public const int CriterionIdFieldNumber = 5;
    private static readonly pb::FieldCodec<long?> _single_criterionId_codec = pb::FieldCodec.ForStructWrapper<long>(42);
    private long? criterionId_;
    /// <summary>
    /// The ID of the criterion.
    ///
    /// This field is ignored during mutate.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long? CriterionId {
      get { return criterionId_; }
      set {
        criterionId_ = value;
      }
    }

    /// <summary>Field number for the "negative" field.</summary>
    public const int NegativeFieldNumber = 7;
    private static readonly pb::FieldCodec<bool?> _single_negative_codec = pb::FieldCodec.ForStructWrapper<bool>(58);
    private bool? negative_;
    /// <summary>
    /// Whether to target (`false`) or exclude (`true`) the criterion.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool? Negative {
      get { return negative_; }
      set {
        negative_ = value;
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 6;
    private global::Google.Ads.GoogleAds.V0.Enums.CriterionTypeEnum.Types.CriterionType type_ = 0;
    /// <summary>
    /// The type of the criterion.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V0.Enums.CriterionTypeEnum.Types.CriterionType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "keyword" field.</summary>
    public const int KeywordFieldNumber = 8;
    /// <summary>
    /// Keyword.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V0.Common.KeywordInfo Keyword {
      get { return criterionCase_ == CriterionOneofCase.Keyword ? (global::Google.Ads.GoogleAds.V0.Common.KeywordInfo) criterion_ : null; }
      set {
        criterion_ = value;
        criterionCase_ = value == null ? CriterionOneofCase.None : CriterionOneofCase.Keyword;
      }
    }

    private object criterion_;
    /// <summary>Enum of possible cases for the "criterion" oneof.</summary>
    public enum CriterionOneofCase {
      None = 0,
      Keyword = 8,
    }
    private CriterionOneofCase criterionCase_ = CriterionOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CriterionOneofCase CriterionCase {
      get { return criterionCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearCriterion() {
      criterionCase_ = CriterionOneofCase.None;
      criterion_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CampaignCriterion);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CampaignCriterion other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (Campaign != other.Campaign) return false;
      if (CriterionId != other.CriterionId) return false;
      if (Negative != other.Negative) return false;
      if (Type != other.Type) return false;
      if (!object.Equals(Keyword, other.Keyword)) return false;
      if (CriterionCase != other.CriterionCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (campaign_ != null) hash ^= Campaign.GetHashCode();
      if (criterionId_ != null) hash ^= CriterionId.GetHashCode();
      if (negative_ != null) hash ^= Negative.GetHashCode();
      if (Type != 0) hash ^= Type.GetHashCode();
      if (criterionCase_ == CriterionOneofCase.Keyword) hash ^= Keyword.GetHashCode();
      hash ^= (int) criterionCase_;
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
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (campaign_ != null) {
        _single_campaign_codec.WriteTagAndValue(output, Campaign);
      }
      if (criterionId_ != null) {
        _single_criterionId_codec.WriteTagAndValue(output, CriterionId);
      }
      if (Type != 0) {
        output.WriteRawTag(48);
        output.WriteEnum((int) Type);
      }
      if (negative_ != null) {
        _single_negative_codec.WriteTagAndValue(output, Negative);
      }
      if (criterionCase_ == CriterionOneofCase.Keyword) {
        output.WriteRawTag(66);
        output.WriteMessage(Keyword);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
      }
      if (campaign_ != null) {
        size += _single_campaign_codec.CalculateSizeWithTag(Campaign);
      }
      if (criterionId_ != null) {
        size += _single_criterionId_codec.CalculateSizeWithTag(CriterionId);
      }
      if (negative_ != null) {
        size += _single_negative_codec.CalculateSizeWithTag(Negative);
      }
      if (Type != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (criterionCase_ == CriterionOneofCase.Keyword) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Keyword);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CampaignCriterion other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.campaign_ != null) {
        if (campaign_ == null || other.Campaign != "") {
          Campaign = other.Campaign;
        }
      }
      if (other.criterionId_ != null) {
        if (criterionId_ == null || other.CriterionId != 0L) {
          CriterionId = other.CriterionId;
        }
      }
      if (other.negative_ != null) {
        if (negative_ == null || other.Negative != false) {
          Negative = other.Negative;
        }
      }
      if (other.Type != 0) {
        Type = other.Type;
      }
      switch (other.CriterionCase) {
        case CriterionOneofCase.Keyword:
          if (Keyword == null) {
            Keyword = new global::Google.Ads.GoogleAds.V0.Common.KeywordInfo();
          }
          Keyword.MergeFrom(other.Keyword);
          break;
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
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
          case 34: {
            string value = _single_campaign_codec.Read(input);
            if (campaign_ == null || value != "") {
              Campaign = value;
            }
            break;
          }
          case 42: {
            long? value = _single_criterionId_codec.Read(input);
            if (criterionId_ == null || value != 0L) {
              CriterionId = value;
            }
            break;
          }
          case 48: {
            type_ = (global::Google.Ads.GoogleAds.V0.Enums.CriterionTypeEnum.Types.CriterionType) input.ReadEnum();
            break;
          }
          case 58: {
            bool? value = _single_negative_codec.Read(input);
            if (negative_ == null || value != false) {
              Negative = value;
            }
            break;
          }
          case 66: {
            global::Google.Ads.GoogleAds.V0.Common.KeywordInfo subBuilder = new global::Google.Ads.GoogleAds.V0.Common.KeywordInfo();
            if (criterionCase_ == CriterionOneofCase.Keyword) {
              subBuilder.MergeFrom(Keyword);
            }
            input.ReadMessage(subBuilder);
            Keyword = subBuilder;
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
