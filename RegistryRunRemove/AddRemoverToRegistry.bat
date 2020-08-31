@echo off
set path=%~dp0
%SystemRoot%\System32\reg.exe ADD "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\remove.exe" /ve /d %path%RegistryRunRemove.exe