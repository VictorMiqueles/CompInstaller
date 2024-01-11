

$LogFilePath = "C:\CompInstaller\Comps01\Logs"
$Path = "C:\CompInstaller\3rdParty"


Start-Transcript -Path $LogFilePath\Notepad++.log -Verbose

start-process -Verb RunAs -FilePath "$Path\FileZilla_3.66.4_win64-setup.exe" -ArgumentList /S -wait -Verbose

Write-Host "Filezilla installed"

Stop-Transcript