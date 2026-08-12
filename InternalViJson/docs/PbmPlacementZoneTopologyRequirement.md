# Vcenter.ViJson.OpenApi.Model.PbmPlacementZoneTopologyRequirement

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProfileId** | [**PbmProfileId**](PbmProfileId.md) | Reference to the capability profile being used as a requirement  | 
**Clusters** | [**List&lt;PbmServerObjectRef&gt;**](PbmServerObjectRef.md) | References of Cluster server objects belonging to a &#x60;AvailabilityZone&#x60;.  i.e. each referenced cluster must be tagged with a zone as this constraint is intended for scenarios where zone-specific behavior is required. Cluster which is not associated with any zone is not allowed in the input when using this constraint. Other type of server objects such as VirtualMachine are not allowed either. This field must be set to a non-empty array of cluster references, otherwise compatibility check fails.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

