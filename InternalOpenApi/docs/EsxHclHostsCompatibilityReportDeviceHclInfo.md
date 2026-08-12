# Vcenter.Automation.OpenApi.Model.EsxHclHostsCompatibilityReportDeviceHclInfo
This Esx.Hcl.Hosts.CompatibilityReport.DeviceHclInfo schema contains properties that describe a PCI device of a given ESXi host and its compatibility information.    If there are multiple PCI devices of the same type on the host each one will be listed in separate instance of this class.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Compatibility** | **string** | Indicates compatibility status of the PCI device.  Possible values:   - &#x60;COMPATIBLE&#x60;: When given hardware is certified for the specified ESXi release but no validation of the software of this hardware is performed.   - &#x60;INCOMPATIBLE&#x60;: When given hardware is not certified for the specified ESXi release.   - &#x60;UNAVAILABLE&#x60;: When there is no information about specified hardware.   - &#x60;CERTIFIED&#x60;: When given hardware is certified for the specified ESXi release. Its software is also validated and it is also certified.   - &#x60;NOT_CERTIFIED&#x60;: When given hardware is certified for the specified ESXi release. Its software is also validated and it is not certified.   For more information see: *Esx.Hcl.CompatibilityStatus*. | 
**Device** | [**EsxHclPCIDevice**](EsxHclPCIDevice.md) | Information about the PCI device. | 
**DeviceConstraints** | [**List&lt;EsxHclHostsCompatibilityReportDeviceConstraint&gt;**](EsxHclHostsCompatibilityReportDeviceConstraint.md) | Lists the constraints the target ESXi release has for this PCI device  If missing or &#x60;null&#x60; no constraints are present as PCI device is either not compatible or compatibility information is not found. | [optional] 
**SupportedReleases** | **List&lt;string&gt;** | Provides information about supported releases for this device.  If missing or &#x60;null&#x60; device is compatible with the given target release. | [optional] 
**VcgLink** | **string** | Provides link to the VMware Compatibility Guide for further information on the compatibility.  If missing or &#x60;null&#x60; there is no VMware Compatibility link available as this is device used by VSAN. | [optional] 
**Notes** | [**List&lt;VapiStdLocalizableMessage&gt;**](VapiStdLocalizableMessage.md) | Information that needs to be taken into account when considering this device hcl.  Only set if there is any information reported. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

