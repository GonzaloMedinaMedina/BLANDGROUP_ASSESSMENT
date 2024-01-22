# Stop the service
Stop-Service -Name "Service1" -Force

# Delete the service
sc.exe delete "Service1"

# Create and configure the new service
New-Service -Name "Service1" -BinaryPathName "C:\Users\Gonzalo\dev\BLANDGROUP_ASSESSMENT\Q5\ANPRCameraSystem\ANPRCameraSystem\bin\Release\ANPRCameraSystem.exe"

# Start the new service
Start-Service -Name "Service1"

# Get the service status
sc.exe query "Service1"