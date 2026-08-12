# Vcenter.Automation.OpenApi.Model.EsxHclHostsCompatibilityReportDeviceConstraint
This Esx.Hcl.Hosts.CompatibilityReport.DeviceConstraint schema contains properties that describe pair of driver and firmware that are supported for a given PCI device and ESXi release.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Driver** | [**EsxHclDriver**](EsxHclDriver.md) | The driver information about the constraint. | 
**Firmware** | [**EsxHclFirmware**](EsxHclFirmware.md) | The firmware information about the constraint.  If missing or &#x60;null&#x60; there is no firmware restriction on the driver to work with that release. | [optional] 
**Notes** | [**List&lt;VapiStdLocalizableMessage&gt;**](VapiStdLocalizableMessage.md) | Any information that should be taken into account when reviewing the device constraint. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

