# Vcenter.Automation.OpenApi.Model.VcenterOvfLibraryItemDeployableIdentity
The Vcenter.Ovf.LibraryItem.DeployableIdentity schema describes the resource created by a deployment, or the source resource from which library item can be created, by specifying its resource type and resource identifier.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Type of the deployable resource.  When clients pass a value of this schema as a parameter, the property must be one of &#x60;VirtualMachine&#x60; or &#x60;VirtualApp&#x60;. When operations return a value of this schema as a response, the property will be one of &#x60;VirtualMachine&#x60; or &#x60;VirtualApp&#x60;. | 
**Id** | **string** | Identifier of the deployable resource.  When clients pass a value of this schema as a parameter, the property must be an identifier for one of these resource types: &#x60;VirtualMachine&#x60; or &#x60;VirtualApp&#x60;. When operations return a value of this schema as a response, the property will be an identifier for one of these resource types: &#x60;VirtualMachine&#x60; or &#x60;VirtualApp&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

