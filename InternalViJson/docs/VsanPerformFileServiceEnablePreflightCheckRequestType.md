# Vcenter.ViJson.OpenApi.Model.VsanPerformFileServiceEnablePreflightCheckRequestType
The parameters of *VsanFileServiceSystem.VsanPerformFileServiceEnablePreflightCheck*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The target cluster to perform preflight check.  ***Required privileges:*** System.Read  Refers instance of *ClusterComputeResource*.  | 
**DomainConfig** | [**VsanFileServiceDomainConfig**](VsanFileServiceDomainConfig.md) | The domain configuration to be validated. If not specified, the validation for the domain will be skipped.  | [optional] 
**Network** | [**ManagedObjectReference**](ManagedObjectReference.md) | The network which will be used for fs containers  Refers instance of *Network*.  | [optional] 
**Scope** | **string** | The scope that preflight check will cover. Valid inputs are listed in the *VsanFileServicePreflightCheckScope_enum* field. Defaults to \&quot;basic\&quot;.  | [optional] 
**DomainUuid** | **string** | The file service domain UUID. It is required when the advanced preflight check is performed on an existing domain. If a new file service domain is to be created, leave it empty.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

