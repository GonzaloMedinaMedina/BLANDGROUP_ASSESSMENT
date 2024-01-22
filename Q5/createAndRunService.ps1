# Stop the service
Stop-Service -Name "Service1" -Force

# Delete the service
sc.exe delete "Service1"

# Create and configure the new service
New-Service -Name "Service1" -BinaryPathName <FullBinaryPath>

# Start the new service
Start-Service -Name "Service1"

# Get the service status
sc.exe query "Service1"