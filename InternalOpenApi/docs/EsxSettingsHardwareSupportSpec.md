# Vcenter.Automation.OpenApi.Model.EsxSettingsHardwareSupportSpec
The Esx.Settings.HardwareSupportSpec schema contains properties to describe the desired Hardware Support Package (HSP) configured for a cluster.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Packages** | [**Dictionary&lt;string, EsxSettingsHardwareSupportPackageSpec&gt;**](EsxSettingsHardwareSupportPackageSpec.md) | Map of Hardware Support Packages (HSPs) for the cluster. The key is the Hardware Support Manager (HSM) name and the value is the specification detailing the HSP configured for that HSM.  This property was added in __vSphere API 7.0.0.0__.  When clients pass a value of this schema as a parameter, the key in the property map must be an identifier for the resource type: &#x60;com.vmware.esx.setting.hardware_support.manager&#x60;. When operations return a value of this schema as a response, the key in the property map will be an identifier for the resource type: &#x60;com.vmware.esx.setting.hardware_support.manager&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

