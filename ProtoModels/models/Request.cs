// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: schemas/request.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
public static partial class Request {

  #region Descriptor
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static Request() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChVzY2hlbWFzL3JlcXVlc3QucHJvdG8iiQEKDVNlYXJjaFJlcXVlc3QSDQoF", 
          "cXVlcnkYASABKAkSEwoLcGFnZV9udW1iZXIYAiABKAUSFwoPcmVzdWx0X3Bl", 
          "cl9wYWdlGAMgASgFEgwKBG5hbWUYBCABKAkSEQoJbGFzdF9uYW1lGAUgASgJ", 
          "EgsKA2FnZRgKIAEoBRINCgVvdGhlchgPIAEoBWIGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.InternalBuildGeneratedFileFrom(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedCodeInfo(null, new pbr::GeneratedCodeInfo[] {
          new pbr::GeneratedCodeInfo(typeof(global::SearchRequest), new[]{ "Query", "PageNumber", "ResultPerPage", "Name", "LastName", "Age", "Other" }, null, null, null)
        }));
  }
  #endregion

}
#region Messages
[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
public sealed partial class SearchRequest : pb::IMessage<SearchRequest> {
  private static readonly pb::MessageParser<SearchRequest> _parser = new pb::MessageParser<SearchRequest>(() => new SearchRequest());
  public static pb::MessageParser<SearchRequest> Parser { get { return _parser; } }

  public static pbr::MessageDescriptor Descriptor {
    get { return global::Request.Descriptor.MessageTypes[0]; }
  }

  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  public SearchRequest() {
    OnConstruction();
  }

  partial void OnConstruction();

  public SearchRequest(SearchRequest other) : this() {
    query_ = other.query_;
    pageNumber_ = other.pageNumber_;
    resultPerPage_ = other.resultPerPage_;
    name_ = other.name_;
    lastName_ = other.lastName_;
    age_ = other.age_;
    other_ = other.other_;
  }

  public SearchRequest Clone() {
    return new SearchRequest(this);
  }

  public const int QueryFieldNumber = 1;
  private string query_ = "";
  public string Query {
    get { return query_; }
    set {
      query_ = pb::Preconditions.CheckNotNull(value, "value");
    }
  }

  public const int PageNumberFieldNumber = 2;
  private int pageNumber_;
  public int PageNumber {
    get { return pageNumber_; }
    set {
      pageNumber_ = value;
    }
  }

  public const int ResultPerPageFieldNumber = 3;
  private int resultPerPage_;
  public int ResultPerPage {
    get { return resultPerPage_; }
    set {
      resultPerPage_ = value;
    }
  }

  public const int NameFieldNumber = 4;
  private string name_ = "";
  public string Name {
    get { return name_; }
    set {
      name_ = pb::Preconditions.CheckNotNull(value, "value");
    }
  }

  public const int LastNameFieldNumber = 5;
  private string lastName_ = "";
  public string LastName {
    get { return lastName_; }
    set {
      lastName_ = pb::Preconditions.CheckNotNull(value, "value");
    }
  }

  public const int AgeFieldNumber = 10;
  private int age_;
  public int Age {
    get { return age_; }
    set {
      age_ = value;
    }
  }

  public const int OtherFieldNumber = 15;
  private int other_;
  public int Other {
    get { return other_; }
    set {
      other_ = value;
    }
  }

  public override bool Equals(object other) {
    return Equals(other as SearchRequest);
  }

  public bool Equals(SearchRequest other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Query != other.Query) return false;
    if (PageNumber != other.PageNumber) return false;
    if (ResultPerPage != other.ResultPerPage) return false;
    if (Name != other.Name) return false;
    if (LastName != other.LastName) return false;
    if (Age != other.Age) return false;
    if (Other != other.Other) return false;
    return true;
  }

  public override int GetHashCode() {
    int hash = 1;
    if (Query.Length != 0) hash ^= Query.GetHashCode();
    if (PageNumber != 0) hash ^= PageNumber.GetHashCode();
    if (ResultPerPage != 0) hash ^= ResultPerPage.GetHashCode();
    if (Name.Length != 0) hash ^= Name.GetHashCode();
    if (LastName.Length != 0) hash ^= LastName.GetHashCode();
    if (Age != 0) hash ^= Age.GetHashCode();
    if (Other != 0) hash ^= Other.GetHashCode();
    return hash;
  }

  public override string ToString() {
    return pb::JsonFormatter.Default.Format(this);
  }

  public void WriteTo(pb::CodedOutputStream output) {
    if (Query.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(Query);
    }
    if (PageNumber != 0) {
      output.WriteRawTag(16);
      output.WriteInt32(PageNumber);
    }
    if (ResultPerPage != 0) {
      output.WriteRawTag(24);
      output.WriteInt32(ResultPerPage);
    }
    if (Name.Length != 0) {
      output.WriteRawTag(34);
      output.WriteString(Name);
    }
    if (LastName.Length != 0) {
      output.WriteRawTag(42);
      output.WriteString(LastName);
    }
    if (Age != 0) {
      output.WriteRawTag(80);
      output.WriteInt32(Age);
    }
    if (Other != 0) {
      output.WriteRawTag(120);
      output.WriteInt32(Other);
    }
  }

  public int CalculateSize() {
    int size = 0;
    if (Query.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Query);
    }
    if (PageNumber != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(PageNumber);
    }
    if (ResultPerPage != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(ResultPerPage);
    }
    if (Name.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
    }
    if (LastName.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(LastName);
    }
    if (Age != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Age);
    }
    if (Other != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Other);
    }
    return size;
  }

  public void MergeFrom(SearchRequest other) {
    if (other == null) {
      return;
    }
    if (other.Query.Length != 0) {
      Query = other.Query;
    }
    if (other.PageNumber != 0) {
      PageNumber = other.PageNumber;
    }
    if (other.ResultPerPage != 0) {
      ResultPerPage = other.ResultPerPage;
    }
    if (other.Name.Length != 0) {
      Name = other.Name;
    }
    if (other.LastName.Length != 0) {
      LastName = other.LastName;
    }
    if (other.Age != 0) {
      Age = other.Age;
    }
    if (other.Other != 0) {
      Other = other.Other;
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
          Query = input.ReadString();
          break;
        }
        case 16: {
          PageNumber = input.ReadInt32();
          break;
        }
        case 24: {
          ResultPerPage = input.ReadInt32();
          break;
        }
        case 34: {
          Name = input.ReadString();
          break;
        }
        case 42: {
          LastName = input.ReadString();
          break;
        }
        case 80: {
          Age = input.ReadInt32();
          break;
        }
        case 120: {
          Other = input.ReadInt32();
          break;
        }
      }
    }
  }

}

#endregion


#endregion Designer generated code
