@echo off

rem https://qiita.com/tera1707/items/018e8390207c5b2212b2
rem thx!

rem �܂��J���җp�R�}���h�v�����v�g���N�����Ă���
call "C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\Common7\Tools\VsDevCmd.bat"

rem NuGet���g���p�b�P�[�W�𕜌�
nuget restore

rem MSBuild�Ńr���h����(C#)
cd %~dp0

echo Building...
MSBuild ".\FuiEditor.sln" /t:clean;rebuild /p:Configuration=Release;Platform="Any CPU"
if %ERRORLEVEL% neq 0 (
    echo ErrorLevel:%ERRORLEVEL%
    echo �r���h���s
)

pause