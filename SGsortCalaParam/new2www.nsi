; Script generated by the HM NIS Edit Script Wizard.

; HM NIS Edit Wizard helper defines
!define PRODUCT_NAME "三维地震勘探施工组织管理系统"
!define PRODUCT_VERSION "1.0"
!define PRODUCT_PUBLISHER "Neplite, Inc."
!define PRODUCT_WEB_SITE "http://www.neplite.com"
!define PRODUCT_DIR_REGKEY "Software\Microsoft\Windows\CurrentVersion\App Paths\SGsortCalaParam.exe"
!define PRODUCT_UNINST_KEY "Software\Microsoft\Windows\CurrentVersion\Uninstall\${PRODUCT_NAME}"
!define PRODUCT_UNINST_ROOT_KEY "HKLM"
!define PRODUCT_STARTMENU_REGVAL "NSIS:StartMenuDir"

; MUI 1.67 compatible ------
!include "MUI.nsh"

; MUI Settings
!define MUI_ABORTWARNING
!define MUI_ICON "1.ico"
!define MUI_UNICON "${NSISDIR}\Contrib\Graphics\Icons\modern-uninstall.ico"

; Language Selection Dialog Settings
!define MUI_LANGDLL_REGISTRY_ROOT "${PRODUCT_UNINST_ROOT_KEY}"
!define MUI_LANGDLL_REGISTRY_KEY "${PRODUCT_UNINST_KEY}"
!define MUI_LANGDLL_REGISTRY_VALUENAME "NSIS:Language"

; Welcome page
!insertmacro MUI_PAGE_WELCOME
; License page
; Directory page
!insertmacro MUI_PAGE_DIRECTORY
; Start menu page
var ICONS_GROUP
!define MUI_STARTMENUPAGE_NODISABLE
!define MUI_STARTMENUPAGE_DEFAULTFOLDER "三维地震勘探施工组织管理系统"
!define MUI_STARTMENUPAGE_REGISTRY_ROOT "${PRODUCT_UNINST_ROOT_KEY}"
!define MUI_STARTMENUPAGE_REGISTRY_KEY "${PRODUCT_UNINST_KEY}"
!define MUI_STARTMENUPAGE_REGISTRY_VALUENAME "${PRODUCT_STARTMENU_REGVAL}"
!insertmacro MUI_PAGE_STARTMENU Application $ICONS_GROUP
; Instfiles page
!insertmacro MUI_PAGE_INSTFILES
; Finish page
!define MUI_FINISHPAGE_RUN "$INSTDIR\SGsortCalaParam.exe"
!insertmacro MUI_PAGE_FINISH

; Uninstaller pages
!insertmacro MUI_UNPAGE_INSTFILES

; Language files
!insertmacro MUI_LANGUAGE "English"
!insertmacro MUI_LANGUAGE "SimpChinese"

; MUI end ------

Name "${PRODUCT_NAME} ${PRODUCT_VERSION}"
OutFile "Setup.exe"
InstallDir "$PROGRAMFILES\三维地震勘探施工组织管理系统"
InstallDirRegKey HKLM "${PRODUCT_DIR_REGKEY}" ""
ShowInstDetails show
ShowUnInstDetails show

Function .onInit
  !insertmacro MUI_LANGDLL_DISPLAY
FunctionEnd

