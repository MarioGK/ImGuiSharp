$projects = "cimgui", "cimguizmo", "cimnodes", "cimplot"

$push=$args[0]

#Pull new versions from github
git pull

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

#Build Native libs
.\build.ps1


#Build generator

#Run Generator for each project

#Push to github
if($push) {
    git add .
    git commit -m "Update definitions"
    git push
}
