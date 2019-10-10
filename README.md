# MacOS Virtual Box Script Generator
This project (small utility) is dedicated for people who want to create Mac OS Virtual Machine using Virtual Box.

As you now, before running Sierra / High Sierra / Mojave / Catalina (not tested yet) on Virtual Box, you should run next commands from Command Line (in some cases with Admin rights):

  cd "C:\Program Files\Oracle\VirtualBox\"

  VBoxManage.exe modifyvm "VM_NAME" --cpuidset 00000001 000106e5 00100800 0098e3fd bfebfbff

  VBoxManage setextradata "VM_NAME" "VBoxInternal/Devices/efi/0/Config/DmiSystemProduct" "iMac11,3"

  VBoxManage setextradata "VM_NAME" "VBoxInternal/Devices/efi/0/Config/DmiSystemVersion" "1.0"

  VBoxManage setextradata "VM_NAME" "VBoxInternal/Devices/efi/0/Config/DmiBoardProduct" "Iloveapple"

  VBoxManage setextradata "VM_NAME" "VBoxInternal/Devices/smc/0/Config/DeviceKey" "ourhardworkbythesewordsguardedpleasedontsteal(c)AppleComputerInc"

  VBoxManage setextradata "VM_NAME" "VBoxInternal/Devices/smc/0/Config/GetKeyFromRealSMC" 1


So, this utility extract Virtual Machines list from your Virtual Box and generate *.txt or *.bat file (you also can execute this bat to apply commands). 

For example, I have next VM's on my local machine:


You can see examples below:
