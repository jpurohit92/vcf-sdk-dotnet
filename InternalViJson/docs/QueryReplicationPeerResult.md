# Vcenter.ViJson.OpenApi.Model.QueryReplicationPeerResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SourceDomain** | [**FaultDomainId**](FaultDomainId.md) | Source fault domain id, must correspond to an id from the input.  | 
**TargetDomain** | [**List&lt;FaultDomainId&gt;**](FaultDomainId.md) | Target fault domains for the given source, fault domain ID&#39;s are globally unique.  There can be one or more target domains for a given source.  | [optional] 
**Error** | [**List&lt;MethodFault&gt;**](MethodFault.md) | Error must be set when targetDomain field is not set.  | [optional] 
**Warning** | [**List&lt;MethodFault&gt;**](MethodFault.md) | Optional warning messages.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

