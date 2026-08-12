# Vcenter.Automation.OpenApi.Model.VcenterGuestCustomizationSpec
The Vcenter.Guest.CustomizationSpec schema contains information required to customize a virtual machine when deploying it or migrating it to a new host.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConfigurationSpec** | [**VcenterGuestConfigurationSpec**](VcenterGuestConfigurationSpec.md) | Settings to be applied to the guest during the customization.  This property was added in __vSphere API 7.0.0.0__. | 
**GlobalDnsSettings** | [**VcenterGuestGlobalDNSSettings**](VcenterGuestGlobalDNSSettings.md) | Global DNS settings constitute the DNS settings that are not specific to a particular virtual network adapter.  This property was added in __vSphere API 7.0.0.0__. | 
**Interfaces** | [**List&lt;VcenterGuestAdapterMapping&gt;**](VcenterGuestAdapterMapping.md) | IP settings that are specific to a particular virtual network adapter. The *Vcenter.Guest.AdapterMapping* schema maps a network adapter&#39;s MAC address to its *Vcenter.Guest.IPSettings*. May be empty if there are no network adapters, else should match number of network adapters configured for the VM.  This property was added in __vSphere API 7.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

