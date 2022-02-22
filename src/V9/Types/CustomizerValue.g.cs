// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v9/common/customizer_value.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V9.Common {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v9/common/customizer_value.proto</summary>
  public static partial class CustomizerValueReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v9/common/customizer_value.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CustomizerValueReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjVnb29nbGUvYWRzL2dvb2dsZWFkcy92OS9jb21tb24vY3VzdG9taXplcl92",
            "YWx1ZS5wcm90bxIeZ29vZ2xlLmFkcy5nb29nbGVhZHMudjkuY29tbW9uGj1n",
            "b29nbGUvYWRzL2dvb2dsZWFkcy92OS9lbnVtcy9jdXN0b21pemVyX2F0dHJp",
            "YnV0ZV90eXBlLnByb3RvGh9nb29nbGUvYXBpL2ZpZWxkX2JlaGF2aW9yLnBy",
            "b3RvGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvIpMBCg9DdXN0b21p",
            "emVyVmFsdWUSZQoEdHlwZRgBIAEoDjJSLmdvb2dsZS5hZHMuZ29vZ2xlYWRz",
            "LnY5LmVudW1zLkN1c3RvbWl6ZXJBdHRyaWJ1dGVUeXBlRW51bS5DdXN0b21p",
            "emVyQXR0cmlidXRlVHlwZUID4EECEhkKDHN0cmluZ192YWx1ZRgCIAEoCUID",
            "4EECQu8BCiJjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjkuY29tbW9uQhRD",
            "dXN0b21pemVyVmFsdWVQcm90b1ABWkRnb29nbGUuZ29sYW5nLm9yZy9nZW5w",
            "cm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjkvY29tbW9uO2NvbW1v",
            "bqICA0dBQaoCHkdvb2dsZS5BZHMuR29vZ2xlQWRzLlY5LkNvbW1vbsoCHkdv",
            "b2dsZVxBZHNcR29vZ2xlQWRzXFY5XENvbW1vbuoCIkdvb2dsZTo6QWRzOjpH",
            "b29nbGVBZHM6OlY5OjpDb21tb25iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V9.Enums.CustomizerAttributeTypeReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V9.Common.CustomizerValue), global::Google.Ads.GoogleAds.V9.Common.CustomizerValue.Parser, new[]{ "Type", "StringValue" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A customizer value that is referenced in customizer linkage entities
  /// like CustomerCustomizer, CampaignCustomizer, etc.
  /// </summary>
  public sealed partial class CustomizerValue : pb::IMessage<CustomizerValue>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CustomizerValue> _parser = new pb::MessageParser<CustomizerValue>(() => new CustomizerValue());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CustomizerValue> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V9.Common.CustomizerValueReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomizerValue() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomizerValue(CustomizerValue other) : this() {
      type_ = other.type_;
      stringValue_ = other.stringValue_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomizerValue Clone() {
      return new CustomizerValue(this);
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 1;
    private global::Google.Ads.GoogleAds.V9.Enums.CustomizerAttributeTypeEnum.Types.CustomizerAttributeType type_ = global::Google.Ads.GoogleAds.V9.Enums.CustomizerAttributeTypeEnum.Types.CustomizerAttributeType.Unspecified;
    /// <summary>
    /// Required. The data type for the customizer value. It must match the attribute type.
    /// The string_value content must match the constraints associated with the
    /// type.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V9.Enums.CustomizerAttributeTypeEnum.Types.CustomizerAttributeType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "string_value" field.</summary>
    public const int StringValueFieldNumber = 2;
    private string stringValue_ = "";
    /// <summary>
    /// Required. Value to insert in creative text. Customizer values of all types are stored
    /// as string to make formatting unambiguous.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string StringValue {
      get { return stringValue_; }
      set {
        stringValue_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CustomizerValue);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CustomizerValue other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Type != other.Type) return false;
      if (StringValue != other.StringValue) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Type != global::Google.Ads.GoogleAds.V9.Enums.CustomizerAttributeTypeEnum.Types.CustomizerAttributeType.Unspecified) hash ^= Type.GetHashCode();
      if (StringValue.Length != 0) hash ^= StringValue.GetHashCode();
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
      if (Type != global::Google.Ads.GoogleAds.V9.Enums.CustomizerAttributeTypeEnum.Types.CustomizerAttributeType.Unspecified) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Type);
      }
      if (StringValue.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(StringValue);
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
      if (Type != global::Google.Ads.GoogleAds.V9.Enums.CustomizerAttributeTypeEnum.Types.CustomizerAttributeType.Unspecified) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Type);
      }
      if (StringValue.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(StringValue);
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
      if (Type != global::Google.Ads.GoogleAds.V9.Enums.CustomizerAttributeTypeEnum.Types.CustomizerAttributeType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (StringValue.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(StringValue);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CustomizerValue other) {
      if (other == null) {
        return;
      }
      if (other.Type != global::Google.Ads.GoogleAds.V9.Enums.CustomizerAttributeTypeEnum.Types.CustomizerAttributeType.Unspecified) {
        Type = other.Type;
      }
      if (other.StringValue.Length != 0) {
        StringValue = other.StringValue;
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
          case 8: {
            Type = (global::Google.Ads.GoogleAds.V9.Enums.CustomizerAttributeTypeEnum.Types.CustomizerAttributeType) input.ReadEnum();
            break;
          }
          case 18: {
            StringValue = input.ReadString();
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
          case 8: {
            Type = (global::Google.Ads.GoogleAds.V9.Enums.CustomizerAttributeTypeEnum.Types.CustomizerAttributeType) input.ReadEnum();
            break;
          }
          case 18: {
            StringValue = input.ReadString();
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