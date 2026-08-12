# Vcenter.Automation.OpenApi.Model.VcenterGuestCustomizationSpecsInfo
The Vcenter.Guest.CustomizationSpecs.Info schema describes a guest customization specification and the timestamp when it was last modified. This is returned by the *GET /vcenter/guest/customization-specs/{name}* operation.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LastModified** | **DateTime** | Time when the specification was last modified.  This property was added in __vSphere API 7.0.0.0__. | 
**Spec** | [**VcenterGuestCustomizationSpecsSpec**](VcenterGuestCustomizationSpecsSpec.md) | The Spec object including specification and metadata information.  This property was added in __vSphere API 7.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

