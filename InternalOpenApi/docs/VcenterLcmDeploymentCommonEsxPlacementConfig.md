# Vcenter.Automation.OpenApi.Model.VcenterLcmDeploymentCommonEsxPlacementConfig
The Vcenter.Lcm.Deployment.Common.EsxPlacementConfig schema contains configuration of ESX placement of the target appliance.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DatastoreName** | **string** | The datastore on which to store the files of the appliance. This value has to be either a specific datastore name, or a specific datastore in a datastore cluster. The datastore must be accessible from the ESX host.  This property was added in __vSphere API 9.0.0.0__. | 
**NetworkName** | **string** | The network of the ESX host to which the new appliance should connect. Omit this parameter if the ESX host has one network.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60; and there is only one network configured, it will be used. | [optional] 
**ResourcePoolPath** | **string** | The path to the resource pool on the ESX host in which the appliance will be deployed.  This property was added in __vSphere API 9.0.0.0__.  Not applicable when not in resource pool | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

