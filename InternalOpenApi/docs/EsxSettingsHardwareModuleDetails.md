# Vcenter.Automation.OpenApi.Model.EsxSettingsHardwareModuleDetails
The Esx.Settings.HardwareModuleDetails schema contains information that provide more details about the a hardware module (e.g. BIOS, PCI device).  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ComponentClass** | **string** | Class of module (BIOS, PCI Device, non-PCI hardware, etc.)  Possible values:   - &#x60;SYSTEM_BIOS&#x60;: System BIOS   - &#x60;PCI_DEVICE&#x60;: PCI device   - &#x60;OTHER&#x60;: Other (non-PCI) hardware   For more information see: *Esx.Settings.HardwareModuleClass*.  This property was added in __vSphere API 7.0.0.0__. | 
**Description** | **string** | Descipription of the hardware module (e.g. \&quot;System BIOS\&quot; or \&quot;Frobozz 100Gb NIC\&quot;).  This property was added in __vSphere API 7.0.0.0__.  missing or &#x60;null&#x60; if description is not specified. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

