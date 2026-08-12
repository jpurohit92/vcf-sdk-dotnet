# Vcenter.ViJson.OpenApi.Model.InsufficientNetworkResourcePoolCapacity

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DvsName** | **string** | Distributed Virtual Switch containing the resource pool having insufficient network bandwidth.  | 
**DvsUuid** | **string** | UUID of the distributed Virtual Switch containing the resource pool having insufficient network bandwidth.  | 
**ResourcePoolKey** | **string** | Key of the resource pool on which network bandwidth is requested.  | 
**Available** | **long** | Network bandwidth available (in MBs) in the requested resource pool.  | 
**Requested** | **long** | Network bandwidth amount requested (in MBs).  | 
**Device** | **List&lt;string&gt;** | List of network devices that are requesting or already have requested bandwidth on the network resource pool.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

