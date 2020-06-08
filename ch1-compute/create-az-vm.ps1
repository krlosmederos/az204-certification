$rgName = Read-Host -Prompt "Enter resource group name"
$location = Read-Host -Prompt "Enter location (ie. eastus)"
$vmName = Read-Host -Prompt "Enter Virtual Machine name"

# Create a resource group
New-AzResourceGroup -Name $rgName -Location $location

# Create the VM
New-AzVM `
    -ResourceGroupName $rgName `
    -Name $vmName `
    -Location $location



