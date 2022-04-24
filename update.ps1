$projects = "cimgui", "cimguizmo", "cimnodes", "cimplot"

#Init submodules
git submodule update --init --recursive

#Update submodules
git submodule update --remote --recursive

#Updating definition files
foreach ($project in $projects) {
    $definitionsPath = (Get-Location).ToString() + "\definitions\" + $project

    if (Test-Path -Path $definitionsPath) {
        Remove-Item -Path $definitionsPath -Recurse -Force
        mkdir $definitionsPath
    }
    else {
        mkdir $definitionsPath
    }

    $outputPath = ".\native\$project\generator\output"

    Push-Location $outputPath

    Write-Output (Get-Location).ToString()

    Copy-Item -Path *.json -Destination $definitionsPath -PassThru

    Pop-Location
}

#Run Generators for each project
