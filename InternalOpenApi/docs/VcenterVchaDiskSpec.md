# Vcenter.Automation.OpenApi.Model.VcenterVchaDiskSpec
The Vcenter.Vcha.DiskSpec schema contains information to describe the storage configuration of a vCenter virtual machine.  This schema was added in __vSphere API 6.7.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Datastore** | **string** | The identifier of the datastore to put all the virtual disks on.  This property was added in __vSphere API 6.7.1__.  This field needs to be set. If missing or &#x60;null&#x60;, then see vim.vm.RelocateSpec.datastore.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;Datastore:VCenter&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;Datastore:VCenter&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

