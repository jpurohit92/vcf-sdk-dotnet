# Vcenter.Automation.OpenApi.Model.VcenterVMStoragePlacementSpec
The Vcenter.VM.StoragePlacementSpec schema contains information used to store a virtual machine's files.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Datastore** | **string** | Datastore on which the virtual machine&#39;s configuration state should be stored. This datastore will also be used for any virtual disks that are created as part of the virtual machine creation operation.  This property is currently required. In the future, if this property is missing or &#x60;null&#x60;, the system will attempt to choose suitable storage for the virtual machine; if storage cannot be chosen, the virtual machine creation operation will fail.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;Datastore&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;Datastore&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

