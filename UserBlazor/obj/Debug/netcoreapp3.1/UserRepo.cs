// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/UserRepo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace UserServices {

  /// <summary>Holder for reflection information generated from Protos/UserRepo.proto</summary>
  public static partial class UserRepoReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/UserRepo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UserRepoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVQcm90b3MvVXNlclJlcG8ucHJvdG8SBVVzZXJzIgkKB05vdGhpbmciOwoE",
            "VXNlchIOCgZVc2VySWQYASABKAUSEAoIVXNlck5hbWUYAiABKAkSEQoJVXNl",
            "ckVNYWlsGAMgASgJIiUKBVVzZXJzEhwKB3JlY29yZHMYASADKAsyCy5Vc2Vy",
            "cy5Vc2VyIhwKClVzZXJGaWx0ZXISDgoGVXNlcklkGAEgASgFMtUBCghVc2Vy",
            "UmVwbxIiCgNBZGQSCy5Vc2Vycy5Vc2VyGg4uVXNlcnMuTm90aGluZxIlCgZV",
            "cGRhdGUSCy5Vc2Vycy5Vc2VyGg4uVXNlcnMuTm90aGluZxIrCgZEZWxldGUS",
            "ES5Vc2Vycy5Vc2VyRmlsdGVyGg4uVXNlcnMuTm90aGluZxImCgZHZXRBbGwS",
            "Di5Vc2Vycy5Ob3RoaW5nGgwuVXNlcnMuVXNlcnMSKQoHR2V0QnlJZBIRLlVz",
            "ZXJzLlVzZXJGaWx0ZXIaCy5Vc2Vycy5Vc2VyQg+qAgxVc2VyU2VydmljZXNi",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::UserServices.Nothing), global::UserServices.Nothing.Parser, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::UserServices.User), global::UserServices.User.Parser, new[]{ "UserId", "UserName", "UserEMail" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::UserServices.Users), global::UserServices.Users.Parser, new[]{ "Records" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::UserServices.UserFilter), global::UserServices.UserFilter.Parser, new[]{ "UserId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Definicion de Mensaje con respuesta "vacia".
  /// </summary>
  public sealed partial class Nothing : pb::IMessage<Nothing> {
    private static readonly pb::MessageParser<Nothing> _parser = new pb::MessageParser<Nothing>(() => new Nothing());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Nothing> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::UserServices.UserRepoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Nothing() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Nothing(Nothing other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Nothing Clone() {
      return new Nothing(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Nothing);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Nothing other) {
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
    public void MergeFrom(Nothing other) {
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

  }

  /// <summary>
  /// Definicion de Mensaje de tipo User.
  /// </summary>
  public sealed partial class User : pb::IMessage<User> {
    private static readonly pb::MessageParser<User> _parser = new pb::MessageParser<User>(() => new User());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<User> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::UserServices.UserRepoReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public User() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public User(User other) : this() {
      userId_ = other.userId_;
      userName_ = other.userName_;
      userEMail_ = other.userEMail_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public User Clone() {
      return new User(this);
    }

    /// <summary>Field number for the "UserId" field.</summary>
    public const int UserIdFieldNumber = 1;
    private int userId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int UserId {
      get { return userId_; }
      set {
        userId_ = value;
      }
    }

    /// <summary>Field number for the "UserName" field.</summary>
    public const int UserNameFieldNumber = 2;
    private string userName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string UserName {
      get { return userName_; }
      set {
        userName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "UserEMail" field.</summary>
    public const int UserEMailFieldNumber = 3;
    private string userEMail_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string UserEMail {
      get { return userEMail_; }
      set {
        userEMail_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as User);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(User other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (UserId != other.UserId) return false;
      if (UserName != other.UserName) return false;
      if (UserEMail != other.UserEMail) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (UserId != 0) hash ^= UserId.GetHashCode();
      if (UserName.Length != 0) hash ^= UserName.GetHashCode();
      if (UserEMail.Length != 0) hash ^= UserEMail.GetHashCode();
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
      if (UserId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(UserId);
      }
      if (UserName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(UserName);
      }
      if (UserEMail.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(UserEMail);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (UserId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(UserId);
      }
      if (UserName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(UserName);
      }
      if (UserEMail.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(UserEMail);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(User other) {
      if (other == null) {
        return;
      }
      if (other.UserId != 0) {
        UserId = other.UserId;
      }
      if (other.UserName.Length != 0) {
        UserName = other.UserName;
      }
      if (other.UserEMail.Length != 0) {
        UserEMail = other.UserEMail;
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
          case 8: {
            UserId = input.ReadInt32();
            break;
          }
          case 18: {
            UserName = input.ReadString();
            break;
          }
          case 26: {
            UserEMail = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Definicion de Mensaje de tipo Users.
  /// </summary>
  public sealed partial class Users : pb::IMessage<Users> {
    private static readonly pb::MessageParser<Users> _parser = new pb::MessageParser<Users>(() => new Users());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Users> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::UserServices.UserRepoReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Users() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Users(Users other) : this() {
      records_ = other.records_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Users Clone() {
      return new Users(this);
    }

    /// <summary>Field number for the "records" field.</summary>
    public const int RecordsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::UserServices.User> _repeated_records_codec
        = pb::FieldCodec.ForMessage(10, global::UserServices.User.Parser);
    private readonly pbc::RepeatedField<global::UserServices.User> records_ = new pbc::RepeatedField<global::UserServices.User>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::UserServices.User> Records {
      get { return records_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Users);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Users other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!records_.Equals(other.records_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= records_.GetHashCode();
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
      records_.WriteTo(output, _repeated_records_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += records_.CalculateSize(_repeated_records_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Users other) {
      if (other == null) {
        return;
      }
      records_.Add(other.records_);
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
            records_.AddEntriesFrom(input, _repeated_records_codec);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Definicion de Mensaje de tipo UserFilter que nos sirve como filtro de busqueda de Usuarios.
  /// </summary>
  public sealed partial class UserFilter : pb::IMessage<UserFilter> {
    private static readonly pb::MessageParser<UserFilter> _parser = new pb::MessageParser<UserFilter>(() => new UserFilter());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UserFilter> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::UserServices.UserRepoReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserFilter() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserFilter(UserFilter other) : this() {
      userId_ = other.userId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserFilter Clone() {
      return new UserFilter(this);
    }

    /// <summary>Field number for the "UserId" field.</summary>
    public const int UserIdFieldNumber = 1;
    private int userId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int UserId {
      get { return userId_; }
      set {
        userId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UserFilter);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UserFilter other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (UserId != other.UserId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (UserId != 0) hash ^= UserId.GetHashCode();
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
      if (UserId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(UserId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (UserId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(UserId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(UserFilter other) {
      if (other == null) {
        return;
      }
      if (other.UserId != 0) {
        UserId = other.UserId;
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
          case 8: {
            UserId = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
