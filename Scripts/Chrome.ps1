

$LogFilePath = "C:\CompInstaller\Comps01\Logs"
$Path = "C:\CompInstaller\3rdParty"


Start-Transcript -Path $LogFilePath\Notepad++.log -Verbose

start-process -Verb RunAs -FilePath "$Path\ChromeSetup.exe" -ArgumentList /S -wait -Verbose

Write-Host Chrome installed"

Stop-Transcript