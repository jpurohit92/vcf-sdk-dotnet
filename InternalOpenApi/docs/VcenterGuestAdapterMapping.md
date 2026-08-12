# Vcenter.Automation.OpenApi.Model.VcenterGuestAdapterMapping
The Vcenter.Guest.AdapterMapping schema specifies the association between a virtual network adapter and its IP settings.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MacAddress** | **string** | The MAC address of a network adapter being customized.    In vSphere 7.0 series, the MAC addresses must be specified in the ascending order of pciSlotNumber, otherwise a MAC address mismatch error will be reported. For further details, see the https://kb.vmware.com/s/article/87648     This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, the customization process maps the the settings from the list of AdapterMappings.IPSettings in the *Vcenter.Guest.CustomizationSpec.interfaces* to the virtual machine&#39;s network adapters, in PCI slot order. The first virtual network adapter on the PCI bus is assigned interfaces[0].IPSettings, the second adapter is assigned interfaces[1].IPSettings, and so on. | [optional] 
**Adapter** | [**VcenterGuestIPSettings**](VcenterGuestIPSettings.md) | The IP settings for the associated virtual network adapter.  This property was added in __vSphere API 7.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

