# Vcenter.ViJson.OpenApi.Model.ConcurrentAccess
A ConcurrentAccess fault is thrown when an operation fails because another operation has modified the datastructure.  For non-transactional operations, such as a recursive delete of a subtree of the inventory, the operation might fail with ConcurrentAccess if another thread has added a new entity to the hierarchy. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

