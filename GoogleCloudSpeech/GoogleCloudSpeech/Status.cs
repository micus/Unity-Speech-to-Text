// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: status.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Rpc {

  /// <summary>Holder for reflection information generated from status.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class StatusReflection {

    #region Descriptor
    /// <summary>File descriptor for status.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static StatusReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgxzdGF0dXMucHJvdG8SCmdvb2dsZS5ycGMaCWFueS5wcm90byJOCgZTdGF0",
            "dXMSDAoEY29kZRgBIAEoBRIPCgdtZXNzYWdlGAIgASgJEiUKB2RldGFpbHMY",
            "AyADKAsyFC5nb29nbGUucHJvdG9idWYuQW55Qh8KDmNvbS5nb29nbGUucnBj",
            "QgtTdGF0dXNQcm90b1ABYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.AnyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Rpc.Status), global::Google.Rpc.Status.Parser, new[]{ "Code", "Message", "Details" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///  The `Status` type defines a logical error model that is suitable for different
  ///  programming environments, including REST APIs and RPC APIs. It is used by
  ///  [gRPC](https://github.com/grpc). The error model is designed to be:
  ///
  ///  - Simple to use and understand for most users
  ///  - Flexible enough to meet unexpected needs
  ///
  ///  # Overview
  ///
  ///  The `Status` message contains three pieces of data: error code, error message,
  ///  and error details. The error code should be an enum value of
  ///  [google.rpc.Code][google.rpc.Code], but it may accept additional error codes if needed.  The
  ///  error message should be a developer-facing English message that helps
  ///  developers *understand* and *resolve* the error. If a localized user-facing
  ///  error message is needed, put the localized message in the error details or
  ///  localize it in the client. The optional error details may contain arbitrary
  ///  information about the error. There is a predefined set of error detail types
  ///  in the package `google.rpc` which can be used for common error conditions.
  ///
  ///  # Language mapping
  ///
  ///  The `Status` message is the logical representation of the error model, but it
  ///  is not necessarily the actual wire format. When the `Status` message is
  ///  exposed in different client libraries and different wire protocols, it can be
  ///  mapped differently. For example, it will likely be mapped to some exceptions
  ///  in Java, but more likely mapped to some error codes in C.
  ///
  ///  # Other uses
  ///
  ///  The error model and the `Status` message can be used in a variety of
  ///  environments, either with or without APIs, to provide a
  ///  consistent developer experience across different environments.
  ///
  ///  Example uses of this error model include:
  ///
  ///  - Partial errors. If a service needs to return partial errors to the client,
  ///      it may embed the `Status` in the normal response to indicate the partial
  ///      errors.
  ///
  ///  - Workflow errors. A typical workflow has multiple steps. Each step may
  ///      have a `Status` message for error reporting purpose.
  ///
  ///  - Batch operations. If a client uses batch request and batch response, the
  ///      `Status` message should be used directly inside batch response, one for
  ///      each error sub-response.
  ///
  ///  - Asynchronous operations. If an API call embeds asynchronous operation
  ///      results in its response, the status of those operations should be
  ///      represented directly using the `Status` message.
  ///
  ///  - Logging. If some API errors are stored in logs, the message `Status` could
  ///      be used directly after any stripping needed for security/privacy reasons.
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Status : pb::IMessage<Status> {
    private static readonly pb::MessageParser<Status> _parser = new pb::MessageParser<Status>(() => new Status());
    public static pb::MessageParser<Status> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Rpc.StatusReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public Status() {
      OnConstruction();
    }

    partial void OnConstruction();

    public Status(Status other) : this() {
      code_ = other.code_;
      message_ = other.message_;
      details_ = other.details_.Clone();
    }

    public Status Clone() {
      return new Status(this);
    }

    /// <summary>Field number for the "code" field.</summary>
    public const int CodeFieldNumber = 1;
    private int code_;
    /// <summary>
    ///  The status code, which should be an enum value of [google.rpc.Code][google.rpc.Code].
    /// </summary>
    public int Code {
      get { return code_; }
      set {
        code_ = value;
      }
    }

    /// <summary>Field number for the "message" field.</summary>
    public const int MessageFieldNumber = 2;
    private string message_ = "";
    /// <summary>
    ///  A developer-facing error message, which should be in English. Any
    ///  user-facing error message should be localized and sent in the
    ///  [google.rpc.Status.details][google.rpc.Status.details] field, or localized by the client.
    /// </summary>
    public string Message {
      get { return message_; }
      set {
        message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "details" field.</summary>
    public const int DetailsFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Google.Protobuf.WellKnownTypes.Any> _repeated_details_codec
        = pb::FieldCodec.ForMessage(26, global::Google.Protobuf.WellKnownTypes.Any.Parser);
    private readonly pbc::RepeatedField<global::Google.Protobuf.WellKnownTypes.Any> details_ = new pbc::RepeatedField<global::Google.Protobuf.WellKnownTypes.Any>();
    /// <summary>
    ///  A list of messages that carry the error details.  There will be a
    ///  common set of message types for APIs to use.
    /// </summary>
    public pbc::RepeatedField<global::Google.Protobuf.WellKnownTypes.Any> Details {
      get { return details_; }
    }

    public override bool Equals(object other) {
      return Equals(other as Status);
    }

    public bool Equals(Status other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Code != other.Code) return false;
      if (Message != other.Message) return false;
      if(!details_.Equals(other.details_)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Code != 0) hash ^= Code.GetHashCode();
      if (Message.Length != 0) hash ^= Message.GetHashCode();
      hash ^= details_.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Code != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Code);
      }
      if (Message.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Message);
      }
      details_.WriteTo(output, _repeated_details_codec);
    }

    public int CalculateSize() {
      int size = 0;
      if (Code != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Code);
      }
      if (Message.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Message);
      }
      size += details_.CalculateSize(_repeated_details_codec);
      return size;
    }

    public void MergeFrom(Status other) {
      if (other == null) {
        return;
      }
      if (other.Code != 0) {
        Code = other.Code;
      }
      if (other.Message.Length != 0) {
        Message = other.Message;
      }
      details_.Add(other.details_);
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Code = input.ReadInt32();
            break;
          }
          case 18: {
            Message = input.ReadString();
            break;
          }
          case 26: {
            details_.AddEntriesFrom(input, _repeated_details_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
