# Vcenter.Automation.OpenApi.Model.VcenterVmToolsVersionStatus
The Vcenter.Vm.Tools.VersionStatus enumerated type defines the version status types of VMware Tools installed in the guest operating system.  Possible values:   - `NOT_INSTALLED`: VMware Tools has never been installed.   - `CURRENT`: VMware Tools is installed, and the version is current.   - `UNMANAGED`: VMware Tools is installed, but it is not managed by VMware. This includes open-vm-tools or OSPs which should be managed by the guest operating system.   - `TOO_OLD_UNSUPPORTED`: VMware Tools is installed, but the version is too old.   - `SUPPORTED_OLD`: VMware Tools is installed, supported, but a newer version is available.   - `SUPPORTED_NEW`: VMware Tools is installed, supported, and newer than the version available on the host.   - `TOO_NEW`: VMware Tools is installed, and the version is known to be too new to work correctly with this virtual machine.   - `BLACKLISTED`: VMware Tools is installed, but the installed version is known to have a grave bug and should be immediately upgraded.   This enumeration was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

