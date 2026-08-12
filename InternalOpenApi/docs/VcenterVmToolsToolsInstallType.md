# Vcenter.Automation.OpenApi.Model.VcenterVmToolsToolsInstallType
The Vcenter.Vm.Tools.ToolsInstallType enumerated type defines the installation type of the Tools in the guest operating system.  Possible values:   - `UNKNOWN`: Installation type is not known. Most likely tools have been installed by OSPs or open-vm-tools, but a version that does not report its install type or an install type that we do not recognize.   - `MSI`: MSI is the installation type used for VMware Tools on Windows.   - `TAR`: Tools have been installed by the tar installer.   - `OSP`: OSPs are RPM or Debian packages tailored for the OS in the VM. See http://packages.vmware.com   - `OPEN_VM_TOOLS`: open-vm-tools are the open-source version of VMware Tools, may have been packaged by the OS vendor.   This enumeration was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