Section "MainSection" SEC01
  SetOutPath "$INSTDIR\de"
  SetOverwrite try
  File "bin\Debug\de\DevExpress.Data.v15.2.resources.dll"
  File "bin\Debug\de\DevExpress.Office.v15.2.Core.resources.dll"
  File "bin\Debug\de\DevExpress.Pdf.v15.2.Core.resources.dll"
  File "bin\Debug\de\DevExpress.Printing.v15.2.Core.resources.dll"
  File "bin\Debug\de\DevExpress.RichEdit.v15.2.Core.resources.dll"
  File "bin\Debug\de\DevExpress.Sparkline.v15.2.Core.resources.dll"
  File "bin\Debug\de\DevExpress.Utils.v15.2.resources.dll"
  File "bin\Debug\de\DevExpress.Utils.v15.2.UI.resources.dll"
  File "bin\Debug\de\DevExpress.XtraBars.v15.2.resources.dll"
  File "bin\Debug\de\DevExpress.XtraCharts.v15.2.resources.dll"
  File "bin\Debug\de\DevExpress.XtraCharts.v15.2.Wizard.resources.dll"
  File "bin\Debug\de\DevExpress.XtraEditors.v15.2.resources.dll"
  File "bin\Debug\de\DevExpress.XtraGrid.v15.2.resources.dll"
  File "bin\Debug\de\DevExpress.XtraLayout.v15.2.resources.dll"
  File "bin\Debug\de\DevExpress.XtraNavBar.v15.2.resources.dll"
  File "bin\Debug\de\DevExpress.XtraPrinting.v15.2.resources.dll"
  File "bin\Debug\de\DevExpress.XtraRichEdit.v15.2.resources.dll"
  File "bin\Debug\de\DevExpress.XtraTreeList.v15.2.resources.dll"
  File "bin\Debug\de\DevExpress.XtraVerticalGrid.v15.2.resources.dll"
  SetOutPath "$INSTDIR"
  File "bin\Debug\DevComponents.DotNetBar2.dll"
  File "bin\Debug\DevComponents.DotNetBar2.xml"
  File "bin\Debug\DevExpress.BonusSkins.v15.2.dll"
  File "bin\Debug\DevExpress.Charts.v15.2.Core.dll"
  File "bin\Debug\DevExpress.Data.v15.2.dll"
  File "bin\Debug\DevExpress.Data.v15.2.xml"
  File "bin\Debug\DevExpress.Office.v15.2.Core.dll"
  File "bin\Debug\DevExpress.Office.v15.2.Core.xml"
  File "bin\Debug\DevExpress.Pdf.v15.2.Core.dll"
  File "bin\Debug\DevExpress.Pdf.v15.2.Core.xml"
  File "bin\Debug\DevExpress.Pdf.v15.2.Drawing.dll"
  File "bin\Debug\DevExpress.Pdf.v15.2.Drawing.xml"
  File "bin\Debug\DevExpress.Printing.v15.2.Core.dll"
  File "bin\Debug\DevExpress.Printing.v15.2.Core.xml"
  File "bin\Debug\DevExpress.RichEdit.v15.2.Core.dll"
  File "bin\Debug\DevExpress.RichEdit.v15.2.Core.xml"
  File "bin\Debug\DevExpress.Sparkline.v15.2.Core.dll"
  File "bin\Debug\DevExpress.Sparkline.v15.2.Core.xml"
  File "bin\Debug\DevExpress.Utils.v15.2.dll"
  File "bin\Debug\DevExpress.Utils.v15.2.UI.dll"
  File "bin\Debug\DevExpress.Utils.v15.2.UI.xml"
  File "bin\Debug\DevExpress.Utils.v15.2.xml"
  File "bin\Debug\DevExpress.XtraBars.v15.2.dll"
  File "bin\Debug\DevExpress.XtraBars.v15.2.xml"
  File "bin\Debug\DevExpress.XtraCharts.v15.2.dll"
  File "bin\Debug\DevExpress.XtraCharts.v15.2.UI.dll"
  File "bin\Debug\DevExpress.XtraCharts.v15.2.UI.xml"
  File "bin\Debug\DevExpress.XtraCharts.v15.2.Wizard.dll"
  File "bin\Debug\DevExpress.XtraCharts.v15.2.Wizard.xml"
  File "bin\Debug\DevExpress.XtraCharts.v15.2.xml"
  File "bin\Debug\DevExpress.XtraEditors.v15.2.dll"
  File "bin\Debug\DevExpress.XtraEditors.v15.2.xml"
  File "bin\Debug\DevExpress.XtraGrid.v15.2.dll"
  File "bin\Debug\DevExpress.XtraGrid.v15.2.xml"
  File "bin\Debug\DevExpress.XtraLayout.v15.2.dll"
  File "bin\Debug\DevExpress.XtraLayout.v15.2.xml"
  File "bin\Debug\DevExpress.XtraNavBar.v15.2.dll"
  File "bin\Debug\DevExpress.XtraNavBar.v15.2.xml"
  File "bin\Debug\DevExpress.XtraPrinting.v15.2.dll"
  File "bin\Debug\DevExpress.XtraPrinting.v15.2.xml"
  File "bin\Debug\DevExpress.XtraRichEdit.v15.2.dll"
  File "bin\Debug\DevExpress.XtraRichEdit.v15.2.xml"
  File "bin\Debug\DevExpress.XtraTreeList.v15.2.dll"
  File "bin\Debug\DevExpress.XtraTreeList.v15.2.xml"
  File "bin\Debug\DevExpress.XtraVerticalGrid.v15.2.dll"
  File "bin\Debug\DevExpress.XtraVerticalGrid.v15.2.xml"
  File "bin\Debug\EntityFramework.dll"
  File "bin\Debug\EntityFramework.SqlServer.dll"
  File "bin\Debug\EntityFramework.SqlServer.xml"
  File "bin\Debug\EntityFramework.xml"
  SetOutPath "$INSTDIR\es"
  File "bin\Debug\es\DevExpress.Data.v15.2.resources.dll"
  File "bin\Debug\es\DevExpress.Office.v15.2.Core.resources.dll"
  File "bin\Debug\es\DevExpress.Pdf.v15.2.Core.resources.dll"
  File "bin\Debug\es\DevExpress.Printing.v15.2.Core.resources.dll"
  File "bin\Debug\es\DevExpress.RichEdit.v15.2.Core.resources.dll"
  File "bin\Debug\es\DevExpress.Sparkline.v15.2.Core.resources.dll"
  File "bin\Debug\es\DevExpress.Utils.v15.2.resources.dll"
  File "bin\Debug\es\DevExpress.Utils.v15.2.UI.resources.dll"
  File "bin\Debug\es\DevExpress.XtraBars.v15.2.resources.dll"
  File "bin\Debug\es\DevExpress.XtraCharts.v15.2.resources.dll"
  File "bin\Debug\es\DevExpress.XtraCharts.v15.2.Wizard.resources.dll"
  File "bin\Debug\es\DevExpress.XtraEditors.v15.2.resources.dll"
  File "bin\Debug\es\DevExpress.XtraGrid.v15.2.resources.dll"
  File "bin\Debug\es\DevExpress.XtraLayout.v15.2.resources.dll"
  File "bin\Debug\es\DevExpress.XtraNavBar.v15.2.resources.dll"
  File "bin\Debug\es\DevExpress.XtraPrinting.v15.2.resources.dll"
  File "bin\Debug\es\DevExpress.XtraRichEdit.v15.2.resources.dll"
  File "bin\Debug\es\DevExpress.XtraTreeList.v15.2.resources.dll"
  File "bin\Debug\es\DevExpress.XtraVerticalGrid.v15.2.resources.dll"
  SetOutPath "$INSTDIR"
  File "bin\Debug\ICSharpCode.SharpZipLib.dll"
  SetOutPath "$INSTDIR\ja"
  File "bin\Debug\ja\DevExpress.Data.v15.2.resources.dll"
  File "bin\Debug\ja\DevExpress.Office.v15.2.Core.resources.dll"
  File "bin\Debug\ja\DevExpress.Pdf.v15.2.Core.resources.dll"
  File "bin\Debug\ja\DevExpress.Printing.v15.2.Core.resources.dll"
  File "bin\Debug\ja\DevExpress.RichEdit.v15.2.Core.resources.dll"
  File "bin\Debug\ja\DevExpress.Sparkline.v15.2.Core.resources.dll"
  File "bin\Debug\ja\DevExpress.Utils.v15.2.resources.dll"
  File "bin\Debug\ja\DevExpress.Utils.v15.2.UI.resources.dll"
  File "bin\Debug\ja\DevExpress.XtraBars.v15.2.resources.dll"
  File "bin\Debug\ja\DevExpress.XtraCharts.v15.2.resources.dll"
  File "bin\Debug\ja\DevExpress.XtraCharts.v15.2.Wizard.resources.dll"
  File "bin\Debug\ja\DevExpress.XtraEditors.v15.2.resources.dll"
  File "bin\Debug\ja\DevExpress.XtraGrid.v15.2.resources.dll"
  File "bin\Debug\ja\DevExpress.XtraLayout.v15.2.resources.dll"
  File "bin\Debug\ja\DevExpress.XtraNavBar.v15.2.resources.dll"
  File "bin\Debug\ja\DevExpress.XtraPrinting.v15.2.resources.dll"
  File "bin\Debug\ja\DevExpress.XtraRichEdit.v15.2.resources.dll"
  File "bin\Debug\ja\DevExpress.XtraTreeList.v15.2.resources.dll"
  File "bin\Debug\ja\DevExpress.XtraVerticalGrid.v15.2.resources.dll"
  SetOutPath "$INSTDIR"
  File "bin\Debug\NPOI.dll"
  File "bin\Debug\NPOI.OOXML.dll"
  File "bin\Debug\NPOI.OpenXml4Net.dll"
  File "bin\Debug\NPOI.OpenXmlFormats.dll"
  File "bin\Debug\NPOI.xml"
  SetOutPath "$INSTDIR\ru"
  File "bin\Debug\ru\DevExpress.Data.v15.2.resources.dll"
  File "bin\Debug\ru\DevExpress.Office.v15.2.Core.resources.dll"
  File "bin\Debug\ru\DevExpress.Pdf.v15.2.Core.resources.dll"
  File "bin\Debug\ru\DevExpress.Printing.v15.2.Core.resources.dll"
  File "bin\Debug\ru\DevExpress.RichEdit.v15.2.Core.resources.dll"
  File "bin\Debug\ru\DevExpress.Sparkline.v15.2.Core.resources.dll"
  File "bin\Debug\ru\DevExpress.Utils.v15.2.resources.dll"
  File "bin\Debug\ru\DevExpress.Utils.v15.2.UI.resources.dll"
  File "bin\Debug\ru\DevExpress.XtraBars.v15.2.resources.dll"
  File "bin\Debug\ru\DevExpress.XtraCharts.v15.2.resources.dll"
  File "bin\Debug\ru\DevExpress.XtraCharts.v15.2.Wizard.resources.dll"
  File "bin\Debug\ru\DevExpress.XtraEditors.v15.2.resources.dll"
  File "bin\Debug\ru\DevExpress.XtraGrid.v15.2.resources.dll"
  File "bin\Debug\ru\DevExpress.XtraLayout.v15.2.resources.dll"
  File "bin\Debug\ru\DevExpress.XtraNavBar.v15.2.resources.dll"
  File "bin\Debug\ru\DevExpress.XtraPrinting.v15.2.resources.dll"
  File "bin\Debug\ru\DevExpress.XtraRichEdit.v15.2.resources.dll"
  File "bin\Debug\ru\DevExpress.XtraTreeList.v15.2.resources.dll"
  File "bin\Debug\ru\DevExpress.XtraVerticalGrid.v15.2.resources.dll"
  SetOutPath "$INSTDIR"
  File "bin\Debug\SGsortCalaParam.exe"
  File "bin\Debug\SGsortCalaParam.exe.config"
  File "bin\Debug\SGsortCalaParam.pdb"
  File "bin\Debug\SGsortCalaParam.vshost.exe"
  File "bin\Debug\SGsortCalaParam.vshost.exe.config"
  File "bin\Debug\SGsortCalaParam.vshost.exe.manifest"
  File "bin\Debug\System.Data.SQLite.dll"
  File "bin\Debug\System.Data.SQLite.EF6.dll"
  File "bin\Debug\System.Data.SQLite.Linq.dll"
  File "bin\Debug\System.Data.SQLite.xml"
  SetOutPath "$INSTDIR\x64"
  File "bin\Debug\x64\SQLite.Interop.dll"
  SetOutPath "$INSTDIR\x86"
  File "bin\Debug\x86\SQLite.Interop.dll"
  SetOutPath "$INSTDIR\zh-Hans"
  File "bin\Debug\zh-Hans\SGsortCalaParam.resources.dll"
  SetOutPath "$INSTDIR"
  File "bin\Debug\工程计算.nsi"

; Shortcuts
  !insertmacro MUI_STARTMENU_WRITE_BEGIN Application
  CreateDirectory "$SMPROGRAMS\$ICONS_GROUP"
  CreateShortCut "$SMPROGRAMS\$ICONS_GROUP\三维地震勘探施工组织管理系统.lnk" "$INSTDIR\SGsortCalaParam.exe"
  CreateShortCut "$DESKTOP\三维地震勘探施工组织管理系统.lnk" "$INSTDIR\SGsortCalaParam.exe"
  !insertmacro MUI_STARTMENU_WRITE_END
SectionEnd

Section -AdditionalIcons
  !insertmacro MUI_STARTMENU_WRITE_BEGIN Application
  WriteIniStr "$INSTDIR\${PRODUCT_NAME}.url" "InternetShortcut" "URL" "${PRODUCT_WEB_SITE}"
  CreateShortCut "$SMPROGRAMS\$ICONS_GROUP\Website.lnk" "$INSTDIR\${PRODUCT_NAME}.url"
  CreateShortCut "$SMPROGRAMS\$ICONS_GROUP\Uninstall.lnk" "$INSTDIR\uninst.exe"
  !insertmacro MUI_STARTMENU_WRITE_END
SectionEnd

Section -Post
  WriteUninstaller "$INSTDIR\uninst.exe"
  WriteRegStr HKLM "${PRODUCT_DIR_REGKEY}" "" "$INSTDIR\SGsortCalaParam.exe"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "DisplayName" "$(^Name)"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "UninstallString" "$INSTDIR\uninst.exe"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "DisplayIcon" "$INSTDIR\SGsortCalaParam.exe"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "DisplayVersion" "${PRODUCT_VERSION}"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "URLInfoAbout" "${PRODUCT_WEB_SITE}"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "Publisher" "${PRODUCT_PUBLISHER}"
