$BuildArch = "x64"
$BuildConfig = "Release"
$BuildPlatform = "x64"
$buildPath
$libsFolder
$rootFolder = (Get-Location).ToString()

#This makes possible to run the script from the root git folder
if((Get-Item .).Name -ne "native")
{
    #it means we are at the root folder
    $buildPath = Join-Path $rootFolder "native" "build"
    $libsFolder = Join-Path $rootFolder "libs"
}
else
{
    $buildPath = Join-Path $rootFolder "build"
    $libsFolder = Join-Path $rootFolder ".." "libs"
}

#Clean the folder if exists, if not creates a new one
if (Test-Path -Path $buildPath) {
    Remove-Item -Path $buildPath -Recurse -Force
    mkdir $buildPath
}
else {
    mkdir $buildPath
}

#Enters build folder
Push-Location $buildPath

cmake .\..
cmake --build . --config $BuildConfig

Pop-Location

#copy the file to the output folder
$releasePath = Join-Path $buildPath $BuildConfig

#TODO cope the file to the output folder
Copy-Item -Path "$releasePath\*.dll" -Destination "$libsFolder\win-x64\cimgui.dll" -PassThru
