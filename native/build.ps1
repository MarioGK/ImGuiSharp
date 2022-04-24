$projects = "cimgui"#, "cimguizmo", "cimnodes", "cimplot"

$BuildArch = "x64"
$BuildConfig = "Debug"
$BuildPlatform = "x64"

foreach ($project in $projects) {
    $projectPath = $path = (Get-Location).ToString() +"\" + $project + "\"
    Write-Output $projectPath
    Push-Location $projectPath
    $path = (Get-Location).ToString() +"\build\" + $BuildArch
    if (Test-Path -Path $path) {
        Remove-Item -Path $path -Recurse -Force
        mkdir $path
    }
    else {
        mkdir $path
    }
    Write-Output "Path: $path"
    
    Write-Output "Calling: cmake -G Visual Studio 17 2022" -DCMAKE_GENERATOR_PLATFORM="$BuildPlatform"
    cmake -G "Visual Studio 17 2022" -DCMAKE_GENERATOR_PLATFORM=$BuildPlatform

    Push-Location $path
    Write-Output "Calling: cmake --build . --config $BuildConfig"
    cmake --build . --config "$BuildConfig"

    Pop-Location
    Pop-Location
}