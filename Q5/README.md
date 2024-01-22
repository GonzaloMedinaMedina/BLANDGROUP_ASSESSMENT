# To run this project first need to install the service app with the following command in the windows PowerShell (maybe need to open it as administrator):
	- New-Service "ANPRCameraSystem" -BinaryPathName <FullPathOfYourExeFile>	 
# To start the service:
	- net start "ANPRCameraSystem"
# To stop the service:
	- net stop "ANPRCameraSystem"
# To Remove a service:
    - sc.exe delete "ANPRCameraSystem"
# To check service status:
	- sc.exe query "ANPRCameraSystem"