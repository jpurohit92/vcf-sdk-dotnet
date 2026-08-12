# Vcenter.ViJson.OpenApi.Model.InsufficientFailoverResourcesFault
This is thrown if an operation would violate the configured failover level of a HA cluster.  In a HA cluster, virtual machines provide high availability by moving among physical machines in the event of a failure. HA Admission Control ensures that the total resource requirements for the set of virtual machines in a HA cluster does not exceed the resources that would be available in the worst-case scenario failure. If HA Admission Control is not used, physical machines may have insufficient resources to provide the expected level of service.  This fault indicates that the virtual machine operation you attempted would have created a situation where the remaining physical machines would not meet the needs of the virtual machines in the event of a failure. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

