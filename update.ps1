$projects = "cimgui", "cimguizmo", "cimnodes", "cimplot"
$projectsFolder = "ImGuiSharp", "ImGuizmoSharp", "ImNodesSharp", "ImPlotSharp"

$push=$args[0]

#Pull new versions from github
git pull

#Init submodules
git submodule update --init --recursive

#Update submodules
git submodule update --remote --recursive

#Updating definition files
for ($i = 0; $i -lt $projects.Count; $i++) {
    $project = $projects[$i]
    $projectFolder = $projectsFolder[$i]

    $definitionsPath = (Get-Location).ToString() + "\src\" + $projectFolder + "\Definitions\"

    $outputPath = ".\native\$project\generator\output"

    Push-Location $outputPath

    Write-Output (Get-Location).ToString()

    Copy-Item -Path *.json -Destination $definitionsPath -PassThru

    Pop-Location
}

#Build Native libs
#.\native\build.ps1


#Build generator

#Run Generator for each project

#Push to github
if($push) {
    git add .
    git commit -m "Update definitions"
    git push
}