SectionEnd


Section -.NET Framework
  ;检测是否是需要的.NET Framework版本
  Call GetNetFrameworkVersion
  Pop $R1
  ;${If} $R1 < '2.0.50727'
  ;${If} $R1 < '3.5.30729.4926'
  ${If} $R1 < '4.0.30319'
  ;${If} $R1 < '4.5.52747'
    MessageBox MB_YESNO|MB_ICONQUESTION "此软件运行需要.NET Framework 4.0运行环境，但您机器上似乎没有安装此环境。$\r$\n您有两个选择：$\r$\n1.您自己到互联网上下载.NET Framework 4.0安装，然后再运行此软件$\r$\n2.使用此安装程序在线下载并安装.NET Framework 4.0$\r$\n$\r$\n现在在线下载并安装.NET Framework 4.0,请确认您的机器已连接互联网.继续吗？" IDNO +2
      Call DownloadNetFramework4
    ${ENDIF}
SectionEnd

Function GetNetFrameworkVersion
;获取.Net Framework版本支持
    Push $1
    Push $0
    ReadRegDWORD $0 HKLM "SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full" "Install"
    ReadRegDWORD $1 HKLM "SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full" "Version"
    StrCmp $0 1 KnowNetFrameworkVersion +1
    ReadRegDWORD $0 HKLM "SOFTWARE\Microsoft\NET Framework Setup\NDP\v3.5" "Install"
    ReadRegDWORD $1 HKLM "SOFTWARE\Microsoft\NET Framework Setup\NDP\v3.5" "Version"
    StrCmp $0 1 KnowNetFrameworkVersion +1
    ReadRegDWORD $0 HKLM "SOFTWARE\Microsoft\NET Framework Setup\NDP\v3.0\Setup" "InstallSuccess"
    ReadRegDWORD $1 HKLM "SOFTWARE\Microsoft\NET Framework Setup\NDP\v3.0\Setup" "Version"
    StrCmp $0 1 KnowNetFrameworkVersion +1
    ReadRegDWORD $0 HKLM "SOFTWARE\Microsoft\NET Framework Setup\NDP\v2.0.50727" "Install"
    ReadRegDWORD $1 HKLM "SOFTWARE\Microsoft\NET Framework Setup\NDP\v2.0.50727" "Version"
    StrCmp $1 "" +1 +2
    StrCpy $1 "2.0.50727.832"
    StrCmp $0 1 KnowNetFrameworkVersion +1
    ReadRegDWORD $0 HKLM "SOFTWARE\Microsoft\NET Framework Setup\NDP\v1.1.4322" "Install"
    ReadRegDWORD $1 HKLM "SOFTWARE\Microsoft\NET Framework Setup\NDP\v1.1.4322" "Version"
    StrCmp $1 "" +1 +2
    StrCpy $1 "1.1.4322.573"
    StrCmp $0 1 KnowNetFrameworkVersion +1
    ReadRegDWORD $0 HKLM "SOFTWARE\Microsoft\.NETFramework\policy\v1.0" "Install"
    ReadRegDWORD $1 HKLM "SOFTWARE\Microsoft\.NETFramework\policy\v1.0" "Version"
    StrCmp $1 "" +1 +2
    StrCpy $1 "1.0.3705.0"
    StrCmp $0 1 KnowNetFrameworkVersion +1
    StrCpy $1 "not .NetFramework"
    KnowNetFrameworkVersion:
    Pop $0
    Exch $1
