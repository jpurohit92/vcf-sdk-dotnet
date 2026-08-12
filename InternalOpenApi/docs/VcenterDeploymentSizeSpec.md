# Vcenter.Automation.OpenApi.Model.VcenterDeploymentSizeSpec
The Vcenter.Deployment.Size.Spec schema contains information needed to resize vcenter deployment. For example, targetDeploymentSize, credentials needed to connect to vCenter and so on.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DeploymentSize** | **string** | The desired deployment size of the vcenter. For scale up operation, it can only be a size higher than the current vcenter size.  Possible values:   - &#x60;TINY&#x60;: Tiny appliance with standard storage   - &#x60;TINY_LSTORAGE&#x60;: Tiny appliance with large storage   - &#x60;TINY_XLSTORAGE&#x60;: Tiny appliance with extra large storage   - &#x60;SMALL&#x60;: Small appliance with standard storage   - &#x60;SMALL_LSTORAGE&#x60;: Small appliance with large storage   - &#x60;SMALL_XLSTORAGE&#x60;: Small appliance with extra large storage   - &#x60;MEDIUM&#x60;: Medium appliance with standard storage   - &#x60;MEDIUM_LSTORAGE&#x60;: Medium appliance with large storage   - &#x60;MEDIUM_XLSTORAGE&#x60;: Medium appliance with extra large storage   - &#x60;LARGE&#x60;: Large appliance with standard storage   - &#x60;LARGE_LSTORAGE&#x60;: Large appliance with large storage   - &#x60;LARGE_XLSTORAGE&#x60;: Large appliance with extra large storage   - &#x60;XLARGE&#x60;: Extra Large appliance with standard storage   - &#x60;XLARGE_LSTORAGE&#x60;: Extra Large appliance with Large storage   - &#x60;XLARGE_XLSTORAGE&#x60;: Extra Large appliance with extra large storage   For more information see: *Vcenter.Deployment.DeploymentSize*.  This property was added in __vSphere API 9.1.0.0__. | 
**Connection** | [**VcenterDeploymentSizeConnection**](VcenterDeploymentSizeConnection.md) | The connection schema contains the credential details of the container that can be a host or a management vCenter. This container should have the vCenter that is to be resized.  This property was added in __vSphere API 9.1.0.0__. | 
**DeferServiceRestart** | **bool** | The flag to indicate if the restart of vCenter services is to be deferred to a later time.  This property was added in __vSphere API 9.1.0.0__.  This property if missing or &#x60;null&#x60; or set with value false will cause the restart of vCenter services. If set to true , it will not restart the vCenter services | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

