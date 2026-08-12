# Vcenter.ViJson.OpenApi.Model.PbmCheckRequirementsRequestType
The parameters of *PbmPlacementSolver.PbmCheckRequirements*.  This structure may be used only with operations rendered under `/pbm`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HubsToSearch** | [**List&lt;PbmPlacementHub&gt;**](PbmPlacementHub.md) | Candidate list of hubs, either datastores or storage pods or a mix. If this parameter is not specified, the Server uses all of the datastores and storage pods for placement compatibility checking.  | [optional] 
**PlacementSubjectRef** | [**PbmServerObjectRef**](PbmServerObjectRef.md) | reference to the object being placed. Should be null when a new object is being provisioned. Should be specified when placement compatibility is being checked for an existing object. Supported objects are *virtualMachine*, *virtualMachineAndDisks*, *virtualDiskId*, *virtualDiskUUID*  | [optional] 
**PlacementSubjectRequirement** | [**List&lt;PbmPlacementRequirement&gt;**](PbmPlacementRequirement.md) | Requirements including the policy requirements, compute requirements and capacity requirements. It is invalid to specify no requirements. It is also invalid to specify duplicate requirements or multiple conflicting requirements such as specifying both *PbmPlacementCapabilityConstraintsRequirement* and *PbmPlacementCapabilityProfileRequirement*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

