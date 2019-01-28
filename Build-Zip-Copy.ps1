# Build in Release configuration. Ensure MSBuild is in your PATH environment variable.
MSBuild.exe .\src\UnicodePad\UnicodePad.sln /t:Rebuild /p:Configuration=Release

# Zip up binaries
Remove-Item .\src\UnicodePad\bin\Release\UnicodePad.pdb -ErrorAction SilentlyContinue
$loc = Get-Location
Add-Type -A System.IO.Compression.FileSystem
$src = "$loc\src\UnicodePad\bin\Release"
$dst = "$loc\binaries\UnicodePad.zip"
Remove-Item $dst -ErrorAction SilentlyContinue
[IO.Compression.ZipFile]::CreateFromDirectory($src, $dst)

# Copy to where I have it installed.
Copy-Item .\src\UnicodePad\bin\Release\UnicodePad.exe -Destination 'C:\Program Files\Unicode Pad\'
Copy-Item .\src\UnicodePad\bin\Release\UnicodePad.exe.config -Destination 'C:\Program Files\Unicode Pad\'
