// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: operations.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Longrunning {

  /// <summary>Holder for reflection information generated from operations.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class OperationsReflection {

    #region Descriptor
    /// <summary>File descriptor for operations.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OperationsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChBvcGVyYXRpb25zLnByb3RvEhJnb29nbGUubG9uZ3J1bm5pbmcaEWFubm90",
            "YXRpb25zLnByb3RvGglhbnkucHJvdG8aC2VtcHR5LnByb3RvGgxzdGF0dXMu",
            "cHJvdG8iqAEKCU9wZXJhdGlvbhIMCgRuYW1lGAEgASgJEiYKCG1ldGFkYXRh",
            "GAIgASgLMhQuZ29vZ2xlLnByb3RvYnVmLkFueRIMCgRkb25lGAMgASgIEiMK",
            "BWVycm9yGAQgASgLMhIuZ29vZ2xlLnJwYy5TdGF0dXNIABIoCghyZXNwb25z",
            "ZRgFIAEoCzIULmdvb2dsZS5wcm90b2J1Zi5BbnlIAEIICgZyZXN1bHQiIwoT",
            "R2V0T3BlcmF0aW9uUmVxdWVzdBIMCgRuYW1lGAEgASgJIlwKFUxpc3RPcGVy",
            "YXRpb25zUmVxdWVzdBIMCgRuYW1lGAQgASgJEg4KBmZpbHRlchgBIAEoCRIR",
            "CglwYWdlX3NpemUYAiABKAUSEgoKcGFnZV90b2tlbhgDIAEoCSJkChZMaXN0",
            "T3BlcmF0aW9uc1Jlc3BvbnNlEjEKCm9wZXJhdGlvbnMYASADKAsyHS5nb29n",
            "bGUubG9uZ3J1bm5pbmcuT3BlcmF0aW9uEhcKD25leHRfcGFnZV90b2tlbhgC",
            "IAEoCSImChZDYW5jZWxPcGVyYXRpb25SZXF1ZXN0EgwKBG5hbWUYASABKAki",
            "JgoWRGVsZXRlT3BlcmF0aW9uUmVxdWVzdBIMCgRuYW1lGAEgASgJMowECgpP",
            "cGVyYXRpb25zEngKDEdldE9wZXJhdGlvbhInLmdvb2dsZS5sb25ncnVubmlu",
            "Zy5HZXRPcGVyYXRpb25SZXF1ZXN0Gh0uZ29vZ2xlLmxvbmdydW5uaW5nLk9w",
            "ZXJhdGlvbiIggtPkkwIaEhgvdjEve25hbWU9b3BlcmF0aW9ucy8qKn0ShgEK",
            "Dkxpc3RPcGVyYXRpb25zEikuZ29vZ2xlLmxvbmdydW5uaW5nLkxpc3RPcGVy",
            "YXRpb25zUmVxdWVzdBoqLmdvb2dsZS5sb25ncnVubmluZy5MaXN0T3BlcmF0",
            "aW9uc1Jlc3BvbnNlIh2C0+STAhcSFS92MS97bmFtZT1vcGVyYXRpb25zfRKB",
            "AQoPQ2FuY2VsT3BlcmF0aW9uEiouZ29vZ2xlLmxvbmdydW5uaW5nLkNhbmNl",
            "bE9wZXJhdGlvblJlcXVlc3QaFi5nb29nbGUucHJvdG9idWYuRW1wdHkiKoLT",
            "5JMCJCIfL3YxL3tuYW1lPW9wZXJhdGlvbnMvKip9OmNhbmNlbDoBKhJ3Cg9E",
            "ZWxldGVPcGVyYXRpb24SKi5nb29nbGUubG9uZ3J1bm5pbmcuRGVsZXRlT3Bl",
            "cmF0aW9uUmVxdWVzdBoWLmdvb2dsZS5wcm90b2J1Zi5FbXB0eSIggtPkkwIa",
            "KhgvdjEve25hbWU9b3BlcmF0aW9ucy8qKn1CKwoWY29tLmdvb2dsZS5sb25n",
            "cnVubmluZ0IPT3BlcmF0aW9uc1Byb3RvUAFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.AnyReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, global::Google.Rpc.StatusReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Longrunning.Operation), global::Google.Longrunning.Operation.Parser, new[]{ "Name", "Metadata", "Done", "Error", "Response" }, new[]{ "Result" }, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Longrunning.GetOperationRequest), global::Google.Longrunning.GetOperationRequest.Parser, new[]{ "Name" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Longrunning.ListOperationsRequest), global::Google.Longrunning.ListOperationsRequest.Parser, new[]{ "Name", "Filter", "PageSize", "PageToken" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Longrunning.ListOperationsResponse), global::Google.Longrunning.ListOperationsResponse.Parser, new[]{ "Operations", "NextPageToken" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Longrunning.CancelOperationRequest), global::Google.Longrunning.CancelOperationRequest.Parser, new[]{ "Name" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Longrunning.DeleteOperationRequest), global::Google.Longrunning.DeleteOperationRequest.Parser, new[]{ "Name" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///  This resource represents a long-running operation that is the result of a
  ///  network API call.
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Operation : pb::IMessage<Operation> {
    private static readonly pb::MessageParser<Operation> _parser = new pb::MessageParser<Operation>(() => new Operation());
    public static pb::MessageParser<Operation> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Longrunning.OperationsReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public Operation() {
      OnConstruction();
    }

    partial void OnConstruction();

    public Operation(Operation other) : this() {
      name_ = other.name_;
      Metadata = other.metadata_ != null ? other.Metadata.Clone() : null;
      done_ = other.done_;
      switch (other.ResultCase) {
        case ResultOneofCase.Error:
          Error = other.Error.Clone();
          break;
        case ResultOneofCase.Response:
          Response = other.Response.Clone();
          break;
      }

    }

    public Operation Clone() {
      return new Operation(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    ///  The name of the operation resource, which is only unique within the same
    ///  service that originally returns it.
    /// </summary>
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "metadata" field.</summary>
    public const int MetadataFieldNumber = 2;
    private global::Google.Protobuf.WellKnownTypes.Any metadata_;
    /// <summary>
    ///  Some service-specific metadata associated with the operation.  It typically
    ///  contains progress information and common metadata such as create time.
    ///  Some services may not provide such metadata.  Any method that returns a
    ///  long-running operation should document the metadata type, if any.
    /// </summary>
    public global::Google.Protobuf.WellKnownTypes.Any Metadata {
      get { return metadata_; }
      set {
        metadata_ = value;
      }
    }

    /// <summary>Field number for the "done" field.</summary>
    public const int DoneFieldNumber = 3;
    private bool done_;
    /// <summary>
    ///  If the value is false, it means the operation is still in progress.
    ///  If true, the operation is completed and the `result` is available.
    /// </summary>
    public bool Done {
      get { return done_; }
      set {
        done_ = value;
      }
    }

    /// <summary>Field number for the "error" field.</summary>
    public const int ErrorFieldNumber = 4;
    /// <summary>
    ///  The error result of the operation in case of failure.
    /// </summary>
    public global::Google.Rpc.Status Error {
      get { return resultCase_ == ResultOneofCase.Error ? (global::Google.Rpc.Status) result_ : null; }
      set {
        result_ = value;
        resultCase_ = value == null ? ResultOneofCase.None : ResultOneofCase.Error;
      }
    }

    /// <summary>Field number for the "response" field.</summary>
    public const int ResponseFieldNumber = 5;
    /// <summary>
    ///  The normal response of the operation in case of success.  If the original
    ///  method returns no data on success, such as `Delete`, the response will be
    ///  `google.protobuf.Empty`.  If the original method is standard
    ///  `Get`/`Create`/`Update`, the response should be the resource.  For other
    ///  methods, the response should have the type `XxxResponse`, where `Xxx`
    ///  is the original method name.  For example, if the original method name
    ///  is `TakeSnapshot()`, the inferred response type will be
    ///  `TakeSnapshotResponse`.
    /// </summary>
    public global::Google.Protobuf.WellKnownTypes.Any Response {
      get { return resultCase_ == ResultOneofCase.Response ? (global::Google.Protobuf.WellKnownTypes.Any) result_ : null; }
      set {
        result_ = value;
        resultCase_ = value == null ? ResultOneofCase.None : ResultOneofCase.Response;
      }
    }

    private object result_;
    /// <summary>Enum of possible cases for the "result" oneof.</summary>
    public enum ResultOneofCase {
      None = 0,
      Error = 4,
      Response = 5,
    }
    private ResultOneofCase resultCase_ = ResultOneofCase.None;
    public ResultOneofCase ResultCase {
      get { return resultCase_; }
    }

    public void ClearResult() {
      resultCase_ = ResultOneofCase.None;
      result_ = null;
    }

    public override bool Equals(object other) {
      return Equals(other as Operation);
    }

    public bool Equals(Operation other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (!object.Equals(Metadata, other.Metadata)) return false;
      if (Done != other.Done) return false;
      if (!object.Equals(Error, other.Error)) return false;
      if (!object.Equals(Response, other.Response)) return false;
      if (ResultCase != other.ResultCase) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (metadata_ != null) hash ^= Metadata.GetHashCode();
      if (Done != false) hash ^= Done.GetHashCode();
      if (resultCase_ == ResultOneofCase.Error) hash ^= Error.GetHashCode();
      if (resultCase_ == ResultOneofCase.Response) hash ^= Response.GetHashCode();
      hash ^= (int) resultCase_;
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (metadata_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Metadata);
      }
      if (Done != false) {
        output.WriteRawTag(24);
        output.WriteBool(Done);
      }
      if (resultCase_ == ResultOneofCase.Error) {
        output.WriteRawTag(34);
        output.WriteMessage(Error);
      }
      if (resultCase_ == ResultOneofCase.Response) {
        output.WriteRawTag(42);
        output.WriteMessage(Response);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (metadata_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Metadata);
      }
      if (Done != false) {
        size += 1 + 1;
      }
      if (resultCase_ == ResultOneofCase.Error) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Error);
      }
      if (resultCase_ == ResultOneofCase.Response) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Response);
      }
      return size;
    }

    public void MergeFrom(Operation other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.metadata_ != null) {
        if (metadata_ == null) {
          metadata_ = new global::Google.Protobuf.WellKnownTypes.Any();
        }
        Metadata.MergeFrom(other.Metadata);
      }
      if (other.Done != false) {
        Done = other.Done;
      }
      switch (other.ResultCase) {
        case ResultOneofCase.Error:
          Error = other.Error;
          break;
        case ResultOneofCase.Response:
          Response = other.Response;
          break;
      }

    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            if (metadata_ == null) {
              metadata_ = new global::Google.Protobuf.WellKnownTypes.Any();
            }
            input.ReadMessage(metadata_);
            break;
          }
          case 24: {
            Done = input.ReadBool();
            break;
          }
          case 34: {
            global::Google.Rpc.Status subBuilder = new global::Google.Rpc.Status();
            if (resultCase_ == ResultOneofCase.Error) {
              subBuilder.MergeFrom(Error);
            }
            input.ReadMessage(subBuilder);
            Error = subBuilder;
            break;
          }
          case 42: {
            global::Google.Protobuf.WellKnownTypes.Any subBuilder = new global::Google.Protobuf.WellKnownTypes.Any();
            if (resultCase_ == ResultOneofCase.Response) {
              subBuilder.MergeFrom(Response);
            }
            input.ReadMessage(subBuilder);
            Response = subBuilder;
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///  The request message for [Operations.GetOperation][google.longrunning.Operations.GetOperation].
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class GetOperationRequest : pb::IMessage<GetOperationRequest> {
    private static readonly pb::MessageParser<GetOperationRequest> _parser = new pb::MessageParser<GetOperationRequest>(() => new GetOperationRequest());
    public static pb::MessageParser<GetOperationRequest> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Longrunning.OperationsReflection.Descriptor.MessageTypes[1]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public GetOperationRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    public GetOperationRequest(GetOperationRequest other) : this() {
      name_ = other.name_;
    }

    public GetOperationRequest Clone() {
      return new GetOperationRequest(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    ///  The name of the operation resource.
    /// </summary>
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    public override bool Equals(object other) {
      return Equals(other as GetOperationRequest);
    }

    public bool Equals(GetOperationRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      return size;
    }

    public void MergeFrom(GetOperationRequest other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///  The request message for [Operations.ListOperations][google.longrunning.Operations.ListOperations].
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class ListOperationsRequest : pb::IMessage<ListOperationsRequest> {
    private static readonly pb::MessageParser<ListOperationsRequest> _parser = new pb::MessageParser<ListOperationsRequest>(() => new ListOperationsRequest());
    public static pb::MessageParser<ListOperationsRequest> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Longrunning.OperationsReflection.Descriptor.MessageTypes[2]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public ListOperationsRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    public ListOperationsRequest(ListOperationsRequest other) : this() {
      name_ = other.name_;
      filter_ = other.filter_;
      pageSize_ = other.pageSize_;
      pageToken_ = other.pageToken_;
    }

    public ListOperationsRequest Clone() {
      return new ListOperationsRequest(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 4;
    private string name_ = "";
    /// <summary>
    ///  The name of the operation collection.
    /// </summary>
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "filter" field.</summary>
    public const int FilterFieldNumber = 1;
    private string filter_ = "";
    /// <summary>
    ///  The standard List filter.
    /// </summary>
    public string Filter {
      get { return filter_; }
      set {
        filter_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "page_size" field.</summary>
    public const int PageSizeFieldNumber = 2;
    private int pageSize_;
    /// <summary>
    ///  The standard List page size.
    /// </summary>
    public int PageSize {
      get { return pageSize_; }
      set {
        pageSize_ = value;
      }
    }

    /// <summary>Field number for the "page_token" field.</summary>
    public const int PageTokenFieldNumber = 3;
    private string pageToken_ = "";
    /// <summary>
    ///  The standard List page token.
    /// </summary>
    public string PageToken {
      get { return pageToken_; }
      set {
        pageToken_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    public override bool Equals(object other) {
      return Equals(other as ListOperationsRequest);
    }

    public bool Equals(ListOperationsRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Filter != other.Filter) return false;
      if (PageSize != other.PageSize) return false;
      if (PageToken != other.PageToken) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Filter.Length != 0) hash ^= Filter.GetHashCode();
      if (PageSize != 0) hash ^= PageSize.GetHashCode();
      if (PageToken.Length != 0) hash ^= PageToken.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Filter.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Filter);
      }
      if (PageSize != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(PageSize);
      }
      if (PageToken.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(PageToken);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Name);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Filter.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Filter);
      }
      if (PageSize != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(PageSize);
      }
      if (PageToken.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PageToken);
      }
      return size;
    }

    public void MergeFrom(ListOperationsRequest other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Filter.Length != 0) {
        Filter = other.Filter;
      }
      if (other.PageSize != 0) {
        PageSize = other.PageSize;
      }
      if (other.PageToken.Length != 0) {
        PageToken = other.PageToken;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Filter = input.ReadString();
            break;
          }
          case 16: {
            PageSize = input.ReadInt32();
            break;
          }
          case 26: {
            PageToken = input.ReadString();
            break;
          }
          case 34: {
            Name = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///  The response message for [Operations.ListOperations][google.longrunning.Operations.ListOperations].
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class ListOperationsResponse : pb::IMessage<ListOperationsResponse> {
    private static readonly pb::MessageParser<ListOperationsResponse> _parser = new pb::MessageParser<ListOperationsResponse>(() => new ListOperationsResponse());
    public static pb::MessageParser<ListOperationsResponse> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Longrunning.OperationsReflection.Descriptor.MessageTypes[3]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public ListOperationsResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    public ListOperationsResponse(ListOperationsResponse other) : this() {
      operations_ = other.operations_.Clone();
      nextPageToken_ = other.nextPageToken_;
    }

    public ListOperationsResponse Clone() {
      return new ListOperationsResponse(this);
    }

    /// <summary>Field number for the "operations" field.</summary>
    public const int OperationsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Google.Longrunning.Operation> _repeated_operations_codec
        = pb::FieldCodec.ForMessage(10, global::Google.Longrunning.Operation.Parser);
    private readonly pbc::RepeatedField<global::Google.Longrunning.Operation> operations_ = new pbc::RepeatedField<global::Google.Longrunning.Operation>();
    /// <summary>
    ///  A list of operations that match the specified filter in the request.
    /// </summary>
    public pbc::RepeatedField<global::Google.Longrunning.Operation> Operations {
      get { return operations_; }
    }

    /// <summary>Field number for the "next_page_token" field.</summary>
    public const int NextPageTokenFieldNumber = 2;
    private string nextPageToken_ = "";
    /// <summary>
    ///  The standard List next-page token.
    /// </summary>
    public string NextPageToken {
      get { return nextPageToken_; }
      set {
        nextPageToken_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    public override bool Equals(object other) {
      return Equals(other as ListOperationsResponse);
    }

    public bool Equals(ListOperationsResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!operations_.Equals(other.operations_)) return false;
      if (NextPageToken != other.NextPageToken) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      hash ^= operations_.GetHashCode();
      if (NextPageToken.Length != 0) hash ^= NextPageToken.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      operations_.WriteTo(output, _repeated_operations_codec);
      if (NextPageToken.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(NextPageToken);
      }
    }

    public int CalculateSize() {
      int size = 0;
      size += operations_.CalculateSize(_repeated_operations_codec);
      if (NextPageToken.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(NextPageToken);
      }
      return size;
    }

    public void MergeFrom(ListOperationsResponse other) {
      if (other == null) {
        return;
      }
      operations_.Add(other.operations_);
      if (other.NextPageToken.Length != 0) {
        NextPageToken = other.NextPageToken;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            operations_.AddEntriesFrom(input, _repeated_operations_codec);
            break;
          }
          case 18: {
            NextPageToken = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///  The request message for [Operations.CancelOperation][google.longrunning.Operations.CancelOperation].
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class CancelOperationRequest : pb::IMessage<CancelOperationRequest> {
    private static readonly pb::MessageParser<CancelOperationRequest> _parser = new pb::MessageParser<CancelOperationRequest>(() => new CancelOperationRequest());
    public static pb::MessageParser<CancelOperationRequest> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Longrunning.OperationsReflection.Descriptor.MessageTypes[4]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public CancelOperationRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    public CancelOperationRequest(CancelOperationRequest other) : this() {
      name_ = other.name_;
    }

    public CancelOperationRequest Clone() {
      return new CancelOperationRequest(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    ///  The name of the operation resource to be cancelled.
    /// </summary>
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    public override bool Equals(object other) {
      return Equals(other as CancelOperationRequest);
    }

    public bool Equals(CancelOperationRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      return size;
    }

    public void MergeFrom(CancelOperationRequest other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///  The request message for [Operations.DeleteOperation][google.longrunning.Operations.DeleteOperation].
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class DeleteOperationRequest : pb::IMessage<DeleteOperationRequest> {
    private static readonly pb::MessageParser<DeleteOperationRequest> _parser = new pb::MessageParser<DeleteOperationRequest>(() => new DeleteOperationRequest());
    public static pb::MessageParser<DeleteOperationRequest> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Longrunning.OperationsReflection.Descriptor.MessageTypes[5]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public DeleteOperationRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    public DeleteOperationRequest(DeleteOperationRequest other) : this() {
      name_ = other.name_;
    }

    public DeleteOperationRequest Clone() {
      return new DeleteOperationRequest(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    ///  The name of the operation resource to be deleted.
    /// </summary>
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    public override bool Equals(object other) {
      return Equals(other as DeleteOperationRequest);
    }

    public bool Equals(DeleteOperationRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      return size;
    }

    public void MergeFrom(DeleteOperationRequest other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
