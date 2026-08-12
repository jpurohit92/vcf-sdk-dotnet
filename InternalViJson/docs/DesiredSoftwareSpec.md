# Vcenter.ViJson.OpenApi.Model.DesiredSoftwareSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BaseImageSpec** | [**DesiredSoftwareSpecBaseImageSpec**](DesiredSoftwareSpecBaseImageSpec.md) | Describes a specific base-image spec for the ESX host.  | 
**VendorAddOnSpec** | [**DesiredSoftwareSpecVendorAddOnSpec**](DesiredSoftwareSpecVendorAddOnSpec.md) | Vendor add-on info for desired software spec.  | [optional] 
**Components** | [**List&lt;DesiredSoftwareSpecComponentSpec&gt;**](DesiredSoftwareSpecComponentSpec.md) | Additional components which should be part of the desired software spec.  These components would override the components present in *DesiredSoftwareSpec.vendorAddOnSpec* and *DesiredSoftwareSpec.baseImageSpec*.  ***Since:*** vSphere API Release 7.0.2.0  | [optional] 
**RemovedComponents** | **List&lt;string&gt;** | Components which should not be part of the desired software spec.  These components are not applied on the host.  ***Since:*** vSphere API Release 8.0.3.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

