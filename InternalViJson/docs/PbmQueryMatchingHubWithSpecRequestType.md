# Vcenter.ViJson.OpenApi.Model.PbmQueryMatchingHubWithSpecRequestType
The parameters of *PbmPlacementSolver.PbmQueryMatchingHubWithSpec*.  This structure may be used only with operations rendered under `/pbm`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HubsToSearch** | [**List&lt;PbmPlacementHub&gt;**](PbmPlacementHub.md) | Candidate list of hubs, either datastores or storage pods or a mix. If this parameter is not specified, the Server uses all of the datastores and storage pods for placement compatibility checking.  | [optional] 
**CreateSpec** | [**PbmCapabilityProfileCreateSpec**](PbmCapabilityProfileCreateSpec.md) | Storage profile creation specification.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

