@echo off
echo ============================================
echo   ClassLog - Creation du package portable
echo ============================================
echo.

set SOURCE=..\AppGestionCahierTexte\bin\Debug
set OUTPUT=..\Output
set PACKAGE=ClassLog_Portable_v1.0.0

:: Créer le dossier de sortie
if not exist "%OUTPUT%" mkdir "%OUTPUT%"

:: Supprimer l'ancien package s'il existe
if exist "%OUTPUT%\%PACKAGE%" rmdir /s /q "%OUTPUT%\%PACKAGE%"
if exist "%OUTPUT%\%PACKAGE%.zip" del "%OUTPUT%\%PACKAGE%.zip"

:: Créer le dossier du package
mkdir "%OUTPUT%\%PACKAGE%"

:: Copier les fichiers nécessaires (pas les .pdb ni .xml)
echo Copie des fichiers...
copy "%SOURCE%\ClassLog.exe" "%OUTPUT%\%PACKAGE%\" >nul
copy "%SOURCE%\ClassLog.exe.config" "%OUTPUT%\%PACKAGE%\" >nul
copy "%SOURCE%\icone app.ico" "%OUTPUT%\%PACKAGE%\" >nul
copy "%SOURCE%\EntityFramework.dll" "%OUTPUT%\%PACKAGE%\" >nul
copy "%SOURCE%\EntityFramework.SqlServer.dll" "%OUTPUT%\%PACKAGE%\" >nul
copy "%SOURCE%\MySql.Data.dll" "%OUTPUT%\%PACKAGE%\" >nul
copy "%SOURCE%\MySql.Data.EntityFramework.dll" "%OUTPUT%\%PACKAGE%\" >nul
copy "%SOURCE%\BouncyCastle.Cryptography.dll" "%OUTPUT%\%PACKAGE%\" >nul
copy "%SOURCE%\Google.Protobuf.dll" "%OUTPUT%\%PACKAGE%\" >nul
copy "%SOURCE%\K4os.Compression.LZ4.dll" "%OUTPUT%\%PACKAGE%\" >nul
copy "%SOURCE%\K4os.Compression.LZ4.Streams.dll" "%OUTPUT%\%PACKAGE%\" >nul
copy "%SOURCE%\K4os.Hash.xxHash.dll" "%OUTPUT%\%PACKAGE%\" >nul
copy "%SOURCE%\ZstdSharp.dll" "%OUTPUT%\%PACKAGE%\" >nul
copy "%SOURCE%\Microsoft.Bcl.AsyncInterfaces.dll" "%OUTPUT%\%PACKAGE%\" >nul
copy "%SOURCE%\System.Buffers.dll" "%OUTPUT%\%PACKAGE%\" >nul
copy "%SOURCE%\System.Configuration.ConfigurationManager.dll" "%OUTPUT%\%PACKAGE%\" >nul
copy "%SOURCE%\System.IO.Pipelines.dll" "%OUTPUT%\%PACKAGE%\" >nul
copy "%SOURCE%\System.Memory.dll" "%OUTPUT%\%PACKAGE%\" >nul
copy "%SOURCE%\System.Numerics.Vectors.dll" "%OUTPUT%\%PACKAGE%\" >nul
copy "%SOURCE%\System.Runtime.CompilerServices.Unsafe.dll" "%OUTPUT%\%PACKAGE%\" >nul
copy "%SOURCE%\System.Threading.Tasks.Extensions.dll" "%OUTPUT%\%PACKAGE%\" >nul

:: Créer le ZIP avec PowerShell
echo Creation du ZIP...
powershell -Command "Compress-Archive -Path '%OUTPUT%\%PACKAGE%\*' -DestinationPath '%OUTPUT%\%PACKAGE%.zip' -Force"

echo.
echo ============================================
echo   Package cree : Output\%PACKAGE%.zip
echo ============================================
echo.
pause
