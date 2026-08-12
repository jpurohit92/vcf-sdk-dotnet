# Vcenter.Automation.OpenApi.Model.VcenterGuestCustomizationSpecsSpec
The Vcenter.Guest.CustomizationSpecs.Spec schema contains the specification information and specification object. This is passed to the *PUT /vcenter/guest/customization-specs/{name}* operation.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Fingerprint** | **string** | The fingerprint is a unique identifier for a given version of the configuration. Each change to the configuration will update this value. A client cannot change this value. If specified when updating a specification, the changes will only be applied if the current fingerprint matches the specified fingerprint. This field can be used to guard against updates that has happened between the specification content was read and until it is applied.  This property was added in __vSphere API 7.0.0.0__. | 
**Spec** | [**VcenterGuestCustomizationSpec**](VcenterGuestCustomizationSpec.md) | The specification object.  This property was added in __vSphere API 7.0.0.0__. | 
**Description** | **string** | Description of the specification.  This property was added in __vSphere API 7.0.0.0__. | 
**Name** | **string** | Name of the specification.  This property was added in __vSphere API 7.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