FunctionEnd

Function DownloadNetFramework2
;下载 .NET Framework 2.0 SP2
  NSISdl::download /TRANSLATE2 '正在下载 %s' '正在连接...' '(剩余 1 秒)' '(剩余 1 分钟)' '(剩余 1 小时)' '(剩余 %u 秒)' '(剩余 %u 分钟)' '(剩余 %u 小时)' '已完成：%skB(%d%%) 大小：%skB 速度：%u.%01ukB/s' /TIMEOUT=7500 /NOIEPROXY 'http://download.microsoft.com/download/c/6/e/c6e88215-0178-4c6c-b5f3-158ff77b1f38/NetFx20SP2_x86.exe' '$TEMP\NetFx20SP2_x86.exe'
  Pop $R0
  StrCmp $R0 "success" 0 +3

  SetDetailsPrint textonly
  DetailPrint "正在安装 .NET Framework 2.0 SP2..."
  SetDetailsPrint listonly
  ExecWait '$TEMP\NetFx20SP2_x86.exe /quiet /norestart' $R1
  Delete "$TEMP\NetFx20SP2_x86.exe"

FunctionEnd

Function DownloadNetFramework35
;下载 .NET Framework 3.5 SP1
  NSISdl::download /TRANSLATE2 '正在下载 %s' '正在连接...' '(剩余 1 秒)' '(剩余 1 分钟)' '(剩余 1 小时)' '(剩余 %u 秒)' '(剩余 %u 分钟)' '(剩余 %u 小时)' '已完成：%skB(%d%%) 大小：%skB 速度：%u.%01ukB/s' /TIMEOUT=7500 /NOIEPROXY 'http://download.microsoft.com/download/2/0/E/20E90413-712F-438C-988E-FDAA79A8AC3D/dotnetfx35.exe' '$TEMP\dotnetfx35.exe'
  Pop $R0
  StrCmp $R0 "success" 0 +2

  SetDetailsPrint textonly
  DetailPrint "正在安装 .NET Framework 3.5 SP1..."
  SetDetailsPrint listonly
  ExecWait '$TEMP\dotnetfx35.exe /quiet /norestart' $R1
  Delete "$TEMP\dotnetfx35.exe"

FunctionEnd

Function DownloadNetFramework4
;下载 .NET Framework 4.0
  NSISdl::download /TRANSLATE2 '正在下载 %s' '正在连接...' '(剩余 1 秒)' '(剩余 1 分钟)' '(剩余 1 小时)' '(剩余 %u 秒)' '(剩余 %u 分钟)' '(剩余 %u 小时)' '已完成：%skB(%d%%) 大小：%skB 速度：%u.%01ukB/s' /TIMEOUT=7500 /NOIEPROXY 'http://download.microsoft.com/download/9/5/A/95A9616B-7A37-4AF6-BC36-D6EA96C8DAAE/dotNetFx40_Full_x86_x64.exe' '$TEMP\dotNetFx40_Full_x86_x64.exe'
  Pop $R0
  StrCmp $R0 "success" 0 +2

  SetDetailsPrint textonly
  DetailPrint "正在安装 .NET Framework 4.0 Full..."
  SetDetailsPrint listonly
  ExecWait '$TEMP\dotNetFx40_Full_x86_x64.exe /quiet /norestart' $R1
  Delete "$TEMP\dotNetFx40_Full_x86_x64.exe"

FunctionEnd

Function DownloadNetFramework45
;下载 .NET Framework 4.5
  NSISdl::download /TRANSLATE2 '正在下载 %s' '正在连接...' '(剩余 1 秒)' '(剩余 1 分钟)' '(剩余 1 小时)' '(剩余 %u 秒)' '(剩余 %u 分钟)' '(剩余 %u 小时)' '已完成：%skB(%d%%) 大小：%skB 速度：%u.%01ukB/s' /TIMEOUT=7500 /NOIEPROXY 'http://download.microsoft.com/download/E/2/1/E21644B5-2DF2-47C2-91BD-63C560427900/NDP452-KB2901907-x86-x64-AllOS-ENU.exe' '$TEMP\NDP452-KB2901907-x86-x64-AllOS-ENU.exe'
  Pop $R0
  StrCmp $R0 "success" 0 +2

  SetDetailsPrint textonly
  DetailPrint "正在安装 .NET Framework 4.5.2 ..."
  SetDetailsPrint listonly
  ExecWait '$TEMP\NDP452-KB2901907-x86-x64-AllOS-ENU.exe /quiet /norestart' $R1
  Delete "$TEMP\NDP452-KB2901907-x86-x64-AllOS-ENU.exe"

