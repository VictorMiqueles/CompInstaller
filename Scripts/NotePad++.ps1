

$LogFilePath = "C:\CompInstaller\Comps01\Logs"
$Path = "C:\CompInstaller\3rdParty"

Start-Transcript -Path $LogFilePath\Notepad++.log -Verbose

start-process -Verb RunAs -FilePath "$Path\npp.8.5.8.Installer.x64.exe" -ArgumentList /S -wait

Write-Host "Notepad++ installed"

Stop-Transcript

