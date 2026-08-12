# Vcenter.Automation.OpenApi.Model.VcenterDatacenterCreateSpec
The Vcenter.Datacenter.CreateSpec schema defines the information used to create a datacenter.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the datacenter to be created. | 
**Folder** | **string** | Datacenter folder in which the new datacenter should be created.  This property is currently required. In the future, if this property is missing or &#x60;null&#x60;, the system will attempt to choose a suitable folder for the datacenter; if a folder cannot be chosen, the datacenter creation operation will fail.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;Folder&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;Folder&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