FunctionEnd
Function un.onUninstSuccess
  HideWindow
  MessageBox MB_ICONINFORMATION|MB_OK "$(^Name) 已成功地从你的计算机移除。"
FunctionEnd

Function un.onInit
!insertmacro MUI_UNGETLANGUAGE
  MessageBox MB_ICONQUESTION|MB_YESNO|MB_DEFBUTTON2 "你确实要完全移除 $(^Name) ，其及所有的组件？" IDYES +2
  Abort
FunctionEnd

Section Uninstall
  !insertmacro MUI_STARTMENU_GETFOLDER "Application" $ICONS_GROUP
  Delete "$INSTDIR\${PRODUCT_NAME}.url"
  Delete "$INSTDIR\uninst.exe"
  Delete "$INSTDIR\工程计算.nsi"
  Delete "$INSTDIR\zh-Hans\SGsortCalaParam.resources.dll"
  Delete "$INSTDIR\x86\SQLite.Interop.dll"
  Delete "$INSTDIR\x64\SQLite.Interop.dll"
  Delete "$INSTDIR\System.Data.SQLite.xml"
  Delete "$INSTDIR\System.Data.SQLite.Linq.dll"
  Delete "$INSTDIR\System.Data.SQLite.EF6.dll"
  Delete "$INSTDIR\System.Data.SQLite.dll"
  Delete "$INSTDIR\SGsortCalaParam.vshost.exe.manifest"
  Delete "$INSTDIR\SGsortCalaParam.vshost.exe.config"
  Delete "$INSTDIR\SGsortCalaParam.vshost.exe"
  Delete "$INSTDIR\SGsortCalaParam.pdb"
  Delete "$INSTDIR\SGsortCalaParam.exe.config"
  Delete "$INSTDIR\SGsortCalaParam.exe"
  Delete "$INSTDIR\ru\DevExpress.XtraVerticalGrid.v15.2.resources.dll"
  Delete "$INSTDIR\ru\DevExpress.XtraTreeList.v15.2.resources.dll"
  Delete "$INSTDIR\ru\DevExpress.XtraRichEdit.v15.2.resources.dll"
  Delete "$INSTDIR\ru\DevExpress.XtraPrinting.v15.2.resources.dll"
  Delete "$INSTDIR\ru\DevExpress.XtraNavBar.v15.2.resources.dll"
  Delete "$INSTDIR\ru\DevExpress.XtraLayout.v15.2.resources.dll"
  Delete "$INSTDIR\ru\DevExpress.XtraGrid.v15.2.resources.dll"
  Delete "$INSTDIR\ru\DevExpress.XtraEditors.v15.2.resources.dll"
  Delete "$INSTDIR\ru\DevExpress.XtraCharts.v15.2.Wizard.resources.dll"
  Delete "$INSTDIR\ru\DevExpress.XtraCharts.v15.2.resources.dll"
  Delete "$INSTDIR\ru\DevExpress.XtraBars.v15.2.resources.dll"
  Delete "$INSTDIR\ru\DevExpress.Utils.v15.2.UI.resources.dll"
  Delete "$INSTDIR\ru\DevExpress.Utils.v15.2.resources.dll"
  Delete "$INSTDIR\ru\DevExpress.Sparkline.v15.2.Core.resources.dll"
  Delete "$INSTDIR\ru\DevExpress.RichEdit.v15.2.Core.resources.dll"
  Delete "$INSTDIR\ru\DevExpress.Printing.v15.2.Core.resources.dll"
  Delete "$INSTDIR\ru\DevExpress.Pdf.v15.2.Core.resources.dll"
  Delete "$INSTDIR\ru\DevExpress.Office.v15.2.Core.resources.dll"
  Delete "$INSTDIR\ru\DevExpress.Data.v15.2.resources.dll"
  Delete "$INSTDIR\NPOI.xml"
  Delete "$INSTDIR\NPOI.OpenXmlFormats.dll"
  Delete "$INSTDIR\NPOI.OpenXml4Net.dll"
  Delete "$INSTDIR\NPOI.OOXML.dll"
  Delete "$INSTDIR\NPOI.dll"
  Delete "$INSTDIR\ja\DevExpress.XtraVerticalGrid.v15.2.resources.dll"
  Delete "$INSTDIR\ja\DevExpress.XtraTreeList.v15.2.resources.dll"
  Delete "$INSTDIR\ja\DevExpress.XtraRichEdit.v15.2.resources.dll"
  Delete "$INSTDIR\ja\DevExpress.XtraPrinting.v15.2.resources.dll"
  Delete "$INSTDIR\ja\DevExpress.XtraNavBar.v15.2.resources.dll"
  Delete "$INSTDIR\ja\DevExpress.XtraLayout.v15.2.resources.dll"
  Delete "$INSTDIR\ja\DevExpress.XtraGrid.v15.2.resources.dll"
  Delete "$INSTDIR\ja\DevExpress.XtraEditors.v15.2.resources.dll"
  Delete "$INSTDIR\ja\DevExpress.XtraCharts.v15.2.Wizard.resources.dll"
  Delete "$INSTDIR\ja\DevExpress.XtraCharts.v15.2.resources.dll"
  Delete "$INSTDIR\ja\DevExpress.XtraBars.v15.2.resources.dll"
  Delete "$INSTDIR\ja\DevExpress.Utils.v15.2.UI.resources.dll"
  Delete "$INSTDIR\ja\DevExpress.Utils.v15.2.resources.dll"
  Delete "$INSTDIR\ja\DevExpress.Sparkline.v15.2.Core.resources.dll"
  Delete "$INSTDIR\ja\DevExpress.RichEdit.v15.2.Core.resources.dll"
  Delete "$INSTDIR\ja\DevExpress.Printing.v15.2.Core.resources.dll"
  Delete "$INSTDIR\ja\DevExpress.Pdf.v15.2.Core.resources.dll"
  Delete "$INSTDIR\ja\DevExpress.Office.v15.2.Core.resources.dll"
  Delete "$INSTDIR\ja\DevExpress.Data.v15.2.resources.dll"
  Delete "$INSTDIR\ICSharpCode.SharpZipLib.dll"
  Delete "$INSTDIR\es\DevExpress.XtraVerticalGrid.v15.2.resources.dll"
  Delete "$INSTDIR\es\DevExpress.XtraTreeList.v15.2.resources.dll"
  Delete "$INSTDIR\es\DevExpress.XtraRichEdit.v15.2.resources.dll"
  Delete "$INSTDIR\es\DevExpress.XtraPrinting.v15.2.resources.dll"
  Delete "$INSTDIR\es\DevExpress.XtraNavBar.v15.2.resources.dll"
  Delete "$INSTDIR\es\DevExpress.XtraLayout.v15.2.resources.dll"
  Delete "$INSTDIR\es\DevExpress.XtraGrid.v15.2.resources.dll"
  Delete "$INSTDIR\es\DevExpress.XtraEditors.v15.2.resources.dll"
  Delete "$INSTDIR\es\DevExpress.XtraCharts.v15.2.Wizard.resources.dll"
  Delete "$INSTDIR\es\DevExpress.XtraCharts.v15.2.resources.dll"
  Delete "$INSTDIR\es\DevExpress.XtraBars.v15.2.resources.dll"
  Delete "$INSTDIR\es\DevExpress.Utils.v15.2.UI.resources.dll"
  Delete "$INSTDIR\es\DevExpress.Utils.v15.2.resources.dll"
  Delete "$INSTDIR\es\DevExpress.Sparkline.v15.2.Core.resources.dll"
  Delete "$INSTDIR\es\DevExpress.RichEdit.v15.2.Core.resources.dll"
  Delete "$INSTDIR\es\DevExpress.Printing.v15.2.Core.resources.dll"
  Delete "$INSTDIR\es\DevExpress.Pdf.v15.2.Core.resources.dll"
  Delete "$INSTDIR\es\DevExpress.Office.v15.2.Core.resources.dll"
  Delete "$INSTDIR\es\DevExpress.Data.v15.2.resources.dll"
  Delete "$INSTDIR\EntityFramework.xml"
  Delete "$INSTDIR\EntityFramework.SqlServer.xml"
  Delete "$INSTDIR\EntityFramework.SqlServer.dll"
  Delete "$INSTDIR\EntityFramework.dll"
  Delete "$INSTDIR\DevExpress.XtraVerticalGrid.v15.2.xml"
  Delete "$INSTDIR\DevExpress.XtraVerticalGrid.v15.2.dll"
  Delete "$INSTDIR\DevExpress.XtraTreeList.v15.2.xml"
  Delete "$INSTDIR\DevExpress.XtraTreeList.v15.2.dll"
  Delete "$INSTDIR\DevExpress.XtraRichEdit.v15.2.xml"
  Delete "$INSTDIR\DevExpress.XtraRichEdit.v15.2.dll"
  Delete "$INSTDIR\DevExpress.XtraPrinting.v15.2.xml"
  Delete "$INSTDIR\DevExpress.XtraPrinting.v15.2.dll"
  Delete "$INSTDIR\DevExpress.XtraNavBar.v15.2.xml"
  Delete "$INSTDIR\DevExpress.XtraNavBar.v15.2.dll"
  Delete "$INSTDIR\DevExpress.XtraLayout.v15.2.xml"
  Delete "$INSTDIR\DevExpress.XtraLayout.v15.2.dll"
  Delete "$INSTDIR\DevExpress.XtraGrid.v15.2.xml"
  Delete "$INSTDIR\DevExpress.XtraGrid.v15.2.dll"
  Delete "$INSTDIR\DevExpress.XtraEditors.v15.2.xml"
  Delete "$INSTDIR\DevExpress.XtraEditors.v15.2.dll"
  Delete "$INSTDIR\DevExpress.XtraCharts.v15.2.xml"
  Delete "$INSTDIR\DevExpress.XtraCharts.v15.2.Wizard.xml"
  Delete "$INSTDIR\DevExpress.XtraCharts.v15.2.Wizard.dll"
  Delete "$INSTDIR\DevExpress.XtraCharts.v15.2.UI.xml"
  Delete "$INSTDIR\DevExpress.XtraCharts.v15.2.UI.dll"
  Delete "$INSTDIR\DevExpress.XtraCharts.v15.2.dll"
  Delete "$INSTDIR\DevExpress.XtraBars.v15.2.xml"
  Delete "$INSTDIR\DevExpress.XtraBars.v15.2.dll"
  Delete "$INSTDIR\DevExpress.Utils.v15.2.xml"
  Delete "$INSTDIR\DevExpress.Utils.v15.2.UI.xml"
  Delete "$INSTDIR\DevExpress.Utils.v15.2.UI.dll"
  Delete "$INSTDIR\DevExpress.Utils.v15.2.dll"
  Delete "$INSTDIR\DevExpress.Sparkline.v15.2.Core.xml"
  Delete "$INSTDIR\DevExpress.Sparkline.v15.2.Core.dll"
  Delete "$INSTDIR\DevExpress.RichEdit.v15.2.Core.xml"
  Delete "$INSTDIR\DevExpress.RichEdit.v15.2.Core.dll"
  Delete "$INSTDIR\DevExpress.Printing.v15.2.Core.xml"
  Delete "$INSTDIR\DevExpress.Printing.v15.2.Core.dll"
  Delete "$INSTDIR\DevExpress.Pdf.v15.2.Drawing.xml"
  Delete "$INSTDIR\DevExpress.Pdf.v15.2.Drawing.dll"
  Delete "$INSTDIR\DevExpress.Pdf.v15.2.Core.xml"
  Delete "$INSTDIR\DevExpress.Pdf.v15.2.Core.dll"
  Delete "$INSTDIR\DevExpress.Office.v15.2.Core.xml"
  Delete "$INSTDIR\DevExpress.Office.v15.2.Core.dll"
  Delete "$INSTDIR\DevExpress.Data.v15.2.xml"
  Delete "$INSTDIR\DevExpress.Data.v15.2.dll"
  Delete "$INSTDIR\DevExpress.Charts.v15.2.Core.dll"
  Delete "$INSTDIR\DevExpress.BonusSkins.v15.2.dll"
  Delete "$INSTDIR\DevComponents.DotNetBar2.xml"
  Delete "$INSTDIR\DevComponents.DotNetBar2.dll"
  Delete "$INSTDIR\de\DevExpress.XtraVerticalGrid.v15.2.resources.dll"
  Delete "$INSTDIR\de\DevExpress.XtraTreeList.v15.2.resources.dll"
  Delete "$INSTDIR\de\DevExpress.XtraRichEdit.v15.2.resources.dll"
  Delete "$INSTDIR\de\DevExpress.XtraPrinting.v15.2.resources.dll"
  Delete "$INSTDIR\de\DevExpress.XtraNavBar.v15.2.resources.dll"
  Delete "$INSTDIR\de\DevExpress.XtraLayout.v15.2.resources.dll"
  Delete "$INSTDIR\de\DevExpress.XtraGrid.v15.2.resources.dll"
  Delete "$INSTDIR\de\DevExpress.XtraEditors.v15.2.resources.dll"
  Delete "$INSTDIR\de\DevExpress.XtraCharts.v15.2.Wizard.resources.dll"
  Delete "$INSTDIR\de\DevExpress.XtraCharts.v15.2.resources.dll"
  Delete "$INSTDIR\de\DevExpress.XtraBars.v15.2.resources.dll"
  Delete "$INSTDIR\de\DevExpress.Utils.v15.2.UI.resources.dll"
  Delete "$INSTDIR\de\DevExpress.Utils.v15.2.resources.dll"
  Delete "$INSTDIR\de\DevExpress.Sparkline.v15.2.Core.resources.dll"
  Delete "$INSTDIR\de\DevExpress.RichEdit.v15.2.Core.resources.dll"
  Delete "$INSTDIR\de\DevExpress.Printing.v15.2.Core.resources.dll"
  Delete "$INSTDIR\de\DevExpress.Pdf.v15.2.Core.resources.dll"
  Delete "$INSTDIR\de\DevExpress.Office.v15.2.Core.resources.dll"
  Delete "$INSTDIR\de\DevExpress.Data.v15.2.resources.dll"

  Delete "$SMPROGRAMS\$ICONS_GROUP\Uninstall.lnk"
  Delete "$SMPROGRAMS\$ICONS_GROUP\Website.lnk"
  Delete "$DESKTOP\三维地震勘探施工组织管理系统.lnk"
  Delete "$SMPROGRAMS\$ICONS_GROUP\三维地震勘探施工组织管理系统.lnk"

  RMDir "$SMPROGRAMS\$ICONS_GROUP"
  RMDir "$INSTDIR\zh-Hans"
  RMDir "$INSTDIR\x86"
  RMDir "$INSTDIR\x64"
  RMDir "$INSTDIR\ru"
  RMDir "$INSTDIR\ja"
  RMDir "$INSTDIR\es"
  RMDir "$INSTDIR\de"
  RMDir "$INSTDIR"

  DeleteRegKey ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}"
  DeleteRegKey HKLM "${PRODUCT_DIR_REGKEY}"
  SetAutoClose true
SectionEnd