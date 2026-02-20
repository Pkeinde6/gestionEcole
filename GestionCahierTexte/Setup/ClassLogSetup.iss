; =============================================
; ClassLog - Script d'installation Inno Setup
; =============================================

#define MyAppName "ClassLog"
#define MyAppVersion "1.0.0"
#define MyAppPublisher "ClassLog"
#define MyAppURL "https://classlog.com"
#define MyAppExeName "ClassLog.exe"
#define MyAppOutputDir "..\Output"
#define MyAppSourceDir "..\AppGestionCahierTexte\bin\Debug"

[Setup]
AppId={{A1B2C3D4-E5F6-7890-ABCD-EF1234567890}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={autopf}\{#MyAppName}
DefaultGroupName={#MyAppName}
AllowNoIcons=yes
OutputDir={#MyAppOutputDir}
OutputBaseFilename=ClassLog_Setup_v{#MyAppVersion}
SetupIconFile={#MyAppSourceDir}\icone app.ico
UninstallDisplayIcon={app}\{#MyAppExeName}
Compression=lzma2/ultra64
SolidCompression=yes
WizardStyle=modern
PrivilegesRequired=admin
ArchitecturesAllowed=x64compatible
ArchitecturesInstallIn64BitMode=x64compatible
DisableProgramGroupPage=yes
LicenseFile=
InfoBeforeFile=
InfoAfterFile=

; Style moderne

[Languages]
Name: "french"; MessagesFile: "compiler:Languages\French.isl"
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"
Name: "quicklaunchicon"; Description: "{cm:CreateQuickLaunchIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
; Exe principal
Source: "{#MyAppSourceDir}\ClassLog.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#MyAppSourceDir}\ClassLog.exe.config"; DestDir: "{app}"; Flags: ignoreversion

; Icone
Source: "{#MyAppSourceDir}\icone app.ico"; DestDir: "{app}"; Flags: ignoreversion

; DLLs Entity Framework
Source: "{#MyAppSourceDir}\EntityFramework.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#MyAppSourceDir}\EntityFramework.SqlServer.dll"; DestDir: "{app}"; Flags: ignoreversion

; DLLs MySQL
Source: "{#MyAppSourceDir}\MySql.Data.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#MyAppSourceDir}\MySql.Data.EntityFramework.dll"; DestDir: "{app}"; Flags: ignoreversion

; DLLs Crypto
Source: "{#MyAppSourceDir}\BouncyCastle.Cryptography.dll"; DestDir: "{app}"; Flags: ignoreversion

; DLLs Google Protobuf
Source: "{#MyAppSourceDir}\Google.Protobuf.dll"; DestDir: "{app}"; Flags: ignoreversion

; DLLs Compression
Source: "{#MyAppSourceDir}\K4os.Compression.LZ4.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#MyAppSourceDir}\K4os.Compression.LZ4.Streams.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#MyAppSourceDir}\K4os.Hash.xxHash.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#MyAppSourceDir}\ZstdSharp.dll"; DestDir: "{app}"; Flags: ignoreversion

; DLLs System
Source: "{#MyAppSourceDir}\Microsoft.Bcl.AsyncInterfaces.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#MyAppSourceDir}\System.Buffers.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#MyAppSourceDir}\System.Configuration.ConfigurationManager.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#MyAppSourceDir}\System.IO.Pipelines.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#MyAppSourceDir}\System.Memory.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#MyAppSourceDir}\System.Numerics.Vectors.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#MyAppSourceDir}\System.Runtime.CompilerServices.Unsafe.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#MyAppSourceDir}\System.Threading.Tasks.Extensions.dll"; DestDir: "{app}"; Flags: ignoreversion

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; IconFilename: "{app}\icone app.ico"
Name: "{group}\Desinstaller {#MyAppName}"; Filename: "{uninstallexe}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; IconFilename: "{app}\icone app.ico"; Tasks: desktopicon
Name: "{userappdata}\Microsoft\Internet Explorer\Quick Launch\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: quicklaunchicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

[Code]
// Vérifier que .NET Framework 4.8 est installé
function IsDotNetInstalled(): Boolean;
var
  release: Cardinal;
begin
  Result := RegQueryDWordValue(HKLM, 'SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full', 'Release', release);
  // 528040 = .NET Framework 4.8
  Result := Result and (release >= 528040);
end;

function InitializeSetup(): Boolean;
begin
  Result := True;
  if not IsDotNetInstalled() then
  begin
    MsgBox('ClassLog nécessite .NET Framework 4.8 ou supérieur.' + #13#10 + #13#10 +
           'Veuillez installer .NET Framework 4.8 depuis le site Microsoft avant de continuer.', mbCriticalError, MB_OK);
    Result := False;
  end;
end;
