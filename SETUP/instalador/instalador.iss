[Files]
Source: DADOS.FDB; DestDir: {app}\dados
Source: e-Imobi.exe; DestDir: {app}
Source: Firebird-2.0.3.12981-1-Win32.exe; DestDir: {tmp}; Flags: deleteafterinstall
Source: FirebirdDEXProvider-2.0.2.exe; DestDir: {tmp}; Flags: deleteafterinstall
[Run]
Filename: {tmp}\Firebird-2.0.3.12981-1-Win32.exe; Parameters: /SILENT; WorkingDir: {tmp}; StatusMsg: Instalando o Firebird Cliente; Flags: waituntilidle hidewizard postinstall
Filename: {tmp}\FirebirdDEXProvider-2.0.2.exe; Parameters: /SILENT; WorkingDir: {tmp}; StatusMsg: Instalando o Firebird DEX Provider; Flags: waituntilidle runhidden postinstall
[Icons]
Name: {userprograms}\AL Software\E-Imobi - Controle Imobiliario; Filename: {app}\e-Imobi.exe; IconIndex: 0
Name: {userdesktop}\E-Imobi - Controle Imobiliario; Filename: {app}\e-Imobi.exe
Name: {userprograms}\AL Software\Desinstalador\Desinstalar o E-Imobi; Filename: {uninstallexe}
[Setup]
AppCopyright=AL Software
AppName=E-Imobi
AppVerName=1.0.0.0
LicenseFile=licenca.rtf
ShowLanguageDialog=no
SetupIconFile=e-imobi.ico
AppPublisherURL=www.alsofthouse.com.br
AppSupportURL=AL Software - Fone: 69 3534-2093
AppSupportPhone=69 9975-0504
DefaultDirName={pf}\AL Software\E-Imobi
OutputBaseFilename=Instalador E-Imobi
VersionInfoVersion=1.0
VersionInfoCompany=AL Software
VersionInfoDescription=Controle de Imobiliaria
VersionInfoCopyright=AL Software
DisableProgramGroupPage=true
[Languages]
Name: pt; MessagesFile: compiler:Languages\BrazilianPortuguese.isl
[INI]
Filename: {app}\bd.ini; Section: ALSoftware; Key: banco; String: {app}\Dados\DADOS.FDB
Filename: {app}\bd.ini; Section: ALSoftware; Key: server; String: localhost
Filename: {app}\bdFirebirdSql.ini; Section: ALSoftware; Key: DI; String: 
Filename: {app}\bdFirebirdSql.ini; Section: ALSoftware; Key: DF; String: 
Filename: {app}\bdFirebirdSql.ini; Section: ALSoftware; Key: C; String: 
Filename: {app}\bdFirebirdSql.ini; Section: ALSoftware; Key: C2; String: 
Filename: {app}\bdFirebirdSql.ini; Section: ALSoftware; Key: A; String: 
[UninstallDelete]
Name: {app}\bd.ini; Type: files
Name: {app}\bdFirebirdSql.ini; Type: files
