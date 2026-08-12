# Vcenter.ViJson.OpenApi.Model.CustomizationAdapterMapping

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MacAddress** | **string** | The MAC address of a network adapter being customized.  The client cannot change this value because the guest operating system has no control over the MAC address of a virtual network adapter.  This property is optional. If it is not included, the customization process maps the settings from the list of AdapterMappings.IPSettings in the Specification.nicSettingMap to the virtual machine&#39;s network adapters, in PCI slot order. The first virtual network adapter on the PCI bus is assigned nicSettingMap\\[0\\].IPSettings, the second adapter is assigned nicSettingMap\\[1\\].IPSettings, and so on.  In vSphere 7.0 series, the MAC addresses must be specified in the ascending order of pciSlotNumber, otherwise a MAC address mismatch error will be reported. For further details, see the https://kb.vmware.com/s/article/87648  | [optional] 
**Adapter** | [**CustomizationIPSettings**](CustomizationIPSettings.md) | The IP settings for the associated virtual network adapter.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

