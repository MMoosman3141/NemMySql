using MySql.Data.MySqlClient;
using NemDbCore;
using System;
using System.Collections.Generic;
using System.Text;
using NemEncryption.Extensions;
using NemMvvm;

namespace NemMySql {
  public class DbMySqlServerSettings : DbSettings {
    private MySqlConnectionStringBuilder _strBuilder;

    public override string ConnectionString {
      get => _strBuilder.ConnectionString;
    }

    public bool AllowPublicKeyRetrieval {
      get => _strBuilder.AllowPublicKeyRetrieval;
      set {
        _strBuilder.AllowPublicKeyRetrieval = value;
        RaisePropertyChanged(nameof(AllowPublicKeyRetrieval));
      }
    }
    public bool AllowUserVariables {
      get => _strBuilder.AllowUserVariables;
      set {
        _strBuilder.AllowUserVariables = value;
        RaisePropertyChanged(nameof(AllowUserVariables));
      }
    }
    public bool AllowZeroDateTime {
      get => _strBuilder.AllowZeroDateTime;
      set {
        _strBuilder.AllowZeroDateTime = value;
        RaisePropertyChanged(nameof(AllowZeroDateTime));
      }
    }
    public string ApplicationName {
      get => _strBuilder.ApplicationName;
      set {
        _strBuilder.ApplicationName = value;
        RaisePropertyChanged(nameof(ApplicationName));
      }
    }
    public bool AutoEnlist {
      get => _strBuilder.AutoEnlist;
      set {
        _strBuilder.AutoEnlist = value;
        RaisePropertyChanged(nameof(AutoEnlist));
      }
    }
    public string CACertificateFile {
      get => _strBuilder.CACertificateFile;
      set {
        _strBuilder.CACertificateFile = value;
        RaisePropertyChanged(nameof(CACertificateFile));
      }
    }
    public string CertificateFile {
      get => _strBuilder.CertificateFile;
      set {
        _strBuilder.CertificateFile = value;
        RaisePropertyChanged(nameof(CertificateFile));
      }
    }
    public string CertificatePassword {
      get => _strBuilder.CertificatePassword;
      set {
        _strBuilder.CertificatePassword = value;
        RaisePropertyChanged(nameof(CertificatePassword));
      }
    }
    public MySqlCertificateStoreLocation CertificateStoreLocation {
      get => _strBuilder.CertificateStoreLocation;
      set {
        _strBuilder.CertificateStoreLocation = value;
        RaisePropertyChanged(nameof(CertificateStoreLocation));
      }
    }
    public string CertificateThumbprint {
      get => _strBuilder.CertificateThumbprint;
      set {
        _strBuilder.CertificateThumbprint = value;
        RaisePropertyChanged(nameof(CertificateThumbprint));
      }
    }
    public string CharacterSet {
      get => _strBuilder.CharacterSet;
      set {
        _strBuilder.CharacterSet = value;
        RaisePropertyChanged(nameof(CharacterSet));
      }
    }
    public uint ConnectionIdlePingTime {
      get => _strBuilder.ConnectionIdlePingTime;
      set {
        _strBuilder.ConnectionIdlePingTime = value;
        RaisePropertyChanged(nameof(ConnectionIdlePingTime));
      }
    }
    public uint ConnectionIdleTimeout {
      get => _strBuilder.ConnectionIdleTimeout;
      set {
        _strBuilder.ConnectionIdleTimeout = value;
        RaisePropertyChanged(nameof(ConnectionIdleTimeout));
      }
    }
    public uint ConnectionLifeTime {
      get => _strBuilder.ConnectionLifeTime;
      set {
        _strBuilder.ConnectionLifeTime = value;
        RaisePropertyChanged(nameof(ConnectionLifeTime));
      }
    }
    public MySqlConnectionProtocol ConnectionProtocol {
      get => _strBuilder.ConnectionProtocol;
      set {
        _strBuilder.ConnectionProtocol = value;
        RaisePropertyChanged(nameof(ConnectionProtocol));
      }
    }
    public bool ConnectionReset {
      get => _strBuilder.ConnectionReset;
      set {
        _strBuilder.ConnectionReset = value;
        RaisePropertyChanged(nameof(ConnectionReset));
      }
    }
    public uint ConnectionTimeout {
      get => _strBuilder.ConnectionTimeout;
      set {
        _strBuilder.ConnectionTimeout = value;
        RaisePropertyChanged(nameof(ConnectionTimeout));
      }
    }
    public bool ConvertZeroDateTime {
      get => _strBuilder.ConvertZeroDateTime;
      set {
        _strBuilder.ConvertZeroDateTime = value;
        RaisePropertyChanged(nameof(ConvertZeroDateTime));
      }
    }
    public string Database {
      get => _strBuilder.Database;
      set {
        _strBuilder.Database = value;
        RaisePropertyChanged(nameof(Database));
      }
    }
    public MySqlDateTimeKind DateTimeKind {
      get => _strBuilder.DateTimeKind;
      set {
        _strBuilder.DateTimeKind = value;
        RaisePropertyChanged(nameof(DateTimeKind));
      }
    }
    public uint DefaultCommandTimeout {
      get => _strBuilder.DefaultCommandTimeout;
      set {
        _strBuilder.DefaultCommandTimeout = value;
        RaisePropertyChanged(nameof(DefaultCommandTimeout));
      }
    }
    public bool ForceSynchronous {
      get => _strBuilder.ForceSynchronous;
      set {
        _strBuilder.ForceSynchronous = value;
        RaisePropertyChanged(nameof(ForceSynchronous));
      }
    }
    public MySqlGuidFormat GuidFormat {
      get => _strBuilder.GuidFormat;
      set {
        _strBuilder.GuidFormat = value;
        RaisePropertyChanged(nameof(GuidFormat));
      }
    }
    public bool IgnoreCommandTransaction {
      get => _strBuilder.IgnoreCommandTransaction;
      set {
        _strBuilder.IgnoreCommandTransaction = value;
        RaisePropertyChanged(nameof(IgnoreCommandTransaction));
      }
    }
    public bool IgnorePrepare {
      get => _strBuilder.IgnorePrepare;
      set {
        _strBuilder.IgnorePrepare = value;
        RaisePropertyChanged(nameof(IgnorePrepare));
      }
    }
    public bool InteractiveSession {
      get => _strBuilder.InteractiveSession;
      set {
        _strBuilder.InteractiveSession = value;
        RaisePropertyChanged(nameof(InteractiveSession));
      }
    }
    public bool IsFixedSize {
      get => _strBuilder.IsFixedSize;
    }
    public bool IsReadOnly {
      get => _strBuilder.IsReadOnly;
    }
    public uint Keepalive {
      get => _strBuilder.Keepalive;
      set {
        _strBuilder.Keepalive = value;
        RaisePropertyChanged(nameof(Keepalive));
      }
    }
    public MySqlLoadBalance LoadBalance {
      get => _strBuilder.LoadBalance;
      set {
        _strBuilder.LoadBalance = value;
        RaisePropertyChanged(nameof(LoadBalance));
      }
    }
    public uint MaximumPoolSize {
      get => _strBuilder.MaximumPoolSize;
      set {
        _strBuilder.MaximumPoolSize = value;
        RaisePropertyChanged(nameof(MaximumPoolSize));
      }
    }
    public uint MinimumPoolSize {
      get => _strBuilder.MinimumPoolSize;
      set {
        _strBuilder.MinimumPoolSize = value;
        RaisePropertyChanged(nameof(MinimumPoolSize));
      }
    }
    public bool OldGuids {
      get => _strBuilder.OldGuids;
      set {
        _strBuilder.OldGuids = value;
        RaisePropertyChanged(nameof(OldGuids));
      }
    }
    public bool PersistSecurityInfo {
      get => _strBuilder.PersistSecurityInfo;
      set {
        _strBuilder.PersistSecurityInfo = value;
        RaisePropertyChanged(nameof(PersistSecurityInfo));
      }
    }
    public string PipeName {
      get => _strBuilder.PipeName;
      set {
        _strBuilder.PipeName = value;
        RaisePropertyChanged(nameof(PipeName));
      }
    }
    public bool Pooling {
      get => _strBuilder.Pooling;
      set {
        _strBuilder.Pooling = value;
        RaisePropertyChanged(nameof(Pooling));
      }
    }
    public uint Port {
      get => _strBuilder.Port;
      set {
        _strBuilder.Port = value;
        RaisePropertyChanged(nameof(Port));
      }
    }
    public string Server {
      get => _strBuilder.Server;
      set {
        _strBuilder.Server = value;
        RaisePropertyChanged(nameof(Server));
      }
    }
    public string ServerRsaPublicKeyFile {
      get => _strBuilder.ServerRsaPublicKeyFile;
      set {
        _strBuilder.ServerRsaPublicKeyFile = value;
        RaisePropertyChanged(nameof(ServerRsaPublicKeyFile));
      }
    }
    public string ServerSPN {
      get => _strBuilder.ServerSPN;
      set {
        _strBuilder.ServerSPN = value;
        RaisePropertyChanged(nameof(ServerSPN));
      }
    }
    public MySqlSslMode SslMode {
      get => _strBuilder.SslMode;
      set {
        _strBuilder.SslMode = value;
        RaisePropertyChanged(nameof(SslMode));
      }
    }
    public bool TreatTinyAsBoolean {
      get => _strBuilder.TreatTinyAsBoolean;
      set {
        _strBuilder.TreatTinyAsBoolean = value;
        RaisePropertyChanged(nameof(TreatTinyAsBoolean));
      }
    }
    public bool UseAffectedRows {
      get => _strBuilder.UseAffectedRows;
      set {
        _strBuilder.UseAffectedRows = value;
        RaisePropertyChanged(nameof(UseAffectedRows));
      }
    }
    public bool UseCompression {
      get => _strBuilder.UseCompression;
      set {
        _strBuilder.UseCompression = value;
        RaisePropertyChanged(nameof(UseCompression));
      }
    }
    public string UserID {
      get => _strBuilder.UserID;
      set {
        _strBuilder.UserID = value;
        RaisePropertyChanged(nameof(UserID));
      }
    }
    public bool UseXaTransactions {
      get => _strBuilder.UseXaTransactions;
      set {
        _strBuilder.UseXaTransactions = value;
        RaisePropertyChanged(nameof(UseXaTransactions));
      }
    }

    public string GetConnectionStringWithPassword() {
      _strBuilder.Password = SecurePassword.ToUnsecureString();
      string connectionString = ConnectionString;
      _strBuilder.Password = "";
      return connectionString;
    }

    public DbMySqlServerSettings() {
      _strBuilder = new MySqlConnectionStringBuilder();

      

    }


  }
}
