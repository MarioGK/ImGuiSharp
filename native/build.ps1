$BuildArch = "x64"
$BuildConfig = "Release"
$BuildPlatform = "x64"

$buildPath = (Get-Location).ToString() + "\build";

#Clean the folder if exists, if not creates a new one
if (Test-Path -Path $buildPath) {
    Remove-Item -Path $buildPath -Recurse -Force
    mkdir $buildPath
}
else {
    mkdir $buildPath
}

Push-Location $buildPath

cmake .\..
cmake --build . --config $BuildConfig

Pop-Location