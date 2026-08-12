# Vcenter.ViJson.OpenApi.Model.VsanQuerySpaceUsageRequestType
The parameters of *VsanSpaceReportSystem.VsanQuerySpaceUsage*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | vSAN cluster  ***Required privileges:*** System.Read  Refers instance of *ComputeResource*.  | 
**StoragePolicies** | [**List&lt;VirtualMachineProfileSpec&gt;**](VirtualMachineProfileSpec.md) | Storage policies specified to calculate what-if capacity of the cluster vSAN datastore. Default value is None  | [optional] 
**WhatifCapacityOnly** | **bool** | Flag indicates if the API is called only for getting vSAN datastore physical capacity and what-if capacity. Default value is False, which returns the vSAN space usage including the space usage overview and the space usage breakdown according to vSAN object type. When it is True, the API only returns the vSAN datastore physical capacity and what-if capacity under given storage policies.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

