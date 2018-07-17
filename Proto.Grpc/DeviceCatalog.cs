// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: device_catalog.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace GrpcDeviceCatalog {

  /// <summary>Holder for reflection information generated from device_catalog.proto</summary>
  public static partial class DeviceCatalogReflection {

    #region Descriptor
    /// <summary>File descriptor for device_catalog.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DeviceCatalogReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRkZXZpY2VfY2F0YWxvZy5wcm90bxIRR3JwY0RldmljZUNhdGFsb2ciJQoR",
            "R2V0Q2F0YWxvZ1JlcXVlc3QSEAoIZGV2aWNlaWQYASABKAkiIgoPR2V0Q2F0",
            "YWxvZ1JlcGx5Eg8KB21lc3NhZ2UYASABKAkiMQodRGV2aWNlQ2F0YWxvZ1N1",
            "YnNjcmliZVJlcXVlc3QSEAoIZGV2aWNlaWQYASABKAkiLgobRGV2aWNlQ2F0",
            "YWxvZ1N1YnNjcmliZVJlcGx5Eg8KB21lc3NhZ2UYASABKAky5wEKDURldmlj",
            "ZUNhdGFsb2cSWAoKR2V0Q2F0YWxvZxIkLkdycGNEZXZpY2VDYXRhbG9nLkdl",
            "dENhdGFsb2dSZXF1ZXN0GiIuR3JwY0RldmljZUNhdGFsb2cuR2V0Q2F0YWxv",
            "Z1JlcGx5IgASfAoWRGV2aWNlQ2F0YWxvZ1N1YnNjcmliZRIwLkdycGNEZXZp",
            "Y2VDYXRhbG9nLkRldmljZUNhdGFsb2dTdWJzY3JpYmVSZXF1ZXN0Gi4uR3Jw",
            "Y0RldmljZUNhdGFsb2cuRGV2aWNlQ2F0YWxvZ1N1YnNjcmliZVJlcGx5IgBi",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcDeviceCatalog.GetCatalogRequest), global::GrpcDeviceCatalog.GetCatalogRequest.Parser, new[]{ "Deviceid" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcDeviceCatalog.GetCatalogReply), global::GrpcDeviceCatalog.GetCatalogReply.Parser, new[]{ "Message" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcDeviceCatalog.DeviceCatalogSubscribeRequest), global::GrpcDeviceCatalog.DeviceCatalogSubscribeRequest.Parser, new[]{ "Deviceid" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcDeviceCatalog.DeviceCatalogSubscribeReply), global::GrpcDeviceCatalog.DeviceCatalogSubscribeReply.Parser, new[]{ "Message" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// The request message.
  /// </summary>
  public sealed partial class GetCatalogRequest : pb::IMessage<GetCatalogRequest> {
    private static readonly pb::MessageParser<GetCatalogRequest> _parser = new pb::MessageParser<GetCatalogRequest>(() => new GetCatalogRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetCatalogRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcDeviceCatalog.DeviceCatalogReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetCatalogRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetCatalogRequest(GetCatalogRequest other) : this() {
      deviceid_ = other.deviceid_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetCatalogRequest Clone() {
      return new GetCatalogRequest(this);
    }

    /// <summary>Field number for the "deviceid" field.</summary>
    public const int DeviceidFieldNumber = 1;
    private string deviceid_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Deviceid {
      get { return deviceid_; }
      set {
        deviceid_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetCatalogRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetCatalogRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Deviceid != other.Deviceid) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Deviceid.Length != 0) hash ^= Deviceid.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Deviceid.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Deviceid);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Deviceid.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Deviceid);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetCatalogRequest other) {
      if (other == null) {
        return;
      }
      if (other.Deviceid.Length != 0) {
        Deviceid = other.Deviceid;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Deviceid = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// The response message.
  /// </summary>
  public sealed partial class GetCatalogReply : pb::IMessage<GetCatalogReply> {
    private static readonly pb::MessageParser<GetCatalogReply> _parser = new pb::MessageParser<GetCatalogReply>(() => new GetCatalogReply());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetCatalogReply> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcDeviceCatalog.DeviceCatalogReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetCatalogReply() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetCatalogReply(GetCatalogReply other) : this() {
      message_ = other.message_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetCatalogReply Clone() {
      return new GetCatalogReply(this);
    }

    /// <summary>Field number for the "message" field.</summary>
    public const int MessageFieldNumber = 1;
    private string message_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Message {
      get { return message_; }
      set {
        message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetCatalogReply);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetCatalogReply other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Message != other.Message) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Message.Length != 0) hash ^= Message.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Message.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Message);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Message.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Message);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetCatalogReply other) {
      if (other == null) {
        return;
      }
      if (other.Message.Length != 0) {
        Message = other.Message;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Message = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// The request message.
  /// </summary>
  public sealed partial class DeviceCatalogSubscribeRequest : pb::IMessage<DeviceCatalogSubscribeRequest> {
    private static readonly pb::MessageParser<DeviceCatalogSubscribeRequest> _parser = new pb::MessageParser<DeviceCatalogSubscribeRequest>(() => new DeviceCatalogSubscribeRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DeviceCatalogSubscribeRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcDeviceCatalog.DeviceCatalogReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DeviceCatalogSubscribeRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DeviceCatalogSubscribeRequest(DeviceCatalogSubscribeRequest other) : this() {
      deviceid_ = other.deviceid_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DeviceCatalogSubscribeRequest Clone() {
      return new DeviceCatalogSubscribeRequest(this);
    }

    /// <summary>Field number for the "deviceid" field.</summary>
    public const int DeviceidFieldNumber = 1;
    private string deviceid_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Deviceid {
      get { return deviceid_; }
      set {
        deviceid_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DeviceCatalogSubscribeRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DeviceCatalogSubscribeRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Deviceid != other.Deviceid) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Deviceid.Length != 0) hash ^= Deviceid.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Deviceid.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Deviceid);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Deviceid.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Deviceid);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DeviceCatalogSubscribeRequest other) {
      if (other == null) {
        return;
      }
      if (other.Deviceid.Length != 0) {
        Deviceid = other.Deviceid;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Deviceid = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// The response message.
  /// </summary>
  public sealed partial class DeviceCatalogSubscribeReply : pb::IMessage<DeviceCatalogSubscribeReply> {
    private static readonly pb::MessageParser<DeviceCatalogSubscribeReply> _parser = new pb::MessageParser<DeviceCatalogSubscribeReply>(() => new DeviceCatalogSubscribeReply());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DeviceCatalogSubscribeReply> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcDeviceCatalog.DeviceCatalogReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DeviceCatalogSubscribeReply() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DeviceCatalogSubscribeReply(DeviceCatalogSubscribeReply other) : this() {
      message_ = other.message_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DeviceCatalogSubscribeReply Clone() {
      return new DeviceCatalogSubscribeReply(this);
    }

    /// <summary>Field number for the "message" field.</summary>
    public const int MessageFieldNumber = 1;
    private string message_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Message {
      get { return message_; }
      set {
        message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DeviceCatalogSubscribeReply);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DeviceCatalogSubscribeReply other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Message != other.Message) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Message.Length != 0) hash ^= Message.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Message.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Message);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Message.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Message);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DeviceCatalogSubscribeReply other) {
      if (other == null) {
        return;
      }
      if (other.Message.Length != 0) {
        Message = other.Message;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Message = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code